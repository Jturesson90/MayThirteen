using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class LittleRockstarAds : MonoBehaviour
{
	public static LittleRockstarAds instance;
	// Use this for initialization

	void Awake ()
	{
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;

		}
		DontDestroyOnLoad (this.gameObject);
	}
	void Start ()
	{
		//	Advertisement.Initialize (GAME_ADS_ID);
	}
	public void ShowAds ()
	{
		bool showAds = PlayerPrefsManager.AdsEnabled ();
		if (showAds) {
			if (Advertisement.IsReady ()) {
				if (Random.value < 0.33f) {
					Advertisement.Show ();
				}

			}
		}
	}
}
