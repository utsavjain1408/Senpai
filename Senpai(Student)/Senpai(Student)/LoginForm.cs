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
            Home ob = new Home();
            ob.Show();
        }
    }
}
