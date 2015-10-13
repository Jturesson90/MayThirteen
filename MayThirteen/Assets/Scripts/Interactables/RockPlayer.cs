using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer),typeof(Rigidbody2D))]
public class RockPlayer : MonoBehaviour
{
		
	public GameObject brokenStone;
	[Range(0f,1f)]
	public float
		volume = 1f;
	[Header("Stone SFX")]
	public AudioClip[]
		softCollisions;
	public AudioClip[]
		hardCollisions;
	public AudioClip[]
		destroy;
	AudioSource _audio;

	private float lowPitchRange = .5F;
	private float highPitchRange = 1F;
	private float velToVol = .2F;
	private float velocityClipSplit = 10F;

	void Awake ()
	{
		_audio = GetComponent<AudioSource> ();
	}
	//private SpriteRenderer rend;
	void Start ()
	{
		if (Application.loadedLevelName == "LevelSelectionLobby") {
			SetToSavedPosition ();
		}
				
	}
	public void SetToSavedPosition ()
	{
		if (PlayerPrefsManager.HasStoneKey ()) {
			float xPos = PlayerPrefsManager.GetStonePositionX ();
			float yPos = PlayerPrefsManager.GetStonePositionY ();
			float zPos = transform.position.z;
			Vector3 newStartPosition = new Vector3 (xPos, yPos, zPos);
			transform.position = newStartPosition;
		}	
	}
	public void SavePosition ()
	{
		PlayerPrefsManager.SetStonePosition (transform.position.x, transform.position.y);
			
	}
	public void Win ()
	{
		print ("YOU WON");
	}
		
	public void Die ()
	{
		GetComponent<Renderer> ().enabled = false;
		GetComponent<Rigidbody2D> ().isKinematic = true;
				
		Component halo = GetComponent ("Halo");
		if (halo != null) {
			halo.GetType ().GetProperty ("enabled").SetValue (halo, false, null);
		}
		InstantiateBrokenStone ();
		GetComponent<Collider2D> ().enabled = false;

		_audio.pitch = Random.Range (lowPitchRange, highPitchRange);
		_audio.PlayOneShot (destroy [Random.Range (0, destroy.Length - 1)], volume);

	}
	private void InstantiateBrokenStone ()
	{
		GameObject.Instantiate (brokenStone, transform.position, Quaternion.identity);
				
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		_audio.pitch = Random.Range (lowPitchRange, highPitchRange);
		float hitVol = coll.relativeVelocity.magnitude * velToVol;
		if (coll.relativeVelocity.magnitude < velocityClipSplit)
			_audio.PlayOneShot (softCollisions [Random.Range (0, softCollisions.Length - 1)], hitVol * volume);
		else 
			_audio.PlayOneShot (hardCollisions [Random.Range (0, hardCollisions.Length - 1)], hitVol * volume);
		
	}

}
