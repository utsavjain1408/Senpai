<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BSubmit = New System.Windows.Forms.Button()
        Me.LCollege = New System.Windows.Forms.Label()
        Me.LGender = New System.Windows.Forms.Label()
        Me.LPhone = New System.Windows.Forms.Label()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BSubmit
        '
        Me.BSubmit.Location = New System.Drawing.Point(92, 204)
        Me.BSubmit.Name = "BSubmit"
        Me.BSubmit.Size = New System.Drawing.Size(75, 21)
        Me.BSubmit.TabIndex = 13
        Me.BSubmit.Text = "Submit"
        Me.BSubmit.UseVisualStyleBackColor = True
        '
        'LCollege
        '
        Me.LCollege.AutoSize = True
        Me.LCollege.Location = New System.Drawing.Point(26, 134)
        Me.LCollege.Name = "LCollege"
        Me.LCollege.Size = New System.Drawing.Size(42, 13)
        Me.LCollege.TabIndex = 11
        Me.LCollege.Text = "College"
        '
        'LGender
        '
        Me.LGender.AutoSize = True
        Me.LGender.Location = New System.Drawing.Point(26, 112)
        Me.LGender.Name = "LGender"
        Me.LGender.Size = New System.Drawing.Size(42, 13)
        Me.LGender.TabIndex = 10
        Me.LGender.Text = "Gender"
        '
        'LPhone
        '
        Me.LPhone.AutoSize = True
        Me.LPhone.Location = New System.Drawing.Point(26, 88)
        Me.LPhone.Name = "LPhone"
        Me.LPhone.Size = New System.Drawing.Size(55, 13)
        Me.LPhone.TabIndex = 9
        Me.LPhone.Text = "Phone No"
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Location = New System.Drawing.Point(26, 64)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(32, 13)
        Me.LEmail.TabIndex = 8
        Me.LEmail.Text = "Email"
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Location = New System.Drawing.Point(26, 39)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(35, 13)
        Me.LName.TabIndex = 7
        Me.LName.Text = "Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 280)
        Me.Controls.Add(Me.BSubmit)
        Me.Controls.Add(Me.LCollege)
        Me.Controls.Add(Me.LGender)
        Me.Controls.Add(Me.LPhone)
        Me.Controls.Add(Me.LEmail)
        Me.Controls.Add(Me.LName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BSubmit As System.Windows.Forms.Button
    Private WithEvents LCollege As System.Windows.Forms.Label
    Private WithEvents LGender As System.Windows.Forms.Label
    Private WithEvents LPhone As System.Windows.Forms.Label
    Private WithEvents LEmail As System.Windows.Forms.Label
    Private WithEvents LName As System.Windows.Forms.Label
End Class
