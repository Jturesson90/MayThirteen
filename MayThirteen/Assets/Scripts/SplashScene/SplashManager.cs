using UnityEngine;
using System.Collections;

public class SplashManager : MonoBehaviour
{
		public float startGameIn = 3f;


		void Start ()
		{
				Invoke ("StartGame", startGameIn);
				Application.targetFrameRate = 60;
		}

		public void StartGame ()
		{
				LevelSwitcher.levelSwitcher.SwitchLevel ("Menu");
				//Application.LoadLevel ("Menu");
		}
}
