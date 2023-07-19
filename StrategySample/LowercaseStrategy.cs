namespace StrategySample;

public class LowercaseStrategy : IStrategy
{
    public string Execute(string input)
    {
        return input.ToLower();
    }
}
