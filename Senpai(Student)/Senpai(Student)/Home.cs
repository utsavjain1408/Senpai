using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Senpai_Student_
{
    public partial class Home : Form
    {
        DataSet ds = new DataSet();
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
           
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from ClassRoomMemberTable WHERE StudentID =@StudentID ", conn);
            cmd.Parameters.AddWithValue("@StudentID", sv.SenpaiID);
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            adapt.Fill(ds);
            conn.Close();

            comboBoxClassroomSelector.DataSource = ds.Tables[0];
            comboBoxClassroomSelector.ValueMember = "ClassRoomID";
            comboBoxClassroomSelector.DisplayMember = "ClassRoomName";
            
           
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
           
            if (comboBoxClassroomSelector.SelectedValue == null)
            {
                MessageBox.Show("Kindly Select A ClassRoom.!");
            }
            else
            {
                sv.ClassRoomID = comboBoxClassroomSelector.SelectedValue.ToString();
                sv.MemberShipID = ds.Tables[0].Rows[0]["MemberShipID"].ToString();
                ClassRoom ob = new ClassRoom(sv);
                ob.Show();
            }
        }

        private void ButtonViewInfo_Click(object sender, EventArgs e)
        {
            ViewInfo ob = new ViewInfo(sv);
            ob.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
             ds = new DataSet();
            //ComboBox temp = new ComboBox();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from ClassRoomMemberTable WHERE StudentID =@StudentID ", conn);
            cmd.Parameters.AddWithValue("@StudentID", sv.SenpaiID);
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            adapt.Fill(ds);
            conn.Close();

            comboBoxClassroomSelector.DataSource = ds.Tables[0];
            comboBoxClassroomSelector.ValueMember = "ClassRoomID";
            comboBoxClassroomSelector.DisplayMember = "ClassRoomName";
            //comboBoxClassroomSelector = temp;
        }
    }
}
