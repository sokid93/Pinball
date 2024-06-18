using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsHandler : MonoBehaviour, HandleBall
{
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject BallSpawner;
    [SerializeField] GameObject GameOverPanel;
    LauncherDoor LauncherDoor;

    private void Start()
    {
        LauncherDoor = FindObjectOfType<LauncherDoor>();
    }

    public void ReleaseBall()
    {
        Instantiate(Ball, BallSpawner.transform.position, Quaternion.identity);
    }

    public void LoseBall()
    {
        GameObject lostBall = GameObject.FindGameObjectWithTag("Ball");
        Destroy(lostBall);
        LauncherDoor.OpenLauncherDoor();
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }
}
