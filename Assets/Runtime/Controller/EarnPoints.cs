public class EarnPoints
{
    private readonly Pinball Pinball;
    private readonly UpdateScore x;

    public EarnPoints(Pinball pinball, UpdateScore updateScore)
    {
        this.Pinball = pinball;
        this.x = updateScore;
    }

    public void Earn(int points)
    {
        Pinball.AddPoints(points);
        x.DisplayPoints(Pinball.Score);
    }
}
