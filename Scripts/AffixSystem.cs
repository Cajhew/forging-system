
using UdonSharp;
using UnityEngine;

public class AffixSystem : UdonSharpBehaviour
{
    public string[] prefixPool;
    public string[] suffixPool;

    public string GetPrefix()
    {
        return prefixPool[Random.Range(0, prefixPool.Length)];
    }

    public string GetSuffix()
    {
        return suffixPool[Random.Range(0, suffixPool.Length)];
    }
}
