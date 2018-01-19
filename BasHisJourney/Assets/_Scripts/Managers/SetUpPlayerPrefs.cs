using UnityEngine;

public class SetUpPlayerPrefs : MonoBehaviour
{
    TimeCounter timeCounter = new TimeCounter();

    void Awake()
    {
        //PlayerPrefs.SetInt("Time", timeCounter.Time);
    }
}
