namespace Senpai_Student_
{
    partial class SignUp3
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
            this.LCity = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelAddCollege = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LNewCollegeName = new System.Windows.Forms.Label();
            this.PanelAddCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Let\'s find your College";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search College";
            // 
            // LCity
            // 
            this.LCity.AutoSize = true;
            this.LCity.Location = new System.Drawing.Point(37, 77);
            this.LCity.Name = "LCity";
            this.LCity.Size = new System.Drawing.Size(52, 13);
            this.LCity.TabIndex = 3;
            this.LCity.Text = "Enter City";
            this.LCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // BFinish
            // 
            this.BFinish.Location = new System.Drawing.Point(109, 250);
            this.BFinish.Name = "BFinish";
            this.BFinish.Size = new System.Drawing.Size(75, 23);
            this.BFinish.TabIndex = 6;
            this.BFinish.Text = "Finish";
            this.BFinish.UseVisualStyleBackColor = true;
            this.BFinish.Click += new System.EventHandler(this.BFinish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your are almost there!";
            // 
            // PanelAddCollege
            // 
            this.PanelAddCollege.Controls.Add(this.textBox1);
            this.PanelAddCollege.Controls.Add(this.LNewCollegeName);
            this.PanelAddCollege.Location = new System.Drawing.Point(48, 144);
            this.PanelAddCollege.Name = "PanelAddCollege";
            this.PanelAddCollege.Size = new System.Drawing.Size(237, 100);
            this.PanelAddCollege.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // LNewCollegeName
            // 
            this.LNewCollegeName.AutoSize = true;
            this.LNewCollegeName.Location = new System.Drawing.Point(3, 12);
            this.LNewCollegeName.Name = "LNewCollegeName";
            this.LNewCollegeName.Size = new System.Drawing.Size(101, 13);
            this.LNewCollegeName.TabIndex = 0;
            this.LNewCollegeName.Text = "Enter College Name";
            // 
            // SignUp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 335);
            this.Controls.Add(this.PanelAddCollege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BFinish);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp3";
            this.Text = "Senpai For Students";
            this.PanelAddCollege.ResumeLayout(false);
            this.PanelAddCollege.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LCity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelAddCollege;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LNewCollegeName;
    }
}