using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    public Text speedDisplay;
    public Text sizeDisplay;

    void Start()
    {
        sizeDisplay.text = PlayerSettings.size.ToString("f2");
        speedDisplay.text = PlayerSettings.speed.ToString();
    }
}
