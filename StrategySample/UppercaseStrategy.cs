namespace StrategySample;

public class UppercaseStrategy : IStrategy
{
    public string Execute(string input)
    {
        return input.ToUpper();
    }
}
