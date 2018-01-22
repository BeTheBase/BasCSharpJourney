using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    public GameObject HighScore;
    public Text HighScoreText;
    public GenericWindow[] Windows;

    private TimeCounter timeCounter = new TimeCounter();
    private int _bestTime = 0;
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
        _bestTime = PlayerPrefs.GetInt("Time");
        Debug.Log(timeCounter.Seconds);
        if (timeCounter.Seconds > 0)
        {
            Debug.Log("1");
            if (timeCounter.Seconds < _bestTime)
            {
                Debug.Log("2");

                //New HighScore
                _bestTime = timeCounter.Seconds;
                PlayerPrefs.SetInt("Time", _bestTime);
            }
        }
        else
        {
            _bestTime = 0;
        }
        Debug.Log("3");

        HighScoreText.text = "NEW HIGHSCORE:" + _bestTime + "!";

        var txt = GameObject.Find("TIMERcanvas");
        //Destroy(txt);
        GenericWindow.Manager = this;
        Open(DefaultWindowID);
    }
}
