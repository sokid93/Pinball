using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dependencies : MonoBehaviour
{
    public Pinball Pinball;
    public ScoreController ScoreController { private set; get; }
    public BallsManager BallsManager { private set; get; }


    private void Awake()
    {
        Pinball = new Pinball(3);
        UpdateScore pointsDisplay = FindObjectOfType<ScorePanel>();
        ScoreController = new ScoreController(Pinball, pointsDisplay);
        HandleBall handleBall = FindObjectOfType<BallsDispenser>();
        BallsManager = new BallsManager(Pinball, handleBall);
    }
}
