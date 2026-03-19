
using UdonSharp;
using UnityEngine;

public class VRInputController : UdonSharpBehaviour
{
    public HammerController hammer;

    public void TriggerHit(MetalState metal)
    {
        hammer.HitMetal(metal);
    }
}
