using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PauseButton : MonoBehaviour
{
    public Sprite pauseSprite;
    public Sprite playSprite;
    public Image image;

    public List<GameObject> gosThatOnlyBeShownIfPaused;

    void Awake()
    {
        OnPlay();
    }

    public void TogglePause()
    {
        if (Time.timeScale == 0)
        {
            image.sprite = pauseSprite;
            Time.timeScale = 1;
            OnPlay();
        }
        else
        {
            image.sprite = playSprite;
            Time.timeScale = 0;
            OnPause();
        }
    }

    public void OnPause()
    {
        ChangePausedGOActivation(true);
    }
    public void OnPlay()
    {
        ChangePausedGOActivation(false);
    }

    void ChangePausedGOActivation(bool activate)
    {
        foreach (var go in gosThatOnlyBeShownIfPaused)
        {
            go.SetActive(activate);
        }
    }
}
