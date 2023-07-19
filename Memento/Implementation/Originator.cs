using System;

namespace SoftwarePatterns.Behavioral.Memento.Implementation;

public class Originator
{
    private string state;

    public void Set(string state)
    {
        this.state = state;
        Console.WriteLine($"Originator: Setting state to {state}");
    }

    public MementoObject SaveToMemento()
    {
        Console.WriteLine("Originator: Saving to MementoObject.");
        return new MementoObject(state);
    }

    public void RestoreFromMemento(MementoObject memento)
    {
        state = memento.GetSavedState();
        Console.WriteLine($"Originator: State after restoring from Memento: {state}");
    }
}
