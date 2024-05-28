using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour, UpdateScore
{
    [SerializeField] Text scorePanel;
    ScoreController ScoreController;

    private void Awake()
    {
        ScoreController = FindObjectOfType<Dependencies>().scoreController;    
    }

    private void Start()
    {
        ScoreController.InitializeScore();
    }

    public void DisplayPoints(int points)
    {
        scorePanel.text = points.ToString();
    }

}
