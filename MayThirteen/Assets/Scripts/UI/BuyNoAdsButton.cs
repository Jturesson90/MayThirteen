using UnityEngine;
using System.Collections;
using CompleteProject;

public class BuyNoAdsButton : MonoBehaviour
{
    public Purchaser purchaser;
    // Use this for initialization
    void Start()
    {
        if (purchaser.HasRemovedAds(gameObject))
        {
            gameObject.SetActive(false);
        }
        //gameObject.SetActive (PlayerPrefsManager.AdsEnabled ());

#if UNITY_IOS
		gameObject.SetActive (false);
#elif UNITY_EDITOR
     //   gameObject.SetActive(true);
#endif
    }
}
