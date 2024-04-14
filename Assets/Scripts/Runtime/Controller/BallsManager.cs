
public class BallsManager
{
    private readonly Pinball pinball;
    private readonly HandleBall handleBall;

    public BallsManager(Pinball pinball, HandleBall handleBall)
    {
        this.pinball = pinball;
        this.handleBall = handleBall;
    }

    public void ReleaseBall()
    {
        if (pinball.CanReleaseBall())
        {
            pinball.ReleaseBall();
            handleBall.ReleaseBall();
        }
    }

    public void LoseBall()
    {
        pinball.LoseBall();
        handleBall.LoseBall();
    }
}
