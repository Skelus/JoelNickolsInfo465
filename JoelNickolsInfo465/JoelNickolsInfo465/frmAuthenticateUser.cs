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

        frmMainPanel mainPanel = new frmMainPanel();
        public void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(global::JoelNickolsInfo465.Properties.Settings.Default.Database1ConnectionString);
            con.Open();

            string txtUser = txtLoginID.Text;
            string txtPass = txtPassword.Text;

            string query = "SELECT * FROM Users WHERE LoginId=@user AND Password =@password"; //check for valid userid and password
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@user",txtUser));
            cmd.Parameters.Add(new SqlParameter("@password", txtPass));


            SqlDataReader dr = cmd.ExecuteReader();

            //successful login
            if (dr.HasRows == true) 
            {
                lblAdvice.Text = "Login Successful";
                mainPanel.Show();
                this.Hide();
            }
            //failed login
            else
            {
                lblAdvice.ForeColor = Color.DarkRed;
                lblAdvice.Text = "Invalid Login";
            }
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
