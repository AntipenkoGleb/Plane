using UnityEngine;

namespace Base.Events.Base
{
    public abstract class BaseEvent : ScriptableObject
    {
        public abstract void Raise();
    }
}