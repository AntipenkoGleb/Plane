using Base.Events.Base;
using UnityEngine;

namespace Base.Events.Audio
{
    public abstract class AudioEvent : BaseEvent
    {
        public AudioEventChannel audioChannel;
        public abstract void Play(AudioSource audioSource);

        public override void Raise()
        {
            if (audioChannel != null) audioChannel.Publish(this);
        }
    }
}