
using UdonSharp;
using UnityEngine;

public class ForgeSoundController : UdonSharpBehaviour
{
    public AudioSource hammerSound;

    public void PlayHammer()
    {
        hammerSound.Play();
    }
}
