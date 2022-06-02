<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opcoes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtHomePage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbStartUp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Download = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.rbAlwaysSave = New System.Windows.Forms.RadioButton()
        Me.rbSaveTo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.Download.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtHomePage)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbStartUp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Start Up:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(295, 111)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 22)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtHomePage
        '
        Me.txtHomePage.Location = New System.Drawing.Point(119, 83)
        Me.txtHomePage.Name = "txtHomePage"
        Me.txtHomePage.Size = New System.Drawing.Size(232, 22)
        Me.txtHomePage.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HomePage:"
        '
        'cmbStartUp
        '
        Me.cmbStartUp.FormattingEnabled = True
        Me.cmbStartUp.Items.AddRange(New Object() {"Go to Home Page ", "Go to Blank Page"})
        Me.cmbStartUp.Location = New System.Drawing.Point(157, 39)
        Me.cmbStartUp.Name = "cmbStartUp"
        Me.cmbStartUp.Size = New System.Drawing.Size(194, 24)
        Me.cmbStartUp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "When Naveg Starts:"
        '
        'Download
        '
        Me.Download.Controls.Add(Me.btnBrowse)
        Me.Download.Controls.Add(Me.TextBox2)
        Me.Download.Controls.Add(Me.rbAlwaysSave)
        Me.Download.Controls.Add(Me.rbSaveTo)
        Me.Download.Location = New System.Drawing.Point(7, 181)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(365, 128)
        Me.Download.TabIndex = 1
        Me.Download.TabStop = False
        Me.Download.Text = "Downloads"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(287, 40)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(43, 22)
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Text = "..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(131, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 22)
        Me.TextBox2.TabIndex = 4
        '
        'rbAlwaysSave
        '
        Me.rbAlwaysSave.AutoSize = True
        Me.rbAlwaysSave.Location = New System.Drawing.Point(6, 82)
        Me.rbAlwaysSave.Name = "rbAlwaysSave"
        Me.rbAlwaysSave.Size = New System.Drawing.Size(253, 21)
        Me.rbAlwaysSave.TabIndex = 2
        Me.rbAlwaysSave.TabStop = True
        Me.rbAlwaysSave.Text = "Always Ask me Where to Save Files"
        Me.rbAlwaysSave.UseVisualStyleBackColor = True
        '
        'rbSaveTo
        '
        Me.rbSaveTo.AutoSize = True
        Me.rbSaveTo.Location = New System.Drawing.Point(6, 40)
        Me.rbSaveTo.Name = "rbSaveTo"
        Me.rbSaveTo.Size = New System.Drawing.Size(114, 21)
        Me.rbSaveTo.TabIndex = 0
        Me.rbSaveTo.TabStop = True
        Me.rbSaveTo.Text = "Save Files to:"
        Me.rbSaveTo.UseVisualStyleBackColor = True
        '
        'Opcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 321)
        Me.Controls.Add(Me.Download)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Opcoes"
        Me.Text = "Opcoes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Download.ResumeLayout(False)
        Me.Download.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbStartUp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Download As GroupBox
    Friend WithEvents rbSaveTo As RadioButton
    Friend WithEvents txtHomePage As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents rbAlwaysSave As RadioButton
    Friend WithEvents btnSave As Button
End Class
