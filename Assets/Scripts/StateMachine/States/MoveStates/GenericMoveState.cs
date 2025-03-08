using System;
using UnityEngine;


[CreateAssetMenu(fileName = "MoveState", menuName = "StateMachine/States/MoveState")]
public class GenericMoveState : GenericState
{
    public float speed = 5f;

    public override void OnEnter(GenericStateMachine stateMachine)
    {
        Debug.Log("Entering Move State");

    }

    public override void OnUpdate(GenericStateMachine stateMachine)
    {

    }

    public override void OnFixedUpdate(GenericStateMachine stateMachine)
    {

    }

    public override void OnExit(GenericStateMachine stateMachine)
    {
        Debug.Log("Exiting Move State");

    }

    public override bool IsConditionMet(GenericStateMachine stateMachine)
    {
        throw new NotImplementedException();
    }
}
