Public Class frmReplace
    Public ReplaceText As String = ""
    Public FindText As String = ""
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        FindText = ""
        ReplaceText = ""
        Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FindText = txtFind.Text
        ReplaceText = txtReplace.Text
        Close()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub
End Class