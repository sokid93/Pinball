using System;

public class Pinball
{
    public int Score { get; private set; }
    public int BallsRemaining { get; private set; }
    public bool HasBallInPlay { get; private set; }
    public int BumpForce { get; private set; }

    public Pinball()
    {
        Score = 0;
        HasBallInPlay = false;
        BallsRemaining = 1;
        BumpForce = 1000;
    }

    public Pinball(int ballsAvailable)
    {
        if (ballsAvailable < 2)
            throw new ArgumentException("El minimo de bolas que se pueden pasar al constructor es 2");
        Score = 0;
        HasBallInPlay = false;
        BallsRemaining = ballsAvailable;
        BumpForce = 1000;
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
            throw new InvalidOperationException("Intentas lanzar una nueva bola pero no hay bolas disponibles");
        }
        BallsRemaining -= 1;
        HasBallInPlay = true;
    }

    public bool CanReleaseBall()
    {
        return !HasBallInPlay && !GameOver();
    }

    public void LoseBall()
    {
        if (BallsRemaining < 0)
        {
            throw new InvalidOperationException("No puedes perder una bola porque no te queda ninguna");
        }
        HasBallInPlay = false;
    }

    public bool GameOver()
    {
        if(!HasBallInPlay)
            return BallsRemaining == 0;
        else return false;
    }
}
