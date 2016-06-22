<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSIM
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gcSim = New DevExpress.XtraGrid.GridControl()
        Me.gvSim = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riSIMLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gcSim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riSIMLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gcSim)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Size = New System.Drawing.Size(511, 520)
        Me.SplitContainer1.SplitterDistance = 463
        Me.SplitContainer1.TabIndex = 0
        '
        'gcSim
        '
        Me.gcSim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSim.Location = New System.Drawing.Point(0, 0)
        Me.gcSim.MainView = Me.gvSim
        Me.gcSim.Name = "gcSim"
        Me.gcSim.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riSIMLink})
        Me.gcSim.Size = New System.Drawing.Size(511, 463)
        Me.gcSim.TabIndex = 3
        Me.gcSim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSim})
        '
        'gvSim
        '
        Me.gvSim.GridControl = Me.gcSim
        Me.gvSim.Name = "gvSim"
        Me.gvSim.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvSim.OptionsBehavior.Editable = False
        Me.gvSim.OptionsCustomization.AllowGroup = False
        Me.gvSim.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSim.OptionsView.EnableAppearanceOddRow = True
        Me.gvSim.OptionsView.RowAutoHeight = True
        Me.gvSim.OptionsView.ShowGroupPanel = False
        '
        'riSIMLink
        '
        Me.riSIMLink.AutoHeight = False
        Me.riSIMLink.Name = "riSIMLink"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(424, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "OK"
        '
        'frmSIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 520)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSIM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIM情報"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gcSim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riSIMLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcSim As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents riSIMLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
End Class
