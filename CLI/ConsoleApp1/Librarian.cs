class Librarian
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }

    public Librarian(string name, int employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    public void AddBook(Book book, Library library)
    {
        library.AddBook(book);
        Console.WriteLine($"{Name} added {book.Title} to the library.");
    }

    public void RemoveBook(Book book, Library library)
    {
        library.RemoveBook(book);
        Console.WriteLine($"{Name} removed {book.Title} from the library.");
    }
}