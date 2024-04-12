using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour, sadlñkfjñs
{
    [SerializeField] Text scorePanel;
    ScoreController controller;

    private void Awake()
    {
        controller = FindObjectOfType<Dependencies>().scoreController;    
    }

    private void Start()
    {
        controller.InitializeScore();
    }

    public void DisplayPoints(int points)
    {
        scorePanel.text = points.ToString();
    }
}
