using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public float Timer;
    public int Seconds;
    public Text TIMER;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        Timer += Time.deltaTime;
        Seconds = (int) (Timer % 60);
        TIMER.text = "TIME:" + Seconds;
    }
}
