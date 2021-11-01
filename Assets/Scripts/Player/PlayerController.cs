using ScriptableObjects.Input;
using ScriptableObjects.Player;
using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        public new Rigidbody2D rigidbody;

        public PlayerSettings playerSettings;

        public GameInputReader inputReader;


        public UnityEvent<Vector3> onPlayerCrashed;

        private bool _alive = true;

        private float _rotationAngle;

        private void Awake()
        {
            inputReader.rotateAction.AddListener(OnRotationInput);
        }

        private void FixedUpdate()
        {
            rigidbody.rotation += _rotationAngle * Time.fixedDeltaTime;
            rigidbody.velocity = transform.right * (playerSettings.movementSpeed * Time.fixedDeltaTime);
            rigidbody.angularVelocity = 0;
        }

        private void OnDestroy()
        {
            inputReader.rotateAction.RemoveListener(OnRotationInput);
        }

        private void OnCollisionEnter2D(Collision2D collision2D)
        {
            if (_alive)
            {
                _alive = false;
                onPlayerCrashed.Invoke(transform.position);
            }
        }

        private void OnRotationInput(float value)
        {
            _rotationAngle = playerSettings.rotationSpeed * value;
        }
    }
}