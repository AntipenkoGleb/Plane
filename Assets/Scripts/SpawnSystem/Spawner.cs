using UnityEngine;

namespace SpawnSystem
{
    public class Spawner : MonoBehaviour
    {
        public GameObject prefab;
        public Vector3 position;
        public Quaternion rotation;
        public Transform parent;

        public void Spawn()
        {
            Instantiate(prefab, position, rotation, parent);
        }
    }
}