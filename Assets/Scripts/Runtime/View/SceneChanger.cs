using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SaveGameState();
        SceneManager.LoadScene(1);
    }

    private void SaveGameState() => FindObjectOfType<Dependencies>().SaveGame.Run();
}
