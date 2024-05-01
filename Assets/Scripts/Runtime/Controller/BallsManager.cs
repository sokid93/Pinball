
public class BallsManager
{
    private readonly Pinball Pinball;
    private readonly HandleBall HandleBall;

    public BallsManager(Pinball pinball, HandleBall handleBall)
    {
        this.Pinball = pinball;
        this.HandleBall = handleBall;
    }

    public void ReleaseBall()
    {
        if (Pinball.CanReleaseBall())
        {
            Pinball.ReleaseBall();
            HandleBall.ReleaseBall();
        }
    }

    public void LoseBall()
    {
        Pinball.LoseBall();
        HandleBall.LoseBall();
        if (Pinball.GameOver())
        {
            HandleBall.GameOver();
        }
    }
}
