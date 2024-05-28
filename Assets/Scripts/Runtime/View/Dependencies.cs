using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dependencies : MonoBehaviour
{
    public Pinball pinball;
    public ScoreController scoreController { private set; get; }
    public BallsManager ballsManager { private set; get; }


    private void Awake()
    {
        pinball = new Pinball(3);
        UpdateScore pointsDisplay = FindObjectOfType<ScorePanel>();
        scoreController = new ScoreController(pinball, pointsDisplay);
        HandleBall handleBall = FindObjectOfType<BallsDispenser>();
        ballsManager = new BallsManager(pinball, handleBall);
    }
}
