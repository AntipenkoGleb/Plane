using Base.Types.Base;
using UnityEngine;

namespace Base.Types.Vector3
{
    [CreateAssetMenu(fileName = "New Vector3 Observable", menuName = "Types/Vector3/Observable")]
    public class Vector3Observable : Observable<UnityEngine.Vector3>
    {
    }
}