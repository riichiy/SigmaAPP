<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFTP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFTP))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.picDrop = New DevExpress.XtraEditors.PictureEdit()
        Me.btnCopyLink = New System.Windows.Forms.Button()
        Me.btnCopyPassword = New System.Windows.Forms.Button()
        Me.chkZip = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFTPPath = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.chkZipLock = New DevExpress.XtraEditors.CheckEdit()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssMessage = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.picDrop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkZip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFTPPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkZipLock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.picDrop)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCopyLink)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCopyPassword)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkZip)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtFTPPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPassword)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkZipLock)
        Me.SplitContainer1.Size = New System.Drawing.Size(512, 122)
        Me.SplitContainer1.SplitterDistance = 144
        Me.SplitContainer1.TabIndex = 0
        '
        'picDrop
        '
        Me.picDrop.AllowDrop = True
        Me.picDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDrop.EditValue = CType(resources.GetObject("picDrop.EditValue"), Object)
        Me.picDrop.Location = New System.Drawing.Point(0, 0)
        Me.picDrop.Name = "picDrop"
        Me.picDrop.Size = New System.Drawing.Size(144, 122)
        Me.picDrop.TabIndex = 0
        '
        'btnCopyLink
        '
        Me.btnCopyLink.BackgroundImage = CType(resources.GetObject("btnCopyLink.BackgroundImage"), System.Drawing.Image)
        Me.btnCopyLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCopyLink.Location = New System.Drawing.Point(316, 37)
        Me.btnCopyLink.Name = "btnCopyLink"
        Me.btnCopyLink.Size = New System.Drawing.Size(26, 23)
        Me.btnCopyLink.TabIndex = 6
        Me.btnCopyLink.UseVisualStyleBackColor = True
        '
        'btnCopyPassword
        '
        Me.btnCopyPassword.BackgroundImage = CType(resources.GetObject("btnCopyPassword.BackgroundImage"), System.Drawing.Image)
        Me.btnCopyPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCopyPassword.Location = New System.Drawing.Point(316, 83)
        Me.btnCopyPassword.Name = "btnCopyPassword"
        Me.btnCopyPassword.Size = New System.Drawing.Size(26, 23)
        Me.btnCopyPassword.TabIndex = 5
        Me.btnCopyPassword.UseVisualStyleBackColor = True
        '
        'chkZip
        '
        Me.chkZip.Location = New System.Drawing.Point(17, 62)
        Me.chkZip.Name = "chkZip"
        Me.chkZip.Properties.Caption = "ZIPとして"
        Me.chkZip.Size = New System.Drawing.Size(125, 19)
        Me.chkZip.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 14)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "ダウンロードリンク："
        '
        'txtFTPPath
        '
        Me.txtFTPPath.Location = New System.Drawing.Point(17, 37)
        Me.txtFTPPath.Name = "txtFTPPath"
        Me.txtFTPPath.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFTPPath.Properties.Appearance.Options.UseFont = True
        Me.txtFTPPath.Size = New System.Drawing.Size(293, 22)
        Me.txtFTPPath.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(199, 84)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Size = New System.Drawing.Size(111, 22)
        Me.txtPassword.TabIndex = 1
        '
        'chkZipLock
        '
        Me.chkZipLock.Location = New System.Drawing.Point(17, 87)
        Me.chkZipLock.Name = "chkZipLock"
        Me.chkZipLock.Properties.Caption = "ZIPとパスワードロック"
        Me.chkZipLock.Size = New System.Drawing.Size(125, 19)
        Me.chkZipLock.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMessage})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 122)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(512, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssMessage
        '
        Me.tssMessage.Name = "tssMessage"
        Me.tssMessage.Size = New System.Drawing.Size(43, 17)
        Me.tssMessage.Text = "Ready"
        '
        'frmFTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 144)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFTP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "サーバーFTP アップロード"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.picDrop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkZip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFTPPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkZipLock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents picDrop As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFTPPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkZipLock As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkZip As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCopyLink As System.Windows.Forms.Button
    Friend WithEvents btnCopyPassword As System.Windows.Forms.Button
End Class
