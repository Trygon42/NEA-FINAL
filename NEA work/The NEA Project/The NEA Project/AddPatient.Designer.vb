<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatient
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
        Me.RdOther = New System.Windows.Forms.RadioButton()
        Me.RdFemale = New System.Windows.Forms.RadioButton()
        Me.RdMale = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LblDisplay = New System.Windows.Forms.Label()
        Me.CmbEthnicity = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnExecute = New System.Windows.Forms.Button()
        Me.TxtOther = New System.Windows.Forms.TextBox()
        Me.LblOther = New System.Windows.Forms.Label()
        Me.LblEthnicity = New System.Windows.Forms.Label()
        Me.LblGPEmail = New System.Windows.Forms.Label()
        Me.LblGPName = New System.Windows.Forms.Label()
        Me.LblHist = New System.Windows.Forms.Label()
        Me.LblDOB = New System.Windows.Forms.Label()
        Me.LblWeight = New System.Windows.Forms.Label()
        Me.LblHeight = New System.Windows.Forms.Label()
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.TxtGPEmail = New System.Windows.Forms.TextBox()
        Me.TxtGPname = New System.Windows.Forms.TextBox()
        Me.TxtHistory = New System.Windows.Forms.TextBox()
        Me.TxtWeight = New System.Windows.Forms.TextBox()
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RdOther
        '
        Me.RdOther.AutoSize = True
        Me.RdOther.Location = New System.Drawing.Point(260, 273)
        Me.RdOther.Margin = New System.Windows.Forms.Padding(2)
        Me.RdOther.Name = "RdOther"
        Me.RdOther.Size = New System.Drawing.Size(51, 17)
        Me.RdOther.TabIndex = 60
        Me.RdOther.TabStop = True
        Me.RdOther.Text = "Other"
        Me.RdOther.UseVisualStyleBackColor = True
        '
        'RdFemale
        '
        Me.RdFemale.AutoSize = True
        Me.RdFemale.Location = New System.Drawing.Point(198, 273)
        Me.RdFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.RdFemale.Name = "RdFemale"
        Me.RdFemale.Size = New System.Drawing.Size(59, 17)
        Me.RdFemale.TabIndex = 58
        Me.RdFemale.TabStop = True
        Me.RdFemale.Text = "Female"
        Me.RdFemale.UseVisualStyleBackColor = True
        '
        'RdMale
        '
        Me.RdMale.AutoSize = True
        Me.RdMale.Location = New System.Drawing.Point(149, 273)
        Me.RdMale.Margin = New System.Windows.Forms.Padding(2)
        Me.RdMale.Name = "RdMale"
        Me.RdMale.Size = New System.Drawing.Size(48, 17)
        Me.RdMale.TabIndex = 57
        Me.RdMale.TabStop = True
        Me.RdMale.Text = "Male"
        Me.RdMale.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(149, 142)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePicker2.TabIndex = 56
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cancel.Location = New System.Drawing.Point(148, 384)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(123, 25)
        Me.Cancel.TabIndex = 55
        Me.Cancel.Text = "Exit"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'LblDisplay
        '
        Me.LblDisplay.AutoSize = True
        Me.LblDisplay.Location = New System.Drawing.Point(125, 320)
        Me.LblDisplay.Name = "LblDisplay"
        Me.LblDisplay.Size = New System.Drawing.Size(0, 13)
        Me.LblDisplay.TabIndex = 54
        '
        'CmbEthnicity
        '
        Me.CmbEthnicity.FormattingEnabled = True
        Me.CmbEthnicity.Items.AddRange(New Object() {"White/Caucasian", "Black/African American", "Hispanic/Latino", "Asian", "Native American/American Indian", "Pacific Islander", "Middle Eastern/Arab", "South Asian", "Southeast Asian", "Central Asian", "Biracial/Multiracial", "Other"})
        Me.CmbEthnicity.Location = New System.Drawing.Point(149, 246)
        Me.CmbEthnicity.Name = "CmbEthnicity"
        Me.CmbEthnicity.Size = New System.Drawing.Size(230, 21)
        Me.CmbEthnicity.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Sex"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTitle.Location = New System.Drawing.Point(115, 21)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(233, 20)
        Me.LblTitle.TabIndex = 52
        Me.LblTitle.Text = "Provide information on patient"
        '
        'BtnExecute
        '
        Me.BtnExecute.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnExecute.Location = New System.Drawing.Point(128, 353)
        Me.BtnExecute.Name = "BtnExecute"
        Me.BtnExecute.Size = New System.Drawing.Size(165, 25)
        Me.BtnExecute.TabIndex = 51
        Me.BtnExecute.Text = "Add patient"
        Me.BtnExecute.UseVisualStyleBackColor = False
        '
        'TxtOther
        '
        Me.TxtOther.Location = New System.Drawing.Point(147, 295)
        Me.TxtOther.Name = "TxtOther"
        Me.TxtOther.Size = New System.Drawing.Size(230, 20)
        Me.TxtOther.TabIndex = 50
        '
        'LblOther
        '
        Me.LblOther.AutoSize = True
        Me.LblOther.Location = New System.Drawing.Point(45, 294)
        Me.LblOther.Name = "LblOther"
        Me.LblOther.Size = New System.Drawing.Size(99, 26)
        Me.LblOther.TabIndex = 49
        Me.LblOther.Text = "Any other " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "relevent information"
        Me.LblOther.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblEthnicity
        '
        Me.LblEthnicity.AutoSize = True
        Me.LblEthnicity.Location = New System.Drawing.Point(96, 250)
        Me.LblEthnicity.Name = "LblEthnicity"
        Me.LblEthnicity.Size = New System.Drawing.Size(47, 13)
        Me.LblEthnicity.TabIndex = 48
        Me.LblEthnicity.Text = "Ethnicity"
        '
        'LblGPEmail
        '
        Me.LblGPEmail.AutoSize = True
        Me.LblGPEmail.Location = New System.Drawing.Point(56, 224)
        Me.LblGPEmail.Name = "LblGPEmail"
        Me.LblGPEmail.Size = New System.Drawing.Size(87, 13)
        Me.LblGPEmail.TabIndex = 47
        Me.LblGPEmail.Text = "Current GP Email"
        '
        'LblGPName
        '
        Me.LblGPName.AutoSize = True
        Me.LblGPName.Location = New System.Drawing.Point(55, 198)
        Me.LblGPName.Name = "LblGPName"
        Me.LblGPName.Size = New System.Drawing.Size(88, 13)
        Me.LblGPName.TabIndex = 46
        Me.LblGPName.Text = "Current GP name"
        '
        'LblHist
        '
        Me.LblHist.AutoSize = True
        Me.LblHist.Location = New System.Drawing.Point(47, 163)
        Me.LblHist.Name = "LblHist"
        Me.LblHist.Size = New System.Drawing.Size(96, 26)
        Me.LblHist.TabIndex = 45
        Me.LblHist.Text = "Relevant " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "history/ conditions "
        Me.LblHist.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDOB
        '
        Me.LblDOB.AutoSize = True
        Me.LblDOB.Location = New System.Drawing.Point(78, 146)
        Me.LblDOB.Name = "LblDOB"
        Me.LblDOB.Size = New System.Drawing.Size(65, 13)
        Me.LblDOB.TabIndex = 44
        Me.LblDOB.Text = "Date of birth"
        '
        'LblWeight
        '
        Me.LblWeight.AutoSize = True
        Me.LblWeight.Location = New System.Drawing.Point(81, 120)
        Me.LblWeight.Name = "LblWeight"
        Me.LblWeight.Size = New System.Drawing.Size(62, 13)
        Me.LblWeight.TabIndex = 43
        Me.LblWeight.Text = "Weight (kg)"
        '
        'LblHeight
        '
        Me.LblHeight.AutoSize = True
        Me.LblHeight.Location = New System.Drawing.Point(82, 94)
        Me.LblHeight.Name = "LblHeight"
        Me.LblHeight.Size = New System.Drawing.Size(61, 13)
        Me.LblHeight.TabIndex = 42
        Me.LblHeight.Text = "Height (cm)"
        '
        'LblFullName
        '
        Me.LblFullName.AutoSize = True
        Me.LblFullName.Location = New System.Drawing.Point(91, 68)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(52, 13)
        Me.LblFullName.TabIndex = 41
        Me.LblFullName.Text = "Full name"
        '
        'TxtGPEmail
        '
        Me.TxtGPEmail.Location = New System.Drawing.Point(149, 221)
        Me.TxtGPEmail.Name = "TxtGPEmail"
        Me.TxtGPEmail.Size = New System.Drawing.Size(230, 20)
        Me.TxtGPEmail.TabIndex = 40
        '
        'TxtGPname
        '
        Me.TxtGPname.Location = New System.Drawing.Point(149, 195)
        Me.TxtGPname.Name = "TxtGPname"
        Me.TxtGPname.Size = New System.Drawing.Size(230, 20)
        Me.TxtGPname.TabIndex = 39
        '
        'TxtHistory
        '
        Me.TxtHistory.Location = New System.Drawing.Point(149, 169)
        Me.TxtHistory.Name = "TxtHistory"
        Me.TxtHistory.Size = New System.Drawing.Size(230, 20)
        Me.TxtHistory.TabIndex = 38
        '
        'TxtWeight
        '
        Me.TxtWeight.Location = New System.Drawing.Point(149, 117)
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(230, 20)
        Me.TxtWeight.TabIndex = 37
        '
        'TxtHeight
        '
        Me.TxtHeight.Location = New System.Drawing.Point(149, 91)
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(230, 20)
        Me.TxtHeight.TabIndex = 36
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(149, 65)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(230, 20)
        Me.TxtName.TabIndex = 35
        '
        'AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(456, 455)
        Me.Controls.Add(Me.RdOther)
        Me.Controls.Add(Me.RdFemale)
        Me.Controls.Add(Me.RdMale)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.LblDisplay)
        Me.Controls.Add(Me.CmbEthnicity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnExecute)
        Me.Controls.Add(Me.TxtOther)
        Me.Controls.Add(Me.LblOther)
        Me.Controls.Add(Me.LblEthnicity)
        Me.Controls.Add(Me.LblGPEmail)
        Me.Controls.Add(Me.LblGPName)
        Me.Controls.Add(Me.LblHist)
        Me.Controls.Add(Me.LblDOB)
        Me.Controls.Add(Me.LblWeight)
        Me.Controls.Add(Me.LblHeight)
        Me.Controls.Add(Me.LblFullName)
        Me.Controls.Add(Me.TxtGPEmail)
        Me.Controls.Add(Me.TxtGPname)
        Me.Controls.Add(Me.TxtHistory)
        Me.Controls.Add(Me.TxtWeight)
        Me.Controls.Add(Me.TxtHeight)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "AddPatient"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RdOther As RadioButton
    Friend WithEvents RdFemale As RadioButton
    Friend WithEvents RdMale As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Cancel As Button
    Friend WithEvents LblDisplay As Label
    Friend WithEvents CmbEthnicity As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnExecute As Button
    Friend WithEvents TxtOther As TextBox
    Friend WithEvents LblOther As Label
    Friend WithEvents LblEthnicity As Label
    Friend WithEvents LblGPEmail As Label
    Friend WithEvents LblGPName As Label
    Friend WithEvents LblHist As Label
    Friend WithEvents LblDOB As Label
    Friend WithEvents LblWeight As Label
    Friend WithEvents LblHeight As Label
    Friend WithEvents LblFullName As Label
    Friend WithEvents TxtGPEmail As TextBox
    Friend WithEvents TxtGPname As TextBox
    Friend WithEvents TxtHistory As TextBox
    Friend WithEvents TxtWeight As TextBox
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents TxtName As TextBox
End Class
