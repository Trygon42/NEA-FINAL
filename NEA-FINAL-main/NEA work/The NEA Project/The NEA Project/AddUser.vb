Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
''' <summary>
''' Form to add user
''' takes users details and adds them to a CSV so they can login
''' </summary>
''' 
Public Class AddUser
    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click
        'Adding a user

        Dim FullName As String
        Dim Username As String
        Dim Email As String
        Dim Password As String

        Dim Success As Boolean = False
        Dim Location As String = IO.Path.Combine(Application.StartupPath, "Users table.csv") 'file that this form will use

        If TxtName.Text <> "" Then
            If TxtUsername.Text <> "" Then  'presence check validation
                If TxtEmail.Text <> "" And TxtEmail.Text.Contains("@") Then

                    'Checking both passwords match and exist
                    If TxtPassword.Text <> "" And TxtPasswordCon.Text = TxtPassword.Text Then

                        Success = True

                        'Taking data from text boxes
                        FullName = TxtName.Text
                        Username = TxtUsername.Text
                        Email = TxtEmail.Text
                        Password = TxtPassword.Text

                        GridUsers.Rows.Add(FullName, Username, Email, Password)

                        'Data already loaded into datagrid and will be added so old file is to be deleted 
                        If Dir(Location) <> "" Then

                            Kill(Location)

                        End If

                        'Saving The users table
                        Using s As StreamWriter = New StreamWriter(File.OpenWrite(Location))

                            'for each individual user
                            For Each row As DataGridViewRow In GridUsers.Rows

                                Dim rowData As New List(Of String)

                                'adding each peice of data about user
                                For Each column As DataGridViewColumn In GridUsers.Columns
                                    rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                                Next

                                s.WriteLine(String.Join(",", rowData))

                            Next

                            s.Close()

                        End Using

                    End If
                End If
            End If
        End If

        If Not (Success) Then

            'User entered incorrect data and should be notified 
            MsgBox("Please fill all fields or check data entered is appropriate", MsgBoxStyle.OkOnly, "Error")

        End If

    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        Me.Close()

    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ReadFile As String = IO.Path.Combine(Application.StartupPath, "Users table.csv")
        Dim LoadData As String = ""
        Dim SplitAt() As String
        Dim ToContinue As Boolean = True 'To Continue ensures the loop stops when the reader reaches the end of the file 

        'Checking file exists - if it doesnt nothing is loaded to avoid error etc
        If File.Exists(ReadFile) = True Then

            Using objReader As New StreamReader(ReadFile)

                If objReader.Peek() = -1 Then
                    ToContinue = False
                End If

                Do While ToContinue

                    'Reading the data to datagrid 
                    LoadData = objReader.ReadLine()
                    SplitAt = Split(LoadData, ",")
                    GridUsers.Rows.Add(SplitAt)

                    'Checking if there is another record
                    If objReader.Peek() = -1 Then
                        ToContinue = False
                    End If

                Loop

            End Using

        End If
    End Sub

End Class