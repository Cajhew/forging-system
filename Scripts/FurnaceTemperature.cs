
using UdonSharp;
using UnityEngine;

public class FurnaceTemperature : UdonSharpBehaviour
{
    public float temperature;
    public float increaseRate = 5f;

    void Update()
    {
        temperature += increaseRate * Time.deltaTime;
    }
}
