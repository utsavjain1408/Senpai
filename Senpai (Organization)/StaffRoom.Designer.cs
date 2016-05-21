namespace Senpai__Organization_
{
    partial class StaffRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffRoom));
            this.TabRequests = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSubject = new System.Windows.Forms.TextBox();
            this.TBDepartment = new System.Windows.Forms.TextBox();
            this.RTBDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MemoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PublishMemoButton = new System.Windows.Forms.Button();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.MemoDetailRTB = new System.Windows.Forms.RichTextBox();
            this.MemoSubjectTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SendButton = new System.Windows.Forms.Button();
            this.LMessage = new System.Windows.Forms.Label();
            this.TBMessage = new System.Windows.Forms.TextBox();
            this.QuorumDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RequestPanel = new System.Windows.Forms.Panel();
            this.ReqConfirmB = new System.Windows.Forms.Button();
            this.ReqCancelB = new System.Windows.Forms.Button();
            this.RemovePanel = new System.Windows.Forms.Panel();
            this.ConfirmRemoveButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddMemberComboBox = new System.Windows.Forms.ComboBox();
            this.BRemove = new System.Windows.Forms.Button();
            this.RemoveMemberComboBox = new System.Windows.Forms.ComboBox();
            this.LRemove = new System.Windows.Forms.Label();
            this.LMenbers = new System.Windows.Forms.Label();
            this.MemberDataGridView = new System.Windows.Forms.DataGridView();
            this.TabRequests.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuorumDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.RequestPanel.SuspendLayout();
            this.RemovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabRequests
            // 
            this.TabRequests.Controls.Add(this.tabPage1);
            this.TabRequests.Controls.Add(this.tabPage3);
            this.TabRequests.Controls.Add(this.tabPage2);
            this.TabRequests.Controls.Add(this.tabPage4);
            this.TabRequests.Location = new System.Drawing.Point(12, 12);
            this.TabRequests.Name = "TabRequests";
            this.TabRequests.SelectedIndex = 0;
            this.TabRequests.Size = new System.Drawing.Size(382, 403);
            this.TabRequests.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LoadingLabel);
            this.tabPage1.Controls.Add(this.EditPanel);
            this.tabPage1.Controls.Add(this.EditButton);
            this.tabPage1.Controls.Add(this.TBName);
            this.tabPage1.Controls.Add(this.TBSubject);
            this.tabPage1.Controls.Add(this.TBDepartment);
            this.tabPage1.Controls.Add(this.RTBDescription);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.ForeColor = System.Drawing.Color.Maroon;
            this.LoadingLabel.Location = new System.Drawing.Point(41, 331);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(236, 25);
            this.LoadingLabel.TabIndex = 14;
            this.LoadingLabel.Text = "Loading! Making Changes!";
            this.LoadingLabel.Visible = false;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.CancelButton);
            this.EditPanel.Controls.Add(this.ConfirmButton);
            this.EditPanel.Enabled = false;
            this.EditPanel.Location = new System.Drawing.Point(222, 261);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(104, 100);
            this.EditPanel.TabIndex = 13;
            this.EditPanel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(17, 44);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(17, 15);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 11;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(130, 276);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // TBName
            // 
            this.TBName.Enabled = false;
            this.TBName.Location = new System.Drawing.Point(161, 37);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(165, 20);
            this.TBName.TabIndex = 7;
            // 
            // TBSubject
            // 
            this.TBSubject.Enabled = false;
            this.TBSubject.Location = new System.Drawing.Point(161, 82);
            this.TBSubject.Name = "TBSubject";
            this.TBSubject.Size = new System.Drawing.Size(165, 20);
            this.TBSubject.TabIndex = 8;
            // 
            // TBDepartment
            // 
            this.TBDepartment.Enabled = false;
            this.TBDepartment.Location = new System.Drawing.Point(161, 125);
            this.TBDepartment.Name = "TBDepartment";
            this.TBDepartment.Size = new System.Drawing.Size(165, 20);
            this.TBDepartment.TabIndex = 9;
            // 
            // RTBDescription
            // 
            this.RTBDescription.Enabled = false;
            this.RTBDescription.Location = new System.Drawing.Point(161, 176);
            this.RTBDescription.Name = "RTBDescription";
            this.RTBDescription.Size = new System.Drawing.Size(165, 62);
            this.RTBDescription.TabIndex = 10;
            this.RTBDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MemoDataGridView);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(374, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Memo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MemoDataGridView
            // 
            this.MemoDataGridView.AllowUserToAddRows = false;
            this.MemoDataGridView.AllowUserToDeleteRows = false;
            this.MemoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MemoDataGridView.Location = new System.Drawing.Point(6, 6);
            this.MemoDataGridView.Name = "MemoDataGridView";
            this.MemoDataGridView.Size = new System.Drawing.Size(362, 174);
            this.MemoDataGridView.TabIndex = 6;
            this.MemoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PublishMemoButton);
            this.panel1.Controls.Add(this.DetailsLabel);
            this.panel1.Controls.Add(this.SubjectLabel);
            this.panel1.Controls.Add(this.MemoDetailRTB);
            this.panel1.Controls.Add(this.MemoSubjectTextBox);
            this.panel1.Location = new System.Drawing.Point(26, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 185);
            this.panel1.TabIndex = 5;
            // 
            // PublishMemoButton
            // 
            this.PublishMemoButton.Location = new System.Drawing.Point(219, 149);
            this.PublishMemoButton.Name = "PublishMemoButton";
            this.PublishMemoButton.Size = new System.Drawing.Size(75, 23);
            this.PublishMemoButton.TabIndex = 8;
            this.PublishMemoButton.Text = "Publish";
            this.PublishMemoButton.UseVisualStyleBackColor = true;
            this.PublishMemoButton.Click += new System.EventHandler(this.PublishMemoButton_Click);
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(26, 67);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(39, 13);
            this.DetailsLabel.TabIndex = 7;
            this.DetailsLabel.Text = "Details";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(26, 32);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(43, 13);
            this.SubjectLabel.TabIndex = 5;
            this.SubjectLabel.Text = "Subject";
            // 
            // MemoDetailRTB
            // 
            this.MemoDetailRTB.Location = new System.Drawing.Point(122, 64);
            this.MemoDetailRTB.Name = "MemoDetailRTB";
            this.MemoDetailRTB.Size = new System.Drawing.Size(172, 79);
            this.MemoDetailRTB.TabIndex = 4;
            this.MemoDetailRTB.Text = "";
            // 
            // MemoSubjectTextBox
            // 
            this.MemoSubjectTextBox.Location = new System.Drawing.Point(122, 29);
            this.MemoSubjectTextBox.Name = "MemoSubjectTextBox";
            this.MemoSubjectTextBox.Size = new System.Drawing.Size(172, 20);
            this.MemoSubjectTextBox.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SendButton);
            this.tabPage2.Controls.Add(this.LMessage);
            this.tabPage2.Controls.Add(this.TBMessage);
            this.tabPage2.Controls.Add(this.QuorumDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quorum";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(228, 306);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // LMessage
            // 
            this.LMessage.AutoSize = true;
            this.LMessage.Location = new System.Drawing.Point(39, 282);
            this.LMessage.Name = "LMessage";
            this.LMessage.Size = new System.Drawing.Size(50, 13);
            this.LMessage.TabIndex = 2;
            this.LMessage.Text = "Message";
            // 
            // TBMessage
            // 
            this.TBMessage.Location = new System.Drawing.Point(42, 308);
            this.TBMessage.Name = "TBMessage";
            this.TBMessage.Size = new System.Drawing.Size(180, 20);
            this.TBMessage.TabIndex = 1;
            // 
            // QuorumDataGridView
            // 
            this.QuorumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuorumDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.QuorumDataGridView.Location = new System.Drawing.Point(16, 15);
            this.QuorumDataGridView.Name = "QuorumDataGridView";
            this.QuorumDataGridView.Size = new System.Drawing.Size(341, 247);
            this.QuorumDataGridView.TabIndex = 0;
            this.QuorumDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuorumDataGridView_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RequestPanel);
            this.tabPage4.Controls.Add(this.RemovePanel);
            this.tabPage4.Controls.Add(this.BAdd);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.AddMemberComboBox);
            this.tabPage4.Controls.Add(this.BRemove);
            this.tabPage4.Controls.Add(this.RemoveMemberComboBox);
            this.tabPage4.Controls.Add(this.LRemove);
            this.tabPage4.Controls.Add(this.LMenbers);
            this.tabPage4.Controls.Add(this.MemberDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(374, 377);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Members";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RequestPanel
            // 
            this.RequestPanel.Controls.Add(this.ReqConfirmB);
            this.RequestPanel.Controls.Add(this.ReqCancelB);
            this.RequestPanel.Location = new System.Drawing.Point(174, 299);
            this.RequestPanel.Name = "RequestPanel";
            this.RequestPanel.Size = new System.Drawing.Size(197, 28);
            this.RequestPanel.TabIndex = 9;
            this.RequestPanel.Visible = false;
            // 
            // ReqConfirmB
            // 
            this.ReqConfirmB.Location = new System.Drawing.Point(112, 2);
            this.ReqConfirmB.Name = "ReqConfirmB";
            this.ReqConfirmB.Size = new System.Drawing.Size(75, 23);
            this.ReqConfirmB.TabIndex = 1;
            this.ReqConfirmB.Text = "Confirm";
            this.ReqConfirmB.UseVisualStyleBackColor = true;
            this.ReqConfirmB.Click += new System.EventHandler(this.ReqConfirmB_Click);
            // 
            // ReqCancelB
            // 
            this.ReqCancelB.Location = new System.Drawing.Point(3, 2);
            this.ReqCancelB.Name = "ReqCancelB";
            this.ReqCancelB.Size = new System.Drawing.Size(75, 23);
            this.ReqCancelB.TabIndex = 0;
            this.ReqCancelB.Text = "Cancel";
            this.ReqCancelB.UseVisualStyleBackColor = true;
            this.ReqCancelB.Click += new System.EventHandler(this.ReqCancelB_Click);
            // 
            // RemovePanel
            // 
            this.RemovePanel.Controls.Add(this.ConfirmRemoveButton);
            this.RemovePanel.Controls.Add(this.NoButton);
            this.RemovePanel.Location = new System.Drawing.Point(181, 238);
            this.RemovePanel.Name = "RemovePanel";
            this.RemovePanel.Size = new System.Drawing.Size(197, 28);
            this.RemovePanel.TabIndex = 8;
            this.RemovePanel.Visible = false;
            // 
            // ConfirmRemoveButton
            // 
            this.ConfirmRemoveButton.Location = new System.Drawing.Point(112, 2);
            this.ConfirmRemoveButton.Name = "ConfirmRemoveButton";
            this.ConfirmRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmRemoveButton.TabIndex = 1;
            this.ConfirmRemoveButton.Text = "Confirm";
            this.ConfirmRemoveButton.UseVisualStyleBackColor = true;
            this.ConfirmRemoveButton.Click += new System.EventHandler(this.ConfirmRemoveButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(3, 2);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 0;
            this.NoButton.Text = "Cancel";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(253, 272);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 7;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Requests";
            // 
            // AddMemberComboBox
            // 
            this.AddMemberComboBox.FormattingEnabled = true;
            this.AddMemberComboBox.Location = new System.Drawing.Point(108, 272);
            this.AddMemberComboBox.Name = "AddMemberComboBox";
            this.AddMemberComboBox.Size = new System.Drawing.Size(121, 21);
            this.AddMemberComboBox.TabIndex = 5;
            // 
            // BRemove
            // 
            this.BRemove.Location = new System.Drawing.Point(253, 209);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(75, 23);
            this.BRemove.TabIndex = 4;
            this.BRemove.Text = "Remove";
            this.BRemove.UseVisualStyleBackColor = true;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // RemoveMemberComboBox
            // 
            this.RemoveMemberComboBox.FormattingEnabled = true;
            this.RemoveMemberComboBox.Location = new System.Drawing.Point(108, 211);
            this.RemoveMemberComboBox.Name = "RemoveMemberComboBox";
            this.RemoveMemberComboBox.Size = new System.Drawing.Size(121, 21);
            this.RemoveMemberComboBox.TabIndex = 3;
            // 
            // LRemove
            // 
            this.LRemove.AutoSize = true;
            this.LRemove.Location = new System.Drawing.Point(20, 214);
            this.LRemove.Name = "LRemove";
            this.LRemove.Size = new System.Drawing.Size(47, 13);
            this.LRemove.TabIndex = 2;
            this.LRemove.Text = "Remove";
            // 
            // LMenbers
            // 
            this.LMenbers.AutoSize = true;
            this.LMenbers.Location = new System.Drawing.Point(17, 9);
            this.LMenbers.Name = "LMenbers";
            this.LMenbers.Size = new System.Drawing.Size(50, 13);
            this.LMenbers.TabIndex = 1;
            this.LMenbers.Text = "Members";
            // 
            // MemberDataGridView
            // 
            this.MemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MemberDataGridView.Location = new System.Drawing.Point(6, 25);
            this.MemberDataGridView.Name = "MemberDataGridView";
            this.MemberDataGridView.Size = new System.Drawing.Size(362, 152);
            this.MemberDataGridView.TabIndex = 0;
            // 
            // StaffRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 427);
            this.Controls.Add(this.TabRequests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffRoom";
            this.Text = "StaffRoom";
            this.Load += new System.EventHandler(this.StaffRoom_Load);
            this.TabRequests.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuorumDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.RequestPanel.ResumeLayout(false);
            this.RemovePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabRequests;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSubject;
        private System.Windows.Forms.TextBox TBDepartment;
        private System.Windows.Forms.RichTextBox RTBDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView MemoDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PublishMemoButton;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.RichTextBox MemoDetailRTB;
        private System.Windows.Forms.TextBox MemoSubjectTextBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label LMessage;
        private System.Windows.Forms.TextBox TBMessage;
        private System.Windows.Forms.DataGridView QuorumDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AddMemberComboBox;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.ComboBox RemoveMemberComboBox;
        private System.Windows.Forms.Label LRemove;
        private System.Windows.Forms.Label LMenbers;
        private System.Windows.Forms.DataGridView MemberDataGridView;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Panel RemovePanel;
        private System.Windows.Forms.Button ConfirmRemoveButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Panel RequestPanel;
        private System.Windows.Forms.Button ReqConfirmB;
        private System.Windows.Forms.Button ReqCancelB;
    }
}