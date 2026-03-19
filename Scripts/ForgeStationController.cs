
using UdonSharp;
using UnityEngine;

public class ForgeStationController : UdonSharpBehaviour
{
    public Transform stationPoint;

    public void EnterStation(Transform player)
    {
        player.position = stationPoint.position;
    }
}
