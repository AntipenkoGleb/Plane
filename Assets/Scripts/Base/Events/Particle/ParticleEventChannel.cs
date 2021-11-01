using Base.Events.Base;
using UnityEngine;

namespace Base.Events.Particle
{
    [CreateAssetMenu(menuName = "Base/EventChannel/Particle")]
    public class ParticleEventChannel : EventChannelSO<ParticleEvent>
    {
    }
}