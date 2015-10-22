using UnityEngine;
using System.Collections;

public class LevelSelectionEnding : MonoBehaviour
{



	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag.Equals ("Ball")) {
			LevelSwitcher.levelSwitcher.SwitchLevel ("Credits");
		}

	}
}
