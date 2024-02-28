Imports System.Windows.Forms.VisualStyles.VisualStyleElement

''' <summary>
''' A menu used to edit and show a specific Patient 
''' </summary>

Public Class SelectedPatient
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub
    Private Sub SelectedPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim n As Integer = Patients.GridPatients.SelectedRows(0).Index


        'Getting Data for patient
        LblName.Text = Patients.GridPatients.Rows(n).Cells("PatientName").Value
        TxtSex.Text = Patients.GridPatients.Rows(n).Cells("Sex").Value
        TxtHeight.Text = Patients.GridPatients.Rows(n).Cells("Height").Value
        TxtWeight.Text = Patients.GridPatients.Rows(n).Cells("Weight").Value
        TxtNotes.Text = Patients.GridPatients.Rows(n).Cells("Other").Value
        TxtEthnicity.Text = Patients.GridPatients.Rows(n).Cells("Ethnicity").Value
        TxtMedicalHist.Text = Patients.GridPatients.Rows(n).Cells("History").Value
        DtpDOB.Value = Patients.GridPatients.Rows(n).Cells("PatientDOB").Value

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim n As Integer = Patients.GridPatients.SelectedRows(0).Index

        'Applying the changes to the datagrid

        Try

            Patients.GridPatients.Rows(n).Cells("PatientName").Value = LblName.Text
            Patients.GridPatients.Rows(n).Cells("Sex").Value = TxtSex.Text
            Patients.GridPatients.Rows(n).Cells("Height").Value = CDbl(TxtHeight.Text)
            Patients.GridPatients.Rows(n).Cells("Weight").Value = CDbl(TxtWeight.Text)
            Patients.GridPatients.Rows(n).Cells("Other").Value = TxtNotes.Text

            Dim timeDif As TimeSpan = Now - DtpDOB.Value
            Dim Age As Integer = Int((timeDif.TotalSeconds) / 31536000)

            Patients.GridPatients.Rows(n).Cells("Age").Value = Age
            Patients.GridPatients.Rows(n).Cells("Ethnicity").Value = TxtEthnicity.Text
            Patients.GridPatients.Rows(n).Cells("History").Value = TxtMedicalHist.Text
            Patients.GridPatients.Rows(n).Cells("PatientDOB").Value = DtpDOB.Value

        Catch ex As Exception

            MsgBox("Please fill all fields or check data entered is appropriate", MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

End Class