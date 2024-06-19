

public class SaveGameState
{
    private readonly GameRepository Repository;
    private readonly Pinball Pinball;

    public SaveGameState(GameRepository repository, Pinball pinball)
    {
        Repository = repository;
        Pinball = pinball;
    }

    public void Run()
    {
        Repository.SaveGameState(Pinball);
    }
}

public interface GameRepository
{
    void SaveGameState(Pinball pinball);
    Pinball LoadGameState();
    void ClearSavedState();
}