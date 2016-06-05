using UnityEngine;
using System.Collections;

public class IntroSceneMovement : MonoBehaviour
{
    public float turnSpeed = 80f;
    public float touchOffset = 0.25f;
    // Use this for initialization
    void Start()
    {

    }
    void OnEnable()
    {
        IntroSceneUI.Instance.ShowArrows();
    }
    void OnDisable()
    {
        IntroSceneUI.Instance.HideArrows();
    }
    // Update is called once per frame
    void Update()
    {
#if UNITY_STANDALONE || UNITY_EDITOR
        StandAloneMovement();
#endif
#if UNITY_ANDROID || UNITY_IPHONE
        MobileMovement();
#endif
    }
    void MobileMovement()
    {
        if (Input.touchCount == 2 || Input.touchCount < 1)
            return;

        if (Input.GetTouch(0).position.x < Screen.width * touchOffset)
        {
            transform.Rotate(0, 0, -Time.deltaTime * turnSpeed);

        }
        if (Input.GetTouch(0).position.x > Screen.width * (1 - touchOffset))
        {
            transform.Rotate(0, 0, Time.deltaTime * turnSpeed);

        }

    }
    void StandAloneMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -Time.deltaTime * turnSpeed);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, Time.deltaTime * turnSpeed);

        }
    }
}
