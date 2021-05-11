using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofMaterialSwitch : MonoBehaviour
{
    // Reference to the sphere object.
   
    // The material that is to be selected.
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;
    public Material Material5;
    public Material Material6;
    public Material Material7;
    public Material Material8;
    public Material Material9;
    public Material Material10;

    
    
    [SerializeField]
    private Renderer planeRenderer;
    

    public void Texture1() {
        planeRenderer.sharedMaterial = Material1;
    
    }
    public void Texture2() {
        planeRenderer.sharedMaterial = Material2;
   
    }
    public void Texture3() {
        planeRenderer.sharedMaterial = Material3;
  
    }
    public void Texture4() {
        planeRenderer.sharedMaterial = Material4;
     
    }
    public void Texture5() {
        planeRenderer.sharedMaterial = Material5;
     
    }
    public void Texture6() {
        planeRenderer.sharedMaterial = Material6;

    }
    public void Texture7() {
        planeRenderer.sharedMaterial = Material7;
      
    }
    public void Texture8() {
        planeRenderer.sharedMaterial = Material8;
   
    }
    public void Texture9() {
        planeRenderer.sharedMaterial = Material9;
      
    }
    public void Texture10() {
        planeRenderer.sharedMaterial = Material10;
      
    }

    
    
    public void LowQuality() {
        QualitySettings.SetQualityLevel(0, true);
        QualitySettings.masterTextureLimit = 3;
    }
    public void MedQuality() {
        QualitySettings.SetQualityLevel(2, true);
        QualitySettings.masterTextureLimit = 2;
    }
    public void HighQuality() {
        QualitySettings.SetQualityLevel(4, true);
        QualitySettings.masterTextureLimit = 1;
    }
    public void UltraQuality() {
        QualitySettings.SetQualityLevel(5, true);
        QualitySettings.masterTextureLimit = 0;
    }
   
}

