

public class ScoreController
{
    private readonly Pinball pinball;
    private readonly ScoreUpdate scoreUpdater;

    public ScoreController(Pinball pinball, ScoreUpdate scoreUpdater)
    {
        this.pinball = pinball;
        this.scoreUpdater = scoreUpdater;
    }

    public void InitializeScore()
    {
        scoreUpdater.DisplayPoints(pinball.Score);
    }

    public void EarnPoints(int points)
    {
        pinball.AddPoints(points);
        scoreUpdater.DisplayPoints(pinball.Score);
    }
}
