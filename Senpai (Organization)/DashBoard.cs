using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senpai__Organization_
{
    public partial class DashBoard : Form
    {   SessionData x = new SessionData();

        public DashBoard()
        {
            InitializeComponent();
        }
        public DashBoard(SessionData ob)
        {
            InitializeComponent();
            x = ob;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateStaffroom ob = new CreateStaffroom(x);
            ob.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void ViewDetailButton_Click(object sender, EventArgs e)
        {
            ViewDetails ob = new ViewDetails(x);
            ob.Show();
            this.Hide();
        }
    }
}
