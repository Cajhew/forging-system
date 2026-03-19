
using UdonSharp;
using UnityEngine;

public class ObjectSafetySystem : UdonSharpBehaviour
{
    public float maxDistance = 5f;
    public Transform origin;

    void Update()
    {
        if(Vector3.Distance(transform.position, origin.position) > maxDistance)
            transform.position = origin.position;
    }
