using UnityEngine;
using System.Collections;

public class IntroStar : MonoBehaviour
{

    public IntroStoneDoor wall;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            GetComponent<Animation>().Play("PlipAway", PlayMode.StopAll);
            wall.StartStoneWallAnimation();
        }
    }
}
