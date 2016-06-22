<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCamera
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
        Me.videoSourcePlayer = New AForge.Controls.VideoSourcePlayer()
        Me.disconnectButton = New System.Windows.Forms.Button()
        Me.connectButton = New System.Windows.Forms.Button()
        Me.snapshotResolutionsCombo = New System.Windows.Forms.ComboBox()
        Me.videoResolutionsCombo = New System.Windows.Forms.ComboBox()
        Me.devicesCombo = New System.Windows.Forms.ComboBox()
        Me.triggerButton = New DevExpress.XtraEditors.SimpleButton()
        Me.picCard = New System.Windows.Forms.PictureBox()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'videoSourcePlayer
        '
        Me.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDark
        Me.videoSourcePlayer.ForeColor = System.Drawing.Color.DarkRed
        Me.videoSourcePlayer.Location = New System.Drawing.Point(12, 12)
        Me.videoSourcePlayer.Name = "videoSourcePlayer"
        Me.videoSourcePlayer.Size = New System.Drawing.Size(358, 274)
        Me.videoSourcePlayer.TabIndex = 1
        Me.videoSourcePlayer.VideoSource = Nothing
        '
        'disconnectButton
        '
        Me.disconnectButton.Location = New System.Drawing.Point(412, 64)
        Me.disconnectButton.Name = "disconnectButton"
        Me.disconnectButton.Size = New System.Drawing.Size(75, 21)
        Me.disconnectButton.TabIndex = 14
        Me.disconnectButton.Text = "切断"
        Me.disconnectButton.UseVisualStyleBackColor = True
        '
        'connectButton
        '
        Me.connectButton.Location = New System.Drawing.Point(493, 64)
        Me.connectButton.Name = "connectButton"
        Me.connectButton.Size = New System.Drawing.Size(75, 21)
        Me.connectButton.TabIndex = 13
        Me.connectButton.Text = "接続"
        Me.connectButton.UseVisualStyleBackColor = True
        '
        'snapshotResolutionsCombo
        '
        Me.snapshotResolutionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.snapshotResolutionsCombo.FormattingEnabled = True
        Me.snapshotResolutionsCombo.Location = New System.Drawing.Point(477, 38)
        Me.snapshotResolutionsCombo.Name = "snapshotResolutionsCombo"
        Me.snapshotResolutionsCombo.Size = New System.Drawing.Size(91, 20)
        Me.snapshotResolutionsCombo.TabIndex = 12
        '
        'videoResolutionsCombo
        '
        Me.videoResolutionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.videoResolutionsCombo.FormattingEnabled = True
        Me.videoResolutionsCombo.Location = New System.Drawing.Point(376, 38)
        Me.videoResolutionsCombo.Name = "videoResolutionsCombo"
        Me.videoResolutionsCombo.Size = New System.Drawing.Size(95, 20)
        Me.videoResolutionsCombo.TabIndex = 11
        '
        'devicesCombo
        '
        Me.devicesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.devicesCombo.FormattingEnabled = True
        Me.devicesCombo.Location = New System.Drawing.Point(376, 12)
        Me.devicesCombo.Name = "devicesCombo"
        Me.devicesCombo.Size = New System.Drawing.Size(192, 20)
        Me.devicesCombo.TabIndex = 10
        '
        'triggerButton
        '
        Me.triggerButton.Location = New System.Drawing.Point(412, 251)
        Me.triggerButton.Name = "triggerButton"
        Me.triggerButton.Size = New System.Drawing.Size(75, 35)
        Me.triggerButton.TabIndex = 16
        Me.triggerButton.Text = "写真"
        '
        'picCard
        '
        Me.picCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCard.Location = New System.Drawing.Point(388, 102)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(180, 140)
        Me.picCard.TabIndex = 17
        Me.picCard.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(493, 251)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 35)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "登録"
        '
        'frmCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(580, 295)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.picCard)
        Me.Controls.Add(Me.triggerButton)
        Me.Controls.Add(Me.disconnectButton)
        Me.Controls.Add(Me.connectButton)
        Me.Controls.Add(Me.snapshotResolutionsCombo)
        Me.Controls.Add(Me.videoResolutionsCombo)
        Me.Controls.Add(Me.devicesCombo)
        Me.Controls.Add(Me.videoSourcePlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmCamera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snapshot"
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents videoSourcePlayer As AForge.Controls.VideoSourcePlayer
    Private WithEvents disconnectButton As System.Windows.Forms.Button
    Private WithEvents connectButton As System.Windows.Forms.Button
    Private WithEvents snapshotResolutionsCombo As System.Windows.Forms.ComboBox
    Private WithEvents videoResolutionsCombo As System.Windows.Forms.ComboBox
    Private WithEvents devicesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents triggerButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picCard As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
