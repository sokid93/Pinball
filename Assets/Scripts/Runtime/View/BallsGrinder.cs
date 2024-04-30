using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsGrinder : MonoBehaviour, HandleBall
{
    BallsManager ballsManager;

    private void Start()
    {
        ballsManager = FindObjectOfType<Dependencies>().ballsManager;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballsManager.LoseBall();
        }
    }

    public void LoseBall()
    {
        GameObject lostBall = GameObject.FindGameObjectWithTag("Ball");
        Destroy(lostBall);
    }

    public void ReleaseBall()
    {
        
    }
}
