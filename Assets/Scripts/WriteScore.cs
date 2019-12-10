using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class WriteScore : MonoBehaviour
{
    int scorerNumber = 1;




    public static void WriteScores()
    {

    string path = "Assets/Resources/Scores.txt";

        if (File.Exists(path))
        {
            string[] createText = { ReadScore.PlayerName + " " + ScoreKeeper.newScore.ToString() };
            File.AppendAllLines(path, createText);
        }
        else
        {
            Debug.Log("File does not exist.");
        }
    }
}
