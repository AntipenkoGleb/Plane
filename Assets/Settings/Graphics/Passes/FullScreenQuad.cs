using System;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Rendering.LWRP
{
    public class FullScreenQuad : ScriptableRendererFeature
    {
        public FullScreenQuadSettings m_Settings;
        private FullScreenQuadPass m_RenderQuadPass;

        public override void Create()
        {
            m_RenderQuadPass = new FullScreenQuadPass(m_Settings);
        }

        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
        {
            if (m_Settings.material != null)
                renderer.EnqueuePass(m_RenderQuadPass);
        }

        [Serializable]
        public struct FullScreenQuadSettings
        {
            public RenderPassEvent renderPassEvent;
            public Material material;
        }
    }
}