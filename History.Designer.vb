<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.btn_ClearAll = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstHistory
        '
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.ItemHeight = 16
        Me.lstHistory.Location = New System.Drawing.Point(3, 3)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(490, 596)
        Me.lstHistory.TabIndex = 0
        '
        'btn_ClearAll
        '
        Me.btn_ClearAll.BackgroundImage = CType(resources.GetObject("btn_ClearAll.BackgroundImage"), System.Drawing.Image)
        Me.btn_ClearAll.Location = New System.Drawing.Point(499, 515)
        Me.btn_ClearAll.Name = "btn_ClearAll"
        Me.btn_ClearAll.Size = New System.Drawing.Size(75, 23)
        Me.btn_ClearAll.TabIndex = 1
        Me.btn_ClearAll.Text = "Clear All"
        Me.btn_ClearAll.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.BackgroundImage = CType(resources.GetObject("btn_Edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_Edit.Location = New System.Drawing.Point(499, 557)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Edit.TabIndex = 2
        Me.btn_Edit.Text = "Edit"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(580, 592)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_ClearAll)
        Me.Controls.Add(Me.lstHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "History"
        Me.Text = "History"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstHistory As ListBox
    Friend WithEvents btn_ClearAll As Button
    Friend WithEvents btn_Edit As Button
End Class
