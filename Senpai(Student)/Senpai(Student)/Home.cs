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
    public partial class Home : Form
    {
        SessionValues sv;
        public Home()
        {
            InitializeComponent();
        }
        public Home(SessionValues temp)
        {
            InitializeComponent();
            sv = temp;
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonFindCla_Click(object sender, EventArgs e)
        {
            FindClassroom ob = new FindClassroom(sv);
            ob.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassRoom ob = new ClassRoom();
            ob.Show();
        }

        private void ButtonViewInfo_Click(object sender, EventArgs e)
        {
            ViewInfo ob = new ViewInfo(sv);
            ob.Show();
        }
    }
}
