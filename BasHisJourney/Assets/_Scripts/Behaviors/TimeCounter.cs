using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public GameObject GameManager;
    public float Timer;
    public int Seconds;
    public Text TIMER;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        DontDestroyOnLoad(GameManager.transform);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            Debug.Log("1");
            Timer += Time.deltaTime;
            Seconds = (int) (Timer);
            TIMER.text = "TIME:" + Seconds;
            TIMER.CrossFadeAlpha(255, 1, false);
        }
        else
        {
            Debug.Log("2");
            Timer = 0;
            TIMER.CrossFadeAlpha(0,0,false);
        }
    }
}
