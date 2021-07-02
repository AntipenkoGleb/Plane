using UnityEngine;
using UnityEngine.Events;

namespace Base.Channels
{
    public class VoidEventChannel : ScriptableObject
    {
        public UnityAction OnEventRaised;

        public void RaiseEvent() =>   OnEventRaised?.Invoke();
    }
}