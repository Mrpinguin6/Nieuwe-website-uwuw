namespace ConsoleApp2;

public class ReferenceBook : Book
{
    public string Topic { get; }

    public ReferenceBook(string title, string author, int isbn, string topic)
        : base(title, author, isbn)
    {
        Topic = topic;
    }

    public override void Borrow()
    {
        Console.WriteLine($"{Title} is a reference book and cannot be borrowed.");
    }
}