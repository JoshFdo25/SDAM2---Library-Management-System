using System.Data;
using System.Data.SqlClient;

namespace LMS_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source = JOSHWIN_FDO\SQLEXPRESS; Initial Catalog = library; Integrated Security = True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("sp_login", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = usernameTxt.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = passwordTxt.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Mainmenu d = new Mainmenu();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!!!");
            }
            connection.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}