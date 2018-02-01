using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceShootLeft : ForcePush
{
    private float speed = 6f;
    private Rigidbody2D thisRigid2D;

    void Start()
    {
        thisRigid2D = GetComponent<Rigidbody2D>();
        speed = Speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        thisRigid2D.AddForce(Vector3.left * speed);
        Destroy(transform.gameObject, 2f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "BreakObj")
        {
            other.gameObject.GetComponent<MeshRenderer>().material = LeftNewSprite;
            Destroy(other.gameObject,1f);
            Destroy(transform.gameObject);
        }
    }
}
