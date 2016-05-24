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
    public partial class ClassRoom : Form
    {
        ClassRoomExamAnswers ob = new ClassRoomExamAnswers();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
        DataSet ds = new DataSet();
        SessionValues sv = new SessionValues();
        BindingSource bindingSource1 = new BindingSource();
        public ClassRoom(SessionValues ob)
        {
            InitializeComponent();
            sv = ob;
        }

        private void ClassRoom_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from ClassRoomTable WHERE ClassRoomID = @ClassroomID", conn);
            cmd.Parameters.AddWithValue("@ClassroomID",sv.ClassRoomID);
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            adapt.Fill(ds);
            conn.Close();
            NameL.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            CodeL.Text = ds.Tables[0].Rows[0]["Code"].ToString();
            SubjectL.Text = ds.Tables[0].Rows[0]["Subject"].ToString();
            DescriptionL.Text = ds.Tables[0].Rows[0]["Description"].ToString();
            Q1TB.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ1"].ToString();
            Q2TB.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ2"].ToString();
            Q3TB.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ3"].ToString();
            Q1AL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ1OptionA"].ToString();
            Q1BL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ1OptionB"].ToString();
            Q1CL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ1OptionC"].ToString();
            Q1DL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ1OptionD"].ToString();
            Q2AL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ2OptionA"].ToString();
            Q2BL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ2OptionB"].ToString();
            Q2CL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ2OptionC"].ToString();
            Q2DL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ2OptionD"].ToString();
            Q3AL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ3OptionA"].ToString();
            Q3BL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ3OptionB"].ToString();
            Q3CL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ3OptionC"].ToString();
            Q3DL.Text += ds.Tables[0].Rows[0]["ClassRoomExamQ3OptionD"].ToString();
            ob.A1 = ds.Tables[0].Rows[0]["AnswerQ1"].ToString();
            ob.A2 = ds.Tables[0].Rows[0]["AnswerQ2"].ToString();
            ob.A3 = ds.Tables[0].Rows[0]["AnswerQ3"].ToString();


            StudyMaterialGridView.DataSource = GetData("SELECT Title, Link FROM ClassRoomStudyMaterialTable WHERE ClassRoomID="+sv.ClassRoomID+"");

            // Resize the DataGridView columns to fit the newly loaded content.
            StudyMaterialGridView.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            QuorumDataGridView.DataSource = GetData("Select Time, SenderName, Message FROM ClassRoomQuorumTable Where ClassRoomID =" + sv.ClassRoomID + " ");
            // Resize the DataGridView columns to fit the newly loaded content.
            QuorumDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private DataTable GetData(string selectCommand)
        {
            DataTable table = new DataTable();
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.


                // Create a new data adapter based on the specified query.

                SqlDataAdapter DataAdapter = new SqlDataAdapter(selectCommand, conn);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(DataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                DataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                return table;

               
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
                return table;
            }

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (TBMessage.Text == "")
            {
                MessageBox.Show("Kindly Put Some Message.");
            }
            SqlCommand AddMessageQuery = new SqlCommand("INSERT INTO ClassRoomQuorumTable (SenderID,SenderName,ClassRoomID,Time, Message)Values(@SenderID,@SenderName,@ClassRoomID,@Time, @Message)", conn);
            AddMessageQuery.Parameters.AddWithValue("@SenderID", sv.SenpaiID);
            AddMessageQuery.Parameters.AddWithValue("@SenderName", sv.UserName);
            AddMessageQuery.Parameters.AddWithValue("@ClassRoomID", sv.ClassRoomID);
            AddMessageQuery.Parameters.AddWithValue("@Time", DateTime.Now);
            AddMessageQuery.Parameters.AddWithValue("@Message", TBMessage.Text);


            conn.Open();
            AddMessageQuery.ExecuteNonQuery();
            conn.Close();
            QuorumDataGridView.DataSource = GetData("Select Time, SenderName, Message FROM ClassRoomQuorumTable Where ClassRoomID =" + sv.ClassRoomID + " ");
            // Resize the DataGridView columns to fit the newly loaded content.
            QuorumDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void buttonLeaveClassroom_Click(object sender, EventArgs e)
        {
            SqlCommand DeleteUserFromClassRoomQuery = new SqlCommand("DELETE FROM ClassRoomMemberTable WHERE StudentID=@SenpaiId", conn);
            DeleteUserFromClassRoomQuery.Parameters.AddWithValue("@SenpaiId",sv.SenpaiID);
            conn.Open();
            DeleteUserFromClassRoomQuery.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sorry To See You Leave!!.");
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (Q1ComboBox.Text == ob.A1)
            {
                score++;
            }
            if (Q2ComboBox.Text == ob.A2)
            {
                score++;
            }
            if (Q3ComboBox.Text == ob.A3)
            {
                score++;
            }
            MessageBox.Show("Your score is "+score);
            SqlCommand InsertExamResult = new SqlCommand("UPDATE ClassRoomMemberTable SET ExamResult= @score WHERE MemberShipID =@mem  ", conn);
            InsertExamResult.Parameters.AddWithValue("@score",score);
            InsertExamResult.Parameters.AddWithValue("@mem", sv.MemberShipID);
            conn.Open();
            InsertExamResult.ExecuteNonQuery();
            conn.Close();

        }

        private void TBMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
