class Program
{
    static void Main()
    {
        Library library = new Library();

        Console.WriteLine("Wellcome to the Library Management System");

        while (true)
        {
            Console.WriteLine("\n1. Display Available Books");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Remove Book");
            Console.WriteLine("4. Exit\n");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nAvailable Books in the library: \n");
                    library.DisplayAvailableBooks();
                    break;

                case 2:
                    Console.WriteLine("\nEnter book details:");
                    Console.Write("BookId: ");
                    int bookId = int.Parse(Console.ReadLine());
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Author: ");
                    string author = Console.ReadLine();
                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine();

                    Book newBook = new Book(bookId, title, author, isbn);
                    library.AddBook(newBook);
                    break;

                case 3:
                    Console.WriteLine("\nEnter the ISBN of the book to remove:");
                    string getByIsbn = Console.ReadLine();
                    library.RemoveBook(getByIsbn);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}