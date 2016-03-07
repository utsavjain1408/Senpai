namespace Senpai_Student_
{
    partial class SignnUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RDMale = new System.Windows.Forms.RadioButton();
            this.RDFemale = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.BNext = new System.Windows.Forms.Button();
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Your Self";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Of Birth";
            // 
            // RDMale
            // 
            this.RDMale.AutoSize = true;
            this.RDMale.Location = new System.Drawing.Point(53, 9);
            this.RDMale.Name = "RDMale";
            this.RDMale.Size = new System.Drawing.Size(48, 17);
            this.RDMale.TabIndex = 6;
            this.RDMale.TabStop = true;
            this.RDMale.Text = "Male";
            this.RDMale.UseVisualStyleBackColor = true;
            // 
            // RDFemale
            // 
            this.RDFemale.AutoSize = true;
            this.RDFemale.Location = new System.Drawing.Point(107, 9);
            this.RDFemale.Name = "RDFemale";
            this.RDFemale.Size = new System.Drawing.Size(59, 17);
            this.RDFemale.TabIndex = 7;
            this.RDFemale.TabStop = true;
            this.RDFemale.Text = "Female";
            this.RDFemale.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.RDMale);
            this.Gender.Controls.Add(this.RDFemale);
            this.Gender.Location = new System.Drawing.Point(40, 183);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(210, 26);
            this.Gender.TabIndex = 8;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(133, 74);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 9;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(133, 100);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 10;
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(133, 129);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(100, 20);
            this.TBPhone.TabIndex = 11;
            // 
            // DTPDOB
            // 
            this.DTPDOB.Location = new System.Drawing.Point(133, 155);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(200, 20);
            this.DTPDOB.TabIndex = 12;
            // 
            // BNext
            // 
            this.BNext.Location = new System.Drawing.Point(138, 232);
            this.BNext.Name = "BNext";
            this.BNext.Size = new System.Drawing.Size(82, 26);
            this.BNext.TabIndex = 13;
            this.BNext.Text = "Next";
            this.BNext.UseVisualStyleBackColor = true;
            this.BNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignnUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 285);
            this.Controls.Add(this.BNext);
            this.Controls.Add(this.DTPDOB);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignnUpForm";
            this.Text = "Senpai for Students";
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RDMale;
        private System.Windows.Forms.RadioButton RDFemale;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.Button BNext;
    }
}