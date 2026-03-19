
using UdonSharp;
using UnityEngine;

public class ForgeGameManager : UdonSharpBehaviour
{
    public ForgeStateMachine stateMachine;
    public FurnaceController furnace;
    public ForgeController forgeController;
    public WeatherController weather;

    public void StartForge()
    {
        stateMachine.SetState(ForgeStateMachine.State.Heating);
        forgeController.BeginSession();
    }

    public void FinishForge()
    {
        forgeController.CompleteForge();
        stateMachine.SetState(ForgeStateMachine.State.Completed);
    }

    public void CancelForge()
    {
        forgeController.CancelForge();
        stateMachine.SetState(ForgeStateMachine.State.Idle);
    }
}
