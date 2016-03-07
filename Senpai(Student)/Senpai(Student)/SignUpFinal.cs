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
        public SignUpFinal()
        {
            InitializeComponent();
        }

        private void BSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entry Made. You may log in Now");
        }
    }
}
