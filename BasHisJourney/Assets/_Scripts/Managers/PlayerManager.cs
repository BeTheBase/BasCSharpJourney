using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private InputState inputState;
    private Walk walkBehavior;
    private Animator animator;
    private CollisionState collisionState;
    private NextScene nextScene;
    private Jump jumpScript;

    private void Awake()
    {
        nextScene = GetComponent<NextScene>();
        inputState = GetComponent<InputState>();
        walkBehavior = GetComponent<Walk>();
        animator = GetComponent<Animator>();
        collisionState = GetComponent<CollisionState>();
        jumpScript = GetComponent<Jump>();

    }

    // Update is called once per frame
    void Update ()
    {
		if(collisionState.standing)
        {
            ChangeAnimationState(0);
        }
        if(inputState.absVelX > 0)
        {
            ChangeAnimationState(1);
        }
        if(inputState.absVelY > 0)
        {
            ChangeAnimationState(3);
        }
        if (nextScene.RunHappyAnim)
        {
            jumpScript.OnJump();

            ChangeAnimationState(2);
        }

        animator.speed = walkBehavior.Running ? walkBehavior.RunMultiplier : 1;
	}

    void ChangeAnimationState(int value)
    {
        animator.SetInteger("AnimState", value);
    }
}
