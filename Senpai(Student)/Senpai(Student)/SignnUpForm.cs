using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Senpai_Student_
{
    public partial class SignnUpForm : Form
    {
        public SignnUpForm()
        {
            InitializeComponent();
        }
        SignUpData ob = new SignUpData();
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
