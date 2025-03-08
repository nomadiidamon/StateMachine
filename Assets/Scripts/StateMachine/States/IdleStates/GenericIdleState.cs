using System;
using UnityEngine;


[CreateAssetMenu(fileName = "IdleState", menuName = "StateMachine/States/IdleStates")]
public class GenericIdleState : GenericState
{
    Vector3 stateStartPosition;
    Vector3 currentPosition;

    public override void OnEnter(GenericStateMachine stateMachine)
	{
        Debug.Log("Entering Idle State");
        animator = stateMachine.GetComponent<Animator>();
        animator.CrossFade(animationName, crossFadeTime);
        stateMachine.currentAnim = animationName;
        stateStartPosition = stateMachine.transform.position;
	}

    public override void OnUpdate(GenericStateMachine stateMachine)
    {
        //currentPosition = stateMachine.transform.position;
        //if (currentPosition != stateStartPosition)
        //{
        //    OnExit(stateMachine);
        //}
    }

    public override void OnFixedUpdate(GenericStateMachine stateMachine)
    {

    }

    public override void OnExit(GenericStateMachine stateMachine)
    {
        Debug.Log("Exiting Idle State");
    }

    public override bool IsConditionMet(GenericStateMachine stateMachine)
    {
        throw new NotImplementedException();
    }
}
