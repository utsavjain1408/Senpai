using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Senpai_Student_
{
    public partial class SignUpFinal : Form
    {
        SignUp3 temp = new SignUp3();
        SignUpData tempdata = new SignUpData();
        SqlConnection ConnectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);

        public SignUpFinal()
        {
            InitializeComponent();
        }
        public SignUpFinal(SignUpData ob , SignUp3 ob1)
        {
            InitializeComponent();
            tempdata = ob;
            temp = ob1; 
        }


        private void BSubmit_Click(object sender, EventArgs e)
        {
            EditButton.Visible = true;
            ConfirmButton.Visible = true;
            SubmitButton.Visible = false;
            
        }

        private void SignUpFinal_Load(object sender, EventArgs e)
        {
            ConfirmPasswordTB.Text = "";
            PasswordTB.Text = "";
            NameTB.Text = tempdata.Name;
            PhoneTB.Text = tempdata.PhoneNumber;
            StreamTB.Text = tempdata.Stream;
            EmailTB.Text = tempdata.Email;
            GenderTB.Text = tempdata.Gender;
            CollegeTB.Text = tempdata.College;
            StreamTB.Text = tempdata.Stream;
            AboutYourselfRTB.Text = tempdata.AboutYourself;
            PasswordPanel.Visible = false;
            PasswordPanel.Enabled = false;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DetailsPanel.Enabled = true;
            SubmitButton.Visible = true;
            EditButton.Visible = false;
            ConfirmButton.Visible = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select Password!");
            DetailsPanel.Enabled = false;
            PasswordPanel.Visible = true;
            PasswordPanel.Enabled = true;
            SubmitButton.Visible = true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string Errors = "";
            if (PasswordTB.Text != ConfirmPasswordTB.Text)
            {
                Errors += "Password and Confirm Password do not match!\n";
            }
            if (PasswordTB.Text.Length <= 6)
            {
                Errors += "\nPassword is too short.\n";
            }
            if (Errors != "")
            {
                MessageBox.Show(Errors);
            }
            else
            {
                LoadingLabel.Visible = true;

                string InsertQuery = "INSERT INTO Senpai_Student (Name, Email, PhoneNumber, DateOfBirth, Gender, City, College, Stream, AboutYourself, Password) VALUES (@Name, @Email, @Phone, @DOB, @Gender,@City,@College,@Stream,@About,@Password)";
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureString"].ConnectionString);
                SqlCommand CommandToAddStudentAccount = new SqlCommand(InsertQuery, conn);
                CommandToAddStudentAccount.Parameters.AddWithValue("@Name", NameTB.Text);
                CommandToAddStudentAccount.Parameters.AddWithValue("@Email", EmailTB.Text);
                CommandToAddStudentAccount.Parameters.AddWithValue("@Phone", PhoneTB.Text);
                CommandToAddStudentAccount.Parameters.AddWithValue("@College", CollegeTB.Text);
                CommandToAddStudentAccount.Parameters.AddWithValue("@DOB", DateTime.UtcNow);
                CommandToAddStudentAccount.Parameters.AddWithValue("@Gender", GenderTB.Text);
                CommandToAddStudentAccount.Parameters.AddWithValue("@City", CityTB.Text);
                CommandToAddStudentAccount.Parameters.AddWithValue("@Stream", StreamTB.Text);
                CommandToAddStudentAccount.Parameters.AddWithValue("@About", AboutYourselfRTB.Text);
                CommandToAddStudentAccount.Parameters.AddWithValue("@Password", PasswordTB.Text);
                MessageBox.Show(InsertQuery);

                conn.Open();
                CommandToAddStudentAccount.ExecuteNonQuery();
                conn.Close();
                LoadingLabel.Visible = false;
                MessageBox.Show("Account Added. You can Sign In Now.");
                this.Close();
            }
            
        }
    }
}
