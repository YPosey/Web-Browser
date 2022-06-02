Imports System.IO
Imports System.Net
Public Class Form1
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim browser As WebFunction = Me.TabControl1.SelectedTab.Tag
        browser.GoBack()
    End Sub

    Private Sub ForwardBtn_Click(sender As Object, e As EventArgs) Handles ForwardBtn.Click
        Dim browser As WebFunction = Me.TabControl1.SelectedTab.Tag
        browser.GoForward()
    End Sub

    Private Sub ReloadBtn_Click(sender As Object, e As EventArgs) Handles ReloadBtn.Click
        Dim browser As WebFunction = Me.TabControl1.SelectedTab.Tag
        browser.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSearchEngines.Items.Add("Google")
        cmbSearchEngines.Items.Add("Baidu")

        cmbSearchEngines.SelectedIndex = 0

        addTab(TabControl1)

        If My.Settings.HomeOrBlank = 0 Then
            Dim browser As WebFunction = Me.TabControl1.SelectedTab.Tag
            browser.Navigate(My.Settings.HomePage)
        End If
        Try
            History.Show()
            History.Visible = False
            For Each link As String In History.lstHistory.Items
                File.AppendAllText("C:\AA\History.txt", link & vbNewLine)
                History.lstHistory.Items.Add(link.ToString)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtUrl_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUrl.KeyUp
        Dim browser As WebFunction = Me.TabControl1.SelectedTab.Tag
        If e.KeyCode = Keys.Enter Then
   browser.Navigate(txtUrl.Text)
        End If
    End Sub
    Private Sub txtUrlSearchEngines_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUrlSearchEngines.KeyUp
        Dim browser As WebFunction = Me.TabControl1.SelectedTab.Tag
        Select Case (cmbSearchEngines.SelectedIndex)
            Case 0
                If e.KeyCode = Keys.Enter Then
                    browser.Navigate("http://www.google.com/search?q=" + txtUrlSearchEngines.Text)
                End If
            Case 1
                If e.KeyCode = Keys.Enter Then
                    browser.Navigate("http://www.baidu.com/#wd=" + txtUrlSearchEngines.Text)
                End If
        End Select
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim browser As WebFunction = Me.TabControl1.SelectedTab.Tag
        browser.Navigate(My.Settings.HomePage)
    End Sub

    Private Sub ArquivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArquivoToolStripMenuItem.Click

    End Sub

    Private Sub OpçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpçõesToolStripMenuItem.Click
        Opcoes.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl.Text = Now
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        History.Visible = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each link As String In History.lstHistory.Items
            Dim newwindows As New Form1
            newwindows.Show()
            File.AppendAllText("C:\AA\History.txt", link & vbNewLine)
        Next
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem.Click

    End Sub

    Private Sub txtUrlSearchEngines_TextChanged(sender As Object, e As EventArgs) Handles txtUrlSearchEngines.TextChanged
        txtUrl.AutoCompleteCustomSource.Clear()
        For i As Integer = 0 To History.lstHistory.Items.Count - 1
            txtUrl.AutoCompleteCustomSource.Add(History.lstHistory.Items(i))
        Next
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        closeTab()
    End Sub
    Public Sub addTab(ByRef tabControl As TabControl)
        Dim Browser As New WebFunction
        Dim tab As New TabPage
        Browser.Tag = tab
        tab.Tag = Browser
        TabControl1.TabPages.Add(tab)
        tab.Controls.Add(Browser)
        Browser.Dock = DockStyle.Fill
        Browser.Navigate("www.baidu.com")
    End Sub
    Public Sub closeTab()
        If TabControl1.TabPages.Count <> 0 Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        End If
    End Sub
    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        addTab(TabControl1)
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        closeTab()
        Dim newwindows As New Form1
        newwindows.Show()
    End Sub

    Private Sub DownloadBtn_Click(sender As Object, e As EventArgs) Handles DownloadBtn.Click

    End Sub
End Class
