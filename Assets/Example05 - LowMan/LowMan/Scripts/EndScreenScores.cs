using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class EndScreenScores : MonoBehaviour
{
    public Text playerScore;
    public Text highScores;
    private int numScores = 10; 

    private void Awake()
    {
        playerScore.text = Score.score.ToString();

        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        string[] playerScores = new string[numScores];
        int scores_read = 0;

        highScores.text = ""; // clear the scores box

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream && scores_read < numScores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            highScores.text += fields[0] + "\n";
                //+ fields[1] + "\n" +
                //fields[2] + "\n" + fields[3] + "\n" + fields[4] + "\n" +
                //fields[5] + "\n" + fields[6] + "\n" + fields[7] + "\n" +
                //fields[8] + "\n" + fields[9];
            scores_read += 1;
        }
    }
}
