using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ReadScore : MonoBehaviour
{
    public Text HighScoreText;
    public InputField NameInputField;

    int scorerNumber = 1;

    public static string PlayerName;

    void Update()
    {
        PlayerName = NameInputField.text;

        string path = "Assets/Resources/Scores.txt";

        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Debug.Log(s);
            HighScoreText.text += "\n" + s;
        }

    }
}

