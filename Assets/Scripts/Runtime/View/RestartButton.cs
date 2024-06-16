using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void Restart()
    {
        ClearGameState();
        SceneManager.LoadScene(0);
    }

    private void ClearGameState() => FindObjectOfType<Dependencies>().LoadGame.ClearSavedState();
}
