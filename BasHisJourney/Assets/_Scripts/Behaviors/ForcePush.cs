using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePush : AbstractBehavior
{

    public SpriteRenderer SpriteRenderer;
    public Sprite NewSprite;
    public float Speed;
    public GameObject ForceObjectRight, ForceObjectLeft;
    public Transform BreakableObject;

    private bool inRange;
    private Vector3 currentPos;

    void Start()
    {

    }

    void Update()
    {
        currentPos = new Vector3(transform.position.x, transform.position.y, 2);

        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);

        if (Input.GetKeyDown(KeyCode.F) && inRange)
        {
            if (right)
            {
                Instantiate(ForceObjectRight, currentPos, Quaternion.identity);

                Debug.Log("Right");
            }
            if (left)
            {
                Instantiate(ForceObjectLeft, currentPos, Quaternion.identity);

                Debug.Log("Left");
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
