using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{

	public GameObject CreditText;
	public LevelSwitcher levelSwitcher;

	public float WaitTime = 5f;
	public float TextSpeed = 40f;

	private bool _pressed = false;
	private float _timeSinceStart = 0f;
	// Use this for initialization
	void Start ()
	{
		_timeSinceStart = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			if (!_pressed && (Time.time - _timeSinceStart) > WaitTime) {

				levelSwitcher.SwitchLevel ("Menu");
				_pressed = true;
			}
		}
		var textTransform = CreditText.GetComponent<Text> ().rectTransform;
		textTransform.anchoredPosition = new Vector2 (textTransform.anchoredPosition.x, textTransform.anchoredPosition.y + Time.deltaTime * TextSpeed);
	}
}
