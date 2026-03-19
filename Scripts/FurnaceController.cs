
using UdonSharp;
using UnityEngine;

public class FurnaceController : UdonSharpBehaviour
{
    public float furnaceTemperature;
    public float heatRate = 15f;
    public float maxTemperature = 1000f;

    public void HeatMetal(MetalState metal)
    {
        if(metal == null) return;
        metal.temperature += heatRate * Time.deltaTime;
        if(metal.temperature > maxTemperature)
            metal.temperature = maxTemperature;
    }
}
