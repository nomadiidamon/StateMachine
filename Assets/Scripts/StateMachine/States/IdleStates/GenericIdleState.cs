using System;
using UnityEngine;


[CreateAssetMenu(fileName = "IdleState", menuName = "StateMachine/States/IdleState")]
public class GenericIdleState : GenericState
{
	public override void OnEnter(GenericStateMachine stateMachine)
	{
        Debug.Log("Entering Idle State");

	}

    public override void OnUpdate(GenericStateMachine stateMachine)
    {

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
