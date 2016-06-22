Imports System.Text
Imports System.IO
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Reflection
Imports System.Environment
Imports System.Threading

Public Class frmWebMail
#Region "FormLoad"
    Dim m_text As String = ""
    Dim m_type As String = ""
    Dim m_css As String = ""
    Dim m_strMCEDir As String = ""
    Dim m_strMCESettings As String = ""
    Dim hc As mshtml.IHTMLDocument2
    Dim M_WORKPATH As String = "TinyMCE"
    Dim M_RESOURCE As String = "Rakuca"
    Dim TinyMCEPath As String = ""
    Dim lstAttachments As New ArrayList
    Dim SMTPSenderName As String = ""
    Dim SMTPSenderEMailID As String = ""
    Dim SMTPServer As String = ""
    Dim SMTPPort As String = ""
    Dim SMTPSSL As String = ""
    Dim SMTPAuth As String = ""
    Dim SMTPUserName As String = ""
    Dim SMTPPassword As String = ""
    Dim data As DataTable
    Dim ini2 As New IniFile(GetFolderPath(SpecialFolder.CommonDocuments) & "\Mail.ini")
    Private Sub frmMailer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splStatus.Panel2Collapsed = True
        appData = GetFolderPath(SpecialFolder.CommonDocuments)
        txtFrom.ReadOnly = True
        CheckSettings()
        CheckMailList()
        LoadEMailSettings()
        LoadAddressColumns()
    End Sub
    Private Sub LoadEMailSettings()
        Try
            TinyMCEPath = AppDataPath & "TinyMCE\"
            EditText("", "tempfilename", "yourCSS.css")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CheckSettings()
        If File.Exists(ini2.FileName) Then
            Try
                SMTPSenderName = ini2.ReadIniString("SMTP", "SenderName")
                SMTPSenderEMailID = ini2.ReadIniString("SMTP", "SenderEMail")
                SMTPServer = ini2.ReadIniString("SMTP", "SMTPServer")
                SMTPPort = ini2.ReadIniString("SMTP", "PortName")
                SMTPSSL = ini2.ReadIniString("SMTP", "SMTPSSL")
                SMTPAuth = ini2.ReadIniString("SMTP", "SMTPAuth")
                SMTPUserName = ini2.ReadIniString("SMTP", "UserName")
                SMTPPassword = ini2.ReadIniString("SMTP", "Password")
            Catch ex As Exception

            Finally
                txtFrom.Text = SMTPSenderEMailID

            End Try
        End If
    End Sub
    Public Sub CheckMailList()
        Dim EMailPath As String = AppDataPath & "MailList\"
        If Directory.Exists(EMailPath) = False Then
            Directory.CreateDirectory(EMailPath)
        End If
        cmbTo.Properties.Items.Clear()
        Dim di As New System.IO.DirectoryInfo(EMailPath)
        Dim diar1 As System.IO.FileInfo() = di.GetFiles()
        Dim dra As System.IO.FileInfo
        For Each dra In diar1
            If UCase(Path.GetExtension(dra.FullName)) = ".CSV" Then
                cmbTo.Properties.Items.Add(Path.GetFileName(dra.FullName))
            End If
        Next
    End Sub

#End Region
#Region "DXGrid"
    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type)
        AddColumn(data, name, type, False)
    End Sub
    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As DataColumn
        col = New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub
