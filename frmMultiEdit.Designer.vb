<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiEdit
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
        Me.gcMultiEdit = New DevExpress.XtraGrid.GridControl()
        Me.gvMultiEdit = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riComboType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.riComboCountry = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.riComboCustomer = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gcMultiEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMultiEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riComboType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riComboCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riComboCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.gcMultiEdit)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnOK)
        Me.SplitContainer1.Size = New System.Drawing.Size(358, 478)
        Me.SplitContainer1.SplitterDistance = 418
        Me.SplitContainer1.TabIndex = 0
        '
        'gcMultiEdit
        '
        Me.gcMultiEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMultiEdit.Location = New System.Drawing.Point(0, 0)
        Me.gcMultiEdit.MainView = Me.gvMultiEdit
        Me.gcMultiEdit.Name = "gcMultiEdit"
        Me.gcMultiEdit.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riComboType, Me.riComboCountry, Me.riComboCustomer})
        Me.gcMultiEdit.Size = New System.Drawing.Size(358, 418)
        Me.gcMultiEdit.TabIndex = 1
        Me.gcMultiEdit.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMultiEdit})
        '
        'gvMultiEdit
        '
        Me.gvMultiEdit.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvMultiEdit.Appearance.Row.Options.UseFont = True
        Me.gvMultiEdit.GridControl = Me.gcMultiEdit
        Me.gvMultiEdit.Name = "gvMultiEdit"
        Me.gvMultiEdit.OptionsView.ShowGroupPanel = False
        '
        'riComboType
        '
        Me.riComboType.AutoHeight = False
        Me.riComboType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riComboType.Name = "riComboType"
        '
        'riComboCountry
        '
        Me.riComboCountry.AutoHeight = False
        Me.riComboCountry.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riComboCountry.Name = "riComboCountry"
        '
        'riComboCustomer
        '
        Me.riComboCustomer.AutoHeight = False
        Me.riComboCustomer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riComboCustomer.Name = "riComboCustomer"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(179, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 40)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "キャンセル"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(271, 9)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 40)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "登録"
        '
        'frmMultiEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 478)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMultiEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "複数編集"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gcMultiEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMultiEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riComboType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riComboCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riComboCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gcMultiEdit As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMultiEdit As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents riComboType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents riComboCountry As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents riComboCustomer As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
