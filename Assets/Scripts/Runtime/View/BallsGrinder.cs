using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsGrinder : MonoBehaviour
{
    BallsManager BallsManager;

    private void Start()
    {
        BallsManager = FindObjectOfType<Dependencies>().BallsManager;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            BallsManager.LoseBall();
        }
    }
}
