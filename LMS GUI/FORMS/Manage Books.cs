using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_GUI
{
    public partial class Manage_Books : Form
    {
        private static string connectionString = @"Data Source = JOSHWIN_FDO\SQLEXPRESS; Initial Catalog = library; Integrated Security = True"; // Replace with your actual connection string

        public Manage_Books()
        {
            InitializeComponent();
        }

        private void Manage_Books_Load(object sender, EventArgs e)
        {
            LoadAvailableBooks();
        }

        private void LoadAvailableBooks()
        {
            dataGridViewBooks.DataSource = DatabaseHelper.GetAvailableBooks();

            string query = "SELECT * FROM Books WHERE IsAvailable = 1"; // Assuming IsAvailable is a BIT column
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewBooks.DataSource = dataTable;
            }
        }

        private void availableBooksRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (availableBooksRBtn.Checked)
            {
                LoadAvailableBooks();
            }
        }

        private void LoadAllBooks()
        {
            dataGridViewBooks.DataSource = DatabaseHelper.GetAllBooks();

            string query = "SELECT * FROM Books";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewBooks.DataSource = dataTable;
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            // Get input values from textboxes
            int bookID;
            if (int.TryParse(bookIdTxt.Text, out bookID))
            {

            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the BookID.");
            }
            string title = bookTitleTxt.Text;
            string author = bookAuthorTxt.Text;
            string isbn = bookIsbnTxt.Text;
            bool isAvailable = true; // Assuming new books are always available

            // Add book to database
            if (DatabaseHelper.AddBook(bookID, title, author, isbn, isAvailable))
            {
                MessageBox.Show("Book added successfully.");
                LoadAllBooks(); // Refresh DataGridView after adding the book
            }
            else
            {
                MessageBox.Show("Failed to add book.");
            }
        }

        public void removeBookBtn_Click(object sender, EventArgs e)
        {
            // Get selected book's ID from DataGridView
            int bookID = Convert.ToInt32(dataGridViewBooks.CurrentRow.Cells["bookIDDataGridViewTextBoxColumn"].Value);

            // Remove book from database
            if (DatabaseHelper.RemoveBook(bookID))
            {
                MessageBox.Show("Book removed successfully.");
                LoadAllBooks(); // Refresh DataGridView after removing the book
            }
            else
            {
                MessageBox.Show("Failed to remove book.");
            }
        }

        private void issueBookBtn_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(dataGridViewBooks.CurrentRow.Cells["bookIDDataGridViewTextBoxColumn"].Value);

            Issue_Book issue_Book = new Issue_Book(bookID);
            issue_Book.Show();
        }

        private void existingBooksRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (existingBooksRBtn.Checked)
            {
                LoadAllBooks();
            }
        }
    }
}
