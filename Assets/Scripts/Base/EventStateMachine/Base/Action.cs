using UnityEngine;

namespace Base.EventStateMachine.Base
{
    public abstract class Action : ScriptableObject
    {
        public abstract void DoAction(EventStateMachine stateMachine);
    }
}