using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;
    public Text pausedText;
    public InputField username;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // escape key pauses AND resumes
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        pausedText.gameObject.SetActive(true);
        username.gameObject.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
        pausedText.gameObject.SetActive(false);
        username.gameObject.SetActive(false);
    }
}