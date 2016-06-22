Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.Data
Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.Threading
Imports System.Net
Imports System.Web
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCompanyData
#Region "Enumerations"
    Private Enum Exec
        OLECMDID_OPEN = 1
        OLECMDID_NEW = 2
        OLECMDID_SAVE = 3
        OLECMDID_SAVEAS = 4
        OLECMDID_SAVECOPYAS = 5
        OLECMDID_PRINT = 6
        OLECMDID_PRINTPREVIEW = 7
        OLECMDID_PAGESETUP = 8
        OLECMDID_SPELL = 9
        OLECMDID_PROPERTIES = 10
        OLECMDID_CUT = 11
        OLECMDID_COPY = 12
        OLECMDID_PASTE = 13
        OLECMDID_PASTESPECIAL = 14
        OLECMDID_UNDO = 15
        OLECMDID_REDO = 16
        OLECMDID_SELECTALL = 17
        OLECMDID_CLEARSELECTION = 18
        OLECMDID_ZOOM = 19
        OLECMDID_GETZOOMRANGE = 20
        OLECMDID_UPDATECOMMANDS = 21
        OLECMDID_REFRESH = 22
        OLECMDID_STOP = 23
        OLECMDID_HIDETOOLBARS = 24
        OLECMDID_SETPROGRESSMAX = 25
        OLECMDID_SETPROGRESSPOS = 26
        OLECMDID_SETPROGRESSTEXT = 27
        OLECMDID_SETTITLE = 28
        OLECMDID_SETDOWNLOADSTATE = 29
        OLECMDID_STOPDOWNLOAD = 30
        OLECMDID_ONTOOLBARACTIVATED = 31
        OLECMDID_FIND = 32
        OLECMDID_DELETE = 33
        OLECMDID_HTTPEQUIV = 34
        OLECMDID_HTTPEQUIV_DONE = 35
        OLECMDID_ENABLE_INTERACTION = 36
        OLECMDID_ONUNLOAD = 37
        OLECMDID_PROPERTYBAG2 = 38
        OLECMDID_PREREFRESH = 39
        OLECMDID_SHOWSCRIPTERROR = 40
        OLECMDID_SHOWMESSAGE = 41
        OLECMDID_SHOWFIND = 42
        OLECMDID_SHOWPAGESETUP = 43
        OLECMDID_SHOWPRINT = 44
        OLECMDID_CLOSE = 45
        OLECMDID_ALLOWUILESSSAVEAS = 46
        OLECMDID_DONTDOWNLOADCSS = 47
        OLECMDID_UPDATEPAGESTATUS = 48
        OLECMDID_PRINT2 = 49
        OLECMDID_PRINTPREVIEW2 = 50
        OLECMDID_SETPRINTTEMPLATE = 51
        OLECMDID_GETPRINTTEMPLATE = 52
        OLECMDID_PAGEACTIONBLOCKED = 55
        OLECMDID_PAGEACTIONUIQUERY = 56
        OLECMDID_FOCUSVIEWCONTROLS = 57
        OLECMDID_FOCUSVIEWCONTROLSQUERY = 58
        OLECMDID_SHOWPAGEACTIONMENU = 59
        OLECMDID_ADDTRAVELENTRY = 60
        OLECMDID_UPDATETRAVELENTRY = 61
        OLECMDID_UPDATEBACKFORWARDSTATE = 62
        OLECMDID_OPTICAL_ZOOM = 63
        OLECMDID_OPTICAL_GETZOOMRANGE = 64
        OLECMDID_WINDOWSTATECHANGED = 65
        OLECMDID_ACTIVEXINSTALLSCOPE = 66
    End Enum
    Private Enum ExecOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum
