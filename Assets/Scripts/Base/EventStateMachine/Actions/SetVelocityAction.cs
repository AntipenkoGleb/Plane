using Base.EventStateMachine.Base;
using Base.Types.Vector3;
using UnityEngine;

namespace Base.EventStateMachine.Actions
{
    [CreateAssetMenu(fileName = "Set Velocity Action", menuName = "StateMachine/Actions/Set Velocity")]
    public class SetVelocityAction : Action
    {
        public Vector3Reference velocity;

        public override void DoAction(EventStateMachine stateMachine)
        {
            Debug.Log("Move");
            if (stateMachine.TryGetComponent(out Rigidbody rigidbody))
                rigidbody.velocity = velocity.Value * Time.fixedTime;
        }
    }
}