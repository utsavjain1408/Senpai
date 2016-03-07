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
    public partial class ClassRoom : Form
    {
        public ClassRoom()
        {
            InitializeComponent();
        }

        private void buttonLeaveClassroom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leaving so soon!");
        }
    }
}
