using UnityEngine;
using System.Collections;

public class IntroEffectsManager : MonoBehaviour
{

    public EarthquakeEffect Earthquake;
    public float earthquakeDuration = 5f;

    private static IntroEffectsManager _instance;

    public static IntroEffectsManager Instance
    {
        get
        {
            return _instance;
        }
    }
    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        
    }

    public void StartEarthQuake()
    {
        if (Earthquake == null) return;
        Earthquake.StartEarthquakeWithLength(earthquakeDuration);
    }


}
