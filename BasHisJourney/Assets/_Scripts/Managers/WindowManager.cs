using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    public GameObject HighScore;
    public Text HighScoreText;
    public GenericWindow[] Windows;

    private TimeCounter timeCounter;
    private int _bestTime;
    public int CurrentWindowID;
    public int DefaultWindowID;

    public GenericWindow GetWindow(int value)
    {
        return Windows[value];
    }

    private void ToggleVisability(int value)
    {
        var total = Windows.Length;

        for (int i = 0; i < total; i++)
        {
            var window = Windows[i];
            if(i == value)
                window.Open();
            else if(window.gameObject.activeSelf)
                window.Close();
        }
    }

    public GenericWindow Open(int value)
    {
        if (value < 0 || value >= Windows.Length)
            return null;

        CurrentWindowID = value;

        ToggleVisability(CurrentWindowID);

        return GetWindow(CurrentWindowID);
    }

    void Start()
    {
        var txt = GameObject.Find("TIMERcanvas");
        timeCounter = txt.GetComponent<TimeCounter>();

        if (timeCounter.Seconds > 0)
        {
            _bestTime = PlayerPrefs.GetInt("Time");

            if (timeCounter.Seconds < _bestTime)
            {
                //New HighScore
                _bestTime = timeCounter.Seconds;
                PlayerPrefs.SetInt("Time", _bestTime);
            }
        }
        else
        {
            _bestTime = PlayerPrefs.GetInt("Time");
        }

        HighScoreText.text = "NEW HIGHSCORE:" + _bestTime + "!";

        GenericWindow.Manager = this;
        Open(DefaultWindowID);
    }
}
