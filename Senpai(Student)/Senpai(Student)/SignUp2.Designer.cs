namespace Senpai_Student_
{
    partial class SignUp2
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
            this.LStream = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LSemester = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.LSession = new System.Windows.Forms.Label();
            this.BFindCollege = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic Info";
            // 
            // LStream
            // 
            this.LStream.AutoSize = true;
            this.LStream.Location = new System.Drawing.Point(54, 142);
            this.LStream.Name = "LStream";
            this.LStream.Size = new System.Drawing.Size(40, 13);
            this.LStream.TabIndex = 1;
            this.LStream.Text = "Stream";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Computer",
            "Civil",
            "Mechanical",
            "EC",
            "Automobile",
            "Chemical"});
            this.comboBox1.Location = new System.Drawing.Point(129, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // LSemester
            // 
            this.LSemester.AutoSize = true;
            this.LSemester.Location = new System.Drawing.Point(54, 104);
            this.LSemester.Name = "LSemester";
            this.LSemester.Size = new System.Drawing.Size(51, 13);
            this.LSemester.TabIndex = 3;
            this.LSemester.Text = "Semester";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Forth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Final"});
            this.comboBox2.Location = new System.Drawing.Point(129, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Odd",
            "Even"});
            this.comboBox3.Location = new System.Drawing.Point(129, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // LSession
            // 
            this.LSession.AutoSize = true;
            this.LSession.Location = new System.Drawing.Point(54, 70);
            this.LSession.Name = "LSession";
            this.LSession.Size = new System.Drawing.Size(44, 13);
            this.LSession.TabIndex = 6;
            this.LSession.Text = "Session";
            // 
            // BFindCollege
            // 
            this.BFindCollege.Location = new System.Drawing.Point(104, 197);
            this.BFindCollege.Name = "BFindCollege";
            this.BFindCollege.Size = new System.Drawing.Size(81, 22);
            this.BFindCollege.TabIndex = 7;
            this.BFindCollege.Text = "Find College";
            this.BFindCollege.UseVisualStyleBackColor = true;
            this.BFindCollege.Click += new System.EventHandler(this.BFindCollege_Click);
            // 
            // SignUp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BFindCollege);
            this.Controls.Add(this.LSession);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.LSemester);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LStream);
            this.Controls.Add(this.label1);
            this.Name = "SignUp2";
            this.Text = "Senpai For Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LStream;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LSemester;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label LSession;
        private System.Windows.Forms.Button BFindCollege;
    }
}