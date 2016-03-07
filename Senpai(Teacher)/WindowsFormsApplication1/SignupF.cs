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
    public partial class SignupF : Form
    {
        public SignupF()
        {
            InitializeComponent();
        }

        private void SignupF_Load(object sender, EventArgs e)
        {

        }

        private void BSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entry Made. You may log in Now");
        }
    }
}
