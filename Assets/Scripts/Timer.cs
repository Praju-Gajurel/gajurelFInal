using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    [SerializeField]

    public Text timerText;

    float timeLeft = PlayerSettings.gameTimer;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time: " + timeLeft.ToString("0");
        if (timeLeft > 120)
        {
            timerText.text = "Time: N/A";
        }
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("4Exit");
            WriteScore.WriteScores();
        }
    }
}
