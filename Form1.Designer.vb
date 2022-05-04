<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesfazerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefazerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelecionarTudoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConteúdoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtUrlSearchEngine = New System.Windows.Forms.ToolStrip()
        Me.BackBtn = New System.Windows.Forms.ToolStripButton()
        Me.ForwardBtn = New System.Windows.Forms.ToolStripButton()
        Me.ReloadBtn = New System.Windows.Forms.ToolStripButton()
        Me.txtUrl = New System.Windows.Forms.ToolStripComboBox()
        Me.HomeBtn = New System.Windows.Forms.ToolStripButton()
        Me.cmbSearchEngines = New System.Windows.Forms.ToolStripComboBox()
        Me.txtUrlSearchEngines = New System.Windows.Forms.ToolStripTextBox()
        Me.DownloadBtn = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.txtUrlSearchEngine.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.FerramentasToolStripMenuItem, Me.BookmarksToolStripMenuItem, Me.DownloadToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1261, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.ToolStripMenuItem1, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.ArquivoToolStripMenuItem.Text = "&File"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Image = CType(resources.GetObject("NovoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(320, 26)
        Me.NovoToolStripMenuItem.Text = "New Tab"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Image = CType(resources.GetObject("SalvarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalvarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(320, 26)
        Me.SalvarToolStripMenuItem.Text = "&New Window"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(320, 26)
        Me.AbrirToolStripMenuItem.Text = "&New Private Window"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(320, 26)
        Me.ToolStripMenuItem1.Text = "&Print"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(320, 26)
        Me.SairToolStripMenuItem.Text = "&Exit"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesfazerToolStripMenuItem, Me.RefazerToolStripMenuItem, Me.toolStripSeparator3, Me.RecortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.ColarToolStripMenuItem, Me.toolStripSeparator4, Me.SelecionarTudoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditarToolStripMenuItem.Text = "&Edit"
        '
        'DesfazerToolStripMenuItem
        '
        Me.DesfazerToolStripMenuItem.Name = "DesfazerToolStripMenuItem"
        Me.DesfazerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DesfazerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DesfazerToolStripMenuItem.Text = "&Desfazer"
        '
        'RefazerToolStripMenuItem
        '
        Me.RefazerToolStripMenuItem.Name = "RefazerToolStripMenuItem"
        Me.RefazerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RefazerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RefazerToolStripMenuItem.Text = "&Refazer"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(221, 6)
        '
        'RecortarToolStripMenuItem
        '
        Me.RecortarToolStripMenuItem.Image = CType(resources.GetObject("RecortarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RecortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RecortarToolStripMenuItem.Name = "RecortarToolStripMenuItem"
        Me.RecortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.RecortarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RecortarToolStripMenuItem.Text = "Recor&tar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'ColarToolStripMenuItem
        '
        Me.ColarToolStripMenuItem.Image = CType(resources.GetObject("ColarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ColarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        Me.ColarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ColarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ColarToolStripMenuItem.Text = "C&olar"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(221, 6)
        '
        'SelecionarTudoToolStripMenuItem
        '
        Me.SelecionarTudoToolStripMenuItem.Name = "SelecionarTudoToolStripMenuItem"
        Me.SelecionarTudoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SelecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizarToolStripMenuItem, Me.OpçõesToolStripMenuItem})
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.FerramentasToolStripMenuItem.Text = "&Options"
        '
        'PersonalizarToolStripMenuItem
        '
        Me.PersonalizarToolStripMenuItem.Name = "PersonalizarToolStripMenuItem"
        Me.PersonalizarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PersonalizarToolStripMenuItem.Text = "&Personalizar"
        '
        'OpçõesToolStripMenuItem
        '
        Me.OpçõesToolStripMenuItem.Name = "OpçõesToolStripMenuItem"
        Me.OpçõesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OpçõesToolStripMenuItem.Text = "&Opções"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConteúdoToolStripMenuItem, Me.ÍndiceToolStripMenuItem, Me.PesquisarToolStripMenuItem, Me.toolStripSeparator5, Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.AjudaToolStripMenuItem.Text = "&Help"
        '
        'ConteúdoToolStripMenuItem
        '
        Me.ConteúdoToolStripMenuItem.Name = "ConteúdoToolStripMenuItem"
        Me.ConteúdoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ConteúdoToolStripMenuItem.Text = "&Conteúdo"
        '
        'ÍndiceToolStripMenuItem
        '
        Me.ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ÍndiceToolStripMenuItem.Text = "Í&ndice"
        '
        'PesquisarToolStripMenuItem
        '
        Me.PesquisarToolStripMenuItem.Name = "PesquisarToolStripMenuItem"
        Me.PesquisarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PesquisarToolStripMenuItem.Text = "&Pesquisar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(221, 6)
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SobreToolStripMenuItem.Text = "&Sobre..."
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.DownloadToolStripMenuItem.Text = "&History"
        '
        'BookmarksToolStripMenuItem
        '
        Me.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem"
        Me.BookmarksToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.BookmarksToolStripMenuItem.Text = "Bookmarks"
        '
        'txtUrlSearchEngine
        '
        Me.txtUrlSearchEngine.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtUrlSearchEngine.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.txtUrlSearchEngine.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackBtn, Me.ForwardBtn, Me.ReloadBtn, Me.txtUrl, Me.HomeBtn, Me.cmbSearchEngines, Me.txtUrlSearchEngines, Me.DownloadBtn})
        Me.txtUrlSearchEngine.Location = New System.Drawing.Point(0, 28)
        Me.txtUrlSearchEngine.Name = "txtUrlSearchEngine"
        Me.txtUrlSearchEngine.Size = New System.Drawing.Size(1261, 28)
        Me.txtUrlSearchEngine.TabIndex = 1
        Me.txtUrlSearchEngine.Text = "ToolStrip1"
        '
        'BackBtn
        '
        Me.BackBtn.AutoSize = False
        Me.BackBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackBtn.Image = CType(resources.GetObject("BackBtn.Image"), System.Drawing.Image)
        Me.BackBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(50, 25)
        Me.BackBtn.Text = "Back"
        '
        'ForwardBtn
        '
        Me.ForwardBtn.AutoSize = False
        Me.ForwardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardBtn.Image = CType(resources.GetObject("ForwardBtn.Image"), System.Drawing.Image)
        Me.ForwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardBtn.Name = "ForwardBtn"
        Me.ForwardBtn.Size = New System.Drawing.Size(50, 25)
        Me.ForwardBtn.Text = "Forward"
        '
        'ReloadBtn
        '
        Me.ReloadBtn.AutoSize = False
        Me.ReloadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReloadBtn.Image = CType(resources.GetObject("ReloadBtn.Image"), System.Drawing.Image)
        Me.ReloadBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReloadBtn.Name = "ReloadBtn"
        Me.ReloadBtn.Size = New System.Drawing.Size(50, 25)
        Me.ReloadBtn.Text = "Reload"
        '
        'txtUrl
        '
        Me.txtUrl.AutoSize = False
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(350, 28)
        '
        'HomeBtn
        '
        Me.HomeBtn.AutoSize = False
        Me.HomeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"), System.Drawing.Image)
        Me.HomeBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(50, 25)
        Me.HomeBtn.Text = "Home"
        '
        'cmbSearchEngines
        '
        Me.cmbSearchEngines.AutoSize = False
        Me.cmbSearchEngines.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.cmbSearchEngines.Name = "cmbSearchEngines"
        Me.cmbSearchEngines.Size = New System.Drawing.Size(120, 28)
        '
        'txtUrlSearchEngines
        '
        Me.txtUrlSearchEngines.AutoSize = False
        Me.txtUrlSearchEngines.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUrlSearchEngines.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.txtUrlSearchEngines.Name = "txtUrlSearchEngines"
        Me.txtUrlSearchEngines.Size = New System.Drawing.Size(90, 25)
        '
        'DownloadBtn
        '
        Me.DownloadBtn.AutoSize = False
        Me.DownloadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DownloadBtn.Image = CType(resources.GetObject("DownloadBtn.Image"), System.Drawing.Image)
        Me.DownloadBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DownloadBtn.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.DownloadBtn.Name = "DownloadBtn"
        Me.DownloadBtn.Size = New System.Drawing.Size(50, 25)
        Me.DownloadBtn.Text = "Download"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1261, 987)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1253, 958)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1247, 952)
        Me.WebBrowser1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 1043)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtUrlSearchEngine)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.txtUrlSearchEngine.ResumeLayout(False)
        Me.txtUrlSearchEngine.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesfazerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefazerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RecortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelecionarTudoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerramentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConteúdoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesquisarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtUrlSearchEngine As ToolStrip
    Friend WithEvents BackBtn As ToolStripButton
    Friend WithEvents ForwardBtn As ToolStripButton
    Friend WithEvents ReloadBtn As ToolStripButton
    Friend WithEvents txtUrl As ToolStripComboBox
    Friend WithEvents HomeBtn As ToolStripButton
    Friend WithEvents txtUrlSearchEngines As ToolStripTextBox
    Friend WithEvents cmbSearchEngines As ToolStripComboBox
    Friend WithEvents DownloadBtn As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem As ToolStripMenuItem
End Class
