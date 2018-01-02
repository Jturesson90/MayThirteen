using UnityEngine;
using System.Collections;
using Drolegames.LittleRockstar.Scenes.Constants;

public class LevelSelectionManager : MonoBehaviour
{
    RockPlayer rockPlayer;
    LittleRockstarAds littleRockstarAds;
    public GameObject backgroundClouds;

    public int showBackgroundCloudsAfterNumLevels = 5;
    void Awake()
    {
        backgroundClouds.SetActive(false);
        int levelsDone = PlayerPrefsManager.GetLevelsDone();
        if (levelsDone >= showBackgroundCloudsAfterNumLevels)
        {
            backgroundClouds.SetActive(true);
        }
        else
        {
            backgroundClouds.SetActive(false);
        }

        littleRockstarAds = GameObject.FindGameObjectWithTag("Ads").GetComponent<LittleRockstarAds>();
        rockPlayer = GameObject.Find("RockPlayer").GetComponent<RockPlayer>();
    }
    void Start()
    {
        LittleRockstarGoogleGame.Instance.ItBegins();
        Invoke("ShowAds", 2f);
        Time.timeScale = 1f;
    }
    public void LoadLevel(string level)
    {
        rockPlayer.SavePosition();
        LevelSwitcher.levelSwitcher.SwitchLevel(level);

    }
    public void LoadMenu()
    {
        LevelSwitcher.levelSwitcher.SwitchLevel(RockstarScenes.Menu);
    }

    private void ShowAds()
    {
        littleRockstarAds.ShowAds();
    }

}
