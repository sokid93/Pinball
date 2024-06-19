using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLastState : MonoBehaviour
{
    private void Start()
    {
        LoadGameState();
    }

    private void OnApplicationQuit()
    {
        ClearGameState();
    }

    private void LoadGameState() => FindObjectOfType<Dependencies>().LoadGame.Run();
    private void ClearGameState() => FindObjectOfType<Dependencies>().LoadGame.ClearSavedState();
}
