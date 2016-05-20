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
    public partial class SignUpFinal : Form
    {
        SignUp3 temp = new SignUp3();
        SignUpData tempdata = new SignUpData();
        public SignUpFinal()
        {
            InitializeComponent();
        }
        public SignUpFinal(SignUpData ob , SignUp3 ob1)
        {
            InitializeComponent();
            tempdata = ob;
            temp = ob1; 
        }


        private void BSubmit_Click(object sender, EventArgs e)
        {
            EditButton.Visible = true;
            ConfirmButton.Visible = true;
            SubmitButton.Visible = false;
            
        }

        private void SignUpFinal_Load(object sender, EventArgs e)
        {
            ConfirmPasswordTB.Text = "";
            PasswordTB.Text = "";
            NameTB.Text = tempdata.Name;
            PhoneTB.Text = tempdata.PhoneNumber;
            StreamTB.Text = tempdata.Stream;
            EmailTB.Text = tempdata.Email;
            GenderTB.Text = tempdata.Gender;
            CollegeTB.Text = tempdata.College;
            StreamTB.Text = tempdata.Stream;
            AboutYourselfRTB.Text = tempdata.AboutYourself;
            PasswordPanel.Visible = false;
            PasswordPanel.Enabled = false;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SubmitButton.Visible = true;
            EditButton.Visible = false;
            ConfirmButton.Visible = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select Password!");
            PasswordPanel.Visible = true;
            PasswordPanel.Enabled = true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string Errors = "";
            if (PasswordTB.Text != ConfirmPasswordTB.Text)
            {
                Errors += "Password and Confirm Password do not match!\n";
            }
            if (PasswordTB.Text.Length <= 6)
            {
                Errors += "\nPassword is too short.\n";
            }
            if (Errors != "")
            {
                MessageBox.Show(Errors);
            }
            else
            {

            }
            
        }
    }
}
