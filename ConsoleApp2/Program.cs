namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        LibraryUser user1 = new LibraryUser("Alice");
        LibraryUser user2 = new LibraryUser("Bob");

        library.Attach(user1);
        library.Attach(user2);

        IItem book1 = ItemFactory.CreateItem("Book", "C# Programming", "John Doe", 12345);
        IItem magazine1 = ItemFactory.CreateItem("Magazine", "Tech Today", "Jane Smith", 42);
        IItem refBook1 = ItemFactory.CreateItem("ReferenceBook", "Encyclopedia", "Various Authors", 67890, "Science");

        library.AddItem(book1);
        library.AddItem(magazine1);
        library.AddItem(refBook1);

        library.BorrowItem(book1);
        library.ReturnItem(book1);

        library.BorrowItem(refBook1);
    }
}