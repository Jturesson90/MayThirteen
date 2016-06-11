using UnityEngine;
using System.Collections;

public class UIButtonsLevelSelection : MonoBehaviour
{
	public GameObject homeButton;
	public GameObject muteButton;
	public GameObject adButton;
	// Use this for initialization
	void Start ()
	{
		hidePausedButtons ();
	}

	public void showPausedButtons ()
	{
		muteButton.SetActive (true);
		homeButton.SetActive (true);
		#if UNITY_ANDROID
		adButton.SetActive (PlayerPrefsManager.AdsEnabled());
		#endif

	}

	public void hidePausedButtons ()
	{
		#if UNITY_ANDROID
		adButton.SetActive (false);
		#endif
		muteButton.SetActive (false);
		homeButton.SetActive (false);
	}
}
