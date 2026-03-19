
using UdonSharp;
using UnityEngine;

public class FurnaceTrigger : UdonSharpBehaviour
{
    public FurnaceController furnace;

    private void OnTriggerEnter(Collider other)
    {
        MetalState metal = other.GetComponent<MetalState>();
        if(metal != null) furnace.HeatMetal(metal);
    }
}
