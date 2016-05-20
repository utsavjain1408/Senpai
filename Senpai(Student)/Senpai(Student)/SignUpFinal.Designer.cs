namespace Senpai_Student_
{
    partial class SignUpFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpFinal));
            this.LName = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LPhone = new System.Windows.Forms.Label();
            this.LGender = new System.Windows.Forms.Label();
            this.LCollege = new System.Windows.Forms.Label();
            this.LStream = new System.Windows.Forms.Label();
            this.BSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutYourselfLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutYourselfRTB = new System.Windows.Forms.RichTextBox();
            this.StreamTB = new System.Windows.Forms.TextBox();
            this.CollegeTB = new System.Windows.Forms.TextBox();
            this.GenderTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PasswordPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(54, 84);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 0;
            this.LName.Text = "Name";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(54, 113);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 1;
            this.LEmail.Text = "Email";
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Location = new System.Drawing.Point(54, 141);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(55, 13);
            this.LPhone.TabIndex = 2;
            this.LPhone.Text = "Phone No";
            // 
            // LGender
            // 
            this.LGender.AutoSize = true;
            this.LGender.Location = new System.Drawing.Point(54, 167);
            this.LGender.Name = "LGender";
            this.LGender.Size = new System.Drawing.Size(42, 13);
            this.LGender.TabIndex = 3;
            this.LGender.Text = "Gender";
            // 
            // LCollege
            // 
            this.LCollege.AutoSize = true;
            this.LCollege.Location = new System.Drawing.Point(54, 196);
            this.LCollege.Name = "LCollege";
            this.LCollege.Size = new System.Drawing.Size(42, 13);
            this.LCollege.TabIndex = 4;
            this.LCollege.Text = "College";
            // 
            // LStream
            // 
            this.LStream.AutoSize = true;
            this.LStream.Location = new System.Drawing.Point(54, 221);
            this.LStream.Name = "LStream";
            this.LStream.Size = new System.Drawing.Size(40, 13);
            this.LStream.TabIndex = 5;
            this.LStream.Text = "Stream";
            // 
            // BSubmit
            // 
            this.BSubmit.Location = new System.Drawing.Point(224, 320);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(75, 23);
            this.BSubmit.TabIndex = 6;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Senpai_Student_.Properties.Resources.Print_2;
            this.pictureBox1.Location = new System.Drawing.Point(40, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Controls.Add(this.SubmitButton);
            this.PasswordPanel.Controls.Add(this.ConfirmPasswordTB);
            this.PasswordPanel.Controls.Add(this.PasswordTB);
            this.PasswordPanel.Controls.Add(this.label2);
            this.PasswordPanel.Controls.Add(this.label1);
            this.PasswordPanel.Location = new System.Drawing.Point(15, 378);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(310, 121);
            this.PasswordPanel.TabIndex = 14;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(97, 78);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(92, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Create Account";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ConfirmPasswordTB
            // 
            this.ConfirmPasswordTB.Location = new System.Drawing.Point(136, 52);
            this.ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            this.ConfirmPasswordTB.PasswordChar = '*';
            this.ConfirmPasswordTB.Size = new System.Drawing.Size(162, 20);
            this.ConfirmPasswordTB.TabIndex = 3;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(136, 26);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(162, 20);
            this.PasswordTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // AboutYourselfLabel
            // 
            this.AboutYourselfLabel.AutoSize = true;
            this.AboutYourselfLabel.Location = new System.Drawing.Point(54, 244);
            this.AboutYourselfLabel.Name = "AboutYourselfLabel";
            this.AboutYourselfLabel.Size = new System.Drawing.Size(76, 13);
            this.AboutYourselfLabel.TabIndex = 15;
            this.AboutYourselfLabel.Text = "About Yourself";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AboutYourselfRTB);
            this.panel1.Controls.Add(this.StreamTB);
            this.panel1.Controls.Add(this.CollegeTB);
            this.panel1.Controls.Add(this.GenderTB);
            this.panel1.Controls.Add(this.PhoneTB);
            this.panel1.Controls.Add(this.EmailTB);
            this.panel1.Controls.Add(this.NameTB);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(127, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 238);
            this.panel1.TabIndex = 23;
            // 
            // AboutYourselfRTB
            // 
            this.AboutYourselfRTB.Location = new System.Drawing.Point(3, 172);
            this.AboutYourselfRTB.Name = "AboutYourselfRTB";
            this.AboutYourselfRTB.Size = new System.Drawing.Size(183, 61);
            this.AboutYourselfRTB.TabIndex = 29;
            this.AboutYourselfRTB.Text = "";
            // 
            // StreamTB
            // 
            this.StreamTB.Location = new System.Drawing.Point(3, 149);
            this.StreamTB.Name = "StreamTB";
            this.StreamTB.Size = new System.Drawing.Size(183, 20);
            this.StreamTB.TabIndex = 28;
            // 
            // CollegeTB
            // 
            this.CollegeTB.Location = new System.Drawing.Point(3, 124);
            this.CollegeTB.Name = "CollegeTB";
            this.CollegeTB.Size = new System.Drawing.Size(183, 20);
            this.CollegeTB.TabIndex = 27;
            // 
            // GenderTB
            // 
            this.GenderTB.Location = new System.Drawing.Point(3, 95);
            this.GenderTB.Name = "GenderTB";
            this.GenderTB.Size = new System.Drawing.Size(183, 20);
            this.GenderTB.TabIndex = 26;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(3, 69);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(183, 20);
            this.PhoneTB.TabIndex = 25;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(3, 41);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(183, 20);
            this.EmailTB.TabIndex = 24;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(3, 12);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(183, 20);
            this.NameTB.TabIndex = 23;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(130, 349);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 24;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(130, 320);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 25;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Visible = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SignUpFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 541);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AboutYourselfLabel);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.LStream);
            this.Controls.Add(this.LCollege);
            this.Controls.Add(this.LGender);
            this.Controls.Add(this.LPhone);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpFinal";
            this.Text = "SignUpFinal";
            this.Load += new System.EventHandler(this.SignUpFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.Label LGender;
        private System.Windows.Forms.Label LCollege;
        private System.Windows.Forms.Label LStream;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.TextBox ConfirmPasswordTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label AboutYourselfLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox AboutYourselfRTB;
        private System.Windows.Forms.TextBox StreamTB;
        private System.Windows.Forms.TextBox CollegeTB;
        private System.Windows.Forms.TextBox GenderTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}