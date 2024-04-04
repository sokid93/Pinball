using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour
{
    [SerializeField] Text scorePanel;
    Pinball pinball;

    void Start()
    {
        pinball = FindObjectOfType<Dependencies>().pinball;
    }

    void Update()
    {
        scorePanel.text= pinball.GetScore().ToString();
    }
}
