using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void IntroScene()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void HighScoresScene()
    {
        SceneManager.LoadScene("2HighScores");
    }

    public void GameScene()
    {
        SceneManager.LoadScene("3Game");
    }

    public void ExitScene()
    {
        SceneManager.LoadScene("4Exit");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
