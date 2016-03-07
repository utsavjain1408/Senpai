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
    public partial class Signup2 : Form
    {
        public Signup2()
        {
            InitializeComponent();
        }

        private void BFinish_Click(object sender, EventArgs e)
        {
            SignupF ob = new SignupF();
            ob.Show();
        }
    }
}
