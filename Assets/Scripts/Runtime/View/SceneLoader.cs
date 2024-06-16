using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int NextSceneId;

    private void OnTriggerEnter(Collider other)
    {
        SaveGameState();
        SceneManager.LoadScene(NextSceneId);
    }

    private void SaveGameState() => FindObjectOfType<Dependencies>().SaveGame.Run();
}