#End Region
#Region "Formd"
    Private Sub frmCompanyData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanyData()
        'splMap.Panel2Collapsed = True
        navMain.ActiveGroup = navCompany
    End Sub

    Private Sub frmCompanyData_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Try
            gvCompany.SaveLayoutToRegistry("gvCompany")
            If COthrd.IsAlive Then
                COthrd.Abort()
            End If
        Catch ex As Exception

        End Try
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
#Region "CompanyData"
    Public FormX As Integer = 0
    Public FormY As Integer = 0
    Dim COconnUsers As System.Data.OleDb.OleDbConnection
    Dim COcmd As New OleDb.OleDbCommand
    Dim COdb_reader As OleDbDataReader
    Dim CompanyDBPath As String = ""
    Dim SIndustry As String = ""
    Dim PrefDBString As String = ""
    Dim IndFirstLoad As Boolean = True
    Dim COthrd As System.Threading.Thread
    Dim Cdata As DataTable
    Dim currentCursor As Cursor = Cursor.Current
    Private Sub LoadCompanyData()
        'AppDataPath = "D:\GDrive\Sigmatek Data\"
        CompanyDBPath = AppDataPath & "CompanyDB\"
        'CompanyDBPath = VPNSigmaDataPath & "RAKUCADATA\CompanyDB\"
        LoadSearchOptions()
        LoadPrefectures()
        activatePrefectureList()
        Dim Ithrd As System.Threading.Thread
        Ithrd = New System.Threading.Thread(AddressOf LoadIndustry)
        Ithrd.Start()
        LoadCompanyColumns()
        COthrd = New System.Threading.Thread(AddressOf LoadCompanyItems)
    End Sub
    Delegate Sub AddCompanyItemDelegate(ByVal ThreadStatus As String, ByVal CompanyGUID As String, ByVal Industry As String, ByVal IndustryDetail As String, ByVal CompanyName As String, ByVal TelephoneNo As String, ByVal FaxNo As String, ByVal ZipCode As String, ByVal Address As String, ByVal BusinessType As String, ByVal WebURL As String, ByVal EMailAddress As String, ByVal Comments As String, ByVal UpdateDate As Date)
    Public Sub AddCompanyItem(ByVal ThreadStatus As String, ByVal CompanyGUID As String, ByVal Industry As String, ByVal IndustryDetail As String, ByVal CompanyName As String, ByVal TelephoneNo As String, ByVal FaxNo As String, ByVal ZipCode As String, ByVal Address As String, ByVal BusinessType As String, ByVal WebURL As String, ByVal EMailAddress As String, ByVal Comments As String, ByVal UpdateDate As Date)
        Select Case ThreadStatus
            Case "START"
                Cdata.Clear()

            Case "FINISHED"

                'gvCompany.RestoreLayoutFromRegistry("gvCompany")
            Case Else
                Cdata.Rows.Add(CompanyGUID, Industry, IndustryDetail, CompanyName, TelephoneNo, FaxNo, ZipCode, Address, BusinessType, WebURL, EMailAddress, Comments, UpdateDate)
        End Select
    End Sub
    Delegate Sub AddIndustryItemDelegate(ByVal ThreadStatus As String, ByVal Industry As String)
    Public Sub AddIndustryItem(ByVal ThreadStatus As String, ByVal Industry As String)
        Select Case ThreadStatus
            Case "START"
                clbIndustry.Items.Clear()
                clbIndustry.Items.Add("全て", True)
            Case "FINISHED"
                'gvCompany.RestoreLayoutFromRegistry("gvCompany")
            Case Else
                clbIndustry.Items.Add(Industry)
                CheckIndustry()
        End Select
    End Sub
    Delegate Sub AddIndItemDelegate(ByVal ThreadStatus As String, ByVal dv As XPDataView)
    Public Sub AddIndItem(ByVal ThreadStatus As String, ByVal dv As XPDataView)
        Select Case ThreadStatus
            Case "START"
                clbIndustry.Items.Clear()
                clbIndustry.Items.Add("全て", True)
            Case "FINISHED"

            Case Else
                For i As Integer = 0 To dv.Count - 1
                    clbIndustry.Items.Add(dv(i).Item(0).ToString, False)
                Next
        End Select
    End Sub
    Delegate Sub AddCoDelegate(ByVal ThreadStatus As String, ByVal CoDv As XPDataView)
    Public Sub AddCoItem(ByVal ThreadStatus As String, ByVal CoDv As XPDataView)
        Select Case ThreadStatus
            Case "START"
                Cdata.Clear()
                Cursor.Current = Cursors.WaitCursor
                ShowWaitForm("")
            Case "FINISH"
                Cdata.Clear()
                Cursor.Current = currentCursor
                _waitForm.Close()

            Case Else
                gcCompany.DataSource = CoDv

        End Select
    End Sub
    Delegate Sub IncrementProgressDelegate(ByVal aThreadName As String, ByVal aProgressBar As DevExpress.XtraEditors.ProgressBarControl, ByVal ThreadStatus As String)
    Public Sub IncrementProgress(ByVal aThreadName As String, ByVal aProgressBar As DevExpress.XtraEditors.ProgressBarControl, ByVal ThreadStatus As String)
        Select Case ThreadStatus
            Case "INC"
                aProgressBar.Increment(1)

            Case Else

        End Select
    End Sub
    Private _waitForm As frmWait
    Private Sub ShowStaticMap()
        Dim Address As String = ""
        Dim FullAddress As String = ""
        Dim WebUrl As String = ""
        Try
            If gvCompany.SelectedRowsCount > 0 Then
                Address = gvCompany.GetRowCellValue(gvCompany.GetSelectedRows(0), "Address")
                WebUrl = gvCompany.GetRowCellValue(gvCompany.GetSelectedRows(0), "WebURL")
                imageMap.ImageLocation = "http://maps.googleapis.com/maps/api/staticmap?center=" & Address & "&zoom=12&size=640x1280" & "&markers=color:blue%7Clabel:S%7CT" & Address & "&maptype=roadmap&sensor=false"
                'If WebUrl <> "" Then
                '    Dim Waddress As New Uri(WebUrl)
                '    webCBrowser.Url = Waddress
                '    Try
                '        Dim wbInstance As Object = webCBrowser.ActiveXInstance
                '        wbInstance.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, ExecOpt.OLECMDEXECOPT_DONTPROMPTUSER, 40 - 0, Nothing)
                '    Catch ex As Exception
                '        MsgBox(ex.Message)
                '    End Try
                'End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ShowDynamicMap()
        Dim StreetAddress As String = ""
        Dim Company As String = ""
        Dim i As Integer = 0
        Try
            If gvCompany.SelectedRowsCount > 0 Then
                For i = 0 To gvCompany.SelectedRowsCount - 1
                    StreetAddress = gvCompany.GetRowCellValue(gvCompany.GetSelectedRows(i), "Address")
                    Company = gvCompany.GetRowCellValue(gvCompany.GetSelectedRows(i), "Company")
                Next

                Dim address As String = "http://maps.google.com/?q=" & Replace(StreetAddress, " ", "+") & ""
                Process.Start(address)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub riHyperLinkEMail_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles riHyperLinkEMail.OpenLink
        If e.EditValue <> "" Then
            Const mailPrefix As String = "mailto:"
            If Not e.EditValue.ToString().ToLower().StartsWith(mailPrefix) Then
                e.EditValue = mailPrefix + e.EditValue.ToString()
            End If
        End If

    End Sub
    Private Sub riHyperLink_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles riHyperLink.OpenLink
        Dim WebLink As String = ""
        If e.EditValue <> "" Then
            WebLink = e.EditValue
            e.EditValue = WebLink
        End If
    End Sub
    Private Sub gvCompany_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gvCompany.CustomRowCellEdit
        If e.Column.FieldName = "WebURL" Then
            Dim gv As GridView = sender
            e.RepositoryItem = riHyperLink
        ElseIf e.Column.FieldName = "EMailAddress" Then
            Dim gv As GridView = sender
            e.RepositoryItem = riHyperLinkEMail

        End If
    End Sub
    Protected Sub ShowWaitForm(message As String)
        ' don't display more than one wait form at a time
        If _waitForm IsNot Nothing AndAlso Not _waitForm.IsDisposed Then
            Return
        End If

        _waitForm = New frmWait()
        ' "Loading data. Please wait..."
        _waitForm.TopMost = True

        _waitForm.StartPosition = FormStartPosition.Manual
        Try
            Dim XLoc As Integer = frmMain.Location.X + splCompany.Panel2.Location.X + (gcCompany.Width / 2) - (_waitForm.Width / 2)
            Dim YLoc As Integer = frmMain.Location.Y + splCompany.Panel2.Location.Y + (gcCompany.Height / 2)
            _waitForm.Location = New Point(XLoc, YLoc)
        Catch ex As Exception

        End Try
        _waitForm.Show()
        _waitForm.Refresh()

        ' force the wait window to display for at least 700ms so it doesn't just flash on the screen
        System.Threading.Thread.Sleep(700)
    End Sub
    Private Sub LoadPrefectures()
        rdoPrefecture.Properties.Items.Clear()
        Dim item As DevExpress.XtraEditors.Controls.RadioGroupItem
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "北海道"
        item.Value = "北海道"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "青森"
        item.Value = "青森"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "岩手"
        item.Value = "岩手"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "宮城"
        item.Value = "宮城"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "秋田"
        item.Value = "秋田"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "山形"
        item.Value = "山形"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "福島"
        item.Value = "福島"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "茨城"
        item.Value = "茨城"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "栃木"
        item.Value = "栃木"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "群馬"
        item.Value = "群馬"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "埼玉"
        item.Value = "埼玉"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "千葉"
        item.Value = "千葉"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "東京"
        item.Value = "東京"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "神奈川"
        item.Value = "神奈川"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "新潟"
        item.Value = "新潟"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "富山"
        item.Value = "富山"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "石川"
        item.Value = "石川"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "福井"
        item.Value = "福井"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "山梨"
        item.Value = "山梨"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "長野"
        item.Value = "長野"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "岐阜"
        item.Value = "岐阜"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "静岡"
        item.Value = "静岡"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "愛知"
        item.Value = "愛知"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "三重"
        item.Value = "三重"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "滋賀"
        item.Value = "滋賀"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "京都"
        item.Value = "京都"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "大阪"
        item.Value = "大阪"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "兵庫"
        item.Value = "兵庫"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "奈良"
        item.Value = "奈良"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "和歌山"
        item.Value = "和歌山"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "鳥取"
        item.Value = "鳥取"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "島根"
        item.Value = "島根"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "岡山"
        item.Value = "岡山"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "広島"
        item.Value = "広島"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "山口"
        item.Value = "山口"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "徳島"
        item.Value = "徳島"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "香川"
        item.Value = "香川"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "愛媛"
        item.Value = "愛媛"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "高知"
        item.Value = "高知"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "福岡"
        item.Value = "福岡"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "佐賀"
        item.Value = "佐賀"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "長崎"
        item.Value = "長崎"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "熊本"
        item.Value = "熊本"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "大分"
        item.Value = "大分"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "宮崎"
        item.Value = "宮崎"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "鹿児島"
        item.Value = "鹿児島"
        rdoPrefecture.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "沖縄"
        item.Value = "沖縄"
        rdoPrefecture.Properties.Items.Add(item)
        rdoPrefecture.SelectedIndex = 12
        'rdoPrefecture.SelectedIndex = 0
    End Sub
    Private Sub activatePrefectureList()
        Dim i As Integer = 0
        Dim PrefName As String = ""
        For i = 0 To rdoPrefecture.Properties.Items.Count - 1
            rdoPrefecture.Properties.Items(i).Enabled = False
        Next
        Dim fileEntries As String() = Directory.GetFiles(CompanyDBPath)
        ' Process the list of files found in the directory. 
        Dim fileName As String
        For Each fileName In fileEntries
            PrefName = Path.GetFileNameWithoutExtension(fileName)
            For i = 0 To rdoPrefecture.Properties.Items.Count - 1
                If PrefName = rdoPrefecture.Properties.Items(i).Value Then
                    rdoPrefecture.Properties.Items(i).Enabled = True
                    Exit For
                End If
            Next
        Next fileName
    End Sub
    Private Sub LoadIndustryOld()
        Dim Query As String = ""
        Dim UQuery As String = ""
        Dim Industry As String = ""
        Dim SPrefecture As String = ""

        SPrefecture = rdoPrefecture.Text
        PrefDBString = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=Devuser127;Data Source=" & CompanyDBPath & SPrefecture & ".mdb"
        COconnUsers = New System.Data.OleDb.OleDbConnection
        COconnUsers.ConnectionString = PrefDBString
        Try
            If Me.clbIndustry.InvokeRequired Then
                Me.clbIndustry.Invoke(New AddIndustryItemDelegate(AddressOf AddIndustryItem), New Object() {"START", ""})
            Else
                Me.AddIndustryItem("START", "")
            End If
            COconnUsers.Open()
            Query = "SELECT DISTINCT(Industry) AS Industry FROM tbl_CompanyDB "
            COcmd.CommandText = Query
            COcmd.Connection = COconnUsers
            COdb_reader = COcmd.ExecuteReader(CommandBehavior.Default)
            If COdb_reader.HasRows Then
                Do While COdb_reader.Read
                    Industry = COdb_reader.Item("Industry").ToString
                    If Me.clbIndustry.InvokeRequired Then
                        Me.clbIndustry.Invoke(New AddIndustryItemDelegate(AddressOf AddIndustryItem), New Object() {"CCThread", Industry})
                    Else
                        Me.AddIndustryItem("CCThread", Industry)
                    End If
                Loop
            End If

            COdb_reader.Close()
        Catch ex As Exception
            COconnUsers.Close()
            COcmd.Dispose()
        Finally
            COconnUsers.Close()
            COcmd.Dispose()
            IndFirstLoad = False
        End Try
    End Sub
    Private Sub LoadIndustry()
        Dim Query As String = ""
        Dim UQuery As String = ""
        Dim Industry As String = ""
        Dim SPrefecture As String = ""
        Dim dv As New XPDataView()
        Dim session As New Session()
        SPrefecture = rdoPrefecture.Text
        PrefDBString = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=Devuser127;Data Source=" & CompanyDBPath & SPrefecture & ".mdb"
        session.ConnectionString = PrefDBString
        Try
            If Me.clbIndustry.InvokeRequired Then
                Me.clbIndustry.Invoke(New AddIndItemDelegate(AddressOf AddIndItem), New Object() {"START", Nothing})
            Else
                Me.AddIndItem("START", Nothing)
            End If

            Query = "SELECT DISTINCT(Industry) AS Industry FROM tbl_CompanyDB "
            Dim data As SelectedData = session.ExecuteQueryWithMetadata(Query)
            For Each row In data.ResultSet(0).Rows
                dv.AddProperty(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next

            dv.LoadData(New SelectedData(data.ResultSet(1)))

            If Me.clbIndustry.InvokeRequired Then
                Me.clbIndustry.Invoke(New AddIndItemDelegate(AddressOf AddIndItem), New Object() {"CCThread", dv})
            Else
                Me.AddIndItem("CCThread", dv)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            IndFirstLoad = False
        End Try
    End Sub
    Private Sub LoadSearchOptions()
        rdoOptions.Properties.Items.Clear()
        Dim item As DevExpress.XtraEditors.Controls.RadioGroupItem
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "全て検索。"
        item.Value = "全て検索。"
        rdoPrefecture.Properties.Items.Add(item)
        rdoOptions.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "Eメールがある場合のみ検索。"
        item.Value = "Eメールがある場合のみ検索。"
        rdoPrefecture.Properties.Items.Add(item)
        rdoOptions.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "異なるEメールのみ検索。"
        item.Value = "異なるEメールのみ検索。"
        rdoPrefecture.Properties.Items.Add(item)
        rdoOptions.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "FAX番号がある場合のみ検索。"
        item.Value = "FAX番号がある場合のみ検索。"
        rdoPrefecture.Properties.Items.Add(item)
        rdoOptions.Properties.Items.Add(item)
        item = New DevExpress.XtraEditors.Controls.RadioGroupItem
        item.Description = "異なるFAX番号のみ検索。"
        item.Value = "異なるFAX番号のみ検索。"
        rdoPrefecture.Properties.Items.Add(item)
        rdoOptions.Properties.Items.Add(item)
        rdoOptions.SelectedIndex = 0
    End Sub
    Private Sub LoadCompanyColumns()
        Dim i As Integer = 0
        Cdata = New DataTable("gvCompanyData")
        Cdata.Clear()
        Cdata.BeginInit()
        AddColumn(Cdata, "CompanyGUID", System.Type.GetType("System.String"))
        AddColumn(Cdata, "Industry", System.Type.GetType("System.String"))
        AddColumn(Cdata, "IndustryDetail", System.Type.GetType("System.String"))
        AddColumn(Cdata, "CompanyName", System.Type.GetType("System.String"))
        AddColumn(Cdata, "TelephoneNo", System.Type.GetType("System.String"))
        AddColumn(Cdata, "FaxNo", System.Type.GetType("System.String"))
        AddColumn(Cdata, "ZipCode", System.Type.GetType("System.String"))
        AddColumn(Cdata, "Address", System.Type.GetType("System.String"))
        AddColumn(Cdata, "BusinessType", System.Type.GetType("System.String"))
        AddColumn(Cdata, "WebURL", System.Type.GetType("System.String"))
        AddColumn(Cdata, "EMailAddress", System.Type.GetType("System.String"))
        AddColumn(Cdata, "Comments", System.Type.GetType("System.String"))
        AddColumn(Cdata, "UpdateDate", System.Type.GetType("System.DateTime"))
        Cdata.EndInit()

        gcCompany.DataSource = Cdata
        gcCompany.DefaultView.PopulateColumns()
        gvCompany.Columns(0).Visible = False
        gvCompany.Columns(1).Width = 150
        gvCompany.Columns(2).Width = 150
        gvCompany.Columns(3).Width = 150
        gvCompany.Columns(4).Width = 100
        gvCompany.Columns(5).Width = 100
        gvCompany.Columns(6).Width = 100
        gvCompany.Columns(7).Width = 150
        gvCompany.Columns(8).Width = 150
        gvCompany.Columns(9).Width = 150
        gvCompany.Columns(10).Width = 150
        gvCompany.Columns(11).Width = 150
        gvCompany.Columns(12).Width = 150
        gvCompany.Columns.ColumnByFieldName("Industry").Caption = "業種"
        gvCompany.Columns.ColumnByFieldName("IndustryDetail").Caption = "業種詳細"
        gvCompany.Columns.ColumnByFieldName("CompanyName").Caption = "名称"
        gvCompany.Columns.ColumnByFieldName("TelephoneNo").Caption = "電話番号"
        gvCompany.Columns.ColumnByFieldName("FaxNo").Caption = "ファックス番号"
        gvCompany.Columns.ColumnByFieldName("ZipCode").Caption = "郵便番号"
        gvCompany.Columns.ColumnByFieldName("Address").Caption = "住所"
        gvCompany.Columns.ColumnByFieldName("BusinessType").Caption = "業種"
        gvCompany.Columns.ColumnByFieldName("WebURL").Caption = "ウェブURL"
        gvCompany.Columns.ColumnByFieldName("EMailAddress").Caption = "Eメール"
        gvCompany.Columns.ColumnByFieldName("Comments").Caption = "コメント"
        gvCompany.Columns.ColumnByFieldName("UpdateDate").Caption = "更新日"
        gvCompany.Columns(0).OptionsColumn.AllowEdit = False
        gvCompany.Columns(1).OptionsColumn.AllowEdit = False
        gvCompany.Columns(2).OptionsColumn.AllowEdit = False
        gvCompany.Columns(3).OptionsColumn.AllowEdit = False
        gvCompany.Columns(4).OptionsColumn.AllowEdit = False
        gvCompany.Columns(5).OptionsColumn.AllowEdit = False
        gvCompany.Columns(6).OptionsColumn.AllowEdit = False
        gvCompany.Columns(7).OptionsColumn.AllowEdit = False
        gvCompany.Columns(8).OptionsColumn.AllowEdit = False
        gvCompany.Columns(9).OptionsColumn.AllowEdit = True
        gvCompany.Columns(10).OptionsColumn.AllowEdit = True
        gvCompany.Columns(11).OptionsColumn.AllowEdit = False
        gvCompany.Columns(12).OptionsColumn.AllowEdit = False
        gvCompany.RestoreLayoutFromRegistry("gvCompany")
        'gvCompany.Columns(7).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        'gvCompany.Columns(7).AppearanceCell.Options.UseTextOptions = True
    End Sub
    Private Sub LoadCompanyItems()
        Dim Query As String = ""
        Dim UQuery As String = ""
        Dim WhereAdd As Boolean = False
        Dim CompanyGUID As String = ""
        Dim UpdateDate As Date = Date.Today
        Dim SPrefecture As String = ""
        Dim dv As New XPDataView()
        Dim session As New Session()
        SPrefecture = rdoPrefecture.Text
        PrefDBString = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=Devuser127;Data Source=" & CompanyDBPath & SPrefecture & ".mdb"
        session.ConnectionString = PrefDBString
        If Me.gcCompany.InvokeRequired Then
            Me.gcCompany.Invoke(New AddCoDelegate(AddressOf AddCoItem), New Object() {"START", Nothing})
        Else
            Me.AddCoItem("START", Nothing)
        End If
        If SPrefecture <> "" Then
            Try
                Select Case rdoOptions.SelectedIndex
                    Case 0, 1, 3
                        Query = "SELECT CompanyGUID, Industry, IndustryDetail, CompanyName, TelephoneNo, FaxNo, ZipCode, Prefecture, Address, "
                        Query = Query & "BusinessType, WebURL, EMailAddress, Comments, UpdateDate "
                        Query = Query & "FROM tbl_CompanyDB "
                    Case 2
                        Query = "SELECT FIRST(CompanyGUID) AS CompanyGUID, FIRST(Industry) As Industry, FIRST(IndustryDetail) As IndustryDetail, FIRST(CompanyName) As CompanyName, "
                        Query = Query & "FIRST(TelephoneNo) As TelephoneNo, FIRST(FaxNo) As FaxNo, FIRST(ZipCode) As ZipCode, FIRST(Prefecture) As Prefecture, FIRST(Address) As Address, "
                        Query = Query & "FIRST(BusinessType) As BusinessType, FIRST(WebURL) As WebURL, EMailAddress, FIRST(Comments) As Comments, FIRST(UpdateDate) As UpdateDate "
                        Query = Query & "FROM tbl_CompanyDB "
                    Case 4
                        Query = "SELECT FIRST(CompanyGUID) AS CompanyGUID, FIRST(Industry) As Industry, FIRST(IndustryDetail) As IndustryDetail, FIRST(CompanyName) As CompanyName, "
                        Query = Query & "FIRST(TelephoneNo) As TelephoneNo, FaxNo, FIRST(ZipCode) As ZipCode, FIRST(Prefecture) As Prefecture, FIRST(Address) As Address, "
                        Query = Query & "FIRST(BusinessType) As BusinessType, FIRST(WebURL) As WebURL, FIRST(EMailAddress) As EMailAddress, FIRST(Comments) As Comments, FIRST(UpdateDate) As UpdateDate "
                        Query = Query & "FROM tbl_CompanyDB "
                End Select

                If SIndustry <> "" And InStr(1, SIndustry, "全て", CompareMethod.Text) = 0 Then
                    Query = Query & "WHERE (" & SIndustry & ") "
                    WhereAdd = True
                End If
                Select Case rdoOptions.SelectedIndex
                    Case 1  'Have email
                        If WhereAdd = False Then
                            Query = Query & "WHERE "
                            WhereAdd = True
                        Else
                            Query = Query & " AND "
                        End If
                        Query = Query & "EMailAddress <> '' "
                    Case 2   'group by email
                        Query = Query & "GROUP BY EMailAddress "
                    Case 3  'have fax
                        If WhereAdd = False Then
                            Query = Query & "WHERE "
                            WhereAdd = True
                        Else
                            Query = Query & " AND "
                        End If
                        Query = Query & "FaxNo <> ''"
                    Case 4  'Group by fax
                        Query = Query & "GROUP BY FaxNo "
                End Select
                If txtSearch.Text <> "" Then
                    If WhereAdd = False Then
                        Query = Query & "WHERE "
                        WhereAdd = True
                    Else
                        Query = Query & " AND "
                    End If
                    Query = Query & "(BusinessType LIKE '%" & txtSearch.Text & "%' OR CompanyName LIKE '%" & txtSearch.Text & "%') "
                End If
                Dim data As SelectedData = session.ExecuteQueryWithMetadata(Query)
                For Each row In data.ResultSet(0).Rows
                    dv.AddProperty(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
                Next
                dv.LoadData(New SelectedData(data.ResultSet(1)))
                If Me.gcCompany.InvokeRequired Then
                    Me.gcCompany.Invoke(New AddCoDelegate(AddressOf AddCoItem), New Object() {"CCThread", dv})
                Else
                    Me.AddCoItem("CCThread", dv)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If Me.gcCompany.InvokeRequired Then
                    Me.gcCompany.Invoke(New AddCoDelegate(AddressOf AddCoItem), New Object() {"FINISH", Nothing})
                Else
                    Me.AddCoItem("FINISH", Nothing)
                End If
            End Try
        End If

    End Sub
    Private Sub CheckIndustry()
        Dim itemChecked As Object
        Dim Query As String = ""
        Dim HasItems As Boolean = False
        For Each itemChecked In clbIndustry.CheckedItems
            Query = Query & "Industry = '" & itemChecked.ToString() & "' OR "
            HasItems = True
        Next
        If HasItems = True Then
            Query = Microsoft.VisualBasic.Left(Query, Len(Query) - 4)
        End If
        SIndustry = Query
    End Sub
    Private Sub clbIndustry_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbIndustry.ItemCheck
        If e.Index > 0 Then
            clbIndustry.SetItemCheckState(0, CheckState.Unchecked)
        ElseIf e.Index = 0 And clbIndustry.GetItemCheckState(0) = CheckState.Checked Then
            For i As Integer = 1 To clbIndustry.ItemCount - 1
                clbIndustry.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
        CheckIndustry()
    End Sub
    Private Sub PreLoadWebBrowser()

        'Try
        '    Dim address As New Uri("http:\\www.google.com")
        '    webCBrowser.Url = address
        '    Dim wbInstance As Object = webCBrowser.ActiveXInstance
        '    wbInstance.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, ExecOpt.OLECMDEXECOPT_DONTPROMPTUSER, 40 - 0, Nothing)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub imageMap_Click(sender As Object, e As EventArgs) Handles imageMap.Click
        ShowDynamicMap()
    End Sub
    Private Sub gvCompany_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvCompany.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            Me.cmsCompanyData.Show(gcCompany, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvCompany_FocusedRowChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles gvCompany.FocusedRowChanged
        ShowStaticMap()
    End Sub
    Private Sub rdoPrefecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdoPrefecture.SelectedIndexChanged
        If IndFirstLoad = False Then
            Dim Ithrd As System.Threading.Thread
            Ithrd = New System.Threading.Thread(AddressOf LoadIndustry)
            Ithrd.Start()
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If IndFirstLoad = False Then
            If COthrd.IsAlive Then
                COthrd.Abort()
            End If
            COthrd = New System.Threading.Thread(AddressOf LoadCompanyItems)
            COthrd.Start()
        End If

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            If COthrd.IsAlive Then
                COthrd.Abort()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CreateEMailList(ByVal ListName As String)
        Dim CompanyName As String = ""
        Dim EMailAddress As String = ""
        Dim i As Integer = 0
        Dim LineItem As String = ""
        Dim EMailPath As String = AppDataPath & "MailList\" & ListName
        Dim sw As New System.IO.StreamWriter(EMailPath, False, System.Text.Encoding.GetEncoding(GblEncoding))
        For i = 0 To gvCompany.SelectedRowsCount - 1
            CompanyName = gvCompany.GetRowCellValue(gvCompany.GetSelectedRows(i), "CompanyName").Trim
            EMailAddress = gvCompany.GetRowCellValue(gvCompany.GetSelectedRows(i), "EMailAddress").Trim
            If EMailAddress <> "" Then
                sw.WriteLine(CompanyName & ",," & EMailAddress)
            End If
            frmProgress.UpdateProgress(i)
        Next
        sw.Close()
    End Sub
    Dim frmProgress As frmProgress
    Private Sub ttsAddToEMailList_Click(sender As Object, e As EventArgs) Handles ttsAddToEMailList.Click
        Dim frmNew As New frmNew
        frmNew.LabelControl1.Text = "リスト名："
        frmNew.ShowDialog()
        Dim ListName As String = frmNew.CustomerName
        If ListName <> "" Then
            ListName = ListName & ".CSV"

            If gvCompany.SelectedRowsCount > 0 Then
                frmProgress = New frmProgress
                frmProgress.pbcStatus.Properties.Minimum = 0
                frmProgress.pbcStatus.Properties.Maximum = gvCompany.SelectedRowsCount - 1
                frmProgress.pbcStatus.Properties.Step = 1
                frmProgress.pbcStatus.Position = 0
                frmProgress.Show()
                Dim SLthrd As System.Threading.Thread
                SLthrd = New System.Threading.Thread(DirectCast(Sub() CreateEMailList(ListName), ThreadStart))
                SLthrd.Start()
            End If
        End If
    End Sub
#End Region
End Class
