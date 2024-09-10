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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            Manage_Books manage_Books = new Manage_Books();

            manage_Books.Show();

        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageStudentsBtn_Click(object sender, EventArgs e)
        {
            Manage_Students manage_Students = new Manage_Students();

            manage_Students.Show();
        }

        private void transactionHistoryBtn(object sender, EventArgs e)
        {
            Transaction_History transaction_History = new Transaction_History();
            transaction_History.ShowDialog();
        }
    }
}
