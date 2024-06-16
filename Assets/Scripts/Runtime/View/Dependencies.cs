using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dependencies : MonoBehaviour
{
    public Pinball Pinball;
    public EarnPoints ScoreController { private set; get; }
    public BallsManager BallsManager { private set; get; }
    public SaveGameState SaveGame { get; set; }
    public LoadGameState LoadGame { get; set; }


    private void Awake()
    {
        Pinball = new Pinball(3);
        UpdateScore pointsDisplay = FindObjectOfType<TextualScore>();
        ScoreController = new EarnPoints(Pinball, pointsDisplay);
        HandleBall handleBall = FindObjectOfType<BallsDispenser>();
        BallsManager = new BallsManager(Pinball, handleBall);

        PlayerPrefsRepository repository = new();
        SaveGame = new SaveGameState(repository, Pinball);
        LoadGame = new LoadGameState(repository, Pinball, pointsDisplay);
    }
}
