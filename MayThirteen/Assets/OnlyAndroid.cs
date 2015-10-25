using UnityEngine;
using System.Collections;

public class OnlyAndroid : MonoBehaviour
{

	// Use this for initialization
	void Awake ()
	{
#if !UNITY_ANDROID
		gameObject.SetActive (false);
#endif
	}
}
