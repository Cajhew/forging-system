
using UdonSharp;
using UnityEngine;

public class ForgeController : UdonSharpBehaviour
{
    public MetalState currentMetal;
    public float hammerAccuracy;
    public float rhythmAccuracy;

    public void BeginSession()
    {
        hammerAccuracy = 0;
        rhythmAccuracy = 0;
    }

    public float CalculateQuality()
    {
        float quality = 1f;
        quality *= hammerAccuracy;
        quality *= rhythmAccuracy;
        if(currentMetal != null)
            quality *= currentMetal.qualityModifier;
        return quality;
    }

    public void CompleteForge()
    {
        float finalQuality = CalculateQuality();
        Debug.Log("Forge Complete Quality: " + finalQuality);
    }

    public void CancelForge()
    {
        currentMetal = null;
    }
}
