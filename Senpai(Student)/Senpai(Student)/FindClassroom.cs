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
    public partial class FindClassroom : Form
    {
        SessionValues sv;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
        public FindClassroom(SessionValues ob)
        {
            InitializeComponent();
            sv = ob;
        }

        private void FindClassroom_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            
            SqlCommand cmd = new SqlCommand("Select * from ClassRoomTable", conn);
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            adapt.Fill(ds);
            conn.Close();
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "ClassRoomID";
            comboBox1.DisplayMember = "Name";
            String QueryToInsert = "INSERT INTO ClassRoomMemberTable (StudentID,StudentName,ClassRoomID,ClassRoomName)VALUES (@StudentID,@StudenName,@ClassRoomID,@ClassRoomName)";

            SqlCommand CommandToInsertIntoMembershipTable = new SqlCommand(QueryToInsert, conn);
            CommandToInsertIntoMembershipTable.Parameters.AddWithValue("@StudentID", sv.SenpaiID);
            CommandToInsertIntoMembershipTable.Parameters.AddWithValue("@StudenName", sv.UserName);
            CommandToInsertIntoMembershipTable.Parameters.AddWithValue("@ClassRoomID", comboBox1.SelectedValue);
            CommandToInsertIntoMembershipTable.Parameters.AddWithValue("@ClassRoomName", comboBox1.Text);
            conn.Open();
            CommandToInsertIntoMembershipTable.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("ClassRoom Added!");
        }
    }
}
