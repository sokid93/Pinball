using System.Collections;
using System.Collections.Generic;

public class Pinball
{
    int score;

    public Pinball()
    {
        score = 0;
    }
    public Pinball(int score)
    {
        this.score = score;
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
        return false;
    }
}
