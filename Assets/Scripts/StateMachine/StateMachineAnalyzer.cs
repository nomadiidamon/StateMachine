using UnityEngine;

public class StateMachineAnalyzer : MonoBehaviour
{
    public static StateMachineAnalyzer Instance;
    [SerializeField] GenericStateMachine toWatch;
    [SerializeField] Transform target;

    void Awake()
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
            toWatch.AssignTargetDestination(target.position);
        }
    }
}
