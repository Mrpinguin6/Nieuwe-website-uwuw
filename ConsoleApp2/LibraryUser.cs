namespace ConsoleApp2;

public class LibraryUser : IObserver
{
    public string Name { get; }

    public LibraryUser(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"User {Name} notified: {message}");
    }
}