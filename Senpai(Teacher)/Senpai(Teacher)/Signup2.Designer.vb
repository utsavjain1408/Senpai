<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup2
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
        Me.PanelAddCollege = New System.Windows.Forms.Panel()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.LNewCollegeName = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.BFinish = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.LCity = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PanelAddCollege.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelAddCollege
        '
        Me.PanelAddCollege.Controls.Add(Me.textBox1)
        Me.PanelAddCollege.Controls.Add(Me.LNewCollegeName)
        Me.PanelAddCollege.Location = New System.Drawing.Point(47, 135)
        Me.PanelAddCollege.Name = "PanelAddCollege"
        Me.PanelAddCollege.Size = New System.Drawing.Size(237, 100)
        Me.PanelAddCollege.TabIndex = 16
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(120, 9)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 1
        '
        'LNewCollegeName
        '
        Me.LNewCollegeName.AutoSize = True
        Me.LNewCollegeName.Location = New System.Drawing.Point(3, 12)
        Me.LNewCollegeName.Name = "LNewCollegeName"
        Me.LNewCollegeName.Size = New System.Drawing.Size(101, 13)
        Me.LNewCollegeName.TabIndex = 0
        Me.LNewCollegeName.Text = "Enter College Name"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(186, 275)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(110, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Your are almost there!"
        '
        'BFinish
        '
        Me.BFinish.Location = New System.Drawing.Point(108, 241)
        Me.BFinish.Name = "BFinish"
        Me.BFinish.Size = New System.Drawing.Size(75, 23)
        Me.BFinish.TabIndex = 14
        Me.BFinish.Text = "Finish"
        Me.BFinish.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(147, 94)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(100, 21)
        Me.comboBox1.TabIndex = 13
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(147, 65)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 12
        '
        'LCity
        '
        Me.LCity.AutoSize = True
        Me.LCity.Location = New System.Drawing.Point(36, 68)
        Me.LCity.Name = "LCity"
        Me.LCity.Size = New System.Drawing.Size(52, 13)
        Me.LCity.TabIndex = 11
        Me.LCity.Text = "Enter City"
        Me.LCity.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(36, 94)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(79, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Search College"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(73, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(110, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Let's find your College"
        '
        'Signup2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 318)
        Me.Controls.Add(Me.PanelAddCollege)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.BFinish)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.LCity)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Signup2"
        Me.Text = "Signup2"
        Me.PanelAddCollege.ResumeLayout(False)
        Me.PanelAddCollege.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents PanelAddCollege As System.Windows.Forms.Panel
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents LNewCollegeName As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents BFinish As System.Windows.Forms.Button
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents LCity As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
