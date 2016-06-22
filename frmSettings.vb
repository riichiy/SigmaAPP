Imports System.Environment
Imports System.IO

Public Class frmSettings
    Dim ini As New IniFile(Application.StartupPath & "\Settings.ini")
    Dim ini2 As New IniFile(GetFolderPath(SpecialFolder.CommonDocuments) & "\Mail.ini")
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xtcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        CheckSettings()
    End Sub
    Private Sub CheckSettings()
        If File.Exists(ini2.FileName) Then
            Try
                txtSenderName.Text = ini2.ReadIniString("SMTP", "SenderName")
                txtSenderEMailID.Text = ini2.ReadIniString("SMTP", "SenderEMail")
                txtSMTPServerName.Text = ini2.ReadIniString("SMTP", "SMTPServer")
                txtPortName.Text = ini2.ReadIniString("SMTP", "PortName")
                chkSSL.CheckState = ini2.ReadIniString("SMTP", "SMTPSSL")
                chkAuthenticationReqd.CheckState = ini2.ReadIniString("SMTP", "SMTPAuth")
                txtUserName.Text = ini2.ReadIniString("SMTP", "UserName")
                txtPassword.Text = ini2.ReadIniString("SMTP", "Password")
            Catch ex As Exception

            End Try
        End If
        If File.Exists(ini.FileName) Then
            Try
                txtFTPHost.Text = ini.ReadIniString("FTP", "HostName")
                txtFTPDefaultFolder.Text = ini.ReadIniString("FTP", "DefaultFolder")
                txtFTPWebAddress.Text = ini.ReadIniString("FTP", "WebAddress")
                txtFTPUsername.Text = ini.ReadIniString("FTP", "UserName")
                txtFTPPassword.Text = ini.ReadIniString("FTP", "Password")
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub SaveSettings()
        Try
            ini2.WriteIni("SMTP", "SenderName", txtSenderName.Text)
            ini2.WriteIni("SMTP", "SenderEMail", txtSenderEMailID.Text)
            ini2.WriteIni("SMTP", "SMTPServer", txtSMTPServerName.Text)
            ini2.WriteIni("SMTP", "PortName", txtPortName.Text)
            ini2.WriteIni("SMTP", "SMTPSSL", chkSSL.CheckState)
            ini2.WriteIni("SMTP", "SMTPAuth", chkAuthenticationReqd.CheckState)
            ini2.WriteIni("SMTP", "UserName", txtUserName.Text)
            ini2.WriteIni("SMTP", "Password", txtPassword.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            ini.WriteIni("FTP", "HostName", txtFTPHost.Text)
            ini.WriteIni("FTP", "DefaultFolder", txtFTPDefaultFolder.Text)
            ini.WriteIni("FTP", "WebAddress", txtFTPWebAddress.Text)
            ini.WriteIni("FTP", "UserName", txtFTPUsername.Text)
            ini.WriteIni("FTP", "Password", txtFTPPassword.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CheckEMail()
        If txtSenderEMailID.Text = "" Then
            MsgBox("Eメールを入力して下さい。")
            Exit Sub
        End If
        If txtSMTPServerName.Text = "" Then
            MsgBox("SMTPサーバーを設定して下さい。")
            Exit Sub
        ElseIf txtPortName.Text = "" Then
            MsgBox("ポートを設定して下さい。")
            Exit Sub
        ElseIf txtUserName.Text = "" Then
            MsgBox("ユーザー名を設定して下さい")
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MsgBox("パスワードを設定して下さい。")
            Exit Sub
        End If
        Dim mailman As New Chilkat.MailMan() ' Any string passed to
        Dim success As Boolean = False
        mailman.UnlockComponent("RIICHIMAILQ_JSCKps2y9Uo9")
        mailman.SmtpHost = txtSMTPServerName.Text
        If chkSSL.Checked Then
            mailman.SmtpAuthMethod = "SSL"
        Else

        End If
        mailman.SmtpPort = txtPortName.Text
        If chkAuthenticationReqd.Checked Then
            mailman.SmtpSsl = True
        Else
            mailman.SmtpSsl = False
        End If
        mailman.SmtpUsername = txtUserName.Text
        mailman.SmtpPassword = txtPassword.Text

        success = mailman.VerifySmtpConnection

        If success = True Then
            MsgBox("メールサーバーに接続できました。")
        Else
            MsgBox("メールサーバーの接続に失敗しました。")
        End If
    End Sub
    Private Sub CheckFTP()
        Dim ftp As New Chilkat.Ftp2()
        Dim success As Boolean
        Dim FileSize As Double = 0
        success = ftp.UnlockComponent("RIICHIFTP_2drPonwunRn2")
        If (success <> True) Then
            Console.WriteLine(ftp.LastErrorText)
            Exit Sub
        End If
        ftp.Hostname = txtFTPHost.Text
        ftp.Username = txtFTPUsername.Text
        ftp.Password = txtFTPPassword.Text
        '  Connect and login to the FTP server.
        success = ftp.Connect()
        If success = True Then
            MsgBox("FTPサーバーに接続できました。")
        Else
            MsgBox("FTPサーバーの接続に失敗しました。")
        End If
    End Sub
    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        If xtcMain.SelectedTabPage Is tabSMTP Then
            CheckEMail()
        Else
            CheckFTP()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
    Private Sub cmdSaveSettings_Click(sender As Object, e As EventArgs) Handles cmdSaveSettings.Click
        SaveSettings()
        Close()
    End Sub
End Class