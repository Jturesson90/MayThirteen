using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
public class GoogleGameMenuUIHandler : MonoBehaviour
{
	
	LittleRockstarGoogleGame googleGame;
	// Use this for initialization
		
	void Awake ()
	{
			
		googleGame = GameObject.Find ("LittleRockstarGoogleGame").GetComponent<LittleRockstarGoogleGame> ();
#if UNITY_IOS
		gameObject.SetActive (false);
#endif

	}
	public void ShowAchievments ()
	{
		googleGame.ShowAchievements ();
	}
	public void ShowLeaderboard ()
	{
		googleGame.ShowLeaderboard ();
	}

}
