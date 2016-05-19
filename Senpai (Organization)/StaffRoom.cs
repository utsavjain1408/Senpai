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
    public partial class StaffRoom : Form
    {
        public StaffRoom()
        {
            InitializeComponent();
        }
        StaffRoomSessionVariables sv;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
        BindingSource MemoBindingSource = new BindingSource();
        DataSet StaffRoomRequestTableDataSet = new DataSet();
        public StaffRoom(StaffRoomSessionVariables ob)
        {
            InitializeComponent();
            sv = ob;
            TBName.Text = sv.StaffRoomName;
            TBSubject.Text = sv.Subject;
            TBDepartment.Text = sv.Department;
            RTBDescription.Text = sv.Description;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffRoom_Load(object sender, EventArgs e)
        {
            //Filling Memo Table
            MemoDataGridView.DataSource = MemoBindingSource;
            MemoDataGridView.DataSource = GetData("Select DataAndTime, Subject, Message FROM StaffRoomMemoTable Where StaffRoomID ="+ sv.StafffRoomID+" ");
            // Resize the DataGridView columns to fit the newly loaded content.
            MemoDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            QuorumDataGridView.DataSource = MemoBindingSource;
            QuorumDataGridView.DataSource = GetData("Select DataAndTime, Sender, Message FROM StaffRoomQuorumTable Where StaffRoomID =" + sv.StafffRoomID + " ");
            // Resize the DataGridView columns to fit the newly loaded content.
            QuorumDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            MemberDataGridView.DataSource = MemoBindingSource;
            MemberDataGridView.DataSource = GetData("Select TeacherName, Email FROM StaffRoomMemberList Where StaffRoomID =" + sv.StafffRoomID + " ");
            // Resize the DataGridView columns to fit the newly loaded content.
            MemberDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            //Filling the RemoveMemberComboBox
            SqlCommand RemoveMemberQuery = new SqlCommand("Select * from StaffRoomMemberList where StaffRoomID =" + sv.StafffRoomID + "", conn);
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(RemoveMemberQuery);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                RemoveMemberComboBox.DataSource = ds.Tables[0];
                RemoveMemberComboBox.ValueMember = "StaffRoomMembershipID";
                RemoveMemberComboBox.DisplayMember = "TeacherName";
            }
            catch
            {
                MessageBox.Show("We are suffering from some technical difficulty. Kindly try again after some time");
            }
            //Filling the AddMemberComboBox
            SqlCommand AddMemberQuery = new SqlCommand("Select * from StaffRoomRequestTable where RequestedStaffRoomID =" + sv.StafffRoomID + "", conn);
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(AddMemberQuery);
                
                adapt.Fill(StaffRoomRequestTableDataSet);
                conn.Close();
                AddMemberComboBox.DataSource = StaffRoomRequestTableDataSet.Tables[0];
                AddMemberComboBox.ValueMember = "RequestID";
                AddMemberComboBox.DisplayMember = "TeacherName";
            }
            catch
            {
                MessageBox.Show("We are suffering from some technical difficulty. Kindly try again after some time");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            TBName.Enabled = true;
            TBSubject.Enabled = true;
            TBDepartment.Enabled = true;
            RTBDescription.Enabled = true;
            EditButton.Enabled = false;
            EditPanel.Visible = true;
            EditPanel.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            TBName.Enabled = false;
            TBSubject.Enabled = false;
            TBDepartment.Enabled = false;
            RTBDescription.Enabled = false;
            EditButton.Enabled = true;
            EditPanel.Visible = false;
            EditPanel.Enabled = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            LoadingLabel.Visible = true;
            if (TBName.Text == "" || TBDepartment.Text == "" || RTBDescription.Text == "" || TBSubject.Text == "")
            {
                MessageBox.Show("Kindly Fill all the Fields carefully!");
            }
            else
            {

                SqlCommand CommandToUpdateStaffRoomTable = new SqlCommand("UPDATE StaffRoomTable SET Name='" + TBName.Text + "', Subject='" + TBSubject.Text + "', Department='" + TBDepartment.Text + "', Description='" + RTBDescription.Text + "'  WHERE StaffRoomID ='" + sv.StafffRoomID + "' ", conn);
                //try
                {
                    conn.Open();
                    CommandToUpdateStaffRoomTable.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Update SuccessFull!! \nKindly Restart The Application!!");
                    this.Close();
                    LoadingLabel.Visible = false;
                    EditButton.Enabled = true;
                    EditButton.Visible = true;
                    EditPanel.Visible = false;
                }
               // catch (Exception)
              //  {
                 //   MessageBox.Show("Database Error !!\n Try Again after some time!! \n Sorry for inconvenience.");
              //      this.Close();
            //    }

            }

        }
        private BindingSource GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.

                BindingSource bindingSource1 = new BindingSource();
                // Create a new data adapter based on the specified query.

                SqlDataAdapter DataAdapter = new SqlDataAdapter(selectCommand, conn);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(DataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                DataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                return bindingSource1;
                
                
            }
            catch (SqlException)
            {
                MessageBox.Show("We are experiencing some technical difficulties. Please try again later!");
                BindingSource bindingSource1 = new BindingSource();
                return bindingSource1;
            }
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            RemovePanel.Visible = true;
            BRemove.Visible = false;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            BRemove.Visible = true;
            RemovePanel.Visible = false;
        }

        private void ConfirmRemoveButton_Click(object sender, EventArgs e)
        {
            BRemove.Visible = true;
            RemovePanel.Visible = false;
            SqlCommand CommandToDeleteMember = new SqlCommand("DELETE FROM StaffRoomMemberList WHERE StaffRoomMembershipID = "+RemoveMemberComboBox.ValueMember+" ", conn);
                     
                conn.Open();
                CommandToDeleteMember.ExecuteNonQuery();
                conn.Close();

                

        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            RequestPanel.Visible = true;
            BAdd.Visible = false;

        }

        private void ReqCancelB_Click(object sender, EventArgs e)
        {
            BAdd.Visible = true;
            RequestPanel.Visible = false;
        }

        private void ReqConfirmB_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(AddMemberComboBox.ValueMember.ToString());
            Object a = StaffRoomRequestTableDataSet.Tables[0].Rows[ID]["Email"];
            SqlCommand CommandToAddMember = new SqlCommand("INSERT INTO StaffRoomMemberList (StaffRoomID, TeacherName, TeacherID) VALUES ('"+sv.StafffRoomID+"', '"+AddMemberComboBox.Text + "','"+AddMemberComboBox.SelectedValue + "')", conn);

            conn.Open();
            CommandToAddMember.ExecuteNonQuery();
            conn.Close();
        }
    }
}
