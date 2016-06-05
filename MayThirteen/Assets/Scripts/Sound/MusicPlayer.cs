using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
    enum SongType
    {
        LOW,
        MIDDLE,
        HIGH
    }

    public float currentTime;
    private AudioClip currentClip;
    public static MusicPlayer instance;
    public AudioClip[] backgroundMusic;

    string currentScene = "";


    // Use this for initialization
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;



        }
        DontDestroyOnLoad(this.gameObject);
        AudioListener.volume = 0f;
    }
    void Start()
    {
        AudioListener.pause = !PlayerPrefsManager.IsSoundOn();
        AudioListener.volume = 1f;
    }
#if UNITY_EDITOR
    void Update()
    {

        if (currentScene != Application.loadedLevelName)
        {
            currentScene = Application.loadedLevelName;
            CheckLevel();
        }

        currentTime = GetComponent<AudioSource>().time;
    }
#else
	void OnLevelWasLoaded ()
	{
		CheckLevel ();
	}
#endif

    void CheckLevel()
    {
        switch (Application.loadedLevelName)
        {

            case "Credits":
                //RandomSongType (SongType.LOW);
                PlaySong(7);
                break;

            case "Menu":
                PlaySong(0);
                break;
            case "IntroScene":
                PlaySong(0);
                break;
            case "LevelSelectionLobby":

                int levelsDone = PlayerPrefsManager.GetLevelsDone();
                CheckWhichSong(levelsDone + 1);


                break;
            case "Splash":
                break;
            default:
                var currentLevel = PlayerPrefsManager.GetCurrentLevel();
                CheckWhichSong(currentLevel);
                break;
        }

    }
    void CheckWhichSong(int level)
    {
        if (level > 18)
        {
            PlaySong(9);
        }
        else if (level > 16)
        {
            PlaySong(8);
        }
        else if (level > 14)
        {
            PlaySong(7);
        }
        else if (level > 12)
        {
            PlaySong(6);
        }
        else if (level > 10)
        {
            PlaySong(5);
        }
        else if (level > 8)
        {
            PlaySong(4);
        }
        else if (level > 6)
        {
            PlaySong(3);
        }
        else if (level > 4)
        {
            PlaySong(2);
        }
        else if (level > 2)
        {
            PlaySong(1);
        }
        else
        {
            PlaySong(0);
        }
    }
    void PlaySong(int id)
    {
        float timeInSamples = GetComponent<AudioSource>().time;
        AudioSource audioSource = GetComponent<AudioSource>();
        float timeSince = Time.time;
        audioSource.clip = backgroundMusic[id];
        if (audioSource.clip != currentClip)
        {

            currentClip = audioSource.clip;

            audioSource.Play();


            timeSince = Time.time - timeSince;

            audioSource.time = timeInSamples + timeSince;
        }
    }
    void RandomSongType(SongType type)
    {
        switch (type)
        {
            case SongType.LOW:
                PlaySong(Random.Range(0, 3));

                break;

            case SongType.MIDDLE:
                PlaySong(Random.Range(4, 7));

                break;

            case SongType.HIGH:

                PlaySong(Random.Range(8, 9));

                break;
            default:
                break;
        }
    }
}
