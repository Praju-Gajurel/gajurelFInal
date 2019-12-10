using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    public Dropdown SpeedDropDown;
    public Dropdown TimerDropDown;
    public Slider SizeSlider;
    public Text SizeText;

    public static bool toggleButtonBool;
    public static float size = 2f;
    public static float speed = 1f;
    public static float gameTimer = 30f;

    void Update()
    {
        switch (SpeedDropDown.value)
        {
            case 1:
                speed = 1f;
                break;
            case 2:
                speed = 2f;
                break;
            case 3:
                speed = 3f;
                break;
            default:
                speed = 4f;
                break;
        }

        switch (TimerDropDown.value)
        {
            case 1:
                gameTimer = 20f;
                break;
            case 2:
                gameTimer = 40f;
                break;
            case 3:
                gameTimer = 999999999999999999f;
                break;
            default:
                gameTimer = 20f;
                break;
        }

        SizeText.text = SizeSlider.value.ToString("f2");
        size = SizeSlider.value;

    }

    public void ToggleButton(bool toggleButtonBool)
    {
        if (toggleButtonBool == false)
        {
            SizeSlider.gameObject.SetActive(false);
        }
        else
        {
            SizeSlider.gameObject.SetActive(true);
        }
    }
}
