
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

public class TongsSpawner : UdonSharpBehaviour
{
    public GameObject tongsPrefab;
    public Transform playerHead;
    private GameObject currentTongs;

    public void SpawnTongs()
    {
        if(currentTongs != null) Destroy(currentTongs);

        Vector3 spawnPos =
            playerHead.position +
            playerHead.forward * 0.7f +
            Vector3.down * 0.2f;

        currentTongs = VRCInstantiate(tongsPrefab);
        currentTongs.transform.position = spawnPos;
    }
}
