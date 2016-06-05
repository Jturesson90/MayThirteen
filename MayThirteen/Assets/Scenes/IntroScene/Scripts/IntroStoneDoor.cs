using UnityEngine;
using System.Collections;

public class IntroStoneDoor : MonoBehaviour {

    public void StartStoneWallAnimation()
    {
        IntroEffectsManager.Instance.Earthquake.StartEarthquakeWithLength(GetComponent<Animation>().clip.length);
        GetComponent<Animation>().Play();
    }

    public void DisableStoneWall()
    {
        gameObject.SetActive(false);
    }
}
