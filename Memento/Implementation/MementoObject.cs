namespace SoftwarePatterns.Behavioral.Memento.Implementation;

public class MementoObject
{
    private readonly string state;

    public MementoObject(string stateToSave)
    {
        state = stateToSave;
    }

    internal string GetSavedState()
    {
        return state;
    }
}
