using System;
using UnityEngine;

namespace Base.Types.Base
{
    [Serializable]
    public abstract class Variable<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        
        [SerializeField] public T value;

        public bool restorable;

        private T _initialValue;

        private void OnValidate()
        {
            _initialValue = value;
        }
        
        public void OnBeforeSerialize()
        {
            if (restorable) value = _initialValue;
        }

        public void OnAfterDeserialize()
        {
            _initialValue = value;
        }
    }
}