using System;
using System.Data;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static string connectionString = @"Data Source = JOSHWIN_FDO\SQLEXPRESS; Initial Catalog = library; Integrated Security = True"; // Replace with your actual connection string

    // Method to establish a connection to the database
    private static SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }

    // Method to execute SQL queries and retrieve data
    public static DataTable ExecuteQuery(string query)
    {
        using (SqlConnection connection = GetConnection())
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    // Method to insert, update, or delete data in the database
    public static bool ExecuteNonQuery(string query)
    {
        using (SqlConnection connection = GetConnection())
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    // Example method to insert a new book into the Books table
    public static bool AddBook(int bookID, string title, string author, string isbn, bool isAvailable)
    {
        string query = $"INSERT INTO Books (BookID, Title, Author, ISBN, IsAvailable) VALUES ('{bookID}', '{title}', '{author}', '{isbn}', '{true}')";
        return ExecuteNonQuery(query);
    }

    // Example method to remove a book from the Books table
    public static bool RemoveBook(int bookID)
    {
        string query = $"DELETE FROM Books WHERE BookID = {bookID}";
        return ExecuteNonQuery(query);
    }

    // Example method to retrieve available books from the Books table
    public static DataTable GetAvailableBooks()
    {
        string query = "SELECT * FROM Books WHERE IsAvailable = 1";
        return ExecuteQuery(query);
    }

    // Example method to retrieve all books from the Books table
    public static DataTable GetAllBooks()
    {
        string query = "SELECT * FROM Books";
        return ExecuteQuery(query);
    }

    // Example method to insert a new student into the Students table
    public static bool AddStudent(int studentID, string name, string department, int year)
    {
        string query = $"INSERT INTO Students (StudentID, Name, Department, Year) VALUES ({studentID}, '{name}', '{department}', {year})";
        return ExecuteNonQuery(query);
    }

    public static bool RemoveStudent(int studentID)
    {
        string query = $"DELETE FROM Students WHERE StudentID = {studentID}";
        return ExecuteNonQuery(query);
    }

    // Example method to retrieve all students from the Students table
    public static DataTable GetAllStudents()
    {
        string query = "SELECT * FROM Students";
        return ExecuteQuery(query);
    }

    // Example method to retrieve a student by ID from the Students table
    public static DataTable GetStudentByID(int studentID)
    {
        string query = $"SELECT * FROM Students WHERE StudentID = {studentID}";
        return ExecuteQuery(query);
    }

    // Example method to issue a book to a student
    public static bool IssueBook(int bookID, int studentID)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Begin a transaction
                    SqlTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;

                    try
                    {
                        // Update the IsAvailable flag of the book to false
                        command.CommandText = "UPDATE Books SET IsAvailable = 0 WHERE BookID = @BookID";
                        command.Parameters.AddWithValue("@BookID", bookID);
                        command.ExecuteNonQuery();

                        // Insert a new transaction record
                        command.CommandText = "INSERT INTO Transactions (BookID, StudentID, DateIssued) VALUES (@BookID, @StudentID, GETDATE())";
                        command.Parameters.Clear(); // Clear previous parameters
                        command.Parameters.AddWithValue("@BookID", bookID);
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction in case of failure
                        transaction.Rollback();
                        throw new Exception("Failed to issue book: " + ex.Message);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Database error: " + ex.Message);
        }
    }

    // Example method to retrieve transaction history
    public static DataTable GetTransactionHistory()
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Transactions";
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to get transaction details from the database: " + ex.Message);
        }
    }

    internal static bool RemoveBook(string bookID)
    {
        throw new NotImplementedException();
    }
}