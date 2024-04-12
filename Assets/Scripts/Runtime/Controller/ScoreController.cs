

public class ScoreController
{
    private readonly Pinball pinball;
    private readonly sadl�kfj�s pointsDisplay;

    public ScoreController(Pinball pinball, sadl�kfj�s pointsDisplay)
    {
        this.pinball = pinball;
        this.pointsDisplay = pointsDisplay;
    }

    public void InitializeScore()
    {
        pointsDisplay.DisplayPoints(pinball.Score);
    }

    public void EarnPoints(int points)
    {
        pinball.AddPoints(points);
        pointsDisplay.DisplayPoints(pinball.Score);
    }
}
