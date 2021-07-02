using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        public new Rigidbody rigidbody;

        public PlayerSettings playerSettings;

        private void FixedUpdate()
        {
            var rotationAngle = playerSettings.rotationSpeed * playerSettings.rotationInput * Time.deltaTime;

            rigidbody.rotation *= Quaternion.AngleAxis(rotationAngle, Vector3.forward);
            rigidbody.angularVelocity = Vector3.zero;
            rigidbody.velocity = transform.right * (playerSettings.movementSpeed * Time.fixedDeltaTime);
        }
    }
}