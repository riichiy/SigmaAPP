<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.xtcMain = New DevExpress.XtraTab.XtraTabControl()
        Me.tabSMTP = New DevExpress.XtraTab.XtraTabPage()
        Me.txtSenderName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSenderEMailID = New System.Windows.Forms.TextBox()
        Me.txtSMTPServerName = New System.Windows.Forms.TextBox()
        Me.txtPortName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkSSL = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAuthenticationReqd = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabFTP = New DevExpress.XtraTab.XtraTabPage()
        Me.txtFTPDefaultFolder = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFTPPassword = New System.Windows.Forms.TextBox()
        Me.txtFTPHost = New System.Windows.Forms.TextBox()
        Me.txtFTPWebAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFTPUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdTest = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSaveSettings = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcMain.SuspendLayout()
        Me.tabSMTP.SuspendLayout()
        Me.tabFTP.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.xtcMain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdTest)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdSaveSettings)
        Me.SplitContainer1.Size = New System.Drawing.Size(448, 363)
        Me.SplitContainer1.SplitterDistance = 297
        Me.SplitContainer1.TabIndex = 0
        '
        'xtcMain
        '
        Me.xtcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcMain.Location = New System.Drawing.Point(0, 0)
        Me.xtcMain.Name = "xtcMain"
        Me.xtcMain.SelectedTabPage = Me.tabSMTP
        Me.xtcMain.Size = New System.Drawing.Size(448, 297)
        Me.xtcMain.TabIndex = 0
        Me.xtcMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSMTP, Me.tabFTP})
        '
        'tabSMTP
        '
        Me.tabSMTP.Controls.Add(Me.txtSenderName)
        Me.tabSMTP.Controls.Add(Me.Label10)
        Me.tabSMTP.Controls.Add(Me.txtPassword)
        Me.tabSMTP.Controls.Add(Me.txtSenderEMailID)
        Me.tabSMTP.Controls.Add(Me.txtSMTPServerName)
        Me.tabSMTP.Controls.Add(Me.txtPortName)
        Me.tabSMTP.Controls.Add(Me.Label14)
        Me.tabSMTP.Controls.Add(Me.chkSSL)
        Me.tabSMTP.Controls.Add(Me.Label3)
        Me.tabSMTP.Controls.Add(Me.chkAuthenticationReqd)
        Me.tabSMTP.Controls.Add(Me.Label4)
        Me.tabSMTP.Controls.Add(Me.Label5)
        Me.tabSMTP.Controls.Add(Me.txtUserName)
        Me.tabSMTP.Controls.Add(Me.Label6)
        Me.tabSMTP.Name = "tabSMTP"
        Me.tabSMTP.Size = New System.Drawing.Size(442, 268)
        Me.tabSMTP.Text = "SMTP"
        '
        'txtSenderName
        '
        Me.txtSenderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenderName.Location = New System.Drawing.Point(53, 28)
        Me.txtSenderName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSenderName.Name = "txtSenderName"
        Me.txtSenderName.Size = New System.Drawing.Size(325, 22)
        Me.txtSenderName.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(51, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 15)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "差出人　名前"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(127, 220)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(249, 22)
        Me.txtPassword.TabIndex = 8
        '
        'txtSenderEMailID
        '
        Me.txtSenderEMailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenderEMailID.Location = New System.Drawing.Point(53, 77)
        Me.txtSenderEMailID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSenderEMailID.Name = "txtSenderEMailID"
        Me.txtSenderEMailID.Size = New System.Drawing.Size(325, 22)
        Me.txtSenderEMailID.TabIndex = 2
        '
        'txtSMTPServerName
        '
        Me.txtSMTPServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSMTPServerName.Location = New System.Drawing.Point(52, 125)
        Me.txtSMTPServerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSMTPServerName.Name = "txtSMTPServerName"
        Me.txtSMTPServerName.Size = New System.Drawing.Size(226, 22)
        Me.txtSMTPServerName.TabIndex = 3
        '
        'txtPortName
        '
        Me.txtPortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPortName.Location = New System.Drawing.Point(285, 125)
        Me.txtPortName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPortName.Name = "txtPortName"
        Me.txtPortName.Size = New System.Drawing.Size(91, 22)
        Me.txtPortName.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(51, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 15)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "差出人　メールアドレス"
        '
        'chkSSL
        '
        Me.chkSSL.AutoSize = True
        Me.chkSSL.BackColor = System.Drawing.Color.Transparent
        Me.chkSSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSL.Location = New System.Drawing.Point(52, 153)
        Me.chkSSL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSSL.Name = "chkSSL"
        Me.chkSSL.Size = New System.Drawing.Size(49, 19)
        Me.chkSSL.TabIndex = 5
        Me.chkSSL.Text = "SSL"
        Me.chkSSL.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "SMTP サーバー"
        '
        'chkAuthenticationReqd
        '
        Me.chkAuthenticationReqd.AutoSize = True
        Me.chkAuthenticationReqd.BackColor = System.Drawing.Color.Transparent
        Me.chkAuthenticationReqd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuthenticationReqd.Location = New System.Drawing.Point(127, 153)
        Me.chkAuthenticationReqd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAuthenticationReqd.Name = "chkAuthenticationReqd"
        Me.chkAuthenticationReqd.Size = New System.Drawing.Size(74, 19)
        Me.chkAuthenticationReqd.TabIndex = 6
        Me.chkAuthenticationReqd.Text = "認証必要"
        Me.chkAuthenticationReqd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "ポート"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "パスワード"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Location = New System.Drawing.Point(127, 184)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(249, 22)
        Me.txtUserName.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "ユーザー名"
        '
        'tabFTP
        '
        Me.tabFTP.Controls.Add(Me.txtFTPDefaultFolder)
        Me.tabFTP.Controls.Add(Me.Label9)
        Me.tabFTP.Controls.Add(Me.txtFTPPassword)
        Me.tabFTP.Controls.Add(Me.txtFTPHost)
        Me.tabFTP.Controls.Add(Me.txtFTPWebAddress)
        Me.tabFTP.Controls.Add(Me.Label1)
        Me.tabFTP.Controls.Add(Me.Label2)
        Me.tabFTP.Controls.Add(Me.Label7)
        Me.tabFTP.Controls.Add(Me.txtFTPUsername)
        Me.tabFTP.Controls.Add(Me.Label8)
        Me.tabFTP.Name = "tabFTP"
        Me.tabFTP.Size = New System.Drawing.Size(442, 268)
        Me.tabFTP.Text = "FTP"
        '
        'txtFTPDefaultFolder
        '
        Me.txtFTPDefaultFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFTPDefaultFolder.Location = New System.Drawing.Point(168, 59)
        Me.txtFTPDefaultFolder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFTPDefaultFolder.Name = "txtFTPDefaultFolder"
        Me.txtFTPDefaultFolder.Size = New System.Drawing.Size(248, 22)
        Me.txtFTPDefaultFolder.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "デフォルトフォルダー"
        '
        'txtFTPPassword
        '
        Me.txtFTPPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFTPPassword.Location = New System.Drawing.Point(167, 157)
        Me.txtFTPPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFTPPassword.Name = "txtFTPPassword"
        Me.txtFTPPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtFTPPassword.Size = New System.Drawing.Size(249, 22)
        Me.txtFTPPassword.TabIndex = 14
        Me.txtFTPPassword.UseSystemPasswordChar = True
        '
        'txtFTPHost
        '
        Me.txtFTPHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFTPHost.Location = New System.Drawing.Point(168, 26)
        Me.txtFTPHost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFTPHost.Name = "txtFTPHost"
        Me.txtFTPHost.Size = New System.Drawing.Size(248, 22)
        Me.txtFTPHost.TabIndex = 10
        '
        'txtFTPWebAddress
        '
        Me.txtFTPWebAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFTPWebAddress.Location = New System.Drawing.Point(168, 91)
        Me.txtFTPWebAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFTPWebAddress.Name = "txtFTPWebAddress"
        Me.txtFTPWebAddress.Size = New System.Drawing.Size(248, 22)
        Me.txtFTPWebAddress.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "ホスト名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "ウェブアドレス"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "パスワード"
        '
        'txtFTPUsername
        '
        Me.txtFTPUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFTPUsername.Location = New System.Drawing.Point(167, 124)
        Me.txtFTPUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFTPUsername.Name = "txtFTPUsername"
        Me.txtFTPUsername.Size = New System.Drawing.Size(249, 22)
        Me.txtFTPUsername.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "ユーザー名"
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(16, 12)
        Me.cmdTest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(92, 34)
        Me.cmdTest.TabIndex = 25
        Me.cmdTest.Text = "接続テスト"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(246, 12)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 34)
        Me.cmdClose.TabIndex = 24
        Me.cmdClose.Text = "キャンセル"
        '
        'cmdSaveSettings
        '
        Me.cmdSaveSettings.Location = New System.Drawing.Point(344, 12)
        Me.cmdSaveSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdSaveSettings.Name = "cmdSaveSettings"
        Me.cmdSaveSettings.Size = New System.Drawing.Size(92, 34)
        Me.cmdSaveSettings.TabIndex = 23
        Me.cmdSaveSettings.Text = "登録"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 363)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "設定"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcMain.ResumeLayout(False)
        Me.tabSMTP.ResumeLayout(False)
        Me.tabSMTP.PerformLayout()
        Me.tabFTP.ResumeLayout(False)
        Me.tabFTP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents xtcMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabSMTP As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtSenderEMailID As System.Windows.Forms.TextBox
    Friend WithEvents txtSMTPServerName As System.Windows.Forms.TextBox
    Friend WithEvents txtPortName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkSSL As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkAuthenticationReqd As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tabFTP As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSaveSettings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFTPDefaultFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFTPPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtFTPHost As System.Windows.Forms.TextBox
    Friend WithEvents txtFTPWebAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFTPUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSenderName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
