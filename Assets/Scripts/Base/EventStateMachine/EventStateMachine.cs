using System;
using System.Collections.Generic;
using Base.Events;
using Base.EventStateMachine.Base;
using UnityEngine;

namespace Base.EventStateMachine
{
    [Serializable]
    public class EventStateMachine : CachedMonoBehaviour
    {
        public List<EventState> eventsToStates;

        public State initialState;

        private State _currentState;

        private void Start()
        {
            _currentState = initialState;
            _currentState.OnStateEnter(this);
        }

        private void Update()
        {
            _currentState.OnUpdate(this);
        }

        private void OnEnable()
        {
            for (var i = eventsToStates.Count - 1; i >= 0; i--)
            {
                var eventState = eventsToStates[i];
                eventState.@event.Subscribe(() => EnterNewState(eventState.state));
            }
        }

        private void EnterNewState(State newState)
        {
            Debug.Log(newState.name);
            if (_currentState == newState) return;

            var oldState = _currentState;
            _currentState = newState;

            oldState.OnStateExit(this);
            _currentState.OnStateEnter(this);
        }

        public void OnMoveUp()
        {
            Debug.Log("Move Up");
        }
    }

    [Serializable]
    public struct EventState
    {
        public GameEvent @event;

        public State state;
    }
}