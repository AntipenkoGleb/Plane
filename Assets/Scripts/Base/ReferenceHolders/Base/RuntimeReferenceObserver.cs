using Base.Types.Base;
using UnityEngine;
using UnityEngine.Events;

namespace Base.ReferenceHolders.Base
{
    public abstract class RuntimeReferenceHolderObserver<H, T> : MonoBehaviour, IObserver<T>
        where H : RuntimeReferenceHolder<T>
    {
        public H objectHolder;

        public UnityEvent<T> callback;

        private void OnEnable()
        {
            objectHolder.AddObserver(this);
        }

        private void OnDisable()
        {
            objectHolder.RemoveObserver(this);
        }

        public void OnValueChanged(T value)
        {
            callback.Invoke(value);
        }
    }
}