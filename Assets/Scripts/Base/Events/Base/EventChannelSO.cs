using System.Collections.Generic;
using UnityEngine;

namespace Base.Events.Base
{
    public class EventChannelSO : MonoBehaviour, IEventChannel
    {
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Publish()
        {
            for (var i = _subscribers.Count - 1; i >= 0; i--) _subscribers[i].OnPublish();
        }
    }

    public class EventChannelSO<T> : ScriptableObject, IEventChannel<T>
    {
        private readonly List<ISubscriber<T>> _subscribers = new List<ISubscriber<T>>();

        public void Subscribe(ISubscriber<T> subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber<T> subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Publish(T data)
        {
            for (var i = _subscribers.Count - 1; i >= 0; i--) _subscribers[i].OnPublish(data);
        }
    }
}