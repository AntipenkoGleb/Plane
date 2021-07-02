using Base.Types.Base;
using UnityEngine;

namespace Base.Types.Quaternion
{
    [CreateAssetMenu(fileName = "New Quaternion Variable", menuName = "Types/Quaternion/Variable")]
    public class QuaternionVariable : Variable<UnityEngine.Quaternion>
    {
    }
}