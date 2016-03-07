namespace Senpai_Student_
{
    partial class LoginForm
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
            this.LWelcome = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.LSignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LWelcome
            // 
            this.LWelcome.AutoSize = true;
            this.LWelcome.Location = new System.Drawing.Point(104, 21);
            this.LWelcome.Name = "LWelcome";
            this.LWelcome.Size = new System.Drawing.Size(55, 13);
            this.LWelcome.TabIndex = 0;
            this.LWelcome.Text = "Welcome!";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(37, 61);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 1;
            this.LEmail.Text = "Email";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(37, 108);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(53, 13);
            this.LPassword.TabIndex = 2;
            this.LPassword.Text = "Password";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(107, 58);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 4;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(107, 105);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 5;
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(87, 170);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(75, 23);
            this.BLogin.TabIndex = 6;
            this.BLogin.Text = "Log In";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // LSignUp
            // 
            this.LSignUp.AutoSize = true;
            this.LSignUp.Location = new System.Drawing.Point(92, 227);
            this.LSignUp.Name = "LSignUp";
            this.LSignUp.Size = new System.Drawing.Size(180, 13);
            this.LSignUp.TabIndex = 7;
            this.LSignUp.Text = "Don\'t Have an Account. Click Here!!";
            this.LSignUp.Click += new System.EventHandler(this.LSignUp_Click);
            // 
            // LoginForm
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
            this.Name = "LoginForm";
            this.Text = "Senpai For Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LWelcome;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label LSignUp;
    }
}

