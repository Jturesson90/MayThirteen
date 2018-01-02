using UnityEngine;
using System.Collections;

public class CameraiPadHandler : MonoBehaviour
{

	// Use this for initialization
	public bool NeedFixForIpad = false;

	void Awake ()
	{
		if (!NeedFixForIpad)
			return;
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		float aspect = ((float)Screen.height) / (float)Screen.width;
		if (aspect > 0.7f) {
			z -= 13.5f;
		} else if (aspect > 0.6f) {
			z -= 10f;
		}
		transform.position = new Vector3 (x, y, z);
	}
	
	// Update is called once per frame
}
