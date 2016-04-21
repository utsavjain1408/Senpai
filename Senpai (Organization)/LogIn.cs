using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G = System.Configuration;   // System.Configuration.dll
using D = System.Data;            // System.Data.dll
using C = System.Data.SqlClient;  // System.Data.dll
using T = System.Text;
using System.Data.SqlClient;
using System.Configuration;


namespace Senpai__Organization_
{
    public partial class SenpaiOrganization : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
        SqlCommand CommandToGetEmail = null;
        SqlCommand CommandToGetPassword = null;
        public SenpaiOrganization()
        {
            InitializeComponent();
            EmailTB.Text = "";
            PasswordTB.Text = "";
        }
        DataPassing x = new DataPassing();
        private void button1_Click(object sender, EventArgs e)
        {
            String Error = " "; ;
            if (IsValidEmail(EmailTB.Text)!=true)
            {
                Error += "Please Enter correct Email!!\n ";
            }
            if (EmailTB.Text == "")
            {
                Error +="Please Enter Email Address !!\n";
            }
            if (PasswordTB.Text == "")
            {
                Error+=" Please Enter Password !!";
            }
            if (Error != " ")
            {
                MessageBox.Show(Error);
            }
            var appSettings = ConfigurationManager.AppSettings;
            string QueryStringToGetEmail = "select Email from Senpai_Organization where Email='("+EmailTB.Text+")'";
            string QueryStringToGetPassword = "select Password from Senpai_Organization where Email='(" + EmailTB.Text + ")'";
            conn.Open();
            CommandToGetEmail = new SqlCommand(QueryStringToGetEmail, conn);
            CommandToGetEmail.Parameters.ToString();
            CommandToGetEmail.CommandType = CommandType.Text;
            /*    object UserEmail = CommandToGetEmail.ExecuteNonQuery();

                if (UserEmail != null)
                {
                    CommandToGetPassword = new SqlCommand(QueryStringToGetPassword, conn);
                    CommandToGetPassword.Parameters.ToString();
                    CommandToGetPassword.CommandType = CommandType.Text;
                    object UserPassword = CommandToGetEmail.ExecuteScalar();
                    MessageBox.Show(UserEmail.ToString() + UserPassword.ToString());
                    //  
                }*/
            DashBoard d = new DashBoard(x);
            d.Show();
        }

        private void SenpaiOrganization_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm CreateAccount = new SignUpForm();
            CreateAccount.Show();
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
