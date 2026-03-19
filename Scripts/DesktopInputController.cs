
using UdonSharp;
using UnityEngine;

public class DesktopInputController : UdonSharpBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Desktop Hit");
        }
    }
}
