using System;

namespace IuvoUnity
{
    public interface IStateACondition : IBooleanCondition
    {
        public bool IsConditionMet();
    }

}