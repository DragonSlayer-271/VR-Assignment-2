using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class CanvasReticle : MonoBehaviour
{
    public XRRayInteractor rayInteractor;
    public RectTransform reticleTransform;

    void Update()
    {
       if (rayInteractor.TryGetCurrentUIRaycastResult(out UnityEngine.EventSystems.RaycastResult result))
       {
            reticleTransform.position = result.worldPosition;
       }
    }
}
