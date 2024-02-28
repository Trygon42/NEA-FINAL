<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DischargePatient
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
        Me.Firstname = New System.Windows.Forms.Label()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.BtnDischarge = New System.Windows.Forms.Button()
        Me.CbEmail = New System.Windows.Forms.CheckBox()
        Me.CbConfirm = New System.Windows.Forms.CheckBox()
        Me.LblFirstName = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Firstname
        '
        Me.Firstname.AutoSize = True
        Me.Firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstname.Location = New System.Drawing.Point(150, 63)
        Me.Firstname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(0, 20)
        Me.Firstname.TabIndex = 21
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.Location = New System.Drawing.Point(20, 188)
        Me.LblMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(0, 13)
        Me.LblMessage.TabIndex = 20
        '
        'BtnDischarge
        '
        Me.BtnDischarge.Location = New System.Drawing.Point(16, 210)
        Me.BtnDischarge.Name = "BtnDischarge"
        Me.BtnDischarge.Size = New System.Drawing.Size(127, 37)
        Me.BtnDischarge.TabIndex = 19
        Me.BtnDischarge.Text = "Discharge patient"
        Me.BtnDischarge.UseVisualStyleBackColor = True
        '
        'CbEmail
        '
        Me.CbEmail.AutoSize = True
        Me.CbEmail.Location = New System.Drawing.Point(16, 160)
        Me.CbEmail.Name = "CbEmail"
        Me.CbEmail.Size = New System.Drawing.Size(141, 17)
        Me.CbEmail.TabIndex = 18
        Me.CbEmail.Text = "Send standardised email"
        Me.CbEmail.UseVisualStyleBackColor = True
        '
        'CbConfirm
        '
        Me.CbConfirm.AutoSize = True
        Me.CbConfirm.Location = New System.Drawing.Point(16, 138)
        Me.CbConfirm.Name = "CbConfirm"
        Me.CbConfirm.Size = New System.Drawing.Size(154, 17)
        Me.CbConfirm.TabIndex = 17
        Me.CbConfirm.Text = "I want to discharge patient "
        Me.CbConfirm.UseVisualStyleBackColor = True
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.Location = New System.Drawing.Point(17, 68)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Size = New System.Drawing.Size(122, 13)
        Me.LblFirstName.TabIndex = 16
        Me.LblFirstName.Text = "Patient to be discharged"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(272, 226)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(67, 21)
        Me.Cancel.TabIndex = 15
        Me.Cancel.Text = "Exit"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Discharging patient"
        '
        'DischargePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(396, 284)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.LblMessage)
        Me.Controls.Add(Me.BtnDischarge)
        Me.Controls.Add(Me.CbEmail)
        Me.Controls.Add(Me.CbConfirm)
        Me.Controls.Add(Me.LblFirstName)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DischargePatient"
        Me.Text = "DischargePatient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Firstname As Label
    Friend WithEvents LblMessage As Label
    Friend WithEvents BtnDischarge As Button
    Friend WithEvents CbEmail As CheckBox
    Friend WithEvents CbConfirm As CheckBox
    Friend WithEvents LblFirstName As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents Label1 As Label
End Class
