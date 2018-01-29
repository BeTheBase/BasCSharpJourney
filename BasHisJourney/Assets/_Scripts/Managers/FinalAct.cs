using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAct : MonoBehaviour
{
    public GameObject Unity;
     
    public bool RunClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Unity")
        {
            other.gameObject.transform.SetParent(gameObject.transform);
            RunClip = true;
        }
    }
}
