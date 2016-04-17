using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G = System.Configuration;   // System.Configuration.dll
using D = System.Data;            // System.Data.dll
using C = System.Data.SqlClient;  // System.Data.dll
using T = System.Text;

namespace Senpai__Organization_
{
    public partial class SenpaiOrganization : Form
    {
        //C.SqlConnection cnDataCon =
          //new C.SqlConnection(G.ConfigurationManager.ConnectionStrings["cnExternalData"].ConnectionString);
        // dataset: Container object for data tables  
        DataSet dsData = new DataSet();
        public SenpaiOrganization()
        {
            InitializeComponent();
           
            x.a = "Hello World";
        }
        DataPassing x = new DataPassing();
        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard(x);
            d.Show();
            
        }

        private void SenpaiOrganization_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm CreateAccount = new SignUpForm();
            CreateAccount.Show();
        }
    }
}
