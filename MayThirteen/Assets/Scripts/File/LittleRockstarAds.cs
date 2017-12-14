using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class LittleRockstarAds : MonoBehaviour
{
    private readonly string iosGameId = "1007506";
    private readonly string androidGameID = "1007507";

    public static LittleRockstarAds instance;
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
    }
    void Start()
    {
#if UNITY_ANDROID
        Advertisement.Initialize(androidGameID);
#elif UNITY_IOS
        Advertisement.Initialize(iosGameId);
#endif
    }
    public void ShowAds()
    {

        bool showAds = PlayerPrefsManager.AdsEnabled();
        if (!showAds) return;
        if (!Advertisement.IsReady()) return;
        int levelsDone = PlayerPrefsManager.GetLevelsDone();
        if (Random.value < 0.5f && levelsDone >= 5)
        {
            Advertisement.Show();
        }

    }
}
