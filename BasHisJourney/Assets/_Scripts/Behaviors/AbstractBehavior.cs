using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractBehavior : MonoBehaviour
{

    public Buttons[] inputButtons;
    public MonoBehaviour[] dissableScripts;

    protected InputState inputState;
    protected Rigidbody2D body2d;
    protected CollisionState collisionState;
    protected AudioManager AManager;

    protected virtual void Awake()
    {
        inputState = GetComponent<InputState>();
        body2d = GetComponent<Rigidbody2D>();
        collisionState = GetComponent<CollisionState>();
        AManager = GetComponent<AudioManager>();
    }

    protected virtual void ToggleScripts(bool value)
    {
        foreach (var script in dissableScripts)
        {
            script.enabled = value;
        }
    }
}
