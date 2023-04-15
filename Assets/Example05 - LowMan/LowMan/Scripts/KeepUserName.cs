using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepUserName : MonoBehaviour
{
    public static string userName;
    public InputField userInput;
    public Text userNameInput;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateUserName()
    {
        userName = userNameInput.text;
    }
}
