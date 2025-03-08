using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public class GenericStateMachine : MonoBehaviour
{
    public GenericState currentState;   
    public GenericState defaultState;
    public Animator animator;
    public NavMeshAgent navMeshAgent;
    public string currentAnim;

    [Header("States")]
    public GenericIdleState idle;
    public GenericMoveState move;
    public List<GenericState> states = new List<GenericState>();




    public void Start()
    {
        if (idle != null)
        {
            states.Add(idle);
        }
        if (move != null)
        {
            states.Add(move);
        }
        ChangeState(defaultState);

    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.OnUpdate(this);
        }

    }

    public void TryChangeState(GenericState newState)
    {
        if (newState != null && newState.CanEnter(this))
        {
            ChangeState(newState);
        }
        else
        {
            Debug.Log("State Transition Denied Due To Unmet Conditions.");
        }

    }

    public void ChangeState(GenericState newState)
    {
        if (currentState != null)
        {
            currentState.OnExit(this);
        }

        currentState = newState;

        if (currentState != null)
        {
            currentState.OnEnter(this);
        }
    }
    public void AssignTargetDestination(Vector3 newDestination)
    {
        if (move != null)
        {
            move.targetPosition = newDestination;
            TryChangeState(move);
        }
    }

}
