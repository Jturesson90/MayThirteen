using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{

	public GameObject CreditText;
	public LevelSwitcher levelSwitcher;

	public float WaitTime = 5f;
	public float TextSpeed = 40f;

	public TextAsset textAsset;

	private bool _pressed = false;
	private float _timeSinceStart = 0f;
	// Use this for initialization
	private RectTransform _textTransform;
	void Start ()
	{
		_timeSinceStart = Time.time;
		SetCreditText ();
		_textTransform = CreditText.GetComponent<Text> ().rectTransform;
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
		_textTransform.anchoredPosition = new Vector2 (_textTransform.anchoredPosition.x, _textTransform.anchoredPosition.y + Time.deltaTime * TextSpeed);
	}
	void SetCreditText ()
	{
		string creditText = GetCreditTextFromResources ();
		CreditText.GetComponent<Text> ().text = creditText;
	}
	string GetCreditTextFromResources ()
	{
		return textAsset.text;
	}
}
