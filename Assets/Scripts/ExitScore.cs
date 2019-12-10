using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ExitScore : MonoBehaviour
{
    public Text CurrentScoreDisplay;
    public Text HighScoresDisplay;

    int scorerNumber = 1;

    void Start()
    {
        int playerScore;
        string playerName;
        string[] readText;
        string[] fields;

        CurrentScoreDisplay.text = "Player: " + ReadScore.PlayerName + "\nScore: " + ScoreKeeper.newScore + "\nLives: " + LivesTracker.lives;

        string path = "Assets/scores.txt";

        readText = File.ReadAllLines(path);

        foreach (string line in readText)
        {
            fields = line.Split(',');
            playerScore = Convert.ToInt32(fields[0]);
            playerName = fields[1];
            if (scorerNumber <= 10)
            {
                HighScoresDisplay.text += scorerNumber + ". " + playerName + " - " + playerScore + "\n";
                scorerNumber++;
            }
        }
    }
}
