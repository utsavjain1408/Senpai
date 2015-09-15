<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LSignUp = New System.Windows.Forms.Label()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.LPassword = New System.Windows.Forms.Label()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LSignUp
        '
        Me.LSignUp.AutoSize = True
        Me.LSignUp.Location = New System.Drawing.Point(80, 227)
        Me.LSignUp.Name = "LSignUp"
        Me.LSignUp.Size = New System.Drawing.Size(180, 13)
        Me.LSignUp.TabIndex = 14
        Me.LSignUp.Text = "Don't Have an Account. Click Here!!"
        '
        'BLogin
        '
        Me.BLogin.Location = New System.Drawing.Point(75, 170)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(75, 23)
        Me.BLogin.TabIndex = 13
        Me.BLogin.Text = "Log In"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(95, 105)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(100, 20)
        Me.TBPassword.TabIndex = 12
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(95, 58)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(100, 20)
        Me.TBEmail.TabIndex = 11
        '
        'LPassword
        '
        Me.LPassword.AutoSize = True
        Me.LPassword.Location = New System.Drawing.Point(25, 108)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(53, 13)
        Me.LPassword.TabIndex = 10
        Me.LPassword.Text = "Password"
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Location = New System.Drawing.Point(25, 61)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(32, 13)
        Me.LEmail.TabIndex = 9
        Me.LEmail.Text = "Email"
        '
        'LWelcome
        '
        Me.LWelcome.AutoSize = True
        Me.LWelcome.Location = New System.Drawing.Point(92, 21)
        Me.LWelcome.Name = "LWelcome"
        Me.LWelcome.Size = New System.Drawing.Size(55, 13)
        Me.LWelcome.TabIndex = 8
        Me.LWelcome.Text = "Welcome!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LSignUp)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.LPassword)
        Me.Controls.Add(Me.LEmail)
        Me.Controls.Add(Me.LWelcome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents LSignUp As System.Windows.Forms.Label
    Private WithEvents BLogin As System.Windows.Forms.Button
    Private WithEvents TBPassword As System.Windows.Forms.TextBox
    Private WithEvents TBEmail As System.Windows.Forms.TextBox
    Private WithEvents LPassword As System.Windows.Forms.Label
    Private WithEvents LEmail As System.Windows.Forms.Label
    Private WithEvents LWelcome As System.Windows.Forms.Label

End Class
