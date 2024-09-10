using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS_GUI
{
    public partial class Transaction_History : Form
    {
        public Transaction_History()
        {
            InitializeComponent();
            RefreshTransactionGrid();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            RefreshTransactionGrid();
        }

        private void RefreshTransactionGrid()
        {
            try
            {
                DataTable dt = DatabaseHelper.GetTransactionHistory();
                dataGridViewTransactions.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to refresh transaction history: " + ex.Message);
            }
        }

        private void transactionHistoryButton_Click(object sender, EventArgs e)
        {
            RefreshTransactionGrid();
        }

        public void LoadTransactionHistory()
        {
            try
            {
                dataGridViewTransactions.DataSource = DatabaseHelper.GetTransactionHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading transaction history: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaction_History_Load(object sender, EventArgs e)
        {

        }
    }
}
