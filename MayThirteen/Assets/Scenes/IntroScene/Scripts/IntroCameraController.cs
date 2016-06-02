using UnityEngine;
using System.Collections;


public class IntroCameraController : MonoBehaviour
{
    static IntroCameraController _instance;
    public static IntroCameraController Instance { get { return _instance; } }
    PinchZoom _pinchZoom;
    IntroSceneMovement _movement;

    void Awake()
    {

        if (_instance == null)
            _instance = this;
        else if (_instance != this)
        {
            Destroy(gameObject);
        }

        _pinchZoom = GetComponent<PinchZoom>();
        _movement = GetComponent<IntroSceneMovement>();

    }
    // Use this for initialization
    void Start()
    {
        _pinchZoom.enabled = false;
        _movement.enabled = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Physics2D.gravity = -transform.up * 9.81f;
    }
    public void SetCanMove(bool enable)
    {
        _pinchZoom.enabled = enable;
        _movement.enabled = enable;
    }
}
