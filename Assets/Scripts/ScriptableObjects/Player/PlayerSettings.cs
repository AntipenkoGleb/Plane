using Base.Types.Base;
using Base.Types.Float;
using UnityEngine;

namespace ScriptableObjects.Player
{
    [CreateAssetMenu(menuName = "Settings/Player")]
    public class PlayerSettings : Settings
    {
        public FloatReference movementSpeed;
        public FloatReference rotationSpeed;
    }
}