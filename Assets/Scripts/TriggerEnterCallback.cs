using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterCallback : MonoBehaviour
{
    public UnityEvent callback;

    private void OnTriggerEnter(Collider other)
    {
        callback.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        callback.Invoke();
    }
}