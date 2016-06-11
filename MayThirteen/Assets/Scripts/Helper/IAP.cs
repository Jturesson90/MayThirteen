using UnityEngine;
using System.Collections;

public class IAP
{

    private static IAP _instance;

    public static IAP Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new IAP();
            }
            return _instance;
        }
    }

    public string AdsRemovalCost { get; set; }
    public bool RemovedAds { get; set; }
}
