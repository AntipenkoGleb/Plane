using Base.EventStateMachine.Base;
using Base.Types.Vector3;
using UnityEngine;

namespace Base.EventStateMachine.Actions
{
    [CreateAssetMenu(fileName = "Add Rotation Action", menuName = "StateMachine/Actions/Add Rotation")]
    public class AddRotationAction : Action
    {
        public Vector3Reference rotation;

        public override void DoAction(EventStateMachine stateMachine)
        {
            stateMachine.transform.rotation *= Quaternion.Euler(rotation.Value * Time.deltaTime);
        }
    }
}