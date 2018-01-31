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
    private FinalAct finalAct;
    private Jump jump;

    private void Awake()
    {
        jump = GetComponent<Jump>();
        finalAct = GetComponent<FinalAct>();
        nextScene = GetComponent<NextScene>();
        inputState = GetComponent<InputState>();
        walkBehavior = GetComponent<Walk>();
        animator = GetComponent<Animator>();
        collisionState = GetComponent<CollisionState>();
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
            ChangeAnimationState(2);
            if (collisionState.standing)
            {
                jump.OnJump();
            }
        }
        if (finalAct.RunClip)
        {
            ChangeAnimationState(2);
            if (collisionState.standing)
            {
                jump.OnJump();
            }
        }

        animator.speed = walkBehavior.Running ? walkBehavior.RunMultiplier : 1;
	}

    void ChangeAnimationState(int value)
    {
        animator.SetInteger("AnimState", value);
    }
}
