Public Class frmNew
    Public CustomerName As String = ""
    Private Sub frmNewCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCustName.Focus()
        txtCustName.Select()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CustomerName = ""
        Close()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        CustomerName = txtCustName.Text
        Close()
    End Sub


End Class