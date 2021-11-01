using Base.Events.Base;
using UnityEngine;

namespace Base.Events.Audio
{
    [CreateAssetMenu(menuName = "Base/EventChannel/Audio")]
    public class AudioEventChannel : EventChannelSO<AudioEvent>
    {
    }
}