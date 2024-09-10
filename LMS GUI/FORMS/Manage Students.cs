using System;
using System.Collections;
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
    public partial class Manage_Students : Form
    {
        private static string connectionString = @"Data Source = JOSHWIN_FDO\SQLEXPRESS; Initial Catalog = library; Integrated Security = True"; // Replace with your actual connection string
        public Manage_Students()
        {
            InitializeComponent();

            LoadAllStudents();
        }

        private void Manage_Students_Load(object sender, EventArgs e)
        {
            LoadAllStudents();
        }

        private void LoadAllStudents()
        {
            dataGridViewStudents.DataSource = DatabaseHelper.GetAllStudents();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            // Get student information from TextBoxes
            int studentID = Convert.ToInt32(studentIdTxt.Text);
            string name = studentNameTxt.Text;
            string department = studentDepartmentTxt.Text;
            int year = Convert.ToInt32(studentYearTxt.Text);

            // Check if the student already exists
            if (CheckExistingStudent(studentID))
            {
                MessageBox.Show("Student with the same ID already exists.");
                return;
            }

            // Insert the student into the database
            string query = "INSERT INTO Students (StudentID, Name, Department, Year) VALUES (@StudentID, @Name, @Department, @Year)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@Year", year);


                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student added successfully.");
                        // Optionally, refresh DataGridView or update its data source to reflect the change

                        LoadStudents();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student.");
                    }
                }
            }

        }

        public void LoadStudents()
        {
            string query = "SELECT * FROM Students";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewStudents.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading students: " + ex.Message);
                    }
                }
            }
        }

        private bool CheckExistingStudent(int studentID)
        {
            string query = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        private void removeStudentBtn_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(dataGridViewStudents.CurrentRow.Cells["studentIDDataGridViewTextBoxColumn"].Value);

            // Remove book from database
            if (DatabaseHelper.RemoveStudent(studentID))
            {
                MessageBox.Show("Book removed successfully.");
                LoadAllStudents(); // Refresh DataGridView after removing the book
            }
            else
            {
                MessageBox.Show("Failed to remove book.");
            }
        }
    }
}
