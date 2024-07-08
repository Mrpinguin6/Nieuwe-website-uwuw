namespace ConsoleApp2;

public class Book : AbstractItem
{
    public int ISBN { get; }

    public Book(string title, string author, int isbn)
        : base(title, author)
    {
        ISBN = isbn;
    }
}