Public Class History
    Private Sub btn_ClearAll_Click(sender As Object, e As EventArgs) Handles btn_ClearAll.Click
        lstHistory.Items.Clear()
        System.IO.File.Delete("C:\AA\History.txt")
    End Sub

    Private Sub lstHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHistory.SelectedIndexChanged

    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub History_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click

    End Sub
End Class