using UnityEngine;
using UnityEngine.XR;

public class SetViewportScale : MonoBehaviour
{
    public float scale = 0.5f; // 80% of native resolution
    void Start()
    {
        XRSettings.renderViewportScale = scale;  
    }
}
