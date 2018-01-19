using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public int Time;
    public Text TIMER;

    void Start()
    {
        Time = PlayerPrefs.GetInt("Time");
        Debug.Log(Time);
    }

    void FixedUpdate()
    {
        Time++;


        TIMER.text = "TIME:" + Time;
    }

}
