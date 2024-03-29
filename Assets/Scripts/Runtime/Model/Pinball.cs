using System.Collections;
using System.Collections.Generic;

public class Pinball
{
    public int score { get; private set; }

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
}
