using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadLowMan()
    {
        SceneManager.LoadScene("Example05 - LowMan");
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("LowMan - EndScene");
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
