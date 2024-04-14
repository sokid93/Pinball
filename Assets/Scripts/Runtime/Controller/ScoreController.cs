

public class ScoreController
{
    private readonly Pinball pinball;
    private readonly ScoreUpdate scoreUpdater;

    public ScoreController(Pinball pinball, ScoreUpdate scoreupdater)
    {
        this.pinball = pinball;
        this.scoreUpdater = scoreupdater;
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
