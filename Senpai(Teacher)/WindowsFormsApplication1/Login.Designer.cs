namespace WindowsFormsApplication1
{
    partial class Login
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
            this.LSignUp = new System.Windows.Forms.Label();
            this.BLogin = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.LPassword = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LSignUp
            // 
            this.LSignUp.AutoSize = true;
            this.LSignUp.Location = new System.Drawing.Point(80, 227);
            this.LSignUp.Name = "LSignUp";
            this.LSignUp.Size = new System.Drawing.Size(180, 13);
            this.LSignUp.TabIndex = 14;
            this.LSignUp.Text = "Don\'t Have an Account. Click Here!!";
            this.LSignUp.Click += new System.EventHandler(this.LSignUp_Click);
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(75, 170);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(75, 23);
            this.BLogin.TabIndex = 13;
            this.BLogin.Text = "Log In";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(95, 105);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 12;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(95, 58);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 11;
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(25, 108);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(53, 13);
            this.LPassword.TabIndex = 10;
            this.LPassword.Text = "Password";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(25, 61);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 9;
            this.LEmail.Text = "Email";
            // 
            // LWelcome
            // 
            this.LWelcome.AutoSize = true;
            this.LWelcome.Location = new System.Drawing.Point(92, 21);
            this.LWelcome.Name = "LWelcome";
            this.LWelcome.Size = new System.Drawing.Size(55, 13);
            this.LWelcome.TabIndex = 8;
            this.LWelcome.Text = "Welcome!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LSignUp);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LWelcome);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LSignUp;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LWelcome;
    }
}

