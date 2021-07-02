using Base.Types.Base;
using Base.Types.Float;
using Base.Types.Quaternion;
using Base.Types.Vector3;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "New Player Settings", menuName = "Settings/Player")]
    public class PlayerSettings : Settings
    {
        public FloatReference movementSpeed;
        public FloatReference rotationSpeed;

        public FloatReference rotationInput;

        public Vector3Reference position;
        public QuaternionReference rotation;
    }
}