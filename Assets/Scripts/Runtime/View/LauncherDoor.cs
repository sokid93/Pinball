using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherDoor : MonoBehaviour
{
    GameObject Door;

    private void OnTriggerExit(Collider other)
    {
        CloseLaucherDoor();
    }

    private void CloseLaucherDoor()
    {
        Door.SetActive(true);
    }

    private void OpenLauncherDoor()
    {
        Door.SetActive(false);
    }
}
