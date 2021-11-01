using UnityEngine;

namespace Base.Events.Particle
{
    [CreateAssetMenu(menuName = "Base/Event/SimpleParticleEvent")]
    public class SimpleParticleEvent : ParticleEvent
    {
        public ParticleSystem particle;

        public override void Emit(Vector3 position)
        {
            Instantiate(particle, position, Quaternion.identity);
        }
    }
}