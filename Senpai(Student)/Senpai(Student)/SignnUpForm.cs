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
    public partial class SignnUpForm : Form
    {
        public SignnUpForm()
        {
            InitializeComponent();
        }
        SignUpData ob = new SignUpData();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Gender;
            String Errors = "";
            if (TBName.Text == "")
            {
                Errors += "Kindly, Enter Name\n";
            }
            if (TBEmail.Text == "")
            {
                Errors += "Kindly, Enter Email\n";
            }
            if (TBPhone.Text == "")
            {
                Errors += "Kindly, Enter Phone Number\n";
            }
            if (RDMale.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            bool flag = true;

            if (flag)
            {
                SqlCommand cmd = new SqlCommand("Select * from Senpai_Student where Email=@username ", conn);
                cmd.Parameters.AddWithValue("@username", TBEmail.Text);
                try
                {
                    conn.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    conn.Close();
                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show frmMain form
                    MessageBox.Show(count.ToString());
                    if (count == 1)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                catch
                {
                    MessageBox.Show("We are experiencing some technical difficulties. Please try againg after som time.");
                }
            }
            if (flag == false)
            {
                Errors += "\nThis Email address is already registered. Kindly try a different Address.";
            }
            if (Errors == "")
            {
                ob.Name = TBName.Text;
                ob.PhoneNumber = TBPhone.Text;
                ob.Gender = Gender;
                ob.DOB = DTPDOB.Value;
                ob.Email = TBEmail.Text;
                this.Visible = false;
                SignUp3 s = new SignUp3(ob);
                s.Enabled = true;
                s.Visible = true;
            }
            else
            {
                MessageBox.Show(Errors);
            }
        }

        private void SignnUpForm_Load(object sender, EventArgs e)
        {
            TBName.Text = "";
            TBEmail.Text = "";
            TBPhone.Text = "";
            DTPDOB.Text = "";

        }
    }
}
