using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text displayScore;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        displayScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        displayScore.text = score.ToString();
    }
}
