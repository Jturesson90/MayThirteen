using UnityEngine;
using System.Collections;
//using CompleteProject;
using UnityEngine.UI;
public class BuyNoAdsButton : MonoBehaviour
{
    private static BuyNoAdsButton _instance;
    [SerializeField]
    private string _text = "";
    public static BuyNoAdsButton Instance
    {
        get
        {
            return _instance;
        }
    }

    public Text text;
    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
        {
            Destroy(gameObject);
        }

        gameObject.SetActive(PlayerPrefsManager.AdsEnabled());

    }
    public void GiveLocalPriceTag(string s)
    {
        if (text != null)
        {
            text.text = _text + s;
        }
    }
    public void SetActive(bool active)
    {
        gameObject.SetActive(active);

    }
    public void BuyNoAds()
    {
       // Purchaser.Instance.BuyNoAds();
    }
    void Start()
    {
        //if (purchaser.HasRemovedAds(gameObject))
        //{
        //    //gameObject.SetActive(false);
        //}


#if UNITY_IOS
		gameObject.SetActive (false);
#elif UNITY_EDITOR
        //   gameObject.SetActive(true);
#endif
        GiveLocalPriceTag(IAP.Instance.AdsRemovalCost);
        //  print("Purchaser.Instance.isActiveAndEnabled "+Purchaser.Instance.isActiveAndEnabled);
        print("PlayerPrefsManager.AdsEnabled() " + PlayerPrefsManager.AdsEnabled());
        /*   if (Purchaser.Instance.isActiveAndEnabled && PlayerPrefsManager.AdsEnabled())
           {
               SetActive(true);
           }
           else
           {
               SetActive(false);
           }*/
    }
}
