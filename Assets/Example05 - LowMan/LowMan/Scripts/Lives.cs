using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public static int livesCount;
    public Text showLives;
    
    // Start is called before the first frame update
    void Start()
    {
        livesCount = 3;
        showLives.text = livesCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        showLives.text = livesCount.ToString();
        if(livesCount < 0)
        {
            ChangeScene.GameOver();
        } 
    }
}
