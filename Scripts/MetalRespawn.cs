
using UdonSharp;
using UnityEngine;

public class MetalRespawn : UdonSharpBehaviour
{
    public Transform spawnPoint;

    void Update()
    {
        if(transform.position.y < -10f)
            transform.position = spawnPoint.position;
    }
}
