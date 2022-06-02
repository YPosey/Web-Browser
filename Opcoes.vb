Public Class Opcoes
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtHomePage_TextChanged(sender As Object, e As EventArgs) Handles txtHomePage.TextChanged

    End Sub
    Private Sub Opcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHomePage.Text = My.Settings.HomePage()
        If My.Settings.HomeOrBlank = 0 Then
            cmbStartUp.SelectedIndex = 0
        ElseIf My.Settings.HomeOrBlank = 1 Then
            cmbStartUp.SelectedIndex = 1
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.HomePage = txtHomePage.Text
        My.Settings.Save()
        My.Settings.Reload()

        My.Settings.HomeOrBlank = cmbStartUp.SelectedIndex.ToString
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
End Class