Imports System.IO
''' <summary>
''' This form shows a datagrid with all patients on it 
''' It has a variaty of differnet ways in which the user can manage the patients 
''' </summary>
Public Class Patients
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAddPatient_Click(sender As Object, e As EventArgs) Handles BtnAddPatient.Click
        AddPatient.Show()
    End Sub

    Private Sub BtnDischargePatient_Click(sender As Object, e As EventArgs) Handles BtnDischargePatient.Click

        Try
            'Error trapping to ensure the user has selected a viable record to discharge

            Dim n As Integer = GridPatients.SelectedRows(0).Index
            Name = GridPatients.Rows(n).Cells("PatientName").Value

            If Name <> "" Then
                DischargePatient.Show()
            Else
                MsgBox("You have selected an empty record", MsgBoxStyle.OkOnly, "Error")
            End If

        Catch ex As Exception
            MsgBox("Please select patient", MsgBoxStyle.OkOnly, "Error")
        End Try

    End Sub

    Private Sub BtnDeletePatient_Click(sender As Object, e As EventArgs) Handles BtnDeletePatient.Click
        Try
            'Error trapping to ensure the user has selected a viable record to delete

            Dim n As Integer = GridPatients.SelectedRows(0).Index
            GridPatients.Rows.RemoveAt(n) 'Deleting

        Catch ex As Exception

            MsgBox("Select patient", MsgBoxStyle.OkOnly, "Error")

        End Try
    End Sub

    Private Sub BtnViewDis_Click(sender As Object, e As EventArgs) Handles BtnViewDis.Click

        DischargedPatients.Show()

    End Sub

    Private Sub BtnContact_Click(sender As Object, e As EventArgs) Handles BtnContact.Click

        Try
            'Error trapping to ensure the user has selected a viable record

            Dim n As Integer = GridPatients.SelectedRows(0).Index
            MsgBox(GridPatients.Rows(n).Cells("GPEmail").Value, MsgBoxStyle.OkOnly, "Patients GP email") 'displaying GP email

        Catch ex As Exception

            MsgBox("No patient selected", MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    Private Sub Patients_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Other forms are dependant on this form so if it is closed without using the given buttons the user is asked and then the whole program closes to avoid error

        If MsgBox("Are you sure you wish to quit form?", MsgBoxStyle.YesNo, "Attention") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Login.Close()
        End If

    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click

        Dim saving As New SaveFileDialog()
        saving.FileName = "Patients table"
        saving.Filter = "CSV File | *.csv"

        'Saving patinet using a save dialog (exporting)
        If saving.ShowDialog() = DialogResult.OK Then

            SavePatients(IO.Path.Combine(Application.StartupPath, saving.FileName))

        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'Saving patinets to program files (without dialog)

        Dim FileName As String = "Patients table.csv"
        SavePatients(IO.Path.Combine(Application.StartupPath, FileName))

    End Sub
    Private Sub SavePatients(location As String)

        'Subroutine to save patients in either way

        'Data already loaded into datagrid And will be added so old file Is to be deleted 
        If Dir(location) <> "" Then

            Kill(location)

        End If


        Using s As StreamWriter = New StreamWriter(File.OpenWrite(location))

            'for each record
            For Each row As DataGridViewRow In GridPatients.Rows

                Dim rowData As New List(Of String)

                'adding data for each record
                For Each column As DataGridViewColumn In GridPatients.Columns
                    rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                Next

                s.WriteLine(String.Join(",", rowData))

            Next

            s.Close()

        End Using

        MsgBox("The table has been saved and will load next time the program is opened.", MsgBoxStyle.OkOnly, "Data saved")

    End Sub

    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ReadFile As String = IO.Path.Combine(Application.StartupPath, "Patients table.csv")
        Dim LoadData As String = ""
        Dim SplitAt() As String
        Dim ToContinue As Boolean = True 'To Continue ensures the loop stops when the reader reaches the end of the file 

        'Checking file exists - if it doesnt nothing is loaded to avoid error etc
        If File.Exists(ReadFile) = True Then

            Using objReader As New StreamReader(ReadFile)

                'Checking if there is another record after
                If objReader.Peek() = -1 Then
                    ToContinue = False
                End If

                Do While ToContinue

                    'Reading the data
                    LoadData = objReader.ReadLine()
                    SplitAt = Split(LoadData, ",")
                    GridPatients.Rows.Add(SplitAt)

                    'Checking if there is another record after
                    If objReader.Peek() = -1 Then
                        ToContinue = False
                    End If

                Loop

            End Using

        End If

    End Sub

    Private Sub BtnViewPatient_Click(sender As Object, e As EventArgs) Handles BtnViewPatient.Click

        Try
            'error trapping to ensure a patient is selected

            Dim n As Integer = GridPatients.SelectedRows(0).Index
            SelectedPatient.Show()

        Catch ex As Exception

            MsgBox("Select patient", MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

End Class