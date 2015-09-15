namespace WindowsFormsApplication1
{
    partial class Signup
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
            this.BNext = new System.Windows.Forms.Button();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.RDMale = new System.Windows.Forms.RadioButton();
            this.RDFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // BNext
            // 
            this.BNext.Location = new System.Drawing.Point(122, 226);
            this.BNext.Name = "BNext";
            this.BNext.Size = new System.Drawing.Size(82, 26);
            this.BNext.TabIndex = 24;
            this.BNext.Text = "Next";
            this.BNext.UseVisualStyleBackColor = true;
            this.BNext.Click += new System.EventHandler(this.BNext_Click);
            // 
            // DTPDOB
            // 
            this.DTPDOB.Location = new System.Drawing.Point(117, 149);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(200, 20);
            this.DTPDOB.TabIndex = 23;
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(117, 123);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(100, 20);
            this.TBPhone.TabIndex = 22;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(117, 94);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 21;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(117, 68);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 20;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.RDMale);
            this.Gender.Controls.Add(this.RDFemale);
            this.Gender.Location = new System.Drawing.Point(24, 177);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(210, 26);
            this.Gender.TabIndex = 19;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Register Your Self";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 275);
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
            this.Name = "Signup";
            this.Text = "Form1";
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BNext;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton RDMale;
        private System.Windows.Forms.RadioButton RDFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}