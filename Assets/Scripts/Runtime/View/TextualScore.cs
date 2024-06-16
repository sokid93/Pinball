using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextualBallsCounter : MonoBehaviour, UpdateScore
{
    [SerializeField] Text ScoreText;
    Pinball Pinball;

    private void Awake()
    {
        Pinball = FindObjectOfType<Dependencies>().Pinball;    
    }

    private void Start()
    {
        InitializeScoreText();
    }

    private void InitializeScoreText()
    {
        DisplayPoints(Pinball.Score);
    }

    public void DisplayPoints(int points)
    {
        ScoreText.text ="Score: " + points.ToString();
    }

}
