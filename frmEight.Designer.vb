<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEight))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.picDrop = New DevExpress.XtraEditors.PictureEdit()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbcStatus = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.picDrop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pbcStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.pbcStatus)
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
        Me.tssMessage.Size = New System.Drawing.Size(39, 17)
        Me.tssMessage.Text = "Ready"
        '
        'pbcStatus
        '
        Me.pbcStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbcStatus.Location = New System.Drawing.Point(0, 0)
        Me.pbcStatus.Name = "pbcStatus"
        Me.pbcStatus.Size = New System.Drawing.Size(364, 122)
        Me.pbcStatus.TabIndex = 0
        '
        'frmEight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 144)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eight CSV 同期"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.picDrop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.pbcStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents picDrop As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pbcStatus As DevExpress.XtraEditors.ProgressBarControl
End Class
