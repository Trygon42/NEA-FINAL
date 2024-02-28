<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Me.BtnViewPatient = New System.Windows.Forms.Button()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnContact = New System.Windows.Forms.Button()
        Me.BtnViewDis = New System.Windows.Forms.Button()
        Me.BtnDischargePatient = New System.Windows.Forms.Button()
        Me.BtnDeletePatient = New System.Windows.Forms.Button()
        Me.BtnAddPatient = New System.Windows.Forms.Button()
        Me.Other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ethnicity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.History = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GridPatients = New System.Windows.Forms.DataGridView()
        CType(Me.GridPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnViewPatient
        '
        Me.BtnViewPatient.Location = New System.Drawing.Point(17, 82)
        Me.BtnViewPatient.Name = "BtnViewPatient"
        Me.BtnViewPatient.Size = New System.Drawing.Size(161, 33)
        Me.BtnViewPatient.TabIndex = 21
        Me.BtnViewPatient.Text = "View Patient"
        Me.BtnViewPatient.UseVisualStyleBackColor = True
        '
        'BtnExport
        '
        Me.BtnExport.Location = New System.Drawing.Point(310, 16)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(84, 29)
        Me.BtnExport.TabIndex = 19
        Me.BtnExport.Text = "Export to CSV"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(13, 506)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(91, 29)
        Me.BtnBack.TabIndex = 18
        Me.BtnBack.Text = "Back to menu"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "View Patients"
        '
        'BtnContact
        '
        Me.BtnContact.Location = New System.Drawing.Point(17, 238)
        Me.BtnContact.Name = "BtnContact"
        Me.BtnContact.Size = New System.Drawing.Size(161, 33)
        Me.BtnContact.TabIndex = 16
        Me.BtnContact.Text = "Contact patient GP"
        Me.BtnContact.UseVisualStyleBackColor = True
        '
        'BtnViewDis
        '
        Me.BtnViewDis.Location = New System.Drawing.Point(17, 199)
        Me.BtnViewDis.Name = "BtnViewDis"
        Me.BtnViewDis.Size = New System.Drawing.Size(161, 33)
        Me.BtnViewDis.TabIndex = 15
        Me.BtnViewDis.Text = "View Discharged patients"
        Me.BtnViewDis.UseVisualStyleBackColor = True
        '
        'BtnDischargePatient
        '
        Me.BtnDischargePatient.Location = New System.Drawing.Point(17, 160)
        Me.BtnDischargePatient.Name = "BtnDischargePatient"
        Me.BtnDischargePatient.Size = New System.Drawing.Size(161, 33)
        Me.BtnDischargePatient.TabIndex = 14
        Me.BtnDischargePatient.Text = "Discharge patient "
        Me.BtnDischargePatient.UseVisualStyleBackColor = True
        '
        'BtnDeletePatient
        '
        Me.BtnDeletePatient.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnDeletePatient.Location = New System.Drawing.Point(17, 304)
        Me.BtnDeletePatient.Name = "BtnDeletePatient"
        Me.BtnDeletePatient.Size = New System.Drawing.Size(120, 33)
        Me.BtnDeletePatient.TabIndex = 13
        Me.BtnDeletePatient.Text = "Delete patient "
        Me.BtnDeletePatient.UseVisualStyleBackColor = False
        '
        'BtnAddPatient
        '
        Me.BtnAddPatient.Location = New System.Drawing.Point(17, 121)
        Me.BtnAddPatient.Name = "BtnAddPatient"
        Me.BtnAddPatient.Size = New System.Drawing.Size(161, 33)
        Me.BtnAddPatient.TabIndex = 12
        Me.BtnAddPatient.Text = "Add Patient"
        Me.BtnAddPatient.UseVisualStyleBackColor = True
        '
        'Other
        '
        Me.Other.HeaderText = "Other info"
        Me.Other.MinimumWidth = 8
        Me.Other.Name = "Other"
        Me.Other.Width = 150
        '
        'Ethnicity
        '
        Me.Ethnicity.HeaderText = "Ethnicity"
        Me.Ethnicity.MinimumWidth = 8
        Me.Ethnicity.Name = "Ethnicity"
        Me.Ethnicity.Width = 150
        '
        'GPEmail
        '
        Me.GPEmail.HeaderText = "GP Email"
        Me.GPEmail.MinimumWidth = 8
        Me.GPEmail.Name = "GPEmail"
        Me.GPEmail.Width = 150
        '
        'GPName
        '
        Me.GPName.HeaderText = "GP Name"
        Me.GPName.MinimumWidth = 8
        Me.GPName.Name = "GPName"
        Me.GPName.Width = 150
        '
        'History
        '
        Me.History.HeaderText = "History"
        Me.History.MinimumWidth = 8
        Me.History.Name = "History"
        Me.History.Width = 150
        '
        'PatientDOB
        '
        Me.PatientDOB.HeaderText = "DOB"
        Me.PatientDOB.MinimumWidth = 8
        Me.PatientDOB.Name = "PatientDOB"
        Me.PatientDOB.Width = 150
        '
        'Weight
        '
        Me.Weight.HeaderText = "Weight /kg"
        Me.Weight.MinimumWidth = 8
        Me.Weight.Name = "Weight"
        Me.Weight.Width = 150
        '
        'Height
        '
        Me.Height.HeaderText = "Height /cm"
        Me.Height.MinimumWidth = 8
        Me.Height.Name = "Height"
        Me.Height.Width = 150
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.MinimumWidth = 8
        Me.Age.Name = "Age"
        Me.Age.Width = 150
        '
        'Sex
        '
        Me.Sex.HeaderText = "Sex"
        Me.Sex.MinimumWidth = 8
        Me.Sex.Name = "Sex"
        Me.Sex.Width = 150
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.MinimumWidth = 8
        Me.PatientName.Name = "PatientName"
        Me.PatientName.Width = 150
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSave.Location = New System.Drawing.Point(220, 16)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(84, 29)
        Me.BtnSave.TabIndex = 20
        Me.BtnSave.Text = "Save table "
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'GridPatients
        '
        Me.GridPatients.AllowUserToAddRows = False
        Me.GridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPatients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientName, Me.Sex, Me.Age, Me.Height, Me.Weight, Me.PatientDOB, Me.History, Me.GPName, Me.GPEmail, Me.Ethnicity, Me.Other})
        Me.GridPatients.Location = New System.Drawing.Point(220, 51)
        Me.GridPatients.Name = "GridPatients"
        Me.GridPatients.RowHeadersWidth = 62
        Me.GridPatients.Size = New System.Drawing.Size(849, 484)
        Me.GridPatients.TabIndex = 11
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 561)
        Me.Controls.Add(Me.BtnViewPatient)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnContact)
        Me.Controls.Add(Me.BtnViewDis)
        Me.Controls.Add(Me.BtnDischargePatient)
        Me.Controls.Add(Me.BtnDeletePatient)
        Me.Controls.Add(Me.BtnAddPatient)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GridPatients)
        Me.Name = "Patients"
        Me.Text = "View patients"
        CType(Me.GridPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnViewPatient As Button
    Friend WithEvents BtnExport As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnContact As Button
    Friend WithEvents BtnViewDis As Button
    Friend WithEvents BtnDischargePatient As Button
    Friend WithEvents BtnDeletePatient As Button
    Friend WithEvents BtnAddPatient As Button
    Friend WithEvents Other As DataGridViewTextBoxColumn
    Friend WithEvents Ethnicity As DataGridViewTextBoxColumn
    Friend WithEvents GPEmail As DataGridViewTextBoxColumn
    Friend WithEvents GPName As DataGridViewTextBoxColumn
    Friend WithEvents History As DataGridViewTextBoxColumn
    Friend WithEvents PatientDOB As DataGridViewTextBoxColumn
    Friend WithEvents Weight As DataGridViewTextBoxColumn
    Friend WithEvents Height As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents BtnSave As Button
    Friend WithEvents GridPatients As DataGridView
End Class
