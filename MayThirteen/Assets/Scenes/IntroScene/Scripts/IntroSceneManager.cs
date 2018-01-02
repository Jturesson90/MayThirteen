using UnityEngine;
using System.Collections;
using System;

public class IntroSceneManager : MonoBehaviour
{
    public float startTextAfter = 5f;

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

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void Ending()
    {
        IntroSceneUI.Instance.Ending();
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
        else if (!_endingDialogDone)
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


    // Use this for initialization
    void Start()
    {
        IntroEffectsManager.Instance.StartEarthQuake();
        IntroSceneUI.Instance.StartIntroDialogText(startTextAfter);
    }

    // Update is called once per frame
    void Update()
    {
        CheckForClick();

    }

    void CheckForClick()
    {
        if (!Input.GetMouseButtonDown(0))
            return;
        OnClick();
    }

    public void DialogDone()
    {
        IntroCameraController.Instance.SetCanMove(true);
    }
}
