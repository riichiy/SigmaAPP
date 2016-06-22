Imports System.IO
Imports DevExpress.XtraEditors.Controls
Imports Microsoft.Office.Interop

Public Class frmMail
    Public FilePath As String
    Private Sub frmMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFileList()
    End Sub
    Private Sub LoadFileList()
        clbFileList.Items.Clear()
        Dim di As New IO.DirectoryInfo(FilePath)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Array.Sort(diar1, New clsCompareFileInfo)
        Dim dra As IO.FileInfo

        Dim CFileName As String = ""
        'list the names of all files in the specified directory
        For Each dra In diar1
            If Path.GetFileName(dra.Name) <> "desktop.ini" Then
                If InStr(1, FilePath, "PostFiles", CompareMethod.Text) > 0 Then
                    If UCase(Path.GetExtension(dra.Name)) = ".PAS" Or UCase(Path.GetExtension(dra.Name)) = ".PST" Or UCase(Path.GetExtension(dra.Name)) = ".TEC" Or UCase(Path.GetExtension(dra.Name)) = ".TEC" Then
                        If dra.LastWriteTime > Date.Now.AddDays(-0.1) Then
                            clbFileList.Items.Add(dra.FullName, dra.Name, CheckState.Checked, True)
                        Else
                            clbFileList.Items.Add(dra.FullName, dra.Name, CheckState.Unchecked, True)
                        End If
                    End If
                Else
                    If dra.LastWriteTime > Date.Now.AddDays(-0.1) Then
                        clbFileList.Items.Add(dra.FullName, dra.Name, CheckState.Checked, True)
                    Else
                        clbFileList.Items.Add(dra.FullName, dra.Name, CheckState.Unchecked, True)
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub CreateZipFile()
        Dim zip As New Chilkat.Zip()
        Dim success As Boolean
        Dim i As Integer = 0
        Dim CheckedItem As String = ""

        success = zip.UnlockComponent("RIICHIZIP_r86X7vbw1Stl")
        If (success <> True) Then
            Console.WriteLine(zip.LastErrorText)
            Exit Sub
        End If
        success = zip.NewZip(FilePath & "\file.zip")
        If (success <> True) Then
            Console.WriteLine(zip.LastErrorText)
            Exit Sub
        End If

        Dim saveExtraPath As Boolean = False
        For Each li As CheckedListBoxItem In clbFileList.Items
            CheckedItem = li.Value

            If li.CheckState = 1 Then
                zip.AppendFiles(CheckedItem, False)
            End If
        Next
        success = zip.WriteZipAndClose()
        If chkCreateMail.Checked = True Then
            CreateOutlookEMail(FilePath & "\file.zip")
        End If

    End Sub
    Private Sub CreateOutlookEMail(ByVal FilePath As String)
        Dim oEMail As Outlook.MailItem
        Dim moApp As Outlook.Application = New Outlook.Application()
        Me.Cursor = Cursors.WaitCursor
        oEMail = DirectCast(moApp.CreateItem(Outlook.OlItemType.olMailItem), Outlook.MailItem)
        With oEMail
            .To = ""
            .Subject = "ファイル送信"
            .BodyFormat = Outlook.OlBodyFormat.olFormatHTML
            .Body = ""
            '.Importance = Outlook.OlImportance.olImportanceHigh
            '.ReadReceiptRequested = True
            .Attachments.Add(FilePath, Outlook.OlAttachmentType.olByValue)
            .Recipients.ResolveAll()
            .Save()
            .Display() 'Show the email message and allow for editing before sending
            '.Send() 'You can automatically send the email without displaying it.
        End With
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CreateZipFile()
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()

    End Sub

    Private Sub chkClear_CheckedChanged(sender As Object, e As EventArgs) Handles chkClear.CheckedChanged
        If chkClear.Checked = False Then
            For Each li As CheckedListBoxItem In clbFileList.Items
                li.CheckState = CheckState.Unchecked
            Next
        Else
            For Each li As CheckedListBoxItem In clbFileList.Items
                li.CheckState = CheckState.Checked
            Next
        End If
    End Sub
End Class
Public Class clsCompareFileInfo
    Implements IComparer
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim File1 As FileInfo
        Dim File2 As FileInfo

        File1 = DirectCast(x, FileInfo)
        File2 = DirectCast(y, FileInfo)

        Compare = DateTime.Compare(File2.LastWriteTime, File1.LastWriteTime)
    End Function
End Class