using Base.Events.Base;
using UnityEngine;

namespace Base.Events.Particle
{
    public abstract class ParticleEvent : BaseEvent
    {
        public ParticleEventChannel particleChannel;

        public abstract void Emit(Vector3 position);

        public override void Raise()
        {
            if (particleChannel != null) particleChannel.Publish(this);
        }
    }
}