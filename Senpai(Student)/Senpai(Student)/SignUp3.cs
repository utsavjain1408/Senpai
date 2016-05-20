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
    public partial class SignUp3 : Form
    {
        public SignUp3()
        {
            InitializeComponent();
        }
        SignUpData ob = new SignUpData();

        public SignUp3(SignUpData temp)
        {
            InitializeComponent();
            ob = temp;
        }
        private void BFinish_Click(object sender, EventArgs e)
        {
            string Errors="";
            if (TBCity.Text == "")
            {
                Errors += "Please Enter City.";
            }
            if (TBCollege.Text == "")
            {
                Errors += "\nPlease Enter Your College.";
            }
            if (StreamTextBox.Text == "")
            {
                Errors += "\nPlease Enter Your Stream.";
            }
            if (Errors != "")
            {
                MessageBox.Show(Errors);
            }
            else
            {
                ob.City = TBCity.Text;
                ob.College = TBCollege.Text;
                ob.Stream = StreamTextBox.Text;
                ob.AboutYourself = AboutYourselfRichTextBox.Text;
                SignUpFinal s = new SignUpFinal(ob, this);
                s.Visible = true;
            }
        }

        private void SignUp3_Load(object sender, EventArgs e)
        {

        }
    }
}
