using UnityEngine;

public class StateMachineAnalyzer : MonoBehaviour
{
    StateMachineAnalyzer Instance;
    [SerializeField] GenericStateMachine toWatch;
    [SerializeField] Transform target;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Update()
    {
        if (target != null && toWatch != null)
        {
            if (toWatch.move.targetPosition == target.position)
            {
                return;
            }
            toWatch.AssignTargetDestination(target.position);
        }
    }
}
