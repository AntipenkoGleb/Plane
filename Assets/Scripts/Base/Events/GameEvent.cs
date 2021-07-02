using UnityEngine;

namespace Base.Events
{
    public delegate void GameEventRaised();

    [CreateAssetMenu]
    public class GameEvent : ScriptableObject
    {
        //  private readonly List<Game> _listeners = new List<IGameEventListener>();

        private event GameEventRaised _listeners;

        public void Raise()
        {
            // for (var i = _listeners.Count - 1; i >= 0; i--)
            //     _listeners[i].OnEventRaised();
            _listeners?.Invoke();
        }

        public void Subscribe(GameEventRaised listener)
        {
            _listeners += listener;
            // if (!_listeners.Contains(listener)) _listeners.Add(listener);
        }

        public void Unsubscribe(GameEventRaised listener)
        {
            _listeners -= listener;
            // if (_listeners.Contains(listener)) _listeners.Remove(listener);
        }
    }
}