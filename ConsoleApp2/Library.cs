namespace ConsoleApp2;

public class Library : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private List<IItem> items = new List<IItem>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }

    public void AddItem(IItem item)
    {
        items.Add(item);
        NotifyObservers($"{item.Title} has been added to the library.");
    }

    public void BorrowItem(IItem item)
    {
        item.Borrow();
        NotifyObservers($"{item.Title} has been borrowed.");
    }

    public void ReturnItem(IItem item)
    {
        item.Return();
        NotifyObservers($"{item.Title} has been returned.");
    }
}
