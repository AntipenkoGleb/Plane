using UnityEngine;

namespace Base.ReferenceHolders.Base
{
    public abstract class RuntimeReferenceObject<H, T> : MonoBehaviour where H : RuntimeReferenceHolder<T>
    {
        public H objectHolder;
    }
}