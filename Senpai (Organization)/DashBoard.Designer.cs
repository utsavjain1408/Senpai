namespace Senpai__Organization_
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.CreateStaffroomButton = new System.Windows.Forms.Button();
            this.StaffRoomListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.ViewDetailButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateStaffroomButton
            // 
            this.CreateStaffroomButton.Location = new System.Drawing.Point(42, 237);
            this.CreateStaffroomButton.Name = "CreateStaffroomButton";
            this.CreateStaffroomButton.Size = new System.Drawing.Size(119, 23);
            this.CreateStaffroomButton.TabIndex = 0;
            this.CreateStaffroomButton.Text = "Create Staffroom";
            this.CreateStaffroomButton.UseVisualStyleBackColor = true;
            this.CreateStaffroomButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffRoomListComboBox
            // 
            this.StaffRoomListComboBox.FormattingEnabled = true;
            this.StaffRoomListComboBox.Location = new System.Drawing.Point(40, 147);
            this.StaffRoomListComboBox.Name = "StaffRoomListComboBox";
            this.StaffRoomListComboBox.Size = new System.Drawing.Size(121, 21);
            this.StaffRoomListComboBox.TabIndex = 1;
            this.StaffRoomListComboBox.SelectedIndexChanged += new System.EventHandler(this.StaffRoomListComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your StaffRooms";
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(63, 185);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 4;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ViewDetailButton
            // 
            this.ViewDetailButton.Location = new System.Drawing.Point(247, 147);
            this.ViewDetailButton.Name = "ViewDetailButton";
            this.ViewDetailButton.Size = new System.Drawing.Size(75, 23);
            this.ViewDetailButton.TabIndex = 6;
            this.ViewDetailButton.Text = "View Details";
            this.ViewDetailButton.UseVisualStyleBackColor = true;
            this.ViewDetailButton.Click += new System.EventHandler(this.ViewDetailButton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Senpai__Organization_.Properties.Resources.Refresh_Icon;
            this.button1.Location = new System.Drawing.Point(167, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Senpai__Organization_.Properties.Resources.Print2;
            this.pictureBox1.Location = new System.Drawing.Point(63, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewDetailButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StaffRoomListComboBox);
            this.Controls.Add(this.CreateStaffroomButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.Text = "Senpai For Organization";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateStaffroomButton;
        private System.Windows.Forms.ComboBox StaffRoomListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ViewDetailButton;
        private System.Windows.Forms.Button button1;
    }
}