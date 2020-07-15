using UnityEngine;

[ExecuteAlways]
public class RenderToTexture : MonoBehaviour
{
  public RenderTexture m_TargetTexture;
  public Vector3 m_FixedCameraPosition;

  void Update()
  {
    // This is super hacky, just quick-and-dirty for this demo.
    // Also rendering thousands of particles for the effect could be reduced by orders of magnitudes.
    // (Again, everything is quick and dirty for this demo).
    Camera.main.targetTexture = m_TargetTexture;
    Camera.main.cullingMask = LayerMask.GetMask("Default");
    Camera.main.orthographic = false;
    Camera.main.Render();
    Camera.main.orthographic = true;
    Camera.main.targetTexture = null;
    Camera.main.cullingMask = LayerMask.GetMask("TransparentFX");
  }
}
