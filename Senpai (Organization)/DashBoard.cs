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
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                StaffRoomListComboBox.DataSource = ds.Tables[0];
                StaffRoomListComboBox.ValueMember = "StaffRoomID";
                StaffRoomListComboBox.DisplayMember = "Name";
            }
            catch
            {
                MessageBox.Show("We are suffering from some technical difficulty. Kindly try again after some time");
            }
        }

        private void ViewDetailButton_Click(object sender, EventArgs e)
        {
            ViewDetails ob = new ViewDetails(x);
            ob.Show();
            
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            object a = StaffRoomListComboBox.SelectedValue;
            if (a == null)
            {
                MessageBox.Show("Kindly Select a value.");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from StaffRoomTable where StaffRoomID =@SelectID", conn);
                cmd.Parameters.AddWithValue("@SelectID", a);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                x.StaffRoomID = ds.Tables[0].Rows[0]["StaffRoomID"].ToString();
                StaffRoomSessionVariables sv = new StaffRoomSessionVariables();
                sv.StaffRoomName = ds.Tables[0].Rows[0]["Name"].ToString();
                sv.Subject = ds.Tables[0].Rows[0]["Subject"].ToString();
                sv.Department = ds.Tables[0].Rows[0]["Department"].ToString();
                sv.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                sv.StafffRoomID = ds.Tables[0].Rows[0]["StaffRoomID"].ToString();
                sv.HODName = x.HeadPersonName;
                StaffRoom ob = new StaffRoom(sv);
                ob.Show();
            }
        }

        private void StaffRoomListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from StaffRoomTable where CreatingOrganization =" + x.SenpaiId + "", conn);
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                StaffRoomListComboBox.DataSource = ds.Tables[0];
                StaffRoomListComboBox.ValueMember = "StaffRoomID";
                StaffRoomListComboBox.DisplayMember = "Name";
            }
            catch
            {
                MessageBox.Show("We are suffering from some technical difficulty. Kindly try again after some time");
            }
        }
    }
}
