<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnExecute = New System.Windows.Forms.Button()
        Me.TxtPasswordCon = New System.Windows.Forms.TextBox()
        Me.LblGPEmail = New System.Windows.Forms.Label()
        Me.LblGPName = New System.Windows.Forms.Label()
        Me.LblHist = New System.Windows.Forms.Label()
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridUsers = New System.Windows.Forms.DataGridView()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cancel.Location = New System.Drawing.Point(134, 252)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(123, 25)
        Me.Cancel.TabIndex = 81
        Me.Cancel.Text = "Exit"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTitle.Location = New System.Drawing.Point(24, 19)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(246, 20)
        Me.LblTitle.TabIndex = 78
        Me.LblTitle.Text = "Provide information on new user"
        '
        'BtnExecute
        '
        Me.BtnExecute.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnExecute.Location = New System.Drawing.Point(114, 221)
        Me.BtnExecute.Name = "BtnExecute"
        Me.BtnExecute.Size = New System.Drawing.Size(165, 25)
        Me.BtnExecute.TabIndex = 77
        Me.BtnExecute.Text = "Add user"
        Me.BtnExecute.UseVisualStyleBackColor = False
        '
        'TxtPasswordCon
        '
        Me.TxtPasswordCon.Location = New System.Drawing.Point(104, 173)
        Me.TxtPasswordCon.Name = "TxtPasswordCon"
        Me.TxtPasswordCon.Size = New System.Drawing.Size(230, 20)
        Me.TxtPasswordCon.TabIndex = 76
        '
        'LblGPEmail
        '
        Me.LblGPEmail.AutoSize = True
        Me.LblGPEmail.Location = New System.Drawing.Point(43, 147)
        Me.LblGPEmail.Name = "LblGPEmail"
        Me.LblGPEmail.Size = New System.Drawing.Size(53, 13)
        Me.LblGPEmail.TabIndex = 73
        Me.LblGPEmail.Text = "Password"
        '
        'LblGPName
        '
        Me.LblGPName.AutoSize = True
        Me.LblGPName.Location = New System.Drawing.Point(25, 124)
        Me.LblGPName.Name = "LblGPName"
        Me.LblGPName.Size = New System.Drawing.Size(73, 13)
        Me.LblGPName.TabIndex = 72
        Me.LblGPName.Text = "Email Address"
        '
        'LblHist
        '
        Me.LblHist.AutoSize = True
        Me.LblHist.Location = New System.Drawing.Point(41, 97)
        Me.LblHist.Name = "LblHist"
        Me.LblHist.Size = New System.Drawing.Size(55, 13)
        Me.LblHist.TabIndex = 71
        Me.LblHist.Text = "Username"
        Me.LblHist.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblFullName
        '
        Me.LblFullName.AutoSize = True
        Me.LblFullName.Location = New System.Drawing.Point(46, 72)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(52, 13)
        Me.LblFullName.TabIndex = 67
        Me.LblFullName.Text = "Full name"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(102, 147)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(232, 20)
        Me.TxtPassword.TabIndex = 66
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(104, 121)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(230, 20)
        Me.TxtEmail.TabIndex = 65
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(104, 95)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(230, 20)
        Me.TxtUsername.TabIndex = 64
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(104, 69)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(230, 20)
        Me.TxtName.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Confirm password"
        '
        'GridUsers
        '
        Me.GridUsers.AllowUserToAddRows = False
        Me.GridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullName, Me.Username, Me.Email, Me.Password})
        Me.GridUsers.Location = New System.Drawing.Point(356, 10)
        Me.GridUsers.Name = "GridUsers"
        Me.GridUsers.Size = New System.Drawing.Size(494, 267)
        Me.GridUsers.TabIndex = 88
        '
        'FullName
        '
        Me.FullName.HeaderText = "Full name"
        Me.FullName.Name = "FullName"
        Me.FullName.Width = 150
        '
        'Username
        '
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.Width = 150
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Width = 150
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.Visible = False
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(862, 292)
        Me.Controls.Add(Me.GridUsers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnExecute)
        Me.Controls.Add(Me.TxtPasswordCon)
        Me.Controls.Add(Me.LblGPEmail)
        Me.Controls.Add(Me.LblGPName)
        Me.Controls.Add(Me.LblHist)
        Me.Controls.Add(Me.LblFullName)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "AddUser"
        Me.Text = "AddUser"
        CType(Me.GridUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnExecute As Button
    Friend WithEvents TxtPasswordCon As TextBox
    Friend WithEvents LblGPEmail As Label
    Friend WithEvents LblGPName As Label
    Friend WithEvents LblHist As Label
    Friend WithEvents LblFullName As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GridUsers As DataGridView
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
End Class
