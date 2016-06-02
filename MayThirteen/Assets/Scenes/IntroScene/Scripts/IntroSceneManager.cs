using UnityEngine;
using System.Collections;
using System;

public class IntroSceneManager : MonoBehaviour
{
    public float startTextAfter = 5f;
    private bool _canMove = false;

    private static IntroSceneManager _instance;
    private bool _firstDialogDone;
    private bool _endingDialogDone;

    public static IntroSceneManager Instance
    {
        get
        {
            return _instance;
        }
    }

    public void Ending()
    {
        IntroSceneUI.Instance.Ending();
    }

    public bool Clicked
    {
        set
        {
            OnClick();
        }
    }
    void OnClick()
    {
        IntroSceneUI.Instance.FadeOutDialog();
        if (!_firstDialogDone)
        {
            _firstDialogDone = CheckIfFirstDialogIsDone();
            if (_firstDialogDone)
            {
                DialogDone();
            }
        }
        else if(!_endingDialogDone)
        {
            _endingDialogDone = CheckIfEndingDialogIsDone();
            if (_endingDialogDone)
            {
                EndDialogDone();
            }
        }
    }

    private bool CheckIfEndingDialogIsDone()
    {
        return IntroSceneUI.Instance.CheckEndDialogIsDone();
    }

    private void EndDialogDone()
    {
        IntroSceneUI.Instance.FadeOutEndingText();
    }

    private bool CheckIfFirstDialogIsDone()
    {
        return IntroSceneUI.Instance.CheckDialogIsDone();
    }

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {
        IntroEffectsManager.Instance.StartEarthQuake();
        IntroSceneUI.Instance.StartIntroDialogText(startTextAfter);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Clicked = true;
        }

    }

    public void DialogDone()
    {
        IntroCameraController.Instance.SetCanMove(true);
    }
}
