using Base.Types.Base;
using UnityEngine;

namespace Base.Types.Quaternion
{
    [CreateAssetMenu(fileName = "New Quaternion Observable", menuName = "Types/Quaternion/Observable")]
    public class QuaternionObservable : Observable<UnityEngine.Quaternion>
    {
    }
}