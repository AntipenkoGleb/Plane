using System.Collections.Generic;
using UnityEngine;

namespace Base.EventStateMachine.Base
{
    public abstract class Condition : ScriptableObject
    {
        public List<Action> actions = new List<Action>();
        public abstract bool CheckCondition();
    }
}