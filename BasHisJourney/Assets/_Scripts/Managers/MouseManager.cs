using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public GameObject Prefab, Obj;

    private Camera _mainCamera;

    // Use this for initialization
    public void Awake()
    {
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {          
            SetHudActive();
        }
    }

    //make the hud for object manipulation active and parent it on the right object
    private void SetHudActive()
    {
        Obj = SelectObject();

        Prefab.transform.SetParent(Obj.transform);
        Prefab.transform.position = Obj.transform.position;
        Prefab.transform.localScale = new Vector3(1, 1, 1);
    }

    //return the object that is selected by mouse using a raycast
    public GameObject SelectObject()
    {
        Vector2 rayPos = new Vector2(_mainCamera.ScreenToWorldPoint(Input.mousePosition).x,
            _mainCamera.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);
        return hit.transform.name == "Wall" ? hit.transform.gameObject : null;
    }
}
