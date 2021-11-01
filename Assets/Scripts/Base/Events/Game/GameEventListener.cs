using Base.Events.Base;
using UnityEngine;
using UnityEngine.Events;

namespace Base.Events.Game
{
    public class GameEventListener : MonoBehaviour, ISubscriber
    {
        public GameEvent @event;

        public UnityEvent response;

        private void OnEnable()
        {
            @event.Subscribe(this);
        }

        private void OnDisable()
        {
            @event.Unsubscribe(this);
        }

        public void OnPublish()
        {
            response.Invoke();
        }
    }
}