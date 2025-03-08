using System;
using UnityEngine;

[System.Serializable]
public abstract class GenericState : ScriptableObject, IStateMachineCondition
{
	public string stateName;

	public virtual bool CanEnter(GenericStateMachine stateMachine)
	{
		return true;
	}
	public abstract void OnEnter(GenericStateMachine stateMachine);
	public abstract void OnUpdate(GenericStateMachine stateMachine);
	public abstract void OnFixedUpdate(GenericStateMachine stateMachine);
	public abstract void OnExit(GenericStateMachine stateMachine);
    public abstract bool IsConditionMet(GenericStateMachine stateMachine);
}
