using System.Collections;
using System.Collections.Generic;

public class Pinball
{
    int score;
    bool hasBall;
    bool isGameOver;

    public Pinball()
    {
        score = 0;
        hasBall = false;
        isGameOver = false;
    }

    //public Pinball(int score)
    //{
    //    this.score = score;
    //}

    public void AddPoints(int points)
    {
        score += points;
    }

    public int GetScore()
    {
        return score;
    }
    public bool HasBallInPlay()
    {
        return hasBall;
    }

    public void ReleaseBall()
    {
        hasBall = true;
    }
    public void LoseBall()
    {
        hasBall = false;
        isGameOver = true;
    }
    public bool GameOver()
    {
        return isGameOver;
    }

}
