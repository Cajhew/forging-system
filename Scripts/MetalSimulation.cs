
using UdonSharp;
using UnityEngine;

public class MetalSimulation : UdonSharpBehaviour
{
    public MetalState metal;
    public float coolingRate = 3f;

    void Update()
    {
        if(metal == null) return;
        metal.temperature -= coolingRate * Time.deltaTime;
        if(metal.temperature < 0) metal.temperature = 0;
    }
}
