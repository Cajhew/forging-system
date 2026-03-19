
using UdonSharp;
using UnityEngine;

public class HammerController : UdonSharpBehaviour
{
    public float hammerStrength = 1f;

    public void HitMetal(MetalState metal)
    {
        if(metal == null) return;
        metal.deformation += hammerStrength * 0.1f;
    }
}
