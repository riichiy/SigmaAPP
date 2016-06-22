Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text
Imports System.Environment

Public Class frmFTP
    Dim Hostname As String = "sigmanest.jp"
    Dim Username As String = "SNUser"
    Dim password As String = "BestNest1445"
    Dim FTPDefaultFolder As String = "/httpdocs/Downloads/"
    Dim HTTPLink As String = "http://www.sigmanest.jp/downloads/"
    Dim ini As New IniFile(Application.StartupPath & "\Settings.ini")
    Private Sub frmFTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If File.Exists(ini.FileName) Then
                Try
                    Hostname = ini.ReadIniString("FTP", "HostName")
                    'FTPDefaultFolder = ini.ReadIniString("FTP", "DefaultFolder")
                    HTTPLink = ini.ReadIniString("FTP", "WebAddress")
                    Username = ini.ReadIniString("FTP", "UserName")
                    password = ini.ReadIniString("FTP", "Password")
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception

        End Try

  
        appData = GetFolderPath(SpecialFolder.CommonDocuments)
        tssMessage.Text = "準備OK"
        chkZip.Checked = False
        txtPassword.Text = RandomString(5, 8)
        txtPassword.Enabled = False
    End Sub
    Function RandomString(minCharacters As Integer, maxCharacters As Integer) As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Delegate Sub IncrementProgressDelegate(ByVal aThreadName As String, ByVal aProgressBar As DevExpress.XtraEditors.ProgressBarControl, ByVal ThreadStatus As String)
    Public Sub IncrementProgress(ByVal aThreadName As String, ByVal aProgressBar As DevExpress.XtraEditors.ProgressBarControl, ByVal ThreadStatus As String)
        Select Case ThreadStatus
            Case "INC"
                aProgressBar.Increment(1)
            Case "FINISHED"

            Case Else

        End Select
    End Sub
    Private Sub CreateLink(ByVal DownloadPath As String)
        Dim MsgLink As String = ""
        MsgLink = "下記のリンクからフィアルをダウンロードして下さい。" & vbCrLf
        MsgLink = MsgLink & DownloadPath & vbCrLf & vbCrLf
        If chkZipLock.Checked = True Then
            MsgLink = MsgLink & "パスワードは：" & txtPassword.Text & vbCrLf
        End If
        Clipboard.SetText(MsgLink)
    End Sub
    Private Sub UploadFile(ByVal FilePath As String)
        Dim ftp As New Chilkat.Ftp2()
        Dim success As Boolean
        Dim FileSize As Double = 0
        success = ftp.UnlockComponent("RIICHIFTP_2drPonwunRn2")
        If (success <> True) Then
            Console.WriteLine(ftp.LastErrorText)
            Exit Sub
        End If
        ftp.Hostname = Hostname
        ftp.Username = Username
        ftp.Password = password
        ftp.Passive = True
        '  Connect and login to the FTP server.
        success = ftp.Connect()
        If (success <> True) Then
            MsgBox("FTPに接続できませんでした。")
            Exit Sub
        End If
        '  Change to the remote directory where the file will be uploaded.
        success = ftp.ChangeRemoteDir(FTPDefaultFolder)
        If (success <> True) Then
            MsgBox("FTPのフォルダーが見つかりません。")
            Exit Sub
        End If

        Dim localFilename As String = FilePath
        Dim remoteFilename As String = Path.GetFileName(FilePath)

        success = ftp.AsyncPutFileStart(localFilename, remoteFilename)
        If (success <> True) Then
            Console.WriteLine(ftp.LastErrorText)
            Exit Sub
        End If
        Dim infoReader As System.IO.FileInfo
        infoReader = My.Computer.FileSystem.GetFileInfo(FilePath)
        FileSize = infoReader.Length

        While ftp.AsyncFinished <> True
            ftp.SleepMs(1000)
        End While

        '  Did the upload succeed?
        If (ftp.AsyncSuccess = True) Then
            tssMessage.Text = "アップロード完了"
            txtFTPPath.Text = HTTPLink & Path.GetFileName(FilePath)
            CreateLink(txtFTPPath.Text)
        Else

        End If
        ftp.Disconnect()
        File.Delete(FilePath)
    End Sub
    Private Function CreateZipFile(ByVal FilePath As String, ByVal DoPassword As Boolean) As String
        Dim zip As New Chilkat.Zip()
        Dim success As Boolean
        Dim i As Integer = 0
        Dim TmpPath As String = ""
        success = zip.UnlockComponent("RIICHIZIP_r86X7vbw1Stl")
        TmpPath = appData & "\" & Path.GetFileNameWithoutExtension(FilePath) & ".zip"
        success = zip.NewZip(TmpPath)
        If DoPassword = True Then
            zip.SetPassword(txtPassword.Text)
            zip.PasswordProtect = True
        End If
        zip.AppendFiles(FilePath, False)
        success = zip.WriteZipAndClose()
        CreateZipFile = TmpPath
    End Function
    Public Sub ProcessFiles(ByVal FilePath As String)
        If chkZip.Checked = False And chkZipLock.Checked = False Then
            UploadFile(FilePath)
        ElseIf chkZip.Checked = True Then
            If UCase(Path.GetExtension(FilePath)) = ".ZIP" Then
                UploadFile(FilePath)
            Else
                UploadFile(CreateZipFile(FilePath, False))
            End If
        ElseIf chkZipLock.Checked = True Then
            UploadFile(CreateZipFile(FilePath, True))
        End If

    End Sub
    Private Sub picDrop_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles picDrop.DragDrop
        'copy file(s) to destination folder
        Dim destinationPath As String = appData & "\"
        'check if this is an outlook message. The outlook messages, all contain a FileContents attribute. If not, exit.
        Dim formats() As String = e.Data.GetFormats()

        'If formats.Contains("FileContents") = False Then Exit Sub

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim draggedFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each fileName As String In draggedFiles
                ProcessFiles(fileName)
            Next
        ElseIf (e.Data.GetDataPresent("FileGroupDescriptor")) Then

            Dim app As New Microsoft.Office.Interop.Outlook.Application() ' // get current selected items
            Dim selection As Microsoft.Office.Interop.Outlook.Selection
            Dim myText As String = ""
            selection = app.ActiveExplorer.Selection
            If selection IsNot Nothing Then

                Dim mailItem As Microsoft.Office.Interop.Outlook._MailItem
                For i As Integer = 0 To selection.Count - 1
                    Dim FilenameStr As String = ""
                    mailItem = TryCast(selection.Item(i + 1), Microsoft.Office.Interop.Outlook._MailItem)
                    If mailItem IsNot Nothing Then
                        Try
                            For Each att As Microsoft.Office.Interop.Outlook.Attachment In mailItem.Attachments
                                Dim att_filename As String = att.FileName
                                Dim att_extension As String = att_filename.Substring(att_filename.LastIndexOf("."))
                                If InStr(1, UCase(att_filename), "JAPANESE", CompareMethod.Text) > 0 Then
                                    Dim TmpPath As String = destinationPath & att_filename
                                    att.SaveAsFile(TmpPath)
                                    ProcessFiles(TmpPath)
                                    File.Delete(TmpPath)
                                End If
                            Next
                        Catch ex As System.Exception
                            MsgBox(ex.Message)
                        Finally
                            Marshal.ReleaseComObject(mailItem)
                        End Try
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub picDrop_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles picDrop.DragEnter
        ' for this program, we allow a file to be dropped from Explorer
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            '    or this tells us if it is an Outlook attachment drop
        ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
            e.Effect = DragDropEffects.Copy
        Else
            '    or none of the above
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub chkZipLock_CheckedChanged(sender As Object, e As EventArgs) Handles chkZipLock.CheckedChanged
        chkZip.Checked = False
        If chkZipLock.Checked = True Then
            txtPassword.Enabled = True
        Else
            txtPassword.Enabled = False
        End If
    End Sub

    Private Sub chkZip_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkZip.CheckedChanged
        chkZipLock.Checked = False
    End Sub

    Private Sub btnCopyPassword_Click(sender As Object, e As EventArgs) Handles btnCopyPassword.Click
        Try
            Clipboard.SetText(txtPassword.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCopyLink_Click(sender As Object, e As EventArgs) Handles btnCopyLink.Click
        Try
            Clipboard.SetText(txtFTPPath.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub picDrop_DoubleClick(sender As Object, e As EventArgs) Handles picDrop.DoubleClick
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "ファイルを開く"
        fd.InitialDirectory = "C:\"
        fd.Filter = "全てのファイル (*.*)|*.*|全てのファイル (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            ProcessFiles(strFileName)
        End If
    End Sub
End Class