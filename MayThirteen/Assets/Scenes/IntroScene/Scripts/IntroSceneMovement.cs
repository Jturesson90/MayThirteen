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
            TurnLeft();

        }
        if (Input.GetTouch(0).position.x > Screen.width * (1 - touchOffset))
        {
            TurnRight();

        }

    }
    void StandAloneMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            TurnLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            TurnRight();
        }
    }
    private void TurnLeft()
    {
        transform.Rotate(0, 0, -Time.deltaTime * turnSpeed);
    }
    private void TurnRight()
    {
        transform.Rotate(0, 0, Time.deltaTime * turnSpeed);
    }
}
