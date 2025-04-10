using System;

namespace IuvoUnity
{
    namespace IuvoBehavior
    {
        public interface IStateMachineCondition
        {
            public bool IsConditionMet(GenericStateMachine stateMachine);

        }
    }
}