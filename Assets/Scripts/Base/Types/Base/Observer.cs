using UnityEngine;
using UnityEngine.Events;

namespace Base.Types.Base
{
    public abstract class Observer<T, TObservable> : MonoBehaviour, IObserver<T> where TObservable : Observable<T>
    {
        public TObservable observable;

        [Space] public UnityEvent<T> onValueChangedEvent;

        private void OnEnable()
        {
            observable.AddObserver(this);
        }

        private void OnDisable()
        {
            observable.RemoveObserver(this);
        }

        public void OnValueChanged(T value)
        {
            onValueChangedEvent.Invoke(value);
        }
    }
}