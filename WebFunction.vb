Public Class WebFunction
    Inherits WebBrowser
    Private Sub WebBrowserDocCompl() Handles Me.DocumentCompleted
        Dim tabPage As TabPage = Me.Tag
        Dim Form1 As New Form1
        tabPage.Text = Me.DocumentTitle
        Form1.txtUrl.Text = Me.Url.ToString()
    End Sub
End Class
