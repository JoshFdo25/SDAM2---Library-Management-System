using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LMS_GUI.FORMS
{
    public partial class Select_Interface : Form
    {
        public Select_Interface()
        {
            InitializeComponent();
        }

        private void Select_Interface_Load(object sender, EventArgs e)
        {

        }

        private void cli_Btn_Click(object sender, EventArgs e)
        {
            string path = "\"C:\\Users\\joshw\\Desktop\\SDAM Assignment 2(Testing 4)\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net6.0\\ConsoleApp1.exe\"";
            Process.Start(path);
        }

        private void gui_Btn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
