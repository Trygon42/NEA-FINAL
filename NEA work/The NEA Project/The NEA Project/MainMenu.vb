Public Class MainMenu

    ''' <summary>
    ''' Main menu of program 
    ''' Used to navigate between forms
    ''' </summary>
    Private Sub s_Click(sender As Object, e As EventArgs) Handles s.Click

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Viewpatients_Click(sender As Object, e As EventArgs) Handles Viewpatients.Click

        Patients.Show()
        Me.Hide()

    End Sub

    Private Sub Stats_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Other forms are dependant on this form so if it is closed without using the given buttons the user is asked and then the whole program closes to avoid error

        If MsgBox("Are you sure you wish to quit form?", MsgBoxStyle.YesNo, "Attention") = MsgBoxResult.No Then
            e.Cancel = True

        Else
            Login.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCreateAcc.Click

        AddUser.Show()

    End Sub

    Private Sub BtnDischarged_Click_1(sender As Object, e As EventArgs) Handles BtnDischarged.Click

        DischargedPatients.Show()

    End Sub

End Class