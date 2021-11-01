using System;
using UnityEngine;

namespace Base.Types.Base
{
    [Serializable]
    public abstract class Variable<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        public T initialValue;

        public T runtimeValue;

        public bool restorable;

        public void OnAfterDeserialize()
        {
            runtimeValue = initialValue;
        }

        public void OnBeforeSerialize()
        {
        }
    }
}