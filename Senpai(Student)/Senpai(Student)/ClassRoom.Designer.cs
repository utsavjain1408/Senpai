namespace Senpai_Student_
{
    partial class ClassRoom
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.TabPageStudyMaterial = new System.Windows.Forms.TabPage();
            this.tabPageQuorum = new System.Windows.Forms.TabPage();
            this.tabPageExam = new System.Windows.Forms.TabPage();
            this.tabPageLeave = new System.Windows.Forms.TabPage();
            this.buttonLeaveClassroom = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.TabPageStudyMaterial.SuspendLayout();
            this.tabPageExam.SuspendLayout();
            this.tabPageLeave.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Controls.Add(this.TabPageStudyMaterial);
            this.tabControl1.Controls.Add(this.tabPageQuorum);
            this.tabControl1.Controls.Add(this.tabPageExam);
            this.tabControl1.Controls.Add(this.tabPageLeave);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.label5);
            this.tabPageInfo.Controls.Add(this.label4);
            this.tabPageInfo.Controls.Add(this.label3);
            this.tabPageInfo.Controls.Add(this.label2);
            this.tabPageInfo.Controls.Add(this.label1);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Size = new System.Drawing.Size(382, 352);
            this.tabPageInfo.TabIndex = 4;
            this.tabPageInfo.Text = "Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // TabPageStudyMaterial
            // 
            this.TabPageStudyMaterial.Controls.Add(this.linkLabel1);
            this.TabPageStudyMaterial.Controls.Add(this.label6);
            this.TabPageStudyMaterial.Location = new System.Drawing.Point(4, 22);
            this.TabPageStudyMaterial.Name = "TabPageStudyMaterial";
            this.TabPageStudyMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageStudyMaterial.Size = new System.Drawing.Size(382, 352);
            this.TabPageStudyMaterial.TabIndex = 0;
            this.TabPageStudyMaterial.Text = "Study Material";
            this.TabPageStudyMaterial.UseVisualStyleBackColor = true;
            // 
            // tabPageQuorum
            // 
            this.tabPageQuorum.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuorum.Name = "tabPageQuorum";
            this.tabPageQuorum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuorum.Size = new System.Drawing.Size(382, 352);
            this.tabPageQuorum.TabIndex = 1;
            this.tabPageQuorum.Text = "Quorum";
            this.tabPageQuorum.UseVisualStyleBackColor = true;
            // 
            // tabPageExam
            // 
            this.tabPageExam.Controls.Add(this.label7);
            this.tabPageExam.Location = new System.Drawing.Point(4, 22);
            this.tabPageExam.Name = "tabPageExam";
            this.tabPageExam.Size = new System.Drawing.Size(382, 352);
            this.tabPageExam.TabIndex = 2;
            this.tabPageExam.Text = "Exams";
            this.tabPageExam.UseVisualStyleBackColor = true;
            // 
            // tabPageLeave
            // 
            this.tabPageLeave.Controls.Add(this.buttonLeaveClassroom);
            this.tabPageLeave.Controls.Add(this.label);
            this.tabPageLeave.Location = new System.Drawing.Point(4, 22);
            this.tabPageLeave.Name = "tabPageLeave";
            this.tabPageLeave.Size = new System.Drawing.Size(382, 352);
            this.tabPageLeave.TabIndex = 3;
            this.tabPageLeave.Text = "Settings";
            this.tabPageLeave.UseVisualStyleBackColor = true;
            // 
            // buttonLeaveClassroom
            // 
            this.buttonLeaveClassroom.Location = new System.Drawing.Point(54, 56);
            this.buttonLeaveClassroom.Name = "buttonLeaveClassroom";
            this.buttonLeaveClassroom.Size = new System.Drawing.Size(75, 23);
            this.buttonLeaveClassroom.TabIndex = 1;
            this.buttonLeaveClassroom.Text = "Leave!";
            this.buttonLeaveClassroom.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(28, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Leave Classroom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Books";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(91, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Coming Soon ";
            // 
            // ClassRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 402);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClassRoom";
            this.Text = "ClassRoom";
            this.Load += new System.EventHandler(this.ClassRoom_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.TabPageStudyMaterial.ResumeLayout(false);
            this.TabPageStudyMaterial.PerformLayout();
            this.tabPageExam.ResumeLayout(false);
            this.tabPageExam.PerformLayout();
            this.tabPageLeave.ResumeLayout(false);
            this.tabPageLeave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageStudyMaterial;
        private System.Windows.Forms.TabPage tabPageQuorum;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageExam;
        private System.Windows.Forms.TabPage tabPageLeave;
        private System.Windows.Forms.Button buttonLeaveClassroom;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}