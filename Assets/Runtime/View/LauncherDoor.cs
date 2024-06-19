using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherDoor : MonoBehaviour
{
    [SerializeField] GameObject Door;

    private void OnTriggerExit(Collider other)
    {
        CloseLaucherDoor();
    }

    private void CloseLaucherDoor()
    {
        Door.SetActive(true);
    }

    public void OpenLauncherDoor()
    {
        Door.SetActive(false);
    }
}
