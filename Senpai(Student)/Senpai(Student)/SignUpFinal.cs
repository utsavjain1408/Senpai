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
            MessageBox.Show("Select Password Now!!");
            PasswordPanel.Visible = true;
            PasswordPanel.Enabled = true;
        }

        private void SignUpFinal_Load(object sender, EventArgs e)
        {
            VName.Text = tempdata.Name;
            VPhone.Text = tempdata.PhoneNumber;
            VStream.Text = tempdata.Stream;
            VEmail.Text = tempdata.Email;
            VGender.Text = tempdata.Gender;
            VCollege.Text = tempdata.College;
            PasswordPanel.Visible = false;
            PasswordPanel.Enabled = false;

        }
    }
}
