
using ObserverSample;

Subject subject = new();

subject.AddObserver(new ConsoleObserver());
subject.AddObserver(new DebugObserver());

subject.SendData("Observer pattern!");