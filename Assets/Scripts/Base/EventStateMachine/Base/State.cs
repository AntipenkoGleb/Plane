using System.Collections.Generic;
using UnityEngine;

namespace Base.EventStateMachine.Base
{
    [CreateAssetMenu(fileName = "State", menuName = "StateMachine/State")]
    public class State : ScriptableObject
    {
        public List<Action> onStateEnter = new List<Action>();
        public List<Action> onUpdate = new List<Action>();
        public List<Action> onStateExit = new List<Action>();

        public void OnStateEnter(EventStateMachine stateMachine)
        {
            for (var i = 0; i < onStateEnter.Count; i++) onStateEnter[i]?.DoAction(stateMachine);
        }

        public void OnUpdate(EventStateMachine stateMachine)
        {
            for (var i = 0; i < onUpdate.Count; i++) onUpdate[i]?.DoAction(stateMachine);
        }

        public void OnStateExit(EventStateMachine stateMachine)
        {
            for (var i = 0; i < onStateExit.Count; i++) onStateExit[i]?.DoAction(stateMachine);
        }
    }
}