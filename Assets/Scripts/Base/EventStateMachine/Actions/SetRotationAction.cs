using Base.EventStateMachine.Base;
using Base.Types.Vector3;
using UnityEngine;

namespace Base.EventStateMachine.Actions
{
    [CreateAssetMenu(fileName = "Set Rotation Action", menuName = "StateMachine/Actions/Set Rotation")]
    public class SetRotationAction : Action
    {
        public Vector3Reference rotation;

        public override void DoAction(EventStateMachine stateMachine)
        {
            stateMachine.transform.rotation = Quaternion.Euler(rotation.Value * Time.deltaTime);
        }
    }
}