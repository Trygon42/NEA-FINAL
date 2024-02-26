Imports System.IO
Public Class DischargedPatients

    ''' <summary>
    ''' Shows a datagrid where all discharged patients can be viewed
    ''' </summary>
    ''' 
    Private Sub DischargedPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ReadFile As String = IO.Path.Combine(Application.StartupPath, "Discharged Patients table.csv")
        Dim LoadData As String = ""
        Dim SplitAt() As String
        Dim ToContinue As Boolean = True 'To Continue ensures the loop stops when the reader reaches the end of the file 

        'Checking file exists - if it doesnt nothing is loaded to avoid error etc
        If File.Exists(ReadFile) = True Then

            Using objReader As New StreamReader(ReadFile)

                'checks if there is a next record
                If objReader.Peek() = -1 Then
                    ToContinue = False
                End If

                Do While ToContinue

                    'Reading the data and adding to datagrid
                    LoadData = objReader.ReadLine()
                    SplitAt = Split(LoadData, ",")
                    GridDischargedPatients.Rows.Add(SplitAt)

                    'checks if there is a next record
                    If objReader.Peek() = -1 Then
                        ToContinue = False
                    End If

                Loop

            End Using

        End If
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click

        'Allows user to save file using a save dialog

        Dim Location

        Dim saving As New SaveFileDialog()
        saving.FileName = "Discharged Patients table"
        saving.Filter = "CSV File | *.csv"

        If saving.ShowDialog() = DialogResult.OK Then

            Location = IO.Path.Combine(Application.StartupPath, saving.FileName)

            Using s As StreamWriter = New StreamWriter(File.OpenWrite(Location))

                'for each record
                For Each row As DataGridViewRow In GridDischargedPatients.Rows

                    Dim rowData As New List(Of String)

                    'adding each item of data for each record
                    For Each column As DataGridViewColumn In GridDischargedPatients.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next

                    s.WriteLine(String.Join(",", rowData))

                Next

                s.Close()

            End Using

        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub

    Private Sub BtnContact_Click(sender As Object, e As EventArgs) Handles BtnContact.Click

        Try

            'displaying email of selected patinets GP
            Dim n As Integer = GridDischargedPatients.SelectedRows(0).Index
            MsgBox(GridDischargedPatients.Rows(n).Cells("GPEmail").Value, MsgBoxStyle.OkOnly, "Patients GP email")

        Catch ex As Exception

            MsgBox("No patient selected", MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

End Class