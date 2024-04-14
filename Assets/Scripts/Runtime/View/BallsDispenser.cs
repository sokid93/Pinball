using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsDispenser : MonoBehaviour, HandleBall
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject ballSpawner;
    BallsManager ballsManager;

    private void Start()
    {
        ballsManager = FindObjectOfType<Dependencies>().ballsManager;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballsManager.ReleaseBall();
        }
    }

    public void LoseBall()
    {
        GameObject lostBall = GameObject.FindGameObjectWithTag("Ball");
        Destroy(lostBall);
    }

    public void ReleaseBall()
    {
        Instantiate(ball, ballSpawner.transform.position, Quaternion.identity);
    }
}
