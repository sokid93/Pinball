using System;
using System.Collections;
using System.Collections.Generic;

public class Pinball
{
    int score;
    int ballsRemaining;
    bool hasBall;
    bool isGameOver;

    public Pinball()
    {
        score = 0;
        hasBall = false;
        isGameOver = false;
        ballsRemaining = 1;
    }

    public Pinball(int ballsAvailable)
    {
        if (ballsAvailable < 2)
            throw new ArgumentException("El minimo de bolas que se pueden pasar al constructor es 2");
        score = 0;
        hasBall = false;
        isGameOver = false;
        ballsRemaining = ballsAvailable;
    }

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
        if (ballsRemaining > 0)
            hasBall = true;
    }
    public void LoseBall()
    {
        hasBall = false;
        ballsRemaining -= 1;
        if (ballsRemaining == 0)
            isGameOver = true;
    }
    public bool GameOver()
    {
        return isGameOver;
    }

}
