''' <summary>
''' Basic form used to take data input from user and add patient
''' </summary>

Public Class AddPatient

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click

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

        Try
            'taking data from patient input 
            Name = TxtName.Text
            Height = CDbl(TxtHeight.Text)
            Weight = CDbl(TxtWeight.Text)
            DOB = DateTimePicker2.Text
            History = TxtHistory.Text
            GPName = TxtGPname.Text
            GPEmail = TxtGPEmail.Text
            Ethnicity = CmbEthnicity.Text
            OtherInfo = TxtOther.Text

            'assigning sex variable
            If RdMale.Checked Then
                Sex = "Male"

            ElseIf RdFemale.Checked Then
                Sex = "Female"

            Else
                Sex = "Other"

            End If

            'calculating age from DOB
            Dim timeDif As TimeSpan = Now - DOB
            Age = Int((timeDif.TotalSeconds) / 31536000)

            LblDisplay.Text = "Patient added"

            'adds patient to data grid
            Patients.GridPatients.Rows.Add(Name, Sex, Age, Height, Weight, DOB, History, GPName, GPEmail, Ethnicity, OtherInfo)
            '[Add to file]

            Me.Close()

        Catch ex As Exception

            MsgBox("Please fill all fields or check data entered is appropriate", MsgBoxStyle.OkOnly, "Error")

        End Try

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()   'exits program 
    End Sub
End Class