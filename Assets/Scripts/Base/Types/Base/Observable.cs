using System.Collections.Generic;
using UnityEngine;

namespace Base.Types.Base
{
    public abstract class Observable<T> : Variable<T>, IObservable<T>, ISerializationCallbackReceiver
    {
        private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();

        public void NotifyValueChanged()
        {
            for (var i = _observers.Count - 1; i >= 0; i--)
                _observers[i].OnValueChanged(runtimeValue);
        }

        public void AddObserver(IObserver<T> observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);
        }

        public void RemoveObserver(IObserver<T> observer)
        {
            if (_observers.Contains(observer)) _observers.Remove(observer);
        }

        public void SetValue(T newValue)
        {
            runtimeValue = newValue;
            NotifyValueChanged();
        }
    }
}