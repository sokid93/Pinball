using System;
using System.Collections;
using System.Collections.Generic;

public class Pinball
{
    public int Score { get; private set; }
    int ballsRemaining;
    bool hasBall;

    public Pinball()
    {
        Score = 0;
        hasBall = false;
        ballsRemaining = 1;
    }

    public Pinball(int ballsAvailable)
    {
        if (ballsAvailable < 2)
            throw new ArgumentException("El minimo de bolas que se pueden pasar al constructor es 2");
        Score = 0;
        hasBall = false;
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
        if (!CanReleaseBall())
        {
            throw new InvalidOperationException("No se puede");
        }
        ballsRemaining -= 1;
        hasBall = true;
    }

    public bool CanReleaseBall()
    {
        return HasBallsRemaining() && !HasBallInPlay() && !GameOver();
    }

    private bool HasBallsRemaining()
    {
        return ballsRemaining > 0;
    }

    public void LoseBall()
    {
        hasBall = false;
    }
    public bool GameOver()
    {
        return !HasBallsRemaining();
    }
    public int CheckRemainingBalls()
    {
        return ballsRemaining;
    }
}
