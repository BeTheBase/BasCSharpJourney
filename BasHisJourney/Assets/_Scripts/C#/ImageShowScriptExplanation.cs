using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageShowScriptExplanation : CSharpPickup
{
    public int Index;

    void Start()
    {
    }

    void OnMouseOver()
    {
        RightScriptImage.sprite = HoverScriptImages[Index];
    }

    void OnMouseExit()
    {
        RightScriptImage.sprite = ScriptImages[SceneIndex];
    }
}
