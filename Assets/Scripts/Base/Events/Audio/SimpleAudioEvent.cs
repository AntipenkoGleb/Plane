using UnityEngine;

namespace Base.Events.Audio
{
    [CreateAssetMenu(menuName = "Base/Event/Audio/SimpleAudioEvent")]
    public class SimpleAudioEvent : AudioEvent
    {
        [Space] public AudioClip clip;

        public float volume = 1f;

        public float pitch = 1f;

        public bool loop;

        public override void Play(AudioSource audioSource)
        {
            audioSource.clip = clip;
            audioSource.volume = volume;
            audioSource.pitch = pitch;
            audioSource.loop = loop;
            audioSource.Play();
        }
    }
}