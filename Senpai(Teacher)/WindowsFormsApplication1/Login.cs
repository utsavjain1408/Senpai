using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LSignUp_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            Home ob = new Home();
            ob.Show();
        }
    }
}