#End Region
#Region "EMail"
    Dim GblEMailList As String = ""
    Delegate Sub StatItemDelegate(ByVal ThreadStatus As String, ByVal StatPosition As Integer, ByVal TotCount As Integer)
    Public Sub StatItem(ByVal ThreadStatus As String, ByVal StatPosition As Integer, ByVal TotCount As Integer)
        Select Case ThreadStatus
            Case "START"
                pbcStatus.Position = 0
            Case "FINISHED"
                splStatus.Panel2Collapsed = True
                CreateNewMail()
            Case Else
                lblStatus.Text = StatPosition & " of " & TotCount
                pbcStatus.Position = StatPosition
        End Select
    End Sub
    Private Sub LoadAddressColumns()
        Dim i As Integer = 0
        data = New DataTable("gvAddress")
        data.Clear()
        data.BeginInit()
        AddColumn(data, "CompanyName", System.Type.GetType("System.String"))
        AddColumn(data, "Name", System.Type.GetType("System.String"))
        AddColumn(data, "EMail", System.Type.GetType("System.String"))
        data.EndInit()

        gcAddress.DataSource = data
        gcAddress.DefaultView.PopulateColumns()
        gvAddress.Columns(0).Width = 150
        gvAddress.Columns(1).Width = 100
        gvAddress.Columns(2).Width = 200
        gvAddress.Columns(0).OptionsColumn.AllowEdit = False
        gvAddress.Columns(1).OptionsColumn.AllowEdit = False
        gvAddress.Columns(2).OptionsColumn.AllowEdit = False
        gvAddress.Columns.ColumnByFieldName("CompanyName").Caption = "会社名"
        gvAddress.Columns.ColumnByFieldName("Name").Caption = "担当者様"
        gvAddress.Columns.ColumnByFieldName("EMail").Caption = "メールアドレス"
    End Sub
    Private Sub LoadAddressData()
        Dim SelList As String = ""
        Dim EMailList As String = ""
        Dim LineItem As String = ""
        SelList = cmbTo.SelectedText
        data.Clear()
        Try
            If InStr(1, UCase(SelList), ".CSV", CompareMethod.Text) > 0 Then
                EMailList = AppDataPath & "MailList\" & SelList
                GblEMailList = EMailList
                Dim sr As New System.IO.StreamReader(EMailList, System.Text.Encoding.GetEncoding(GblEncoding))
                While sr.Peek() > -1
                    LineItem = sr.ReadLine()
                    Dim TmpArr() As String
                    TmpArr = Split(LineItem, ",")
                    data.Rows.Add(TmpArr(0), TmpArr(1), TmpArr(2))
                End While
                sr.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnDeleteList_Click(sender As Object, e As EventArgs) Handles btnDeleteList.Click
        Dim result As Integer = MessageBox.Show(Path.GetFileNameWithoutExtension(GblEMailList) & "　のリストデータを削除して良いのでしょうか？", "リスト削除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Try
                File.Delete(GblEMailList)
                xtcMailMain.SelectedTabPage = tabMessage
                CheckMailList()
                cmbTo.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub SendMessage()
        If Not validate_Controls(True) Then Exit Sub
        If InStr(1, UCase(cmbTo.Text), ".CSV", CompareMethod.Text) > 0 Then ' Multiple email
            pbcStatus.Properties.Minimum = 0
            pbcStatus.Properties.Maximum = gvAddress.RowCount
            pbcStatus.Properties.Step = 1
            pbcStatus.Position = 0
            splStatus.Panel2Collapsed = False
            Dim html As String = ""
            html = CType(axBrowser.Document, mshtml.IHTMLDocument3).getElementById("elm1").innerText
            Dim SLthrd As System.Threading.Thread
            SLthrd = New System.Threading.Thread(DirectCast(Sub() SendMessages(txtFrom.Text, "MULTI", txtSubject.Text, html, "", lstAttachments, True, SMTPSenderName, "", ""), ThreadStart))
            SLthrd.Start()
        Else  'Single email
            If IsValidEMailFormat(cmbTo.Text) = True Then
                splStatus.Panel2Collapsed = True
                Dim html As String = ""
                html = CType(axBrowser.Document, mshtml.IHTMLDocument3).getElementById("elm1").innerText
                Dim SLthrd As System.Threading.Thread
                SLthrd = New System.Threading.Thread(DirectCast(Sub() SendMessages(txtFrom.Text, cmbTo.Text, txtSubject.Text, html, "", lstAttachments, True, SMTPSenderName, "", ""), ThreadStart))
                SLthrd.Start()
            Else
                MsgBox("メールアドレスを確認して下さい。")
            End If
        End If
    End Sub
    Function IsValidEMailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function
    Private Function validate_Controls(ByVal validateSMTP As Boolean) As Boolean
        validate_Controls = True
        If SMTPServer = "" Then
            MsgBox("SMTP設定をおこなって下さい。")
            Dim frmSettings As New frmSettings
            frmSettings.ShowDialog()
            CheckSettings()
            validate_Controls = False
            Exit Function
        End If
        If txtSubject.Text.Trim = "" Then
            If (MessageBox.Show("件名が無いメールを本当に送りますか？", "RakucaSOFT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes) Then
                validate_Controls = True
            Else
                txtSubject.Focus()
                validate_Controls = False
                Exit Function
            End If
        End If

    End Function
    Public Sub CopyFile(ByVal source As Stream, ByVal target As Stream)
        Dim buffer(&H10000) As Byte
        Dim bytes As Integer
        Try
            While ((bytes = source.Read(buffer, 0, buffer.Length)) > 0)
                target.Write(buffer, 0, bytes)
            End While
        Catch ex As Exception
        Finally
            target.Close()
        End Try
    End Sub
    'Get the correct internal path where tinyMCE and work file will be stored
    Private Function getWorkPath(ByVal subPath As String) As String
        Dim AppFolder As String = TinyMCEPath
        Return System.IO.Path.Combine(AppFolder, subPath)
    End Function
    'Prepare tinyMCE package
    Public Sub PrepareTinyMCE()
        Dim strFile As String
        Dim sMCE As String = "jscripts\tiny_mce"
        strFile = TinyMCEPath + "tinyMCE_Jp.txt"
        Dim sr As StreamReader = New StreamReader(strFile, Encoding.UTF8)
        m_strMCESettings = sr.ReadToEnd()
        sr.Close()
        m_strMCEDir = sMCE
    End Sub
    Public Function GetResourceFile(ByVal File As String) As Stream
        If (File Is Nothing Or File = "") Then
            Return Nothing
        End If
        Try
            Return Me.GetType().Assembly.GetManifestResourceStream(File)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Sub doInit()
        Dim empty As Object = System.Reflection.Missing.Value
        axBrowser.Navigate("about:blank", empty, empty, empty, empty)
        hc = CType(axBrowser.Document, mshtml.IHTMLDocument2)
    End Sub
    Public Sub ShowText(ByVal Text As String)
        m_text = Text
        ShowText(False)
        Me.Show()
    End Sub
    Public Function EditText(ByVal Text As String, ByVal Type As String, ByVal CSSFile As String) As String
        Try
            m_text = Text
            m_type = Type
            m_css = CSSFile
            PrepareTinyMCE()
            ShowText(True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ""
    End Function
    Private Sub showText(ByVal edit As Boolean)
        Dim sb As StringBuilder = New StringBuilder()
        'sb.AppendLine("<HTML><HEAD><meta http-equiv=""Content-Type"" content=""text/html; charset=windows-1250"" content=""no-cache"">")
        sb.AppendLine("<HTML><HEAD><meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" content=""no-cache"">")
        If (edit And Not String.IsNullOrEmpty(m_strMCESettings)) Then

            sb.Append("<script type=""text/javascript"" src=""")
            sb.Append(m_strMCEDir.Replace("\", "/")) 'IE compatible
            sb.AppendLine("/tiny_mce.js"">")
            sb.AppendLine("</script>")
            sb.AppendLine(m_strMCESettings)
            sb.AppendLine("</HEAD><BODY><FONT FACE=""Arial"" SIZE=""-1"">")
            sb.AppendLine("<form method="""" action="""" onsubmit=""return false"">")
            sb.AppendLine("<textarea id=""elm1"" name=""elm1"" style=""width: 100%;height:100%"">")

        Else
            sb.AppendLine("</HEAD><BODY><FONT FACE=""Arial"" SIZE=""-1"">")
        End If

        sb.AppendLine(m_text)
        If (edit And Not String.IsNullOrEmpty(m_strMCESettings)) Then
            sb.AppendLine("</textarea>")
        End If

        sb.AppendLine("</FONT></BODY></HTML>")

        'get CSS to local folder
        If (File.Exists(m_css)) Then
            File.Copy(m_css, getWorkPath(m_type + ".css"), True)
            m_css = m_type + ".css"
        End If

        Dim t As String = sb.Replace("[CSS]", m_css).ToString()
        Dim sDoc As String = New Uri(getWorkPath(m_type + ".html")).LocalPath
        'Dim sw As StreamWriter = New StreamWriter(sDoc, False, System.Text.Encoding.GetEncoding(1250))
        Dim sw As StreamWriter = New StreamWriter(sDoc, False, Encoding.UTF8)
        sw.Write(t)
        sw.Close()
        Try
            axBrowser.Navigate(sDoc)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CreateNewMail()
        txtSubject.Text = ""
        cmbTo.Text = ""
        axBrowser.Enabled = True
        EditText("", "tempfilename", "yourCSS.css")
        txtSubject.Focus()
        xtcMailMain.SelectedTabPage = tabMessage
    End Sub
    Public Sub SaveMail()
        Try
            Dim sfdSaveAs As New SaveFileDialog
            sfdSaveAs.FileName = ""
            'sfdSaveAs.Filter = "Microsoft Mail Documents (*.eml)|*.eml|HTML File|*.html|HTM File|*.htm|Text file|*.txt"
            sfdSaveAs.Filter = "HTML File|*.html|HTM File|*.htm|Text file|*.txt"
            If (sfdSaveAs.ShowDialog = Windows.Forms.DialogResult.OK) Then
                Dim extension As String = Path.GetExtension(sfdSaveAs.FileName).ToLower
                If (extension = ".eml") Then
                    Dim mail As MailMessage
                    Dim html As String = ""
                    html = CType(axBrowser.Document, mshtml.IHTMLDocument3).getElementById("elm1").innerText
                    mail = BuildMessage(txtFrom.Text, cmbTo.Text, txtSubject.Text, html, "", lstAttachments, True, SMTPSenderName, "", "", False)
                    SaveToEML(mail, sfdSaveAs.FileName)
                ElseIf (extension = ".txt") Then
                    SaveHTMLText(sfdSaveAs.FileName, True)
                Else
                    SaveHTMLText(sfdSaveAs.FileName, False)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        axBrowser.Focus()
    End Sub
#End Region

#Region "Mailer"
    Private Function SendMessages(ByVal fromAddress As String, ByVal toAddress As String, ByVal subject As String, ByVal html As String, ByVal plainText As String, ByVal attachements As ArrayList, ByVal isHTML As Boolean, ByVal SenderName As String, ByVal ReturnPath As String, ByVal UnSubscribeEMail As String) As Boolean
        Dim retVal As Boolean = True
        Dim mail As New Chilkat.EMail
        Dim mailman As New Chilkat.MailMan() ' Any string passed to1E48F71C295
        Dim CompanyName As String = ""
        Dim RecName As String = ""
        Dim EMail As String = ""
        Dim i As Integer = 0
        mailman.UnlockComponent("RIICHIMAILQ_JSCKps2y9Uo9")
        Try

            mailman.SmtpPort = SMTPPort
            mailman.SmtpHost = SMTPServer
            If (SMTPAuth = "1") Then
                mailman.SmtpSsl = True
            Else
                mailman.SmtpSsl = False
            End If
            mailman.SmtpUsername = SMTPUserName
            mailman.SmtpPassword = SMTPPassword

            If toAddress = "MULTI" Then
                If Me.pbcStatus.InvokeRequired Then
                    Me.pbcStatus.Invoke(New StatItemDelegate(AddressOf StatItem), New Object() {"START", 0, 1})
                Else
                    Me.StatItem("START", 0, 1)
                End If
                For i = 0 To gvAddress.RowCount - 1
                    Dim NewHTML As String = ""
                    CompanyName = gvAddress.GetRowCellValue(i, "CompanyName")
                    RecName = gvAddress.GetRowCellValue(i, "Name")
                    EMail = gvAddress.GetRowCellValue(i, "EMail")
                    NewHTML = ReplacePlaceholders(CompanyName, RecName, EMail, html)
                    mail = BuildMessageChilkat(fromAddress, EMail, subject, NewHTML, plainText, attachements, isHTML, SenderName, ReturnPath, UnSubscribeEMail)
                    Dim success As Boolean = True
                    success = mailman.SendEMail(mail)
                    If success = False Then
                        MsgBox(mailman.LastErrorText)
                    End If
                    If Me.pbcStatus.InvokeRequired Then
                        Me.pbcStatus.Invoke(New StatItemDelegate(AddressOf StatItem), New Object() {"CCThread", i + 1, gvAddress.RowCount})
                    Else
                        Me.StatItem("CCThread", i + 1, gvAddress.RowCount)
                    End If
                Next
                If Me.pbcStatus.InvokeRequired Then
                    Me.pbcStatus.Invoke(New StatItemDelegate(AddressOf StatItem), New Object() {"FINISHED", 0, 1})
                Else
                    Me.StatItem("FINISHED", 0, 1)
                End If
            Else
                mail = BuildMessageChilkat(fromAddress, toAddress, subject, html, plainText, attachements, isHTML, SenderName, ReturnPath, UnSubscribeEMail)
                Dim success As Boolean = True
                success = mailman.SendEMail(mail)
                If success = False Then
                    MsgBox(mailman.LastErrorText)
                End If
            End If
         
            'messagesSent += 1
        Catch ex As Exception
            retVal = False
        Finally
            If Not mail Is Nothing Then
                mail.Dispose()
            End If
        End Try
        Return retVal
    End Function
    Private Function BuildMessage(ByVal fromAddress As String, ByVal toAddress As String, ByVal subject As String, ByVal html As String, ByVal plainText As String, ByVal attachements As ArrayList, ByVal isHTML As Boolean, ByVal SenderName As String, ByVal ReturnPath As String, ByVal UnSubscribeEMail As String, Optional ReplacePlaceholder As Boolean = True) As MailMessage
        If html Is Nothing Then
            html = ""
        End If
        Dim mail As New MailMessage
        If Not String.IsNullOrEmpty(toAddress) Then
            mail.To.Add(toAddress)
        End If
        mail.From = New MailAddress(fromAddress, SenderName)
        mail.Sender = New MailAddress(fromAddress, SenderName)
        'mail.ReplyTo = New MailAddress(fromAddress, SenderName)
        mail.ReplyToList.Add(New MailAddress(fromAddress, SenderName))

        'If server supports these header then we can get the bounce back here
        If (ReturnPath.Trim <> "") Then
            mail.Headers.Add("Return-Path", ReturnPath)
            mail.Headers.Add("Errors-To", ReturnPath)
        End If
        mail.Subject = subject
        'Add a plain text view
        mail.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(plainText, Nothing, "text/plain"))
        'Add the attachements
        If (Not attachements Is Nothing) Then
            If (attachements.Count > 0) Then
                For Each attachement As String In attachements
                    If (Not String.IsNullOrEmpty(attachement)) Then
                        Try
                            mail.Attachments.Add(New Attachment(attachement))
                        Catch ex As Exception

                        End Try
                    End If
                Next
            End If
        End If
        If (isHTML) Then
            If UnSubscribeEMail.Trim <> "" Then
                html = html.Replace("#UNSUBSCRIBEEMAIL#", UnSubscribeEMail.Trim)
            End If
            Dim avHTMLBody As AlternateView
            Dim linkedResources As New List(Of LinkedResource)
            'Embed the images
            Dim objRegEx As System.Text.RegularExpressions.Regex
            Dim objMatch As System.Text.RegularExpressions.Match
            Dim arrLinks As New System.Collections.ArrayList()
            objRegEx = New System.Text.RegularExpressions.Regex("<img.+?src=[\""'](.+?)[\""'].+?>", System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.Compiled)
            objMatch = objRegEx.Match(html)
            While objMatch.Success
                Dim strMatch As String
                strMatch = objMatch.Groups(1).ToString
                Try
                    Dim cid As String = ""
                    Dim fil As New FileInfo(strMatch)
                    cid = fil.Name
                    'link the resource to embed
                    Dim resource As New LinkedResource(strMatch)
                    'name the resource
                    resource.ContentId = cid
                    'add the resource to the alternate view
                    linkedResources.Add(resource)
                    html = html.Replace(strMatch, "cid:" + cid)
                Catch ex As Exception

                End Try
                objMatch = objMatch.NextMatch()
            End While
            avHTMLBody = AlternateView.CreateAlternateViewFromString(html, Nothing, "text/html")
            'Add the LinkedResource
            If (Not linkedResources Is Nothing) Then
                If (linkedResources.Count > 0) Then
                    For Each lnkResource As LinkedResource In linkedResources
                        avHTMLBody.LinkedResources.Add(lnkResource)
                    Next
                End If
            End If
            'add the view to the message
            mail.AlternateViews.Add(avHTMLBody)
            mail.IsBodyHtml = True
        Else
            mail.IsBodyHtml = False
            mail.Body = html
        End If
        Return mail
    End Function
    Private Function BuildMessageChilkat(ByVal fromAddress As String, ByVal toAddress As String, ByVal subject As String, ByVal html As String, ByVal plainText As String, ByVal attachements As ArrayList, ByVal isHTML As Boolean, ByVal SenderName As String, ByVal ReturnPath As String, ByVal UnSubscribeEMail As String, Optional ReplacePlaceholder As Boolean = True) As Chilkat.EMail
        If html Is Nothing Then
            html = ""
        End If
        Dim mail As New Chilkat.EMail
        If Not String.IsNullOrEmpty(toAddress) Then
            mail.AddTo(toAddress, toAddress)
        End If
        mail.Charset = "utf-8"
        mail.FromAddress = fromAddress
        mail.FromName = SenderName
        ' mail.ReplyTo = fromAddress
        'If server supports these header then we can get the bounce back here
        If (ReturnPath.Trim <> "") Then
            'mail.AddHeaderField("Return-Path", ReturnPath)
            'mail.AddHeaderField("Errors-To", ReturnPath)
        End If

        mail.Subject = subject
        'mail.AddPlainTextAlternativeBody
        'Add a plain text view
        'mail.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(plainText, Nothing, "text/plain"))

        'Add the attachements
        If (Not attachements Is Nothing) Then
            If (attachements.Count > 0) Then
                For Each attachement As String In attachements
                    If (Not String.IsNullOrEmpty(attachement)) Then
                        Try
                            mail.AddFileAttachment(attachement)
                            'mail.Attachments.Add(New Attachment(attachement))
                        Catch ex As Exception

                        End Try
                    End If
                Next
            End If
        End If
        If (isHTML) Then

            If UnSubscribeEMail.Trim <> "" Then
                html = html.Replace("#UNSUBSCRIBEEMAIL#", UnSubscribeEMail.Trim)
            End If

            ReplaceGoogleAnalyticsLink(html)
            html = html.Replace("file:///", "").Replace("%20", " ")
            Dim avHTMLBody As AlternateView
            Dim linkedResources As New List(Of LinkedResource)
            'Embed the images
            Dim objRegEx As System.Text.RegularExpressions.Regex
            Dim objMatch As System.Text.RegularExpressions.Match
            Dim arrLinks As New System.Collections.ArrayList()
            objRegEx = New System.Text.RegularExpressions.Regex("<img.+?src=[\""'](.+?)[\""'].+?>", System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.Compiled)
            objMatch = objRegEx.Match(html)
            While objMatch.Success
                Dim strMatch As String
                strMatch = objMatch.Groups(1).ToString
                Try
                    Dim cid As String = ""
                    Dim fil As New FileInfo(strMatch)
                    cid = fil.Name
                    'link the resource to embed
                    Dim resource As New LinkedResource(strMatch)
                    'name the resource
                    resource.ContentId = cid
                    'add the resource to the alternate view
                    linkedResources.Add(resource)
                    html = html.Replace(strMatch, "cid:" + cid)
                Catch ex As Exception

                End Try
                objMatch = objMatch.NextMatch()
            End While


            avHTMLBody = AlternateView.CreateAlternateViewFromString(html, Nothing, "text/html")

            'Add the LinkedResource
            If (Not linkedResources Is Nothing) Then
                If (linkedResources.Count > 0) Then
                    For Each lnkResource As LinkedResource In linkedResources
                        avHTMLBody.LinkedResources.Add(lnkResource)
                    Next
                End If
            End If
            mail.SetHtmlBody(html)
            mail.AddHtmlAlternativeBody(html)
            'add the view to the message
            'mail.AlternateViews.Add(avHTMLBody)
            'mail.HasHtmlBody
            'mail.IsBodyHtml = True
        Else
            'mail.IsBodyHtml = False
            mail.Body = html
            'Add a plain text view
            'mail.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(CommonFunctions.HTMLToText(html), Nothing, "text/plain"))

        End If

        Return mail
    End Function
    Private Sub ReplaceGoogleAnalyticsLink(ByRef body As String)
        Dim TinyMceUrl As String = Replace(TinyMCEPath, "//", "///")
        If Not String.IsNullOrEmpty(body) Then
            If body.IndexOf("utm_campaign=") <> -1 Then
                While body.IndexOf(TinyMceUrl) <> -1 And (body.IndexOf("utm_campaign=") - body.IndexOf(TinyMceUrl)) > 0
                    Dim tempGALink As String = body.Substring(body.IndexOf(TinyMceUrl), body.IndexOf("utm_campaign=") - body.IndexOf(TinyMceUrl))
                    Dim tempNewLink As String = tempGALink.Replace(TinyMceUrl, "").Replace("&amp;", "&").Replace("%20", " ")
                    body = body.Replace(tempGALink, tempNewLink)
                End While
            End If
        End If

    End Sub
    Private Function ReplacePlaceholders(ByVal CompanyName As String, ByVal RecName As String, ByVal EMail As String, ByVal body As String) As String
        body = body.Replace("#EMail#", EMail)
        If RecName <> "" Then
            body = body.Replace("#Name#", RecName)
        End If
        If CompanyName <> "" Then
            body = body.Replace("#Company#", CompanyName)
        End If
        body = body.Replace("#SenderName#", SMTPSenderName)
        body = body.Replace("#Date#", Date.Today)
        ReplacePlaceholders = body
    End Function
#End Region
#Region "Templates"
    Dim currentTempFilesLocation As String = appData & "\Temp\"
    Private Sub ExtractAttachementAndImages(ByRef HTMLBody As String, ByVal bodyParts As CDO.IBodyParts, ByVal readBodyOnly As Boolean, ByVal IsBodyHTML As Boolean)
        'save the attachement and embeded images
        If Not bodyParts Is Nothing Then
            If bodyParts.Count > 0 Then
                For Each att As CDO.IBodyPart In bodyParts
                    If Not att.BodyParts Is Nothing Then
                        If att.BodyParts.Count > 0 Then
                            ExtractAttachementAndImages(HTMLBody, att.BodyParts, readBodyOnly, IsBodyHTML)
                        End If
                    End If
                    If att.ContentMediaType.ToLower = "application/octet-stream" Then
                        If (att.FileName.Trim <> "") Then
                            'Get the attachement
                            If Not readBodyOnly Then
                                'just for safty replace the cid
                                If IsBodyHTML Then
                                    HTMLBody = HTMLBody.Replace("cid:" + att.FileName, currentTempFilesLocation + att.FileName)
                                End If
                            End If
                        Else
                            'Get the embeded images
                            If IsBodyHTML Then
                                If att.Fields(1).Name = "urn:schemas:mailheader:content-id" Then
                                    If Not String.IsNullOrEmpty(att.Fields(1).Value) Then
                                        Dim imgFilName As String = att.Fields(1).Value.ToString.Replace("<", "").Replace(">", "")
                                        att.SaveToFile(currentTempFilesLocation + imgFilName)
                                        HTMLBody = HTMLBody.Replace("cid:" + imgFilName, currentTempFilesLocation + imgFilName)
                                    End If
                                End If
                            End If
                        End If
                    ElseIf att.ContentMediaType.ToLower.IndexOf("image/") <> -1 Then
                        'Get the embeded images
                        If IsBodyHTML Then
                            If Not String.IsNullOrEmpty(att.FileName) Then
                                If Not att.Fields Is Nothing Then
                                    If att.Fields.Count > 0 Then
                                        For Each fld As ADODB.Field In att.Fields
                                            If Not fld Is Nothing Then
                                                If Not String.IsNullOrEmpty(fld.Name) And Not String.IsNullOrEmpty(fld.Value) Then
                                                    If fld.Name = "urn:schemas:mailheader:content-id" Then
                                                        Dim imgFilName As String = fld.Value.ToString.Replace("<", "").Replace(">", "")
                                                        att.SaveToFile(currentTempFilesLocation + att.FileName)
                                                        HTMLBody = HTMLBody.Replace("cid:" + imgFilName, currentTempFilesLocation + att.FileName)
                                                        Exit For
                                                    End If
                                                End If
                                            End If
                                        Next
                                    End If
                                End If
                            End If
                        End If
                    End If
                    Try
                        att.DataSource.ActiveConnection.Close()
                    Catch ex As Exception
                    End Try
                    att = Nothing
                Next
            End If
        End If
    End Sub
    Private Sub SaveToEML(ByVal Message As MailMessage, ByVal FileName As String)
        Try
            Dim assembly As Assembly = GetType(System.Net.Mail.SmtpClient).Assembly
            Dim _mailWriterType As Type = assembly.GetType("System.Net.Mail.MailWriter")
            Dim _fileStream As FileStream = New FileStream(FileName, FileMode.Create)
            ' Get reflection info for MailWriter contructor             
            Dim _mailWriterContructor As ConstructorInfo = _mailWriterType.GetConstructor(BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, New Type() {GetType(Stream)}, Nothing)
            'Construct MailWriter object with our FileStream      
            Dim _mailWriter As Object = _mailWriterContructor.Invoke(New Object() {_fileStream})
            'Get reflection info for Send() method on MailMessage         
            Dim _sendMethod As MethodInfo = GetType(MailMessage).GetMethod("Send", BindingFlags.Instance Or BindingFlags.NonPublic)
            'Call method passing in MailWriter          
            _sendMethod.Invoke(Message, BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, New Object() {_mailWriter, True}, Nothing)
            'Finally get reflection info for Close() method on our MailWriter       
            Dim _closeMethod As MethodInfo = _mailWriter.GetType().GetMethod("Close", BindingFlags.Instance Or BindingFlags.NonPublic)
            'Call close method           
            _closeMethod.Invoke(_mailWriter, BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, New Object() {}, Nothing)
            _fileStream.Close()
            _fileStream.Dispose()

            _mailWriter = Nothing
            Message.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ReadEML(ByVal emlFileName As String, ByVal readBodyOnly As Boolean)
        Try
            'Clear all the objects
            If (Not readBodyOnly) Then
                cmbTo.Text = ""
                txtSubject.Text = ""
            End If
            'Microsoft CDO for Windows 2000 Library
            Dim Message As New MailMessage
            Dim msg As CDO.Message = New CDO.Message()
            Dim stream As ADODB.Stream = New ADODB.Stream()

            stream.Open(Type.Missing, ADODB.ConnectModeEnum.adModeUnknown, ADODB.StreamOpenOptionsEnum.adOpenStreamUnspecified, String.Empty, String.Empty)
            stream.LoadFromFile(emlFileName)
            stream.Flush()
            msg.DataSource.OpenObject(stream, "_Stream")
            msg.DataSource.Save()

            'Set the details on form
            Dim str As String = ""
            str = msg.HTMLBody
            Dim IsBodyHTML As Boolean = True
            If str.Trim = "" And msg.TextBody.Trim <> "" Then
                str = msg.TextBody
                IsBodyHTML = False
            End If

            If (Not readBodyOnly) Then
                txtSubject.Text = msg.Subject
            End If
            If Directory.Exists(currentTempFilesLocation) = False Then
                Directory.CreateDirectory(currentTempFilesLocation)
            End If

            ExtractAttachementAndImages(str, msg.BodyPart.BodyParts, readBodyOnly, IsBodyHTML)
            axBrowser.Enabled = True
            EditText(str, "tempfilename", "yourCSS.css")
            axBrowser.Focus()
            Try
                msg.DataSource.ActiveConnection.Close()
            Catch ex As Exception

            End Try

            msg = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function HTMLToText(ByVal HTMLCode As String) As String
        If HTMLCode Is Nothing Then
            Return ""
        End If
        ' Remove new lines since they are not visible in HTML
        HTMLCode = HTMLCode.Replace("\n", vbCrLf)
        HTMLCode = HTMLCode.Replace("\N", vbCrLf)

        '' Remove tab spaces
        HTMLCode = HTMLCode.Replace("\t", " ")

        ' Remove multiple white spaces from HTML
        HTMLCode = Regex.Replace(HTMLCode, "\\s+", " ")

        ' Remove HEAD tag
        HTMLCode = Regex.Replace(HTMLCode, "<head.*?</head>", "", RegexOptions.IgnoreCase Or RegexOptions.Singleline)

        ' Remove any JavaScript
        HTMLCode = Regex.Replace(HTMLCode, "<script.*?</script>", "", RegexOptions.IgnoreCase Or RegexOptions.Singleline)

        ' Replace special characters like &, <, >, " etc.
        Dim sbHTML As StringBuilder = New StringBuilder(HTMLCode)
        ' Note: There are many more special characters, these are just
        ' most common. You can add new characters in this arrays if needed
        Dim OldWords() As String = {"&nbsp", "&amp", "&quot", "&lt", "&gt", "&reg", "&copy", "&bull", "&trade"}
        Dim NewWords() As String = {" ", "&", """", "<", ">", "Â®", "Â©", "â€¢", "â„¢"}

        Dim i As Int16 = 0
        While (i < OldWords.Length)
            sbHTML.Replace(OldWords(i), NewWords(i))
            i += 1
        End While

        OldWords = New String() {"&NBSP", "&AMP", "&QUOT", "&LT", "&GT", "&REG", "&COPY", "&BULL", "&TRADE"}
        i = 0
        While (i < OldWords.Length)
            sbHTML.Replace(OldWords(i), NewWords(i))
            i += 1
        End While

        ' Check if there are line breaks (<br>) or paragraph (<p>)
        sbHTML.Replace("<br>", Environment.NewLine + "<br>")
        sbHTML.Replace("<br ", Environment.NewLine + "<br ")
        sbHTML.Replace("<p ", Environment.NewLine + "<p ")

        sbHTML.Replace("<BR>", Environment.NewLine + "<BR>")
        sbHTML.Replace("<BR ", Environment.NewLine + "<BR ")
        sbHTML.Replace("<P ", Environment.NewLine + "<P ")

        ' Finally, remove all HTML tags and return plain text
        Return System.Text.RegularExpressions.Regex.Replace(sbHTML.ToString(), "<[^>]*>", "")
    End Function
    Private Sub ReadHTMLText(ByVal fileName As String, ByVal readTextOnly As Boolean)
        Try
            Dim str As String = File.ReadAllText(fileName)
            If (readTextOnly) Then
                str = HTMLToText(str)
            End If
            axBrowser.Enabled = True
            str = str.Replace(Environment.NewLine, "<br>")
            EditText(str, "tempfilename", "yourCSS.css")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveHTMLText(ByVal fileName As String, ByVal saveTextOnly As Boolean)
        Try
            Dim str As String = ""
            str = CType(axBrowser.Document, mshtml.IHTMLDocument3).getElementById("elm1").innerText
            If (saveTextOnly) Then
                str = HTMLToText(str)
            End If
            File.WriteAllText(fileName, str)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnOpenEML_Click(sender As Object, e As EventArgs) Handles btnOpenEML.Click
        Dim TemplatePath As String = AppDataPath & "Templates\"
        Try
            Dim sfdOpenFile As New OpenFileDialog
            sfdOpenFile.FileName = ""
            sfdOpenFile.Filter = "Microsoft Mail Documents (*.eml)|*.eml"
            sfdOpenFile.InitialDirectory = TemplatePath
            sfdOpenFile.FilterIndex = 1
            If sfdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                ReadEML(sfdOpenFile.FileName, True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        axBrowser.Focus()

    End Sub
    Private Sub btnHTML_Click(sender As Object, e As EventArgs) Handles btnHTML.Click
        Try
            Dim sfdOpenFile As New OpenFileDialog
            sfdOpenFile.Filter = "HTML File|*.html|HTM File|*.htm"
            sfdOpenFile.FilterIndex = 1
            If sfdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                ReadHTMLText(sfdOpenFile.FileName, False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        axBrowser.Focus()
    End Sub
    Private Sub btnSaveTemplate_Click(sender As Object, e As EventArgs) Handles btnSaveTemplate.Click
        SaveMail()
    End Sub
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        SendMessage()
    End Sub
    Private Sub btnAddressOK_Click(sender As Object, e As EventArgs) Handles btnAddressOK.Click
        xtcMailMain.SelectedTabPage = tabMessage
    End Sub

    Private Sub cmbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTo.SelectedIndexChanged
        Dim SelList As String = ""
        SelList = cmbTo.SelectedText
        If InStr(1, UCase(SelList), ".CSV", CompareMethod.Text) > 0 Then
            LoadAddressData()
            xtcMailMain.SelectedTabPage = tabList

        End If

    End Sub
#End Region


End Class