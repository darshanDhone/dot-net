using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DataBaseApp
{
    public partial class FrmLogin : Form
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=training;Integrated Security=True");

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //parametarized query
            string sql = "select count(*) from userdata where username=@name and password=@pwd";

            SqlCommand command = new SqlCommand(sql, connection);

            //pass value for parameter
            command.Parameters.AddWithValue("name",txtUsername.Text);
            command.Parameters.AddWithValue("pwd", txtPassword.Text);

            //open connection
            connection.Open();

            int count = (int)command.ExecuteScalar();
            connection.Close();

            if(count == 1)
            {
                label3.Text = "Valid User";
                label3.ForeColor = Color.DarkGreen;
            }
            else
            {
                label3.Text = "InValid Username or password";
                label3.ForeColor = Color.Red;
            }
        }
    }
}
