
public class BallsManager
{
    private readonly Pinball pinball;

    public BallsManager(Pinball pinball)
    {
        this.pinball = pinball;
    }

    public void ReleaseBall()
    {
        pinball.ReleaseBall();
    }

    public void LoseBall()
    {
        pinball.LoseBall();
    }
}
