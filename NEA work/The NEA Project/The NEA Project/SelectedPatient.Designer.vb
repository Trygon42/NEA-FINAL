<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectedPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectedPatient))
        Me.TxtSex = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.TxtWeight = New System.Windows.Forms.TextBox()
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.TxtEthnicity = New System.Windows.Forms.TextBox()
        Me.TxtMedicalHist = New System.Windows.Forms.TextBox()
        Me.DtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblWeight = New System.Windows.Forms.Label()
        Me.LblSex = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSex
        '
        Me.TxtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtSex.FormattingEnabled = True
        Me.TxtSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.TxtSex.Location = New System.Drawing.Point(75, 128)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.Size = New System.Drawing.Size(68, 21)
        Me.TxtSex.TabIndex = 36
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(357, 232)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(124, 31)
        Me.BtnSave.TabIndex = 35
        Me.BtnSave.Text = "Apply changes"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtNotes
        '
        Me.TxtNotes.Location = New System.Drawing.Point(275, 154)
        Me.TxtNotes.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(167, 57)
        Me.TxtNotes.TabIndex = 34
        '
        'TxtWeight
        '
        Me.TxtWeight.Location = New System.Drawing.Point(75, 154)
        Me.TxtWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(68, 20)
        Me.TxtWeight.TabIndex = 33
        '
        'TxtHeight
        '
        Me.TxtHeight.Location = New System.Drawing.Point(75, 180)
        Me.TxtHeight.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(68, 20)
        Me.TxtHeight.TabIndex = 32
        '
        'TxtEthnicity
        '
        Me.TxtEthnicity.Location = New System.Drawing.Point(75, 206)
        Me.TxtEthnicity.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEthnicity.Name = "TxtEthnicity"
        Me.TxtEthnicity.Size = New System.Drawing.Size(102, 20)
        Me.TxtEthnicity.TabIndex = 31
        '
        'TxtMedicalHist
        '
        Me.TxtMedicalHist.Location = New System.Drawing.Point(275, 81)
        Me.TxtMedicalHist.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMedicalHist.Multiline = True
        Me.TxtMedicalHist.Name = "TxtMedicalHist"
        Me.TxtMedicalHist.Size = New System.Drawing.Size(167, 57)
        Me.TxtMedicalHist.TabIndex = 30
        '
        'DtpDOB
        '
        Me.DtpDOB.Location = New System.Drawing.Point(19, 103)
        Me.DtpDOB.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpDOB.Name = "DtpDOB"
        Me.DtpDOB.Size = New System.Drawing.Size(135, 20)
        Me.DtpDOB.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Ethnicity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(101, 14)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Medical history:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.Label1.Size = New System.Drawing.Size(81, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Other notes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Height: "
        '
        'LblWeight
        '
        Me.LblWeight.AutoSize = True
        Me.LblWeight.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWeight.Location = New System.Drawing.Point(21, 157)
        Me.LblWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblWeight.Name = "LblWeight"
        Me.LblWeight.Size = New System.Drawing.Size(52, 14)
        Me.LblWeight.TabIndex = 24
        Me.LblWeight.Text = "Weight: "
        '
        'LblSex
        '
        Me.LblSex.AutoSize = True
        Me.LblSex.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSex.Location = New System.Drawing.Point(42, 131)
        Me.LblSex.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSex.Name = "LblSex"
        Me.LblSex.Size = New System.Drawing.Size(31, 14)
        Me.LblSex.TabIndex = 23
        Me.LblSex.Text = "Sex: "
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAge.Location = New System.Drawing.Point(16, 81)
        Me.LblAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(85, 14)
        Me.LblAge.TabIndex = 22
        Me.LblAge.Text = "Date of  birth: "
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(20, 17)
        Me.LblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Padding = New System.Windows.Forms.Padding(0, 0, 13, 0)
        Me.LblName.Size = New System.Drawing.Size(13, 39)
        Me.LblName.TabIndex = 21
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(497, 232)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(124, 31)
        Me.BtnBack.TabIndex = 20
        Me.BtnBack.Text = "Back to patients"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(490, 79)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'SelectedPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 303)
        Me.Controls.Add(Me.TxtSex)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtNotes)
        Me.Controls.Add(Me.TxtWeight)
        Me.Controls.Add(Me.TxtHeight)
        Me.Controls.Add(Me.TxtEthnicity)
        Me.Controls.Add(Me.TxtMedicalHist)
        Me.Controls.Add(Me.DtpDOB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblWeight)
        Me.Controls.Add(Me.LblSex)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SelectedPatient"
        Me.Text = "SelectedPatient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSex As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents TxtWeight As TextBox
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents TxtEthnicity As TextBox
    Friend WithEvents TxtMedicalHist As TextBox
    Friend WithEvents DtpDOB As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblWeight As Label
    Friend WithEvents LblSex As Label
    Friend WithEvents LblAge As Label
    Friend WithEvents LblName As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
