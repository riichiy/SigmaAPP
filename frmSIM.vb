Imports System.IO
Imports System.Xml
Public Class frmSIM
    Dim data As DataTable
    Public SimPath As String
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Close()
    End Sub
    Private Sub frmSIM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSimColumns()
        LoadSimInfo()
    End Sub
    Private Sub LoadSimColumns()
        Dim i As Integer = 0
        data = New DataTable("gvSIM")
        data.Clear()
        data.BeginInit()
        AddColumn(data, "Description", System.Type.GetType("System.String"))
        AddColumn(data, "Value", System.Type.GetType("System.String"))
        data.EndInit()

        gcSim.DataSource = data
        gcSim.DefaultView.PopulateColumns()
        gvSim.Columns(0).Width = 150
        gvSim.Columns(1).Width = 150
        gvSim.Columns.ColumnByFieldName("Description").Caption = "説明"
        gvSim.Columns.ColumnByFieldName("Value").Caption = "詳細"
    End Sub
    Private Function FromExcelSerialDate(ByVal SerialDate As Integer) As DateTime
        If SerialDate > 59 Then SerialDate -= 1 ''// Excel/Lotus 2/29/1900 bug
        Return New DateTime(1899, 12, 31).AddDays(SerialDate)
    End Function
    Private Sub LoadSimInfo()
        Dim SimID As String = ""
        Dim HaspID As String = ""
        Dim HaspDate As String = ""
        Dim NetworkSim As String = ""
        Dim CompanyName As String = ""
        Dim Location As String = ""
        Dim MaintenanceExpDate As String = ""
        Dim SigmaNESTVersion As String = ""
        Dim ModuleDescription As String = ""
        Dim CertFileName As String = ""
        Dim ModuleArr As New ArrayList
        Dim i As Integer = 0
        data.Clear()
        ModuleArr.Clear()

        If File.Exists(SimPath) Then
            Try
                Dim sr As New System.IO.StreamReader(SimPath, System.Text.Encoding.GetEncoding(GblEncoding))
                Dim LineItem As String = ""
                While sr.Peek() > -1
                    LineItem = sr.ReadLine()
                    If InStr(1, LineItem, "<CompanyName>", CompareMethod.Text) > 0 Then
                        CompanyName = Microsoft.VisualBasic.Mid(LineItem, InStr(1, LineItem, "<CompanyName>", CompareMethod.Text) + 13, InStr(1, LineItem, "</CompanyName>", CompareMethod.Text) - InStr(1, LineItem, "<CompanyName>", CompareMethod.Text) - 13)
                    End If
                    If InStr(1, LineItem, "CertFileName", CompareMethod.Text) > 0 Then
                        CertFileName = Microsoft.VisualBasic.Mid(LineItem, InStr(1, LineItem, "CertFileName", CompareMethod.Text) + 14, 13)
                    End If
                End While
                sr.Close()

                Dim xr As XmlReader = XmlReader.Create(SimPath)
                Do While xr.Read()
                    'MsgBox(xr.Name)
                    'MsgBox(xr.NodeType)
                    If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "MaintenanceExpDate" Then
                        MaintenanceExpDate = FromExcelSerialDate(xr.ReadElementString).ToString
                    ElseIf xr.NodeType = XmlNodeType.EndElement AndAlso xr.Name = "CompanyName" Then
                        ' CompanyName = xr.ReadElementString
                    ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Location" Then
                        Location = xr.ReadElementString
                    ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "SimID" Then
                        SimID = xr.ReadElementString
                    ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "HaspID" Then
                        HaspID = xr.ReadElementString
                    ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "NetworkSim" Then
                        NetworkSim = xr.ReadElementString
                    ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "TimedHasp" Then
                        HaspDate = FromExcelSerialDate(xr.GetAttribute("EndDateValue")).ToString
                    ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "SigmaNEST" Then
                        SigmaNESTVersion = xr.GetAttribute("Version")
                    ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Module" Then
                        ModuleDescription = xr.GetAttribute("Description")
                        ModuleArr.Add(ModuleDescription)
                    End If
                Loop
                xr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            data.Rows.Add("会社名", CompanyName)
            data.Rows.Add("住所", Location)
            data.Rows.Add("SIM ID", SimID)
            data.Rows.Add("HASP ID", HaspID)
            data.Rows.Add("証明書", CertFileName)
            If HaspDate = "" Then
                HaspDate = "永久ライセンス"
            End If
            data.Rows.Add("HASP 有効日", HaspDate)
            data.Rows.Add("保守 有効日", MaintenanceExpDate)
            data.Rows.Add("ネットワーク　SIM", NetworkSim)
            For i = 0 To ModuleArr.Count - 1
                data.Rows.Add("モジュール", ModuleArr(i))
            Next

        End If

    End Sub
End Class