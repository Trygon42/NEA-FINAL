<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Viewpatients = New System.Windows.Forms.Button()
        Me.s = New System.Windows.Forms.Button()
        Me.BtnCreateAcc = New System.Windows.Forms.Button()
        Me.BtnDischarged = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Medical Database"
        '
        'Viewpatients
        '
        Me.Viewpatients.Location = New System.Drawing.Point(109, 42)
        Me.Viewpatients.Name = "Viewpatients"
        Me.Viewpatients.Size = New System.Drawing.Size(198, 33)
        Me.Viewpatients.TabIndex = 8
        Me.Viewpatients.Text = "View patients"
        Me.Viewpatients.UseVisualStyleBackColor = True
        '
        's
        '
        Me.s.Location = New System.Drawing.Point(163, 175)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(84, 38)
        Me.s.TabIndex = 7
        Me.s.Text = "Logout"
        Me.s.UseVisualStyleBackColor = True
        '
        'BtnCreateAcc
        '
        Me.BtnCreateAcc.Location = New System.Drawing.Point(109, 120)
        Me.BtnCreateAcc.Name = "BtnCreateAcc"
        Me.BtnCreateAcc.Size = New System.Drawing.Size(198, 33)
        Me.BtnCreateAcc.TabIndex = 14
        Me.BtnCreateAcc.Text = "Create and manage users"
        Me.BtnCreateAcc.UseVisualStyleBackColor = True
        '
        'BtnDischarged
        '
        Me.BtnDischarged.Location = New System.Drawing.Point(109, 81)
        Me.BtnDischarged.Name = "BtnDischarged"
        Me.BtnDischarged.Size = New System.Drawing.Size(198, 33)
        Me.BtnDischarged.TabIndex = 15
        Me.BtnDischarged.Text = "View Discharged patients"
        Me.BtnDischarged.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 240)
        Me.Controls.Add(Me.BtnDischarged)
        Me.Controls.Add(Me.BtnCreateAcc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Viewpatients)
        Me.Controls.Add(Me.s)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Viewpatients As Button
    Friend WithEvents s As Button
    Friend WithEvents BtnCreateAcc As Button
    Friend WithEvents BtnDischarged As Button
End Class
