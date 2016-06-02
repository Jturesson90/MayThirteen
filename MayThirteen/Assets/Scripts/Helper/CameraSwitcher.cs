using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraSwitcher : MonoBehaviour
{

    private Camera mainCamera;
    private Camera secondaryCamera;

    void Awake()
    {
        mainCamera = Camera.main;
        secondaryCamera = GameObject.FindGameObjectWithTag("Camera2").GetComponent<Camera>();
    }
    void LateUpdate()
    {
        if (SceneManager.GetActiveScene().name.Equals("LevelX"))
        {
            if (!mainCamera.enabled)
            {
                secondaryCamera.enabled = false;
                mainCamera.enabled = true;
            }
            else if (secondaryCamera.enabled)
            {
                secondaryCamera.enabled = false;
            }
            return;
        }

        if (Time.timeScale == 0.0f && mainCamera.enabled)
        {
            secondaryCamera.enabled = true;
            mainCamera.enabled = false;

        }
        else if (Time.timeScale > 0.1f && secondaryCamera.enabled)
        {
            secondaryCamera.enabled = false;
            mainCamera.enabled = true;

        }
    }
}
