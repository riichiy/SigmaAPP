<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMail
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
        Me.clbFileList = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.chkClear = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCreateMail = New DevExpress.XtraEditors.CheckEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.clbFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkClear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCreateMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.clbFileList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkClear)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkCreateMail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancel)
        Me.SplitContainer1.Size = New System.Drawing.Size(257, 437)
        Me.SplitContainer1.SplitterDistance = 357
        Me.SplitContainer1.TabIndex = 0
        '
        'clbFileList
        '
        Me.clbFileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbFileList.Location = New System.Drawing.Point(0, 0)
        Me.clbFileList.Name = "clbFileList"
        Me.clbFileList.Size = New System.Drawing.Size(257, 357)
        Me.clbFileList.TabIndex = 1
        '
        'chkClear
        '
        Me.chkClear.EditValue = True
        Me.chkClear.Location = New System.Drawing.Point(10, 11)
        Me.chkClear.Name = "chkClear"
        Me.chkClear.Properties.Caption = "クリア"
        Me.chkClear.Size = New System.Drawing.Size(58, 19)
        Me.chkClear.TabIndex = 3
        '
        'chkCreateMail
        '
        Me.chkCreateMail.EditValue = True
        Me.chkCreateMail.Location = New System.Drawing.Point(92, 11)
        Me.chkCreateMail.Name = "chkCreateMail"
        Me.chkCreateMail.Properties.Caption = "Outlook　メール作成"
        Me.chkCreateMail.Size = New System.Drawing.Size(153, 19)
        Me.chkCreateMail.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(170, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "作成"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(76, 36)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "キャンセル"
        '
        'frmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 437)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ファイルリスト"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.clbFileList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkClear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCreateMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents clbFileList As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkCreateMail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkClear As DevExpress.XtraEditors.CheckEdit
End Class
