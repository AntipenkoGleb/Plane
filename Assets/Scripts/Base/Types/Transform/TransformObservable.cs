using Base.Types.Base;
using UnityEngine;

namespace Base.Types.Transform
{
    [CreateAssetMenu(fileName = "New Transform Observable", menuName = "Types/Transform/Observable")]
    public class TransformObservable : Observable<UnityEngine.Transform>
    {
    }
}