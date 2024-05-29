using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsDispenser : MonoBehaviour, HandleBall
{
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject BallSpawner;
    [SerializeField] GameObject GameOverPanel;
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
        if (Input.GetKeyDown(KeyCode.P))
        {
            BallsManager.LoseBall();
        }
    }

    public void ReleaseBall()
    {
        Instantiate(Ball, BallSpawner.transform.position, Quaternion.identity);
    }

    public void LoseBall()
    {
        GameObject lostBall = GameObject.FindGameObjectWithTag("Ball");
        Destroy(lostBall);
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }
}
