using System;
using System.Collections;
using System.Collections.Generic;

public class Pinball
{
    public int Score { get; private set; }
    int ballsRemaining;
    bool hasBall;
    bool isGameOver;

    public Pinball()
    {
        Score = 0;
        hasBall = false;
        isGameOver = false;
        ballsRemaining = 1;
    }

    public Pinball(int ballsAvailable)
    {
        if (ballsAvailable < 2)
            throw new ArgumentException("El minimo de bolas que se pueden pasar al constructor es 2");
        Score = 0;
        hasBall = false;
        isGameOver = false;
        ballsRemaining = ballsAvailable;
    }

    public void AddPoints(int points)
    {
        if (points <= 0)
            throw new ArgumentException("Solo se pueden añadir puntos mayores que 0");
        Score += points;
    }

    public bool HasBallInPlay()
    {
        return hasBall;
    }

    public void ReleaseBall()
    {
        if (HasBallsRemaining()&&!HasBallInPlay()&&!GameOver())
        {
            ballsRemaining -= 1;
            hasBall = true;
        }
    }

    private bool HasBallsRemaining()
    {
        return ballsRemaining > 0;
    }

    public void LoseBall()
    {
        hasBall = false;
        
        if (!HasBallsRemaining())
            isGameOver = true;
    }
    public bool GameOver()
    {
        return isGameOver;
    }
    public int CheckRemainingBalls()
    {
        return ballsRemaining;
    }
}
