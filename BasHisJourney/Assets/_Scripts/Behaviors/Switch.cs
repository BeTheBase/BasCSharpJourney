using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public Sprite SwitchedSprite;
    public SpriteRenderer SpriteRenderer;
    public Transform LerpObject;
    public Text PressEObject;
    public float Amount, LerpSpeed;

    public enum Directions
    {
        Up, Left, Right, Down
    }
    public Directions dir;

    private bool switchBool, e;
    private Vector3 posUp, posLeft, posRight, posDown;

    void Start()
    {
        posUp = LerpObject.position + Vector3.up * Amount;
        posLeft = LerpObject.position + Vector3.left * Amount;
        posRight = LerpObject.position + Vector3.right * Amount;
        posDown = LerpObject.position + Vector3.down * Amount;
    }

    void FixedUpdate()
    {
        if (e && Input.GetKeyDown(KeyCode.E))
        {
            ChangeSprite();
            switchBool = true;
        }

        if (switchBool)
        {
            switch (dir)
            {
                case Directions.Up:
                    LerpObject.position = Vector3.Lerp(LerpObject.position, posUp, LerpSpeed);
                    break;
                case Directions.Left:
                    LerpObject.position = Vector3.Lerp(LerpObject.position, posLeft, LerpSpeed);
                    break;
                case Directions.Right:
                    LerpObject.position = Vector3.Lerp(LerpObject.position, posRight, LerpSpeed);
                    break;
                case Directions.Down:
                    LerpObject.position = Vector3.Lerp(LerpObject.position, posDown, LerpSpeed);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    void ChangeSprite()
    {
        SpriteRenderer.sprite = SwitchedSprite;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if(!e)
                PressEObject.gameObject.SetActive(true);
            e = true; 
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            PressEObject.gameObject.SetActive(false);
        }
    }
}
