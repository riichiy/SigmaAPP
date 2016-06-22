Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Environment
Imports System.Text
Public Class frmTranslation


#Region "GblVar"
    Dim data As DataTable
    Dim data2 As DataTable
    Dim CopyText As String
    Dim GblTranslationFile As String = ""
#End Region
#Region "Formload"
    Private Sub frmTranslation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splweb.Panel2Collapsed = True
        appData = GetFolderPath(SpecialFolder.CommonDocuments)
        LoadTListColumns()
        LoadTranslationColumns()
        'ReadFileForTranslation()
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
#Region "TList"
    Private Sub gvTList_FocusedRowChanged(sender As Object, e As EventArgs) Handles gvTList.FocusedRowChanged
        If gvTList.SelectedRowsCount > 0 Then
            Dim FileName As String = gvTList.GetRowCellValue(gvTList.GetSelectedRows(0), "FileName").ToString
            Dim FullPath As String = gvTList.GetRowCellValue(gvTList.GetSelectedRows(0), "FullPath").ToString
            GblTranslationFile = FullPath
            ProcessTranslationFile(FullPath)
        End If
    End Sub
    Private Sub LoadTListColumns()
        Dim i As Integer = 0
        data2 = New DataTable("gvTList")
        data2.Clear()
        data2.BeginInit()
        AddColumn(data2, "FileName", System.Type.GetType("System.String"))
        AddColumn(data2, "Count", System.Type.GetType("System.Int32"))
        AddColumn(data2, "FullPath", System.Type.GetType("System.String"))
        data2.EndInit()

        gcTList.DataSource = data2
        gcTList.DefaultView.PopulateColumns()
        gvTList.Columns(0).Width = 150
        gvTList.Columns(1).Width = 30
        gvTList.Columns(2).Visible = False
        gvTList.Columns.ColumnByFieldName("FileName").Caption = "ファイル名"
        gvTList.Columns.ColumnByFieldName("Count").Caption = "数"
        gvTList.Columns(0).OptionsColumn.AllowEdit = False
    End Sub
    Private Function GetTRowCnt(ByVal FilePath As String) As Integer
        Dim sr As New System.IO.StreamReader(FilePath, System.Text.Encoding.GetEncoding(GblEncoding))
        Dim LineCnt As Integer = 0
        While sr.Peek() > -1
            LineCnt += 1
            sr.ReadLine()
        End While
        sr.Close()
        GetTRowCnt = LineCnt
    End Function
    Private Sub ExtractZipFile(ByVal FilePath As String)
        Try
            data2.Clear()
            Dim zip As New Chilkat.Zip()
            Dim success As Boolean
            Dim Dircnt As Integer = 0
            Dim FileName As String = ""
            success = zip.UnlockComponent("RIICHIZIP_r86X7vbw1Stl")
            If (success <> True) Then
                Console.WriteLine(zip.LastErrorText)
                Exit Sub
            End If
            success = zip.OpenZip(FilePath)
            Dim ZipPath As String = appData & "\Translations\"
            If Directory.Exists(ZipPath) = False Then
                Directory.CreateDirectory(ZipPath)
            End If
            zip.Unzip(ZipPath)
            For Each Dir As String In Directory.GetDirectories(ZipPath)
                Dim dra As New System.IO.DirectoryInfo(Dir)
                Dim diar1 As System.IO.FileInfo() = dra.GetFiles()

                For Each files In diar1
                    FileName = files.FullName
                    data2.Rows.Add(Path.GetFileNameWithoutExtension(FileName), GetTRowCnt(FileName), ZipPath & Path.GetFileName(FileName))
                    File.Copy(FileName, ZipPath & Path.GetFileName(FileName), True)
                    File.Delete(FileName)
                Next
                Directory.Delete(Dir, True)
                Dircnt += 1
            Next
            If Dircnt = 0 Then
                Dim dra As New System.IO.DirectoryInfo(ZipPath)
                Dim diar1 As System.IO.FileInfo() = dra.GetFiles()
                For Each files In diar1
                    FileName = files.FullName
                    data2.Rows.Add(Path.GetFileNameWithoutExtension(FileName), GetTRowCnt(FileName), ZipPath & Path.GetFileName(FileName))
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CreateZipFile()
        Dim zip As New Chilkat.Zip()
        Dim success As Boolean
        Dim i As Integer = 0

        success = zip.UnlockComponent("RIICHIZIP_r86X7vbw1Stl")
        If (success <> True) Then
            Console.WriteLine(zip.LastErrorText)
            Exit Sub
        End If
        Dim NewZip As String = appData & "\" & "Japanese.zip"
        success = zip.NewZip(NewZip)
        If gvTList.RowCount > 0 Then
            For i = 0 To gvTList.RowCount - 1
                Dim FileName As String = gvTList.GetRowCellValue(i, "FileName").ToString
                Dim FullPath As String = gvTList.GetRowCellValue(i, "FullPath").ToString
                zip.AppendFiles(FullPath, False)
            Next
        End If
        success = zip.WriteZipAndClose()
        CreateTranslationMail(NewZip)
    End Sub
    Private Sub CreateTranslationMail(ByVal ZipFile As String)
        Dim oEMail As Microsoft.Office.Interop.Outlook.MailItem

        Dim i As Integer = 0
        Dim moApp As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application()
        Me.Cursor = Cursors.WaitCursor
        oEMail = DirectCast(moApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem), Microsoft.Office.Interop.Outlook.MailItem)
        With oEMail
            .To = ""
            .Subject = ""
            .BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML
            .Body = ""
            '.Importance = Outlook.OlImportance.olImportanceHigh
            '.ReadReceiptRequested = True
            '.Attachments.Add(FilePath, Outlook.OlAttachmentType.olByValue)
            .Attachments.Add(ZipFile, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue)
            .Recipients.ResolveAll()
            .Save()
            .Display() 'Show the email message and allow for editing before sending
            '.Send() 'You can automatically send the email without displaying it.
        End With
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub ProcessFiles(ByVal FilePath As String)
        Dim FExt As String = ""
        FExt = UCase(Path.GetExtension(FilePath))
        Select Case FExt
            Case ".ZIP"
                ExtractZipFile(FilePath)
        End Select
    End Sub
    Private Sub gcTList_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gcTList.DragDrop
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
    Private Sub gcTList_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles gcTList.DragEnter
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
#End Region
#Region "ExText"
    Private Sub LoadTranslationColumns()
        Dim i As Integer = 0
        data = New DataTable("gvTranslation")
        data.Clear()
        data.BeginInit()
        AddColumn(data, "ControlValue", System.Type.GetType("System.String"))
        AddColumn(data, "ExtractedText", System.Type.GetType("System.String"))
        AddColumn(data, "GoogleText", System.Type.GetType("System.String"))
        AddColumn(data, "MyText", System.Type.GetType("System.String"))
        data.EndInit()

        gcTranslation.DataSource = data
        gcTranslation.DefaultView.PopulateColumns()
        gvTranslation.Columns(0).Width = 75
        gvTranslation.Columns(1).Width = 150
        gvTranslation.Columns(2).Width = 150
        gvTranslation.Columns(3).Width = 150
        gvTranslation.Columns.ColumnByFieldName("ControlValue").Caption = "変数"
        gvTranslation.Columns.ColumnByFieldName("ExtractedText").Caption = "テキスト"
        gvTranslation.Columns.ColumnByFieldName("GoogleText").Caption = "Google翻訳"
        gvTranslation.Columns.ColumnByFieldName("MyText").Caption = "翻訳確認"
        gvTranslation.Columns(0).OptionsColumn.AllowEdit = False
        gvTranslation.Columns(1).OptionsColumn.AllowEdit = False
        gvTranslation.Columns(2).OptionsColumn.AllowEdit = False
        gvTranslation.Columns(3).OptionsColumn.AllowEdit = True
    End Sub
    Private Sub ProcessTranslationFile(ByVal FileName As String)
        Dim LineItem As String = ""
        Dim ControlText As String = ""
        Dim ExText As String = ""
        data.Clear()
        CopyText = ""
        Dim sr As New System.IO.StreamReader(FileName, System.Text.Encoding.GetEncoding(GblEncoding))
        While sr.Peek() > -1
            LineItem = sr.ReadLine().Trim
            If InStr(1, LineItem, ";##### ", CompareMethod.Text) > 0 Then
                sr.ReadLine()
            ElseIf InStr(1, UCase(LineItem), "=", CompareMethod.Text) > 0 Then
                Dim TmpArr() As String
                TmpArr = Split(LineItem, "=")
                ControlText = TmpArr(0).Trim
                ExText = TmpArr(1).Trim
                data.Rows.Add(ControlText, ExText, "", "")
                CopyText = CopyText & ExText & vbCrLf
            End If
        End While
        sr.Close()
    End Sub
    Private Function OmitRules(ByVal LineItem As String) As Boolean
        Dim DoOmit As Boolean = False
        If InStr(1, LineItem, "If", CompareMethod.Text) > 0 Then
            DoOmit = True
        End If
        If Microsoft.VisualBasic.Left(LineItem, 1) = "'" Then
            DoOmit = True
        End If
        If Microsoft.VisualBasic.Left(LineItem, 3) = "Me." Then
            DoOmit = True
        End If
        If InStr(1, LineItem, "= """"", CompareMethod.Text) > 0 Then
            DoOmit = True
        End If
        If Microsoft.VisualBasic.Left(UCase(LineItem), 3) = "TXT" Then
            DoOmit = True
        End If
        If Microsoft.VisualBasic.Left(UCase(LineItem), 3) = "CMB" Then
            DoOmit = True
        End If
        OmitRules = DoOmit
    End Function
    Private Sub ReadFileForTranslation()
        ' Dim TFile As String = "D:\GDrive\VSProjects\Visual Studio 2010\Projects\SigmaAPP\SigmaAPP\SigmaAPP.Designer.vb"
        Dim TFile As String = "D:\GDrive\VSProjects\Visual Studio 2010\Projects\SigmaAPP\SigmaAPP\SigmaAPP.vb"
        Dim LineItem As String = ""
        Dim ControlText As String = ""
        Dim ExText As String = ""
        data.Clear()
        CopyText = ""
        Dim sr As New System.IO.StreamReader(TFile, System.Text.Encoding.GetEncoding(GblEncoding))
        While sr.Peek() > -1
            LineItem = sr.ReadLine()

            If InStr(1, UCase(LineItem), ".TEXT = """, CompareMethod.Text) Or InStr(1, UCase(LineItem), ".CAPTION = """, CompareMethod.Text) Then
                ControlText = LineItem.Trim
                Dim TmpArr() As String
                TmpArr = Split(ControlText, "=")
                ExText = TmpArr(1).Trim
                ExText = ExText.Trim
                ExText = Replace(ExText, """", "")
                ExText = ExText.Trim
                If OmitRules(ControlText) = False Then
                    data.Rows.Add(ControlText, ExText, "", "")
                    CopyText = CopyText & ExText & vbCrLf
                End If
            ElseIf InStr(1, UCase(LineItem), "MSGBOX(", CompareMethod.Text) > 0 And InStr(1, UCase(LineItem), "EX.MESSAGE", CompareMethod.Text) <= 0 Then
                ControlText = LineItem.Trim
                ExText = Replace(ControlText, "MsgBox(""", "")
                ExText = Replace(ExText, """)", "")
                data.Rows.Add(ControlText, ExText, "", "")
                CopyText = CopyText & ExText & vbCrLf
            End If

        End While
        sr.Close()
    End Sub
    Private Sub ParseGText(ByVal GText As String)
        Dim GLines() As String = GText.Split(System.Environment.NewLine)
        Dim GLine As String = ""
        Dim i As Integer = 0
        Try
            For i = 0 To GLines.Count - 1
                GLine = GLines(i).Trim.ToString
                gvTranslation.SetRowCellValue(i, "GoogleText", GLine)
                gvTranslation.SetRowCellValue(i, "MyText", GLine)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ReturnToEnglish()
        Dim ExtractedText As String = ""
        If gvTranslation.SelectedRowsCount > 0 Then
            For i = 0 To gvTranslation.SelectedRowsCount - 1
                ExtractedText = gvTranslation.GetRowCellValue(gvTranslation.GetSelectedRows(i), "ExtractedText").ToString
                gvTranslation.SetRowCellValue(gvTranslation.GetSelectedRows(i), "MyText", ExtractedText)
            Next
        End If
    End Sub
    Private Sub gcTranslation_DoubleClick(sender As Object, e As EventArgs) Handles gcTranslation.DoubleClick
        ReturnToEnglish()
    End Sub
    Private Sub ttsReturnEnglish_Click(sender As Object, e As EventArgs) Handles ttsReturnEnglish.Click
        ReturnToEnglish()
    End Sub
    Private Sub gcTranslation_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gcTranslation.DragDrop
        Try
            Dim DText As String = e.Data.GetData(DataFormats.StringFormat)
            ParseGText(DText)
            splweb.Panel2Collapsed = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub gcTranslation_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gcTranslation.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub CreateSourceExport()
        Dim i As Integer = 0
        Dim ControlValue As String = ""
        Dim ExtractedText As String = ""
        Dim GoogleText As String = ""
        Dim MyText As String = ""
        Dim NewControlValue As String = ""
        Dim ExportStr As String = ""
        If gvTranslation.RowCount > 0 Then
            For i = 0 To gvTranslation.RowCount - 1
                ControlValue = gvTranslation.GetRowCellValue(i, "ControlValue").ToString
                ExtractedText = gvTranslation.GetRowCellValue(i, "ExtractedText").ToString
                MyText = gvTranslation.GetRowCellValue(i, "MyText").ToString
                NewControlValue = Replace(ControlValue, """" & ExtractedText & """", """" & MyText & """")
                ExportStr = ExportStr & NewControlValue & vbCrLf
            Next
            Clipboard.SetText(ExportStr)
        End If

    End Sub
    Private Sub ttsReplace_Click(sender As Object, e As EventArgs) Handles ttsReplace.Click
        Dim frmReplace As New frmReplace
        Dim MyText As String = ""
        If gvTranslation.SelectedRowsCount > 0 Then
            For i = 0 To gvTranslation.SelectedRowsCount - 1
                MyText = gvTranslation.GetRowCellValue(gvTranslation.GetSelectedRows(i), "MyText").ToString
            Next
        End If
        frmReplace.txtFind.Text = MyText
        frmReplace.ShowDialog()
        Dim ReplaceText As String = ""
        Dim FindText As String = ""
        FindText = frmReplace.FindText
        ReplaceText = frmReplace.ReplaceText
        If ReplaceText <> "" Then
            Dim i As Integer = 0
            For i = 0 To gvTranslation.RowCount - 1
                MyText = gvTranslation.GetRowCellValue(i, "MyText").ToString
                If InStr(1, MyText, FindText, CompareMethod.Text) > 0 Then
                    MyText = Replace(MyText, FindText, ReplaceText)
                    gvTranslation.SetRowCellValue(i, "MyText", MyText)
                End If
            Next
        End If
    End Sub
    Public Sub SaveTranslations()
        Dim i As Integer = 0
        Dim ControlValue As String = ""
        Dim MyText As String = ""
        Dim SettingValue As String = ""
        Dim Section As String = ""
        Dim Key As String = ""

        Try
            gcTranslation.FocusedView.CloseEditor()
            Dim sw As New System.IO.StreamWriter(GblTranslationFile, False, System.Text.Encoding.GetEncoding(GblEncoding))
            For i = 0 To gvTranslation.RowCount - 1
                ControlValue = gvTranslation.GetRowCellValue(i, "ControlValue").ToString
                MyText = gvTranslation.GetRowCellValue(i, "MyText").ToString
                sw.WriteLine(ControlValue & "=" & MyText)
            Next
            sw.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("登録しました。")
        End Try
    End Sub
    Private Sub ttsEMailTranslation_Click(sender As Object, e As EventArgs) Handles ttsEMailTranslation.Click
        CreateZipFile()
    End Sub
#End Region
#Region "Navigation"
    Private Sub ttxCopyText_Click(sender As Object, e As EventArgs) Handles ttxCopyText.Click
        splweb.Panel2Collapsed = False
        Dim WebUrl As String
        WebUrl = "https://translate.google.com/#en/ja/"
        Dim address As New Uri(WebUrl)
        webT.Url = address
        If CopyText <> "" Then
            Clipboard.SetText(CopyText)
        End If

    End Sub
    Private Sub gvTranslation_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvTranslation.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 50 Then
            ttxCopyText.Visible = True
            Me.cmsTMenu.Show(gcTranslation, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub ttsReadGText_Click(sender As Object, e As EventArgs) Handles ttsReadGText.Click
        Dim DText As String = Clipboard.GetText
        ParseGText(DText)
    End Sub
    Private Sub ttsSave_Click(sender As Object, e As EventArgs) Handles ttsSave.Click
        SaveTranslations()
    End Sub
#End Region




   
   

End Class