namespace ConsoleApp2;

public static class ItemFactory
{
    public static IItem CreateItem(string type, string title, string author, int identifier, string topic = null)
    {
        return type switch
        {
            "Book" => new Book(title, author, identifier),
            "Magazine" => new Magazine(title, author, identifier),
            "ReferenceBook" => new ReferenceBook(title, author, identifier, topic),
            _ => throw new ArgumentException("Invalid item type")
        };
    }
}