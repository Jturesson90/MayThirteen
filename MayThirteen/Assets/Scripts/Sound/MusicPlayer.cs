using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Drolegames.LittleRockstar.Scenes.Constants;
using System;
using Random = UnityEngine.Random;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    enum SongType
    {
        LOW,
        MIDDLE,
        HIGH
    }

    public float currentTime;
    public static MusicPlayer Instance;
    public AudioClip[] backgroundMusic;

    private AudioClip currentClip;
    AudioSource _audioSource;

    // Use this for initialization
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        DontDestroyOnLoad(gameObject);
        AudioListener.volume = 0f;
        _audioSource = GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnLevelChanged;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelChanged;
    }
    private void OnLevelChanged(Scene scene, LoadSceneMode sceneMode)
    {
        CheckLevel();
    }

    void Start()
    {
        AudioListener.pause = !PlayerPrefsManager.IsSoundOn();
        AudioListener.volume = 1f;
    }
/*#if UNITY_EDITOR
    void Update()
    {
        if (currentScene != SceneManager.GetActiveScene().name)
        {
            currentScene = SceneManager.GetActiveScene().name;
            CheckLevel();
        }

        currentTime = _audioSource.time;
    }
#else
	void OnLevelWasLoaded ()
	{
		CheckLevel ();
	}
#endif*/


    void CheckLevel()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            
            case RockstarScenes.Credits:
                //RandomSongType (SongType.LOW);
                PlaySong(7);
                break;

            case RockstarScenes.Menu:
                PlaySong(0);
                break;
            case RockstarScenes.Tutorial:
                PlaySong(0);
                break;
            case RockstarScenes.Lobby:
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
        float timeInSamples = _audioSource.time;
        float timeSince = Time.time;
        _audioSource.clip = backgroundMusic[id];
        if (_audioSource.clip != currentClip)
        {

            currentClip = _audioSource.clip;

            _audioSource.Play();


            timeSince = Time.time - timeSince;

            _audioSource.time = timeInSamples + timeSince;
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
