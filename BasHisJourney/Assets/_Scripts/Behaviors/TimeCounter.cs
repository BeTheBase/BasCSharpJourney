using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public int Time;
    public Text TIMER;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void FixedUpdate()
    {
        Time++;
        TIMER.text = "TIME:" + Time;
    }
}
