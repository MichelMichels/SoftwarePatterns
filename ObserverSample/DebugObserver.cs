using System.Diagnostics;

namespace ObserverSample;

public class DebugObserver : IObserver
{
    public void Update(string data)
    {
        Debug.WriteLine($"{nameof(DebugObserver)}: {data}");
    }
}
