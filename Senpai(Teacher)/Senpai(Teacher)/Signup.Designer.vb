<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Me.BNext = New System.Windows.Forms.Button()
        Me.DTPDOB = New System.Windows.Forms.DateTimePicker()
        Me.TBPhone = New System.Windows.Forms.TextBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.GroupBox()
        Me.RDMale = New System.Windows.Forms.RadioButton()
        Me.RDFemale = New System.Windows.Forms.RadioButton()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Gender.SuspendLayout()
        Me.SuspendLayout()
        '
        'BNext
        '
        Me.BNext.Location = New System.Drawing.Point(122, 213)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(82, 26)
        Me.BNext.TabIndex = 24
        Me.BNext.Text = "Next"
        Me.BNext.UseVisualStyleBackColor = True
        '
        'DTPDOB
        '
        Me.DTPDOB.Location = New System.Drawing.Point(117, 136)
        Me.DTPDOB.Name = "DTPDOB"
        Me.DTPDOB.Size = New System.Drawing.Size(200, 20)
        Me.DTPDOB.TabIndex = 23
        '
        'TBPhone
        '
        Me.TBPhone.Location = New System.Drawing.Point(117, 110)
        Me.TBPhone.Name = "TBPhone"
        Me.TBPhone.Size = New System.Drawing.Size(100, 20)
        Me.TBPhone.TabIndex = 22
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(117, 81)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(100, 20)
        Me.TBEmail.TabIndex = 21
        '
        'TBName
        '
        Me.TBName.Location = New System.Drawing.Point(117, 55)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(100, 20)
        Me.TBName.TabIndex = 20
        '
        'Gender
        '
        Me.Gender.Controls.Add(Me.RDMale)
        Me.Gender.Controls.Add(Me.RDFemale)
        Me.Gender.Location = New System.Drawing.Point(24, 164)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(210, 26)
        Me.Gender.TabIndex = 19
        Me.Gender.TabStop = False
        Me.Gender.Text = "Gender"
        '
        'RDMale
        '
        Me.RDMale.AutoSize = True
        Me.RDMale.Location = New System.Drawing.Point(53, 9)
        Me.RDMale.Name = "RDMale"
        Me.RDMale.Size = New System.Drawing.Size(48, 17)
        Me.RDMale.TabIndex = 6
        Me.RDMale.TabStop = True
        Me.RDMale.Text = "Male"
        Me.RDMale.UseVisualStyleBackColor = True
        '
        'RDFemale
        '
        Me.RDFemale.AutoSize = True
        Me.RDFemale.Location = New System.Drawing.Point(107, 9)
        Me.RDFemale.Name = "RDFemale"
        Me.RDFemale.Size = New System.Drawing.Size(59, 17)
        Me.RDFemale.TabIndex = 7
        Me.RDFemale.TabStop = True
        Me.RDFemale.Text = "Female"
        Me.RDFemale.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(21, 139)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(68, 13)
        Me.label5.TabIndex = 18
        Me.label5.Text = "Date Of Birth"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(21, 113)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(55, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Phone No"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(21, 84)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(32, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Email"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(21, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(35, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Name"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(74, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Register Your Self"
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 273)
        Me.Controls.Add(Me.BNext)
        Me.Controls.Add(Me.DTPDOB)
        Me.Controls.Add(Me.TBPhone)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.TBName)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Signup"
        Me.Text = "Signup"
        Me.Gender.ResumeLayout(False)
        Me.Gender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BNext As System.Windows.Forms.Button
    Private WithEvents DTPDOB As System.Windows.Forms.DateTimePicker
    Private WithEvents TBPhone As System.Windows.Forms.TextBox
    Private WithEvents TBEmail As System.Windows.Forms.TextBox
    Private WithEvents TBName As System.Windows.Forms.TextBox
    Private WithEvents Gender As System.Windows.Forms.GroupBox
    Private WithEvents RDMale As System.Windows.Forms.RadioButton
    Private WithEvents RDFemale As System.Windows.Forms.RadioButton
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
