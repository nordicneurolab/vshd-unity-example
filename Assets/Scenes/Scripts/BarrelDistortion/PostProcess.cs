using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PostProcess : MonoBehaviour
{
    /** 
     * Applies barrel distortion shader during post processing
     * **/
    public Material material;
    public Slider kcubeSlider;
    public Slider kSlider; 
    public float kcube;
    public float k;

    // Postprocess the image
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        kcube = kcubeSlider.value;
        k = kSlider.value; 

        material.SetFloat("kcube", kcube);
        material.SetFloat("k", k);
        Graphics.Blit(source, destination, material);
    }
}
