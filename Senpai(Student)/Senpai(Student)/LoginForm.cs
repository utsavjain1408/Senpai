using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Senpai_Student_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LSignUp_Click(object sender, EventArgs e)
        {
            SignnUpForm s = new SignnUpForm();
          //  s.Visible = true;
            s.Show();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            changeloadingtotrue();
            String Error = " "; ;
            if (IsValidEmail(EmailTB.Text) != true)
            {
                Error += "Please Enter correct Email!!\n ";
            }
            if (EmailTB.Text == "")
            {
                Error += "Please Enter Email Address !!\n";
            }
            if (PasswordTB.Text == "")
            {
                Error += " Please Enter Password !!";
            }
            if (Error != " ")
            {
                changeloadingtotrue();
                MessageBox.Show(Error);
                LoadingLabel.Visible = false;
            }
            else
            {

                changeloadingtotrue();
                //LoadingLabel.Visible = true;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);

                SqlCommand cmd = new SqlCommand("Select * from Senpai_Student where Email=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", EmailTB.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTB.Text);
             //   try
             //   {
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show frmMain form
                    MessageBox.Show(count.ToString());
                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!");
                        SqlCommand cmd1 = new SqlCommand("Select * from Senpai_Student where Email=@username and Password=@password", con);
                        cmd1.Parameters.AddWithValue("@username", EmailTB.Text);
                        cmd1.Parameters.AddWithValue("@password",PasswordTB.Text);
                        con.Open();
                        SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
                        DataSet ds1 = new DataSet();
                        adapt1.Fill(ds1);
                        count = ds1.Tables[0].Columns.Count;

                        //MessageBox.Show(ds1.Tables[0].Rows[0]["Email"].ToString() + count);
                        SessionValues sv = new SessionValues();
                        sv.SenpaiID = ds1.Tables[0].Rows[0]["StudentSenpaiID"].ToString() ;
                        sv.Email = ds1.Tables[0].Rows[0]["Email"].ToString();
                        sv.UserName = ds1.Tables[0].Rows[0]["Name"].ToString();
                        sv.PhoneNumber = ds1.Tables[0].Rows[0]["PhoneNumber"].ToString();
                        sv.Gender = ds1.Tables[0].Rows[0]["Gender"].ToString();
                        sv.City = ds1.Tables[0].Rows[0]["City"].ToString();
                        sv.AboutYourself = ds1.Tables[0].Rows[0]["AboutYourself"].ToString();
                        Home ob = new Home(sv);
                        ob.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Login Failed.");
                        LoadingLabel.Visible = false;

                    }
              //  }
               // catch
//{
               //     MessageBox.Show("We are experiencing some technical difficulty. Kindly try again after some time.");
//}

            }

            
        }
        public void changeloadingtotrue()
        {

            LoadingLabel.Visible = true;
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
