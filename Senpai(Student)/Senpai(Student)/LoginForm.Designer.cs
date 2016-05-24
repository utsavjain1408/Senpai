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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LWelcome = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.LSignUp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LWelcome
            // 
            this.LWelcome.AutoSize = true;
            this.LWelcome.Location = new System.Drawing.Point(126, 125);
            this.LWelcome.Name = "LWelcome";
            this.LWelcome.Size = new System.Drawing.Size(55, 13);
            this.LWelcome.TabIndex = 0;
            this.LWelcome.Text = "Welcome!";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(59, 165);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 1;
            this.LEmail.Text = "Email";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(59, 196);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(53, 13);
            this.LPassword.TabIndex = 2;
            this.LPassword.Text = "Password";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(129, 162);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(100, 20);
            this.EmailTB.TabIndex = 4;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(129, 193);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 5;
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(106, 245);
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
            this.LSignUp.Location = new System.Drawing.Point(115, 290);
            this.LSignUp.Name = "LSignUp";
            this.LSignUp.Size = new System.Drawing.Size(180, 13);
            this.LSignUp.TabIndex = 7;
            this.LSignUp.Text = "Don\'t Have an Account. Click Here!!";
            this.LSignUp.Click += new System.EventHandler(this.LSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Senpai_Student_.Properties.Resources.Print_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Enabled = false;
            this.LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.ForeColor = System.Drawing.Color.Red;
            this.LoadingLabel.Location = new System.Drawing.Point(81, 170);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(159, 39);
            this.LoadingLabel.TabIndex = 10;
            this.LoadingLabel.Text = "Loading!!";
            this.LoadingLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 318);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LSignUp);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Senpai For Students";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LWelcome;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label LSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoadingLabel;
    }
}

