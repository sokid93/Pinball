using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsRepository : GameRepository
{
    public Pinball LoadGameState()
    {
        int ballsRemaining = PlayerPrefs.GetInt("BallsRemaining", new Pinball(3).BallsRemaining);
        int score = PlayerPrefs.GetInt("Score", new Pinball().Score);
        return new Pinball(ballsRemaining, score);
    }

    public void SaveGameState(Pinball pinball)
    {
        PlayerPrefs.SetInt("BallsRemaining", pinball.BallsRemaining);
        PlayerPrefs.SetInt("Score", pinball.Score);
    }

    public void ClearSavedState()
    {
        PlayerPrefs.DeleteAll();
    }
}
