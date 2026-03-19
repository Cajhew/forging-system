
using UdonSharp;
using UnityEngine;

public class ForgeUIController : UdonSharpBehaviour
{
    public GameObject uiRoot;

    public void ShowUI()
    {
        uiRoot.SetActive(true);
    }

    public void HideUI()
    {
        uiRoot.SetActive(false);
    }
}
