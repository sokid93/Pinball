using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dependencies : MonoBehaviour
{
    Pinball pinball;
    public ScoreController scoreController { private set; get; }


    private void Awake()
    {
        pinball = new Pinball(3);
        sadlñkfjñs pointsDisplay = FindObjectOfType<ScorePanel>();
        scoreController = new ScoreController(pinball, pointsDisplay);
    }
}
