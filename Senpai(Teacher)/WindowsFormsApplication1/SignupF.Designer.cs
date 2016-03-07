namespace WindowsFormsApplication1
{
    partial class SignupF
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
            this.BSubmit = new System.Windows.Forms.Button();
            this.LStream = new System.Windows.Forms.Label();
            this.LCollege = new System.Windows.Forms.Label();
            this.LGender = new System.Windows.Forms.Label();
            this.LPhone = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BSubmit
            // 
            this.BSubmit.Location = new System.Drawing.Point(98, 191);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(75, 21);
            this.BSubmit.TabIndex = 13;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // LStream
            // 
            this.LStream.AutoSize = true;
            this.LStream.Location = new System.Drawing.Point(32, 145);
            this.LStream.Name = "LStream";
            this.LStream.Size = new System.Drawing.Size(40, 13);
            this.LStream.TabIndex = 12;
            this.LStream.Text = "Stream";
            // 
            // LCollege
            // 
            this.LCollege.AutoSize = true;
            this.LCollege.Location = new System.Drawing.Point(32, 121);
            this.LCollege.Name = "LCollege";
            this.LCollege.Size = new System.Drawing.Size(42, 13);
            this.LCollege.TabIndex = 11;
            this.LCollege.Text = "College";
            // 
            // LGender
            // 
            this.LGender.AutoSize = true;
            this.LGender.Location = new System.Drawing.Point(32, 99);
            this.LGender.Name = "LGender";
            this.LGender.Size = new System.Drawing.Size(42, 13);
            this.LGender.TabIndex = 10;
            this.LGender.Text = "Gender";
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Location = new System.Drawing.Point(32, 75);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(55, 13);
            this.LPhone.TabIndex = 9;
            this.LPhone.Text = "Phone No";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(32, 51);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 8;
            this.LEmail.Text = "Email";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(32, 26);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 7;
            this.LName.Text = "Name";
            // 
            // SignupF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 247);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.LStream);
            this.Controls.Add(this.LCollege);
            this.Controls.Add(this.LGender);
            this.Controls.Add(this.LPhone);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LName);
            this.Name = "SignupF";
            this.Text = "SignupF";
            this.Load += new System.EventHandler(this.SignupF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.Label LStream;
        private System.Windows.Forms.Label LCollege;
        private System.Windows.Forms.Label LGender;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LName;
    }
}