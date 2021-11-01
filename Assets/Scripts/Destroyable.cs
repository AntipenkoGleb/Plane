using UnityEngine;

public class Destroyable : MonoBehaviour
{
    public void DestroySelf(float delay = 0f)
    {
        Destroy(gameObject, delay);
    }
}