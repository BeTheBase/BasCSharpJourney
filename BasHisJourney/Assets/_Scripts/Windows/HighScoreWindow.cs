using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreWindow : GenericWindow
{
    

    public void Awake()
    {
        
    }
     
    void Start()
    {
        
    }

    public override void Open()
    {
        base.Open();
    }

    public override void Close()
    {
        base.Close();

    }

    public void OnNext()
    {
        Manager.Open(0);
    }

}
