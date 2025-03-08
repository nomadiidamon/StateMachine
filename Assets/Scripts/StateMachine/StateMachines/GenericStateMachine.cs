using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GenericStateMachine : MonoBehaviour
{
	public GenericState currentState;
	public GenericState defaultState;

	[Header("States")]
	public Dictionary<string, GenericState> states = new Dictionary<string, GenericState>();
	public GenericIdleState idle;
	public GenericMoveState move;



	public Animator animator;

	public void Start()
	{
		animator = GetComponent<Animator>();

		states.Add("Idle", idle);
        states.Add("Move", move);
        //states.Add("Sprint", SprintState);
        //states.Add("Crouch", CrouchState);

		ChangeState(idle);

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
		if (newState!= null && newState.CanEnter(this))
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

}
