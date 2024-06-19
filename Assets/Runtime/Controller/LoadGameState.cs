

public class LoadGameState
{
    private GameRepository Repository;
    private readonly Pinball Pinball;
    private readonly UpdateScore ScoreDisplay;

    public LoadGameState(GameRepository repository, Pinball pinball, UpdateScore scoreDisplay)
    {
        Repository = repository;
        Pinball = pinball;
        ScoreDisplay = scoreDisplay;
    }

    public void Run()
    {
        Pinball loadedGameState = Repository.LoadGameState();
        Pinball.SetFromOtherGameState(loadedGameState.BallsRemaining, loadedGameState.Score);
        ScoreDisplay.DisplayPoints(Pinball.Score);
    }

    public void ClearSavedState()
    {
        Repository.ClearSavedState();
    }
}
