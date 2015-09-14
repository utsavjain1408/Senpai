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
    public partial class SignUp2 : Form
    {
        public SignUp2()
        {
            InitializeComponent();
        }

        private void BFindCollege_Click(object sender, EventArgs e)
        {
            SignUp3 s = new SignUp3();
            s.Visible = true;
        }
    }
}
