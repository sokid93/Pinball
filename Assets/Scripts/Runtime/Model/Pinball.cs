using System.Collections;
using System.Collections.Generic;

public class Pinball
{
    public int score;

    public Pinball(int score)
    {
        this.score = score;
    }

    public void AddPoints(int points)
    {
        score += points;
    }
}
