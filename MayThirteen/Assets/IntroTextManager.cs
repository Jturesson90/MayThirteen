using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

public class IntroTextManager : MonoBehaviour
{
    [SerializeField]
    Text startText;
    [SerializeField]
    Text endText;

    [SerializeField]
    List<string> startDialog = new List<string>();

    public float textFadeSeconds = 4f;

    Queue<string> startDialogQueue = new Queue<string>();
    public bool ReadyForNextStartDialog = true;
    public bool ReadyForFadeOut = false;
    public bool FadingInEndText = false;

    public string endTextString = "Take care, Little Rockstar";
    private float endingTextFadeIn = 1f;

    public bool StartDialogIsEmpty
    {
        get
        {
            print("StartDialogIsEmpty " + (startDialogQueue.Count < float.Epsilon));
            return startDialogQueue.Count < float.Epsilon;
        }
    }

    public bool DialogDone { get; private set; }
    public bool EndDialogDone { get; private set; }

    void Awake()
    {
        foreach (string s in startDialog)
        {
            startDialogQueue.Enqueue(s);
        }
        startDialog = null;

        SetupTextObjects();
    }

    public void IntroEnding(float delay)
    {
        if (FadingInEndText) return;
        StartCoroutine(ShowEndingText(delay));
    }

    private IEnumerator ShowEndingText(float delay)
    {
        FadingInEndText = true;
        endText.text = endTextString;
        yield return StartCoroutine(WaitForRealSeconds(delay));
        endText.CrossFadeAlpha(1, endingTextFadeIn, false);
        EndDialogDone = true;
    }
    public void FadeOutEndingText()
    {

        StartCoroutine(FadeOutEnding());

    }

    private IEnumerator FadeOutEnding()
    {

        endText.CrossFadeAlpha(0, textFadeSeconds, false);
        yield return StartCoroutine(WaitForRealSeconds(textFadeSeconds));
        PlayerPrefsManager.SetDoneFirstLevel(true);
        SceneManager.LoadScene(3);
    }

    private void SetupTextObjects()
    {
        startText.text = string.Empty;
        endText.text = string.Empty;
        startText.CrossFadeAlpha(0, 0, false);
        endText.CrossFadeAlpha(0, 0, false);
        if (startDialogQueue.Count < float.Epsilon) return;

    }



    // Use this for initialization
    void Start()
    {

    }
    public void NextStartDialog()
    {
        if (!ReadyForNextStartDialog) return;
        StartCoroutine(NextStartText());
    }
    public void NextStartDialog(float delay)
    {
        if (!ReadyForNextStartDialog) return;
        StartCoroutine(NextStartTextWithDelay(delay));
    }

    private IEnumerator NextStartTextWithDelay(float delay)
    {

        yield return StartCoroutine(WaitForRealSeconds(delay));
        StartCoroutine(NextStartText());
    }

    private IEnumerator NextStartText()
    {
        print("NextStartText - start");
        ReadyForNextStartDialog = false;
        ReadyForFadeOut = false;
        startText.text = startDialogQueue.Dequeue();
        startText.CrossFadeAlpha(1, textFadeSeconds, false);
        yield return StartCoroutine(WaitForRealSeconds(textFadeSeconds));
        print("NextStartText - end");
        ReadyForFadeOut = true;

        yield return StartCoroutine(WaitForRealSeconds(textFadeSeconds));
        if (ReadyForFadeOut) FadeOutStartDialog();
    }
    public void FadeOutStartDialog()
    {
        if (!ReadyForFadeOut) return;
        StartCoroutine(FadeOutStartText());
    }
    private IEnumerator FadeOutStartText()
    {
        print("FadeOutStartText - start");
        if (StartDialogIsEmpty) DialogDone = true;
        ReadyForFadeOut = false;
        startText.CrossFadeAlpha(0, textFadeSeconds, false);
        yield return StartCoroutine(WaitForRealSeconds(textFadeSeconds));
        ReadyForNextStartDialog = true;
        print("FadeOutStartText - end" + startDialogQueue.Count + " still left in queue");


        if (!StartDialogIsEmpty)
        {
            NextStartDialog();
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }
    private IEnumerator WaitForRealSeconds(float time)
    {
        float start = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < start + time)
        {
            yield return null;
        }
    }
}
