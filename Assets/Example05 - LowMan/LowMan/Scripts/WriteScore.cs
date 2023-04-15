using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class WriteScore : MonoBehaviour
{
    public Text newScore;
    private int numScores = 10;

    public void SaveScore()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        int scores_written = 0;
        string newScore = "999";
        bool newScoreWritten = false;
        string[] writeScores = new string[numScores];

        newScore = Score.score.ToString();

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            if (!newScoreWritten && scores_written < numScores)
            {
                for (int i = 0; i < numScores; i++)
                {
                    if (Convert.ToInt32(newScore) > Convert.ToInt32(fields[i]))
                    {
                        writeScores[scores_written] = fields[i];
                        newScoreWritten = true;
                        scores_written += 1;
                    }
                    if (scores_written < numScores)
                    {
                        writeScores[scores_written] = fields[i];
                        scores_written += 1;
                    }
                }
                
            }
        }
        reader.Close();
        StreamWriter writer = new StreamWriter(path);

        for (int x = 0; x < scores_written; x++)
        {
            writer.WriteLine(writeScores[x]);
        }
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

    }
}
