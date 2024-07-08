namespace ConsoleApp2;

public abstract class AbstractItem : IItem
{
    private string title;
    private string author;
    
    public AbstractItem(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public string Title => title;
    public string Author => author;

    public virtual void Borrow()
    {
        Console.WriteLine($"{Title} by {Author} has been borrowed.");
    }

    public virtual void Return()
    {
        Console.WriteLine($"{Title} by {Author} has been returned.");
    }
}