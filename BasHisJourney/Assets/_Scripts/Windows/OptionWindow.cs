using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionWindow : GenericWindow
{

    public void Awake()
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
