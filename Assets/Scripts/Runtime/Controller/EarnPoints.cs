public class EarnPoints
{
    private readonly Pinball Pinball;
    private readonly UpdateScore UpdateScore;

    public EarnPoints(Pinball pinball, UpdateScore updateScore)
    {
        this.Pinball = pinball;
        this.UpdateScore = updateScore;
    }

    public void Earn(int points)
    {
        Pinball.AddPoints(points);
        UpdateScore.DisplayPoints(Pinball.Score);
    }
}
