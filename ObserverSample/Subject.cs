namespace ObserverSample;

public class Subject
{
    private readonly List<IObserver> observers = new();

    public void NotifyObservers(string data)
    {
        observers.ForEach(x => x.Update(data));
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void SendData(string data)
    {
        NotifyObservers(data);
    }
}