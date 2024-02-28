<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DischargedPatients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GridDischargedPatients = New System.Windows.Forms.DataGridView()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.History = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ethnicity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnContact = New System.Windows.Forms.Button()
        CType(Me.GridDischargedPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridDischargedPatients
        '
        Me.GridDischargedPatients.AllowUserToAddRows = False
        Me.GridDischargedPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDischargedPatients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientName, Me.Sex, Me.Age, Me.Height, Me.Weight, Me.PatientDOB, Me.History, Me.GPName, Me.GPEmail, Me.Ethnicity, Me.Other})
        Me.GridDischargedPatients.Location = New System.Drawing.Point(12, 44)
        Me.GridDischargedPatients.Name = "GridDischargedPatients"
        Me.GridDischargedPatients.RowHeadersWidth = 62
        Me.GridDischargedPatients.Size = New System.Drawing.Size(849, 484)
        Me.GridDischargedPatients.TabIndex = 22
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.MinimumWidth = 8
        Me.PatientName.Name = "PatientName"
        Me.PatientName.Width = 150
        '
        'Sex
        '
        Me.Sex.HeaderText = "Sex"
        Me.Sex.MinimumWidth = 8
        Me.Sex.Name = "Sex"
        Me.Sex.Width = 150
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.MinimumWidth = 8
        Me.Age.Name = "Age"
        Me.Age.Width = 150
        '
        'Height
        '
        Me.Height.HeaderText = "Height /cm"
        Me.Height.MinimumWidth = 8
        Me.Height.Name = "Height"
        Me.Height.Width = 150
        '
        'Weight
        '
        Me.Weight.HeaderText = "Weight /kg"
        Me.Weight.MinimumWidth = 8
        Me.Weight.Name = "Weight"
        Me.Weight.Width = 150
        '
        'PatientDOB
        '
        Me.PatientDOB.HeaderText = "DOB"
        Me.PatientDOB.MinimumWidth = 8
        Me.PatientDOB.Name = "PatientDOB"
        Me.PatientDOB.Width = 150
        '
        'History
        '
        Me.History.HeaderText = "History"
        Me.History.MinimumWidth = 8
        Me.History.Name = "History"
        Me.History.Width = 150
        '
        'GPName
        '
        Me.GPName.HeaderText = "GP Name"
        Me.GPName.MinimumWidth = 8
        Me.GPName.Name = "GPName"
        Me.GPName.Width = 150
        '
        'GPEmail
        '
        Me.GPEmail.HeaderText = "GP Email"
        Me.GPEmail.MinimumWidth = 8
        Me.GPEmail.Name = "GPEmail"
        Me.GPEmail.Width = 150
        '
        'Ethnicity
        '
        Me.Ethnicity.HeaderText = "Ethnicity"
        Me.Ethnicity.MinimumWidth = 8
        Me.Ethnicity.Name = "Ethnicity"
        Me.Ethnicity.Width = 150
        '
        'Other
        '
        Me.Other.HeaderText = "Other info"
        Me.Other.MinimumWidth = 8
        Me.Other.Name = "Other"
        Me.Other.Width = 150
        '
        'BtnExport
        '
        Me.BtnExport.Location = New System.Drawing.Point(470, 9)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(84, 29)
        Me.BtnExport.TabIndex = 30
        Me.BtnExport.Text = "Export to CSV"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(571, 9)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(91, 29)
        Me.BtnBack.TabIndex = 29
        Me.BtnBack.Text = "Back to menu"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "View Discharged Patients"
        '
        'BtnContact
        '
        Me.BtnContact.Location = New System.Drawing.Point(688, 7)
        Me.BtnContact.Name = "BtnContact"
        Me.BtnContact.Size = New System.Drawing.Size(161, 33)
        Me.BtnContact.TabIndex = 27
        Me.BtnContact.Text = "Contact patient GP"
        Me.BtnContact.UseVisualStyleBackColor = True
        '
        'DischargedPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 549)
        Me.Controls.Add(Me.GridDischargedPatients)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnContact)
        Me.Name = "DischargedPatients"
        Me.Text = "DischargedPatients"
        CType(Me.GridDischargedPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridDischargedPatients As DataGridView
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Height As DataGridViewTextBoxColumn
    Friend WithEvents Weight As DataGridViewTextBoxColumn
    Friend WithEvents PatientDOB As DataGridViewTextBoxColumn
    Friend WithEvents History As DataGridViewTextBoxColumn
    Friend WithEvents GPName As DataGridViewTextBoxColumn
    Friend WithEvents GPEmail As DataGridViewTextBoxColumn
    Friend WithEvents Ethnicity As DataGridViewTextBoxColumn
    Friend WithEvents Other As DataGridViewTextBoxColumn
    Friend WithEvents BtnExport As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnContact As Button
End Class
