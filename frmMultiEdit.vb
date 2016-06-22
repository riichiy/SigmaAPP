Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports System.Data.OleDb
Public Class frmMultiEdit
    Public GUIDList As New ArrayList
    Public CompanyList As New ArrayList
    Dim GUIDArr() As String
    Public ChangeMade As Boolean = False
    Public NativeCompany As String = ""
    Public CompanyLink As String = ""
    Public SNInfoLink As String = ""
    Private Sub frmMultiEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadMultiEditColumns()
        LoadMultiEditData()
        LoadTypeComboBox()
    End Sub
#Region "DXGrid"
    Private data As DataTable

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
#Region "Data"
    Private Sub LoadMultiEditColumns()
        Dim i As Integer = 0
        data = New DataTable("gvMultiEdit")
        data.Clear()
        data.BeginInit()
        AddColumn(data, "Field", System.Type.GetType("System.String"))
        AddColumn(data, "Value", System.Type.GetType("System.String"))

        data.EndInit()

        gcMultiEdit.DataSource = data
        gcMultiEdit.DefaultView.PopulateColumns()
        gvMultiEdit.Columns(0).Width = 200
        gvMultiEdit.Columns(1).Width = 200
        gvMultiEdit.Columns.ColumnByFieldName("Field").Caption = "フィールド"
        gvMultiEdit.Columns.ColumnByFieldName("Value").Caption = "編集後"
        gvMultiEdit.Columns(0).OptionsColumn.AllowEdit = False
        gvMultiEdit.Columns(1).OptionsColumn.AllowEdit = True

        'gvMultiEdit.Columns(7).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        'gvMultiEdit.Columns(7).AppearanceCell.Options.UseTextOptions = True
    End Sub
    Private Sub LoadMultiEditData()

        data.Clear()
        data.Rows.Add("タイプ", "")
        data.Rows.Add("会社名", "")
        data.Rows.Add("会社名英語", NativeCompany)
        data.Rows.Add("部署", "")
        data.Rows.Add("役職", "")
        data.Rows.Add("電話番号", "")
        data.Rows.Add("FAX番号", "")
        data.Rows.Add("Eメール", "")
        data.Rows.Add("ホームページ", "")
        data.Rows.Add("全住所", "")
        data.Rows.Add("郵便番号", "")
        data.Rows.Add("都道府県", "")
        data.Rows.Add("市区町村", "")
        data.Rows.Add("国", "")
        data.Rows.Add("メモ", "")
        data.Rows.Add("会社名リンク", CompanyLink)
        data.Rows.Add("SNリンク", SNInfoLink)
    End Sub
    Private Sub gvMultiEdit_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gvMultiEdit.CustomRowCellEdit
        If e.Column.FieldName = "Value" Then
            Dim Gv As GridView = sender
            Dim FieldName As String = Gv.GetRowCellValue(e.RowHandle, Gv.Columns("Field")).ToString()
            Select Case FieldName
                Case "タイプ"
                    e.RepositoryItem = riComboType
                Case "国"
                    e.RepositoryItem = riComboCountry
                Case "会社名リンク"
                    e.RepositoryItem = riComboCustomer
            End Select

        End If
    End Sub
    Private Sub LoadTypeComboBox()
        Dim CustType As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers
        riComboCountry.Items.Clear()
        riComboCustomer.Items.Clear()
        riComboType.Items.Clear()
        connUsers.Open()
        cmd.Connection = connUsers
        cmd.CommandText = "SELECT DISTINCT(RelationShip) AS RelationShip FROM tbl_SNContacts"
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            CustType = db_reader.Item("RelationShip").ToString
            riComboType.Items.Add(CustType)
        Loop
        db_reader.Close()
        cmd.Connection = connUsers
        cmd.CommandText = "SELECT DISTINCT(Country) AS Type FROM tbl_SNContacts"
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            CustType = db_reader.Item("Type").ToString
            riComboCountry.Items.Add(CustType)
        Loop
        db_reader.Close()
        cmd = Nothing
        connUsers.Close()
        Dim i As Integer = 0
        For i = 0 To CompanyList.Count - 1
            riComboCustomer.Items.Add(CompanyList(i))
        Next
    End Sub
    Private Sub SaveData()
        Dim cmd As New OleDb.OleDbCommand
        Dim Query As String = ""
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim IsChanged As Boolean = False
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        Try
            connUsers.Open()
            cmd.Connection = connUsers
            For i As Integer = 0 To GUIDList.Count - 1
                Query = "UPDATE tbl_SNContacts SET "
                If gvMultiEdit.GetRowCellValue(0, "Value").ToString <> "" Then
                    Query = Query & "RelationShip='" & gvMultiEdit.GetRowCellValue(0, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(1, "Value").ToString <> "" Then
                    Query = Query & "Company='" & gvMultiEdit.GetRowCellValue(1, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(2, "Value").ToString <> "" Then
                    Query = Query & "NativeCompany='" & gvMultiEdit.GetRowCellValue(2, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(3, "Value").ToString <> "" Then
                    Query = Query & "Department='" & gvMultiEdit.GetRowCellValue(3, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(4, "Value").ToString <> "" Then
                    Query = Query & "Title='" & gvMultiEdit.GetRowCellValue(4, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(5, "Value").ToString <> "" Then
                    Query = Query & "Telephone='" & gvMultiEdit.GetRowCellValue(5, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(6, "Value").ToString <> "" Then
                    Query = Query & "Fax='" & gvMultiEdit.GetRowCellValue(6, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(7, "Value").ToString <> "" Then
                    Query = Query & "EMail='" & gvMultiEdit.GetRowCellValue(7, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(8, "Value").ToString <> "" Then
                    Query = Query & "Website='" & gvMultiEdit.GetRowCellValue(8, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(9, "Value").ToString <> "" Then
                    Query = Query & "Address='" & gvMultiEdit.GetRowCellValue(9, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(10, "Value").ToString <> "" Then
                    Query = Query & "Zip='" & gvMultiEdit.GetRowCellValue(10, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(11, "Value").ToString <> "" Then
                    Query = Query & "State='" & gvMultiEdit.GetRowCellValue(11, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(12, "Value").ToString <> "" Then
                    Query = Query & "City='" & gvMultiEdit.GetRowCellValue(12, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(13, "Value").ToString <> "" Then
                    Query = Query & "Country='" & gvMultiEdit.GetRowCellValue(13, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(14, "Value").ToString <> "" Then
                    Query = Query & "Memo='" & gvMultiEdit.GetRowCellValue(14, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(15, "Value").ToString <> "" Then
                    Query = Query & "CompanyLink='" & gvMultiEdit.GetRowCellValue(15, "Value") & "',"
                    IsChanged = True
                End If
                If gvMultiEdit.GetRowCellValue(16, "Value").ToString <> "" Then
                    Query = Query & "SNInfoLink='" & gvMultiEdit.GetRowCellValue(16, "Value") & "',"
                    IsChanged = True
                End If
                Query = Microsoft.VisualBasic.Left(Query, Len(Query) - 1)
                Query = Query & " WHERE ContactsGUID='" & GUIDList(i) & "'"
                If IsChanged = True Then
                    cmd.CommandText = Query
                    cmd.Connection = connUsers
                    cmd.ExecuteNonQuery()
                Else
                    ChangeMade = False
                End If
            Next
            connUsers.Close()
            cmd = Nothing


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Navigation"
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        'GUIDList.Clear()
        Close()
    End Sub
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        ChangeMade = True
        SaveData()
        Close()
    End Sub
#End Region

   
End Class