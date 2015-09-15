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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StaffRoom ob = new StaffRoom();
            ob.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateClassRoom ob = new CreateClassRoom();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassRoom ob = new ClassRoom();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have no new request.");
        }
    }
}
