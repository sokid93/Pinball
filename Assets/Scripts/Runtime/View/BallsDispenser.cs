using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsDispenser : MonoBehaviour
{
    BallsManager BallsManager;

    private void Start()
    {
        BallsManager = FindObjectOfType<Dependencies>().BallsManager;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BallsManager.ReleaseBall();
        }
    }
}
