
using UdonSharp;
using UnityEngine;

public class ForgeStateMachine : UdonSharpBehaviour
{
    public enum State { Idle, Heating, Forging, Cooling, Completed }
    public State currentState;

    public void SetState(State newState)
    {
        currentState = newState;
    }
}
