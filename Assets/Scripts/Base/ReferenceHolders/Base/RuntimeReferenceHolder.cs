using System.Collections.Generic;
using Base.Types.Base;
using UnityEngine;

namespace Base.ReferenceHolders.Base
{
    public abstract class RuntimeReferenceHolder<T> : ScriptableObject, IObservable<T>
    {
        [SerializeField] private T _runtimeObject;
        private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();

        public T RuntimeObject
        {
            get => _runtimeObject;
            set
            {
                _runtimeObject = value;
                NotifyValueChanged();
            }
        }

        public void AddObserver(IObserver<T> observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);
        }

        public void NotifyValueChanged()
        {
            for (var i = _observers.Count - 1; i >= 0; i--)
                _observers[i].OnValueChanged(RuntimeObject);
        }

        public void RemoveObserver(IObserver<T> observer)
        {
            if (_observers.Contains(observer)) _observers.Remove(observer);
        }
    }
}