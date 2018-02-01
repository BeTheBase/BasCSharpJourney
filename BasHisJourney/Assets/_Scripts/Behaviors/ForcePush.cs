using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePush : AbstractBehavior
{
    public Material LeftNewSprite;
    public Material RightNewSprite;
    public float Speed;
    public GameObject ForceObjectRight, ForceObjectLeft;
    public Transform CurrentShootPosition;

    private bool inRange;

    void Update()
    {
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);

        if (Input.GetKeyDown(KeyCode.F) && inRange)
        {
            if (right)
            {
                Instantiate(ForceObjectRight, CurrentShootPosition.position, Quaternion.identity);
            }
            if (left)
            {
                Instantiate(ForceObjectLeft, CurrentShootPosition.position, Quaternion.identity);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "BreakObj")
        {
            inRange = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "BreakObj")
        {
            inRange = false;
        }
    }
}
