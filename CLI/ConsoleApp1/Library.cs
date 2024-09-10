
using System.Data.SqlClient;

class Library
{
    private string connectionString = "Data Source=JOSHWIN_FDO\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

    public void AddBook(Book book)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Books (BookID, Title, Author, ISBN, IsAvailable) VALUES (@BookID, @Title, @Author, @ISBN, @IsAvailable)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", book.BookID);
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@ISBN", book.ISBN);
            command.Parameters.AddWithValue("@IsAvailable", book.IsAvailable);
            command.ExecuteNonQuery();
        }
    }

    public void RemoveBook(string isbn)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Books WHERE ISBN = @ISBN";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ISBN", isbn);
            command.ExecuteNonQuery();
        }
    }

    public void DisplayAvailableBooks()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Books WHERE IsAvailable = 1";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"BookId: {reader["BookId"]}\nTitle: {reader["Title"]}\nAuthor: {reader["Author"]}\nISBN: {reader["ISBN"]}\nAvailable: {reader["IsAvailable"]}\n");
            }
        }
    }

    internal void RemoveBook(Book book)
    {
        throw new NotImplementedException();
    }
}