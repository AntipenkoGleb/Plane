using System.Collections.Generic;
using Base.EventStateMachine.Base;
using UnityEngine;

namespace Base.EventStateMachine.Actions
{
    [CreateAssetMenu(fileName = "New Condition", menuName = "StateMachine/Condition")]
    public class ConditionAction : Action
    {
        public List<Condition> conditions = new List<Condition>();

        public List<Action> actions = new List<Action>();

        public override void DoAction(EventStateMachine stateMachine)
        {
            for (var i = 0; i < conditions.Count; i++)
                if (!conditions[i].CheckCondition())
                    return;

            for (var i = 0; i < actions.Count; i++) actions[i].DoAction(stateMachine);
        }
    }
}