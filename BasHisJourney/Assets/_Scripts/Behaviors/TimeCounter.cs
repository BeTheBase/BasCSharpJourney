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
        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            Debug.Log("1");
            Timer += Time.deltaTime;
            Seconds = (int) (Timer % 60);
            TIMER.text = "TIME:" + Seconds;
        }
        else
        {
            Debug.Log("2");
            Timer = 0;
        }
    }
}
