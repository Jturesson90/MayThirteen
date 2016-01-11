using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class LittleRockstarAds : MonoBehaviour
{
    public static LittleRockstarAds instance;
    // Use this for initialization

    void Awake()
    {
		#if UNITY_IOS
		return;
		#endif
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
    }
    void Start()
    {
        //	Advertisement.Initialize (GAME_ADS_ID);
    }
    public void ShowAds()
    {
		#if !UNITY_IOS
        bool showAds = PlayerPrefsManager.AdsEnabled();
        if (!showAds) return;
        if (!Advertisement.IsReady()) return;
        int levelsDone = PlayerPrefsManager.GetLevelsDone();
        print("ShowAds, LevelsDone: " + levelsDone);
        if (Random.value < 0.5f && levelsDone >= 5)
        {
            Advertisement.Show();
        }
		#endif
    }
}
