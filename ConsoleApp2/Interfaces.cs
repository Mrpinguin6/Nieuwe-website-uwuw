namespace ConsoleApp2;

public interface IItem
{
    string Title { get; }
    string Author { get; }
    void Borrow();
    void Return();
}

public interface IObserver
{
    void Update(string message);
}

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void NotifyObservers(string message);
}