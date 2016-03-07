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

        private void BFinish_Click(object sender, EventArgs e)
        {
            SignUpFinal s = new SignUpFinal();
            s.Visible = true;
        }
    }
}
