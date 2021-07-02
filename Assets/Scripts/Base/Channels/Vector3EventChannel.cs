using UnityEngine;
using UnityEngine.Events;

namespace Base.Channels
{
    [CreateAssetMenu]
    public class Vector3EventChannel : ScriptableObject
    {
        public UnityAction<Vector3> OnEventRaised;
        
        public void RaiseEvent(Vector3 data) =>   OnEventRaised?.Invoke(data);
    }
}