class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int bookId, string title, string author, string isbn)
    {
        BookID = bookId;
        Title = title;
        Author = author;
        ISBN = isbn;
        IsAvailable = true;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"BookId: {BookID}, \nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nAvailable: {IsAvailable}\n");
    }
}