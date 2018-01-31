using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceShoot : ForcePush
{
    private float speed = 6f;

    void Awake()
    {
        speed = Speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(1 * speed,0,0);
        Destroy(transform.gameObject, 2f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "BreakObj")
        {
            Destroy(other.gameObject);
            Destroy(transform.gameObject, 1f);
        }
    }
}
