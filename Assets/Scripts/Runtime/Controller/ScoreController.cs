

public class ScoreController
{
    private readonly Pinball pinball;

    public ScoreController(Pinball pinball)
    {
        this.pinball = pinball;
    }

    public void EarnPoints(int points)
    {
        pinball.AddPoints(points);
    }
}
