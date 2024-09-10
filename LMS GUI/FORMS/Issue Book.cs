using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_GUI
{
    public partial class Issue_Book : Form
    {

        public Issue_Book(int bookID)
        {
            InitializeComponent();
            LoadAllStudents();
        }

        private void issueBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID;
                if (int.TryParse(studentIdTxt.Text, out studentID))
                {
                    // Get the Book ID from the textbox
                    int bookID = Convert.ToInt32(bookIdTxt.Text);

                    if (DatabaseHelper.IssueBook(bookID, studentID))
                    {
                        MessageBox.Show("Book issued successfully.");
                        RefreshTransactionGrid(); // Refresh transaction grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to issue book.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid student ID entered.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }

        private void LoadAllStudents()
        {
            dataGridViewStudentIssue2.DataSource = DatabaseHelper.GetAllStudents();
        }

        // Refresh the transaction grid
        private void RefreshTransactionGrid()
        {
            try
            {
                // Fetch transaction data from the database
                var transactions = DatabaseHelper.GetTransactionHistory();

                // Bind the transaction data to the DataGridView
                dataGridViewStudentIssue.DataSource = transactions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing transaction data: {ex.Message}");
            }
        }
    }
}
