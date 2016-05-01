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
            MessageBox.Show("Entry Made. You may log in Now");
        }

        private void SignUpFinal_Load(object sender, EventArgs e)
        {

        }
    }
}
