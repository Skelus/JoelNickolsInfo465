using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JoelNickolsInfo465
{
    public partial class frmAuthenticateUser : Form
    {
        public frmAuthenticateUser()
        {
            InitializeComponent();
        }

        private void frmAuthenticateUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(global::JoelNickolsInfo465.Properties.Settings.Default.Database1ConnectionString);
            con.Open();

            string txtUser = txtLoginID.Text;
            string txtPass = txtPassword.Text;

            string query = "SELECT * FROM Users WHERE LoginId=@user AND Password =@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@user",txtUser));
            cmd.Parameters.Add(new SqlParameter("@password", txtPass));


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true) //checks to see if WHERE condition is satisfied
            {
                MessageBox.Show("Login Successfull");
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
