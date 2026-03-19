
using UdonSharp;
using UnityEngine;

public class TongsController : UdonSharpBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    public override void OnPickup()
    {
        rb.isKinematic = false;
    }

    public override void OnDrop()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
