namespace StrategySample;

public class StringEditor
{
    private IStrategy strategy;

    public StringEditor(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public string Execute(string input)
    {
        return strategy.Execute(input);
    }
}
