using System;
using System.Collections;
using System.Collections.Generic;

public class Pinball
{
    public int Score { get; private set; }
    public int BallsRemaining { get; private set; }
    public bool HasBallInPlay { get; private set; }

    public Pinball()
    {
        Score = 0;
        HasBallInPlay = false;
        BallsRemaining = 1;
    }

    public Pinball(int ballsAvailable)
    {
        if (ballsAvailable < 2)
            throw new ArgumentException("El minimo de bolas que se pueden pasar al constructor es 2");
        Score = 0;
        HasBallInPlay = false;
        BallsRemaining = ballsAvailable;
    }

    public void AddPoints(int points)
    {
        if (points <= 0)
            throw new ArgumentException("Solo se pueden añadir puntos mayores que 0");
        Score += points;
    }

    public void ReleaseBall()
    {
        if (!CanReleaseBall())
        {
            throw new InvalidOperationException("No se puede");
        }
        BallsRemaining -= 1;
        HasBallInPlay = true;
    }

    public bool CanReleaseBall()
    {
        return HasBallsRemaining() && !HasBallInPlay&& !GameOver();
    }

    private bool HasBallsRemaining()
    {
        return BallsRemaining > 0;
    }

    public void LoseBall()
    {
        HasBallInPlay = false;
    }

    public bool GameOver()
    {
        return !HasBallsRemaining();
    }
}
