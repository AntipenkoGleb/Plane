using UnityEngine.Rendering.Universal;

namespace UnityEngine.Rendering.LWRP
{
    public class FullScreenQuadPass : ScriptableRenderPass
    {
        private readonly string m_ProfilerTag = "DrawFullScreenPass";

        private readonly FullScreenQuad.FullScreenQuadSettings m_Settings;

        public FullScreenQuadPass(FullScreenQuad.FullScreenQuadSettings settings)
        {
            renderPassEvent = settings.renderPassEvent;
            m_Settings = settings;
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var camera = renderingData.cameraData.camera;

            var cmd = CommandBufferPool.Get(m_ProfilerTag);
            cmd.SetViewProjectionMatrices(Matrix4x4.identity, Matrix4x4.identity);
            cmd.DrawMesh(RenderingUtils.fullscreenMesh, Matrix4x4.identity, m_Settings.material);
            cmd.SetViewProjectionMatrices(camera.worldToCameraMatrix, camera.projectionMatrix);
            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }
    }
}