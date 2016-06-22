<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTranslation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTranslation))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gcTList = New DevExpress.XtraGrid.GridControl()
        Me.gvTList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.splweb = New System.Windows.Forms.SplitContainer()
        Me.gcTranslation = New DevExpress.XtraGrid.GridControl()
        Me.gvTranslation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.webT = New System.Windows.Forms.WebBrowser()
        Me.cmsTMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttxCopyText = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsReadGText = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsReturnEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsEMailTranslation = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gcTList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splweb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splweb.Panel1.SuspendLayout()
        Me.splweb.Panel2.SuspendLayout()
        Me.splweb.SuspendLayout()
        CType(Me.gcTranslation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTranslation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsTMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gcTList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.splweb)
        Me.SplitContainer1.Size = New System.Drawing.Size(1070, 625)
        Me.SplitContainer1.SplitterDistance = 208
        Me.SplitContainer1.TabIndex = 0
        '
        'gcTList
        '
        Me.gcTList.AllowDrop = True
        Me.gcTList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcTList.Location = New System.Drawing.Point(0, 0)
        Me.gcTList.MainView = Me.gvTList
        Me.gcTList.Name = "gcTList"
        Me.gcTList.Size = New System.Drawing.Size(208, 625)
        Me.gcTList.TabIndex = 4
        Me.gcTList.UseEmbeddedNavigator = True
        Me.gcTList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTList})
        '
        'gvTList
        '
        Me.gvTList.GridControl = Me.gcTList
        Me.gvTList.Name = "gvTList"
        Me.gvTList.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvTList.OptionsCustomization.AllowGroup = False
        Me.gvTList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTList.OptionsView.EnableAppearanceOddRow = True
        Me.gvTList.OptionsView.ShowGroupPanel = False
        '
        'splweb
        '
        Me.splweb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splweb.Location = New System.Drawing.Point(0, 0)
        Me.splweb.Name = "splweb"
        Me.splweb.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splweb.Panel1
        '
        Me.splweb.Panel1.Controls.Add(Me.gcTranslation)
        '
        'splweb.Panel2
        '
        Me.splweb.Panel2.Controls.Add(Me.webT)
        Me.splweb.Size = New System.Drawing.Size(858, 625)
        Me.splweb.SplitterDistance = 369
        Me.splweb.TabIndex = 0
        '
        'gcTranslation
        '
        Me.gcTranslation.AllowDrop = True
        Me.gcTranslation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcTranslation.Location = New System.Drawing.Point(0, 0)
        Me.gcTranslation.MainView = Me.gvTranslation
        Me.gcTranslation.Name = "gcTranslation"
        Me.gcTranslation.Size = New System.Drawing.Size(858, 369)
        Me.gcTranslation.TabIndex = 4
        Me.gcTranslation.UseEmbeddedNavigator = True
        Me.gcTranslation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTranslation})
        '
        'gvTranslation
        '
        Me.gvTranslation.GridControl = Me.gcTranslation
        Me.gvTranslation.Name = "gvTranslation"
        Me.gvTranslation.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvTranslation.OptionsCustomization.AllowGroup = False
        Me.gvTranslation.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTranslation.OptionsView.EnableAppearanceOddRow = True
        Me.gvTranslation.OptionsView.ShowGroupPanel = False
        '
        'webT
        '
        Me.webT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webT.Location = New System.Drawing.Point(0, 0)
        Me.webT.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webT.Name = "webT"
        Me.webT.ScriptErrorsSuppressed = True
        Me.webT.Size = New System.Drawing.Size(858, 252)
        Me.webT.TabIndex = 0
        '
        'cmsTMenu
        '
        Me.cmsTMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttxCopyText, Me.ttsReadGText, Me.ttsReturnEnglish, Me.ttsReplace, Me.ttsSave, Me.ttsEMailTranslation})
        Me.cmsTMenu.Name = "cmsTMenu"
        Me.cmsTMenu.Size = New System.Drawing.Size(197, 158)
        '
        'ttxCopyText
        '
        Me.ttxCopyText.Image = CType(resources.GetObject("ttxCopyText.Image"), System.Drawing.Image)
        Me.ttxCopyText.Name = "ttxCopyText"
        Me.ttxCopyText.Size = New System.Drawing.Size(196, 22)
        Me.ttxCopyText.Text = "テキストコピー(貼り付け）"
        '
        'ttsReadGText
        '
        Me.ttsReadGText.Image = CType(resources.GetObject("ttsReadGText.Image"), System.Drawing.Image)
        Me.ttsReadGText.Name = "ttsReadGText"
        Me.ttsReadGText.Size = New System.Drawing.Size(196, 22)
        Me.ttsReadGText.Text = "翻訳テキスト読み込み"
        '
        'ttsReturnEnglish
        '
        Me.ttsReturnEnglish.Image = CType(resources.GetObject("ttsReturnEnglish.Image"), System.Drawing.Image)
        Me.ttsReturnEnglish.Name = "ttsReturnEnglish"
        Me.ttsReturnEnglish.Size = New System.Drawing.Size(196, 22)
        Me.ttsReturnEnglish.Text = "英語に戻す"
        '
        'ttsReplace
        '
        Me.ttsReplace.Image = CType(resources.GetObject("ttsReplace.Image"), System.Drawing.Image)
        Me.ttsReplace.Name = "ttsReplace"
        Me.ttsReplace.Size = New System.Drawing.Size(196, 22)
        Me.ttsReplace.Text = "置換"
        '
        'ttsSave
        '
        Me.ttsSave.Image = CType(resources.GetObject("ttsSave.Image"), System.Drawing.Image)
        Me.ttsSave.Name = "ttsSave"
        Me.ttsSave.Size = New System.Drawing.Size(196, 22)
        Me.ttsSave.Text = "登録"
        '
        'ttsEMailTranslation
        '
        Me.ttsEMailTranslation.Image = CType(resources.GetObject("ttsEMailTranslation.Image"), System.Drawing.Image)
        Me.ttsEMailTranslation.Name = "ttsEMailTranslation"
        Me.ttsEMailTranslation.Size = New System.Drawing.Size(196, 22)
        Me.ttsEMailTranslation.Text = "完了の翻訳をメール"
        '
        'frmTranslation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 625)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTranslation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "翻訳"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gcTList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splweb.Panel1.ResumeLayout(False)
        Me.splweb.Panel2.ResumeLayout(False)
        CType(Me.splweb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splweb.ResumeLayout(False)
        CType(Me.gcTranslation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTranslation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsTMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmsTMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttxCopyText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsReadGText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gcTList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents splweb As System.Windows.Forms.SplitContainer
    Friend WithEvents gcTranslation As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTranslation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents webT As System.Windows.Forms.WebBrowser
    Friend WithEvents ttsReturnEnglish As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsReplace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsEMailTranslation As System.Windows.Forms.ToolStripMenuItem
End Class
