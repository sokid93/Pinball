using System;

public class Pinball
{
    public int Score { get; private set; }
    public int BallsRemaining { get; private set; }
    public bool HasBallInPlay { get; private set; }
    public float BumpForce { get; private set; }
    public float PlungerMaxForce { get; private set; }

    public Pinball(int ballsAvailable)
    {
        Score = 0;
        HasBallInPlay = false;
        BallsRemaining = ballsAvailable;
        BumpForce = 20f;
        PlungerMaxForce = 20f;
    }

    public Pinball() : this(1) { }

    public Pinball(int ballsAvailable, int score) : this(ballsAvailable)
    {
        Score = score;
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

    public void SetFromOtherGameState(int ballsAvailables, int score)
    {
        BallsRemaining = ballsAvailables;
        Score = score;
    }
}
