namespace ConsoleApp2;

public class Magazine : AbstractItem
{
    public int IssueNumber { get; }

    public Magazine(string title, string author, int issueNumber)
        : base(title, author)
    {
        IssueNumber = issueNumber;
    }
}