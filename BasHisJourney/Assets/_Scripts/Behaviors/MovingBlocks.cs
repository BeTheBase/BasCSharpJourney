using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlocks : AreaManager
{
    private int Dir = 1;

    void Update()
    {
        transform.Translate(new Vector3(1,0,0) *Time.deltaTime * Dir * BlockSpeed);
    }

    new void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Reverse")
        {
            Debug.Log("reverse bra");
            Dir *= -1;
        }
//        if (other.gameObject.name == "Player")
//        {
//            other.transform.parent = gameObject.transform;
//        }
    }

    new void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.transform.parent = null;
        }
    }
}
