using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingBallsCounter : MonoBehaviour
{
    [SerializeField] Text RemainingBallsText;
    Pinball Pinball;

    void Start()
    {
        Pinball = FindObjectOfType<Dependencies>().Pinball;     
    }

    private void Update()
    {
        RemainingBallsText.text = "Remaining Balls: " + Pinball.BallsRemaining.ToString();
    }
}
