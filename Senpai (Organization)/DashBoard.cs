﻿using System;
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
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        public DashBoard(DataPassing ob)
        {
            InitializeComponent();
            x = ob;
        }
        DataPassing x = new DataPassing();

        private void button1_Click(object sender, EventArgs e)
        {
            CreateStaffroom ob = new CreateStaffroom();
            ob.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
