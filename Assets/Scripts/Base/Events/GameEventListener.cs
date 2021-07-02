using UnityEngine;
using UnityEngine.Events;

namespace Base.Events
{
    public class GameGameEventListener : MonoBehaviour
    {
        public GameEvent @event;

        public UnityEvent response;

        private void OnEnable()
        {
            @event.Subscribe(OnEventRaised);
        }

        private void OnDisable()
        {
            @event.Unsubscribe(OnEventRaised);
        }

        private void OnEventRaised()
        {
            response?.Invoke();
        }
    }
}