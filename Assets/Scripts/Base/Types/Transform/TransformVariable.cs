using Base.Types.Base;
using UnityEngine;

namespace Base.Types.Transform
{
    [CreateAssetMenu(fileName = "New Transform Variable", menuName = "Types/Transform/Variable")]
    public class TransformVariable : Variable<UnityEngine.Transform>
    {
    }
}