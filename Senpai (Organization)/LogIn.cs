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
        public SenpaiOrganization()
        {
            InitializeComponent();
            EmailTB.Text = "";
            PasswordTB.Text = "";
        }
        //DataPassing x = new DataPassing();
        private void button1_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("Select * from College where Email=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", EmailTB.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTB.Text);
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
                    SqlCommand cmd1 = new SqlCommand("Select * from Senpai_Organization where Email=@username", con);
                    cmd1.Parameters.AddWithValue("@username", EmailTB.Text);
                    con.Open();
                    SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
                    DataSet ds1 = new DataSet();
                    adapt1.Fill(ds1);
                    count = ds1.Tables[0].Columns.Count;

                    MessageBox.Show(ds1.Tables[0].Rows[0]["Email"].ToString()+count);
                    SessionData sv = new SessionData();
                    sv.SenpaiId = ds1.Tables[0].Rows[0]["College_Id"].ToString(); ;
                    sv.Email = ds1.Tables[0].Rows[0]["Email"].ToString();
                    sv.Name = ds1.Tables[0].Rows[0]["InstituteName"].ToString();
                    sv.PhoneNumber = ds1.Tables[0].Rows[0]["PhoneNumber"].ToString();
                    sv.HeadPersonName = ds1.Tables[0].Rows[0]["HeadPersonName"].ToString();
                    sv.City = ds1.Tables[0].Rows[0]["City"].ToString();
                    sv.AboutUs = ds1.Tables[0].Rows[0]["AboutUs"].ToString();
                    sv.StaffroomListId = ds1.Tables[0].Rows[0]["StaffRoomListTable"].ToString();
                    DashBoard d = new DashBoard(sv);
                    d.Show();
                    this.Visible=false;
                }
                else
                {
                    MessageBox.Show("Login Failed.");
                    LoadingLabel.Visible = false;

                }
            }
        }

        private void SenpaiOrganization_Load(object sender, EventArgs e)
        {

        }
        public void changeloadingtotrue()
        {
            
            LoadingLabel.Visible = true;
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
