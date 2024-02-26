Imports System.IO

''' <summary>
''' Starting form
''' Login form, checks username and password against User csv file 
''' </summary>

Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim ReadFile As String = IO.Path.Combine(Application.StartupPath, "Users table.csv") 'File this form will be working with
        Dim LoadData As String = ""
        Dim SplitAt() As String
        Dim ToContinue As Boolean = True
        Dim Users As List(Of String()) = New List(Of String())  'List of string arrays - each array will contain a User record

        'Taking data from textboxes
        Dim UserUsername As String = TxtUsername.Text
        Dim UserPassword As String = TxtPassword.Text

        Dim Password As String

        'Taking users from the Users csv file and adding them into the users List of arrays
        If File.Exists(ReadFile) = True Then

            Dim n As Integer = 0
            Using objReader As New StreamReader(ReadFile)

                'Checking if there is another record after
                If objReader.Peek() = -1 Then
                    ToContinue = False
                End If

                Do While ToContinue

                    'adding user arrays to list
                    LoadData = objReader.ReadLine()
                    SplitAt = Split(LoadData, ",")
                    Users.Add(SplitAt)

                    'Checking if there is another record after
                    If objReader.Peek() = -1 Then
                        ToContinue = False
                    End If

                    n += 1

                Loop
            End Using
        End If

        Users = BubbleSort(Users)

        Password = BinarySearch(Users, UserUsername, ((Users.Count) - 1), 0)

        If Password = "" Then

            MsgBox("Your username is not recognised. Please contact your administrator to create an account.", MsgBoxStyle.OkOnly, "Incorrect username")

        ElseIf UserPassword = Password Then

            'Login correct - entering program
            MainMenu.Show()
            TxtUsername.Clear()
            TxtPassword.Clear()
            Me.Hide()

        Else

            MsgBox("Your password is incorrect. Please try again or contact your administrator.", MsgBoxStyle.OkOnly, "Incorrect passwrd")

        End If
    End Sub

    Private Function BubbleSort(Users As List(Of String()))

        Dim n As Integer = (Users.Count)
        Dim swapped As Boolean = False
        Dim Tem As String()

        'loop that goes through the list in Users
        For i = 0 To (n - 1)

            swapped = False
            For j = 0 To (n - i - 2)

                'swapping
                If Users(j)(1).CompareTo(Users(j + 1)(1)) = -1 Then

                    swapped = True
                    Tem = Users(j)
                    Users(j) = Users(j + 1)
                    Users(j + 1) = Tem

                End If
            Next j

            'When sorted
            If Not (swapped) Then
                Exit For
            End If

        Next i

        Return Users

    End Function

    Private Function BinarySearch(Users As List(Of String()), Target As String, Top As Integer, Bottom As Integer)

        Dim MidPoint As Integer

        MidPoint = (Top + Bottom) \ 2

        Try

            'When item found
            If Target = Users(MidPoint)(1) Then

                Return Users(MidPoint)(3)

                'item not found
            ElseIf Bottom > Top Or Top < Bottom Then

                Return ""

                'Target item below current midpoint
            ElseIf Users(MidPoint)(1).CompareTo(Target) = -1 Then

                Return BinarySearch(Users, Target, (MidPoint - 1), Bottom) ''''''''''''''''''''''''''''''''''''''''''Recursion''''''''

                'Target item below current midpoint
            ElseIf Users(MidPoint)(1).CompareTo(Target) = 1 Then

                Return BinarySearch(Users, Target, Top, (MidPoint + 1))        '''''''''''''''''''''''''''''''''''''''''Recursion''''''''

            Else

                Return ""

            End If

        Catch ex As Exception

            Return ""

        End Try

    End Function

End Class
