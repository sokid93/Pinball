using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dependencies : MonoBehaviour
{
    Pinball pinball;
    public ScoreController scoreController { private set; get; }
    public BallsManager ballsManager { private set; get; }


    private void Awake()
    {
        pinball = new Pinball(3);
        ScoreUpdate pointsDisplay = FindObjectOfType<ScorePanel>();
        scoreController = new ScoreController(pinball, pointsDisplay);
        HandleBall handleBall = FindObjectOfType<BallsDispenser>();
        ballsManager = new BallsManager(pinball, handleBall);
    }
}
