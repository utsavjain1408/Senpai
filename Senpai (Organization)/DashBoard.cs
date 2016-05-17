using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Senpai__Organization_
{
    public partial class DashBoard : Form
    {   SessionData x = new SessionData();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
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
            SqlCommand cmd = new SqlCommand("Select * from StaffRoomTable where CreatingOrganization ="+x.SenpaiId+"", conn);
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            conn.Close();
            StaffRoomListComboBox.DataSource = ds.Tables[0];
            StaffRoomListComboBox.ValueMember = "StaffRoomID";
            StaffRoomListComboBox.DisplayMember = "Name";

        }

        private void ViewDetailButton_Click(object sender, EventArgs e)
        {
            ViewDetails ob = new ViewDetails(x);
            ob.Show();
            this.Hide();
        }
    }
}
