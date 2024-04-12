using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dependencies : MonoBehaviour
{
    public Pinball pinball { private set; get; }
    public ScoreController scoreController { private set; get; }

    private void Awake()
    {
        pinball = new Pinball(3);
        scoreController = new ScoreController(pinball);
    }
}
