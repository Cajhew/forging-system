
using UdonSharp;
using UnityEngine;

public class ForgeConfig : UdonSharpBehaviour
{
    public float maxMetalTemperature = 1000f;
    public float optimalTemperatureMin = 600f;
    public float optimalTemperatureMax = 850f;
    public float coolingRate = 10f;
    public float forgeHitQuality = 0.05f;
}
