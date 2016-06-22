Imports System.IO
Imports DevExpress.XtraEditors.Controls
Imports Microsoft.Office.Interop

Public Class frmEdit
    Public FilePath As String
    Public DoSave As Boolean = False
    Public ROnly As Boolean = False
    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DoSave = False
        Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ROnly = True Then
            DoSave = False
        Else
            DoSave = True
        End If
        Close()
    End Sub
End Class
