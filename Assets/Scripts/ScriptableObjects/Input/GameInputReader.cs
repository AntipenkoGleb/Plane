using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace ScriptableObjects.Input
{
    [CreateAssetMenu(menuName = "Game/InputReader/Game")]
    public class GameInputReader : InputReader
    {
        public UnityEvent<float> rotateAction;

        public UnityEvent<bool> respawnAction;

        public UnityEvent<bool> pauseAction;

        public void OnRotationInput(InputAction.CallbackContext context)
        {
            rotateAction?.Invoke(context.ReadValue<float>());
        }

        public void OnRespawnInput(InputAction.CallbackContext context)
        {
            respawnAction?.Invoke(context.ReadValueAsButton());
        }

        public void OnPauseInput(InputAction.CallbackContext context)
        {
            pauseAction?.Invoke(context.ReadValueAsButton());
        }
    }
}