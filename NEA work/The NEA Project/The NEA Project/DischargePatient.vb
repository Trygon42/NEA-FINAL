Imports System.IO
Public Class DischargePatient
    ''' <summary>
    ''' A form to discharge patients 
    ''' Moves selected patinet record from main patients csv to discharged patients CSV
    ''' </summary>

    Private Sub DischargePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim n As Integer = Patients.GridPatients.SelectedRows(0).Index 'validation already done before this is called so not required here
        Dim Name As String

        'takes patient name and puts it on the label in the discahrge form
        Name = Patients.GridPatients.Rows(n).Cells("PatientName").Value
        Firstname.Text = Name

    End Sub
    Private Sub BtnDischarge_Click(sender As Object, e As EventArgs) Handles BtnDischarge.Click

        Try

            Dim Name As String
            Dim Age As Integer
            Dim Height As Double
            Dim Weight As Double
            Dim DOB As Date
            Dim History As String
            Dim GPName As String
            Dim GPEmail As String
            Dim Ethnicity As String
            Dim OtherInfo As String
            Dim Sex As String

            'File this form will be using
            Dim Location As String = IO.Path.Combine(Application.StartupPath, "Discharged Patients table.csv")

            DischargedPatients.Show()

            'Defines selected patinet
            Dim n As Integer = Patients.GridPatients.SelectedRows(0).Index

            'Takes data from record on original table 
            Name = Patients.GridPatients.Rows(n).Cells("PatientName").Value
            Sex = Patients.GridPatients.Rows(n).Cells("Sex").Value
            Height = Patients.GridPatients.Rows(n).Cells("Height").Value
            Weight = Patients.GridPatients.Rows(n).Cells("Weight").Value
            OtherInfo = Patients.GridPatients.Rows(n).Cells("Other").Value
            Ethnicity = Patients.GridPatients.Rows(n).Cells("Ethnicity").Value
            History = Patients.GridPatients.Rows(n).Cells("History").Value
            DOB = Patients.GridPatients.Rows(n).Cells("PatientDOB").Value
            GPName = Patients.GridPatients.Rows(n).Cells("GPName").Value
            GPEmail = Patients.GridPatients.Rows(n).Cells("GPEmail").Value

            'adds record to discharge table
            DischargedPatients.GridDischargedPatients.Rows.Add(Name, Sex, Age, Height, Weight, DOB, History, GPName, GPEmail, Ethnicity, OtherInfo)

            'Data already loaded into datagrid and will be added so old file is to be deleted 
            If Dir(Location) <> "" Then

                Kill(Location)

            End If

            'Saving The discharged paitnets table
            Using s As StreamWriter = New StreamWriter(File.OpenWrite(Location))

                'for each record
                For Each row As DataGridViewRow In DischargedPatients.GridDischargedPatients.Rows

                    Dim rowData As New List(Of String)

                    'Data for each patient added to datagrid
                    For Each column As DataGridViewColumn In DischargedPatients.GridDischargedPatients.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next

                    s.WriteLine(String.Join(",", rowData))

                Next

                s.Close()

            End Using

            'Changing focus to patinets CSV file 
            Location = IO.Path.Combine(Application.StartupPath, "Patients table.csv")

            'Removing old record
            Patients.GridPatients.Rows.RemoveAt(n)

            'Data already loaded into datagrid And will be added so old file Is to be deleted 
            If Dir(Location) <> "" Then

                Kill(Location)

            End If

            'saving normal patients table  
            Using s As StreamWriter = New StreamWriter(File.OpenWrite(Location))

                'for each record
                For Each row As DataGridViewRow In Patients.GridPatients.Rows

                    Dim rowData As New List(Of String)

                    'Data for each patient added to datagrid
                    For Each column As DataGridViewColumn In Patients.GridPatients.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next

                    s.WriteLine(String.Join(",", rowData))

                Next

                s.Close()

            End Using

            MsgBox("The patient has been successfully discharged", MsgBoxStyle.OkOnly, "Patient Discharged")
            Me.Close()

        Catch ex As Exception

            MsgBox("Error in discharging patient", MsgBoxStyle.OkOnly, "Error")

            Me.Close()

        End Try

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()   'exit button
    End Sub

End Class