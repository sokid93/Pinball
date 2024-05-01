

public class ScoreController
{
    private readonly Pinball Pinball;
    private readonly ScoreUpdate ScoreUpdater;

    public ScoreController(Pinball pinball, ScoreUpdate scoreUpdater)
    {
        this.Pinball = pinball;
        this.ScoreUpdater = scoreUpdater;
    }

    public void InitializeScore()
    {
        ScoreUpdater.DisplayPoints(Pinball.Score);
    }

    public void EarnPoints(int points)
    {
        Pinball.AddPoints(points);
        ScoreUpdater.DisplayPoints(Pinball.Score);
    }
}
