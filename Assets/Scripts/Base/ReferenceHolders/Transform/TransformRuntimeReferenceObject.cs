using Base.ReferenceHolders.Base;

namespace Base.ReferenceHolders.Transform
{
    public class
        TransformRuntimeReferenceObject : RuntimeReferenceObject<TransformRuntimeReferenceHolder, UnityEngine.Transform>
    {
        private void OnEnable()
        {
            objectHolder.RuntimeObject = gameObject.transform;
        }

        private void OnDisable()
        {
            objectHolder.RuntimeObject = null;
        }
    }
}