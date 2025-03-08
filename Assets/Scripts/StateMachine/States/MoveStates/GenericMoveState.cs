using System;
using UnityEngine;
using UnityEngine.AI;


[CreateAssetMenu(fileName = "GenericMoveState", menuName = "StateMachine/States/MoveStates")]
public class GenericMoveState : GenericState
{
    public float speed = 5f;
    public Vector3 currentPosition;
    public Vector3 targetPosition;
    NavMeshAgent agent;

    public override void OnEnter(GenericStateMachine stateMachine)
    {
        Debug.Log("Entering Move State");
        agent = stateMachine.navMeshAgent;
        agent.speed = speed;
        animator = stateMachine.GetComponent<Animator>();
        animator.CrossFade(animationName, crossFadeTime);
        if (targetPosition != null)
        {
            agent.SetDestination(targetPosition);
        }
        else
        {
            agent.SetDestination(currentPosition);
        }
        stateMachine.currentAnim = animationName;

    }

    public override void OnUpdate(GenericStateMachine stateMachine)
    {
        if (!agent.autoRepath)
        {
            agent.autoRepath = true;
        }
        if (IsConditionMet(stateMachine))
        {
            OnExit(stateMachine);
        }
    }

    public override void OnFixedUpdate(GenericStateMachine stateMachine)
    {

    }

    public override void OnExit(GenericStateMachine stateMachine)
    {
        Debug.Log("Exiting Move State");
        stateMachine.TryChangeState(stateMachine.defaultState);
    }

    public override bool IsConditionMet(GenericStateMachine stateMachine)
    {
        currentPosition = stateMachine.transform.position;
        if (agent.remainingDistance < 0.5f)
        {
            currentPosition = targetPosition;
            return true;
        }
        else
        {
            return false;
        }
    }

}
