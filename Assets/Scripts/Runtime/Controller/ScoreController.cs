

public class ScoreController
{
    private readonly Pinball Pinball;
    private readonly UpdateScore ScoreUpdater;

    public ScoreController(Pinball pinball, UpdateScore scoreUpdater)
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
