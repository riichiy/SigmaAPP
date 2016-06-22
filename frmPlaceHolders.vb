
Public Class frmPlaceHolders
    Private data As DataTable
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
    Private Sub LoadPlaceHolderColumns()
        Dim i As Integer = 0
        data = New DataTable("gvPlaceHolder")
        data.Clear()
        data.BeginInit()
        AddColumn(data, "Field", System.Type.GetType("System.String"))
        AddColumn(data, "PlaceHolder", System.Type.GetType("System.String"))
        data.EndInit()

        gcPlaceHolder.DataSource = data
        gcPlaceHolder.DefaultView.PopulateColumns()
        gvPlaceHolder.Columns(0).Width = 200
        gvPlaceHolder.Columns(1).Width = 200

        gvPlaceHolder.Columns.ColumnByFieldName("Field").Caption = "フィールド"
        gvPlaceHolder.Columns.ColumnByFieldName("PlaceHolder").Caption = "プレースホルダー"
        gvPlaceHolder.BestFitColumns()

    End Sub
    Private Sub LoadPlaceHolderData()
        data.Rows.Add("Eメール", "#EMail#")
        data.Rows.Add("名前", "#Name#")
        data.Rows.Add("会社名", "#Company#")
        'data.Rows.Add("住所", "#Address#")
        'data.Rows.Add("郵便番号", "#Zip#")
        'data.Rows.Add("町", "#City#")
        'data.Rows.Add("市", "#State#")
        'data.Rows.Add("国", "#Country#")
        'data.Rows.Add("電話番号", "#Telephone#")
        'data.Rows.Add("ＦＡＸ番号", "#Fax#")
        'data.Rows.Add("ＵＲＬ", "#Website#")
        'data.Rows.Add("部署", "#Business#")
        'data.Rows.Add("役職", "#Title#")
        data.Rows.Add("送り元名", "#SenderName#")
        'data.Rows.Add("送り元会社名", "#SenderCompany#")
        'data.Rows.Add("送り元Eメール", "#SenderEMail#")
        'data.Rows.Add("送り元FAX番号", "#SenderFax#")
        data.Rows.Add("日付", "#Date#")
    End Sub
    Private Sub frmPlaceHolders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadPlaceHolderColumns()
        LoadPlaceHolderData()
        
    End Sub
    Private Sub btnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        Me.Close()
    End Sub


End Class
