Imports System.IO
Imports System.Net
Public Class Form1
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ForwardBtn_Click(sender As Object, e As EventArgs) Handles ForwardBtn.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ReloadBtn_Click(sender As Object, e As EventArgs) Handles ReloadBtn.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSearchEngines.Items.Add("Google")
        cmbSearchEngines.Items.Add("Baidu")

        cmbSearchEngines.SelectedIndex = 0
        WebBrowser1.Navigate("Baidu.com")
    End Sub

    Private Sub txtUrl_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUrl.KeyUp
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(txtUrl.Text)
        End If
    End Sub
    Private Sub webIcons()
        Dim wc As New WebClient
        Dim memorystream As New MemoryStream(wc.DownloadData("http://" & New Uri(WebBrowser1.Url.ToString).Host & "/favicon.ico"))
        Dim icon As New Icon(memorystream)
        If ImageList1.Images.Count = -1 Then
            ImageList1.Images.Add(icon.ToBitmap)
            TabControl1.SelectedTab.ImageIndex = 0
        Else
            ImageList1.Images.Clear()
            ImageList1.Images.Add(icon.ToBitmap)
            TabControl1.SelectedTab.ImageIndex = 0
        End If
    End Sub
    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        txtUrl.Text = WebBrowser1.Url.ToString
        webIcons()

        TabControl1.SelectedTab.Text = WebBrowser1.DocumentTitle.ToString
    End Sub
    Private Sub txtUrlSearchEngines_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUrlSearchEngines.KeyUp
        Select Case (cmbSearchEngines.SelectedIndex)
            Case 0
                If e.KeyCode = Keys.Enter Then
                    WebBrowser1.Navigate("http://www.google.com/search?q=" + txtUrlSearchEngines.Text)
                End If
            Case 1
                If e.KeyCode = Keys.Enter Then
                    WebBrowser1.Navigate("http://www.baidu.com/#wd=" + txtUrlSearchEngines.Text)
                End If
        End Select
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        WebBrowser1.Navigate(My.Settings.HomePage)
    End Sub

    Private Sub ArquivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArquivoToolStripMenuItem.Click

    End Sub
End Class
