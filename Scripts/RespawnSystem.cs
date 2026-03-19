
using UdonSharp;
using UnityEngine;

public class RespawnSystem : UdonSharpBehaviour
{
    public Transform respawnPoint;

    void Update()
    {
        if(transform.position.y < -10)
            transform.position = respawnPoint.position;
    }
}
