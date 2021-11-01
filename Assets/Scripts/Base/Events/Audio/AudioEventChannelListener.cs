using Base.Events.Base;
using UnityEngine;

namespace Base.Events.Audio
{
    public class AudioEventChannelListener : MonoBehaviour, ISubscriber<AudioEvent>
    {
        public AudioSource audioSource;

        public AudioEventChannel eventChannel;

        private void OnEnable()
        {
            eventChannel.Subscribe(this);
        }

        private void OnDisable()
        {
            eventChannel.Unsubscribe(this);
        }

        public void OnPublish(AudioEvent audioEvent)
        {
            audioEvent.Play(audioSource);
        }
    }
}