using UnityEngine;
using System.Collections;

public class IntroSceneLoader : MonoBehaviour
{

    public GameObject gameManager;
    public GameObject UI;
    public GameObject effectsManager;
    void Awake()
    {
        if (IntroSceneManager.Instance == null)
            Instantiate(gameManager);

        if (IntroSceneUI.Instance == null)
            Instantiate(UI);

        if (IntroEffectsManager.Instance == null)
            Instantiate(effectsManager);
    }
}
