using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class IntroSceneUI : MonoBehaviour
{


    private static IntroSceneUI _instance;
    public IntroTextManager textManager;
    public GameObject arrows;

    public RawImage fader;
    [SerializeField]
    private float fadeInSeconds = 2f;
    [SerializeField]
    private float fadeOutSeconds = 2f;
    private bool _startDialogDone;


    public static IntroSceneUI Instance
    {
        get
        {
            return _instance;
        }
    }

    public void Ending()
    {
        FadeOut();
        textManager.IntroEnding(fadeOutSeconds);
    }

    void Awake()
    {
        if (_instance == null)
            _instance = this;
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        HideArrows();
    }

    public bool CheckDialogIsDone()
    {
        return textManager.DialogDone;
    }
    // Use this for initialization
    void Start()
    {
        FadeIn();
    }

    public void StartIntroDialogText(float delay)
    {
        print("IntroSceneUI.StartIntroDialogText");
        if (textManager == null) return;
        textManager.NextStartDialog(delay);

    }

    public bool CheckEndDialogIsDone()
    {
        return textManager.EndDialogDone;
    }

    public void FadeOutEndingText()
    {
        textManager.FadeOutEndingText();
    }

    public void FadeOutDialog()
    {
        if (textManager == null) return;
        textManager.FadeOutStartDialog();
    }


    public void FadeIn()
    {
        fader.GetComponent<RawImage>().CrossFadeAlpha(0, fadeInSeconds, false);
    }
    public void FadeOut()
    {
        fader.GetComponent<RawImage>().CrossFadeAlpha(1f, fadeOutSeconds, false);
    }
    public void ShowArrows()
    {
        if (arrows != null)
            arrows.SetActive(true);
    }
    public void HideArrows()
    {
        if (arrows != null)
            arrows.SetActive(false);
    }
}
