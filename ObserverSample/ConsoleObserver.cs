namespace ObserverSample;

public class ConsoleObserver : IObserver
{
    public void Update(string data)
    {
        Console.WriteLine($"{nameof(ConsoleObserver)}: {data}");
    }
}