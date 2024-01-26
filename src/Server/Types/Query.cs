namespace Server.Types;

[QueryType]
public static class Query
{
    public static Book GetBook(string title)
        => new Book(title, new Author("Jon Skeet"));
}
