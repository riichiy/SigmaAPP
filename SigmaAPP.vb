Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports SigmaNEST
Imports System.IO
Imports System.Threading
Imports System.Data.OleDb
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Office.Interop
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Commands
Imports System.Text
Imports System.Xml
Imports System.Net
Imports System.Web
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base
Imports System.Environment
Imports Google.Contacts
Imports Google.GData.Client
Imports Google.GData.Contacts
Imports Google.GData.Extensions
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraEditors
Imports System.Net.NetworkInformation
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors.Repository
Imports Microsoft.Win32
Imports System.Globalization
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Base
Imports System.Collections.Specialized
Imports System.Management

'Imports Microsoft.Office.Interop.OneNote
'Imports MySql.Data.MySqlClient
Partial Public Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
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
#Region "GlobalVar"
    Dim data As DataTable
    Dim data2 As DataTable
    Dim data3 As DataTable
    Dim data4 As DataTable
    Dim data5 As DataTable
    Dim data6 As DataTable
    Dim data7 As DataTable
    Dim data9 As DataTable
    Dim data10 As DataTable
    Dim data11 As DataTable
    Dim data12 As DataTable
    Dim data13 As DataTable
    Dim data14 As DataTable
    Dim data15 As DataTable
    Dim data16 As DataTable
    Dim data17 As DataTable
    Dim data18 As DataTable
    Dim data19 As DataTable
    Dim data20 As DataTable
    Dim data21 As DataTable
    Dim data22 As DataTable
    Dim data23 As DataTable
    Dim data24 As DataTable
    Dim data25 As DataTable
    Dim data26 As DataTable
    Dim data27 As DataTable
    Dim data28 As DataTable
    Dim data29 As DataTable
    Dim data30 As DataTable
    Dim Cdata As DataTable
    Dim SNDatabasePath As String = ""
    Dim SNSSPI As Boolean = True
    Dim SNCatalog As String = ""
    Dim SNUserID As String = ""
    Dim SNPassword As String = ""
    Dim SigmanestPath As String = ""
    Dim RakucaPath As String = ""
    Dim ViewerPath As String = ""
    Dim BeyondComparePath As String = ""
    Dim GblCustomerPath As String = ""
    Dim GblAppFileLog As String = ""
    Dim GblAppPath As String = ""
    Dim GblExpensesPath As String = ""
    Dim GblQuotationPath As String = ""
    Dim GblExNitto As String = ""
    Dim SimNoList As String = ""
    Dim TeamAddressList As String = ""
    Dim SigmaINIPath As String = ""
    Dim firstload As Boolean = True
    Dim GblMyName As String = ""
    Dim GblMyAddress As String = ""
    Dim GblMyTrainStation As String = ""
    Dim GoogleUsername As String = ""
    Dim GooglePassword As String = ""
    Dim GblExchangeRate As Double = 0
    Dim GblPresentationPath As String = ""
    Dim MyDesktopPath As String = ""
    Dim SHthrd As System.Threading.Thread
    Dim COthrd As System.Threading.Thread
    Dim Language As String = "jp"
    Dim ini As New IniFile(Application.StartupPath & "\Settings.ini")
    Dim ini2 As New IniFile(GetFolderPath(SpecialFolder.CommonDocuments) & "\Settings.ini")
    Dim ComConnected As Boolean = False
    Dim GblSkinName As String = ""
    Dim GblDirList As New ArrayList
    Dim Adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
    Private CurrentNetworkInterface As NetworkInterface
    Private InitNicStats As Boolean = False
    Delegate Sub FuncCallback(ByRef obj As Object, ByVal text As String)
    Dim NetworkBW As New NetworkBandwidth
    Dim frmClock As New frmClock With {.TopLevel = False, .AutoSize = False}
    Dim frmTranslation As New frmTranslation With {.TopLevel = False, .AutoSize = False}
    Dim frmCompanyData As New frmCompanyData With {.TopLevel = False, .AutoSize = False}
    Dim frmWebMail As New frmWebMail With {.TopLevel = False, .AutoSize = False}
    Event NetChangedHandler As NetworkInformation.NetworkAvailabilityChangedEventHandler
    Dim ISthrd As System.Threading.Thread
    Dim IsNet As Boolean = True
    Dim IsSQL As Boolean = False
    Dim IsVPN As Boolean = False
    Dim IsGDrive As Boolean = False
    Dim GblSNInfoLink As String = ""
    Dim CustMultiEditIndex As Integer = 0
#End Region
#Region "FormLoad"
    Public Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        InitializeComponent()

    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        bbiUnits.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bsiVersion.Caption = "Ver:" & SAVersion

        appData = GetFolderPath(SpecialFolder.CommonDocuments)
        xtcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        xtcTools.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        splCustInfo.Panel2Collapsed = True
        ttsFolderDelete.Visible = False
        bbiJapan.Down = True
        bbiCompanyMode.Down = True
        bbiExExcel.Down = True
        ttsMoveToCustomer.Visible = False
        bbiSigmanest.Down = True
        bbiUnits.Down = True
        LoadDatabase()
        ChkSettings()
        'ISthrd = New System.Threading.Thread(AddressOf CheckNetStatus)
        'ISthrd.Start()

        LoadLanguages()
        CheckSIMRegistry()
        frmCompanyData.Dock = DockStyle.Fill
        frmCompanyData.Parent = tabCompanySearch
        frmCompanyData.Show()
        frmWebMail.Dock = DockStyle.Fill
        frmWebMail.Parent = tabMail
        frmWebMail.Show()
        frmWebMail.xtcMailMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        frmClock.Dock = DockStyle.Fill
        frmClock.Parent = pnlClock
        frmClock.Show()
        splMailMain.Visible = False
        'Thread = New Threading.Thread(AddressOf UpdateExtIpAddr)
        'Thread.IsBackground = True
        'Thread.Start()
        'AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf OnNetWorkChanged_Event
        'AddHandler NetworkChange.NetworkAddressChanged, AddressOf OnNetworkAddrChanged_Event"
        VPNSigmaDocumentsPath = "\\sigmatek.net\Documents\Employees\SigmaTEK Japan\Sigmatek Documents\"
        VPNSigmaDataPath = "\\sigmatek.net\Documents\Employees\SigmaTEK Japan\Sigmatek Data\"
        VPNRootPath = "\\sigmatek.net\Documents\Employees\SigmaTEK Japan\"
        DFeel.LookAndFeel.SkinName = GblSkinName
        firstload = False

    End Sub
    Private Sub frmMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        Dim SplHeight As Double = frmSysInfo.splWid.Height
        frmSysInfo.splWid.SplitterDistance = (SplHeight / 3) * 2
    End Sub
    Private Sub frmMain_FormClosed(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        Try
            If File.Exists(ini2.FileName) Then
                ini2.WriteIni("SETTINGS", "SkinName", DFeel.LookAndFeel.SkinName)
            End If
            gvCustomerData.ApplyFindFilter("")
            gvCustomerData.ClearColumnsFilter()
            gvCustomer.SaveLayoutToRegistry("gvStock")
            gvCustomerData.SaveLayoutToRegistry("gvCustomerData")
            frmCompanyData.gvCompany.SaveLayoutToRegistry("gvCompany")
            rbnMain.SaveLayoutToXml(appData & "\layout.xml")
            If SHthrd.IsAlive = True Then
                SHthrd.Abort()
            End If
            frmSysInfo.Dispose()
            FSNApp = Nothing
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CheckSIMRegistry()
        Dim i As Integer = 0
        Dim SimFound As Boolean = False
        Try
            Dim readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SIGMANEST", "HaspID", Nothing)
            If InStr(1, SimNoList, ",", CompareMethod.Text) > 0 Then
                Dim TmpArr() As String
                TmpArr = Split(SimNoList, ",")
                For i = 0 To TmpArr.Count - 1
                    If readValue = TmpArr(i) Then
                        SimFound = True
                        Exit For
                    End If
                Next
            Else
                If readValue = SimNoList Then
                    SimFound = True
                End If
            End If
            If SimFound = False Then
                SimNoList = SimNoList & "," & readValue
                gvSettings.SetRowCellValue(7, "SettingValue", SimNoList)
                SaveIniSettings(False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ChkSettings()

        LoadSettingColumns()
        If File.Exists(ini.FileName) Then
            Try

                CustomerDataPath = ini.ReadIniString("SETTINGS", "CustomerDataPath")
                ProspectDataPath = ini.ReadIniString("SETTINGS", "ProspectDataPath")
                PartnerDataPath = ini.ReadIniString("SETTINGS", "PartnerDataPath")
                PostDataPath = ini.ReadIniString("SETTINGS", "PostDataPath")
                SigmanestDataPath = ini.ReadIniString("SETTINGS", "SigmanestDataPath")
                DocumentDataPath = ini.ReadIniString("SETTINGS", "DocumentDataPath")
                SigmanestPath = ini.ReadIniString("SETTINGS", "SigmanestPath")
                SimNoList = ini.ReadIniString("SETTINGS", "SimNoList")
                GblEncoding = ini.ReadIniString("SETTINGS", "Encoding")
                BeyondComparePath = ini.ReadIniString("SETTINGS", "BeyondComparePath")
                RakucaPath = ini.ReadIniString("SETTINGS", "RakucaPath")
                ViewerPath = ini.ReadIniString("SETTINGS", "ViewerPath")
                Language = ini.ReadIniString("SETTINGS", "Language")
                'SNDatabasePath = ini.ReadIniString("DATABASE", "SNDatabasePath")
                'SNCatalog = ini.ReadIniString("DATABASE", "SNCatalog")
                'SNUserID = ini.ReadIniString("DATABASE", "SNUserID")
                'SNPassword = ini.ReadIniString("DATABASE", "SNPassword")
                'SNSSPI = ini.ReadIniInteger("DATABASE", "SNSSPI")
            Catch ex As Exception

            Finally
                data15.Rows.Clear()
                data15.Rows.Add("GoogleDrive Customer パス", CustomerDataPath, "SETTINGS", "CustomerDataPath")
                data15.Rows.Add("GoogleDrive Prospects パス", ProspectDataPath, "SETTINGS", "ProspectDataPath")
                data15.Rows.Add("GoogleDrive Partners パス", PartnerDataPath, "SETTINGS", "PartnerDataPath")
                data15.Rows.Add("GoogleDrive Post パス", PostDataPath, "SETTINGS", "PostDataPath")
                data15.Rows.Add("GoogleDrive Data パス", SigmanestDataPath, "SETTINGS", "SigmanestDataPath")
                data15.Rows.Add("GoogleDrive Document パス", DocumentDataPath, "SETTINGS", "DocumentDataPath")
                data15.Rows.Add("SigmaNEST 実行ファイル パス", SigmanestPath, "SETTINGS", "SigmanestPath")
                data15.Rows.Add("SIM番号", SimNoList, "SETTINGS", "SimNoList")
                data15.Rows.Add("エンコード", GblEncoding, "SETTINGS", "Encoding")
                data15.Rows.Add("Beyond Compare パス", BeyondComparePath, "SETTINGS", "BeyondComparePath")
                data15.Rows.Add("Viewer パス", ViewerPath, "SETTINGS", "ViewerPath")
                If Directory.Exists(CustomerDataPath) = False Then
                    CustomerDataPath = Replace(CustomerDataPath, "C:\", "D:\")
                End If
                If Directory.Exists(ProspectDataPath) = False Then
                    ProspectDataPath = Replace(ProspectDataPath, "C:\", "D:\")
                End If
                If Directory.Exists(PartnerDataPath) = False Then
                    PartnerDataPath = Replace(PartnerDataPath, "C:\", "D:\")
                End If
                If Directory.Exists(PostDataPath) = False Then
                    PostDataPath = Replace(PostDataPath, "C:\", "D:\")
                End If
                If Directory.Exists(SigmanestDataPath) = False Then
                    SigmanestDataPath = Replace(SigmanestDataPath, "C:\", "D:\")
                End If
                If Directory.Exists(DocumentDataPath) = False Then
                    DocumentDataPath = Replace(DocumentDataPath, "C:\", "D:\")
                End If
                If File.Exists(BeyondComparePath) = False Then
                    BeyondComparePath = Replace(BeyondComparePath, "C:\", "D:\")
                End If
                If File.Exists(ViewerPath) = False Then
                    ViewerPath = Replace(ViewerPath, "C:\", "D:\")
                End If
                CheckNetStatus()
                AppDataPath = SigmanestDataPath & "RAKUCADATA\"
                ListID = "SigmaJapan"
                LoadCustomerInfoColumns()
                SHthrd = New System.Threading.Thread(AddressOf LoadCustomerInfoItems)
                SHthrd.Start()
            End Try
        Else
            MsgBox("Settings.iniが見つかりません。")
        End If

        If File.Exists(ini2.FileName) Then
            Try
                GblMyAddress = ini2.ReadIniString("SETTINGS", "MyAddress")
                GblMyName = ini2.ReadIniString("SETTINGS", "MyName")
                GblMyTrainStation = ini2.ReadIniString("SETTINGS", "MyTrainStation")
                TeamAddressList = ini2.ReadIniString("SETTINGS", "TeamAddressList")
                GoogleUsername = ini2.ReadIniString("SETTINGS", "GoogleUsername")
                GooglePassword = ini2.ReadIniString("SETTINGS", "GooglePassword")
                GblPresentationPath = ini2.ReadIniString("SETTINGS", "PresentationPath")
                GblExpensesPath = ini2.ReadIniString("SETTINGS", "ExpensesPath")
                GblQuotationPath = ini2.ReadIniString("SETTINGS", "QuotationPath")
                GblExNitto = ini2.ReadIniString("SETTINGS", "AllowanceAmount")
                GblSkinName = ini2.ReadIniString("SETTINGS", "SkinName")
                MyDesktopPath = ini2.ReadIniString("SETTINGS", "DesktopPath")
                GblExchangeRate = ini2.ReadIniString("SETTINGS", "ExchangeRate")
            Catch ex As Exception

            Finally
                data16.Rows.Clear()
                data16.Rows.Add("私の名前", GblMyName, "SETTINGS", "MyName")
                data16.Rows.Add("私の住所", GblMyAddress, "SETTINGS", "MyAddress")
                data16.Rows.Add("私の最寄り駅", GblMyTrainStation, "SETTINGS", "MyTrainStation")
                data16.Rows.Add("私のチームメールアドレス", TeamAddressList, "SETTINGS", "TeamAddressList")
                data16.Rows.Add("私のGoogle ユーザー名", GoogleUsername, "SETTINGS", "GoogleUsername")
                data16.Rows.Add("私のGoogle パスワード", GooglePassword, "SETTINGS", "GooglePassword")
                data16.Rows.Add("私のプレゼンテーション", GblPresentationPath, "SETTINGS", "PresentationPath")
                data16.Rows.Add("私のデスクトップ画像", MyDesktopPath, "SETTINGS", "DesktopPath")
                data16.Rows.Add("私の経費データ保存先", GblExpensesPath, "SETTINGS", "ExpensesPath")
                data16.Rows.Add("私の見積もりデータ保存先", GblQuotationPath, "SETTINGS", "QuotationPath")
                data16.Rows.Add("私の日当金額", GblExNitto, "SETTINGS", "AllowanceAmount")
                data16.Rows.Add("見積もりの為替", GblExchangeRate, "SETTINGS", "ExchangeRate")
            End Try
        Else
            File.Create(ini2.FileName)
            data16.Rows.Clear()
            data16.Rows.Add("私の名前", GblMyName, "SETTINGS", "MyName")
            data16.Rows.Add("私の住所", GblMyAddress, "SETTINGS", "MyAddress")
            data16.Rows.Add("私の最寄り駅", GblMyTrainStation, "SETTINGS", "MyTrainStation")
            data16.Rows.Add("私のチームメールアドレス", TeamAddressList, "SETTINGS", "TeamAddressList")
            data16.Rows.Add("私のGoogle ユーザー名", GoogleUsername, "SETTINGS", "GoogleUsername")
            data16.Rows.Add("私のGoogle パスワード", GooglePassword, "SETTINGS", "GooglePassword")
            data16.Rows.Add("私のプレゼンテーション", GblPresentationPath, "SETTINGS", "PresentationPath")
            data16.Rows.Add("私のデスクトップ画像", MyDesktopPath, "SETTINGS", "DesktopPath")
            data16.Rows.Add("私の経費データ保存先", GblExpensesPath, "SETTINGS", "ExpensesPath")
            data16.Rows.Add("私の見積もりデータ保存先", GblQuotationPath, "SETTINGS", "QuotationPath")
            data16.Rows.Add("私の日当金額", GblExNitto, "SETTINGS", "AllowanceAmount")
            data16.Rows.Add("見積もりの為替", GblExchangeRate, "SETTINGS", "ExchangeRate")
        End If
        If Directory.Exists(GblExpensesPath) = False And GblExpensesPath <> "" Then
            Directory.CreateDirectory(GblExpensesPath)
        End If
        If Directory.Exists(GblQuotationPath) = False And GblQuotationPath <> "" Then
            Directory.CreateDirectory(GblQuotationPath)
        End If
        LoadCustomerColumns()
        LoadCustomerDetailsColumns()
        LoadCustomerData()
        LoadCustomerLogColumns()
        LoadSigmanestColumns()
        LoadProductsColumns()
        LoadSigmanestData()
        LoadAppColumns()
        LoadMailTemplateColumns()
        LoadWebShortcutColumns()
        LoadDemoColumns()
        LoadVideoColumns()

        LoadSIMColumns()
        LoadMachineColumns()
        LoadExMonthColumns()
        LoadQAColumns()
        LoadQACSV()
        LoadAllQuoteColumns()
        LoadSalesLogixColumns()

    End Sub
    Private Sub SaveIniSettings(Optional ByVal Showmessage As Boolean = True)
        Dim i As Integer = 0
        Dim Description As String = """"
        Dim SettingValue As String = ""
        Dim Section As String = ""
        Dim Key As String = ""

        If File.Exists(ini.FileName) Then
            Try
                gcSettings.FocusedView.CloseEditor()
                For i = 0 To gvSettings.RowCount - 1
                    Description = gvSettings.GetRowCellValue(i, "Description").ToString
                    SettingValue = gvSettings.GetRowCellValue(i, "SettingValue").ToString
                    Section = gvSettings.GetRowCellValue(i, "Section").ToString
                    Key = gvSettings.GetRowCellValue(i, "Key").ToString
                    ini.WriteIni(Section, Key, SettingValue)
                    Select Case Key
                        Case "CustomerDataPath"
                            CustomerDataPath = SettingValue
                        Case "ProspectDataPath"
                            ProspectDataPath = SettingValue
                        Case "PartnerDataPath"
                            PartnerDataPath = SettingValue
                        Case "PostDataPath"
                            PostDataPath = SettingValue
                        Case "SigmanestDataPath"
                            SigmanestDataPath = SettingValue
                        Case "DocumentDataPath"
                            DocumentDataPath = SettingValue
                        Case "SigmanestPath"
                            SigmanestPath = SettingValue
                        Case "BeyondComparePath"
                            BeyondComparePath = SettingValue
                        Case "ViewerPath"
                            ViewerPath = SettingValue
                        Case "SimNoList"
                            SimNoList = SettingValue
                        Case "Encoding"
                            GblEncoding = SettingValue
                        Case "PresentationPath"
                            GblPresentationPath = SettingValue
                    End Select
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

            End Try
        Else
            MsgBox("Settings.iniが見つかりません。")
        End If
        If File.Exists(ini2.FileName) Then
            Try
                gcLSettings.FocusedView.CloseEditor()
                For i = 0 To gvLSettings.RowCount - 1
                    Description = gvLSettings.GetRowCellValue(i, "Description").ToString
                    SettingValue = gvLSettings.GetRowCellValue(i, "SettingValue").ToString
                    Section = gvLSettings.GetRowCellValue(i, "Section").ToString
                    Key = gvLSettings.GetRowCellValue(i, "Key").ToString
                    ini2.WriteIni(Section, Key, SettingValue)
                    Select Case Key
                        Case "MyAddress"
                            GblMyAddress = SettingValue
                        Case "MyName"
                            GblMyName = SettingValue
                        Case "MyTrainStation"
                            GblMyTrainStation = SettingValue
                        Case "TeamAddressList"
                            TeamAddressList = SettingValue
                        Case "GoogleUsername"
                            GoogleUsername = SettingValue
                        Case "GooglePassword"
                            GooglePassword = SettingValue
                        Case "ExpensesPath"
                            GblExpensesPath = SettingValue
                        Case "QuotationPath"
                            GblQuotationPath = SettingValue
                        Case "AllowanceAmount"
                            GblExNitto = SettingValue
                        Case "ExchangeRate"
                            GblExchangeRate = SettingValue
                        Case "MyDesktopPath"
                            MyDesktopPath = SettingValue
                    End Select
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

            End Try
        Else
            MsgBox("Settings.iniが見つかりません。")
        End If
        ChkSettings()
        LoadCustomerData()
        LoadSigmanestData()
        If Showmessage = True Then
            MsgBox("設定が保存されました")
        End If
    End Sub
    Private Sub LoadLanguages()
        If Language = "en" Then
            Me.tabCustomer.Text = "CustomerFiles"

            Me.cbtnQA.Text = "QA only"
            Me.bbiSave.Caption = "Save"
            Me.bbiSetSNData.Caption = "Set Sigma"
            Me.bbiUndoSetting.Caption = "Undo"
            Me.bbiSaveSettings.Caption = "Save"
            Me.bbiNew.Caption = "Clear"
            Me.bbiEditLog.Caption = "Edit Log"
            Me.bbiRefresh.Caption = "Refresh Log"
            Me.bbiMail.Caption = "EMail"
            Me.bbiJapan.Caption = "Japanese"
            Me.bbiUSA.Caption = "English"
            Me.bbiKorea.Caption = "Korean"
            Me.bbiOpenINI.Caption = "Open INI"
            Me.bbiChina.Caption = "Chinese"
            Me.bbiSigmanest.Caption = "SigmaNEST"
            Me.bbiCompanion.Caption = "Companion"
            Me.bbiQuote.Caption = "Quote"
            Me.bbiCTL.Caption = "CTL"
            Me.bbiLite.Caption = "Lite"
            Me.bbiNormalSetting.Caption = "Reset Settings"
            Me.bbiBeyondCompare.Caption = "Beyond Compare"
            Me.bbiOpenFile.Caption = "Open"
            Me.bbiDelete.Caption = "Delete"
            Me.bbiCreateOutlookMail.Caption = "Create email"
            Me.bbiCalDay.Caption = "Day"
            Me.bbiCalWeek.Caption = "Week"
            Me.bbiCalWork.Caption = "Week  (Weekdays)"
            Me.bbiCalMonth.Caption = "Month"
            Me.bbiCalTimeline.Caption = "Timeline"
            Me.bbiSNConfig.Caption = "SN configuration"
            Me.bbiShowVideo.Caption = "Video"
            Me.bbiDocuments.Caption = "Document"
            Me.bbiDocMachines.Caption = "Machine Specs"
            Me.bbiDocTrouble.Caption = "Troubleshooting"
            Me.bbiCustFind.Caption = "Search"
            Me.bbiCustClear.Caption = "Clear"
            Me.bbiAddNewCustomer.Caption = "New Customers"
            Me.bbiEditCustomer.Caption = "Name Edit"
            Me.bbiSIMMail.Caption = "SIM-mail"
            Me.bbiLicenseFile.Caption = "Open license"
            Me.bbiSalesMode.Caption = "Prospects"
            Me.bbiAddCustomer.Caption = "Add to"
            Me.bbiEditCust.Caption = "Edit"
            Me.bbiCustDelete.Caption = "Delete"
            Me.skinSet.Caption = "SkinRibbonGalleryBarItem1"
            Me.bbiEight.Caption = "Eight Sync"
            Me.bbiViewer.Caption = "NC Viewer"
            Me.bbiOpen.Caption = "Open Folder"
            Me.bbiRunFile.Caption = "Run"
            Me.bbiShowCustomer.Caption = "Customer list"
            Me.bbiShowCompany.Caption = "Company List"
            Me.bbiMasterPost.Caption = "Post"
            Me.bbiCompanyMode.Caption = "Customer"
            Me.bbiPrint.Caption = "Print"
            Me.bbiSpain.Caption = "Spanish"
            Me.bbiGoogleContacts.Caption = "Google Contacts"
            Me.bbiExExcel.Caption = "Expenses XLS"
            Me.bbiExWeb.Caption = "Information on the Web"
            Me.bbiExExpenses.Caption = "Expenses"
            Me.bbiExTimecard.Caption = "Attendance table"
            Me.bbiExCreate.Caption = "Creating"
            Me.btnUndo.Caption = "Undo"
            Me.bbiHasp.Caption = "HASP"
            Me.bbiPartnerMode.Caption = "Partners"
            Me.bbiKillSigmanest.Caption = "SN Exit"
            Me.bbiQuotation.Caption = "Quotation"
            Me.bbiPicture.Caption = "Image"
            Me.bbiSlideshow.Caption = "Slideshow"
            Me.bbiQuoteDoc.Caption = "Estimates details"
            Me.bbiExportPDF.Caption = "PDF creation"
            Me.bbiInvoice.Caption = "Bill"
            Me.bbiCreateQuote.Caption = "Quotation"
            Me.bbiMaintQuote.Caption = "Subscription Quote"
            Me.bbiMaintInvoice.Caption = "Subscription Invoice"
            Me.bbiOpenQuote.Caption = "Open Quote"
            Me.bsiVersion.Caption = "Ver"
            Me.bbiCreateNewExcel.Caption = "New Excel"
            Me.bbiCreateNewWord.Caption = "New Word"
            Me.bbiSQLManager.Caption = "SQL Manager"
            Me.rpgSigma.Text = "SigmaNEST"
            Me.rpgLanguage.Text = "Language"
            Me.rpgSigmaStartup.Text = "Startup"
            Me.rpgSigmaINI.Text = "SigmaNEST INI"
            Me.rpgTools.Text = "Tool"
            Me.rpgDemo.Text = "Demos"
            Me.rpgSigmanest2.Text = "SigmaNEST setting"
            Me.rpgShowVideo.Text = "Video"
            Me.rpgDemoTools.Text = "Tool"
            Me.rpgMain.Text = "Customer Data"
            Me.rpgCustFind.Text = "Search"
            Me.rpgSalesMode.Text = "Navigation"
            Me.rpgNav.Text = "New/Save"
            Me.rpgSigmanest.Text = "SigmaNEST"
            Me.rpgLog.Text = "Log"
            Me.rpgMisc.Text = "Other"
            Me.rpgCustomers.Text = "Clients"
            Me.rpgCustomerNav.Text = "Navigation"
            Me.rpgFind.Text = "Search"
            Me.rpgCustomerEdit.Text = "Customer management"
            Me.rpgEight.Text = "Tool"
            Me.rpgApps.Text = "Apps/DLL"
            Me.rpgNav2.Text = "New/Save"
            Me.rpgSigmanestApp.Text = "SigmaNEST"
            Me.rpgSigmaDLLIni.Text = "APPS/DLL"
            Me.rpgAppVide.Text = "Video"
            Me.rpgMail.Text = "EMail"
            Me.rpgNav3.Text = "New/Save"
            Me.rpgOutlook.Text = "Outlook"
            Me.rpgWeb.Text = "Web"
            Me.rpgWebNav.Text = "New/Save"
            Me.rpgMaintenance.Text = "Document"
            Me.rpgExcel.Text = "File folder"
            Me.rpgDocNav.Text = "Navigation"
            Me.rpgMaintFind.Text = "Search"
            Me.rpgNewDocument.Text = "New Document"
            Me.rpgVideo.Text = "Image"
            Me.rpgVideoShow.Text = "Video image"
            Me.rpgVideoFolder.Text = "Folder"
            Me.rpgSlideshow.Text = "Slideshow"
            Me.rpExpenses.Text = "Internal"
            Me.rpgExDocument.Text = "Document"
            Me.rpgExNavigation.Text = "Navigation"
            Me.rpgExEdit.Text = "Registration and editing"
            Me.rpgQuote.Text = "Quote-invoice"
            Me.rpgSettings.Text = "Settings"
            Me.rpgEdit.Text = "Setting edit"
            Me.LabelControl8.Text = "Version:"
            Me.LabelControl7.Text = "Maintenance:"
            Me.tabCustomerData.Text = "CustomerData"
            Me.tabCompanySearch.Text = "Company"
            Me.tabSigmaNEST.Text = "SigmaNEST"
            Me.tabApps.Text = "Apps"
            Me.tabDemo.Text = "Demo"
            Me.tabMail.Text = "Mail"
            Me.splMailMain.Panel1.Text = "Panel1"
            Me.splMailMain.Panel2.Text = "Panel2"
            Me.splMailMain.Text = "SplitContainerControl1"
            Me.GroupControl2.Text = "Mail Template"
            Me.LayoutControl1.Text = "LayoutControl1"
            Me.rtbBody.Text = ""
            Me.LabelControl3.Text = "Subject"
            Me.LabelControl2.Text = "Body"
            Me.tabDocuments.Text = "Documents"
            Me.xlsData.Text = "SpreadsheetControl1"
            Me.tabWeb.Text = "Web"
            Me.SplitContainerControl1.Panel1.Text = "Panel1"
            Me.SplitContainerControl1.Panel2.Text = "Panel2"
            Me.SplitContainerControl1.Text = "SplitContainerControl1"
            Me.GroupControl3.Text = "Web links"
            Me.LayoutControl2.Text = "LayoutControl2"
            Me.LabelControl6.Text = "Type"
            Me.LabelControl4.Text = "Link"
            Me.LabelControl5.Text = "Description"
            Me.tabVideo.Text = "Video"
            Me.tabExpenses.Text = "Expenses"
            Me.tabMyExpenses.Text = "Expenses"
            Me.GroupControl7.Text = "Other"
            Me.LabelControl27.Text = "Advertising:"
            Me.LabelControl23.Text = "Other:"
            Me.LabelControl32.Text = "Gifts:"
            Me.LabelControl25.Text = "Stamp fee:"
            Me.LabelControl28.Text = "Overseas mail:"
            Me.LabelControl31.Text = "Domestic mail:"
            Me.GroupControl4.Text = "Transportation cost"
            Me.LabelControl18.Text = "Car Rental:"
            Me.LabelControl22.Text = "Gasoline:"
            Me.LabelControl20.Text = "Car (km 40 yen):"
            Me.LabelControl21.Text = "Parking fee:"
            Me.LabelControl19.Text = "Taxi bus:"
            Me.btnExSearch.Text = "Search"
            Me.LabelControl17.Text = "Fast price:"
            Me.LabelControl14.Text = "~"
            Me.LabelControl16.Text = "Airfare:"
            Me.LabelControl15.Text = "Route fare:"
            Me.GroupControl5.Text = "Food and drink"
            Me.chkExForCompany.Properties.Caption = "House"
            Me.LabelControl13.Text = "Members:"
            Me.LabelControl24.Text = "Other:"
            Me.LabelControl26.Text = "Dinner:"
            Me.LabelControl29.Text = "Lunch:"
            Me.LabelControl30.Text = "Breakfast:"
            Me.GroupControl6.Text = "General"
            Me.LabelControl33.Text = "Exchange:"
            Me.chkExLate.Properties.Caption = "Late"
            Me.LabelControl9.Text = "Date:"
            Me.chkExEarly.Properties.Caption = "Early"
            Me.LabelControl10.Text = "Destination:"
            Me.chkNitto.Properties.Caption = ""
            Me.LabelControl12.Text = "Day:"
            Me.LabelControl11.Text = "Hotel:"
            Me.chkHotel.Properties.Caption = ""
            Me.tabSalesTools.Text = "Business"
            Me.NavBarControl1.Text = "NavBarControl1"
            Me.NavBarGroup4.Caption = "Discounts and other"
            Me.NavQuotePackage.Caption = "Package"
            Me.NavBarGroup2.Caption = "Options"
            Me.ポスト.Caption = "Post + Customization"
            Me.NavBarGroup1.Caption = "Installation Support and maintenance"
            Me.NavBarGroup3.Caption = "All (English)"
            Me.tabExWeb.Text = "Web"
            Me.tabExSpreadsheet.Text = "Excel"
            Me.xlsExpenses.Text = "SpreadsheetControl1"
            Me.tabExSpreadsheet2.Text = "Excel 2"
            Me.xlsDoc.Text = "SpreadsheetControl1"
            Me.tabExDocument.Text = "Document"
            Me.tabSettings.Text = "Settings"
            Me.gcsSettings.Text = "Setting"
            Me.ttsFindCustomer.Text = "Information retrieval"
            Me.ttsNewFolder.Text = "Folder new"
            Me.ttsEditFolder.Text = "Folder name Edit"
            Me.ttsOpenCustomerFolder.Text = "Open folder"
            Me.ttsFolderDelete.Text = "Folder Delete"
            Me.ttsMoveToCustomer.Text = "Go to customer"
            Me.ttsCreateExpenses.Text = "Create expense report"
            Me.ttsCheck.Text = "Confirmation"
            Me.ttsEditSim.Text = "Edit"
            Me.ttsMailLog.Text = "E-mail created"
            Me.ttsDeleteLogItem.Text = "Column Delete"
            Me.ttsEditLog.Text = "Log edit"
            Me.ttsCustomerMultiEdit.Text = "Multiple editing"
            Me.ttsMailClient.Text = "Create email"
            Me.ttsOpenWebAddress.Text = "Open  Web page"
            Me.ttsGoogleSearch.Text = "Google route search"
            Me.ttsNavitime.Text = "Navitime route search"
            Me.ttsSearchJalan.Text = "Jalan Hotel Search"
            Me.ttsSearchRakuten.Text = "Rakuten Hotel Search"
            Me.ttsSearchWeather.Text = "Yahoo Weather Search"
            Me.ttsShowVideo.Text = "Open video"
            Me.ttsSaveLog.Text = "Sign up"
            Me.ttsCopyClipboard.Text = "Copy to clipboard"
            Me.ttsAddToSchedule.Text = "Add Maintenance Date to Schedule"
            Me.ttsAddMaintToSchedule.Text = "Add Maintenance Date to Schedule"
            Me.ttsRequestSim.Text = "Send email"
            Me.ttsShowDemoVideo.Text = "Open video"
            Me.ttsShowDemoWOL.Text = "Open WOL"
            Me.ttsOpenDemoHelp.Text = "Open HELP"
            Me.ttsQQty.Text = "Quantity"
            Me.ttsQ1.Text = "One"
            Me.ttsQ2.Text = "Two"
            Me.ttsQ3.Text = "Three"
            Me.ttsQ4.Text = "Four"
            Me.ttsQ5.Text = "Five"
            Me.ttsQAdd.Text = "Add to"
            Me.ttsCartClear.Text = "Revocation"
            Me.ttsItemDelete.Text = "Delete"
            Me.Text = "SigmaTEK Dashboard"
            Me.bbiFTPUp.Caption = "FTP Upload"
            Me.bbiCustMarkers.Caption = "Map"
            Me.bbiMail.Caption = "Mail"
            Me.bbiMailMessage.Caption = "Message"
            Me.bbiMailTemplate.Caption = "Template"
            Me.bbiMailText.Caption = "Text Template"
            Me.bbiSMTPSettings.Caption = "SMTP Settings"
            Me.bbiFTPSettings.Caption = "FTP Settings"
            Me.bbiPlaceholders.Caption = "Placeholders"
            Me.bbiExportToCSV.Caption = "CSV Export"
            Me.bbiTranslate.Caption = "Translate"
            Me.bbiClickstamper.Caption = "Seal"
            'this form
        Else

        End If


    End Sub
    Private Sub LoadDatabase()
        SSDBString = "Provider=SQLOLEDB.1;Data Source=sql2012.willnet.ad.jp;User ID=r_11094_sigmanest;Password=BestNest1445;Persist Security Info=True;Initial Catalog=r_11094_SNDBase;"
        SS2DBString = "Data Source=sql2012.willnet.ad.jp;User ID=r_11094_sigmanest;Password=BestNest1445;Persist Security Info=True;Initial Catalog=r_11094_SNDBase;"
    End Sub

#End Region
#Region "Desktop"
    Private Const SPI_SETDESKWALLPAPER As Integer = &H14
    Private Const SPIF_UPDATEINIFILE As Integer = &H1
    Private Const SPIF_SENDWININICHANGE As Integer = &H2
    Dim PrevDesktop As String = ""
    Dim NewDesktop As Boolean = False
    Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Function GetCurrentWallpaper() As String
        ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
        Dim rkWallPaper As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        ' Return the current wallpaper path
        Return WallpaperPath
    End Function
    Friend Sub SetWallpaper()
        Dim imageLocation As String = ""
        Dim imagePath As String = ""

        ' imageLocation = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.MyPictures, WallpaperFile)
        imagePath = SigmanestDataPath & "Applications\SigmaAPP\Images\"
        If File.Exists(MyDesktopPath) Then
            imageLocation = MyDesktopPath
        Else
            Dim di As New System.IO.DirectoryInfo(imagePath)
            Dim diar1 As System.IO.FileInfo() = di.GetFiles()
            Dim dra As System.IO.FileInfo
            For Each dra In diar1
                imageLocation = dra.FullName
                Exit For
            Next
        End If


        If NewDesktop = False Then
            If imageLocation <> "" Then
                Try
                    PrevDesktop = GetCurrentWallpaper()

                    Dim FolderName As String = Path.GetDirectoryName(PrevDesktop) & "\"
                    If FolderName <> imagePath Then
                        If File.Exists(ini2.FileName) Then
                            ini2.WriteIni("DESKTOP", "ImagePath", PrevDesktop)
                        End If
                    End If

                    'img.Save(imageLocation, System.Drawing.Imaging.ImageFormat.Bmp)
                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imageLocation, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            End If
            NewDesktop = True
        Else
            Try
                If File.Exists(ini2.FileName) Then
                    PrevDesktop = ini2.ReadIniString("DESKTOP", "ImagePath")
                End If
            Catch ex As Exception

            End Try
            imageLocation = PrevDesktop
            If imageLocation <> "" Then
                Try
                    'img.Save(imageLocation, System.Drawing.Imaging.ImageFormat.Bmp)
                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imageLocation, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            End If
            NewDesktop = False
        End If

    End Sub
    Private Sub bbiSwitchDesktop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        SetWallpaper()
    End Sub
    Private Sub bbiOpenPresentation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOpenPresentation.ItemClick
        Dim DocDataPath As String = GblPresentationPath
        'Process.Start("powerpnt", "/s """ & DocDataPath & """")
        If File.Exists(DocDataPath) Then
            Process.Start(DocDataPath)
        Else
            MsgBox("プレゼンのファイルが見つかりません。")
        End If

    End Sub
#End Region
#Region "Sigmanest"
    Private FSNApp As ISNApp
    Dim tvChecked As Boolean = False
    Private Enum COMConnection
        ConnectedToCom = 1
        NotConnectedToCom
    End Enum

    Private Sub ConnectToCOM()
        Dim p() As Process
        p = Process.GetProcessesByName("Sigmanest")
        If p.Count > 0 Then
            'If FSNApp Is Nothing Then

            Try
                FSNApp = TryCast(Marshal.GetActiveObject("SigmaNEST.SNApp"), ISNApp)

                If FSNApp IsNot Nothing Then
                    FSNApp.ShowForm()
                End If
                DBString = FSNApp.ADOConnectionString
                SNDBString = DBString
                SimDBString = Microsoft.VisualBasic.Left(SNDBString, SNDBString.LastIndexOf("=")) & "=SIMTRANS;"
                Dim TmpArr() As String
                TmpArr = Split(DBString, ";")
                Dim i As Integer = 0
                For i = 0 To UBound(TmpArr) - 1
                    Dim TmpArr2() As String
                    TmpArr2 = Split(TmpArr(i), "=")
                    Select Case TmpArr2(0)
                        Case "Data Source"
                            SNDatabasePath = TmpArr2(1)
                        Case "User ID"
                            SNUserID = TmpArr2(1)
                        Case "Password"
                            SNPassword = TmpArr2(1)
                        Case "Initial Catalog"
                            SNCatalog = TmpArr2(1)
                        Case "Persist Security Info"
                            SNSSPI = TmpArr2(1)
                    End Select
                Next
                ComConnected = True
            Catch ex As Exception
                MsgBox(ex.Message)
                'MsgBox("シグマネストに接続できませんでした。再度SigmaAPPを立ち上げなおして下さい。")
                'GetActiveObj failed no try to create a new instance
                'Try
                '    FSNApp = New SNApp()
                '    FSNApp.ShowForm()
                'Catch [Error] As Exception
                '    MessageBox.Show("Error connecting to existing instance" & vbLf & [Error].ToString(), "COM Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                'End Try
            End Try
            ComConnected = False
        Else
            ComConnected = False
            'we are connected - lets disconnect
            'FSNApp = Nothing
        End If
        'Else
        'MsgBox("SigmaNESTを立ち上げて下さい。")
        'End If



    End Sub
    Private Sub ReConnectToCOM()
        If FSNApp Is Nothing Then
            Try
                FSNApp = TryCast(Marshal.GetActiveObject("SigmaNEST.SNApp"), ISNApp)

                If FSNApp IsNot Nothing Then
                    FSNApp.ShowForm()
                End If
            Catch
                'GetActiveObj failed no try to create a new instance
                Try
                    FSNApp = New SNApp()
                    FSNApp.ShowForm()
                Catch [Error] As Exception
                    MessageBox.Show("Error connecting to existing instance" & vbLf & [Error].ToString(), "COM Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
            End Try
        Else
            'we are connected - lets disconnect
            FSNApp = Nothing
        End If

    End Sub
#End Region
#Region "NetTraffic"
    Private Sub bsiVPNStatus_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bsiVPNStatus.ItemDoubleClick
        If bsiVPNStatus.Caption = "VPN On" Then
            Dim Query As String = ""
            Query = "rasdial.exe ""SigmaTEK VPN"" /disconnect"
            Dim batpath As String = Application.LocalUserAppDataPath & "\VPN.BAT"
            Dim sw As New System.IO.StreamWriter(batpath, False, System.Text.Encoding.GetEncoding(GblEncoding))
            sw.Write(Query)
            sw.Close()
            Process.Start(batpath)
        Else
            Dim Query As String = ""
            Query = "rasphone.exe -d ""SigmaTEK VPN"""
            Dim batpath As String = Application.LocalUserAppDataPath & "\VPN.BAT"
            Dim sw As New System.IO.StreamWriter(batpath, False, System.Text.Encoding.GetEncoding(GblEncoding))
            sw.Write(Query)
            sw.Close()
            Process.Start(batpath)
        End If
    End Sub
    Private Sub bsiGDriveStatus_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bsiGDriveStatus.ItemDoubleClick
        If bsiGDriveStatus.Caption = "GDrive Off" Then
            Try
                Process.Start("C:\Program Files (x86)\Google\Drive\googledrivesync.exe")
            Catch ex As Exception

            End Try
        End If
    End Sub
    Public Function BytesConverter(ByVal bytes As Long) As String
        Dim KB As Long = 1024
        Dim MB As Long = KB * KB
        Dim GB As Long = KB * KB * KB
        Dim TB As Long = KB * KB * KB * KB
        Dim returnVal As String = "0 Bytes"

        Select Case bytes
            Case Is <= KB
                returnVal = bytes & " Bytes"
            Case Is > TB
                returnVal = (bytes / KB / KB / KB / KB).ToString("0.00") & " TB"
            Case Is > GB
                returnVal = (bytes / KB / KB / KB).ToString("0.00") & " GB"
            Case Is > MB
                returnVal = (bytes / KB / KB).ToString("0.00") & " MB"
            Case Is > KB
                returnVal = (bytes / KB).ToString("0.00") & " KB"
        End Select

        Return returnVal.ToString
    End Function
    Private Function FormatBString(ByVal FString As String) As String
        Dim TmpStr As String = ""
        TmpStr = Microsoft.VisualBasic.Right("          " & FString, 10)
        FormatBString = TmpStr
    End Function
    Delegate Sub AddNetStatusDelegate(ByVal CheckItem As String, ByVal Online As Boolean)
    Public Sub AddNetStatus(ByVal CheckItem As String, ByVal Online As Boolean)
        Select Case CheckItem
            Case "INTERNET"
                If Online = False Then
                    bsiStatus.Caption = "Offline"
                    bsiStatus.ItemAppearance.Normal.ForeColor = Color.Red
                    clbSource.BackColor = Color.MistyRose
                Else
                    bsiStatus.Caption = "Online"
                    bsiStatus.ItemAppearance.Normal.ForeColor = Color.Green
                    clbSource.BackColor = Color.FromArgb(192, 255, 192)
                End If
            Case "VPN"
                If Online = False Then
                    bsiVPNStatus.Caption = "VPN Off"
                    bsiVPNStatus.ItemAppearance.Normal.ForeColor = Color.Red
                    clbVPNItems.BackColor = Color.MistyRose
                Else
                    bsiVPNStatus.Caption = "VPN On"
                    bsiVPNStatus.ItemAppearance.Normal.ForeColor = Color.Green
                    clbVPNItems.BackColor = Color.FromArgb(192, 255, 192)
                End If
            Case "GDRIVE"
                If Online = False Then
                    bsiGDriveStatus.Caption = "GDrive Off"
                    bsiGDriveStatus.ItemAppearance.Normal.ForeColor = Color.Red
                Else
                    bsiGDriveStatus.Caption = "GDrive On"
                    bsiGDriveStatus.ItemAppearance.Normal.ForeColor = Color.Green
                End If
        End Select
    End Sub
    Private Sub CheckNetStatus()
        Dim cmd As New OleDb.OleDbCommand
        Dim connUsers As System.Data.OleDb.OleDbConnection
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers
        Try
            connUsers.Open()
            IsSQL = True
        Catch ex As Exception
            connUsers.Close()
            IsSQL = False
        Finally
            connUsers.Close()
        End Try
        Try
            If CheckForInternetConnection() = False Then
                IsNet = False
            Else
                IsNet = True
            End If
            If Me.clbSource.InvokeRequired Then
                Me.clbSource.Invoke(New AddNetStatusDelegate(AddressOf AddNetStatus), New Object() {"INTERNET", IsNet})
            Else
                Me.AddNetStatus("INTERNET", IsNet)
            End If
            If CheckForVPN() = False Then
                IsVPN = False
            Else

                IsVPN = True
            End If
            If Me.clbVPNItems.InvokeRequired Then
                Me.clbVPNItems.Invoke(New AddNetStatusDelegate(AddressOf AddNetStatus), New Object() {"VPN", IsVPN})
            Else
                Me.AddNetStatus("VPN", IsVPN)
            End If
            If CheckForGDriveProcess() = False Then
                IsGDrive = False
            Else
                IsGDrive = True
            End If
            If Me.clbSource.InvokeRequired Then
                Me.clbSource.Invoke(New AddNetStatusDelegate(AddressOf AddNetStatus), New Object() {"GDRIVE", IsGDrive})
            Else
                AddNetStatus("GDRIVE", IsGDrive)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BandwidthUpdateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BandwidthUpdateTimer.Tick
        ISthrd = New System.Threading.Thread(AddressOf CheckNetStatus)
        ISthrd.Start()
    End Sub
    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.co.jp")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Public Shared Function CheckForVPN() As Boolean
        Try
            If My.Computer.Network.Ping("10.0.0.17") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    Private Shared Function CheckForGDriveProcess()
        Dim GDriveOn As Boolean = False
        For Each prog As Process In Process.GetProcesses
            If InStr(1, UCase(prog.ProcessName), "GOOGLEDRIVESYNC", CompareMethod.Text) > 0 Then
                GDriveOn = True
            End If
        Next
        Return GDriveOn
    End Function
#End Region
#Region "Settings"
    Private Sub LoadSettingColumns()
        Dim i As Integer = 0
        data15 = New DataTable("gvSetting")
        data15.Clear()
        data15.BeginInit()
        AddColumn(data15, "Description", System.Type.GetType("System.String"))
        AddColumn(data15, "SettingValue", System.Type.GetType("System.String"))
        AddColumn(data15, "Section", System.Type.GetType("System.String"))
        AddColumn(data15, "Key", System.Type.GetType("System.String"))
        data15.EndInit()

        gcSettings.DataSource = data15
        gcSettings.DefaultView.PopulateColumns()
        gvSettings.Columns(2).Visible = False
        gvSettings.Columns(3).Visible = False
        gvSettings.Columns(0).OptionsColumn.AllowEdit = False
        gvSettings.Columns.ColumnByFieldName("Description").Caption = "設定名"
        gvSettings.Columns.ColumnByFieldName("SettingValue").Caption = "設定値"

        data16 = New DataTable("gvLSetting")
        data16.Clear()
        data16.BeginInit()
        AddColumn(data16, "Description", System.Type.GetType("System.String"))
        AddColumn(data16, "SettingValue", System.Type.GetType("System.String"))
        AddColumn(data16, "Section", System.Type.GetType("System.String"))
        AddColumn(data16, "Key", System.Type.GetType("System.String"))
        data16.EndInit()

        gcLSettings.DataSource = data16
        gcLSettings.DefaultView.PopulateColumns()
        gvLSettings.Columns(2).Visible = False
        gvLSettings.Columns(3).Visible = False
        gvLSettings.Columns(0).OptionsColumn.AllowEdit = False
        gvLSettings.Columns.ColumnByFieldName("Description").Caption = "私の設定名"
        gvLSettings.Columns.ColumnByFieldName("SettingValue").Caption = "私の設定値"
    End Sub
    Private Sub gvSettings_CustomDrawRow(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvSettings.CustomDrawCell
        If e.Column.FieldName = "Description" Then
            e.Column.AppearanceCell.BackColor = Color.Beige
        End If
    End Sub
    Private Sub gvLSettings_CustomDrawRow(sender As Object, e As RowCellCustomDrawEventArgs) Handles gvLSettings.CustomDrawCell
        If e.Column.FieldName = "Description" Then
            e.Column.AppearanceCell.BackColor = Color.Beige
        End If
    End Sub
    Private Sub gcSettings_DoubleClick(sender As Object, e As EventArgs) Handles gcSettings.DoubleClick
        If gvSettings.SelectedRowsCount > 0 Then
            FolderBrowserDialog1.SelectedPath = gvSettings.GetRowCellValue(gvSettings.GetSelectedRows(0), "SettingValue")
            If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
                gvSettings.SetRowCellValue(gvSettings.GetSelectedRows(0), "SettingValue", FolderBrowserDialog1.SelectedPath & "\")
            End If
        End If
    End Sub
    Private Sub gvLSettings_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gvLSettings.CustomRowCellEdit
        If e.Column.FieldName = "SettingValue" Then
            Dim gv As GridView = sender
            If e.RowHandle = 5 Then
                e.RepositoryItem = riPassword
            End If
        End If
    End Sub
#End Region
#Region "Database"

    Private Sub ExecuteNonQuery(Query As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim connUsers As System.Data.OleDb.OleDbConnection
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SNDBString
        cmd.Connection = connUsers
        Try
            connUsers.Open()
            cmd.CommandText = Query
            cmd.Connection = connUsers
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            connUsers.Close()
        Finally
            connUsers.Close()
        End Try
    End Sub
    Private Sub RExecuteNonQuery(Query As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim connUsers As System.Data.OleDb.OleDbConnection
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers
        Try
            connUsers.Open()
            cmd.CommandText = Query
            cmd.Connection = connUsers
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            connUsers.Close()
        Finally
            connUsers.Close()
        End Try
    End Sub
    Private Sub SimExecuteNonQuery(Query As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim connUsers As System.Data.OleDb.OleDbConnection
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SimDBString
        cmd.Connection = connUsers
        Try
            connUsers.Open()
            cmd.CommandText = Query
            cmd.Connection = connUsers
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            connUsers.Close()
        Finally
            connUsers.Close()
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
#Region "CommonTools"
    Dim currentCursor As Cursor = Cursor.Current
    Private _waitForm As frmWait
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
            Dim XLoc As Integer = Me.Location.X + (Me.Width / 2) - (_waitForm.Width / 2)
            Dim YLoc As Integer = Me.Location.Y + (Me.Height / 2)
            _waitForm.Location = New Point(XLoc, YLoc)
        Catch ex As Exception

        End Try
        _waitForm.Show()
        _waitForm.Refresh()

        ' force the wait window to display for at least 700ms so it doesn't just flash on the screen
        System.Threading.Thread.Sleep(700)
    End Sub
    Private Function UninstallProgram(ProgramName As String) As Boolean
        Try
            Dim mos As New ManagementObjectSearcher((Convert.ToString("SELECT * FROM Win32_Product WHERE Name = '") & ProgramName) + "'")
            For Each mo As ManagementObject In mos.[Get]()
                Try
                    If mo("Name").ToString() = ProgramName Then
                        Dim hr As Object = mo.InvokeMethod("Uninstall", Nothing)
                        Return CBool(hr)
                    End If
                    'this program may not have a name property, so an exception will be thrown
                Catch ex As Exception
                End Try
            Next

            'was not found...

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub ChangeIni(ByVal IniKey As String, ByVal IniVal As String)

        Try
            Dim IniPath As String = FSNApp.Paths.GetPath(PathID.piIniPath) & "\snconfig.ini"
            Dim ini As New IniFile(IniPath)
            If File.Exists(Application.StartupPath & "\Settings.ini") Then
                Try
                    ini.WriteIni("Paths", IniKey, IniVal)
                Catch ex As Exception

                Finally

                End Try
            Else
                MsgBox(IniPath & "が見つかりません。")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ChangeIni(ByVal IniSection As String, ByVal IniKey As String, ByVal IniVal As String)

        Try
            Dim IniPath As String = FSNApp.Paths.GetPath(PathID.piIniPath) & "\snconfig.ini"
            Dim ini As New IniFile(IniPath)
            If File.Exists(Application.StartupPath & "\Settings.ini") Then
                Try
                    ini.WriteIni(IniSection, IniKey, IniVal)
                Catch ex As Exception

                Finally

                End Try
            Else
                MsgBox(IniPath & "が見つかりません。")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ChangeSNIni(ByVal IniFile As String, ByVal IniSection As String, ByVal IniKey As String, ByVal IniVal As String)
        Dim IniPath As String = IniFile
        Dim ini As New IniFile(IniPath)
        Try
            ini.WriteIni(IniSection, IniKey, IniVal)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
#End Region
#Region "AutoTest"
    Private Sub gv_SigmaNEST(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvSigmaNEST.MouseUp
        If e.Button = MouseButtons.Right Then
            Me.cmsAutoTest.Show(gcSigmaNEST, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub PrepareAutoTest()
        Dim AutoTestIniPath As String = ""
        Dim SettingPath As String = SigmanestDataPath & "AutoRun\"
        Dim SettingCopyPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\SigmaTEK\AutoRun\"
        Dim SigmaNESTPath As String = ""
        Try
            If File.Exists(SettingPath & "Settings\AutoRun.ini") Then
                If Directory.Exists(SettingCopyPath) = False Then
                    Directory.CreateDirectory(SettingCopyPath)
                End If
                File.Copy(SettingPath & "Settings\AutoRun.ini", SettingCopyPath & "AutoRun.ini", True)
            End If
            If gvSigmaNEST.SelectedRowsCount > 0 Then
                Dim BuildName As String = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "BuildName").ToString
                SigmaNESTPath = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "SigmaNESTPath").ToString
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "SigmaNESTPath", SigmaNESTPath)
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "ResultsPath", SettingPath & "Results\" & BuildName)
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "controlDataPath", SettingPath)
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "SetupPath", SettingPath & "Setup\")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "PackandSendPath", SettingPath & "AutoRun\")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "WOLPath", SettingPath & "WOL\")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "LocalPath", SettingPath & "WOL\TMPWOL\")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "PostPath", SettingPath & "PostFiles\")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Path", "DataSetPath", SettingPath & "DataSets\")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "CSVPath", "CSVPath1", SettingPath & "CSV\,1,1")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Server", "TempInstallPath", SettingPath & "TEMP\")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Server", "UserXMLFile", SettingPath & "TEMP\Users.xml")
                ChangeSNIni(SettingCopyPath & "AutoRun.ini", "Server", "BaseResultPath", SettingPath & "Results\")
                Dim SNIniPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\SigmaTEK\" & BuildName & "\IniFiles\AutoRun\"
                Dim SNCopyPath As String = SettingPath & "Settings\AutoRun\"
                If Directory.Exists(SNCopyPath) Then
                    My.Computer.FileSystem.CopyDirectory(SNCopyPath, SNIniPath, True)
                End If
                Dim AutoRunPath As String = SettingPath & "AutoRun\AutoTest.exe"
                If File.Exists(AutoRunPath) Then
                    Process.Start(AutoRunPath)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub ttsRunAutotest_Click(sender As Object, e As EventArgs) Handles ttsRunAutotest.Click
        PrepareAutoTest()
    End Sub
#End Region
#Region "Customer"
    Private Sub LoadCustomerColumns()
        Dim i As Integer = 0
        data = New DataTable("gvCustomer")
        data.Clear()
        data.BeginInit()
        AddColumn(data, "CustomerName", System.Type.GetType("System.String"))
        AddColumn(data, "ModifyDate", System.Type.GetType("System.String"))
        AddColumn(data, "CustomerPath", System.Type.GetType("System.String"))
        data.EndInit()

        gcCustomer.DataSource = data
        gcCustomer.DefaultView.PopulateColumns()
        gvCustomer.Columns(0).Width = 150
        gvCustomer.Columns(1).Width = 150
        gvCustomer.Columns(2).Visible = False
        gvCustomer.Columns.ColumnByFieldName("CustomerName").Caption = "顧客名"
        gvCustomer.Columns.ColumnByFieldName("ModifyDate").Caption = "編集日"
        gvCustomer.Columns.ColumnByFieldName("CustomerPath").Caption = "パス"
    End Sub
    Private Sub LoadCustomerDetailsColumns()
        Dim i As Integer = 0
        data19 = New DataTable("gvCustomerDetails")
        data19.Clear()
        data19.BeginInit()

        AddColumn(data19, "Company", System.Type.GetType("System.String"))
        AddColumn(data19, "Address", System.Type.GetType("System.String"))
        AddColumn(data19, "Telephone", System.Type.GetType("System.String"))
        AddColumn(data19, "EMail", System.Type.GetType("System.String"))
        AddColumn(data19, "Website", System.Type.GetType("System.String"))
        AddColumn(data19, "Business", System.Type.GetType("System.String"))
        AddColumn(data19, "Title", System.Type.GetType("System.String"))
        AddColumn(data19, "Name", System.Type.GetType("System.String"))
        data19.EndInit()

        gcCustomerDetail.DataSource = data19
        gcCustomerDetail.DefaultView.PopulateColumns()
        cvCustomerDetail.OptionsView.ShowQuickCustomizeButton = False
        cvCustomerDetail.CardCaptionFormat = "{8}"
        cvCustomerDetail.Columns("EMail").ColumnEdit = riCardLink
        cvCustomerDetail.Columns("Website").ColumnEdit = riCardURL
        cvCustomerDetail.Columns.ColumnByFieldName("Company").Caption = "会社名"
        cvCustomerDetail.Columns.ColumnByFieldName("Address").Caption = "住所"
        cvCustomerDetail.Columns.ColumnByFieldName("Telephone").Caption = "電話番号"
        cvCustomerDetail.Columns.ColumnByFieldName("EMail").Caption = "Eメール"
        cvCustomerDetail.Columns.ColumnByFieldName("Website").Caption = "URL"
        cvCustomerDetail.Columns.ColumnByFieldName("Business").Caption = "部署"
        cvCustomerDetail.Columns.ColumnByFieldName("Title").Caption = "役職"
        cvCustomerDetail.Columns.ColumnByFieldName("Name").Caption = "名前"
        '.ColumnEdit = riCombo
    End Sub
    Private Sub CreateDirList()
        GblDirList.Clear()
        Try
            If Directory.Exists(CustomerDataPath) Then
                For Each Dir As String In Directory.GetDirectories(CustomerDataPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    GblDirList.Add(dra.Name)
                Next
            End If
            If Directory.Exists(ProspectDataPath) Then
                For Each Dir As String In Directory.GetDirectories(ProspectDataPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    GblDirList.Add(dra.Name)
                Next
            End If
            If Directory.Exists(PartnerDataPath) Then
                For Each Dir As String In Directory.GetDirectories(PartnerDataPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    GblDirList.Add(dra.Name)
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadCustomerData()

        data.Clear()
        If bbiSalesMode.Down = True Then
            If Directory.Exists(ProspectDataPath) Then
                For Each Dir As String In Directory.GetDirectories(ProspectDataPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    data.Rows.Add(dra.Name, dra.LastAccessTime, dra.FullName)
                Next
            Else
                MsgBox("Google Driveのパスを変更して下さい。")
            End If
        ElseIf bbiPartnerMode.Down = True Then
            If Directory.Exists(PartnerDataPath) Then
                For Each Dir As String In Directory.GetDirectories(PartnerDataPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    data.Rows.Add(dra.Name, dra.LastAccessTime, dra.FullName)
                Next
            Else
                MsgBox("Google Driveのパスを変更して下さい。")
            End If
        ElseIf bbiMasterPost.Down = True Then
            If Directory.Exists(PostDataPath) Then
                For Each Dir As String In Directory.GetDirectories(PostDataPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    data.Rows.Add(dra.Name, dra.LastAccessTime, dra.FullName)
                Next
            Else
                MsgBox("Google Driveのパスを変更して下さい。")
            End If
        Else
            If Directory.Exists(CustomerDataPath) Then
                For Each Dir As String In Directory.GetDirectories(CustomerDataPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    data.Rows.Add(dra.Name, dra.LastAccessTime, dra.FullName)
                Next
            Else
                MsgBox("Google Driveのパスを変更して下さい。")
            End If
        End If
        If gvCustomer.RowCount > 0 Then
            gvCustomer.SelectRow(0)
        End If
        CreateDirList()
    End Sub
    Public Shared Sub DeleteDirectory(target_dir As String)
        Dim files As String() = Directory.GetFiles(target_dir)
        Dim dirs As String() = Directory.GetDirectories(target_dir)

        For Each file__1 As String In files
            File.SetAttributes(file__1, FileAttributes.Normal)
            File.Delete(file__1)
        Next

        For Each dir As String In dirs
            DeleteDirectory(dir)
        Next

        Directory.Delete(target_dir, False)
    End Sub
    Private Sub DeleteOldBackups(ByVal CustomerPath As String)
        Try
            For Each Dir As String In Directory.GetDirectories(CustomerPath)
                Dim dra As New System.IO.DirectoryInfo(Dir)
                Select Case dra.Name
                    Case "PostFiles", "Reports", "Tools"
                        Dim NFilePath As String = dra.FullName
                        For Each Dir2 As String In Directory.GetDirectories(NFilePath)
                            Dim dra2 As New System.IO.DirectoryInfo(Dir2)
                            If InStr(1, dra2.Name, "Backup-", CompareMethod.Text) > 0 Then
                                Dim TmpArr() As String
                                TmpArr = Split(dra2.Name, "-")
                                Dim DateFmt As String = Microsoft.VisualBasic.Left(TmpArr(1), 4) & "/" & Microsoft.VisualBasic.Mid(TmpArr(1), 5, 2) & "/" & Microsoft.VisualBasic.Right(TmpArr(1), 2)
                                Dim result As Integer = DateDiff(DateInterval.Day, Date.Today, CDate(DateFmt))
                                If result < -30 Then
                                    Try
                                        DeleteDirectory(dra2.FullName & "\")
                                        Directory.Delete(dra2.FullName)
                                    Catch ex As Exception

                                    End Try
                                End If
                            End If
                        Next
                End Select
            Next
        Catch ex As Exception

        End Try

    End Sub
  
    Private Sub BackupFiles(ByVal SelPath As String)
        Dim BackupPath As String = ""
        Dim DateFmt As String = "Backup-" & Microsoft.VisualBasic.Right("0000" & Date.Today.Year, 4) & Microsoft.VisualBasic.Right("00" & Date.Today.Month, 2) & Microsoft.VisualBasic.Right("00" & Date.Today.Day, 2)
        BackupPath = SelPath & DateFmt & "\"
        If Directory.Exists(BackupPath) = False Then
            Directory.CreateDirectory(BackupPath)
        End If
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(BackupPath, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
            My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

        Next
        Dim di As New System.IO.DirectoryInfo(SelPath)
        Dim diar1 As System.IO.FileInfo() = di.GetFiles()
        Dim dra As System.IO.FileInfo

        Dim CFileName As String = ""
        'list the names of all files in the specified directory
        For Each dra In diar1
            CFileName = BackupPath & dra.Name
            Try
                File.Copy(dra.FullName, CFileName)
            Catch ex As Exception

            End Try

        Next
    End Sub
    Dim OldPostPath As String = ""
    Dim OldReplacePath As String = ""
    Dim OldReportsPath As String = ""
    Dim OldToolsPath As String = ""
    Private Sub ttsAboutLicense_Click(sender As Object, e As EventArgs)
        ConnectToCOM()
        ChangeIni("SYSTEM OPTIONS", "About", 1)
        FSNApp.ReLoadConfig()
        MsgBox("ABOUT設定を変更しました")
    End Sub
    Private Sub SetSigmanestPaths()
        Dim CheckedItem As String = ""
        Dim SelPath As String = GblCustomerPath
        Dim IniPath As String = ""
        If GblCustomerPath <> "" Then
            Dim result2 As Integer = MessageBox.Show(Path.GetFileNameWithoutExtension(GblCustomerPath) & " のパス設定を変更して良いでしょうか？", "パス設定", MessageBoxButtons.YesNo)
            If result2 = DialogResult.Yes Then
                Try
                    ConnectToCOM()
                    For Each li As CheckedListBoxItem In clbSigmanest.Items
                        CheckedItem = UCase(li.Value)

                        If li.CheckState = 1 Then
                            Select Case CheckedItem
                                Case "DESKTOPS"

                                Case "INIFILES"

                                Case "NESTINGINIFILES"
                                    Dim SigmaIni As String = ""
                                    SelPath = GblCustomerPath & "\" & CheckedItem & "\Nesting2.ini"
                                    If gvSigmaNEST.SelectedRowsCount > 0 Then
                                        Dim BuildName As String = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "BuildName").ToString
                                        SigmaIni = "C:\ProgramData\SigmaTEK\" & BuildName & "\nesting2.ini"
                                        File.Copy(SelPath, SigmaIni, True)
                                        FSNApp.ReLoadConfig()
                                    Else
                                        MsgBox("変更するシグマネストのビルドを選択して下さい。")
                                    End If
                                Case "POSTFILES"
                                    OldPostPath = FSNApp.Paths.GetPath(PathID.piPostPath)
                                    SelPath = GblCustomerPath & "\" & CheckedItem & "\"
                                    BackupFiles(SelPath)
                                    ChangeIni("PostPath", SelPath)
                                    FSNApp.ReLoadConfig()
                                Case "REPLACEFILES", "REPLACE"
                                    OldReplacePath = FSNApp.Paths.GetPath(PathID.piDataPath) & "Replace"
                                    SelPath = GblCustomerPath & "\" & CheckedItem & "\"
                                    BackupFiles(SelPath)
                                    ChangeIni("ReplacePattenPath", SelPath)
                                    FSNApp.ReLoadConfig()
                                Case "REPORTS"
                                    OldReportsPath = FSNApp.Paths.GetPath(PathID.piReportPath)
                                    SelPath = GblCustomerPath & "\" & CheckedItem & "\"
                                    BackupFiles(SelPath)
                                    ChangeIni("ReportPath", SelPath)
                                    FSNApp.ReLoadConfig()
                                Case "TOOLS"
                                    OldReportsPath = FSNApp.Paths.GetPath(PathID.piToolsPath)
                                    SelPath = GblCustomerPath & "\" & CheckedItem & "\"
                                    BackupFiles(SelPath)
                                    ChangeIni("ToolsPath", SelPath)
                                    FSNApp.ReLoadConfig()
                                Case "DBASE", "DATABASE"
                                    Dim Query As String = ""
                                    Query = "DELETE FROM Tool"
                                    Dim result As Integer = MessageBox.Show("ツールデータベースをクリアして良いですか？", "ツールデータベース", MessageBoxButtons.YesNo)
                                    If result = DialogResult.Yes Then
                                        ExecuteNonQuery(Query)
                                        SelPath = GblCustomerPath & "\" & CheckedItem & "\"
                                        Query = "bcp " & SNCatalog & ".dbo.tool in """ & SelPath & "tool.sndbase"" -b 100000 -f """ & SelPath & "tool.fmt"" -S " & SNDatabasePath & " -U " & SNUserID & " -P " & SNPassword
                                        Dim sw As New System.IO.StreamWriter(SelPath & "Tool.BAT", False, System.Text.Encoding.GetEncoding(GblEncoding))
                                        sw.Write(Query)
                                        sw.Close()
                                        Process.Start(SelPath & "Tool.BAT")
                                    End If

                            End Select
                        End If
                    Next
                    MsgBox("設定変更しました。")
                Catch ex As Exception
                    MsgBox("シグマネストに接続できませんでした。再度SigmaAPPを立ち上げなおして下さい。")
                End Try
            End If
        Else
            MsgBox("顧客を選択して下さい。")
        End If
    End Sub
    Private Sub UndoSigmanestPath()
        If OldPostPath <> "" Then
            ChangeIni("PostPath", OldPostPath)
        End If
        If OldReportsPath <> "" Then
            ChangeIni("ReportPath", OldReportsPath)
        End If
        If OldToolsPath <> "" Then
            ChangeIni("ToolsPath", OldToolsPath)
        End If
        If OldReplacePath <> "" Then
            ChangeIni("ReplacePattenPath", OldReplacePath)
        End If


        OldPostPath = ""
        OldReplacePath = ""
        OldReportsPath = ""
        OldToolsPath = ""
        Try
            Dim SIniPath As String = SigmanestDataPath & "Applications\SigmaAPP\INI\Nesting2.ini"
            Dim SigmaIni As String = ""
            If gvSigmaNEST.SelectedRowsCount > 0 Then
                Dim BuildName As String = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "BuildName").ToString
                SigmaIni = "C:\ProgramData\SigmaTEK\" & BuildName & "\nesting2.ini"
            End If
            File.Copy(SIniPath, SigmaIni, True)
            FSNApp.ReLoadConfig()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("元の設定に戻しました。")
    End Sub
    Private Sub ResetSigmanestPath()
        Dim SNDataPath As String = ""
        Try
            ConnectToCOM()
            SNDataPath = FSNApp.Paths.GetPath(PathID.piDataPath)
            ChangeIni("PostPath", SNDataPath & "Post\Samples\")
            ChangeIni("ReportPath", SNDataPath & "Reports90\Japanese\")
            ChangeIni("ToolsPath", SNDataPath & "Tools\")
            ChangeIni("ReplacePattenPath", SNDataPath & "Replace\")
            Try
                Dim SIniPath As String = SigmanestDataPath & "Applications\SigmaAPP\INI\Nesting2.ini"
                Dim SigmaIni As String = ""
                If gvSigmaNEST.SelectedRowsCount > 0 Then
                    Dim BuildName As String = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "BuildName").ToString
                    SigmaIni = "C:\ProgramData\SigmaTEK\" & BuildName & "\nesting2.ini"
                End If
                File.Copy(SIniPath, SigmaIni, True)
                FSNApp.ReLoadConfig()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("標準の設定に戻しました。")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function GetOutlookAttachment(ByVal e As System.Windows.Forms.DragEventArgs) As String
        Dim theStream As System.IO.Stream = DirectCast(e.Data.GetData("FileGroupDescriptor"), System.IO.Stream)
        Dim fileGroupDescriptor As Byte() = New Byte(511) {}
        theStream.Read(fileGroupDescriptor, 0, 512)
        Dim tempFiles As New ArrayList

        ' used to build the filename from the FileGroupDescriptor block
        Dim fileName As New System.Text.StringBuilder("")

        ' this trick gets the filename of the passed attached file
        Dim i As Integer = 76
        While fileGroupDescriptor(i) <> 0
            fileName.Append(Convert.ToChar(fileGroupDescriptor(i)))
            i += 1
        End While
        theStream.Close()
        Dim path As String = System.IO.Path.GetTempPath()

        ' put the zip file into the temp directory
        Dim theFile As String = path + fileName.ToString()
        tempFiles.Add(theFile)

        Dim ms As System.IO.MemoryStream = DirectCast(e.Data.GetData("FileContents", True), System.IO.MemoryStream)

        ' allocate enough bytes to hold the raw data
        Dim fileBytes As Byte() = New Byte(ms.Length - 1) {}

        ' set starting position at first byte and read in the raw data
        ms.Position = 0
        ms.Read(fileBytes, 0, CInt(ms.Length))

        ' create a file and save the raw zip file to it
        Dim fs As New System.IO.FileStream(theFile, System.IO.FileMode.Create)
        fs.Write(fileBytes, 0, CInt(fileBytes.Length))

        fs.Close()
        ' close the file

        Return theFile
    End Function
    Private Sub CheckSIMFile(ByVal SimNo As String)
        Dim LineItem As String = ""
        Dim SimFile As String = GblCustomerPath & "\SIM.txt"
        Dim SimNoFound As Boolean = False
        If File.Exists(SimFile) Then
            Dim sr As New System.IO.StreamReader(SimFile, System.Text.Encoding.GetEncoding(GblEncoding))
            While sr.Peek() > -1
                LineItem = sr.ReadLine()
                If SimNo = LineItem Then
                    SimNoFound = True
                End If
            End While
            sr.Close()
            If SimNoFound = False Then
                Dim sw As New System.IO.StreamWriter(SimFile, True, System.Text.Encoding.GetEncoding(GblEncoding))
                sw.WriteLine(SimNo)
                sw.Close()
            End If
        Else
            Dim sw As New System.IO.StreamWriter(SimFile, False, System.Text.Encoding.GetEncoding(GblEncoding))
            sw.Close()
            CheckSIMFile(SimNo)
        End If
    End Sub
    Private Sub CreateZipFile(ByVal FilePath As String, ByVal FullPath As String)
        Dim zip As New Chilkat.Zip()
        Dim success As Boolean
        Dim i As Integer = 0

        success = zip.UnlockComponent("RIICHIZIP_r86X7vbw1Stl")
        If (success <> True) Then
            Console.WriteLine(zip.LastErrorText)
            Exit Sub
        End If
        success = zip.NewZip(FullPath & "\" & Path.GetFileNameWithoutExtension(FilePath) & ".zip")
        zip.SetPassword("BestNest1445")
        zip.PasswordProtect = True
        zip.AppendFiles(FilePath, False)
        success = zip.WriteZipAndClose()

    End Sub
    Private Sub ExtractZipFile(ByVal FilePath As String)
        Dim zip As New Chilkat.Zip()
        Dim success As Boolean
        success = zip.UnlockComponent("RIICHIZIP_r86X7vbw1Stl")
        If (success <> True) Then
            Console.WriteLine(zip.LastErrorText)
            Exit Sub
        End If
        success = zip.OpenZip(FilePath)
        zip.DecryptPassword = "BestNest1445"
        zip.Unzip(appData)
        Dim TmpPath As String = appData & "\TMP.PDF"
        Try
            Process.Start(TmpPath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub ProcessFiles(ByVal FilePath As String)
        Dim FExt As String = ""
        Dim FName As String = ""
        Dim FolderPath As String = ""
        FExt = UCase(Path.GetExtension(FilePath))
        FName = Path.GetFileName(FilePath)
        Select Case FExt
            Case ".SIM", ".SNLIC", ".SNLICV3"
                FolderPath = GblCustomerPath & "\SIM\"
            Case ".WS"
                FolderPath = VPNCustomerPath & "\WS\"
            Case Else
                If InStr(1, FName, "JapaneseLA", CompareMethod.Text) > 0 Or InStr(1, FName, "SignedLA", CompareMethod.Text) > 0 Then
                    FolderPath = GblCustomerPath & "\License Agreement\"
                ElseIf InStr(1, FName, "見積", CompareMethod.Text) > 0 Then
                    FolderPath = GblCustomerPath & "\Quote\"
                ElseIf InStr(1, UCase(FName), "INV_", CompareMethod.Text) > 0 Then
                    FolderPath = GblCustomerPath & "\US Invoice\"
                ElseIf InStr(1, FName, "請求書", CompareMethod.Text) > 0 Then
                    FolderPath = GblCustomerPath & "\Invoice\"
                ElseIf InStr(1, FName, "注文書", CompareMethod.Text) > 0 Or InStr(1, FName, "請求書", CompareMethod.Text) > 0 Or InStr(1, UCase(FName), "ORDER", CompareMethod.Text) > 0 Then
                    FolderPath = GblCustomerPath & "\Purchase Order\"
                ElseIf InStr(1, FName, "秘密保持", CompareMethod.Text) > 0 Or InStr(1, UCase(FName), "NDA", CompareMethod.Text) > 0 Then
                    FolderPath = GblCustomerPath & "\Confidentiality Agreement\"
                ElseIf InStr(1, FName, "仕様書", CompareMethod.Text) > 0 Or InStr(1, UCase(FName), "カスタマイズ", CompareMethod.Text) > 0 Then
                    FolderPath = GblCustomerPath & "\Specification\"
                Else
                    If FolderMode = "clbVPNItems" Then
                        FolderPath = VPNCustomerPath & "\Files\"
                    Else
                        FolderPath = GblCustomerPath & "\Documents\"
                    End If
                End If
        End Select
        If Directory.Exists(FolderPath) = False And FolderPath <> "" Then
            Directory.CreateDirectory(FolderPath)
        End If
        File.Copy(FilePath, FolderPath & Path.GetFileName(FilePath), True)
        If FExt = ".SIM" Then
            CheckSIMFile(Path.GetFileNameWithoutExtension(FilePath))
        End If
        If gvCustomer.SelectedRowsCount > 0 Then
            Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
            Dim CustomerPath As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerPath").ToString
            LoadSigmaNESTFiles(CustomerName, CustomerPath)
            LoadCustomerLogFile()
        End If
    End Sub
    Private Sub HandleCustFileDrop(ByVal e As System.Windows.Forms.DragEventArgs)
        Dim IsDir As Boolean = False
        Dim destinationPath As String = appData & "\"
        Dim CopyDirPath As String = ""
        'copy file(s) to destination folder
        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each path In files
                If System.IO.Directory.Exists(path) Then
                    IsDir = True
                    CopyDirPath = path
                    Exit For
                ElseIf System.IO.File.Exists(path) Then
                    CopyDirPath = ""
                    IsDir = False
                End If
            Next
            If GblCustomerPath <> "" Or VPNCustomerPath <> "" Then
                If IsDir = True Then
                    ShowWaitForm("")
                    Dim CopyPath As String = VPNCustomerPath & Path.GetFileNameWithoutExtension(CopyDirPath) & "\"
                    My.Computer.FileSystem.CopyDirectory(CopyDirPath, CopyPath, True)
                    _waitForm.Close()
                Else
                    Dim formats() As String = e.Data.GetFormats()
                    If formats.Contains("FileContents") = False Then Exit Sub

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
                                            Dim TmpPath As String = destinationPath & att_filename
                                            att.SaveAsFile(TmpPath)
                                            ProcessFiles(TmpPath)
                                            File.Delete(TmpPath)
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
                End If
                If gvCustomer.SelectedRowsCount > 0 Then
                    Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
                    Dim CustomerPath As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerPath").ToString
                    LoadSigmaNESTFiles(CustomerName, CustomerPath)
                    LoadCustomerLogFile()
                End If
            Else
                MsgBox("顧客を選択して下さい。")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub clbsource_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles clbSource.DragDrop
        HandleCustFileDrop(e)
    End Sub
    Private Sub clbVPNItems_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles clbVPNItems.DragDrop
        HandleCustFileDrop(e)
    End Sub
    Private Sub clbsource_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles clbSource.DragEnter
        FolderMode = "clbSource"
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
    Private Sub clbVPNItems_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles clbVPNItems.DragEnter
        FolderMode = "clbVPNItems"
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
    Dim SimArr As New ArrayList
    Private Sub ttsSIMMail_Click(sender As Object, e As EventArgs) Handles ttsSIMMail.Click
        Dim FileFound As Boolean = False
        Try
            Dim SimPath As String = GblCustomerPath & "\SIM\"
            If Directory.Exists(SimPath) Then
                Dim di As New System.IO.DirectoryInfo(SimPath)
                Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                Dim dra As System.IO.FileInfo
                For Each dra In diar1
                    If UCase(Path.GetExtension(dra.FullName)) <> ".INI" Then
                        SimArr.Add(dra.FullName)
                        FileFound = True
                    End If
                Next

            End If
        Catch ex As Exception
        Finally
            If FileFound = True Then
                rbnMain.SelectedPage = rpgMail
                xtcMain.SelectedTabPage = tabMail
                bbiMailText.Down = True
                bbiMailMessage.Down = False
                bbiMailTemplate.Down = False
                LoadMailForm()
            Else
                MsgBox("メールするSIMはありません。")
            End If
        End Try
    End Sub
    Private Sub LoadCustomerDataFromDB(ByVal CustomerName As String)  'continue here today
        If IsSQL = False Then Exit Sub
        Try
            Dim EventsGUID As String = ""
            Dim ListID As String = ""
            Dim db_reader As OleDbDataReader
            Dim connUsers As System.Data.OleDb.OleDbConnection
            Dim UName As String = ""
            Dim Company As String = ""
            Dim Department As String = ""
            Dim Title As String = ""
            Dim Telephone As String = ""
            Dim EMail As String = ""
            Dim Website As String = ""
            Dim Address As String = ""
            Dim UpdateDate As Date
            Dim cmd As New OleDb.OleDbCommand
            Dim Query As String = ""
            If IsSQL = False Then Exit Sub
            data19.Clear()
            connUsers = New System.Data.OleDb.OleDbConnection
            connUsers.ConnectionString = SSDBString
            connUsers.Open()
            cmd.Connection = connUsers
            Query = "SELECT * FROM tbl_SNContacts WHERE CompanyLink='" & CustomerName & "' "
            cmd.CommandText = Query
            db_reader = cmd.ExecuteReader(CommandBehavior.Default)
            Do While db_reader.Read
                UName = db_reader.Item("LastName").ToString
                Company = db_reader.Item("Company").ToString
                Department = db_reader.Item("Department").ToString
                Title = db_reader.Item("Title").ToString
                Telephone = db_reader.Item("Telephone").ToString
                EMail = db_reader.Item("EMail").ToString
                Website = db_reader.Item("Website").ToString
                Address = db_reader.Item("Address").ToString
                UpdateDate = db_reader.Item("UpdateDate")
                GblSNInfoLink = db_reader.Item("SNInfoLink").ToString
                data19.Rows.Add(Company, Address, Telephone, EMail, Website, Department, Title, UName)
            Loop

            If data19.Rows.Count > 0 Then
                splCustInfo.Panel2Collapsed = False
            Else
                splCustInfo.Panel2Collapsed = True
            End If

            cmd = Nothing
            connUsers.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub LoadSNInfoHub()
        Dim WebURL As String = ""
        WebURL = "http://info.sigmatek.net/"
        Dim address As New Uri(WebURL)
        wbOverview.Url = address
    End Sub
    Private Sub LoadInfoHubData()
        Dim WebURL As String = ""
        If GblSNInfoLink <> "" Then
            WebURL = "http://info.sigmatek.net/Org/Overview/" & GblSNInfoLink
            Dim address As New Uri(WebURL)
            wbOverview.Url = address
            WebURL = "http://info.sigmatek.net/Helpdesk/Ticket/List/CreatedProblems?Organizations=" & GblSNInfoLink
            address = New Uri(WebURL)
            wbSupport.Url = address
            WebURL = "http://info.sigmatek.net/ProdConfig/Basic/" & GblSNInfoLink
            address = New Uri(WebURL)
            wbMachine.Url = address
        End If
    End Sub
    Private Sub xtcCustomer_DoubleClick(sender As Object, e As EventArgs) Handles xtcCustomer.DoubleClick
        Dim WebURL As String = ""

        If xtcCustomer.SelectedTabPage Is tabOverview Then
            WebURL = "http://info.sigmatek.net/Org/Overview/" & GblSNInfoLink
            Process.Start(WebURL)
        ElseIf xtcCustomer.SelectedTabPage Is tabSupport Then
            WebURL = "http://info.sigmatek.net/Helpdesk/Ticket/List/CreatedProblems?Organizations=" & GblSNInfoLink
            Process.Start(WebURL)
        ElseIf xtcCustomer.SelectedTabPage Is tabMachine Then
            WebURL = "http://info.sigmatek.net/ProdConfig/Basic/" & GblSNInfoLink
            Process.Start(WebURL)
        ElseIf xtcCustomer.SelectedTabPage Is tabTicket Then
            WebURL = "http://info.sigmatek.net/"
            Process.Start(WebURL)
        End If

    End Sub
    Private Sub gvCustomer_FocusedRowChanged(sender As System.Object, e As System.EventArgs) Handles gvCustomer.FocusedRowChanged
        Try
            GblCustomerPath = ""
            If gvCustomer.SelectedRowsCount > 0 Then
                Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
                Dim CustomerPath As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerPath").ToString
                Dim split As String() = CustomerPath.Split("\")
                Dim parentFolder As String = split(0) & "\" & split(1) & "\"
                VPNCustomerPath = Replace(CustomerPath, parentFolder, VPNRootPath) & "\"
                LoadSigmaNESTFiles(CustomerName, CustomerPath)
                DeleteOldBackups(CustomerPath)
                LoadCustomerDataFromDB(CustomerName)
                LoadCustomerLogFile()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            LoadInfoHubData()
        End Try
    End Sub
    Private Sub gcCustomer_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gcCustomer.DoubleClick
        SetSigmanestPaths()
    End Sub
    Private Sub ttsOpenCustomerFolder_Click(sender As Object, e As EventArgs) Handles ttsOpenCustomerFolder.Click
        If FolderMode = "clbSigmanest" Then
            Process.Start(GblCustomerPath & "\" & clbSigmanest.SelectedValue)
        ElseIf FolderMode = "clbSource" Then
            Process.Start(GblCustomerPath & "\" & clbSource.SelectedValue)
        ElseIf FolderMode = "clbVPNItems" Then
            Process.Start(VPNCustomerPath & "\" & clbVPNItems.SelectedValue & "\")
        Else
            Process.Start(GblCustomerPath)
        End If

    End Sub
    Private Sub meTikDescription_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles meTikDescription.MouseUp
        If e.Button = MouseButtons.Right Then
            Me.cmsShortcuts.Show(meTikDescription, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub ttsCreateExpenses_Click(sender As Object, e As EventArgs) Handles ttsCreateExpenses.Click
        If gvCustomer.SelectedRowsCount > 0 Then
            Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
            cmbExCustomer.Text = CustomerName
            xtcMain.SelectedTabPage = tabExpenses
            rbnMain.SelectedPage = rpExpenses
        End If
    End Sub
    Private Sub meTikDescription_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles meTikDescription.DragDrop

        Try
            splMailMain.Collapsed = False
            If Not e.Data.GetDataPresent(DataFormats.Text) = False Then
                'check if this is an outlook message. The outlook messages, all contain a FileContents attribute. If not, exit.
                Dim formats() As String = e.Data.GetFormats()

                If formats.Contains("FileContents") = False Then Exit Sub

                'they are dragging the attachment
                If (e.Data.GetDataPresent("Object Descriptor")) Then
                    Dim app As New Microsoft.Office.Interop.Outlook.Application() ' // get current selected items
                    Dim selection As Microsoft.Office.Interop.Outlook.Selection
                    Dim myText As String = ""
                    Dim Attachments As New ArrayList
                    Dim FullAttachments As New ArrayList
                    Attachments.Clear()
                    FullAttachments.Clear()

                    selection = app.ActiveExplorer.Selection
                    If selection IsNot Nothing Then

                        Dim mailItem As Microsoft.Office.Interop.Outlook._MailItem
                        For i As Integer = 0 To selection.Count - 1
                            Dim Subject As String = ""
                            Dim ReceiveTime As String = ""
                            Dim Body As String = ""
                            Dim BodyFmt As String = ""
                            Dim ReceivedBy As String = ""
                            mailItem = TryCast(selection.Item(i + 1), Microsoft.Office.Interop.Outlook._MailItem)
                            If mailItem IsNot Nothing Then
                                Try
                                    myText = ""
                                    Subject = mailItem.Subject
                                    ReceivedBy = mailItem.ReceivedByName
                                    ReceiveTime = mailItem.ReceivedTime.ToShortDateString
                                    BodyFmt = Replace(mailItem.Body, vbCrLf & vbCrLf, vbCrLf)
                                    Body = "FROM : " & mailItem.SenderName & vbCrLf & vbCrLf & BodyFmt  'Plain Text Body Message
                                    txtTikTitle.Text = Subject
                                    meTikDescription.Text = Body
                                    meTikSolution.Text = "メールサポートにより問題解決。"
                                    chkTikClosed.Checked = True
                                Catch ex As System.Exception
                                Finally
                                    Marshal.ReleaseComObject(mailItem)
                                End Try

                            End If
                        Next
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub meTikDescription_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles meTikDescription.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
#End Region
#Region "CustomerLog"
    Private Sub gvCustomerLog_CalcRowHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles gvCustomerLog.CalcRowHeight
        If e.RowHeight > 75 Then
            e.RowHeight = 75
        End If
    End Sub
    Private Sub LoadCustomerLogColumns()
        Dim i As Integer = 0
        data2 = New DataTable("gvCustomerLog")
        data2.Clear()
        data2.BeginInit()
        AddColumn(data2, "LogDate", System.Type.GetType("System.String"))
        AddColumn(data2, "Detail", System.Type.GetType("System.String"))
        AddColumn(data2, "LogItem", System.Type.GetType("System.String"))
        AddColumn(data2, "SInd", System.Type.GetType("System.Int32"))
        AddColumn(data2, "FInd", System.Type.GetType("System.Int32"))
        data2.EndInit()

        gcCustomerLog.DataSource = data2
        gcCustomerLog.DefaultView.PopulateColumns()
        gvCustomerLog.Columns(0).Width = 100
        gvCustomerLog.Columns(1).Width = 70
        gvCustomerLog.Columns(2).Width = 500
        gvCustomerLog.Columns(3).Visible = False
        gvCustomerLog.Columns(4).Visible = False
        gvCustomerLog.Columns(0).OptionsColumn.AllowEdit = False
        gvCustomerLog.Columns(1).OptionsColumn.AllowEdit = True
        gvCustomerLog.Columns(2).OptionsColumn.AllowEdit = False
        gvCustomerLog.Columns.ColumnByFieldName("LogDate").Caption = "日付"
        gvCustomerLog.Columns.ColumnByFieldName("Detail").Caption = "詳細"
        gvCustomerLog.Columns.ColumnByFieldName("LogItem").Caption = "アイテム"
    End Sub
    Private Sub LoadCustomerLogFile()
        Dim CustomerFile As String = GblCustomerPath & "\CustomerLog.txt"
        Dim AboutFile As String = GblCustomerPath & "\About.txt"
        Dim SimFile As String = GblCustomerPath & "\SIM.txt"
        Dim MachineFile As String = GblCustomerPath & "\Machine.txt"
        Dim LineItem As String = ""
        Dim DateStr As String = ""
        Dim MessageStr As String = ""
        Dim QAStr As String = ""
        Dim NewMessage As Boolean = False
        Dim StartIndex As Integer = 0
        Dim FinIndex As Integer = 0
        Dim LineCnt As Integer = 0
        data2.Clear()
        txtMaintenance.Text = ""
        txtSIMVersion.Text = ""
        SimArr.Clear()
        Dim QAFound As Boolean = False
        Try
            If File.Exists(CustomerFile) Then
                Dim sr As New System.IO.StreamReader(CustomerFile, System.Text.Encoding.GetEncoding(GblEncoding))
                While sr.Peek() > -1
                    LineItem = sr.ReadLine()
                    LineCnt += 1
                    If InStr(1, LineItem, "#", CompareMethod.Text) > 0 Then
                        DateStr = Replace(LineItem, "#", "")
                        MessageStr = ""
                        QAStr = ""
                        NewMessage = True
                        StartIndex = LineCnt
                        QAFound = False
                    End If
                    Do While NewMessage = True And LineItem <> "E$" And (sr.EndOfStream = False)
                        LineItem = sr.ReadLine()
                        LineCnt += 1
                        If InStr(1, LineItem, "QA:", CompareMethod.Text) > 0 Then
                            QAStr = LineItem
                            QAFound = True
                        ElseIf InStr(1, LineItem, "SIM:", CompareMethod.Text) > 0 Then
                            QAStr = LineItem
                        ElseIf InStr(1, LineItem, "T$", CompareMethod.Text) > 0 And QAFound = False Then
                            QAStr = Microsoft.VisualBasic.Right(LineItem, Len(LineItem) - 2)
                        ElseIf InStr(1, LineItem, "T$", CompareMethod.Text) > 0 And QAFound = True Then

                        ElseIf InStr(1, LineItem, "E$", CompareMethod.Text) = 0 Then
                            MessageStr = MessageStr & LineItem & vbCrLf
                        Else
                            NewMessage = False
                            FinIndex = LineCnt
                            If QAFound = True Then
                                MessageStr = GetQAInfo(QAStr, "DefectName")
                            End If
                            data2.Rows.Add(DateStr, QAStr, MessageStr, StartIndex, FinIndex)
                        End If
                    Loop

                End While
                sr.Close()
            Else
                Dim sw As New System.IO.StreamWriter(CustomerFile, False, System.Text.Encoding.GetEncoding(GblEncoding))
                sw.Close()
            End If
            deMaintenance.Text = ""
            txtVersion.Text = ""
            deMaintenance.BackColor = Color.White
            If File.Exists(AboutFile) Then
                Dim sr As New System.IO.StreamReader(AboutFile, System.Text.Encoding.GetEncoding(GblEncoding))
                While sr.Peek() > -1
                    LineItem = sr.ReadLine()
                    If InStr(1, LineItem, "0001", CompareMethod.Text) > 0 Then
                        deMaintenance.Text = ""
                    Else
                        deMaintenance.DateTime = CDate(LineItem)
                        Dim result As Integer = DateDiff(DateInterval.Day, Date.Today, deMaintenance.DateTime)
                        If result >= 0 Then
                            deMaintenance.BackColor = Color.LightGreen
                        Else
                            deMaintenance.BackColor = Color.Red
                        End If
                    End If
                    LineItem = sr.ReadLine
                    txtVersion.Text = LineItem
                End While
                sr.Close()
            End If
            data13.Clear()
            If File.Exists(SimFile) Then
                Dim sr As New System.IO.StreamReader(SimFile, System.Text.Encoding.GetEncoding(GblEncoding))
                While sr.Peek() > -1
                    LineItem = sr.ReadLine()
                    data13.Rows.Add(LineItem)
                End While
                sr.Close()
                CheckLicenseInfo()
            End If
            data14.Clear()
            If File.Exists(MachineFile) Then
                Dim sr As New System.IO.StreamReader(MachineFile, System.Text.Encoding.GetEncoding(GblEncoding))
                While sr.Peek() > -1
                    LineItem = sr.ReadLine()
                    If InStr(1, LineItem, "+", CompareMethod.Text) > 0 Then
                        Dim TmpStr() As String
                        TmpStr = Split(LineItem, "+")
                        data14.Rows.Add(TmpStr(0), TmpStr(1))
                    Else
                        data14.Rows.Add(LineItem, "")
                    End If
                End While
                sr.Close()
            End If

            gvCustomerLog.MoveLastVisible()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        LoadQACSV()
    End Sub
    Private Sub SaveCustomerLogFile()
        Try
            If meTikDescription.Text <> "" Then

                Dim SelPath As String = GblCustomerPath & "\CustomerLog.txt"
                Dim DateFmt As String = Microsoft.VisualBasic.Right("0000" & Date.Today.Year, 4) & "/" & Microsoft.VisualBasic.Right("00" & Date.Today.Month, 2) & "/" & Microsoft.VisualBasic.Right("00" & Date.Today.Day, 2)
                Dim sw As New System.IO.StreamWriter(SelPath, True, System.Text.Encoding.GetEncoding(GblEncoding))
                sw.Write(vbCrLf)
                sw.WriteLine("#" & DateFmt)
                If txtTikTitle.Text <> "" Then
                    sw.Write("Title:" & txtTikTitle.Text & vbCrLf)
                End If
                sw.Write("Description:" & meTikDescription.Text & vbCrLf)
                If meTikSolution.Text <> "" Then
                    sw.Write("Solution:" & meTikDescription.Text & vbCrLf)
                End If
                sw.WriteLine("T$" & GblMyName)
                sw.WriteLine("E$")
                sw.Close()
                ClearTikItems()
                MsgBox("登録されました。")
                SaveCustomerInfoFile()
                LoadCustomerLogFile()
                meTikDescription.BackColor = Color.White
            Else
                meTikDescription.BackColor = Color.LightPink
            End If
        Catch ex As Exception
            MsgBox("同期中です。再度登録して下さい。")
        End Try

    End Sub
    Private Sub meTikDescription_Click(sender As Object, e As EventArgs) Handles meTikDescription.Click
        meTikDescription.BackColor = Color.White
    End Sub
    Private Sub ttsSaveLog_Click(sender As Object, e As EventArgs) Handles ttsSaveLog.Click
        SaveCustomerLogFile()
    End Sub
    Private Sub ttsDeleteLogItem_Click(sender As Object, e As EventArgs) Handles ttsDeleteLogItem.Click
        Dim LogFile As String = GblCustomerPath & "\CustomerLog.txt"
        Dim LineItem As String = ""
        Dim LogArr As New ArrayList
        Dim LineCnt As Integer = 0
        Dim result As Integer = MessageBox.Show("ログのデータを削除して良いのでしょうか？", "ログ削除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            If gvCustomerLog.SelectedRowsCount > 0 Then
                Try
                    Dim SInd As Integer = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "SInd")
                    Dim FInd As Integer = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "FInd")
                    LogArr.Clear()
                    If File.Exists(LogFile) Then
                        Dim sr As New System.IO.StreamReader(LogFile, System.Text.Encoding.GetEncoding(GblEncoding))
                        While sr.Peek() > -1
                            LineItem = sr.ReadLine()
                            LineCnt += 1
                            If LineCnt >= SInd And LineCnt <= FInd + 1 Then
                                'do nothing
                            Else
                                LogArr.Add(LineItem)
                            End If
                        End While
                        sr.Close()
                        Dim sw As New System.IO.StreamWriter(LogFile, False, System.Text.Encoding.GetEncoding(GblEncoding))
                        For i As Integer = 0 To LogArr.Count - 1
                            If i = LogArr.Count - 1 Then
                                If LogArr(i) <> "" Then

                                    sw.WriteLine(LogArr(i))
                                End If
                            Else
                                sw.WriteLine(LogArr(i))
                            End If
                        Next
                        sw.Close()
                    End If
                Catch ex As Exception

                Finally
                    LoadCustomerLogFile()
                End Try
            End If
        End If
    End Sub
    Private Sub SaveCustomerInfoFile()
        Try
            Dim SelPath As String = GblCustomerPath & "\About.txt"
            Dim sw As New System.IO.StreamWriter(SelPath, False, System.Text.Encoding.GetEncoding(GblEncoding))
            sw.WriteLine(deMaintenance.DateTime.Date)
            sw.WriteLine(txtVersion.Text)
            sw.Close()
        Catch ex As Exception
            MsgBox("同期中です。再度登録して下さい。")
        End Try

    End Sub
    Private Sub LoadSIMColumns()
        Dim i As Integer = 0
        data13 = New DataTable("gvSIM")
        data13.Clear()
        data13.BeginInit()
        AddColumn(data13, "SIMNo", System.Type.GetType("System.String"))
        AddColumn(data13, "SIMDate", System.Type.GetType("System.String"))
        AddColumn(data13, "HaspID", System.Type.GetType("System.String"))
        data13.EndInit()

        gcSim.DataSource = data13
        gcSim.DefaultView.PopulateColumns()
        gvSim.Columns(1).OptionsColumn.AllowEdit = False
        gvSim.Columns(2).Visible = False
        gvSim.Columns.ColumnByFieldName("SIMNo").Caption = "SIM番号"
        gvSim.Columns.ColumnByFieldName("SIMDate").Caption = "SIM日付"
    End Sub
    Private Sub LoadMachineColumns()
        Dim i As Integer = 0
        data14 = New DataTable("gvMachine")
        data14.Clear()
        data14.BeginInit()
        AddColumn(data14, "Machine", System.Type.GetType("System.String"))
        AddColumn(data14, "Qty", System.Type.GetType("System.String"))
        data14.EndInit()

        gcMachine.DataSource = data14
        gcMachine.DefaultView.PopulateColumns()
        gvMachine.Columns(0).OptionsColumn.AllowEdit = False
        gvMachine.Columns(1).OptionsColumn.AllowEdit = False
        gvMachine.Columns.ColumnByFieldName("Machine").Caption = "設備名"
        gvMachine.Columns.ColumnByFieldName("Qty").Caption = "台数"
    End Sub
    Private Sub CheckSIMSummary(ByVal CustomerName As String, ByVal CustomerEngName As String, ByVal SimNo As String, ByVal HaspID As String, ByVal HaspDate As String, ByVal MaintenanceExpDate As String, ByVal SigmanestVersion As String)
        Dim SimFile As String = CustomerDataPath & "SIMSUM.txt"
        Dim LineItem As String = ""
        Dim SimNoFound As Boolean = False
        Dim SimArr As New ArrayList
        SimArr.Clear()
        If File.Exists(SimFile) Then
            Dim sr As New System.IO.StreamReader(SimFile, System.Text.Encoding.GetEncoding(GblEncoding))
            While sr.Peek() > -1
                LineItem = sr.ReadLine()
                Dim TmpArr() As String
                TmpArr = Split(LineItem, ",")
                If SimNo = TmpArr(2) Then
                    SimNoFound = True
                    SimArr.Add(CustomerName & "," & CustomerEngName & "," & SimNo & "," & HaspID & "," & HaspDate & "," & MaintenanceExpDate & "," & SigmanestVersion)
                Else
                    SimArr.Add(LineItem)
                End If
            End While
            If SimNoFound = False Then
                SimArr.Add(CustomerName & "," & CustomerEngName & "," & SimNo & "," & HaspID & "," & HaspDate & "," & MaintenanceExpDate & "," & SigmanestVersion)
            End If
            sr.Close()
            Dim sw As New System.IO.StreamWriter(SimFile, False, System.Text.Encoding.GetEncoding(GblEncoding))
            For i As Integer = 0 To SimArr.Count - 1
                sw.WriteLine(SimArr(i))
            Next
            sw.Close()
        Else
            Dim sw As New System.IO.StreamWriter(SimFile, False, System.Text.Encoding.GetEncoding(GblEncoding))
            sw.Close()
            CheckSIMSummary(CustomerName, CustomerEngName, SimNo, HaspID, HaspDate, MaintenanceExpDate, SigmanestVersion)
        End If
    End Sub
    Private Sub CheckLicenseInfo()
        Dim SimID As String = ""
        Dim HaspID As String = ""
        Dim HaspDate As String = ""
        Dim MaintenanceExpDate As String = ""
        Dim SigmaNESTVersion As String = ""
        Dim CompanyEngName As String = ""
        Dim i As Integer = 0
        Try

            Dim SimPath As String = GblCustomerPath & "\SIM\"
            If Directory.Exists(SimPath) Then
                Dim di As New System.IO.DirectoryInfo(SimPath)
                Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                Dim dra As System.IO.FileInfo
                For Each dra In diar1
                    If UCase(Path.GetExtension(dra.FullName)) = ".SNLICV3" Or UCase(Path.GetExtension(dra.FullName)) = ".SNLIC" Then
                        HaspID = ""
                        SimID = ""
                        HaspDate = ""
                        MaintenanceExpDate = ""
                        SigmaNESTVersion = ""
                        CompanyEngName = ""

                        Dim sr As New System.IO.StreamReader(dra.FullName, System.Text.Encoding.GetEncoding(GblEncoding))
                        Dim LineItem As String = ""
                        While sr.Peek() > -1
                            LineItem = sr.ReadLine()
                            If InStr(1, LineItem, "<CompanyName>", CompareMethod.Text) > 0 Then
                                CompanyEngName = Microsoft.VisualBasic.Mid(LineItem, InStr(1, LineItem, "<CompanyName>", CompareMethod.Text) + 13, InStr(1, LineItem, "</CompanyName>", CompareMethod.Text) - InStr(1, LineItem, "<CompanyName>", CompareMethod.Text) - 13)
                                CompanyEngName = Replace(CompanyEngName, ",", " ")
                            End If
                        End While
                        sr.Close()

                        Dim xr As XmlReader = XmlReader.Create(dra.FullName)
                        Do While xr.Read()
                            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "MaintenanceExpDate" Then
                                MaintenanceExpDate = xr.ReadElementString
                            ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "SimID" Then
                                SimID = xr.ReadElementString
                            ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "HaspID" Then
                                HaspID = xr.ReadElementString
                            ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "TimedHasp" Then
                                HaspDate = xr.GetAttribute("EndDateValue")
                            ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "SigmaNEST" Then
                                SigmaNESTVersion = xr.GetAttribute("Version")
                            End If
                        Loop
                        xr.Close()
                        If HaspDate = "" Then
                            HaspDate = "Perm"
                        End If
                        If HaspID <> "" Then
                            Dim CustomerName As String = Path.GetFileNameWithoutExtension(GblCustomerPath)
                            CheckSIMSummary(CustomerName, CompanyEngName, SimID, HaspID, HaspDate, MaintenanceExpDate, SigmaNESTVersion)
                        End If
                        For i = 0 To data13.Rows.Count - 1
                            If SimID = data13.Rows(i).Item(0) Then
                                If HaspDate <> "Perm" Then
                                    data13.Rows(i).Item(1) = Microsoft.VisualBasic.Left(FromExcelSerialDate(HaspDate).ToString, 10)
                                Else
                                    data13.Rows(i).Item(1) = "Perm"
                                End If
                                data13.Rows(i).Item(2) = HaspID
                            End If
                        Next
                        If MaintenanceExpDate <> "" Then
                            txtMaintenance.Text = Microsoft.VisualBasic.Left(FromExcelSerialDate(MaintenanceExpDate).ToString, 10)
                        End If
                        txtSIMVersion.Text = SigmaNESTVersion
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub gcSim_DoubleClick(sender As Object, e As EventArgs) Handles gcSim.DoubleClick
        ChangeView()
    End Sub
    Private Sub gcMachine_DoubleClick(sender As Object, e As EventArgs) Handles gcMachine.DoubleClick
        ChangeView()
    End Sub
    Private Sub gcCustomerLog_DoubleClick(sender As Object, e As EventArgs) Handles gcCustomerLog.DoubleClick
        Dim LogFile As String = GblCustomerPath & "\CustomerLog.txt"
        Dim LineItem As String = ""
        Dim LogArr As New ArrayList
        Dim LineCnt As Integer = 0
        If gvCustomerLog.SelectedRowsCount > 0 Then
            Try
                Dim LogDate As String = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "LogDate").ToString
                Dim Link As String = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "Detail").ToString
                Dim LogItem As String = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "LogItem").ToString
                Dim frmEdit As New frmEdit
                If Microsoft.VisualBasic.Left(Link, 3) = "QA:" Then
                    Dim TmpStr As String = GetQAInfo(Link, True)
                    Dim Description As String = ""
                    If TmpStr <> "" Then
                        Dim TmpArr() As String
                        TmpArr = Split(TmpStr, ",")
                        Dim QAStr As String = ""
                        QAStr = "QA名 : " & TmpArr(0) & vbCrLf
                        QAStr = QAStr & "登録日 : " & TmpArr(7) & vbCrLf
                        QAStr = QAStr & "登録タイプ : " & TmpArr(1) & vbCrLf
                        QAStr = QAStr & "進捗 : " & TmpArr(2) & vbCrLf
                        QAStr = QAStr & "AE優先順位 : " & TmpArr(3) & vbCrLf
                        QAStr = QAStr & "開発優先順位 : " & TmpArr(4) & vbCrLf
                        QAStr = QAStr & "開発者 : " & TmpArr(5) & vbCrLf
                        QAStr = QAStr & "タグ : " & TmpArr(6) & vbCrLf & vbCrLf
                        Description = GetQAInfo(Link, "Description")
                        QAStr = QAStr & "詳細 : " & Description
                        LogItem = QAStr
                        frmEdit.ROnly = True
                    End If
                End If
                frmEdit.rtbEdit.Text = LogItem
                frmEdit.ShowDialog()
                If gvCustomerLog.SelectedRowsCount > 0 And frmEdit.DoSave = True Then
                    Try
                        Dim SInd As Integer = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "SInd")
                        Dim FInd As Integer = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "FInd")
                        LogArr.Clear()
                        If File.Exists(LogFile) Then
                            Dim sr As New System.IO.StreamReader(LogFile, System.Text.Encoding.GetEncoding(GblEncoding))
                            While sr.Peek() > -1
                                LineItem = sr.ReadLine()
                                LineCnt += 1
                                If LineCnt = SInd Then
                                    LogArr.Add("#" & LogDate)
                                    LogArr.Add(frmEdit.rtbEdit.Text.Trim)
                                    If Link <> "" And InStr(1, Link, "QA:", CompareMethod.Text) <= 0 Then
                                        LogArr.Add("T$" & Link)
                                    End If
                                    LogArr.Add("E$")
                                ElseIf LineCnt > SInd And LineCnt <= FInd Then

                                Else
                                    LogArr.Add(LineItem)
                                End If
                            End While
                            sr.Close()
                            Dim sw As New System.IO.StreamWriter(LogFile, False, System.Text.Encoding.GetEncoding(GblEncoding))
                            For i As Integer = 0 To LogArr.Count - 1
                                If i = LogArr.Count - 1 Then
                                    If LogArr(i) <> "" Then
                                        sw.WriteLine(LogArr(i))
                                    End If
                                Else
                                    sw.WriteLine(LogArr(i))
                                End If
                            Next
                            sw.Close()
                        End If
                    Catch ex As Exception

                    Finally
                        LoadCustomerLogFile()
                    End Try
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub ttsMailLog_Click(sender As Object, e As EventArgs) Handles ttsMailLog.Click
        If gvCustomerLog.SelectedRowsCount > 0 Then
            Try
                Dim LogDate As String = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "LogDate").ToString
                Dim Link As String = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "Detail").ToString
                Dim LogItem As String = gvCustomerLog.GetRowCellValue(gvCustomerLog.GetSelectedRows(0), "LogItem").ToString
                CreateLogOutlookMail(LogDate, Link, LogItem)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub CreateLogOutlookMail(ByVal LogDate As String, ByVal Link As String, ByVal LogItem As String)
        Try
            Dim oEMail As Microsoft.Office.Interop.Outlook.MailItem
            Dim i As Integer = 0
            Dim MailBody As String = ""
            Dim moApp As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application()
            Me.Cursor = Cursors.WaitCursor
            oEMail = DirectCast(moApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem), Microsoft.Office.Interop.Outlook.MailItem)
            With oEMail
                .To = Replace(TeamAddressList, ",", ";")
                .Subject = Microsoft.VisualBasic.Right(GblCustomerPath, Len(GblCustomerPath) - GblCustomerPath.LastIndexOf("\") - 1)
                .BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML
                MailBody = LogDate & vbCrLf & Link & vbCrLf & LogItem
                .Body = MailBody
                .Recipients.ResolveAll()
                .Save()
                .Display()
            End With
            Me.Cursor = Cursors.Default

        Catch ex As Exception

        End Try

    End Sub
    Private Sub gvSIM_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvSim.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            ttsCheck.Visible = True
            ttsSIMMail.Visible = True
            Me.cmsCheck.Show(gcSim, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvCustomerLog_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvCustomerLog.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            Me.cmsLog.Show(gcCustomerLog, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvVideo_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvVideo.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            Me.cmsDelete.Show(gcVideo, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvMachine_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvMachine.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            ttsCheck.Visible = False
            ttsSIMMail.Visible = False
            Me.cmsCheck.Show(gcMachine, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub ttsCheck_Click(sender As Object, e As EventArgs) Handles ttsCheck.Click
        Dim frmSIM As New frmSIM
        If gvSim.SelectedRowsCount > 0 Then
            Dim HaspID As String = gvSim.GetRowCellValue(gvSim.GetSelectedRows(0), "HaspID").ToString
            If HaspID <> "" Then
                Dim SimPath As String = GblCustomerPath & "\SIM\" & HaspID & ".SNLICV3"
                frmSIM.SimPath = SimPath
                frmSIM.Show()
            End If
        End If
    End Sub
    Private Sub ttsEditSim_Click(sender As Object, e As EventArgs) Handles ttsEditSim.Click
        Try
            If gcSim.Visible = True Then
                Dim SelPath As String = GblCustomerPath & "\SIM.txt"
                If File.Exists(SelPath) Then
                    Process.Start(SelPath)
                Else
                    Dim sw As New System.IO.StreamWriter(SelPath, False, System.Text.Encoding.GetEncoding(GblEncoding))
                    sw.Close()
                    Process.Start(SelPath)
                End If
            Else
                Dim SelPath As String = GblCustomerPath & "\Machine.txt"
                If File.Exists(SelPath) Then
                    Process.Start(SelPath)
                Else
                    Dim sw As New System.IO.StreamWriter(SelPath, False, System.Text.Encoding.GetEncoding(GblEncoding))
                    sw.Close()
                    Process.Start(SelPath)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bbiEditLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditLog.ItemClick
        If GblCustomerPath <> "" Then
            Dim SelPath As String = GblCustomerPath & "\CustomerLog.txt"
            Process.Start(SelPath)
        End If
    End Sub
    Private Sub ttsEditLog_Click(sender As Object, e As EventArgs) Handles ttsEditLog.Click
        If GblCustomerPath <> "" Then
            Dim SelPath As String = GblCustomerPath & "\CustomerLog.txt"
            Process.Start(SelPath)
        End If
    End Sub
    Private Sub cbtnQA_CheckedChanged(sender As Object, e As EventArgs) Handles cbtnQA.CheckedChanged
        If cbtnQA.Checked = True Then
            gvCustomerLog.ApplyFindFilter("QA:")
        Else
            gvCustomerLog.ApplyFindFilter("")
        End If
    End Sub
    Private Sub ChangeView()
        If gcSim.Visible = True Then
            gcSim.Visible = False
            gcMachine.Visible = True
        Else
            gcSim.Visible = True
            gcMachine.Visible = False
        End If
    End Sub
    Private Sub ttsChangeView_Click(sender As Object, e As EventArgs)
        ChangeView()
    End Sub
    Private Sub bbiHasp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHasp.ItemClick
        bbiQA.Down = False
        If bbiHasp.Down = True Then
            gcSimSum.Visible = True
            gcSimSum.BringToFront()
            LoadSimSumColumns()
            LoadSimSumData()
        Else
            gcSimSum.Visible = False
            splCustomer.BringToFront()
        End If
    End Sub
    Private Sub LoadSimSumColumns()
        Dim i As Integer = 0
        data18 = New DataTable("gvSimSum")
        data18.Clear()
        data18.BeginInit()
        AddColumn(data18, "CustomerName", System.Type.GetType("System.String"))
        AddColumn(data18, "CustomerEngName", System.Type.GetType("System.String"))
        AddColumn(data18, "SimID", System.Type.GetType("System.String"))
        AddColumn(data18, "HaspID", System.Type.GetType("System.String"))
        AddColumn(data18, "LicenseDate", System.Type.GetType("System.String"))
        AddColumn(data18, "MaintenanceDate", System.Type.GetType("System.String"))
        AddColumn(data18, "Version", System.Type.GetType("System.String"))
        data18.EndInit()

        gcSimSum.DataSource = data18
        gcSimSum.DefaultView.PopulateColumns()
        gvSimSum.Columns.ColumnByFieldName("CustomerName").Caption = "顧客名"
        gvSimSum.Columns.ColumnByFieldName("CustomerEngName").Caption = "登録名"
        gvSimSum.Columns.ColumnByFieldName("SimID").Caption = "SIM番号"
        gvSimSum.Columns.ColumnByFieldName("HaspID").Caption = "Hasp番号"
        gvSimSum.Columns.ColumnByFieldName("LicenseDate").Caption = "ライセンス日"
        gvSimSum.Columns.ColumnByFieldName("MaintenanceDate").Caption = "保守日"
        gvSimSum.Columns.ColumnByFieldName("Version").Caption = "バージョン"
    End Sub
    Private Sub LoadSimSumData()
        Dim SimFile As String = CustomerDataPath & "SIMSUM.txt"
        Dim LineItem As String = ""
        Dim SimNoFound As Boolean = False
        data18.Clear()
        If File.Exists(SimFile) Then
            Dim sr As New System.IO.StreamReader(SimFile, System.Text.Encoding.GetEncoding(GblEncoding))
            While sr.Peek() > -1
                LineItem = sr.ReadLine()
                Dim TmpArr() As String
                TmpArr = Split(LineItem, ",")
                If TmpArr(4) <> "Perm" Then
                    data18.Rows.Add(TmpArr(0), TmpArr(1), TmpArr(2), TmpArr(3), FromExcelSerialDate(TmpArr(4)), FromExcelSerialDate(TmpArr(5)), TmpArr(6))
                Else
                    data18.Rows.Add(TmpArr(0), TmpArr(1), TmpArr(2), TmpArr(3), TmpArr(4), FromExcelSerialDate(TmpArr(5)), TmpArr(6))
                End If
            End While
            sr.Close()
        End If
        gvSimSum.Columns("LicenseDate").SortOrder = ColumnSortOrder.Ascending
        gvSimSum.MoveFirst()
    End Sub
    Private Function FromExcelSerialDate(ByVal SerialDate As Integer) As DateTime
        If SerialDate > 59 Then SerialDate -= 1 ''// Excel/Lotus 2/29/1900 bug
        Return New DateTime(1899, 12, 31).AddDays(SerialDate)
    End Function
    Private Sub gvSimSum_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvSimSum.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            Me.cmsSim.Show(gcSimSum, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub ttsAddToSchedule_Click(sender As Object, e As EventArgs) Handles ttsAddToSchedule.Click
        If gvSimSum.SelectedRowsCount > 0 Then
            Dim CustomerName As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "CustomerName").ToString
            Dim SimID As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "SimID").ToString
            Dim HaspID As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "HaspID").ToString
            Dim LicenseDate As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "LicenseDate").ToString
            Dim MaintenanceDate As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "MaintenanceDate").ToString
            Dim Version As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "Version").ToString
            Dim TmpBody As String = "日付：" & LicenseDate & vbCrLf & "保守日付：" & MaintenanceDate & vbCrLf & "バージョン：" & Version
            'CreateOutlookAppointment(CustomerName & "-SIM期間切れ", TmpBody, CustomerName, CDate(LicenseDate).AddHours(9), CDate(LicenseDate).AddHours(10))
            'MsgBox("Outlookのスケジュールに追加されました。")
        End If
    End Sub
    Private Sub ttsAddMaintToSchedule_Click(sender As Object, e As EventArgs) Handles ttsAddMaintToSchedule.Click
        If gvSimSum.SelectedRowsCount > 0 Then
            Dim CustomerName As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "CustomerName").ToString
            Dim SimID As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "SimID").ToString
            Dim HaspID As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "HaspID").ToString
            Dim LicenseDate As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "LicenseDate").ToString
            Dim MaintenanceDate As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "MaintenanceDate").ToString
            Dim Version As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "Version").ToString
            Dim TmpBody As String = "保守日付：" & MaintenanceDate & vbCrLf & "ライセンス日付：" & LicenseDate & vbCrLf & "バージョン：" & Version
            'CreateOutlookAppointment(CustomerName & "-保守切れ", TmpBody, CustomerName, CDate(MaintenanceDate).AddHours(9), CDate(MaintenanceDate).AddHours(10))
            'MsgBox("Outlookのスケジュールに追加されました。")
        End If
    End Sub
    Private Sub ttsRequestSim_Click(sender As Object, e As EventArgs) Handles ttsRequestSim.Click
        If gvSimSum.SelectedRowsCount > 0 Then
            Dim SimID As String = gvSimSum.GetRowCellValue(gvSimSum.GetSelectedRows(0), "SimID").ToString
            Clipboard.SetText(SimID)
            rbnMain.SelectedPage = rpgMail
            xtcMain.SelectedTabPage = tabMail
            bbiMailText.Down = True
            bbiMailMessage.Down = False
            bbiMailTemplate.Down = False
            LoadMailForm()
        End If
    End Sub
#End Region
#Region "FileNavigation"
    Dim FolderMode As String = ""
    Private Sub ClearCustomerForm()
        ClearTikItems()
        data2.Clear()
        clbSigmanest.Items.Clear()
        clbSource.Items.Clear()
        data13.Clear()
        data14.Clear()
        gvCustomer.ClearColumnsFilter()
        gvCustomer.ClearSelection()
    End Sub
    Private Sub ClearTikItems()
        meTikDescription.Text = ""
        meTikSolution.Text = ""
        txtTikTitle.Text = ""
        txtTikVersion.Text = ""
        chkTikClosed.Checked = False
        meTikDescription.BackColor = Color.White
    End Sub
    Private Sub LoadCustomerMode()
        ClearCustomerForm()
        If bbiSalesMode.Down = True Then
            splSigmaInfo.Panel2Collapsed = True
            splSim.Panel2Collapsed = False
            gcMachine.Visible = True
            gcSim.Visible = False
            rpgSigmanest.Visible = False
            LoadCustomerData()
        ElseIf bbiPartnerMode.Down = True Then
            splSigmaInfo.Panel2Collapsed = True
            splSim.Panel2Collapsed = True
            gcMachine.Visible = False
            gcSim.Visible = False
            rpgSigmanest.Visible = True
            LoadCustomerData()
        ElseIf bbiMasterPost.Down = True Then
            splSigmaInfo.Panel2Collapsed = True
            splSim.Panel2Collapsed = True
            gcMachine.Visible = False
            gcSim.Visible = False
            rpgSigmanest.Visible = True
            LoadCustomerData()
        Else
            splSigmaInfo.Panel2Collapsed = False
            splSim.Panel2Collapsed = False
            gcMachine.Visible = False
            gcSim.Visible = True
            rpgSigmanest.Visible = True
            LoadCustomerData()
        End If
        Try
            If gvCustomer.SelectedRowsCount > 0 Then
                Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
                Dim CustomerPath As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerPath").ToString
                LoadSigmaNESTFiles(CustomerName, CustomerPath)
                LoadCustomerLogFile()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bbiSalesMode_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalesMode.ItemClick
        bbiSalesMode.Down = True
        bbiCompanyMode.Down = False
        bbiPartnerMode.Down = False
        bbiMasterPost.Down = False
        ttsMoveToCustomer.Visible = True
        LoadCustomerMode()
    End Sub
    Private Sub bbiCompanyMode_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCompanyMode.ItemClick
        bbiSalesMode.Down = False
        bbiCompanyMode.Down = True
        bbiPartnerMode.Down = False
        bbiMasterPost.Down = False
        ttsMoveToCustomer.Visible = False
        LoadCustomerMode()
    End Sub
    Private Sub bbiMasterPost_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMasterPost.ItemClick
        bbiSalesMode.Down = False
        bbiCompanyMode.Down = False
        bbiPartnerMode.Down = False
        bbiMasterPost.Down = True
        ttsMoveToCustomer.Visible = True
        LoadCustomerMode()
    End Sub
    Private Sub bbiPartnerMode_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPartnerMode.ItemClick
        bbiSalesMode.Down = False
        bbiCompanyMode.Down = False
        bbiPartnerMode.Down = True
        bbiMasterPost.Down = False
        ttsMoveToCustomer.Visible = False
        LoadCustomerMode()
    End Sub
    Private Sub ttsMoveToCustomer_Click(sender As Object, e As EventArgs) Handles ttsMoveToCustomer.Click
        Dim frmCust As New frmNew
        Dim NewCustDir As String = ""
        Dim OldCustDir As String = ""
        Dim CustName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName")
        Dim result As Integer = MessageBox.Show(CustName & "　のデータを顧客に移動して良いでしょうか？", "データ移動", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Try
                If bbiSalesMode.Down = True Then
                    OldCustDir = ProspectDataPath & CustName & "\"
                    NewCustDir = CustomerDataPath & CustName & "\"
                ElseIf bbiMasterPost.Down = True Then
                    OldCustDir = PostDataPath & CustName & "\"
                    NewCustDir = CustomerDataPath & CustName & "\"
                End If
                FileIO.FileSystem.CopyDirectory(OldCustDir, NewCustDir, True)
                FileIO.FileSystem.DeleteDirectory(OldCustDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
            Finally
                LoadCustomerData()
            End Try
        End If
    End Sub
    Private Sub ttsFolderDelete_Click(sender As Object, e As EventArgs) Handles ttsFolderDelete.Click
        Dim frmCust As New frmNew
        Dim NewCustDir As String = ""
        If FolderMode = "clbSigmanest" Or FolderMode = "clbSource" Or FolderMode = "clbVPNItems" Then
            Dim FolderName As String
            If FolderMode = "clbSigmanest" Then
                FolderName = clbSigmanest.SelectedValue
            ElseIf FolderMode = "clbVPNItems" Then
                FolderName = clbVPNItems.SelectedValue
            Else
                FolderName = clbSource.SelectedValue
            End If
            Dim result As Integer = MessageBox.Show(FolderName & "　のデータを全て削除して良いでしょうか？", "データ削除", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
            Try
                If result = DialogResult.Yes Then
                    If FolderMode = "clbVPNItems" Then
                        NewCustDir = VPNCustomerPath & "\" & FolderName & "\"
                    Else
                        NewCustDir = GblCustomerPath & "\" & FolderName & "\"
                    End If

                    If Directory.Exists(NewCustDir) Then
                        Directory.Delete(NewCustDir, True)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
                Dim CustomerPath As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerPath").ToString
                LoadSigmaNESTFiles(CustomerName, CustomerPath)
            End Try
        Else
            Dim CustName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName")
            Dim result As Integer = MessageBox.Show(CustName & "　のデータを全て削除して良いでしょうか？", "データ削除", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
            Try
                If result = DialogResult.Yes Then
                    If bbiSalesMode.Down = True Then
                        NewCustDir = ProspectDataPath & CustName & "\"
                    ElseIf bbiPartnerMode.Down = True Then
                        NewCustDir = PartnerDataPath & CustName & "\"
                    ElseIf bbiMasterPost.Down = True Then
                        NewCustDir = PostDataPath & CustName & "\"
                    Else
                        NewCustDir = CustomerDataPath & CustName & "\"
                    End If
                    If Directory.Exists(NewCustDir) Then
                        Directory.Delete(NewCustDir, True)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                LoadCustomerData()
            End Try
        End If

    End Sub
    Private Sub ttsNewFolder_Click(sender As Object, e As EventArgs) Handles ttsNewFolder.Click
        Dim frmCust As New frmNew
        Dim NewCustDir As String = ""
        If FolderMode = "clbSigmanest" Or FolderMode = "clbSource" Or FolderMode = "clbVPNItems" Then
            frmCust.LabelControl1.Text = "フォルダー名："
            frmCust.ShowDialog()
            Dim FolderName As String = frmCust.CustomerName
            If FolderMode = "clbVPNItems" Then
                NewCustDir = VPNCustomerPath & "\" & FolderName & "\"
            Else
                NewCustDir = GblCustomerPath & "\" & FolderName & "\"
            End If
            If Directory.Exists(NewCustDir) = False And FolderName <> "" Then
                Directory.CreateDirectory(NewCustDir)
                Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
                Dim CustomerPath As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerPath").ToString
                LoadSigmaNESTFiles(CustomerName, CustomerPath)
            End If
        Else
            frmCust.ShowDialog()
            Dim CustName As String = frmCust.CustomerName
            If bbiSalesMode.Down = True Then
                NewCustDir = ProspectDataPath & CustName & "\"
            ElseIf bbiPartnerMode.Down = True Then
                NewCustDir = PartnerDataPath & CustName & "\"
            ElseIf bbiMasterPost.Down = True Then
                NewCustDir = PostDataPath & CustName & "\"
            Else
                NewCustDir = CustomerDataPath & CustName & "\"
            End If
            If Directory.Exists(NewCustDir) = False And CustName <> "" Then
                Directory.CreateDirectory(NewCustDir)
                LoadCustomerData()
            End If
        End If

    End Sub
    Private Sub ttsEditFolder_Click(sender As Object, e As EventArgs) Handles ttsEditFolder.Click
        Dim frmCust As New frmNew

        Dim NewCustDir As String = ""
        Dim OldCustDir As String = ""
        If FolderMode = "clbSigmanest" Or FolderMode = "clbSource" Or FolderMode = "clbVPNItems" Then
            frmCust.LabelControl1.Text = "フォルダー名："
            Dim FolderName As String
            If FolderMode = "clbSigmanest" Then
                FolderName = clbSigmanest.SelectedValue
            ElseIf FolderMode = "clbVPNItems" Then
                FolderName = clbVPNItems.SelectedValue
            Else
                FolderName = clbSource.SelectedValue
            End If
            frmCust.txtCustName.Text = FolderName
            frmCust.ShowDialog()
            Dim NewFolderName As String = frmCust.CustomerName
            If FolderMode = "clbVPNItems" Then
                OldCustDir = VPNCustomerPath & "\" & FolderName & "\"
                NewCustDir = VPNCustomerPath & "\" & NewFolderName & "\"
            Else
                OldCustDir = GblCustomerPath & "\" & FolderName & "\"
                NewCustDir = GblCustomerPath & "\" & NewFolderName & "\"
            End If
            If Directory.Exists(OldCustDir) = True And NewFolderName <> "" Then
                FileIO.FileSystem.RenameDirectory(OldCustDir, NewFolderName)
                Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
                Dim CustomerPath As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerPath").ToString
                LoadSigmaNESTFiles(CustomerName, CustomerPath)
            End If
        Else
            Dim CustName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName")
            frmCust.txtCustName.Text = CustName
            frmCust.ShowDialog()
            Dim NewCustName As String = frmCust.CustomerName
            If bbiSalesMode.Down = True Then
                OldCustDir = ProspectDataPath & CustName & "\"
                NewCustDir = ProspectDataPath & NewCustName & "\"
            ElseIf bbiPartnerMode.Down = True Then
                OldCustDir = PartnerDataPath & CustName & "\"
                NewCustDir = PartnerDataPath & NewCustName & "\"
            ElseIf bbiMasterPost.Down = True Then
                OldCustDir = PostDataPath & CustName & "\"
                NewCustDir = PostDataPath & NewCustName & "\"
            Else
                OldCustDir = CustomerDataPath & CustName & "\"
                NewCustDir = CustomerDataPath & NewCustName & "\"
            End If
            Try
                If Directory.Exists(OldCustDir) = True And NewCustName <> "" Then
                    FileIO.FileSystem.RenameDirectory(OldCustDir, NewCustName)
                    LoadCustomerData()
                End If
            Catch ex As Exception

            End Try

        End If

    End Sub
#End Region
#Region "FileUpload"
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bTest.ItemClick
        'uploadcontact()
        UninstallProgram("SigmaNEST91SP6.5")
    End Sub
    Private Sub uploadcontact()
        Dim nvc As New NameValueCollection()
        'nvc.Add("id", "TTR")
        'nvc.Add("btn-submit-photo", "Upload")
        HttpUploadFile("http://info.sigmatek.net/org/import", "c:\sndata\jptest.csv", "csvFile", "text/csv", nvc)
    End Sub
    Public Shared Sub HttpUploadFile(url As String, file As String, paramName As String, contentType As String, nvc As NameValueCollection)
        MsgBox(String.Format("Uploading {0} to {1}", file, url))
        Dim boundary As String = "---------------------------" + DateTime.Now.Ticks.ToString("x")
        Dim boundarybytes As Byte() = System.Text.Encoding.ASCII.GetBytes((Convert.ToString(vbCr & vbLf & "--") & boundary) + vbCr & vbLf)

        Dim wr As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        wr.ContentType = Convert.ToString("multipart/form-data; boundary=") & boundary
        wr.Method = "POST"
        wr.KeepAlive = True
        wr.Credentials = System.Net.CredentialCache.DefaultCredentials

        Dim rs As Stream = wr.GetRequestStream()

        Dim formdataTemplate As String = "Content-Disposition: form-data; name=""{0}""" & vbCr & vbLf & vbCr & vbLf & "{1}"
        For Each key As String In nvc.Keys
            rs.Write(boundarybytes, 0, boundarybytes.Length)
            Dim formitem As String = String.Format(formdataTemplate, key, nvc(key))
            Dim formitembytes As Byte() = System.Text.Encoding.UTF8.GetBytes(formitem)
            rs.Write(formitembytes, 0, formitembytes.Length)
        Next
        rs.Write(boundarybytes, 0, boundarybytes.Length)

        Dim headerTemplate As String = "Content-Disposition: form-data; name=""{0}""; filename=""{1}""" & vbCr & vbLf & "Content-Type: {2}" & vbCr & vbLf & vbCr & vbLf
        Dim header As String = String.Format(headerTemplate, paramName, file, contentType)
        Dim headerbytes As Byte() = System.Text.Encoding.UTF8.GetBytes(header)
        rs.Write(headerbytes, 0, headerbytes.Length)

        Dim fileStream As New FileStream(file, FileMode.Open, FileAccess.Read)
        Dim buffer As Byte() = New Byte(4095) {}
        Dim bytesRead As Integer = 0
        While (bytesRead = fileStream.Read(buffer, 0, buffer.Length)) <> 0
            rs.Write(buffer, 0, bytesRead)
        End While
        fileStream.Close()

        Dim trailer As Byte() = System.Text.Encoding.ASCII.GetBytes((Convert.ToString(vbCr & vbLf & "--") & boundary) + "--" & vbCr & vbLf)
        rs.Write(trailer, 0, trailer.Length)
        rs.Close()

        Dim wresp As WebResponse = Nothing
        Try
            wresp = wr.GetResponse()
            Dim stream2 As Stream = wresp.GetResponseStream()
            Dim reader2 As New StreamReader(stream2)
            MsgBox(String.Format("File uploaded, server response is: " & reader2.ReadToEnd()))
        Catch ex As Exception
            MsgBox(ex.Message)
            If wresp IsNot Nothing Then
                wresp.Close()
                wresp = Nothing
            End If
        Finally
            wr = Nothing
        End Try
    End Sub



#End Region
#Region "SalesLogix"
    Dim LoadSalesLogic As Boolean = False
    Private Sub LoadSalesLogixColumns()
        Dim i As Integer = 0
        data27 = New DataTable("gvSalesLogix")
        data27.Clear()
        data27.BeginInit()
        AddColumn(data27, "Account", System.Type.GetType("System.String"))
        AddColumn(data27, "Country", System.Type.GetType("System.String"))
        AddColumn(data27, "State", System.Type.GetType("System.String"))
        AddColumn(data27, "City", System.Type.GetType("System.String"))
        AddColumn(data27, "PhoneNo", System.Type.GetType("System.String"))
        AddColumn(data27, "Type", System.Type.GetType("System.String"))
        AddColumn(data27, "Status", System.Type.GetType("System.String"))
        AddColumn(data27, "AccountManager", System.Type.GetType("System.String"))
        AddColumn(data27, "Owner", System.Type.GetType("System.String"))
        data27.EndInit()

        gcSalesLogix.DataSource = data27
        gcSalesLogix.DefaultView.PopulateColumns()
        gvSalesLogix.Columns(0).Width = 150
        gvSalesLogix.Columns(1).Width = 150
        gvSalesLogix.Columns(2).Width = 150
        gvSalesLogix.Columns(3).Width = 150
        gvSalesLogix.Columns(4).Width = 150
        gvSalesLogix.Columns(5).Width = 150
        gvSalesLogix.Columns(6).Width = 150
        gvSalesLogix.Columns(7).Width = 150
        gvSalesLogix.Columns(8).Width = 150
        gvSalesLogix.Columns.ColumnByFieldName("Account").Caption = "アカウント"
        gvSalesLogix.Columns.ColumnByFieldName("Country").Caption = "国"
        gvSalesLogix.Columns.ColumnByFieldName("State").Caption = "県"
        gvSalesLogix.Columns.ColumnByFieldName("City").Caption = "町"
        gvSalesLogix.Columns.ColumnByFieldName("PhoneNo").Caption = "電話番号"
        gvSalesLogix.Columns.ColumnByFieldName("Type").Caption = "タイプ"
        gvSalesLogix.Columns.ColumnByFieldName("Status").Caption = "ステータス"
        gvSalesLogix.Columns.ColumnByFieldName("AccountManager").Caption = "管理者"
        gvSalesLogix.Columns.ColumnByFieldName("Owner").Caption = "事務所"

    End Sub
    Delegate Sub AddSLItemDelegate(ByVal ThreadStatus As String, ByVal Account As String, ByVal Country As String, ByVal State As String, ByVal City As String, ByVal PhoneNo As String, ByVal Type As String, ByVal Status As String, ByVal AccountManager As String, ByVal Owner As String)
    Public Sub AddSLItem(ByVal ThreadStatus As String, ByVal Account As String, ByVal Country As String, ByVal State As String, ByVal City As String, ByVal PhoneNo As String, ByVal Type As String, ByVal Status As String, ByVal AccountManager As String, ByVal Owner As String)
        Select Case ThreadStatus
            Case "START"
                LoadSalesLogic = True
                data27.Clear()
            Case "FINISHED"
                gvSalesLogix.Columns("Country").GroupIndex = 0
                'gvCompany.RestoreLayoutFromRegistry("gvCompany")
            Case Else
                data27.Rows.Add(Account, Country, State, City, PhoneNo, Type, Status, AccountManager, Owner)
        End Select
    End Sub
    Private Sub LoadSalesLogixItems()
        Dim SalesLogicFile As String = SigmanestDataPath & "\Applications\SigmaAPP\Saleslogix\Contacts.csv"
        Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(SalesLogicFile, System.Text.Encoding.GetEncoding(GblEncoding))
        Dim Account, Country, State, City, PhoneNo, Type, Status, AccountManager, Owner As String
        Dim CurrentRecord As String()
        afile.TextFieldType = FileIO.FieldType.Delimited
        afile.Delimiters = New String() {","}
        afile.HasFieldsEnclosedInQuotes = True
        ' parse the actual file
        If Me.gcSalesLogix.InvokeRequired Then
            Me.gcSalesLogix.Invoke(New AddSLItemDelegate(AddressOf AddSLItem), New Object() {"START", "", "", "", "", "", "", "", "", ""})
        Else
            Me.AddSLItem("START", "", "", "", "", "", "", "", "", "")
        End If
        afile.ReadLine()
        Do While Not afile.EndOfData
            Try
                CurrentRecord = afile.ReadFields
                Account = CurrentRecord(0).Trim
                Country = CurrentRecord(1).Trim
                State = CurrentRecord(2).Trim
                City = CurrentRecord(3).Trim
                PhoneNo = CurrentRecord(4).Trim
                Type = CurrentRecord(5).Trim
                Status = CurrentRecord(6).Trim
                AccountManager = CurrentRecord(7).Trim
                Owner = CurrentRecord(8).Trim
                If Account <> "" Then
                    If Me.gcCustomerData.InvokeRequired Then
                        Me.gcCustomerData.Invoke(New AddSLItemDelegate(AddressOf AddSLItem), New Object() {"CCThread", Account, Country, State, City, PhoneNo, Type, Status, AccountManager, Owner})
                    Else
                        Me.AddSLItem("CCThread", Account, Country, State, City, PhoneNo, Type, Status, AccountManager, Owner)
                    End If
                End If
            Catch ex As FileIO.MalformedLineException
                afile.Close()
                Stop
            End Try
        Loop
        afile.Close()
        If Me.gcSalesLogix.InvokeRequired Then
            Me.gcSalesLogix.Invoke(New AddSLItemDelegate(AddressOf AddSLItem), New Object() {"FINISHED", "", "", "", "", "", "", "", "", ""})
        Else
            Me.AddSLItem("FINISHED", "", "", "", "", "", "", "", "", "")
        End If
    End Sub
    Private Sub bbiSalesLogix_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSalesLogix.ItemClick
        bbiShowCompany.Down = False
        bbiShowCustomer.Down = False
        bbiSalesLogix.Down = True
        'xtcMain.SelectedTabPage = tabSaleslogix
        Dim SLPath As String = "https://crm.sigmatek.net/SlxClient/Home.aspx"
        Dim MozillaPath As String = "C:\Program Files (x86)\Mozilla Firefox\firefox.exe"
        If File.Exists(MozillaPath) Then
            Shell("""" & MozillaPath & """" & " """ & SLPath & """")
        Else
            MsgBox("SalesLogixはMozillaをインストールして下さい。")
        End If
        'If LoadSalesLogic = False Then
        '    Dim SLthrd As System.Threading.Thread
        '    SLthrd = New System.Threading.Thread(AddressOf LoadSalesLogixItems)
        '    SLthrd.Start()
        'End If

    End Sub
#End Region
#Region "CustomerData"
    Private Sub ShowStaticMap()
        Dim Address As String = ""
        Dim FullAddress As String = ""
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                Address = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address")
                imageMap.ImageLocation = "http://maps.googleapis.com/maps/api/staticmap?center=" & Address & "&zoom=12&size=640x1280" & "&markers=color:blue%7Clabel:S%7CT" & Address & "&maptype=roadmap&sensor=false"
                Dim CardPath1 As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "CardPath1")
                LoadBusinessCardImage(CardPath1)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ShowDynamicMap()
        Dim StreetAddress As String = ""
        Dim Company As String = ""
        Dim i As Integer = 0
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                For i = 0 To gvCustomerData.SelectedRowsCount - 1
                    StreetAddress = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Address")
                    Company = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Company")
                Next

                Dim address As String = "http://maps.google.com/?q=" & Replace(StreetAddress, " ", "+") & ""
                Process.Start(address)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ShowMapMarkers()
        Dim StreetAddress As String
        Dim Company As String = ""
        Dim i As Integer = 0
        Dim AddressStr As New ArrayList
        Dim CompanyStr As New ArrayList
        Dim oWrite As System.IO.StreamWriter
        Dim dWrite As System.IO.StreamWriter
        AddressStr.Clear()
        CompanyStr.Clear()
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                For i = 0 To gvCustomerData.SelectedRowsCount - 1
                    StreetAddress = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Address")
                    Company = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Company")
                    If StreetAddress <> "" Then
                        AddressStr.Add(StreetAddress)
                        CompanyStr.Add(Company)
                    End If
                Next

                oWrite = File.CreateText(appData + "\map1.js")
                oWrite.WriteLine("var geocoder;var map;function initialize() {geocoder = new google.maps.Geocoder();var latlng = new google.maps.LatLng(35.7, 139.7);var myOptions = {zoom: 12,center: latlng,mapTypeId: google.maps.MapTypeId.ROADMAP}; var address ;")
                For i = 0 To AddressStr.Count - 1
                    oWrite.WriteLine("address = '" & AddressStr(i) & "';getLat(address,""" & CompanyStr(i) & """);")
                Next

                Dim pathMap As String = (appData + "\detail.html")
                dWrite = File.CreateText(pathMap)
                dWrite.WriteLine("<!DOCTYPE html>")
                dWrite.WriteLine("<html>")
                dWrite.WriteLine("  <head>")
                dWrite.WriteLine("    <title>Google Maps JavaScript API v3 Example: Map Simple</title>")
                dWrite.WriteLine("    <meta name=""viewport""")
                dWrite.WriteLine("        content=""width=device-width, initial-scale=1.0, user-scalable=no"">")
                dWrite.WriteLine("	<meta http-equiv=""content-type"" content=""text/html; charset=UTF-8""/>")
                dWrite.WriteLine("    <style type=""text/css"">")
                dWrite.WriteLine("      html, body, #map_canvas {")
                dWrite.WriteLine("        margin: 0;")
                dWrite.WriteLine("        padding: 0;")
                dWrite.WriteLine("        height: 100%;")
                dWrite.WriteLine("      }")
                dWrite.WriteLine("    </style>")
                dWrite.WriteLine("    <script type=""text/javascript""")
                dWrite.WriteLine("       src=""http://maps.googleapis.com/maps/api/js?sensor=false""></script>")
                dWrite.WriteLine("   <script type=""text/javascript"" src=""map1.js"" charset=""utf-8""></script>")
                dWrite.WriteLine("  </head>")
                dWrite.WriteLine("  <body onload=""initialize()"">")
                dWrite.WriteLine("    <div id=""map_canvas""></div>")
                dWrite.WriteLine("  </body>")
                dWrite.WriteLine("</html>")
                dWrite.Close()
                oWrite.WriteLine("map = new google.maps.Map(document.getElementById(""map_canvas""), myOptions);}function getLat( address,shopname) {geocoder.geocode( { 'address': address}, function(results, status) {if (status == google.maps.GeocoderStatus.OK) {map.setCenter(results[0].geometry.location);var marker = new google.maps.Marker({map: map, position: results[0].geometry.location});var contentString =shopname + '<br/>' + address ;var infowindow = new google.maps.InfoWindow({content: contentString});google.maps.event.addListener(marker, 'click', function() {infowindow.open(map,marker);});} else {alert(""Geocode was not successful for the following reason: "" + status);}});}")
                oWrite.Close()
                Dim address As New Uri("file://" & pathMap)
                webB.Url = address
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub PreLoadWebBrowser()

        Try
            webBrowser.Visible = False
            Dim address As New Uri("http:\\www.google.com")
            webBrowser.Url = address
            Dim wbInstance As Object = webBrowser.ActiveXInstance
            wbInstance.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, ExecOpt.OLECMDEXECOPT_DONTPROMPTUSER, 40 - 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadBusinessCardImage(CardPath1 As String)
        Dim BCardPath As String = SigmanestDataPath & "RAKUCADATA\BusinessCards\"
        Dim NoImagePath As String = SigmanestDataPath & "デモ用データ\noimagel.png"
        Dim WebUrl As String = ""
        Dim image1 As Bitmap
        If File.Exists(BCardPath & CardPath1) Then
            webBrowser.Visible = False
            picCard.Visible = True
            image1 = CType(Image.FromFile(BCardPath & CardPath1, True), Bitmap)
            picCard.SizeMode = PictureBoxSizeMode.StretchImage
            picCard.Image = image1
        Else
            WebUrl = ""
            If gvCustomerData.SelectedRowsCount > 0 Then
                WebUrl = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Website")
            End If
            If WebUrl <> "" Then
                webBrowser.Visible = True
                picCard.Visible = False
                Dim address As New Uri(WebUrl)
                webBrowser.Url = address
                Try
                    Dim wbInstance As Object = webBrowser.ActiveXInstance
                    wbInstance.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, ExecOpt.OLECMDEXECOPT_DONTPROMPTUSER, 40 - 0, Nothing)
                    'If webBrowser.IsBusy = False Then
                    '    Dim wbInstance As Object = webBrowser.ActiveXInstance
                    '    wbInstance.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, ExecOpt.OLECMDEXECOPT_DONTPROMPTUSER, 40 - 0, Nothing)
                    'End If
                Catch ex As Exception

                End Try
            Else
                webBrowser.Visible = False
                picCard.Visible = True
                image1 = CType(Image.FromFile(NoImagePath, True), Bitmap)
                picCard.SizeMode = PictureBoxSizeMode.StretchImage
                picCard.Image = image1
            End If
        End If
        ' picCard.ImageLocation = BCardPath & CardPath1
    End Sub
    Private Sub LoadCustomerInfoColumns()
        Dim i As Integer = 0
        data12 = New DataTable("gvCustomerData")
        data12.Clear()
        data12.BeginInit()
        AddColumn(data12, "ContactsGUID", System.Type.GetType("System.String"))
        AddColumn(data12, "LastName", System.Type.GetType("System.String"))
        AddColumn(data12, "Relationship", System.Type.GetType("System.String"))
        AddColumn(data12, "Company", System.Type.GetType("System.String"))
        AddColumn(data12, "NativeCompany", System.Type.GetType("System.String"))
        AddColumn(data12, "Department", System.Type.GetType("System.String"))
        AddColumn(data12, "Title", System.Type.GetType("System.String"))
        AddColumn(data12, "Telephone", System.Type.GetType("System.String"))
        AddColumn(data12, "Fax", System.Type.GetType("System.String"))
        AddColumn(data12, "EMail", System.Type.GetType("System.String"))
        AddColumn(data12, "Website", System.Type.GetType("System.String"))
        AddColumn(data12, "Address", System.Type.GetType("System.String"))
        AddColumn(data12, "Zip", System.Type.GetType("System.String"))
        AddColumn(data12, "State", System.Type.GetType("System.String"))
        AddColumn(data12, "City", System.Type.GetType("System.String"))
        AddColumn(data12, "Country", System.Type.GetType("System.String"))
        AddColumn(data12, "Remarks", System.Type.GetType("System.String"))
        AddColumn(data12, "UpdateDate", System.Type.GetType("System.DateTime"))
        AddColumn(data12, "CardPath1", System.Type.GetType("System.String"))
        AddColumn(data12, "CardPath2", System.Type.GetType("System.String"))
        AddColumn(data12, "UserName", System.Type.GetType("System.String"))
        AddColumn(data12, "CompanyLink", System.Type.GetType("System.String"))
        AddColumn(data12, "SNInfoLink", System.Type.GetType("System.String"))
        data12.EndInit()

        gcCustomerData.DataSource = data12
        gcCustomerData.DefaultView.PopulateColumns()
        gvCustomerData.Columns(0).Visible = False
        gvCustomerData.Columns(1).Width = 200
        gvCustomerData.Columns(2).Width = 150
        gvCustomerData.Columns(3).Width = 150
        gvCustomerData.Columns(4).Width = 150
        gvCustomerData.Columns(5).Width = 150
        gvCustomerData.Columns(6).Width = 150
        gvCustomerData.Columns(7).Width = 150
        gvCustomerData.Columns(8).Width = 150
        gvCustomerData.Columns(9).Width = 150
        gvCustomerData.Columns(10).Width = 150
        gvCustomerData.Columns(11).Width = 150
        gvCustomerData.Columns(12).Width = 150
        gvCustomerData.Columns(13).Width = 150
        gvCustomerData.Columns(14).Width = 150
        gvCustomerData.Columns(15).Width = 150
        gvCustomerData.Columns(16).Width = 150
        gvCustomerData.Columns(17).Width = 150
        gvCustomerData.Columns(18).Visible = False
        gvCustomerData.Columns(19).Visible = False
        gvCustomerData.Columns(20).Width = 150
        gvCustomerData.Columns(21).Width = 150
        gvCustomerData.Columns(22).Width = 150
        gvCustomerData.Columns.ColumnByFieldName("LastName").Caption = "名前"
        gvCustomerData.Columns.ColumnByFieldName("Relationship").Caption = "タイプ"
        gvCustomerData.Columns.ColumnByFieldName("Company").Caption = "会社名"
        gvCustomerData.Columns.ColumnByFieldName("NativeCompany").Caption = "会社名英語"
        gvCustomerData.Columns.ColumnByFieldName("Department").Caption = "部署"
        gvCustomerData.Columns.ColumnByFieldName("Title").Caption = "役職"
        gvCustomerData.Columns.ColumnByFieldName("Telephone").Caption = "電話番号"
        gvCustomerData.Columns.ColumnByFieldName("Fax").Caption = "FAX番号"
        gvCustomerData.Columns.ColumnByFieldName("EMail").Caption = "Eメール"
        gvCustomerData.Columns.ColumnByFieldName("Website").Caption = "ホームページ"
        gvCustomerData.Columns.ColumnByFieldName("Address").Caption = "全住所"
        gvCustomerData.Columns.ColumnByFieldName("Zip").Caption = "郵便番号"
        gvCustomerData.Columns.ColumnByFieldName("State").Caption = "都道府県"
        gvCustomerData.Columns.ColumnByFieldName("City").Caption = "市区町村"
        gvCustomerData.Columns.ColumnByFieldName("Country").Caption = "国"
        gvCustomerData.Columns.ColumnByFieldName("Remarks").Caption = "メモ"
        gvCustomerData.Columns.ColumnByFieldName("UpdateDate").Caption = "更新日"
        gvCustomerData.Columns.ColumnByFieldName("UserName").Caption = "管理者"
        gvCustomerData.Columns.ColumnByFieldName("CompanyLink").Caption = "会社名リンク"
        gvCustomerData.Columns.ColumnByFieldName("SNInfoLink").Caption = "SNリンク"
        gvCustomerData.Columns(0).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(1).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(2).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(3).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(4).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(5).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(6).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(7).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(8).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(9).OptionsColumn.AllowEdit = True
        gvCustomerData.Columns(10).OptionsColumn.AllowEdit = True
        gvCustomerData.Columns(11).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(12).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(13).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(14).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(15).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(16).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(19).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(20).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(21).OptionsColumn.AllowEdit = False
        gvCustomerData.Columns(22).OptionsColumn.AllowEdit = False
        'gvCustomer.Columns(7).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        'gvCustomer.Columns(7).AppearanceCell.Options.UseTextOptions = True
        gvCustomerData.HideFindPanel()

    End Sub
    Delegate Sub AddCoDelegate(ByVal ThreadStatus As String, ByVal CoDv As XPDataView)
    Public Sub AddCoItem(ByVal ThreadStatus As String, ByVal CoDv As XPDataView)
        Select Case ThreadStatus
            Case "START"
                data12.Clear()
                Cursor.Current = Cursors.WaitCursor
                'ShowWaitForm("")
            Case "FINISH"
                'data12.Clear()
                Cursor.Current = currentCursor
                gvCustomerData.RestoreLayoutFromRegistry("gvCustomerData")

                If gvCustomerData.RowCount > 0 Then
                    If CustMultiEditIndex > 0 Then

                        gvCustomerData.MoveBy(CustMultiEditIndex)
                        gvCustomerData.SelectRow(CustMultiEditIndex)
                        ShowStaticMap()
                    Else
                        gvCustomerData.SelectRow(0)
                        ShowStaticMap()
                    End If
                End If
                '_waitForm.Close()
            Case Else
                gcCustomerData.DataSource = CoDv
        End Select
    End Sub
    Private Function ExecuteXPDataView(ByVal Query As String) As XPDataView
        Dim session As New Session()
        Dim dv As New XPDataView()
        session.ConnectionString = SS2DBString
        Dim data As SelectedData = session.ExecuteQueryWithMetadata(Query)
        For Each row In data.ResultSet(0).Rows
            dv.AddProperty(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
        Next
        dv.LoadData(New SelectedData(data.ResultSet(1)))
        ExecuteXPDataView = dv
    End Function
    Public Function LoadCustomerInfoItems(Optional ByVal CompanyLink As String = "") As Boolean
        Dim EventsGUID As String = ""
        Dim ListID As String = ""
        Dim CompanyRoma As String = ""
        Dim Query As String = ""
        Dim HasRows As Boolean = False
        Dim dv As New XPDataView()

        If IsSQL = False Then
            LoadCustomerInfoItems = False
            Exit Function
        End If
        Try
            If Me.gcCustomerData.InvokeRequired Then
                Me.gcCustomerData.Invoke(New AddCoDelegate(AddressOf AddCoItem), New Object() {"START", Nothing})
            Else
                Me.AddCoItem("START", Nothing)
            End If

            If CompanyLink <> "" Then
                Query = "SELECT "
                Query = Query & "ContactsGUID,LastName,Relationship,Company,NativeCompany,Department,Title,Telephone,Fax,EMail,"
                Query = Query & "Website,Address,Zip,State,City,Country,Remarks,UpdateDate,"
                Query = Query & "CardPath1,CardPath2,UserName,CompanyLink,SNInfoLink "
                Query = Query & "FROM tbl_SNContacts WHERE CompanyLink='" & CompanyLink & "' "
            Else
                Query = "SELECT "
                Query = Query & "ContactsGUID,LastName,Relationship,Company,NativeCompany,Department,Title,Telephone,Fax,EMail,"
                Query = Query & "Website,Address,Zip,State,City,Country,Remarks,UpdateDate,"
                Query = Query & "CardPath1,CardPath2,UserName,CompanyLink,SNInfoLink "
                Query = Query & "FROM tbl_SNContacts "
            End If
            dv = ExecuteXPDataView(Query)
            If dv.Count > 0 Then
                HasRows = True
            End If
            If Me.gcCustomerData.InvokeRequired Then
                Me.gcCustomerData.Invoke(New AddCoDelegate(AddressOf AddCoItem), New Object() {"CCThread", dv})
            Else
                Me.AddCoItem("CCThread", dv)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            If Me.gcCustomerData.InvokeRequired Then
                Me.gcCustomerData.Invoke(New AddCoDelegate(AddressOf AddCoItem), New Object() {"FINISH", Nothing})
            Else
                Me.AddCoItem("FINISH", Nothing)
            End If
        End Try
        LoadCustomerInfoItems = HasRows
    End Function
    Private Sub gvCustomerData_MouseUp(sender As Object, e As EventArgs) Handles gvCustomerData.MouseUp
        ShowStaticMap()
    End Sub
    Private Sub gcCustomerData_DoubleClick(sender As Object, e As EventArgs) Handles gcCustomerData.DoubleClick
        EditAddress()
    End Sub
    Private Sub ttsOpenWebAddress_Click(sender As Object, e As EventArgs) Handles ttsOpenWebAddress.Click
        Try
            Dim Website As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Website")
            If Website <> "" Then
                Process.Start(Website)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ttsMailClient_Click(sender As Object, e As EventArgs) Handles ttsMailClient.Click
        Try
            Dim EMail As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "EMail")
            If EMail <> "" Then
                Dim oEMail As Microsoft.Office.Interop.Outlook.MailItem
                Dim i As Integer = 0

                Dim moApp As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application()
                Me.Cursor = Cursors.WaitCursor
                oEMail = DirectCast(moApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem), Microsoft.Office.Interop.Outlook.MailItem)
                With oEMail
                    .To = EMail
                    .Subject = ""
                    .BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML
                    .Body = ""
                    .Recipients.ResolveAll()
                    .Save()
                    .Display()
                End With
                Me.Cursor = Cursors.Default
            End If

        Catch ex As Exception

        End Try
    End Sub
    Dim CardFrontShown As Boolean = True
    Private Sub ttsFindCustomer_Click(sender As Object, e As EventArgs) Handles ttsFindCustomer.Click
        Dim HasItem As Boolean = False

        If gvCustomer.SelectedRowsCount > 0 Then
            Dim CustomerName As String = gvCustomer.GetRowCellValue(gvCustomer.GetSelectedRows(0), "CustomerName").ToString
            HasItem = LoadCustomerInfoItems(CustomerName)
            If HasItem = True Then
                rbnMain.SelectedPage = rpgCustomers
                xtcMain.SelectedTabPage = tabCustomerData
            Else
                LoadCustomerInfoItems()
                CustomerName = Microsoft.VisualBasic.Right(CustomerName, Len(CustomerName) - 2)
                If InStr(1, CustomerName, "(", CompareMethod.Text) > 0 Then
                    CustomerName = Microsoft.VisualBasic.Left(CustomerName, InStr(1, CustomerName, "(", CompareMethod.Text) - 1)
                End If
                rbnMain.SelectedPage = rpgCustomers
                xtcMain.SelectedTabPage = tabCustomerData
                gvCustomerData.ApplyFindFilter(CustomerName)
                If gvCustomerData.RowCount > 0 Then
                    gvCustomerData.SelectRow(0)
                    ShowStaticMap()
                Else
                    gvCustomerData.ApplyFindFilter("")
                End If
            End If
        End If
    End Sub
    Sub MacEventHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim PSTFile As String = ""
        Dim TECFile As String = ""
        Dim PASFile As String = ""
        Dim TECFound As Boolean = False
        Dim PASFound As Boolean = False
        Dim MacPath As String = GblCustomerPath & "\" & clbSigmanest.SelectedValue & "\"
        Dim LineItem As String = ""
        Try
            PSTFile = MacPath & sender.text & ".PST"
            Dim sr As New System.IO.StreamReader(PSTFile, System.Text.Encoding.GetEncoding(GblEncoding))
            While sr.Peek() > -1
                LineItem = sr.ReadLine()
                If InStr(1, UCase(LineItem), ".TEC", CompareMethod.Text) > 0 And InStr(1, UCase(LineItem), "401", CompareMethod.Text) > 0 Then
                    Dim TmpArr() As String
                    TmpArr = Split(LineItem, "=")
                    TECFile = MacPath & TmpArr(1).Trim
                    TECFound = True
                ElseIf InStr(1, UCase(LineItem), ".PAS", CompareMethod.Text) > 0 And InStr(1, UCase(LineItem), "EXEP", CompareMethod.Text) > 0 Then
                    Dim TmpStr As String = ""
                    TmpStr = Microsoft.VisualBasic.Mid(LineItem, LineItem.IndexOf("(") + 2, LineItem.IndexOf(")") - LineItem.IndexOf("(") - 1).Trim
                    TmpStr = Microsoft.VisualBasic.Left(TmpStr, InStr(1, UCase(TmpStr), ",", CompareMethod.Text) - 1)
                    PASFile = MacPath & TmpStr
                    PASFound = True
                End If
                If TECFound = True And PASFound = True Then
                    Exit While
                End If
            End While
            sr.Close()
            If File.Exists(PSTFile) Then
                Process.Start(PSTFile)
            End If
            If File.Exists(TECFile) Then
                Process.Start(TECFile)
            End If
            If File.Exists(PASFile) Then
                Process.Start(PASFile)
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub CreateMacList()
        Dim ttsMac As System.Windows.Forms.ToolStripMenuItem
        Dim MacPath As String = GblCustomerPath & "\" & clbSigmanest.SelectedValue & "\"
        Dim di As New System.IO.DirectoryInfo(MacPath)
        Dim diar1 As System.IO.FileInfo() = di.GetFiles()
        Dim dra As System.IO.FileInfo
        Me.ttsPostFiles.DropDownItems.Clear()
        For Each dra In diar1
            If UCase(Path.GetExtension(dra.FullName)) = ".PST" Then
                ttsMac = New System.Windows.Forms.ToolStripMenuItem
                ttsMac.Name = "tts" & Path.GetFileNameWithoutExtension(dra.FullName)
                ttsMac.Text = Path.GetFileNameWithoutExtension(dra.FullName)
                Me.ttsPostFiles.DropDownItems.Add(ttsMac)
                AddHandler ttsMac.Click, AddressOf MacEventHandler
            End If
        Next
    End Sub
    Private Sub clbSigmanest_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles clbSigmanest.MouseUp
        If e.Button = MouseButtons.Right And GblCustomerPath <> "" Then
            ttsFindCustomer.Visible = False
            ttsMoveToCustomer.Visible = False
            ttsCreateExpenses.Visible = False
            ttsPostFiles.Visible = True
            If clbSigmanest.SelectedValue = "PostFiles" Then
                CreateMacList()
                ttsPostFiles.Visible = True
            Else
                ttsPostFiles.Visible = False
            End If
            Me.cmsCustomer.Show(clbSigmanest, New Point(e.X, e.Y))
        End If
        FolderMode = "clbSigmanest"
    End Sub
    Private Sub clbSource_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles clbSource.MouseUp
        If e.Button = MouseButtons.Right And GblCustomerPath <> "" Then
            ttsFindCustomer.Visible = False
            ttsMoveToCustomer.Visible = False
            ttsCreateExpenses.Visible = False
            ttsPostFiles.Visible = False
            Me.cmsCustomer.Show(clbSource, New Point(e.X, e.Y))
        End If
        FolderMode = "clbSource"
    End Sub
    Private Sub clbVPNItems_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles clbVPNItems.MouseUp
        If e.Button = MouseButtons.Right And GblCustomerPath <> "" Then
            ttsFindCustomer.Visible = False
            ttsMoveToCustomer.Visible = False
            ttsCreateExpenses.Visible = False
            ttsPostFiles.Visible = False
            Me.cmsCustomer.Show(clbVPNItems, New Point(e.X, e.Y))
        End If
        FolderMode = "clbVPNItems"
    End Sub
    Private Sub gvCustomer_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvCustomer.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            ttsFindCustomer.Visible = True
            ttsCreateExpenses.Visible = True
            FolderMode = "gvCustomer"
            Me.cmsCustomer.Show(gcCustomer, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvCustomerData_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvCustomerData.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 75 Then
            Me.cmsCustomerData.Show(gcCustomerData, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub bbiCustFind_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCustFind.ItemClick
        If xtcMain.SelectedTabPage Is tabCustomerData Then
            If gvCustomerData.IsFindPanelVisible = False Then
                gvCustomerData.ShowFindPanel()
            Else
                gvCustomerData.ApplyFindFilter("")
                gvCustomerData.ClearColumnsFilter()
                gvCustomerData.HideFindPanel()
            End If
        ElseIf xtcMain.SelectedTabPage Is tabCustomer Then
            If gvCustomer.IsFindPanelVisible = False Then
                gvCustomer.ShowFindPanel()
            Else
                gvCustomer.HideFindPanel()
            End If
        ElseIf xtcMain.SelectedTabPage Is tabSaleslogix Then
            If gvSalesLogix.IsFindPanelVisible = False Then
                gvSalesLogix.ShowFindPanel()
            Else
                gvSalesLogix.HideFindPanel()
            End If
        ElseIf xtcMain.SelectedTabPage Is tabDocuments Then
            If pdfViewer.Visible = True Then
                pdfViewer.ShowFindDialog()
            ElseIf docViewer.Visible = True Then
                docViewer.ShowSearchForm()
            ElseIf xlsData.Visible = True Then

            End If
        End If
    End Sub
    Private Sub bbiCustClear_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCustClear.ItemClick
        gvCustomerData.ApplyFindFilter("")
        gvCustomerData.ClearColumnsFilter()
        LoadCustomerInfoItems()
    End Sub
    Private Sub picCard_Click(sender As Object, e As EventArgs) Handles picCard.Click
        Try
            Dim CardPath1 As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "CardPath1")
            Dim CardPath2 As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "CardPath2")
            If CardFrontShown = True Then
                If CardPath2 <> "" Then
                    LoadBusinessCardImage(CardPath2)
                    CardFrontShown = False
                End If
            Else
                LoadBusinessCardImage(CardPath1)
                CardFrontShown = True
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub riHyperLinkMail_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles riHyperLinkMail.OpenLink
        If e.EditValue <> "" Then
            Const mailPrefix As String = "mailto:"
            If Not e.EditValue.ToString().ToLower().StartsWith(mailPrefix) Then
                e.EditValue = mailPrefix + e.EditValue.ToString()
            End If
        End If

    End Sub
    Private Sub gvCustomerData_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gvCustomerData.CustomRowCellEdit
        If e.Column.FieldName = "Website" Then
            Dim gv As GridView = sender
            e.RepositoryItem = riHyperLink
        ElseIf e.Column.FieldName = "EMail" Then
            Dim gv As GridView = sender
            e.RepositoryItem = riHyperLinkMail

        End If
    End Sub
    Private Sub imageMap_Click(sender As Object, e As EventArgs) Handles imageMap.Click
        ShowDynamicMap()
    End Sub
    Private Sub bbiAddCustomer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAddCustomer.ItemClick
        Dim frmAddressCard As New frmAddressCard
        frmAddressCard.Add = True
        frmAddressCard.ShowDialog()
        LoadCustomerInfoItems()
    End Sub
    Private Sub EditAddress()
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                Dim AddressCard As New frmAddressCard()
                AddressCard.Edit = True
                AddressCard.txtEMail.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "EMail").ToString
                AddressCard.cmbType.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Relationship").ToString
                AddressCard.cmbUser.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "UserName").ToString
                AddressCard.txtName.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "LastName").ToString
                AddressCard.cmbCompany.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Company").ToString
                AddressCard.txtAddress.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address").ToString
                AddressCard.txtZip.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Zip").ToString
                AddressCard.txtCity.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "City").ToString
                AddressCard.txtState.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "State").ToString
                AddressCard.cmbCountry.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Country").ToString
                AddressCard.txtTelephone.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Telephone").ToString
                AddressCard.txtFax.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Fax").ToString
                AddressCard.txtNote.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Remarks").ToString
                AddressCard.txtWebsite.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Website").ToString
                AddressCard.txtBusiness.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Department").ToString
                AddressCard.txtJob.Text = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Title").ToString
                AddressCard.ContactsGUID = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "ContactsGUID").ToString
                AddressCard.CardPath1 = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "CardPath1").ToString
                AddressCard.CardPath2 = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "CardPath2").ToString
                AddressCard.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'SHthrd = New System.Threading.Thread(AddressOf LoadCustomerInfoItems)
            'SHthrd.Start()
            LoadCustomerInfoItems()
            'SHthrd = New System.Threading.Thread(AddressOf LoadCustomerInfoItems)
            'SHthrd.Start()
        End Try
    End Sub
    Private Sub bbiEditCust_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditCust.ItemClick
        EditAddress()
    End Sub
    Private Sub DeleteAddress()
        Dim i As Integer = 0
        Dim ContactsGUID As String = ""
        Dim Query As String = ""
        If gvCustomerData.SelectedRowsCount > 0 Then
            Try
                Dim success As Boolean = False
                If (MessageBox.Show("このアイテムを削除しますか ?", "RakucaSOFT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No) Then
                    Exit Sub
                End If
                For i = 0 To gvCustomerData.SelectedRowsCount - 1
                    ContactsGUID = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "ContactsGUID")
                    Query = "DELETE FROM tbl_SNContacts where ContactsGUID='" & ContactsGUID & "'"
                    RExecuteNonQuery(Query)
                Next
                LoadCustomerInfoItems()
            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
            Finally

            End Try
        End If
    End Sub
    Private Sub bbiCustDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCustDelete.ItemClick
        DeleteAddress()
    End Sub
    Function StringOutNumbers(ByVal HotStripper As String) As String
        Dim NewValue As String = ""
        For I As Integer = 0 To HotStripper.Length - 1
            If IsNumeric(HotStripper.Substring(I, 1)) = True Then
                NewValue = Microsoft.VisualBasic.Left(HotStripper, I)
                Exit For
            End If
        Next
        NewValue = Replace(NewValue, "-", "")
        NewValue = Replace(NewValue, "番地", "")
        Return NewValue
    End Function
    Function GetCity(ByVal HotStripper As String) As String
        Dim NewValue As String = ""
        Dim GetIndex As Integer = 0
        If InStr(1, HotStripper, "市", CompareMethod.Text) > 0 Then
            GetIndex = InStr(1, HotStripper, "市", CompareMethod.Text)
        ElseIf InStr(1, HotStripper, "都", CompareMethod.Text) > 0 Then
            GetIndex = InStr(1, HotStripper, "区", CompareMethod.Text)
        ElseIf InStr(1, HotStripper, "府", CompareMethod.Text) > 0 Then
            GetIndex = InStr(1, HotStripper, "区", CompareMethod.Text)
        End If
        NewValue = Microsoft.VisualBasic.Left(HotStripper, GetIndex)
        GetCity = NewValue
    End Function
    Private Sub ttsNavitime_Click(sender As Object, e As EventArgs) Handles ttsNavitime.Click
        Dim StreetAddress As String
        Dim Query As String = ""
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                Dim senderAddress As String = GblMyAddress
                StreetAddress = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address")
                Query = "http://www.navitime.co.jp/?keyword0=" & senderAddress
                Query = Query & "&keyword1=" & StreetAddress & ""
                Query = Query & "&ctl=00001&mode=car&tollroad=1&orv=&dnv=&orvAdd=&dnvAdd=&detailset=1"
                Process.Start(Query)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ttsGoogleSearch_Click(sender As Object, e As EventArgs) Handles ttsGoogleSearch.Click
        Dim StreetAddress As String
        Dim Query As String = ""
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                Dim senderAddress As String = GblMyAddress
                StreetAddress = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address")
                Query = "http://maps.google.com/maps?saddr=" & Replace(GblMyAddress, " ", "+") & "&daddr=" & Replace(StreetAddress, " ", "+") & ""
                Process.Start(Query)
                'Dim address As New Uri(Query)
                'webB.Url = address
                'xtcMain.SelectedTabPage = tabBrowser
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ttsSearchJalan_Click(sender As Object, e As EventArgs) Handles ttsSearchJalan.Click
        Dim StreetAddress As String
        Dim Query As String = ""
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                StreetAddress = GetCity(gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address"))
                StreetAddress = System.Web.HttpUtility.UrlEncode(StreetAddress, System.Text.Encoding.GetEncoding(GblEncoding))
                Query = "http://www.jalan.net/uw/uwp2011/uww2011init.do?keyword=" & StreetAddress
                Process.Start(Query)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ttsSearchRakuten_Click(sender As Object, e As EventArgs) Handles ttsSearchRakuten.Click
        Dim StreetAddress As String
        Dim Query As String = ""
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                StreetAddress = GetCity(gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address"))
                StreetAddress = System.Web.HttpUtility.UrlEncode(StreetAddress, System.Text.Encoding.GetEncoding(GblEncoding))
                Query = "http://kw.travel.rakuten.co.jp/keyword/Search.do?f_max=30&f_query=" & StreetAddress
                Process.Start(Query)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ttsSearchWeather_Click(sender As Object, e As EventArgs) Handles ttsSearchWeather.Click
        Dim StreetAddress As String
        Dim Query As String = ""
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                StreetAddress = GetCity(gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address"))
                'StreetAddress = System.Web.HttpUtility.UrlEncode(StreetAddress, System.Text.Encoding.GetEncoding(GblEncoding))
                Query = "http://weather.yahoo.co.jp/weather/search/?p=" & StreetAddress
                Process.Start(Query)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ttsCustomerMultiEdit_Click(sender As Object, e As EventArgs) Handles ttsCustomerMultiEdit.Click
        Dim multiEditFrm As New frmMultiEdit
        Dim i As Integer
        Dim ContactsGUID As String = ""
        If gvCustomerData.SelectedRowsCount > 0 Then
            multiEditFrm.GUIDList.Clear()
            For i = 0 To gvCustomerData.SelectedRowsCount - 1
                ContactsGUID = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "ContactsGUID")
                multiEditFrm.GUIDList.Add(ContactsGUID)
                CustMultiEditIndex = gvCustomerData.GetSelectedRows(i)
            Next
            multiEditFrm.NativeCompany = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "NativeCompany")
            multiEditFrm.CompanyLink = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "CompanyLink")
            multiEditFrm.SNInfoLink = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "SNInfoLink")
            multiEditFrm.CompanyList.Clear()
            multiEditFrm.CompanyList = GblDirList
            multiEditFrm.ShowDialog()
            If multiEditFrm.ChangeMade = True Then
                LoadCustomerInfoItems()
            End If
        End If


    End Sub
    Private Function GetISO(ByVal Prefecture As String)
        Dim IsoCode As String = ""
        Select Case Prefecture
            Case UCase("愛知県")
                IsoCode = "JP-23"
            Case UCase("秋田県")
                IsoCode = "JP-05"
            Case UCase("青森県")
                IsoCode = "JP-02"
            Case UCase("愛媛県")
                IsoCode = "JP-38"
            Case UCase("岐阜県")
                IsoCode = "JP-21"
            Case UCase("群馬県")
                IsoCode = "JP-10"
            Case UCase("広島県")
                IsoCode = "JP-34"
            Case UCase("北海道")
                IsoCode = "JP-01"
            Case UCase("福井県")
                IsoCode = "JP-18"
            Case UCase("福岡県")
                IsoCode = "JP-40"
            Case UCase("福島県")
                IsoCode = "JP-07"
            Case UCase("兵庫県")
                IsoCode = "JP-08"
            Case UCase("茨城県")
                IsoCode = "JP-23"
            Case UCase("石川県")
                IsoCode = "JP-17"
            Case UCase("岩手県")
                IsoCode = "JP-03"
            Case UCase("香川県")
                IsoCode = "JP-37"
            Case UCase("鹿児島県")
                IsoCode = "JP-46"
            Case UCase("神奈川県")
                IsoCode = "JP-14"
            Case UCase("高知県")
                IsoCode = "JP-39"
            Case UCase("熊本県")
                IsoCode = "JP-43"
            Case UCase("京都府")
                IsoCode = "JP-26"
            Case UCase("三重県")
                IsoCode = "JP-24"
            Case UCase("宮城県")
                IsoCode = "JP-04"
            Case UCase("宮崎県")
                IsoCode = "JP-45"
            Case UCase("長野県")
                IsoCode = "JP-20"
            Case UCase("長崎県")
                IsoCode = "JP-42"
            Case UCase("奈良県")
                IsoCode = "JP-29"
            Case UCase("新潟県")
                IsoCode = "JP-15"
            Case UCase("新潟県")
                IsoCode = "JP-15"
            Case UCase("大分県")
                IsoCode = "JP-44"
            Case UCase("岡山県")
                IsoCode = "JP-33"
            Case UCase("沖縄県")
                IsoCode = "JP-47"
            Case UCase("大阪府")
                IsoCode = "JP-27"
            Case UCase("佐賀県")
                IsoCode = "JP-41"
            Case UCase("埼玉県")
                IsoCode = "JP-11"
            Case UCase("滋賀県")
                IsoCode = "JP-25"
            Case UCase("島根県")
                IsoCode = "JP-32"
            Case UCase("静岡県")
                IsoCode = "JP-22"
            Case UCase("千葉県")
                IsoCode = "JP-12"
            Case UCase("栃木県")
                IsoCode = "JP-09"
            Case UCase("徳島県")
                IsoCode = "JP-36"
            Case UCase("東京都")
                IsoCode = "JP-13"
            Case UCase("鳥取県")
                IsoCode = "JP-31"
            Case UCase("富山県")
                IsoCode = "JP-16"
            Case UCase("和歌山県")
                IsoCode = "JP-30"
            Case UCase("山形県")
                IsoCode = "JP-06"
            Case UCase("山口県")
                IsoCode = "JP-35"
            Case UCase("山梨県")
                IsoCode = "JP-19"
            Case ""

            Case Else
                MsgBox(Prefecture)
        End Select
        GetISO = IsoCode
    End Function
    Private Function IsDoubleByte(ByVal checkStr As String)
        Dim word As String = checkStr.Trim()
        Dim containUnicode As Boolean = False
        For x As Integer = 0 To word.Length - 1
            If Char.GetUnicodeCategory(word(x)) = UnicodeCategory.OtherLetter Then
                containUnicode = True
                Exit For
            End If
        Next
        If containUnicode Then
            IsDoubleByte = True
        Else
            IsDoubleByte = False
        End If
    End Function
    Private Function ConvertCountry(ByVal CountryStr As String)
        Dim CountryLatin As String = ""
        Select Case CountryStr
            Case "日本"
                CountryLatin = "Japan"
            Case "アメリカ"
                CountryLatin = "USA"
            Case "インド"
                CountryLatin = "India"
            Case "インドネシア"
                CountryLatin = "Indonesia"
            Case "シンガポール"
                CountryLatin = "Singapore"
            Case "タイ"
                CountryLatin = "Thailand"
            Case "ドイツ"
                CountryLatin = "Germany"
            Case "ニュージーランド"
                CountryLatin = "New Zealand"
            Case "フィリピン"
                CountryLatin = "Philippines"
            Case "ブラジル"
                CountryLatin = "Brazil"
            Case "ベルギー"
                CountryLatin = "Belgium"
            Case "ロシア"
                CountryLatin = "Russia"
            Case "韓国"
                CountryLatin = "Korea"
            Case "台湾"
                CountryLatin = "Taiwan"
            Case "中国"
                CountryLatin = "China"
            Case "南アフリカ"
                CountryLatin = "South Africa"
            Case Else
                CountryLatin = "Japan"
        End Select
        ConvertCountry = CountryLatin
    End Function
    Private Function FormatAddress(ByVal FullAddr As String, ByVal City As String, ByVal State As String, ByVal Town As String)
        Dim NewAddr As String
        NewAddr = Replace(FullAddr, City, "")
        NewAddr = Replace(NewAddr, State, "")
        ' NewAddr = Replace(NewAddr, Town, "")
        FormatAddress = NewAddr
    End Function
    Private Sub GetAddress(ByVal FullAddress As String, ByRef ZipCode As String, ByRef StreetAddress As String, ByRef StreetAddress2 As String, ByRef City As String, ByRef State As String, ByRef Country As String, ByRef PrefIso As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim db_reader As OleDbDataReader
        Dim Prefecture As String = ""
        Dim Town As String = ""
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim postalcode As String = Replace(ZipCode, "-", "")
        Try
            connUsers = New System.Data.OleDb.OleDbConnection
            connUsers.ConnectionString = SSDBString
            connUsers.Open()
            cmd.Connection = connUsers
            cmd.CommandText = "SELECT Prefecture, City, Town, PrefectureKana, CityKana, TownKana FROM tbl_PostalCodes WHERE PostalCode='" & postalcode & "'"
            db_reader = cmd.ExecuteReader(CommandBehavior.Default)
            Do While db_reader.Read
                Prefecture = db_reader.Item("Prefecture")
                City = db_reader.Item("City")
                Town = db_reader.Item("Town")
            Loop
            cmd = Nothing
            connUsers.Close()
            ZipCode = postalcode
            City = City
            State = Prefecture
            Country = ConvertCountry(Country)
            PrefIso = GetISO(Prefecture)
            StreetAddress = FormatAddress(FullAddress, City, State, Town)
            StreetAddress2 = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub CreateSalesLogixCSV(ByVal strFileName As String)
        Dim Company As String = ""
        Dim NativeCompany As String = ""
        Dim Name, FirstName, NativeFirstName, LastName, NativeLastName, Title, Department, TypeStr As String
        Dim AddressStr, StreetAddress, StreetAddress2, City, State, Country, Zip, Phone, Fax, EMail, Note, PrefIso As String
        Dim CSVLine As String = ""
        Dim sw As New System.IO.StreamWriter(strFileName, False, System.Text.Encoding.Unicode)
        sw.WriteLine("Company,NativeCompany,FirstName,NativeFirstName,LastName,NativeLastName,Title,Department,Address1,Address2,City,State,Country,Zip,Phone,Fax,EMail,Note,SubdivisionCode")

        For i = 0 To gvCustomerData.RowCount - 1
            Try
                Company = gvCustomerData.GetRowCellValue(i, "Company").Trim
                Name = gvCustomerData.GetRowCellValue(i, "Name").Trim
                TypeStr = gvCustomerData.GetRowCellValue(i, "Type").Trim
                TypeStr = ""
                Title = gvCustomerData.GetRowCellValue(i, "Title").Trim
                Department = gvCustomerData.GetRowCellValue(i, "Business").Trim
                AddressStr = gvCustomerData.GetRowCellValue(i, "Address").Trim
                Zip = gvCustomerData.GetRowCellValue(i, "Zip").Trim
                StreetAddress = ""
                StreetAddress2 = ""
                City = ""
                State = ""
                Country = ""
                PrefIso = ""
                Phone = gvCustomerData.GetRowCellValue(i, "Telephone").Trim
                Fax = gvCustomerData.GetRowCellValue(i, "Fax").Trim
                EMail = gvCustomerData.GetRowCellValue(i, "EMail").Trim
                Note = gvCustomerData.GetRowCellValue(i, "CompanyLink").Trim
                If IsDoubleByte(Company) Then
                    NativeCompany = Company
                    Company = ""
                Else
                    Company = Company
                    NativeCompany = ""
                End If
                If IsDoubleByte(Name) = True Then
                    LastName = Name
                    NativeLastName = Name
                    FirstName = ""
                    NativeFirstName = ""
                Else
                    LastName = Name
                    FirstName = ""
                    NativeLastName = ""
                    NativeFirstName = ""
                End If
                GetAddress(AddressStr, Zip, StreetAddress, StreetAddress2, City, State, Country, PrefIso)
                CSVLine = Company & "," & NativeCompany & "," & FirstName & "," & NativeFirstName & "," & LastName & "," & NativeLastName & ","
                CSVLine = CSVLine & Title & "," & Department & "," & StreetAddress & "," & StreetAddress2 & "," & City & ","
                CSVLine = CSVLine & State & "," & Country & "," & Zip & "," & Phone & "," & Fax & "," & EMail & "," & Note & "," & PrefIso
                sw.WriteLine(CSVLine)
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

        Next

        sw.Close()
    End Sub
    Private Sub bbiExportToCSV_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportToCSV.ItemClick
        Dim fd As SaveFileDialog = New SaveFileDialog()
        Dim strFileName As String = ""
        fd.Title = "ファイル名選択"
        'fd.InitialDirectory = GblQuotationPath
        fd.Filter = "CSV (*.CSV*)|*.CSV*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            If InStr(1, UCase(strFileName), ".CSV", CompareMethod.Text) = 0 Then
                strFileName = fd.FileName & ".CSV"
            End If
            If bbiShowCustomer.Down = True Then
                CreateSalesLogixCSV(strFileName)
            ElseIf bbiShowCompany.Down = True Then
                frmCompanyData.gvCompany.ExportToCsv(strFileName)
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
    Private Sub CreateEMailList(ByVal ListName As String)
        Dim CompanyName As String = ""
        Dim CustomerName As String = ""
        Dim EMailAddress As String = ""
        Dim i As Integer = 0
        Dim LineItem As String = ""
        Dim EMailPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailList\" & ListName
        Dim sw As New System.IO.StreamWriter(EMailPath, False, System.Text.Encoding.GetEncoding(GblEncoding))
        For i = 0 To gvCustomerData.SelectedRowsCount - 1
            CompanyName = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Company").Trim
            CustomerName = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Name").Trim
            EMailAddress = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "EMail").Trim
            If EMailAddress <> "" And IsValidEMailFormat(EMailAddress) = True Then
                sw.WriteLine(CompanyName & "," & CustomerName & "," & EMailAddress)
            End If
            frmProgress.UpdateProgress(i + 1)
        Next
        sw.Close()
        frmWebMail.CheckMailList()
    End Sub
    Dim frmProgress As frmProgress
    Private Sub ttsAddToEMailList_Click(sender As Object, e As EventArgs) Handles ttsAddToEMailList.Click
        Dim frmNew As New frmNew
        frmNew.LabelControl1.Text = "リスト名："
        frmNew.ShowDialog()
        Dim ListName As String = frmNew.CustomerName
        If ListName <> "" Then
            ListName = ListName & ".CSV"

            If gvCustomerData.SelectedRowsCount > 0 Then
                frmProgress = New frmProgress
                frmProgress.pbcStatus.Properties.Minimum = 0
                frmProgress.pbcStatus.Properties.Maximum = gvCustomerData.SelectedRowsCount
                frmProgress.pbcStatus.Properties.Step = 1
                frmProgress.pbcStatus.Position = 0
                frmProgress.Show()
                Dim SLthrd As System.Threading.Thread
                SLthrd = New System.Threading.Thread(DirectCast(Sub() CreateEMailList(ListName), ThreadStart))
                SLthrd.Start()
            End If
        End If
    End Sub


    Private Function FormatStrData(ByVal StrData As String) As String
        StrData = Replace(StrData, """", "")
        FormatStrData = StrData
    End Function
    Private Function IsAddressUsed(ByVal CompanyName As String, ByVal NamePerson As String, ByVal EMailId As String, ByVal Telephone As String) As String
        Dim ContactsGUID As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim Query As String = ""
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        cmd.Connection = connUsers
        Query = "SELECT ContactsGUID FROM tbl_SNContacts WHERE (Company='" & CompanyName & "' AND LastName='" & NamePerson & "' AND (EMail='" & EMailId & "' OR Telephone='" & Telephone & "')) OR "
        Query = Query & "(Company='" & CompanyName & "' AND LastName='" & NamePerson & "' AND EMail='')"
        cmd.CommandText = Query
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            ContactsGUID = db_reader.Item("ContactsGUID").ToString
        Loop
        cmd = Nothing
        connUsers.Close()
        IsAddressUsed = ContactsGUID
    End Function
    Private Sub copyDB_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles copyDB.ItemClick   'Tanu
        Dim Company As String = ""
        Dim NativeCompany As String = ""
        Dim FirstName, LastName, Title, Department, Relationship As String
        Dim AddressStr, StreetAddress, StreetAddress2, City, State, Country, Zip, Phone, Fax, EMail, Note, PrefIso As String
        Dim ListID, ContactsGUID, Website, CardPath1, CardPath2, UserName, Remarks, CompanyLink As String
        Dim UpdateDate As Date
        Dim CSVLine As String = ""
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim Query As String = ""
        Dim ExistingContactsGUID As String = ""
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        For i = 0 To gvCustomerData.RowCount - 1
            Try
                ListID = "SigmaJapan"
                ContactsGUID = FormatStrData(gvCustomerData.GetRowCellValue(i, "ContactsGUID"))
                Company = FormatStrData(gvCustomerData.GetRowCellValue(i, "Company"))
                NativeCompany = ""
                LastName = FormatStrData(gvCustomerData.GetRowCellValue(i, "Name"))
                FirstName = ""
                Relationship = FormatStrData(gvCustomerData.GetRowCellValue(i, "Relationship"))
                Title = FormatStrData(gvCustomerData.GetRowCellValue(i, "Title"))
                Department = FormatStrData(gvCustomerData.GetRowCellValue(i, "Department"))
                AddressStr = FormatStrData(gvCustomerData.GetRowCellValue(i, "Address"))
                Zip = FormatStrData(gvCustomerData.GetRowCellValue(i, "Zip"))
                StreetAddress = ""
                StreetAddress2 = ""
                City = ""
                State = ""
                Country = FormatStrData(gvCustomerData.GetRowCellValue(i, "Country"))
                PrefIso = ""
                Phone = FormatStrData(gvCustomerData.GetRowCellValue(i, "Telephone"))
                Fax = FormatStrData(gvCustomerData.GetRowCellValue(i, "Fax"))
                EMail = FormatStrData(gvCustomerData.GetRowCellValue(i, "EMail"))
                Website = FormatStrData(gvCustomerData.GetRowCellValue(i, "Website"))
                CardPath1 = FormatStrData(gvCustomerData.GetRowCellValue(i, "CardPath1"))
                CardPath2 = FormatStrData(gvCustomerData.GetRowCellValue(i, "CardPath2"))
                UserName = FormatStrData(gvCustomerData.GetRowCellValue(i, "UserName"))
                Remarks = FormatStrData(gvCustomerData.GetRowCellValue(i, "Remarks"))
                UpdateDate = gvCustomerData.GetRowCellValue(i, "UpdateDate")
                CompanyLink = FormatStrData(gvCustomerData.GetRowCellValue(i, "CompanyLink"))
                ExistingContactsGUID = IsAddressUsed(CompanyName, LastName, EMail, Phone)
                GetAddress(AddressStr, Zip, StreetAddress, StreetAddress2, City, State, Country, PrefIso)
                Note = ""
                If ExistingContactsGUID = "" Then
                    Query = "INSERT INTO tbl_SNContacts "
                    Query = Query & "(ContactsGUID,ListID,Company,NativeCompany,Relationship,FirstName,LastName,EMail,"
                    Query = Query & "Zip,Address,Country,State,City,Address1,Telephone,Fax,Website,Title,Department,"
                    Query = Query & "CardPath1,CardPath2,UserName,Remarks,UpdateDate,CompanyLink) "
                    Query = Query & "VALUES ('"
                    Query = Query & ContactsGUID & "','" & ListID & "','" & Company & "','" & NativeCompany & "','"
                    Query = Query & Relationship & "','" & FirstName & "','" & LastName & "','" & EMail & "','"
                    Query = Query & Zip & "','" & AddressStr & "','" & Country & "','" & State & "','" & City & "','"
                    Query = Query & StreetAddress & "','" & Phone & "','" & Fax & "','" & Website & "','" & Title & "','"
                    Query = Query & Department & "','" & CardPath1 & "','" & CardPath2 & "','" & UserName & "','"
                    Query = Query & Remarks & "','" & UpdateDate & "','" & CompanyLink & "') "
                Else
                    Query = "UPDATE tbl_SNContacts SET "
                    Query = Query & "ListID='" & ListID & "', Company='" & CompanyName & "', NativeCompany='" & NativeCompany & "', "
                    Query = Query & "Relationship='" & Relationship & "', FirstName='" & FirstName & "', LastName='" & LastName & "', "
                    Query = Query & "EMail='" & EMail & "', Zip='" & Zip & "', Address='" & AddressStr & "', "
                    Query = Query & "Country='" & Country & "', State='" & State & "', City='" & City & "', "
                    Query = Query & "Address1='" & StreetAddress & "', Telephone='" & Phone & "', Fax='" & Fax & "', "
                    Query = Query & "Website='" & Website & "', Title='" & Title & "', Department='" & Department & "', "
                    Query = Query & "CardPath1='" & CardPath1 & "', CardPath2='" & CardPath2 & "', UserName='" & UserName & "', "
                    Query = Query & "Remarks='" & Remarks & "', UpdateDate='" & UpdateDate & "', CompanyLink='" & CompanyLink & "' "
                    Query = Query & "WHERE ContactsGUID='" & ExistingContactsGUID & "' "
                End If
                cmd.Connection = connUsers
                cmd.CommandText = Query
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                'MsgBox(Query)
                'MsgBox(ex.Message)
            End Try
        Next
        cmd = Nothing
        connUsers.Close()
    End Sub
    Private Sub LoadPostalCSV()
        Dim CSVPath As String = SigmanestDataPath & "Applications\SigmaAPP\Data\"
        Dim CSVFile As String = ""
        Dim LineItem As String = ""
        Dim CurrentRecord As String() ' this array will hold each line of data
        Dim RegionCode, PostalCode, PrefectureKana, CityKana, TownKana, Prefecture, City, Town As String
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim Query As String = ""
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        connUsers.Open()


        If Directory.Exists(CSVPath) Then
            Dim di As New System.IO.DirectoryInfo(CSVPath)
            Dim diar1 As System.IO.FileInfo() = di.GetFiles()
            Dim dra As System.IO.FileInfo
            For Each dra In diar1
                If UCase(Path.GetExtension(dra.FullName)) = ".CSV" Then
                    CSVFile = dra.FullName
                    Exit For
                End If
            Next
            If File.Exists(CSVFile) Then
                Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(CSVFile, System.Text.Encoding.GetEncoding(GblEncoding))
                afile.TextFieldType = FileIO.FieldType.Delimited
                afile.Delimiters = New String() {","}
                afile.HasFieldsEnclosedInQuotes = True
                ' parse the actual file
                cmd.Connection = connUsers
                Query = "DELETE FROM tbl_PostalCodes "
                cmd.CommandText = Query
                cmd.ExecuteNonQuery()

                Do While Not afile.EndOfData
                    Try
                        CurrentRecord = afile.ReadFields
                        RegionCode = CurrentRecord(0)
                        PostalCode = CurrentRecord(2)
                        PrefectureKana = CurrentRecord(3)
                        CityKana = CurrentRecord(4)
                        TownKana = CurrentRecord(5)
                        Prefecture = CurrentRecord(6)
                        City = CurrentRecord(7)
                        Town = CurrentRecord(8)
                        cmd.Connection = connUsers
                        Query = "INSERT INTO tbl_PostalCodes (RegionCode,PostalCode,PrefectureKana,CityKana,TownKana,"
                        Query = Query & "Prefecture,City,Town) "
                        Query = Query & "VALUES ('" & RegionCode & "','" & PostalCode & "','" & PrefectureKana & "','" & CityKana & "','" & TownKana & "','"
                        Query = Query & Prefecture & "','" & City & "','" & Town & "') "
                        cmd.CommandText = Query
                        cmd.ExecuteNonQuery()
                    Catch ex As FileIO.MalformedLineException
                        MsgBox(ex.Message)
                        cmd = Nothing
                        connUsers.Close()
                        afile.Close()
                    End Try
                Loop
                afile.Close()
                cmd = Nothing
                connUsers.Close()
            End If
        End If
    End Sub
    Private Sub btnPostalCodes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPostalCodes.ItemClick
        LoadPostalCSV()
    End Sub
#End Region
#Region "Eight"
    Private Function IsAddressAvail(ByVal CompanyName As String, ByVal NamePerson As String, ByVal EMailId As String) As String
        Dim ContactsGUID As String = ""
        Dim db_reader As OleDbDataReader
        Dim connUsers As System.Data.OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim Query As String = ""
        connUsers = New System.Data.OleDb.OleDbConnection
        connUsers.ConnectionString = SSDBString
        cmd.Connection = connUsers

        connUsers.Open()
        cmd.Connection = connUsers
        Query = "Select ContactsGUID from tbl_SNContacts where (Company='" & CompanyName & "' AND Name='" & NamePerson & "' AND EMail='" & EMailId & "') OR "
        Query = Query & "(Company='" & CompanyName & "' AND Name='" & NamePerson & "' AND EMail='')"
        cmd.CommandText = Query
        db_reader = cmd.ExecuteReader(CommandBehavior.Default)
        Do While db_reader.Read
            ContactsGUID = db_reader.Item("ContactsGUID").ToString
        Loop
        cmd = Nothing
        connUsers.Close()
        IsAddressAvail = ContactsGUID
    End Function
    Private Sub bbiEight_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEight.ItemClick
        Dim frmEight As New frmEight
        frmEight.ShowDialog()
    End Sub

#End Region
#Region "CompanyData"
    Private Sub bbiShowCustomer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiShowCustomer.ItemClick
        bbiShowCompany.Down = False
        bbiShowCustomer.Down = True
        bbiSalesLogix.Down = False
        xtcMain.SelectedTabPage = tabCustomerData
    End Sub
    Private Sub bbiShowCompany_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiShowCompany.ItemClick
        bbiShowCompany.Down = True
        bbiShowCustomer.Down = False
        bbiSalesLogix.Down = False
        xtcMain.SelectedTabPage = tabCompanySearch
    End Sub
#End Region
#Region "Envelopes"
    Public Sub FindandReplace(doc As Word.Document, Findtext As String, Replacetext As String)

        Dim myStoryRange = doc.Range()

        'First search the main document using the Selection
        If True Then
            myStoryRange.Find.Text = Findtext
            myStoryRange.Find.Replacement.Text = Replacetext
            myStoryRange.Find.Forward = True
            myStoryRange.Find.Wrap = Word.WdFindWrap.wdFindContinue
            myStoryRange.Find.Format = False
            myStoryRange.Find.MatchCase = False
            myStoryRange.Find.MatchWholeWord = False
            myStoryRange.Find.MatchWildcards = False
            myStoryRange.Find.MatchSoundsLike = False
            myStoryRange.Find.MatchAllWordForms = False
            myStoryRange.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)
        End If

        'Now search all other stories using Ranges
        For Each myStoryRange In doc.StoryRanges
            If myStoryRange.StoryType <> Word.WdStoryType.wdMainTextStory Then
                If True Then
                    myStoryRange.Find.Text = Findtext
                    myStoryRange.Find.Replacement.Text = Replacetext
                    myStoryRange.Find.Wrap = Word.WdFindWrap.wdFindContinue
                    myStoryRange.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)
                End If
                While (myStoryRange.NextStoryRange IsNot Nothing)
                    myStoryRange = myStoryRange.NextStoryRange
                    If True Then
                        myStoryRange.Find.Text = Findtext
                        myStoryRange.Find.Replacement.Text = Replacetext
                        myStoryRange.Find.Wrap = Word.WdFindWrap.wdFindContinue
                        myStoryRange.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)
                    End If
                End While
            End If
        Next
    End Sub
    Private Sub LoadEnvelope(ByVal EnvPath As String, ByVal CZip As String, ByVal CAddress As String, ByVal CCompany As String, ByVal CName As String)

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Try
            oWord = CreateObject("Word.Application")
            oWord.Visible = True
            oDoc = oWord.Documents.Open(EnvPath, ReadOnly:=False)
            oWord.Selection.Find.ClearFormatting()
            Dim TmpArr() As String
            TmpArr = Split(CZip, "-")
            FindandReplace(oDoc, "111", TmpArr(0))
            FindandReplace(oDoc, "0000", TmpArr(1))
            FindandReplace(oDoc, "住所", CAddress)
            FindandReplace(oDoc, "会社名", CCompany)
            FindandReplace(oDoc, "名前", CName)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ttsEnvelopeLarge_Click(sender As Object, e As EventArgs) Handles ttsEnvelopeLarge.Click
        Dim CName, CCompany, CZip, CAddress As String
        Dim Query As String = ""
        Dim EnvPath As String = SigmanestDataPath & "\Applications\SigmaAPP\PrintTemplates\SigmaEnvelope.docx"
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                CAddress = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address")
                CName = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "LastName")
                CCompany = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Company")
                CZip = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Zip")
                LoadEnvelope(EnvPath, CZip, CAddress, CCompany, CName)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ttsEnvelopeSmall_Click(sender As Object, e As EventArgs) Handles ttsEnvelopeSmall.Click
        Dim CName, CCompany, CZip, CAddress As String
        Dim Query As String = ""
        Dim EnvPath As String = SigmanestDataPath & "\Applications\SigmaAPP\PrintTemplates\SigmaEnvelopeS.docx"
        Try
            If gvCustomerData.SelectedRowsCount > 0 Then
                CAddress = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Address")
                CName = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "LastName")
                CCompany = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Company")
                CZip = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Zip")
                LoadEnvelope(EnvPath, CZip, CAddress, CCompany, CName)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "LaunchSigmanest"
    Private Sub LoadSigmanestColumns()
        Dim i As Integer = 0
        data3 = New DataTable("gvSigmaNEST")
        data3.Clear()
        data3.BeginInit()
        AddColumn(data3, "IconPic", GetType(Image))
        AddColumn(data3, "BuildName", System.Type.GetType("System.String"))
        AddColumn(data3, "Version", System.Type.GetType("System.String"))
        AddColumn(data3, "ModifyDate", System.Type.GetType("System.String"))
        AddColumn(data3, "SigmaNESTPath", System.Type.GetType("System.String"))
        data3.EndInit()

        gcSigmaNEST.DataSource = data3
        gcSigmaNEST.DefaultView.PopulateColumns()
        gvSigmaNEST.Columns(0).Width = 50
        gvSigmaNEST.Columns(1).Width = 200
        gvSigmaNEST.Columns(2).Width = 150
        gvSigmaNEST.Columns(3).Width = 150
        gvSigmaNEST.Columns(4).Visible = False
        gvSigmaNEST.Columns.ColumnByFieldName("IconPic").Caption = "アイコン"
        gvSigmaNEST.Columns.ColumnByFieldName("BuildName").Caption = "ビルド名"
        gvSigmaNEST.Columns.ColumnByFieldName("Version").Caption = "バージョン"
        gvSigmaNEST.Columns.ColumnByFieldName("ModifyDate").Caption = "作成日"
        gvSigmaNEST.Columns.ColumnByFieldName("SigmaNESTPath").Caption = "パス"
        gvSigmaNEST.Columns("IconPic").ColumnEdit = riPicF
    End Sub
    Private Sub LoadProductsColumns()
        Dim i As Integer = 0
        data30 = New DataTable("gvProducts")
        data30.Clear()
        data30.BeginInit()
        AddColumn(data30, "IconPic", GetType(Image))
        AddColumn(data30, "BuildName", System.Type.GetType("System.String"))
        AddColumn(data30, "Version", System.Type.GetType("System.String"))
        AddColumn(data30, "ModifyDate", System.Type.GetType("System.String"))
        AddColumn(data30, "ProductsPath", System.Type.GetType("System.String"))
        data30.EndInit()

        gcProducts.DataSource = data30
        gcProducts.DefaultView.PopulateColumns()
        gvProducts.Columns(0).Width = 50
        gvProducts.Columns(1).Width = 200
        gvProducts.Columns(2).Width = 150
        gvProducts.Columns(3).Width = 150
        gvProducts.Columns(4).Visible = False
        gvProducts.Columns.ColumnByFieldName("IconPic").Caption = "アイコン"
        gvProducts.Columns.ColumnByFieldName("BuildName").Caption = "ビルド名"
        gvProducts.Columns.ColumnByFieldName("Version").Caption = "バージョン"
        gvProducts.Columns.ColumnByFieldName("ModifyDate").Caption = "作成日"
        gvProducts.Columns.ColumnByFieldName("ProductsPath").Caption = "パス"
        gvProducts.Columns("IconPic").ColumnEdit = riPicF
    End Sub
    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function

    Private Sub LoadSigmanestData()
        Dim ExtAppsPath As String = Application.StartupPath & "\Products.txt"
        data3.Clear()
        data30.Clear()
        Try
            If File.Exists(ExtAppsPath) Then
                Dim sr As New System.IO.StreamReader(ExtAppsPath, System.Text.Encoding.GetEncoding(GblEncoding))
                Dim LineItem As String = ""
                Dim TmpArr() As String
                Dim SigmanestPath As String = ""
                Dim SigmanestDate As String = ""
                While sr.Peek() > -1
                    LineItem = sr.ReadLine()
                    TmpArr = Split(LineItem, ",")
                    SigmanestPath = TmpArr(1)
                    If File.Exists(SigmanestPath) = False And InStr(1, SigmanestPath, "D:\", CompareMethod.Text) > 0 Then
                        SigmanestPath = Replace(SigmanestPath, "D:\", "C:\")
                    End If

                    If File.Exists(SigmanestPath) Then
                        Dim ico As Icon = Icon.ExtractAssociatedIcon(SigmanestPath)
                        Dim img As Bitmap = ico.ToBitmap
                        SigmanestDate = Microsoft.VisualBasic.Left(FileDateTime(SigmanestPath).ToString, 10)
                        data30.Rows.Add(img, TmpArr(0), GetFileVersionInfo(SigmanestPath), SigmanestDate, SigmanestPath)
                    End If
                End While
                sr.Close()
            End If
            If Directory.Exists(SigmanestPath) Then
                For Each Dir As String In Directory.GetDirectories(SigmanestPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    If InStr(1, UCase(dra.Name), "SIGMANEST", CompareMethod.Text) > 0 And InStr(1, UCase(dra.Name), "DEVELOP", CompareMethod.Text) <= 0 Then
                        Dim diar1 As System.IO.FileInfo() = dra.GetFiles()
                        Dim SigmanestPath As String = ""
                        Dim SigmanestDate As String = ""
                        For Each file In diar1
                            SigmanestPath = file.FullName
                            If UCase(Path.GetFileName(SigmanestPath)) = "SIGMANEST.EXE" Then
                                SigmanestDate = Microsoft.VisualBasic.Left(file.LastWriteTime.ToString, 10)
                                Dim ico As Icon = Icon.ExtractAssociatedIcon(SigmanestPath)
                                Dim img As Bitmap = ico.ToBitmap
                                data3.Rows.Add(img, dra.Name, GetFileVersionInfo(SigmanestPath), SigmanestDate, dra.FullName)
                                Exit For
                            End If
                        Next
                    ElseIf InStr(1, UCase(dra.Name), "SIMTRANS", CompareMethod.Text) > 0 Then
                        Dim diar1 As System.IO.FileInfo() = dra.GetFiles()
                        Dim SigmanestPath As String = ""
                        Dim SigmanestDate As String = ""
                        For Each file In diar1
                            SigmanestPath = file.FullName
                            If UCase(Path.GetFileName(SigmanestPath)) = "SIMTRANS.EXE" And InStr(1, UCase(Path.GetFileName(SigmanestPath)), ".EXE", CompareMethod.Text) > 0 Then
                                SigmanestPath = file.FullName
                                SigmanestDate = Microsoft.VisualBasic.Left(file.LastWriteTime.ToString, 10)
                                Dim ico As Icon = Icon.ExtractAssociatedIcon(SigmanestPath)
                                Dim img As Bitmap = ico.ToBitmap
                                data30.Rows.Add(img, dra.Name, GetFileVersionInfo(SigmanestPath), SigmanestDate, SigmanestPath)
                                Exit For
                            End If
                        Next
                    Else
                        Dim diar1 As System.IO.FileInfo() = dra.GetFiles()
                        Dim SigmanestPath As String = ""
                        Dim SigmanestDate As String = ""
                        For Each file In diar1
                            SigmanestPath = file.FullName
                            If InStr(1, UCase(Path.GetFileName(SigmanestPath)), ".EXE", CompareMethod.Text) > 0 Then
                                SigmanestPath = file.FullName
                                SigmanestDate = Microsoft.VisualBasic.Left(file.LastWriteTime.ToString, 10)
                                Dim ico As Icon = Icon.ExtractAssociatedIcon(SigmanestPath)
                                Dim img As Bitmap = ico.ToBitmap
                                data30.Rows.Add(img, dra.Name, GetFileVersionInfo(SigmanestPath), SigmanestDate, SigmanestPath)
                                Exit For
                            End If
                        Next
                    End If

                Next
            Else
                MsgBox("SigmaNEST のパスを変更して下さい。")
            End If

            gvSigmaNEST.Columns("ModifyDate").SortOrder = ColumnSortOrder.Descending
            gvSigmaNEST.MoveFirst()
            gvProducts.Columns("ModifyDate").SortOrder = ColumnSortOrder.Descending
            gvProducts.MoveFirst()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       
    End Sub
    Private Sub LoadSigmaNESTFiles(ByVal CustomerName As String, ByVal CustomerPath As String)  'Add stuff
        clbSigmanest.Items.Clear()
        clbSource.Items.Clear()
        clbVPNItems.Items.Clear()
        For Each Dir As String In Directory.GetDirectories(CustomerPath)
            Dim dra As New System.IO.DirectoryInfo(Dir)
            If bbiCompanyMode.Down = True Then
                Select Case UCase(dra.Name)
                    Case "DESKTOPS"
                        'clbSigmanest.Items.Add(dra.Name, False)
                    Case "INIFILES"
                        'clbSigmanest.Items.Add(dra.Name, False)
                    Case "NESTINGINIFILES"
                        clbSigmanest.Items.Add(dra.Name, False)
                    Case "POSTFILES"
                        clbSigmanest.Items.Add(dra.Name, True)
                    Case "REPLACEFILES", "REPLACE"
                        clbSigmanest.Items.Add(dra.Name, False)
                    Case "REPORTS"
                        clbSigmanest.Items.Add(dra.Name, True)
                    Case "TOOLS"
                        clbSigmanest.Items.Add(dra.Name, True)
                    Case "DBASE", "DATABASE"
                        clbSigmanest.Items.Add(dra.Name, True)
                    Case Else
                        clbSource.Items.Add(dra.Name, False)
                End Select
            Else
                Select Case dra.Name
                    Case "PostFiles"
                        clbSigmanest.Items.Add(dra.Name, True)
                    Case Else
                        clbSource.Items.Add(dra.Name, False)
                End Select

            End If
        Next
        If IsVPN = True Then
            If Directory.Exists(VPNCustomerPath) Then
                For Each Dir As String In Directory.GetDirectories(VPNCustomerPath)
                    Dim dra As New System.IO.DirectoryInfo(Dir)
                    clbVPNItems.Items.Add(dra.Name, False)
                Next
            End If
        End If
        GblCustomerPath = CustomerPath
    End Sub
    Private Sub SetSigmanestMode()
        Dim i As Integer = 0
        Dim SimNo As String = ""
        Dim SimTmp() As String
        Dim SigmaStartupIniPath As String = SigmaINIPath & "StartUpSeq.ini"
        Dim SigmaNEST As String = "NO"
        Dim SigmaNESTLite As String = "NO"
        Dim SigmaNESTBlack As String = "NO"
        Dim CutToLength As String = "NO"
        Dim Companion As String = "NO"
        Dim SigmanestQuote As String = "NO"
        Try
            If File.Exists(SigmaStartupIniPath) Then
                File.Delete(SigmaStartupIniPath)
            End If
            If bbiSigmanest.Down = True Then
                SigmaNEST = "YES"
                SigmaNESTLite = "YES"
                SigmaNESTBlack = "YES"
                CutToLength = "YES"
                Companion = "YES"
                SigmanestQuote = "YES"
            ElseIf bbiCompanion.Down = True Then
                SigmaNEST = "NO"
                SigmaNESTLite = "NO"
                SigmaNESTBlack = "NO"
                CutToLength = "NO"
                Companion = "YES"
                SigmanestQuote = "NO"
            ElseIf bbiQuote.Down = True Then
                SigmaNEST = "NO"
                SigmaNESTLite = "NO"
                SigmaNESTBlack = "NO"
                CutToLength = "NO"
                Companion = "NO"
                SigmanestQuote = "YES"
            ElseIf bbiCTL.Down = True Then
                SigmaNEST = "NO"
                SigmaNESTLite = "NO"
                SigmaNESTBlack = "NO"
                CutToLength = "YES"
                Companion = "NO"
                SigmanestQuote = "NO"
            ElseIf bbiLite.Down = True Then
                SigmaNEST = "NO"
                SigmaNESTLite = "YES"
                SigmaNESTBlack = "NO"
                CutToLength = "NO"
                Companion = "NO"
                SigmanestQuote = "NO"
            End If
            If InStr(1, SimNoList, ",", CompareMethod.Text) > 0 Then
                SimTmp = Split(SimNoList, ",")
                For i = 0 To SimTmp.Count - 1
                    SimNo = SimTmp(i)
                    ChangeSNIni(SigmaStartupIniPath, SimNo, "1 SigmaNEST", SigmaNEST)
                    ChangeSNIni(SigmaStartupIniPath, SimNo, "2 SigmaNEST Lite", SigmaNESTLite)
                    ChangeSNIni(SigmaStartupIniPath, SimNo, "3 SigmaNEST Black Box", SigmaNESTBlack)
                    ChangeSNIni(SigmaStartupIniPath, SimNo, "5 Cut To Length", CutToLength)
                    ChangeSNIni(SigmaStartupIniPath, SimNo, "13 SigmaNEST Companion", Companion)
                    ChangeSNIni(SigmaStartupIniPath, SimNo, "14 SigmaNEST Quote Client", SigmanestQuote)
                Next
            Else
                SimNo = SimNoList
                ChangeSNIni(SigmaStartupIniPath, SimNo, "1 SigmaNEST", SigmaNEST)
                ChangeSNIni(SigmaStartupIniPath, SimNo, "2 SigmaNEST Lite", SigmaNESTLite)
                ChangeSNIni(SigmaStartupIniPath, SimNo, "3 SigmaNEST Black Box", SigmaNESTBlack)
                ChangeSNIni(SigmaStartupIniPath, SimNo, "5 Cut To Length", CutToLength)
                ChangeSNIni(SigmaStartupIniPath, SimNo, "13 SigmaNEST Companion", Companion)
                ChangeSNIni(SigmaStartupIniPath, SimNo, "14 SigmaNEST Quote Client", SigmanestQuote)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bbiJapan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiJapan.ItemClick
        bbiJapan.Down = True
        bbiUSA.Down = False
        bbiKorea.Down = False
        bbiChina.Down = False
        bbiSpain.Down = False
    End Sub
    Private Sub bbiUSA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUSA.ItemClick
        bbiJapan.Down = False
        bbiUSA.Down = True
        bbiKorea.Down = False
        bbiChina.Down = False
        bbiSpain.Down = False
    End Sub
    Private Sub bbiKorea_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiKorea.ItemClick
        bbiJapan.Down = False
        bbiUSA.Down = False
        bbiKorea.Down = True
        bbiChina.Down = False
        bbiSpain.Down = False
    End Sub
    Private Sub bbiChina_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiChina.ItemClick
        bbiJapan.Down = False
        bbiUSA.Down = False
        bbiKorea.Down = False
        bbiChina.Down = True
        bbiSpain.Down = False
    End Sub
    Private Sub bbiSpain_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSpain.ItemClick
        bbiJapan.Down = False
        bbiUSA.Down = False
        bbiKorea.Down = False
        bbiChina.Down = False
        bbiSpain.Down = True
    End Sub
    Private Sub bbiSigmanest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSigmanest.ItemClick
        bbiSigmanest.Down = True
        bbiCompanion.Down = False
        bbiQuote.Down = False
        bbiLite.Down = False
        bbiCTL.Down = False
    End Sub
    Private Sub bbiCompanion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCompanion.ItemClick
        bbiSigmanest.Down = False
        bbiCompanion.Down = True
        bbiQuote.Down = False
        bbiLite.Down = False
        bbiCTL.Down = False
    End Sub
    Private Sub bbiQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuote.ItemClick
        bbiSigmanest.Down = False
        bbiCompanion.Down = False
        bbiQuote.Down = True
        bbiLite.Down = False
        bbiCTL.Down = False
    End Sub
    Private Sub bbiLite_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLite.ItemClick
        bbiSigmanest.Down = False
        bbiCompanion.Down = False
        bbiQuote.Down = False
        bbiLite.Down = True
        bbiCTL.Down = False
    End Sub
    Private Sub bbiCTL_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCTL.ItemClick
        bbiSigmanest.Down = False
        bbiCompanion.Down = False
        bbiQuote.Down = False
        bbiLite.Down = False
        bbiCTL.Down = True
    End Sub
    Private Sub bbiUnits_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUnits.ItemClick
        If bbiUnits.Down = True Then
            bbiUnits.Caption = "Metric"
        Else
            bbiUnits.Caption = "Inch"
        End If
    End Sub
    Private Sub gcSigmaNEST_DoubleClick(sender As Object, e As EventArgs) Handles gcSigmaNEST.DoubleClick
        Dim SigmaNESTPath As String = ""
        Try
            If gvSigmaNEST.SelectedRowsCount > 0 Then
                Dim BuildName As String = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "BuildName").ToString
                If InStr(1, UCase(BuildName), "SIGMANEST", CompareMethod.Text) > 0 Then
                    SigmaNESTPath = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "SigmaNESTPath").ToString & "\Sigmanest.exe"
                Else
                    SigmaNESTPath = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "SigmaNESTPath").ToString
                End If

                SigmaINIPath = "C:\ProgramData\SigmaTEK\" & BuildName & "\"
                Dim SigmaStartupIniPath As String = SigmaINIPath & "SNStartup.ini"
                Dim lang As String = "ja"
                If bbiJapan.Down = True Then
                    lang = "ja"
                ElseIf bbiUSA.Down = True Then
                    lang = "en"
                ElseIf bbiKorea.Down = True Then
                    lang = "ko"
                ElseIf bbiChina.Down = True Then
                    lang = "zh-cn"
                ElseIf bbiSpain.Down = True Then
                    lang = "es"
                End If
                SetSigmanestMode()
                ChangeSNIni(SigmaStartupIniPath, "SYSTEM OPTIONS", "LanguageExt", lang)
                Process.Start(SigmaNESTPath)
                'Shell(SigmaNESTPath, AppWinStyle.NormalFocus)
                'Process.Start(SigmaNESTPath)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ttsLaunchasAdmin_Click(sender As Object, e As EventArgs) Handles ttsLaunchasAdmin.Click
        Dim SigmaNESTPath As String = ""
        Try
            If gvSigmaNEST.SelectedRowsCount > 0 Then
                Dim BuildName As String = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "BuildName").ToString
                If InStr(1, UCase(BuildName), "SIGMANEST", CompareMethod.Text) > 0 Then
                    SigmaNESTPath = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "SigmaNESTPath").ToString & "\Sigmanest.exe"
                Else
                    SigmaNESTPath = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "SigmaNESTPath").ToString
                End If

                SigmaINIPath = "C:\ProgramData\SigmaTEK\" & BuildName & "\"
                Dim SigmaStartupIniPath As String = SigmaINIPath & "SNStartup.ini"
                Dim lang As String = "ja"
                If bbiJapan.Down = True Then
                    lang = "ja"
                ElseIf bbiUSA.Down = True Then
                    lang = "en"
                ElseIf bbiKorea.Down = True Then
                    lang = "ko"
                ElseIf bbiChina.Down = True Then
                    lang = "zh-cn"
                ElseIf bbiSpain.Down = True Then
                    lang = "es"
                End If
                SetSigmanestMode()
                ChangeSNIni(SigmaStartupIniPath, "SYSTEM OPTIONS", "LanguageExt", lang)
                Dim procStartInfo As New ProcessStartInfo
                Dim procExecuting As New Process

                With procStartInfo
                    .UseShellExecute = True
                    .FileName = SigmaNESTPath
                    .WindowStyle = ProcessWindowStyle.Normal
                    .Verb = "runas" 'add this to prompt for elevation
                End With

                procExecuting = Process.Start(procStartInfo)
                'Shell(SigmaNESTPath, AppWinStyle.NormalFocus)
                'Process.Start(SigmaNESTPath)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub gcProducts_DoubleClick(sender As Object, e As EventArgs) Handles gcProducts.DoubleClick
        Dim ProductsPath As String = ""
        Try
            If gvProducts.SelectedRowsCount > 0 Then
                ProductsPath = gvProducts.GetRowCellValue(gvProducts.GetSelectedRows(0), "ProductsPath").ToString
                Process.Start(ProductsPath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub gcSigmaNEST_Click(sender As Object, e As EventArgs) Handles gcSigmaNEST.Click
        Try
            If gvSigmaNEST.SelectedRowsCount > 0 Then
                Dim BuildName As String = gvSigmaNEST.GetRowCellValue(gvSigmaNEST.GetSelectedRows(0), "BuildName").ToString
                SigmaINIPath = "C:\ProgramData\SigmaTEK\" & BuildName & "\"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bbiOpenINI_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOpenINI.ItemClick
        Try
            Process.Start(SigmaINIPath)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bbiLicenseFile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLicenseFile.ItemClick
        Dim LicensePath As String = "C:\ProgramData\SigmaTEK\License Files\"
        Try
            Process.Start(LicensePath)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bbiBeyondCompare_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBeyondCompare.ItemClick
        Try
            Process.Start(BeyondComparePath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bbiViewer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiViewer.ItemClick
        Try
            Process.Start(ViewerPath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim GblSelectedFolderPath As String = ""
    Private Sub clbSigmanest_Click(sender As Object, e As EventArgs)
        Try
            GblSelectedFolderPath = ""
            Dim SelPath As String = GblCustomerPath & "\" & clbSigmanest.SelectedValue & "\"
            If bbiCompanyMode.Down = False Then
                clbSource.Items.Clear()
                Dim di As New System.IO.DirectoryInfo(SelPath)
                Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                Dim dra As System.IO.FileInfo
                For Each dra In diar1
                    If UCase(Path.GetExtension(dra.FullName)) <> ".INI" Then
                        clbSource.Items.Add(Path.GetFileName(dra.FullName))
                    End If
                Next
            End If
            GblSelectedFolderPath = clbSigmanest.SelectedValue
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clbSigmanest_DoubleClick(sender As Object, e As EventArgs)
        Dim SelPath As String = GblCustomerPath
        Select Case clbSigmanest.SelectedValue
            Case Else
                SelPath = SelPath & "\" & clbSigmanest.SelectedValue & "\"
                Process.Start(SelPath)
        End Select
    End Sub
    Private Sub bbiKillSigmanest_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiKillSigmanest.ItemClick
        For Each prog As Process In Process.GetProcesses
            Try
                If InStr(1, UCase(prog.ProcessName), "SIGMANEST", CompareMethod.Text) > 0 Or InStr(1, UCase(prog.ProcessName), "SIMTRANS", CompareMethod.Text) > 0 Then
                    prog.Kill()
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub
#End Region
#Region "AppsDlls"
    Private Sub LoadAppColumns()
        Dim i As Integer = 0
        data5 = New DataTable("gvApps")
        data5.Clear()
        data5.BeginInit()
        AddColumn(data5, "AppName", System.Type.GetType("System.String"))
        AddColumn(data5, "AppFile", System.Type.GetType("System.String"))
        AddColumn(data5, "AppPath", System.Type.GetType("System.String"))
        data5.EndInit()

        gcApps.DataSource = data5
        gcApps.DefaultView.PopulateColumns()
        gvApps.Columns(0).Width = 150
        gvApps.Columns(1).Width = 150
        gvApps.Columns(2).Visible = False
        gvApps.Columns.ColumnByFieldName("AppName").Caption = "アプリ名"
        gvApps.Columns.ColumnByFieldName("AppFile").Caption = "アプリファイル"
        gvApps.Columns.ColumnByFieldName("AppPath").Caption = "アプリパス"
    End Sub
    Private Sub LoadAppData()
        Dim AppdataPath As String = SigmanestDataPath & "Customize\"
        data5.Clear()
        If Directory.Exists(SigmanestDataPath) Then
            For Each Dir As String In Directory.GetDirectories(AppdataPath)
                Dim dra As New System.IO.DirectoryInfo(Dir)
                Dim diar1 As System.IO.FileInfo() = dra.GetFiles()
                Dim AppName As String = ""
                Dim AppPath As String = ""
                For Each file In diar1
                    Dim FExt As String = Path.GetExtension(file.Name)
                    If Microsoft.VisualBasic.Left(dra.Name, 3) = "DLL" Then
                        If UCase(FExt) = ".DLL" Then
                            AppName = file.Name
                            AppPath = file.FullName
                            Exit For
                        End If
                    ElseIf Microsoft.VisualBasic.Left(dra.Name, 3) = "EXE" Then
                        If UCase(FExt) = ".EXE" Then
                            AppName = file.Name
                            AppPath = file.FullName
                            Exit For
                        End If
                    End If
                    'MsgBox(AppPath)
                Next
                data5.Rows.Add(dra.Name, AppName, AppPath)
            Next
        Else
            MsgBox("Google Driveのパスを変更して下さい。")
        End If
    End Sub
    Private Sub LoadAppCommentFile(ByVal AppPath As String)
        GblAppFileLog = Path.GetDirectoryName(AppPath) & "\AppLog.doc"
        If File.Exists(GblAppFileLog) Then
            recApp.LoadDocument(GblAppFileLog)
        Else
            recApp.CreateNewDocument()
        End If
    End Sub
    Private Sub SaveAppCommentFile()
        If GblAppFileLog <> "" Then
            recApp.SaveDocument(GblAppFileLog, DevExpress.XtraRichEdit.DocumentFormat.Doc)
        End If

    End Sub
    Private Sub SetAppPaths()
        Dim SelPath As String = GblCustomerPath
        Dim AppSettingPath As String = ""
        Dim AppSettingFile As String = ""
        Dim PluginName As String = ""
        Try
            ConnectToCOM()
            AppSettingPath = FSNApp.Paths.GetPath(PathID.piIniPath)
            AppSettingPath = Microsoft.VisualBasic.Left(AppSettingPath, Len(AppSettingPath) - 1 - (Len(AppSettingPath) - InStr(AppSettingPath, "IniFiles", CompareMethod.Text)))
            Dim FExt As String = Path.GetExtension(GblAppPath)
            If UCase(FExt) = ".DLL" Then
                AppSettingPath = AppSettingPath & "Plugins\"
                AppSettingFile = AppSettingPath & "SNPlugInSettings.ini"
                PluginName = Path.GetFileNameWithoutExtension(GblAppPath)
                File.Copy(GblAppPath, AppSettingPath & Path.GetFileName(GblAppPath), True)
                ChangeSNIni(AppSettingFile, "PlugIn Enabled", PluginName, "1")
                ChangeSNIni(AppSettingFile, "PlugIn Authorized", PluginName, "1")
            ElseIf UCase(FExt) = ".EXE" Then
                AppSettingPath = AppSettingPath & "AppManager\"
                AppSettingFile = AppSettingPath & "AppManagerSettings.ini"
                PluginName = Path.GetFileNameWithoutExtension(GblAppPath)

                ChangeSNIni(AppSettingFile, "ApplicationLink_0", "File_PathNameExt", GblAppPath)
                ChangeSNIni(AppSettingFile, "ApplicationLink_0", "Description", Path.GetFileName(GblAppPath))
                ChangeSNIni(AppSettingFile, "ApplicationLink_0", "Enabled", "1")
                ChangeSNIni(AppSettingFile, "ApplicationLink_0", "TabLocation", GblAppPath)
                ChangeSNIni(AppSettingFile, "ApplicationLink_0", "Parameter", "")
            End If

            FSNApp.ReLoadConfig()
            MsgBox("設定変更しました。")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub UndoAppPaths()

    End Sub
    Private Sub gvApps_FocusedRowChanged(sender As Object, e As EventArgs) Handles gvApps.FocusedRowChanged
        If gvApps.SelectedRowsCount > 0 Then
            Dim AppName As String = gvApps.GetRowCellValue(gvApps.GetSelectedRows(0), "AppName").ToString
            Dim AppPath As String = gvApps.GetRowCellValue(gvApps.GetSelectedRows(0), "AppPath").ToString
            GblAppPath = AppPath
            LoadAppCommentFile(AppPath)
        End If
    End Sub
    Private Sub gcApps_DoubleClick(sender As Object, e As EventArgs) Handles gcApps.DoubleClick
        RunAppFile()
    End Sub
    Private Sub RunAppFile()
        Try
            Dim WSPath As String = Replace(GblAppPath, Path.GetFileName(GblAppPath), "") & "WS\"

            If Directory.Exists(WSPath) Then
                ConnectToCOM()
                Dim di As New System.IO.DirectoryInfo(WSPath)
                Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                Dim dra As System.IO.FileInfo
                For Each dra In diar1
                    If UCase(Path.GetExtension(dra.FullName)) = ".WS" Then
                        FSNApp.LoadWorkSpaceFile(dra.FullName)
                        Exit For
                    End If
                Next
            End If
            Process.Start(GblAppPath)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bbiRunFile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRunFile.ItemClick
        RunAppFile()
    End Sub
    Private Sub LoadAppVideo()
        Dim DemoName As String = ""
        Dim DemoDataPath As String = ""
        DemoName = gvApps.GetRowCellValue(gvApps.GetSelectedRows(0), "AppName").ToString
        DemoDataPath = SigmanestDataPath & "Customize\" & DemoName & "\VIDEO\"

        Dim di As New System.IO.DirectoryInfo(DemoDataPath)
        If Directory.Exists(DemoDataPath) Then
            Dim diar1 As System.IO.FileInfo() = di.GetFiles()
            Dim dra As System.IO.FileInfo
            For Each dra In diar1
                If UCase(Path.GetExtension(dra.FullName)) = ".WMV" Or UCase(Path.GetExtension(dra.FullName)) = ".AVI" Then
                    Process.Start(dra.FullName)
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region
#Region "Documents"
    Dim GblDocumentDataPath As String = ""
    Private loadDrives As Boolean = False
    Private Sub InitDocumentTreeList()
        If Directory.Exists(GblDocumentDataPath) Then
            tlDocuments.DataSource = New Object()
            tlDocuments.Columns(0).Caption = "名前"
            tlDocuments.Columns(1).Visible = False
            tlDocuments.Columns(2).Visible = False
            tlDocuments.Columns(3).Visible = False
            loadDrives = False
        End If
    End Sub
    Private Sub tlDocuments_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles tlDocuments.FocusedNodeChanged
        LoadDocument()
    End Sub
    Private Sub tlDocuments_VirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo) Handles tlDocuments.VirtualTreeGetChildNodes
        Dim current As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        If loadDrives = False Then
            'Dim roots() As String = Directory.GetLogicalDrives()
            Dim dirs() As String = Directory.GetDirectories(GblDocumentDataPath)
            Dim files() As String = Directory.GetFiles(GblDocumentDataPath)
            Dim FilesAndDirs As New ArrayList
            FilesAndDirs.Clear()
            FilesAndDirs.AddRange(dirs)
            FilesAndDirs.AddRange(files)
            e.Children = FilesAndDirs
            loadDrives = True
        Else
            Try
                Dim path As String = CStr(e.Node)
                If Directory.Exists(path) Then
                    Dim dirs() As String = Directory.GetDirectories(path)
                    Dim files() As String = Directory.GetFiles(path)
                    Dim arr(dirs.Length + files.Length - 1) As String
                    dirs.CopyTo(arr, 0)
                    files.CopyTo(arr, dirs.Length)
                    e.Children = arr
                Else
                    e.Children = New Object() {}
                End If
            Catch
                e.Children = New Object() {}
            End Try
        End If
        Cursor.Current = current
    End Sub
    Private Sub treeList1_VirtualTreeGetCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo) Handles tlDocuments.VirtualTreeGetCellValue
        Dim di As New DirectoryInfo(CStr(e.Node))
        If e.Column Is colName Then
            e.CellData = di.Name
        End If
        If e.Column Is colPath Then
            e.CellData = e.Node.ToString
        End If
        If e.Column Is colType Then
            If IsDrive(CStr(e.Node)) Then
                e.CellData = "Drive"
            ElseIf Not IsFile(di) Then
                e.CellData = "Folder"
            Else
                e.CellData = "File"
            End If
        End If
        If e.Column Is colSize Then
            If IsFile(di) Then
                e.CellData = (New FileInfo(CStr(e.Node))).Length
            Else
                e.CellData = Nothing
            End If
        End If
    End Sub
    Private Function IsFile(ByVal info As DirectoryInfo) As Boolean
        Try
            Return (info.Attributes And FileAttributes.Directory) = 0
        Catch
            Return False
        End Try
    End Function
    Private Function IsDrive(ByVal val As String) As Boolean
        Dim drives() As String = Directory.GetLogicalDrives()
        For Each drive As String In drives
            If drive.Equals(val) Then
                Return True
            End If
        Next drive
        Return False
    End Function
    '</treeList1>
    Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles tlDocuments.GetStateImage
        If e.Node.GetDisplayText("Type") = "Folder" Then
            e.NodeImageIndex = If(e.Node.Expanded, 1, 0)
        ElseIf e.Node.GetDisplayText("Type") = "File" Then
            e.NodeImageIndex = 2
        Else
            e.NodeImageIndex = 3
        End If
    End Sub
    Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles tlDocuments.CustomDrawNodeCell
        If e.Column Is Me.colSize Then
            If e.Node.GetDisplayText("Type") = "File" Then
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Italic)
                Dim size As Int64 = Convert.ToInt64(e.Node.GetValue("Size"))
                If size >= 1024 Then
                    e.CellText = String.Format("{0:### ### ###} KB", size \ 1024)
                Else
                    e.CellText = String.Format("{0} Bytes", size)
                End If
            Else
                e.CellText = String.Format("<{0}>", e.Node.GetDisplayText("Type"))
            End If
        End If

        If e.Column Is Me.colName Then
            If e.Node.GetDisplayText("Type") = "File" Then
                e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
            End If
        End If
    End Sub
    Private Sub tlDocuments_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tlDocuments.DragDrop
        Dim IsDir As Boolean = False
        Dim destinationPath As String = appData & "\"
        Dim CopyDirPath As String = ""
        'copy file(s) to destination folder
        Try
            If GblDocumentDataPath <> "" Then
                Dim formats() As String = e.Data.GetFormats()
                If formats.Contains("FileContents") = False Then Exit Sub
                If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                    Dim draggedFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
                    For Each fileName As String In draggedFiles
                        File.Copy(fileName, GblDocumentDataPath & Path.GetFileName(fileName), True)
                    Next
                End If
                Dim fi As New System.IO.FileInfo(GblDocumentDataPath)
                Dim FolderName As String = fi.Directory.Name
                LoadDocumentData(FolderName)
            Else
                MsgBox("ドキュメントパスを選択して下さい。")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub tlDocuments_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles tlDocuments.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub LoadDocumentData(ByVal DocumentType As String)
        Dim DocDataPath As String = ""
        Select Case DocumentType
            Case "Manuals"
                DocDataPath = "\\sigmatek.net\Documents\Support\MTG\OEM Machine Manuals and Documentation\"
            Case "Products"
                DocDataPath = "\\sigmatek.net\Documents\Product Documentation\SigmaNEST\"
            Case Else
                DocDataPath = DocumentDataPath & DocumentType & "\"
        End Select
        GblDocumentDataPath = DocDataPath
        InitDocumentTreeList()
    End Sub
    Dim GblDocumentPath As String = ""
    Private Sub bbiCreateNewExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCreateNewExcel.ItemClick
        Dim frmNew As New frmNew
        frmNew.ShowDialog()
        Dim NewFolderName As String = frmNew.CustomerName
        If NewFolderName <> "" Then
            xlsData.CreateNewDocument()
            xlsData.SaveDocument(GblDocumentDataPath & NewFolderName & ".xls", DevExpress.Spreadsheet.DocumentFormat.Xls)
            Dim fi As New System.IO.FileInfo(GblDocumentDataPath)
            Dim FolderName As String = fi.Directory.Name
            LoadDocumentData(FolderName)
        End If
    End Sub
    Private Sub bbiCreateNewWord_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCreateNewWord.ItemClick
        Dim frmNew As New frmNew
        frmNew.ShowDialog()
        Dim NewFolderName As String = frmNew.CustomerName
        If NewFolderName <> "" Then
            docViewer.CreateNewDocument()
            docViewer.SaveDocument(GblDocumentDataPath & NewFolderName & ".doc", DevExpress.XtraRichEdit.DocumentFormat.Doc)
            Dim fi As New System.IO.FileInfo(GblDocumentDataPath)
            Dim FolderName As String = fi.Directory.Name
            LoadDocumentData(FolderName)
        End If
    End Sub
    Private Sub LoadDocument()
        If tlDocuments.FocusedNode(1) <> "" Then
            Dim DocumentName As String = tlDocuments.FocusedNode(0).ToString
            Dim DocumentPath As String = tlDocuments.FocusedNode(1).ToString
            GblDocumentPath = DocumentPath
            Dim FExt As String = Path.GetExtension(DocumentPath)
            Try
                If UCase(FExt) = ".XLS" Or UCase(FExt) = ".XLSX" Then
                    xlsData.Visible = True
                    pdfViewer.Visible = False
                    docViewer.Visible = False
                    xlsData.LoadDocument(DocumentPath)
                ElseIf UCase(FExt) = ".PDF" Then
                    xlsData.Visible = False
                    pdfViewer.Visible = True
                    docViewer.Visible = False
                    pdfViewer.LoadDocument(DocumentPath)
                ElseIf UCase(FExt) = ".DOC" Or UCase(FExt) = ".DOCX" Or UCase(FExt) = ".WOL" Or UCase(FExt) = ".TXT" Or UCase(FExt) = ".PAS" Or UCase(FExt) = ".PST" Then
                    xlsData.Visible = False
                    pdfViewer.Visible = False
                    docViewer.Visible = True
                    docViewer.LoadDocument(DocumentPath)
                ElseIf UCase(FExt) = ".EXE" Or UCase(FExt) = ".ZIP" Then
                    xlsData.Visible = False
                    pdfViewer.Visible = False
                    docViewer.Visible = True
                Else
                    xlsData.Visible = False
                    pdfViewer.Visible = False
                    docViewer.Visible = True
                    Process.Start(DocumentPath)
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub SaveDocument()
        If tlDocuments.FocusedNode(1) <> "" Then
            Dim DocumentName As String = tlDocuments.FocusedNode(0).ToString
            Dim DocumentPath As String = tlDocuments.FocusedNode(1).ToString
            Dim FExt As String = Path.GetExtension(DocumentPath)
            Try
                If UCase(FExt) = ".XLS" Or UCase(FExt) = ".XLSX" Then
                    xlsData.SaveDocument(DocumentPath, DevExpress.Spreadsheet.DocumentFormat.Xls)
                ElseIf UCase(FExt) = ".XLSX" Then
                    xlsData.SaveDocument(DocumentPath, DevExpress.Spreadsheet.DocumentFormat.Xlsx)
                ElseIf UCase(FExt) = ".DOC" Then
                    docViewer.SaveDocument(DocumentPath, DevExpress.XtraRichEdit.DocumentFormat.Doc)
                ElseIf UCase(FExt) = ".DOCX" Then
                    docViewer.SaveDocument(DocumentPath, DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
                ElseIf UCase(FExt) = ".WOL" Or UCase(FExt) = ".TXT" Or UCase(FExt) = ".PAS" Or UCase(FExt) = ".PST" Then
                    docViewer.SaveDocument(DocumentPath, DevExpress.XtraRichEdit.DocumentFormat.PlainText)
                End If
                MsgBox("ドキュメントは保存されました。")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Private Sub PrintDocument()
        If tlDocuments.FocusedNode(1) <> "" Then
            Dim DocumentName As String = tlDocuments.FocusedNode(0).ToString
            Dim DocumentPath As String = tlDocuments.FocusedNode(1).ToString
            Dim FExt As String = Path.GetExtension(DocumentPath)
            Try
                If UCase(FExt) = ".XLS" Then
                    xlsData.ShowRibbonPrintPreview()
                ElseIf UCase(FExt) = ".DOC" Or UCase(FExt) = ".WOL" Or UCase(FExt) = ".TXT" Or UCase(FExt) = ".PAS" Or UCase(FExt) = ".PST" Then
                    docViewer.ShowPrintPreview()

                ElseIf UCase(FExt) = ".PDF" Then
                    pdfViewer.Print()
                Else
                    MsgBox("印刷はこのフォーマットをサポートしていません。")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ttsFind_Click(sender As Object, e As EventArgs) Handles ttsFind.Click
        If xtcMain.SelectedTabPage Is tabVideo Then
            gvVideo.ShowFindPanel()
        Else
            tlDocuments.ShowFindPanel()
        End If
    End Sub
    Private Sub bbiDocuments_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDocuments.ItemClick
        LoadDocumentData("ドキュメント")
    End Sub
    Private Sub bbiDocMachines_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDocMachines.ItemClick
        LoadDocumentData("機械仕様書")
    End Sub
    Private Sub bbiProductInfo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiProductInfo.ItemClick
        LoadDocumentData("Products")
    End Sub
    Private Sub bbiDocTrouble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDocTrouble.ItemClick
        LoadDocumentData("トラブルシューティング")
    End Sub
    Private Sub tlDocuments_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tlDocuments.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            Me.cmsDelete.Show(tlDocuments, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub DeleteDocuments()
        Dim DocPath As String = ""
        Try
            If tlDocuments.FocusedNode(1) <> "" Then
                Dim result As Integer = MessageBox.Show("ドキュメントを削除してよろしいでしょうか？", "ドキュメントの削除", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    DocPath = tlDocuments.FocusedNode(1)
                    If File.Exists(DocPath) Then
                        File.Delete(DocPath)
                        Dim fi As New System.IO.FileInfo(GblDocumentDataPath)
                        Dim FolderName As String = fi.Directory.Name
                        LoadDocumentData(FolderName)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bbiClickstamper_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClickstamper.ItemClick
        Dim CStampPath As String = SigmanestDataPath & "Customize\EXE-クリックスタンパー\"
        Dim sw2 As New System.IO.StreamWriter(appData & "\Temp.BAT", False, System.Text.Encoding.GetEncoding(GblEncoding))
        sw2.WriteLine(Path.GetPathRoot(SigmanestDataPath))
        sw2.WriteLine("cd " & CStampPath)
        sw2.WriteLine("ClickStamper.exe " & GblMyName & ".csdate")
        sw2.Close()
        Try
            Shell(appData & "\Temp.BAT", AppWinStyle.Hide)
        Catch ex As Exception
            Process.Start(CStampPath & "ClickStamper.exe")
        End Try
        'Process.Start(CStampPath & " 山本.csdate")
    End Sub
#End Region
#Region "QA"
    Private Function GetQAInfo(ByVal QANo As String, ByVal SelectedField As String) As String
        Dim i As Integer = 0
        Dim DefectID As String = ""
        Dim DefectName As String = ""
        Dim BacklogType, Workflow, AEPriority, DevPriority, AssignedTo, Tags As String
        Dim Description As String = ""
        Dim CreatedDate As String
        Dim ReturnStr As String = ""
        QANo = Replace(QANo, "QA:", "").Trim
        If gvQA.RowCount > 0 Then
            For i = 0 To gvQA.RowCount - 1
                DefectID = gvQA.GetRowCellValue(i, "DefectID").trim
                If DefectID = QANo Then
                    DefectName = gvQA.GetRowCellValue(i, "DefectName")
                    BacklogType = gvQA.GetRowCellValue(i, "BacklogType")
                    Workflow = gvQA.GetRowCellValue(i, "Workflow")
                    AEPriority = gvQA.GetRowCellValue(i, "AEPriority")
                    DevPriority = gvQA.GetRowCellValue(i, "DevPriority")
                    AssignedTo = gvQA.GetRowCellValue(i, "AssignedTo")
                    Tags = gvQA.GetRowCellValue(i, "Tags")
                    Description = gvQA.GetRowCellValue(i, "Description")
                    CreatedDate = gvQA.GetRowCellValue(i, "CreatedDate")
                    ReturnStr = DefectName & "," & BacklogType & "," & Workflow & "," & AEPriority & "," & DevPriority & "," & AssignedTo & "," & Tags & "," & CreatedDate
                    Exit For
                End If
            Next
        End If
        If SelectedField = "DefectName" Then
            GetQAInfo = DefectName
        ElseIf SelectedField = "Description" Then
            GetQAInfo = Description
        Else
            GetQAInfo = ReturnStr
        End If
    End Function
    Private Sub LoadQAColumns()
        Dim i As Integer = 0
        data26 = New DataTable("gvQA")
        data26.Clear()
        data26.BeginInit()
        AddColumn(data26, "DefectID", System.Type.GetType("System.String"))
        AddColumn(data26, "DefectName", System.Type.GetType("System.String"))
        AddColumn(data26, "BacklogType", System.Type.GetType("System.String"))
        AddColumn(data26, "Workflow", System.Type.GetType("System.String"))
        AddColumn(data26, "AEPriority", System.Type.GetType("System.String"))
        AddColumn(data26, "DevPriority", System.Type.GetType("System.String"))
        AddColumn(data26, "AssignedTo", System.Type.GetType("System.String"))
        AddColumn(data26, "Tags", System.Type.GetType("System.String"))
        AddColumn(data26, "Description", System.Type.GetType("System.String"))
        AddColumn(data26, "CreatedDate", System.Type.GetType("System.DateTime"))
        data26.EndInit()

        gcQA.DataSource = data26
        gcQA.DefaultView.PopulateColumns()
        gvQA.Columns(0).Width = 75
        gvQA.Columns(1).Width = 150
        gvQA.Columns(2).Width = 100
        gvQA.Columns(3).Width = 100
        gvQA.Columns(4).Width = 100
        gvQA.Columns(5).Width = 100
        gvQA.Columns(6).Width = 100
        gvQA.Columns(7).Width = 100
        gvQA.Columns(8).Width = 200
        gvQA.Columns(9).Width = 100

        gvQA.Columns.ColumnByFieldName("DefectID").Caption = "QA番号"
        gvQA.Columns.ColumnByFieldName("DefectName").Caption = "名前"
        gvQA.Columns.ColumnByFieldName("BacklogType").Caption = "タイプ"
        gvQA.Columns.ColumnByFieldName("Workflow").Caption = "進捗"
        gvQA.Columns.ColumnByFieldName("AEPriority").Caption = "AE優先順位"
        gvQA.Columns.ColumnByFieldName("DevPriority").Caption = "開発優先順位"
        gvQA.Columns.ColumnByFieldName("AssignedTo").Caption = "開発者"
        gvQA.Columns.ColumnByFieldName("Tags").Caption = "タグ"
        gvQA.Columns.ColumnByFieldName("Description").Caption = "説明"
        gvQA.Columns.ColumnByFieldName("CreatedDate").Caption = "登録日付"
        gvQA.BestFitColumns()
        gvQA.Columns("CreatedDate").SortOrder = ColumnSortOrder.Descending
    End Sub
    Private Sub LoadQACSV()
        Dim QAPath As String = SigmanestDataPath & "Applications\SigmaAPP\QA\"
        Dim QAFile As String = ""
        Dim DefectID, DefectName, BacklogType, Workflow, AEPriority, DevPriority, AssignedTo, Tags, Description As String
        Dim CreatedDate As Date
        Dim LineItem As String = ""
        If Directory.Exists(QAPath) Then
            Dim di As New System.IO.DirectoryInfo(QAPath)
            Dim diar1 As System.IO.FileInfo() = di.GetFiles()
            Dim dra As System.IO.FileInfo
            For Each dra In diar1
                If UCase(Path.GetExtension(dra.FullName)) = ".CSV" Then
                    QAFile = dra.FullName
                    Exit For
                End If
            Next
            Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(QAFile, System.Text.Encoding.GetEncoding(GblEncoding))
            Dim CurrentRecord As String()
            afile.TextFieldType = FileIO.FieldType.Delimited
            afile.Delimiters = New String() {","}
            afile.HasFieldsEnclosedInQuotes = True
            ' parse the actual file
            data26.Clear()
            afile.ReadLine()
            Do While Not afile.EndOfData
                Try

                    CurrentRecord = afile.ReadFields
                    DefectID = CurrentRecord(1)
                    DefectName = CurrentRecord(2)
                    BacklogType = CurrentRecord(0)
                    Workflow = CurrentRecord(3)
                    AEPriority = CurrentRecord(12)
                    DevPriority = CurrentRecord(9)
                    AssignedTo = CurrentRecord(6)
                    Tags = CurrentRecord(17)
                    Description = CurrentRecord(18)
                    CreatedDate = CDate(CurrentRecord(15))
                    data26.Rows.Add(DefectID, DefectName, BacklogType, Workflow, AEPriority, DevPriority, AssignedTo, Tags, Description, CreatedDate)

                Catch ex As FileIO.MalformedLineException
                    afile.Close()
                    Stop
                End Try
            Loop
            afile.Close()
        End If
    End Sub
    Private Sub bbiQA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQA.ItemClick
        bbiHasp.Down = False
        If bbiQA.Down = True Then
            gcQA.Visible = True
            gcQA.BringToFront()
        Else
            gcQA.Visible = False
            splCustomer.BringToFront()
        End If
    End Sub
    Private Sub bbiOntime_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOntime.ItemClick
        Dim OnTimeURL As String = "http://ontime.sigmatek.net/OnTimeWeb/default.aspx"
        Process.Start(OnTimeURL)
    End Sub
#End Region
#Region "Translation"
    Private Sub bbiTranslate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTranslate.ItemClick
        If bbiTranslate.Down = True Then
            frmTranslation.Dock = DockStyle.Fill
            frmTranslation.Parent = pnlTools
            frmTranslation.Show()
            pnlTools.Visible = True
            gcsSettings.Visible = False
        Else
            pnlTools.Visible = False
            gcsSettings.Visible = True
        End If
    End Sub
#End Region
#Region "Google"
    Private Sub InsertContacts(ByVal cr As ContactsRequest)
        Dim i As Integer = 0
        Try
            For i = 0 To gvCustomerData.SelectedRowsCount - 1
                Dim newEntry As Contact = New Contact
                Dim BPath As String = ""
                Dim FullName As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Name").ToString
                newEntry.Name = New Name With {.FullName = FullName}
                Dim EMail1Address As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "EMail").ToString
                If EMail1Address <> "" Then
                    newEntry.Emails.Add(New Google.GData.Extensions.EMail() With {.Primary = True, .Rel = ContactsRelationships.IsWork, .Address = EMail1Address})

                End If
                Dim CompanyName As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Company").ToString
                Dim Department As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Department").ToString
                Dim Title As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Title").ToString
                If CompanyName <> "" Then
                    newEntry.Organizations.Add(New Google.GData.Extensions.Organization() With {.Rel = ContactsRelationships.IsWork, .Name = CompanyName})
                End If
                If Department <> "" Then
                    newEntry.Organizations.Add(New Google.GData.Extensions.Organization() With {.Rel = ContactsRelationships.IsWork, .Name = CompanyName})
                End If
                If Title <> "" Then
                    newEntry.Organizations.Add(New Google.GData.Extensions.Organization() With {.Rel = ContactsRelationships.IsWork, .Name = CompanyName})
                End If
                Dim MailingAddress As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Address").ToString
                Dim MailingAddressPostalCode As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Zip").ToString
                Dim MailingAddressCity As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "City").ToString
                Dim MailingAddressState As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "State").ToString
                Dim MailingAddressCountry As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Country").ToString
                If MailingAddress <> "" Then
                    newEntry.PostalAddresses.Add(New StructuredPostalAddress With {.Rel = ContactsRelationships.IsWork, .FormattedAddress = MailingAddress})
                End If
                If MailingAddressPostalCode <> "" Then
                    newEntry.PostalAddresses.Add(New StructuredPostalAddress With {.Rel = ContactsRelationships.IsWork, .Postcode = MailingAddressPostalCode})
                End If
                If MailingAddressCity <> "" Then
                    newEntry.PostalAddresses.Add(New StructuredPostalAddress With {.Rel = ContactsRelationships.IsWork, .City = MailingAddressCity})
                End If
                If MailingAddressCountry <> "" Then
                    newEntry.PostalAddresses.Add(New StructuredPostalAddress With {.Rel = ContactsRelationships.IsWork, .Country = MailingAddressCountry})
                End If

                Dim HomeTelephoneNumber As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Telephone").ToString
                Dim HomeFaxNumber As String = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Fax").ToString
                If HomeTelephoneNumber <> "" Then
                    newEntry.Phonenumbers.Add(New PhoneNumber() With {.Rel = ContactsRelationships.IsWork, .Value = HomeTelephoneNumber})
                End If
                If HomeFaxNumber <> "" Then
                    newEntry.Phonenumbers.Add(New PhoneNumber() With {.Rel = ContactsRelationships.IsFax, .Value = HomeFaxNumber})
                End If

                'NewConta = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(0), "Remarks").ToString
                'Dim WebPage = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "Website").ToString
                'BPath = gvCustomerData.GetRowCellValue(gvCustomerData.GetSelectedRows(i), "CardPath1").ToString
                'NewContact.AddPicture(BCardPath & BPath)
                Dim feedUri As Uri = New Uri(ContactsQuery.CreateContactsUri("default"))
                Dim createdEntry As Contact = cr.Insert(feedUri, newEntry)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("Google 連絡先に書き込まれました。")
        End Try

    End Sub
    Private Sub CreateGoogleContacts()
        Dim rs As RequestSettings = New RequestSettings("TAPCRM", GoogleUsername, GooglePassword)
        Dim cr As ContactsRequest = New ContactsRequest(rs)
        InsertContacts(cr)
    End Sub
    Private Sub bbiGoogleContacts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGoogleContacts.ItemClick
        CreateGoogleContacts()
    End Sub
#End Region
#Region "DemoSets"
    Dim GblDemoDataPath As String = ""
    Private Function ProcessWOL(ByVal WOLPath As String) As String
        Dim TmpWOL As String = appData & "\Tmp.WOL"
        Dim sr As New System.IO.StreamReader(WOLPath, System.Text.Encoding.GetEncoding(GblEncoding))
        Dim sw As New System.IO.StreamWriter(TmpWOL, False, System.Text.Encoding.GetEncoding(GblEncoding))
        Dim SNDataPath As String = FSNApp.Paths.GetPath(PathID.piDataPath)
        Dim LineItem As String = ""
        While sr.Peek() > -1
            LineItem = sr.ReadLine()
            If InStr(1, LineItem, "{SNDATA}", CompareMethod.Text) > 0 Then
                LineItem = Replace(LineItem, "{SNDATA}\DXF", SNDataPath & "DXF")
            End If
            sw.WriteLine(LineItem)
        End While
        sw.Close()
        sr.Close()
        ProcessWOL = TmpWOL
    End Function
    Private Sub LoadDemoMachines(ByVal DemoName As String, ByVal DemoType As String)
        Dim DemoDataPath As String = SigmanestDataPath & "デモ用データ\" & DemoType & "\" & DemoName & "\"
        Dim PostPath As String = DemoDataPath & "PostFiles\"
        Dim ToolsPath As String = DemoDataPath & "Tools\"
        Dim ReportsPath As String = DemoDataPath & "Reports\"
        Dim DBasePath As String = DemoDataPath & "Database\"
        Dim DBaseSimtransPath As String = DemoDataPath & "DatabaseSimtrans\"
        Dim ReplacePath As String = DemoDataPath & "Replace\"
        Dim DXFPath As String = DemoDataPath & "DXF\"
        Dim WSPath As String = DemoDataPath & "WS\"
        Dim SetupPath As String = DemoDataPath & "SETUP\"
        Dim WOLPath As String = DemoDataPath & "WOL\"
        Dim SQLPath As String = DemoDataPath & "SQL\"
        Dim SQLModifyPath As String = DemoDataPath & "SQLMODIFY\"
        Dim DeskTopsPath As String = DemoDataPath & "DeskTops\"
        Dim Showmessage As Boolean = True
        Try
            Dim result As Integer = MessageBox.Show(DemoName & " のデモデータを設定しますか？", "デモデータの設定", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ConnectToCOM()
                If Directory.Exists(PostPath) Then
                    OldPostPath = FSNApp.Paths.GetPath(PathID.piPostPath)
                    ChangeIni("PostPath", PostPath)
                    Showmessage = False
                End If
                If Directory.Exists(ToolsPath) Then
                    OldToolsPath = FSNApp.Paths.GetPath(PathID.piToolsPath)
                    ChangeIni("ToolsPath", ToolsPath)
                    Showmessage = False
                End If
                If Directory.Exists(ToolsPath) Then
                    OldReportsPath = FSNApp.Paths.GetPath(PathID.piReportPath)
                    ChangeIni("ReportPath", ReportsPath)
                    Showmessage = False
                End If
                If Directory.Exists(ReplacePath) Then
                    OldReplacePath = FSNApp.Paths.GetPath(PathID.piDataPath) & "Replace"
                    ChangeIni("ReplacePattenPath", ReplacePath)
                    Showmessage = False
                End If


                If Directory.Exists(SQLPath) Then
                    Dim di As New System.IO.DirectoryInfo(SQLPath)
                    Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                    Dim dra As System.IO.FileInfo
                    For Each dra In diar1
                        If UCase(Path.GetExtension(dra.FullName)) = ".TXT" Then
                            Dim sr As New System.IO.StreamReader(dra.FullName, System.Text.Encoding.GetEncoding(GblEncoding))
                            Dim LineItem As String = ""
                            While sr.Peek() > -1
                                LineItem = sr.ReadLine()
                                ExecuteNonQuery(LineItem)
                            End While
                            sr.Close()
                            Exit For
                        End If
                    Next
                    Showmessage = False
                End If
                If Directory.Exists(DBasePath) Then
                    Dim Query As String = ""
                    Query = "DELETE FROM Tool"
                    ExecuteNonQuery(Query)
                    Query = "bcp " & SNCatalog & ".dbo.tool in """ & DBasePath & "tool.sndbase"" -b 100000 -f """ & DBasePath & "tool.fmt"" -S " & SNDatabasePath & " -U " & SNUserID & " -P " & SNPassword
                    Dim sw As New System.IO.StreamWriter(DBasePath & "Tool.BAT", False, System.Text.Encoding.GetEncoding(GblEncoding))
                    sw.Write(Query)
                    sw.Close()
                    Process.Start(DBasePath & "Tool.BAT")
                    Showmessage = False
                End If
                If Directory.Exists(DBaseSimtransPath) Then
                    Dim Query As String = ""
                    Query = "DELETE FROM TransAct"
                    SimExecuteNonQuery(Query)
                    Query = "bcp SIMTRANS.dbo.TransAct in """ & DBaseSimtransPath & "TransAct.sndbase"" -b 100000 -f """ & DBaseSimtransPath & "TransAct.fmt"" -S " & SNDatabasePath & " -U sa -P Shark1445NE$T"
                    Dim sw As New System.IO.StreamWriter(DBaseSimtransPath & "TransAct.BAT", False, System.Text.Encoding.GetEncoding(GblEncoding))
                    sw.Write(Query)
                    sw.Close()
                    Process.Start(DBaseSimtransPath & "TransAct.BAT")
                    Showmessage = False
                End If

                FSNApp.ClearWorkSpace()
                If Directory.Exists(WSPath) Then
                    Dim di As New System.IO.DirectoryInfo(WSPath)
                    Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                    Dim dra As System.IO.FileInfo
                    For Each dra In diar1
                        If UCase(Path.GetExtension(dra.FullName)) = ".WS" Then
                            FSNApp.LoadWorkSpaceFile(dra.FullName)
                            Exit For
                        End If
                    Next
                    Showmessage = False
                End If
                If Directory.Exists(DXFPath) Then
                    Dim di As New System.IO.DirectoryInfo(DXFPath)
                    Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                    Dim dra As System.IO.FileInfo
                    For Each dra In diar1
                        If UCase(Path.GetExtension(dra.FullName)) = ".DXF" Then
                            Dim ssauto As New SNAutomation
                            ssauto.ExeBatchString("LOAD,FILE," & dra.FullName)
                        End If
                        FSNApp.PartTile()
                        FSNApp.AutoScale()
                    Next
                    Showmessage = False
                End If
                If Directory.Exists(DeskTopsPath) Then
                    Dim di As New System.IO.DirectoryInfo(DeskTopsPath)
                    Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                    Dim dra As System.IO.FileInfo
                    Try
                        For Each dra In diar1
                            If UCase(Path.GetExtension(dra.FullName)) = ".XML" Then
                                Dim SNDesktopPath As String = FSNApp.Paths.GetPath(PathID.piDataPath) & "DeskTops\"
                                File.Copy(dra.FullName, SNDesktopPath & Path.GetFileName(dra.FullName), True)
                            End If
                        Next
                    Catch ex As Exception

                    End Try
                    Showmessage = False
                End If
                If Directory.Exists(SetupPath) Then
                    Dim di As New System.IO.DirectoryInfo(SetupPath)
                    Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                    Dim dra As System.IO.FileInfo
                    Try
                        For Each dra In diar1
                            If UCase(Path.GetExtension(dra.FullName)) = ".DXF" Then
                                Dim SNDXFPath As String = FSNApp.Paths.GetPath(PathID.piDataPath) & "DXF\"
                                File.Copy(dra.FullName, SNDXFPath & Path.GetFileName(dra.FullName), True)
                            ElseIf UCase(Path.GetExtension(dra.FullName)) = ".CDL" Then
                                Dim SNCDLPath As String = FSNApp.Paths.GetPath(PathID.piDataPath) & "CDL\"
                                File.Copy(dra.FullName, SNCDLPath & Path.GetFileName(dra.FullName), True)
                            ElseIf InStr(1, dra.FullName, ".PRS", CompareMethod.Text) > 0 Then
                                Dim SNPartPath As String = FSNApp.Paths.GetPath(PathID.piDataPath) & "PARTS\"
                                File.Copy(dra.FullName, SNPartPath & Path.GetFileName(dra.FullName), True)
                            End If
                        Next
                    Catch ex As Exception

                    End Try

                    Showmessage = False
                End If
                If Directory.Exists(WOLPath) Then
                    Dim di As New System.IO.DirectoryInfo(WOLPath)
                    Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                    Dim dra As System.IO.FileInfo
                    For Each dra In diar1
                        If UCase(Path.GetExtension(dra.FullName)) = ".WOL" Then
                            FSNApp.ExecuteBatchFile(ProcessWOL(dra.FullName))
                        End If
                    Next
                    Showmessage = False
                End If
                If Showmessage = True Then
                    MsgBox("設定ファイルがありません。")
                Else
                    MsgBox(DemoName & "の設定になりました。")
                End If
                If Directory.Exists(SQLModifyPath) Then
                    Dim di As New System.IO.DirectoryInfo(SQLModifyPath)
                    Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                    Dim dra As System.IO.FileInfo
                    For Each dra In diar1
                        If UCase(Path.GetExtension(dra.FullName)) = ".TXT" Then
                            Dim sr As New System.IO.StreamReader(dra.FullName, System.Text.Encoding.GetEncoding(GblEncoding))
                            Dim LineItem As String = ""
                            While sr.Peek() > -1
                                LineItem = sr.ReadLine()
                                If InStr(1, LineItem, "{SNDATA}", CompareMethod.Text) > 0 Then
                                    LineItem = Replace(LineItem, "{SNDATA}", FSNApp.Paths.GetPath(PathID.piDataPath))
                                End If
                                SimExecuteNonQuery(LineItem)
                            End While
                            sr.Close()
                            Exit For
                        End If
                    Next
                    Showmessage = False
                End If
                FSNApp.ReLoadConfig()
            End If
        Catch ex As Exception
            MsgBox("シグマネストに接続できませんでした。再度SigmaAPPを立ち上げなおして下さい。")
        End Try
    End Sub
    Private Sub LoadDemoColumns()
        Dim i As Integer = 0
        data9 = New DataTable("gvDemoMachine")
        data9.Clear()
        data9.BeginInit()
        AddColumn(data9, "DemoPic", GetType(Image))
        AddColumn(data9, "DemoName", System.Type.GetType("System.String"))
        data9.EndInit()

        gcDemoMachine.DataSource = data9
        gcDemoMachine.DefaultView.PopulateColumns()
        gvDemoMachine.Columns(0).Width = 150
        gvDemoMachine.Columns(1).Width = 150
        gvDemoMachine.Columns.ColumnByFieldName("DemoPic").Caption = "画像"
        gvDemoMachine.Columns.ColumnByFieldName("DemoName").Caption = "デモ名"
        gvDemoMachine.Columns("DemoPic").ColumnEdit = riPicM

        data10 = New DataTable("gvDemoFeatures")
        data10.Clear()
        data10.BeginInit()
        AddColumn(data10, "DemoPic", GetType(Image))
        AddColumn(data10, "DemoName", System.Type.GetType("System.String"))
        data10.EndInit()

        gcDemoFeatures.DataSource = data10
        gcDemoFeatures.DefaultView.PopulateColumns()
        gvDemoFeatures.Columns(0).Width = 150
        gvDemoFeatures.Columns(1).Width = 150
        gvDemoFeatures.Columns.ColumnByFieldName("DemoPic").Caption = "画像"
        gvDemoFeatures.Columns.ColumnByFieldName("DemoName").Caption = "デモ名"
        gvDemoFeatures.Columns("DemoPic").ColumnEdit = riPicF
    End Sub
    Private Sub LoadDemoData()
        Dim DemoDataPath As String = SigmanestDataPath & "デモ用データ\機械別\"
        Dim MachinePic As String = ""
        Dim NoImagePath As String = SigmanestDataPath & "デモ用データ\noimage.png"
        data9.Clear()
        If Directory.Exists(SigmanestDataPath) Then
            For Each Dir As String In Directory.GetDirectories(DemoDataPath)
                Dim dra As New System.IO.DirectoryInfo(Dir)
                Dim diar1 As System.IO.FileInfo() = dra.GetFiles()
                Dim dra2 As System.IO.FileInfo
                MachinePic = ""
                For Each dra2 In diar1
                    If UCase(Path.GetExtension(dra2.FullName)) = ".JPG" Or UCase(Path.GetExtension(dra2.FullName)) = ".PNG" Then
                        MachinePic = dra2.FullName
                        Exit For
                    End If
                Next

                If MachinePic = "" Then
                    Dim image1 As Bitmap = CType(Image.FromFile(NoImagePath, True), Bitmap)
                    data9.Rows.Add(image1, dra.Name)
                Else
                    Dim image1 As Bitmap = CType(Image.FromFile(MachinePic, True), Bitmap)
                    data9.Rows.Add(image1, dra.Name)
                End If

            Next
        Else
            MsgBox("Google Driveのパスを変更して下さい。")
        End If

        Dim DemoFDataPath As String = SigmanestDataPath & "デモ用データ\機能別\"
        data10.Clear()
        If Directory.Exists(SigmanestDataPath) Then
            For Each Dir As String In Directory.GetDirectories(DemoFDataPath)
                Dim dra As New System.IO.DirectoryInfo(Dir)
                Dim diar1 As System.IO.FileInfo() = dra.GetFiles()
                Dim dra2 As System.IO.FileInfo
                MachinePic = ""
                For Each dra2 In diar1
                    If UCase(Path.GetExtension(dra2.FullName)) = ".JPG" Or UCase(Path.GetExtension(dra2.FullName)) = ".PNG" Then
                        MachinePic = dra2.FullName
                        Exit For
                    End If
                Next
                If MachinePic = "" Then
                    Dim image1 As Bitmap = CType(Image.FromFile(NoImagePath, True), Bitmap)
                    data10.Rows.Add(image1, dra.Name)
                Else
                    Dim image1 As Bitmap = CType(Image.FromFile(MachinePic, True), Bitmap)
                    data10.Rows.Add(image1, dra.Name)
                End If

            Next
        Else
            MsgBox("Google Driveのパスを変更して下さい。")
        End If
    End Sub
    Private Sub ShowDemoVideo()
        Dim DemoName As String = ""
        Dim DemoDataPath As String = ""
        Dim videofound As Boolean = False
        If gvDemoFeatures.SelectedRowsCount > 0 And DemoFocus = "Feature" Then
            DemoName = gvDemoFeatures.GetRowCellValue(gvDemoFeatures.GetSelectedRows(0), "DemoName").ToString
            DemoDataPath = SigmanestDataPath & "デモ用データ\機能別\" & DemoName & "\VIDEO\"
        ElseIf gvDemoMachine.SelectedRowsCount > 0 And DemoFocus = "Machine" Then
            DemoName = (gvDemoMachine.GetRowCellValue(gvDemoMachine.GetSelectedRows(0), "DemoName").ToString)
            DemoDataPath = SigmanestDataPath & "デモ用データ\機械別\" & DemoName & "\VIDEO\"
        End If

        Dim di As New System.IO.DirectoryInfo(DemoDataPath)
        If Directory.Exists(DemoDataPath) Then
            Dim diar1 As System.IO.FileInfo() = di.GetFiles()
            Dim dra As System.IO.FileInfo
            For Each dra In diar1
                If UCase(Path.GetExtension(dra.FullName)) = ".WMV" Or UCase(Path.GetExtension(dra.FullName)) = ".AVI" Then
                    Process.Start(dra.FullName)
                    videofound = True
                    Exit For
                End If
            Next
        End If
        If videofound = False Then
            MsgBox("ビデオファイルが見つかりません。")
        End If
    End Sub
    Private Sub LoadDemoSet()
        If gvDemoFeatures.SelectedRowsCount > 0 And DemoFocus = "Feature" Then
            Dim DemoName As String = gvDemoFeatures.GetRowCellValue(gvDemoFeatures.GetSelectedRows(0), "DemoName").ToString
            LoadDemoMachines(DemoName, "機能別")
        ElseIf gvDemoMachine.SelectedRowsCount > 0 And DemoFocus = "Machine" Then
            Dim DemoName As String = gvDemoMachine.GetRowCellValue(gvDemoMachine.GetSelectedRows(0), "DemoName").ToString
            LoadDemoMachines(DemoName, "機械別")
        End If
    End Sub
    Private Sub gcDemoMachine_DoubleClick(sender As Object, e As EventArgs) Handles gcDemoMachine.DoubleClick
        Dim DemoName As String = gvDemoMachine.GetRowCellValue(gvDemoMachine.GetSelectedRows(0), "DemoName").ToString
        LoadDemoMachines(DemoName, "機械別")
    End Sub
    Private Sub gcDemoFeatures_DoubleClick(sender As Object, e As EventArgs) Handles gcDemoFeatures.DoubleClick
        Dim DemoName As String = gvDemoFeatures.GetRowCellValue(gvDemoFeatures.GetSelectedRows(0), "DemoName").ToString
        LoadDemoMachines(DemoName, "機能別")
    End Sub
    Dim DemoFocus As String = ""
    Private Sub gcDemoMachine_Click(sender As Object, e As EventArgs) Handles gcDemoMachine.Click
        DemoFocus = "Machine"
        Dim DemoName As String = gvDemoMachine.GetRowCellValue(gvDemoMachine.GetSelectedRows(0), "DemoName").ToString
        Dim DemoDataPath As String = SigmanestDataPath & "デモ用データ\機械別\" & DemoName & "\"
        GblDemoDataPath = DemoDataPath
    End Sub
    Private Sub gcDemoFeatures_Click(sender As Object, e As EventArgs) Handles gcDemoFeatures.Click
        DemoFocus = "Feature"
        Dim DemoName As String = gvDemoFeatures.GetRowCellValue(gvDemoFeatures.GetSelectedRows(0), "DemoName").ToString
        Dim DemoDataPath As String = SigmanestDataPath & "デモ用データ\機能別\" & DemoName & "\"
        GblDemoDataPath = DemoDataPath
    End Sub
    Private Sub gvDemoMachine_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvDemoMachine.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            Dim WOLPath As String = GblDemoDataPath & "WOL\"
            If Directory.Exists(WOLPath) Then
                ttsShowDemoWOL.Visible = True
            Else
                ttsShowDemoWOL.Visible = False
            End If
            Dim HelpPath As String = GblDemoDataPath & "Help\"
            If Directory.Exists(HelpPath) Then
                ttsOpenDemoHelp.Visible = True
            Else
                ttsOpenDemoHelp.Visible = False
            End If
            Me.cmsDemo.Show(gcDemoMachine, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvDemoFeatures_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvDemoFeatures.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            Dim WOLPath As String = GblDemoDataPath & "WOL\"
            If Directory.Exists(WOLPath) Then
                ttsShowDemoWOL.Visible = True
            Else
                ttsShowDemoWOL.Visible = False
            End If
            Dim HelpPath As String = GblDemoDataPath & "Help\"
            If Directory.Exists(HelpPath) Then
                ttsOpenDemoHelp.Visible = True
            Else
                ttsOpenDemoHelp.Visible = False
            End If
            Me.cmsDemo.Show(gcDemoFeatures, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub ttsShowDemoVideo_Click(sender As Object, e As EventArgs) Handles ttsShowDemoVideo.Click
        ShowDemoVideo()
    End Sub
    Private Sub ttsShowDemoWOL_Click(sender As Object, e As EventArgs) Handles ttsShowDemoWOL.Click
        Dim WOLPath As String = GblDemoDataPath & "WOL\"
        If Directory.Exists(WOLPath) Then
            Dim di As New System.IO.DirectoryInfo(WOLPath)
            Dim diar1 As System.IO.FileInfo() = di.GetFiles()
            Dim dra As System.IO.FileInfo
            For Each dra In diar1
                If UCase(Path.GetExtension(dra.FullName)) = ".WOL" Then
                    Process.Start(dra.FullName)
                End If
            Next
        End If
    End Sub
    Private Sub ttsOpenDemoHelp_Click(sender As Object, e As EventArgs) Handles ttsOpenDemoHelp.Click
        Dim HelpPath As String = GblDemoDataPath & "Help\"
        If Directory.Exists(HelpPath) Then
            Dim di As New System.IO.DirectoryInfo(HelpPath)
            Dim diar1 As System.IO.FileInfo() = di.GetFiles()
            Dim dra As System.IO.FileInfo
            For Each dra In diar1
                If UCase(Path.GetExtension(dra.FullName)) = ".PNG" Or UCase(Path.GetExtension(dra.FullName)) = ".JPG" Then
                    Dim frmHelp As New frmDemoHelp
                    Dim bmp As New Bitmap(dra.FullName)
                    frmHelp.Width = bmp.Width + 15
                    frmHelp.Height = bmp.Height + 40
                    frmHelp.picHElp.ImageLocation = dra.FullName
                    frmHelp.Show()
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub bbiSQLManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSQLManager.ItemClick
        Dim SQLManagerPath As String = "C:\Program Files (x86)\Common Files\SigmaTEK Shared\SQLManager\SNSQLManager.exe"
        If File.Exists(SQLManagerPath) Then
            Process.Start(SQLManagerPath)
        End If
    End Sub
#End Region
#Region "Video"
    Private Sub LoadVideoColumns()
        Dim i As Integer = 0
        data11 = New DataTable("gvVideo")
        data11.Clear()
        data11.BeginInit()
        AddColumn(data11, "VideoCategory", System.Type.GetType("System.String"))
        AddColumn(data11, "VideoName", System.Type.GetType("System.String"))
        AddColumn(data11, "VideoPath", System.Type.GetType("System.String"))
        data11.EndInit()

        gcVideo.DataSource = data11
        gcVideo.DefaultView.PopulateColumns()
        gvVideo.Columns(0).Width = 150
        gvVideo.Columns(1).Width = 150
        gvVideo.Columns(2).Visible = False
        gvVideo.Columns.ColumnByFieldName("VideoCategory").Caption = "カテゴリ"
        gvVideo.Columns.ColumnByFieldName("VideoName").Caption = "ビデオ名"

    End Sub
    Dim GblVideopath As String = ""
    Private Sub LoadVideoData(ByVal MyPath As String)
        Dim VideoFullPath As String = VPNSigmaDocumentsPath & MyPath & "\"
        GblVideopath = VideoFullPath
        data11.Clear()
        If Directory.Exists(VideoFullPath) Then
            For Each Dir As String In Directory.GetDirectories(VideoFullPath)
                Dim dra As New System.IO.DirectoryInfo(Dir)
                Dim diar1 As System.IO.FileInfo() = dra.GetFiles()
                Dim VideoName As String = ""
                Dim VideoPath As String = ""
                For Each file In diar1
                    VideoName = file.Name
                    VideoPath = file.FullName
                    If UCase(Path.GetExtension(VideoPath)) <> ".INI" Then
                        data11.Rows.Add(dra.Name, VideoName, VideoPath)
                    End If

                Next
            Next
        Else
            MsgBox("VPNに接続できません。")
        End If
        gvVideo.BeginSort()
        Try
            gvVideo.ClearGrouping()
            gvVideo.Columns("VideoCategory").GroupIndex = 0
        Finally
            gvVideo.EndSort()
            gvVideo.ExpandAllGroups()
        End Try
    End Sub
    Private Sub LoadVideo()
        Try
            Dim VideoPath As String = gvVideo.GetRowCellValue(gvVideo.GetSelectedRows(0), "VideoPath").ToString
            If UCase(Path.GetExtension(VideoPath)) = ".WMV" Or UCase(Path.GetExtension(VideoPath)) = ".AVI" Or UCase(Path.GetExtension(VideoPath)) = ".MP4" Then
                Process.Start(VideoPath)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bbiShowVideo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiShowVideo.ItemClick
        If xtcMain.SelectedTabPage Is tabDemo Then
            ShowDemoVideo()
        ElseIf xtcMain.SelectedTabPage Is tabVideo Then
            rpgSlideshow.Visible = False
            LoadVideoData("プレゼン用ビデオ")
            ' LoadVideo()
        ElseIf xtcMain.SelectedTabPage Is tabApps Then
            LoadAppVideo()
        End If
    End Sub
    Private Sub gcVideo_DoubleClick(sender As Object, e As EventArgs) Handles gcVideo.DoubleClick
        LoadVideo()
    End Sub
    Dim ShowVideo As Boolean = False
    Private Sub gvVideo_FocusedRowChanged(sender As Object, e As EventArgs) Handles gvVideo.FocusedRowChanged
        Try
            Dim image1 As Bitmap
            Dim VideoPath As String = gvVideo.GetRowCellValue(gvVideo.GetSelectedRows(0), "VideoPath").ToString
            If UCase(Path.GetExtension(VideoPath)) = ".JPG" Or UCase(Path.GetExtension(VideoPath)) = ".PNG" Or UCase(Path.GetExtension(VideoPath)) = ".BMP" Then
                picImage.Visible = True
                image1 = CType(Image.FromFile(VideoPath, True), Bitmap)
                picImage.Image = image1
            ElseIf UCase(Path.GetExtension(VideoPath)) = ".WMV" Or UCase(Path.GetExtension(VideoPath)) = ".AVI" Or UCase(Path.GetExtension(VideoPath)) = ".MP4" Then
                If ShowVideo = True Then
                    picImage.Visible = True
                    Dim ffMpeg = New NReco.VideoConverter.FFMpegConverter()
                    Dim imageStr As New MemoryStream()
                    ffMpeg.GetVideoThumbnail(VideoPath, imageStr)
                    image1 = Bitmap.FromStream(imageStr)
                    picImage.Image = image1
                Else
                    ShowVideo = True
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ttsShowVideo_Click(sender As Object, e As EventArgs) Handles ttsShowVideo.Click
        LoadVideo()
    End Sub
    Private Sub bbiPicture_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPicture.ItemClick
        rpgSlideshow.Visible = True
        LoadVideoData("写真")
    End Sub
    Private SSimages As New List(Of Image)
    Private SSindex As Integer = 0
    Private Sub bbiSlideshow_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSlideshow.ItemClick
        If bbiSlideshow.Down = True Then
            Dim VideoRoot As String = Path.GetDirectoryName(gvVideo.GetRowCellValue(gvVideo.GetSelectedRows(0), "VideoPath").ToString)
            SSimages.Clear()
            SSindex = 0
            If Directory.Exists(VideoRoot) Then
                Dim di As New System.IO.DirectoryInfo(VideoRoot)
                Dim diar1 As System.IO.FileInfo() = di.GetFiles()
                Dim VideoName As String = ""
                Dim VideoPath As String = ""
                For Each file In diar1
                    VideoName = file.Name
                    VideoPath = file.FullName
                    If UCase(Path.GetExtension(VideoPath)) = ".JPG" Or UCase(Path.GetExtension(VideoPath)) = ".PNG" Then
                        SSimages.Add(Image.FromFile(VideoPath))
                    End If
                Next
            Else
                MsgBox("Google Driveのパスを変更して下さい。")
            End If
            Timer1.Interval = 3000
            Timer1.Start()
        Else
            Timer1.Stop()
        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If SSimages.Count > 0 Then
            If SSindex >= SSimages.Count Then
                SSindex = 0
            End If
            picImage.Image = SSimages(SSindex)
            SSindex += 1
        End If
    End Sub
    Private Sub DeleteVideoImages()
        If gvVideo.SelectedRowsCount > 0 Then
            Dim result As Integer = MessageBox.Show("画像を削除してよろしいでしょうか？", "画像の削除", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim VideoPath As String = gvVideo.GetRowCellValue(gvVideo.GetSelectedRows(0), "VideoPath").ToString
                If File.Exists(VideoPath) Then
                    picImage.Image = Nothing
                    File.Delete(VideoPath)
                    Dim fi As New System.IO.FileInfo(VideoPath)
                    Dim FolderName As String = fi.Directory.Name
                    If rpgSlideshow.Visible = True Then
                        LoadVideoData("写真")
                    Else
                        LoadVideoData("プレゼン用ビデオ")
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region "WebSites"
    Private Sub LoadWebShortcutColumns()

        Dim i As Integer = 0
        data7 = New DataTable("gvWeb")
        data7.Clear()
        data7.BeginInit()
        AddColumn(data7, "Type", System.Type.GetType("System.String"))
        AddColumn(data7, "Description", System.Type.GetType("System.String"))
        AddColumn(data7, "WebLink", System.Type.GetType("System.String"))
        data7.EndInit()

        gcWebLink.DataSource = data7
        gcWebLink.DefaultView.PopulateColumns()
        gvWebLink.Columns(0).Width = 100
        gvWebLink.Columns(1).Width = 150
        gvWebLink.Columns(2).Width = 500

        gvWebLink.Columns.ColumnByFieldName("Type").Caption = "タイプ"
        gvWebLink.Columns.ColumnByFieldName("Description").Caption = "説明"
        gvWebLink.Columns.ColumnByFieldName("WebLink").Caption = "ウェブリンク"
        gvWebLink.Columns(0).OptionsColumn.AllowEdit = False
        gvWebLink.Columns(1).OptionsColumn.AllowEdit = False
    End Sub
    Private Sub LoadWebLinksData()
        LoadWebTypeItems()
        Dim DocPath As String = SigmanestDataPath & "Applications\SigmaAPP\Web\WebLinks.txt"
        Dim LineItem As String = ""
        Dim TmpArr() As String
        data7.Clear()
        Dim sr As New System.IO.StreamReader(DocPath, System.Text.Encoding.GetEncoding(GblEncoding))
        While sr.Peek() > -1
            LineItem = sr.ReadLine()
            TmpArr = Split(LineItem, ",")
            data7.Rows.Add(TmpArr(0), TmpArr(1), TmpArr(2))
        End While
        sr.Close()
        gvWebLink.Columns("Type").SortOrder = ColumnSortOrder.Ascending
    End Sub
    Private Sub SaveWebLinksData()
        If txtWebDescription.Text <> "" And txtWebLink.Text <> "" Then
            Dim DocPath As String = SigmanestDataPath & "Applications\SigmaAPP\Web\WebLinks.txt"
            Dim sw As New System.IO.StreamWriter(DocPath, True, System.Text.Encoding.GetEncoding(GblEncoding))
            'sw.WriteLine(vbCrLf)
            sw.WriteLine(cmbWebType.Text & "," & txtWebDescription.Text & "," & txtWebLink.Text)
            sw.Close()
        End If
        cmbWebType.Text = ""
        txtWebDescription.Text = ""
        txtWebLink.Text = ""
        LoadWebLinksData()
    End Sub
    Private Sub DeleteWebLinksData()
        Dim i As Integer = 0
        If gvWebLink.SelectedRowsCount > 0 Then
            gvWebLink.DeleteRow(gvWebLink.GetSelectedRows(0))
        End If
        gcWebLink.FocusedView.CloseEditor()
        Dim DocPath As String = SigmanestDataPath & "Applications\SigmaAPP\Web\WebLinks.txt"
        Dim sw As New System.IO.StreamWriter(DocPath, False, System.Text.Encoding.GetEncoding(GblEncoding))
        For i = 0 To gvWebLink.RowCount - 1
            Dim WebType As String = gvWebLink.GetRowCellValue(i, "Type").ToString
            Dim Description As String = gvWebLink.GetRowCellValue(i, "Description").ToString
            Dim WebLink As String = gvWebLink.GetRowCellValue(i, "WebLink").ToString
            sw.WriteLine(WebType & "," & Description & "," & WebLink)
        Next
        sw.Close()
        cmbWebType.Text = ""
        txtWebDescription.Text = ""
        txtWebLink.Text = ""
        LoadWebLinksData()
    End Sub
    Private Sub LoadWebTypeItems()
        Dim DocPath As String = SigmanestDataPath & "Applications\SigmaAPP\Web\WebLinks.txt"
        Dim LineItem As String = ""
        Dim TypeName As String = ""
        Dim TmpArr() As String
        Dim TypeArr As New ArrayList
        Dim MatchFound As Boolean = False
        Dim i As Integer = 0
        TypeArr.Clear()
        TypeArr.Add("Misc")
        Dim sr As New System.IO.StreamReader(DocPath, System.Text.Encoding.GetEncoding(GblEncoding))
        While sr.Peek() > -1
            LineItem = sr.ReadLine()
            TmpArr = Split(LineItem, ",")
            TypeName = TmpArr(0)
            MatchFound = False
            For i = 0 To TypeArr.Count - 1
                If TypeName = TypeArr(i) Then
                    MatchFound = True
                End If
            Next
            If MatchFound = False Then
                TypeArr.Add(TypeName)
            End If

        End While
        sr.Close()
        cmbWebType.Properties.Items.Clear()
        For i = 0 To TypeArr.Count - 1
            cmbWebType.Properties.Items.Add(TypeArr(i))
        Next
        cmbWebType.SelectedIndex = 1
    End Sub
    Private Sub ttsCopyClipboard_Click(sender As Object, e As EventArgs) Handles ttsCopyClipboard.Click
        If gvWebLink.SelectedRowsCount > 0 Then
            Dim WebLink As String = gvWebLink.GetRowCellValue(gvWebLink.GetSelectedRows(0), "WebLink").ToString
            Clipboard.SetText(WebLink)
        End If
    End Sub
    Private Sub gvWebLink_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvWebLink.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            Me.cmsWeb.Show(gcWebLink, New Point(e.X, e.Y))
        End If
    End Sub
#End Region
    '#Region "Calendar"
    '    Public Sub CreateOutlookAppointment(Subject As String, Body As String, Location As String, StartTime As Date, EndTime As Date)
    '        Try
    '            ' Create an Outlook application.
    '            Dim oApp As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application()
    '            ' Get NameSpace and Logon.
    '            Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.GetNamespace("mapi")
    '            ' Create a new AppointmentItem.
    '            Dim oAppt As Microsoft.Office.Interop.Outlook.AppointmentItem = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem)

    '            If oAppt Is Nothing Then
    '                ' no appointment was found
    '                ' so create a new one here
    '            End If

    '            ' Set some common properties.
    '            oAppt.Subject = Subject
    '            oAppt.Body = Body
    '            oAppt.Location = Location

    '            oAppt.Start = StartTime
    '            oAppt.End = EndTime

    '            oAppt.ReminderSet = True
    '            oAppt.ReminderMinutesBeforeStart = 720
    '            oAppt.BusyStatus = Microsoft.Office.Interop.Outlook.OlBusyStatus.olBusy  '  olBusy
    '            oAppt.IsOnlineMeeting = False

    '            oAppt.Save()

    '            oNS.Logoff()

    '            ' Clean up.
    '            oApp = Nothing
    '            oNS = Nothing
    '            oAppt = Nothing
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Delegate Sub OItemDelegate(ByVal ThreadStatus As String, ByVal apt As Appointment)
    '    Public Sub OItem(ByVal ThreadStatus As String, ByVal apt As Appointment)
    '        Select Case ThreadStatus
    '            Case "START"
    '                scSchedule.Storage.Appointments.Clear()
    '            Case "FINISHED"

    '            Case Else
    '                scSchedule.Storage.Appointments.Add(apt)
    '        End Select
    '    End Sub
    '    Public Sub LoadOutlookCalendar()
    '        Try
    '            Dim OL As Microsoft.Office.Interop.Outlook.Application
    '            'OL = CreateObject("Outlook.Application")
    '            OL = New Microsoft.Office.Interop.Outlook.Application()
    '            'OL = Marshal.GetActiveObject("Outlook.Application")
    '            'scSchedule.Storage.Appointments.Clear()
    '            If Me.scSchedule.InvokeRequired Then
    '                Me.scSchedule.Invoke(New OItemDelegate(AddressOf OItem), New Object() {"START", Nothing})
    '            Else
    '                Me.OItem("START", Nothing)
    '            End If

    '            Dim myStart As String = Format(Date.Now.AddMonths(-1), "MM/dd/yyyy hh:mm tt")
    '            Dim myEnd As String = Format(Date.Now.AddMonths(1), "MM/dd/yyyy hh:mm tt")
    '            System.Diagnostics.Debug.Print("Looking for appointments between " & myStart & " and " & myEnd)

    '            Dim oSession As Microsoft.Office.Interop.Outlook.NameSpace = OL.Session()
    '            Dim oCalendar As Microsoft.Office.Interop.Outlook.MAPIFolder = oSession.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar)
    '            Dim oItems As Microsoft.Office.Interop.Outlook.Items = oCalendar.Items()

    '            oItems.IncludeRecurrences = True
    '            oItems.Sort("[Start]")

    '            Dim strRestriction As String = "[Start] <= '" & myEnd _
    '                                & "' AND [End] >= '" & myStart & "'"

    '            Dim oResitems As Microsoft.Office.Interop.Outlook.Items = oItems.Restrict(strRestriction)
    '            oResitems.Sort("[Start]")

    '            Dim oAppt As Microsoft.Office.Interop.Outlook.AppointmentItem
    '            oAppt = Nothing
    '            For Each oAppt In oResitems
    '                Dim apt As Appointment = scSchedule.Storage.CreateAppointment(AppointmentType.Pattern)
    '                apt.Subject = oAppt.Subject
    '                apt.Location = oAppt.Location
    '                apt.Description = oAppt.Body
    '                apt.Start = oAppt.Start
    '                apt.End = oAppt.End

    '                'apt.RecurrenceInfo.Type = RecurrenceType.Daily
    '                apt.RecurrenceInfo.Start = apt.Start
    '                apt.RecurrenceInfo.Periodicity = 1
    '                apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
    '                apt.RecurrenceInfo.OccurrenceCount = 1
    '                apt.LabelKey = 0
    '                If Me.scSchedule.InvokeRequired Then
    '                    Me.scSchedule.Invoke(New OItemDelegate(AddressOf OItem), New Object() {"CCTHREAD", apt})
    '                Else
    '                    Me.OItem("CCTHREAD", apt)
    '                End If
    '                'scSchedule.Storage.Appointments.Add(apt)
    '            Next

    '            ' Clean up
    '            If Not oAppt Is Nothing Then Marshal.ReleaseComObject(oAppt)
    '            oAppt = Nothing
    '            If Not oResitems Is Nothing Then Marshal.ReleaseComObject(oResitems)
    '            oResitems = Nothing
    '            If Not oItems Is Nothing Then Marshal.ReleaseComObject(oItems)
    '            oItems = Nothing
    '            If Not oCalendar Is Nothing Then Marshal.ReleaseComObject(oCalendar)
    '            oCalendar = Nothing
    '            If Not oSession Is Nothing Then Marshal.ReleaseComObject(oSession)
    '            oSession = Nothing
    '            If Not OL Is Nothing Then Marshal.ReleaseComObject(OL)
    '            OL = Nothing
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Public Sub LoadReminders()
    '        Dim data As DataTable
    '        Dim sql As String
    '        Dim i As Integer = 0
    '        Try

    '            sql = "SELECT * FROM tbl_Events WHERE ReminderDate<>''"
    '            data = GlobalData.GetSQLDataTable(sql)
    '            Dim Title As String = ""
    '            Dim Type As String = ""
    '            Dim ScheduleTime As Date
    '            Dim Description As String = ""
    '            For i = 0 To data.Rows.Count - 1
    '                Title = data.Rows(i).Item("Subject").ToString()
    '                Type = data.Rows(i).Item("Type").ToString()
    '                ScheduleTime = CDate(data.Rows(i).Item("ReminderDate"))
    '                Description = data.Rows(i).Item("EventMemo").ToString()
    '                Dim apt As Appointment = scSchedule.Storage.CreateAppointment(AppointmentType.Pattern)
    '                apt.Subject = Title
    '                apt.Location = Type
    '                apt.Description = Description
    '                apt.Start = ScheduleTime
    '                apt.End = ScheduleTime
    '                apt.RecurrenceInfo.Start = apt.Start
    '                apt.RecurrenceInfo.Periodicity = 1
    '                apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
    '                apt.RecurrenceInfo.OccurrenceCount = 1
    '                apt.LabelKey = 4
    '                scSchedule.Storage.Appointments.Add(apt)
    '            Next
    '        Catch ex As Exception

    '        End Try

    '    End Sub
    '    Public Sub AddNewSchedule(Title As String, ScheduleTime As Date, Description As String)

    '        Try

    '            Dim apt As Appointment = scSchedule.Storage.CreateAppointment(AppointmentType.Pattern)
    '            apt.Subject = Title
    '            apt.Location = Description
    '            apt.Description = ""
    '            apt.Start = ScheduleTime
    '            apt.End = ScheduleTime

    '            apt.RecurrenceInfo.Type = RecurrenceType.Minutely
    '            apt.RecurrenceInfo.Start = apt.Start
    '            apt.RecurrenceInfo.Periodicity = 1
    '            apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
    '            apt.RecurrenceInfo.OccurrenceCount = 1

    '            scSchedule.Storage.Appointments.Add(apt)
    '            'scSchedule.ActiveViewType = SchedulerViewType.Month
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub CreateOutlookMeeting(meetingTitle As String, meetingDate As String, startTime As String, endTime As String, recipientEMail As String)
    '        Dim apptItem As Microsoft.Office.Interop.Outlook.AppointmentItem = Nothing
    '        Dim recipient As Microsoft.Office.Interop.Outlook.Recipient = Nothing
    '        Dim oApp As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application()

    '        If IsDate(meetingDate) And IsDate(startTime) And IsDate(endTime) Then

    '            apptItem = oApp.Session.Application.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem)
    '            recipient = apptItem.Recipients.Add(recipientEMail)
    '            recipient.Type = CType(Microsoft.Office.Interop.Outlook.OlMeetingRecipientType.olRequired, Integer)

    '            With apptItem
    '                .MeetingStatus = Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting
    '                .Subject = meetingTitle
    '                .Start = DateTime.Today & " " & startTime
    '                .End = DateTime.Today & " " & endTime

    '            End With

    '            If apptItem.Recipients.ResolveAll Then
    '                apptItem.Send()
    '            Else
    '                apptItem.Display()
    '            End If

    '            'Release the COM!
    '            If recipient IsNot Nothing Then Marshal.ReleaseComObject(recipient)
    '            If apptItem IsNot Nothing Then Marshal.ReleaseComObject(apptItem)

    '        End If
    '    End Sub
    '    Private Sub bbiCalDay_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCalDay.ItemClick
    '        scSchedule.ActiveViewType = SchedulerViewType.Day
    '        '  CreateOutlookMeeting()
    '    End Sub
    '    Private Sub bbiCalWeek_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCalWeek.ItemClick
    '        scSchedule.ActiveViewType = SchedulerViewType.Week
    '    End Sub
    '    Private Sub bbiCalWork_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCalWork.ItemClick
    '        scSchedule.ActiveViewType = SchedulerViewType.WorkWeek
    '    End Sub
    '    Private Sub bbiCalMonth_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCalMonth.ItemClick
    '        scSchedule.ActiveViewType = SchedulerViewType.Month
    '    End Sub
    '    Private Sub bbiCalTimeline_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCalTimeline.ItemClick
    '        scSchedule.ActiveViewType = SchedulerViewType.Gantt
    '    End Sub
    '#End Region
#Region "Expenses"
    Dim GblExpensesFile As String = ""
    Dim DispMonth As String = ""
    Private Sub LoadExMonthColumns()

        Dim i As Integer = 0
        data17 = New DataTable("gvExMonth")
        data17.Clear()
        data17.BeginInit()
        AddColumn(data17, "Month", System.Type.GetType("System.String"))
        data17.EndInit()

        gcExMonth.DataSource = data17
        gcExMonth.DefaultView.PopulateColumns()
        gvExMonth.Columns.ColumnByFieldName("Month").Caption = "月"
        gvExMonth.Columns(0).OptionsColumn.AllowEdit = False
        gvExMonth.RowHeight = 25
    End Sub
    Private Sub LoadExMonthData()
        Dim i As Integer = 0
        Dim MonthName As String = ""
        data17.Rows.Clear()
        For i = 1 To 12
            MonthName = Microsoft.VisualBasic.Right("00" & i, 2)
            data17.Rows.Add(MonthName)
        Next
        Try
            gvExMonth.FocusedRowHandle = CInt(Date.Today.Month) - 1
        Catch ex As Exception

        End Try
    End Sub
    Private Sub gcExMonth_Click(sender As Object, e As EventArgs) Handles gcExMonth.Click
        If bbiQuotation.Down = False Then
            Dim ExpenseYear As String = Microsoft.VisualBasic.Right("0000" & Date.Today.Year, 4)
            Dim YearPath As String = GblExpensesPath & ExpenseYear & "\"
            Dim ThisMonth As String = Microsoft.VisualBasic.Right("00" & Date.Today.Month, 2)
            If gvExMonth.SelectedRowsCount > 0 Then
                Dim MonthName As String = gvExMonth.GetRowCellValue(gvExMonth.GetSelectedRows(0), "Month").ToString
                DispMonth = YearPath & MonthName
                GblExpensesFile = DispMonth
                SwitchExView()
                If bbiExExpenses.Down = True Then
                    xlsExpenses.LoadDocument(DispMonth & "\Expenses.xls")
                ElseIf bbiExTimecard.Down = True Then
                    xlsExpenses.LoadDocument(DispMonth & "\Timecard.xls")
                End If

            End If
        End If
    End Sub
    Private Sub LoadExpenses()
        deExDate.DateTime = Date.Today
        cmbExMealMember.Text = GblMyName & ","
        Dim i As Integer = 0
        Try
            cmbExCustomer.Properties.Items.Clear()
            cmbExCustomer.Properties.Items.Add("社内ミーティング")
            For i = 0 To GblDirList.Count - 1
                Dim CustomerName As String = GblDirList(i)
                cmbExCustomer.Properties.Items.Add(CustomerName)
            Next
        Catch ex As Exception

        End Try
        chkExForCompany.Checked = True
        Try
            Dim WebUrl As String
            WebUrl = "http://www.navitime.co.jp/"
            Dim address As New Uri(WebUrl)
            webExpenses.Url = address
        Catch ex As Exception

        End Try

        LoadAIExpenses()
    End Sub
    Private Sub PrepareExpenseDirectory()
        Try
            Dim ExcelPath As String = SigmanestDataPath & "Applications\SigmaAPP\Expenses\Expenses.xls"
            Dim TimePath As String = SigmanestDataPath & "Applications\SigmaAPP\Expenses\Timecard.xls"
            If Directory.Exists(GblExpensesPath) = False Then
                Directory.CreateDirectory(GblExpensesPath)
            End If
            Dim ExpenseYear As String = Microsoft.VisualBasic.Right("0000" & Date.Today.Year, 4)
            Dim YearPath As String = GblExpensesPath & ExpenseYear & "\"
            If Directory.Exists(YearPath) = False Then
                Directory.CreateDirectory(YearPath)
            End If
            Dim i As Integer = 0
            Dim ExpenseMonth As String = ""
            Dim MonthPath As String = ""
            Dim ExpenseXLSPath As String = ""
            Dim TimeXLSPath As String = ""
            For i = 1 To 12
                ExpenseMonth = Microsoft.VisualBasic.Right("00" & i.ToString, 2)
                MonthPath = YearPath & ExpenseMonth & "\"
                If Directory.Exists(MonthPath) = False Then
                    Directory.CreateDirectory(MonthPath)
                End If
                ExpenseXLSPath = MonthPath & "Expenses.xls"
                If File.Exists(ExpenseXLSPath) = False Then
                    File.Copy(ExcelPath, ExpenseXLSPath, False)
                End If
                TimeXLSPath = MonthPath & "Timecard.xls"
                If File.Exists(TimeXLSPath) = False Then
                    File.Copy(TimePath, TimeXLSPath, False)
                End If
            Next
            Dim ThisMonth As String = Microsoft.VisualBasic.Right("00" & Date.Today.Month, 2)
            DispMonth = YearPath & ThisMonth
            GblExpensesFile = DispMonth
            SwitchExView()

            xlsExpenses.LoadDocument(DispMonth & "\Expenses.xls")
        Catch ex As Exception

        End Try

    End Sub
    Private Sub WriteToExpenses()
        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B7").Value = "TASSS"
    End Sub
    Private Sub chkHotel_CheckedChanged(sender As Object, e As EventArgs) Handles chkHotel.CheckedChanged
        If chkHotel.Checked = True Then
            txtExHotel.Text = "8000"
        Else
            txtExHotel.Text = "0"
        End If
    End Sub
    Private Sub chkNitto_CheckedChanged(sender As Object, e As EventArgs) Handles chkNitto.CheckedChanged
        If chkNitto.Checked = True Then
            If GblExNitto = "" Then
                txtExNitto.Text = "3000"
            Else
                txtExNitto.Text = GblExNitto
            End If
            If txtExCurrencyRate.Text <> 1 Then
                txtExNitto.Text = "5000"
            End If
        Else
            txtExNitto.Text = "0"
        End If
    End Sub
    Private Sub btnExSearch_Click(sender As Object, e As EventArgs) Handles btnExSearch.Click
        If cmbExLocStart.Text <> "" And cmbExLocEnd.Text <> "" Then
            bbiExWeb.Down = True
            bbiExExcel.Down = False
            SwitchExView()
            'Dim WebUrl As String = "http://maps.google.com/maps?saddr=" & Replace(txtExLocStart.Text, " ", "+") & "&daddr=" & Replace(txtExLocEnd.Text, " ", "+") & ""
            Dim WebUrl As String
            If rdoTransporation.SelectedIndex = 0 Or rdoTransporation.SelectedIndex = 1 Then
                WebUrl = "http://www.navitime.co.jp/transfer/searchlist?orvStationName=" & Replace(cmbExLocStart.Text, " ", "+") & "&dnvStationName=" & Replace(cmbExLocEnd.Text, " ", "+") & "&basis=1&airplane=1&sprexprs=1&utrexprs=1&othexprs=1&mtrplbus=1&intercitybus=1&ferry=1&wspeed=100&month=2015/2&day=26&hour=14&minute=52&isrec=1&sort=0&from=view.transfer.searchlist.tab.time#routedetail_1"
            Else
                WebUrl = "http://www.navitime.co.jp/?keyword0=" & Replace(cmbExLocStart.Text, " ", "+") & "&keyword1=" & Replace(cmbExLocEnd.Text, " ", "+") & "&ctl=00001&mode=car&tollroad=1&orv=&dnv=&orvAdd=&dnvAdd=&detailset=1"
            End If
            Try
                Dim address As New Uri(WebUrl)
                webExpenses.Url = address
            Catch ex As Exception

            End Try
        Else
            MsgBox("出発地と到着地を入力して下さい。")
        End If

    End Sub
    Private Sub rdoTransporation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdoTransporation.SelectedIndexChanged
        If rdoTransporation.SelectedIndex = 3 Then
            cmbExLocStart.Text = GblMyAddress
        ElseIf rdoTransporation.SelectedIndex = 1 Then
            cmbExLocStart.Text = GblMyTrainStation
        Else
            cmbExLocStart.Text = ""
        End If
    End Sub
    Private Sub ExLateEarly()
        If chkExEarly.Checked = True And chkExLate.Checked = True Then
            txtExEarlyLate.Text = "1000"
        ElseIf chkExEarly.Checked = True And chkExLate.Checked = False Then
            txtExEarlyLate.Text = "500"
        ElseIf chkExEarly.Checked = False And chkExLate.Checked = True Then
            txtExEarlyLate.Text = "500"
        Else
            txtExEarlyLate.Text = "0"
        End If
    End Sub
    Private Sub chkExEarly_CheckedChanged(sender As Object, e As EventArgs) Handles chkExEarly.CheckedChanged
        ExLateEarly()
    End Sub
    Private Sub chkExLate_CheckedChanged(sender As Object, e As EventArgs) Handles chkExLate.CheckedChanged
        ExLateEarly()
    End Sub
    Private Sub SwitchExView()
        If bbiExExcel.Down = True Then
            xtcTools.SelectedTabPage = tabExSpreadsheet
        Else
            xtcTools.SelectedTabPage = tabExWeb
        End If
    End Sub
    Private Sub bbiExExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExExcel.ItemClick
        bbiExExcel.Down = True
        bbiExWeb.Down = False
        SwitchExView()
    End Sub
    Private Sub bbiExWeb_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExWeb.ItemClick
        bbiExExcel.Down = False
        bbiExWeb.Down = True
        SwitchExView()
    End Sub
    Private Sub ClearExValues()
        chkExEarly.Checked = False
        chkExLate.Checked = False
        chkExForCompany.Checked = True
        chkHotel.Checked = False
        chkNitto.Checked = False
        cmbExCustomer.Text = ""
        txtExCurrencyRate.Text = "1"
        txtExHotel.Text = ""
        txtExNitto.Text = ""
        txtExEarlyLate.Text = ""
        txtExBreakfast.Text = ""
        txtExLunch.Text = ""
        txtExDinner.Text = ""
        txtExMealMisc.Text = ""
        cmbExMealMember.Text = ""
        cmbExLocEnd.Text = ""
        cmbExLocStart.Text = ""
        rdoTransporation.SelectedIndex = 0
        txtExTrain.Text = ""
        txtExAir.Text = ""
        txtExTaxi.Text = ""
        txtExCarRental.Text = ""
        txtExHighway.Text = ""
        txtExParking.Text = ""
        txtExCarMiles.Text = ""
        txtExGas.Text = ""
        txtExPostal.Text = ""
        txtExOvPostal.Text = ""
        txtExAdvertising.Text = ""
        txtExRevenue.Text = ""
        txtExGift.Text = ""
        txtExMisc.Text = ""
    End Sub
    Private Sub UndoExpenses()
        For i = ExFinIndex To ExStartIndex Step -1
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("E" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("H" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("I" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("J" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("K" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("L" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("M" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("N" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("O" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("P" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Q" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("R" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("S" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("T" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("U" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("V" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("W" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("X" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Y" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Z" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AA" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AB" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & i).Value = ""
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AE" & i).Value = ""
        Next
    End Sub
    Private Function FormatDouble(ByVal FormatValue As String) As Double
        Dim FVal As Double
        If IsNumeric(FormatValue) = True Then
            FVal = CDbl(FormatValue)
        Else
            FVal = 0
        End If
        FormatDouble = FVal
    End Function
    Dim ExStartIndex As Integer = 0
    Dim ExFinIndex As Integer = 0
    Private Sub EnterExpenseData()
        Try
            SaveAIExpenses()
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B1").Value = "Team Member: " & GblMyName
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("P55").Value = Date.Today
            Dim i As Integer = 0
            Dim DateField As String = ""
            Dim ExDate As Date = deExDate.DateTime.Date
            Dim ExCustomer As String = cmbExCustomer.Text
            Dim ExHotel As String = txtExHotel.Text
            Dim ExNitto As String = txtExNitto.Text
            'Dim ExNitto As String = txtExNitto.Text
            Dim ExEarlyLate As String = txtExEarlyLate.Text
            Dim ExBreakfast As String = txtExBreakfast.Text
            Dim ExLunch As String = txtExLunch.Text
            Dim ExDinner As String = txtExDinner.Text
            Dim ExMealMisc As String = txtExMealMisc.Text
            Dim ExMealMember As String = cmbExMealMember.Text
            Dim ExLocEnd As String = cmbExLocEnd.Text
            Dim ExLocStart As String = cmbExLocStart.Text
            Dim ExTrain As String = txtExTrain.Text
            Dim ExAir As String = txtExAir.Text
            Dim ExTaxi As String = txtExTaxi.Text
            Dim ExCarRental As String = txtExCarRental.Text
            Dim ExHighway As String = txtExHighway.Text
            Dim ExParking As String = txtExParking.Text
            Dim ExCarMiles As String = txtExCarMiles.Text
            Dim ExGas As String = txtExGas.Text
            Dim ExPostal As String = txtExPostal.Text
            Dim ExOvPostal As String = txtExOvPostal.Text
            Dim ExAdvertising As String = txtExAdvertising.Text
            Dim ExRevenue As String = txtExRevenue.Text
            Dim ExGift As String = txtExGift.Text
            Dim ExMisc As String = txtExMisc.Text
            Dim StartIndex As Integer = 0
            Dim AddIndex As Integer = 0
            Dim DateNum As String = ExDate.Date.Day
            Dim CRate As Double = 1

            If IsNumeric(txtExCurrencyRate.Text) Then
                CRate = CDbl(txtExCurrencyRate.Text)
            Else
                CRate = 1
            End If
            For i = 7 To 42
                DateField = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & i).Value.ToString
                If ExDate < DateField Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Rows.Insert(i - 1)
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Rows(i - 1).CopyFrom(xlsExpenses.Document.Worksheets.ActiveWorksheet.Rows(i - 2), PasteSpecial.All)
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Rows(i - 1).ClearContents()
                    StartIndex = i
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Rows.Remove(42)
                    Exit For
                End If
                If DateField = "" Then
                    StartIndex = i
                    Exit For
                End If
            Next

            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex).Value = ExCustomer
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = DateNum
            If ExNitto <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("E" & StartIndex).Formula = "=" & ExNitto
            End If
            If chkExEarly.Checked = True Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Value = 500
            End If
            If chkExLate.Checked = True Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Value = 500
            End If
            Dim AddEqual As String = 0
            If ExBreakfast <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("H" & StartIndex + AddIndex).Formula = "=(" & ExBreakfast & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("H" & StartIndex + AddIndex).Formula = "=" & ExBreakfast
                End If

                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "朝食"
                If ExMealMember <> "" Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AE" & StartIndex + AddIndex).Value = ExMealMember
                End If
                If chkExForCompany.Checked = True Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & StartIndex + AddIndex).Value = "社内"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & StartIndex + AddIndex).Value = "取引先"
                End If
                If InStr(1, ExNitto, "=", CompareMethod.Text) <= 0 Then
                    AddEqual = "="
                Else
                    AddEqual = ""
                End If

                If txtExNitto.Text <> "" Then
                    ExNitto = AddEqual & ExNitto & "-500"
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("E" & StartIndex).Formula = ExNitto
                End If
                AddIndex = AddIndex + 1
            End If
            If ExLunch <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("I" & StartIndex + AddIndex).Formula = "=(" & ExLunch & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("I" & StartIndex + AddIndex).Formula = "=" & ExLunch
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "昼食"
                If ExMealMember <> "" Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AE" & StartIndex + AddIndex).Value = ExMealMember
                End If
                If chkExForCompany.Checked = True Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & StartIndex + AddIndex).Value = "社内"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & StartIndex + AddIndex).Value = "取引先"
                End If
                If InStr(1, ExNitto, "=", CompareMethod.Text) <= 0 Then
                    AddEqual = "="
                Else
                    AddEqual = ""
                End If
                If txtExNitto.Text <> "" Then
                    ExNitto = AddEqual & ExNitto & "-1000"
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("E" & StartIndex).Formula = ExNitto
                End If
                AddIndex = AddIndex + 1
            End If
            If ExDinner <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("J" & StartIndex + AddIndex).Formula = "=(" & ExDinner & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("J" & StartIndex + AddIndex).Formula = "=" & ExDinner
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "夕食"
                If ExMealMember <> "" Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AE" & StartIndex + AddIndex).Value = ExMealMember
                End If
                If chkExForCompany.Checked = True Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & StartIndex + AddIndex).Value = "社内"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & StartIndex + AddIndex).Value = "取引先"
                End If
                If InStr(1, ExNitto, "=", CompareMethod.Text) <= 0 Then
                    AddEqual = "="
                Else
                    AddEqual = ""
                End If
                If txtExNitto.Text <> "" Then
                    ExNitto = AddEqual & ExNitto & "-1000"
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("E" & StartIndex).Formula = ExNitto
                End If
                AddIndex = AddIndex + 1
            End If
            If ExMealMisc <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("K" & StartIndex + AddIndex).Formula = "=(" & ExMealMisc & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("K" & StartIndex + AddIndex).Formula = "=" & ExMealMisc
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "その他"
                If ExMealMember <> "" Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AE" & StartIndex + AddIndex).Value = ExMealMember
                End If
                If chkExForCompany.Checked = True Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & StartIndex + AddIndex).Value = "社内"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AD" & StartIndex + AddIndex).Value = "取引先"
                End If
                If InStr(1, ExNitto, "=", CompareMethod.Text) <= 0 Then
                    AddEqual = "="
                Else
                    AddEqual = ""
                End If
                If txtExNitto.Text <> "" Then
                    ExNitto = AddEqual & ExNitto & "-1000"
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("E" & StartIndex).Formula = ExNitto
                End If
                AddIndex = AddIndex + 1
            End If

            If ExHotel <> "" Then
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("L" & StartIndex).Formula = "=(" & ExHotel & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("L" & StartIndex).Formula = "=" & ExHotel
                End If
            End If
            xlsExpenses.Document.CalculateFullRebuild()
            If ExTrain <> "" Then
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("M" & StartIndex).Formula = "=(" & ExTrain & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("M" & StartIndex).Formula = "=" & ExTrain
                End If
            End If
            If ExLocStart <> "" And ExLocEnd <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AA" & StartIndex).Value = ExLocStart & "→" & ExLocEnd
            End If
            If ExAir <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("N" & StartIndex + AddIndex).Formula = "=(" & ExAir & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("N" & StartIndex + AddIndex).Formula = "=" & ExAir
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "航空券"
                AddIndex = AddIndex + 1
            End If
            If ExHighway <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("O" & StartIndex + AddIndex).Formula = "=(" & ExHighway & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("O" & StartIndex + AddIndex).Formula = "=" & ExHighway
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "高速代金"
                AddIndex = AddIndex + 1
            End If
            If ExCarRental <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("P" & StartIndex + AddIndex).Formula = "=(" & ExCarRental & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("P" & StartIndex + AddIndex).Formula = "=" & ExCarRental
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "レンタカー"
                AddIndex = AddIndex + 1
            End If
            If ExTaxi <> "" Then
                If InStr(1, ExTaxi, "+", CompareMethod.Text) > 0 Then
                    Dim tmparr() As String
                    tmparr = Split(ExTaxi, "+")
                    For i = 0 To tmparr.Count - 1
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                        If CRate <> 1 Then
                            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Q" & StartIndex + AddIndex).Formula = "=(" & tmparr(i) & " * " & CRate & ")"
                        Else
                            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Q" & StartIndex + AddIndex).Formula = "=" & tmparr(i)
                        End If
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "タクシー・バス(￥" & tmparr(i) & ")"
                        AddIndex = AddIndex + 1
                    Next
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                    If CRate <> 1 Then
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Q" & StartIndex + AddIndex).Formula = "=(" & ExTaxi & " * " & CRate & ")"
                    Else
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Q" & StartIndex + AddIndex).Formula = "=" & ExTaxi
                    End If
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "タクシー・バス(￥" & ExTaxi & ")"
                    AddIndex = AddIndex + 1
                End If
            End If
            If ExGas <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("R" & StartIndex + AddIndex).Formula = "=(" & ExGas & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("R" & StartIndex + AddIndex).Formula = "=" & ExGas
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "ガソリン"
                AddIndex = AddIndex + 1
            End If
            If ExParking <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("S" & StartIndex + AddIndex).Formula = "=(" & ExParking & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("S" & StartIndex + AddIndex).Formula = "=" & ExParking
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "パーキング"
                AddIndex = AddIndex + 1
            End If
            If ExCarMiles <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = DateNum
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("T" & StartIndex).Formula = "=(" & ExCarMiles & " * 40)"
            End If
            If ExPostal <> "" Then
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("U" & StartIndex).Formula = "=(" & ExPostal & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("U" & StartIndex).Formula = "=" & ExPostal
                End If
            End If
            If ExOvPostal <> "" Then
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("V" & StartIndex).Formula = "=(" & ExOvPostal & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("V" & StartIndex).Formula = "=" & ExOvPostal
                End If
            End If
            If ExGift <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("W" & StartIndex + AddIndex).Formula = "=(" & ExGift & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("W" & StartIndex + AddIndex).Formula = "=" & ExGift
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "お土産"
                AddIndex = AddIndex + 1
            End If
            If ExAdvertising <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("X" & StartIndex + AddIndex).Formula = "=(" & ExAdvertising & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("X" & StartIndex + AddIndex).Formula = "=" & ExAdvertising
                End If
                AddIndex = AddIndex + 1
            End If
            If ExRevenue <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Y" & StartIndex + AddIndex).Formula = "=(" & ExRevenue & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Y" & StartIndex + AddIndex).Formula = "=" & ExRevenue
                End If

                AddIndex = AddIndex + 1
            End If
            If ExMisc <> "" Then
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("B" & StartIndex + AddIndex).Value = ExCustomer
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex + AddIndex).Value = Microsoft.VisualBasic.Left(ExDate.ToString, 10)
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex + AddIndex).Value = DateNum
                If CRate <> 1 Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Z" & StartIndex + AddIndex).Formula = "=(" & ExMisc & " * " & CRate & ")"
                Else
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("Z" & StartIndex + AddIndex).Formula = "=" & ExMisc
                End If
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("AC" & StartIndex + AddIndex).Value = "その他"
                AddIndex = AddIndex + 1
            End If
            ExStartIndex = StartIndex
            ExFinIndex = StartIndex + AddIndex
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ClearExValues()
    End Sub
    Private Sub SaveAIExpenses()
        Dim LineItem As String = ""
        Dim MealMember As String = SigmanestDataPath & "Applications\SigmaAPP\Expenses\MealMember.txt"
        Dim MemberFound As Boolean = False
        If File.Exists(MealMember) = True Then
            Dim sr As New System.IO.StreamReader(MealMember, System.Text.Encoding.GetEncoding(GblEncoding))
            While sr.Peek() > -1
                LineItem = sr.ReadLine()
                If cmbExMealMember.Text = LineItem Then
                    MemberFound = True
                End If
            End While
            sr.Close()
            If MemberFound = False Then
                Dim sw As New System.IO.StreamWriter(MealMember, True, System.Text.Encoding.GetEncoding(GblEncoding))
                sw.WriteLine(cmbExMealMember.Text)
                sw.Close()
            End If
        Else
            Dim sw As New System.IO.StreamWriter(MealMember, False, System.Text.Encoding.GetEncoding(GblEncoding))
            sw.Close()
        End If
        Dim Location As String = SigmanestDataPath & "Applications\SigmaAPP\Expenses\Location.txt"
        Dim StartLocationFound As Boolean = False
        Dim EndLocationFound As Boolean = False
        If File.Exists(Location) = True Then
            Dim sr As New System.IO.StreamReader(Location, System.Text.Encoding.GetEncoding(GblEncoding))
            While sr.Peek() > -1
                LineItem = sr.ReadLine()
                If cmbExLocStart.Text = LineItem Then
                    StartLocationFound = True
                End If
                If cmbExLocEnd.Text = LineItem Then
                    EndLocationFound = True
                End If
            End While
            sr.Close()
            If StartLocationFound = False Then
                Dim sw As New System.IO.StreamWriter(Location, True, System.Text.Encoding.GetEncoding(GblEncoding))
                sw.WriteLine(cmbExLocStart.Text)
                sw.Close()
            End If
            If EndLocationFound = False Then
                Dim sw As New System.IO.StreamWriter(Location, True, System.Text.Encoding.GetEncoding(GblEncoding))
                sw.WriteLine(cmbExLocEnd.Text)
                sw.Close()
            End If
        Else
            Dim sw As New System.IO.StreamWriter(Location, False, System.Text.Encoding.GetEncoding(GblEncoding))
            sw.Close()
        End If
        LoadAIExpenses()
    End Sub
    Private Sub LoadAIExpenses()
        Dim MealMember As String = SigmanestDataPath & "Applications\SigmaAPP\Expenses\MealMember.txt"
        Dim Location As String = SigmanestDataPath & "Applications\SigmaAPP\Expenses\Location.txt"
        Dim LineItem As String = ""
        If File.Exists(MealMember) = True Then
            Dim sr As New System.IO.StreamReader(MealMember, System.Text.Encoding.GetEncoding(GblEncoding))
            cmbExMealMember.Properties.Items.Clear()
            While sr.Peek() > -1
                LineItem = sr.ReadLine()
                If LineItem <> "" Then
                    cmbExMealMember.Properties.Items.Add(LineItem)
                End If
            End While
            sr.Close()
        End If
        If File.Exists(Location) = True Then
            Dim sr As New System.IO.StreamReader(Location, System.Text.Encoding.GetEncoding(GblEncoding))
            cmbExLocStart.Properties.Items.Clear()
            cmbExLocEnd.Properties.Items.Clear()
            While sr.Peek() > -1
                LineItem = sr.ReadLine()
                If LineItem <> "" Then
                    cmbExLocStart.Properties.Items.Add(LineItem)
                    cmbExLocEnd.Properties.Items.Add(LineItem)
                End If
            End While
            sr.Close()
        End If
    End Sub
    Private Sub SaveExpense()
        If bbiExExpenses.Down = True Then
            Try
                Dim NewPath As String = Replace(DispMonth & "\Expenses.xls", "Expenses.xls", GblMyName & "-Expenses.xls")

                xlsExpenses.SaveDocument()
                MsgBox("登録されました。")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf bbiQuotation.Down = True Then
            Dim fd As SaveFileDialog = New SaveFileDialog()
            Dim strFileName As String = ""
            fd.Title = "ファイル名選択"
            fd.InitialDirectory = GblQuotationPath
            fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True
            If fd.ShowDialog() = DialogResult.OK Then
                strFileName = fd.FileName
                strFileName = Replace(UCase(strFileName), ".XLS", "")
                strFileName = Replace(UCase(strFileName), ".DOC", "")
            End If
            If bbiInvoice.Down = True Or bbiMaintInvoice.Down = True Or bbiMaintQuote.Down = True Then
                xlsDoc.SaveDocument(strFileName & ".xls")
            Else
                xlsExpenses.SaveDocument(strFileName & ".xls")
                If recDoc.Text <> "" Then
                    recDoc.SaveDocument(strFileName & ".doc", DevExpress.XtraRichEdit.DocumentFormat.Doc)
                End If
            End If
        Else
            Try

                Dim DateStr As String = Date.Today.Year & "-" & Path.GetFileNameWithoutExtension(GblExpensesFile)
                Dim NewPath As String = Replace(DispMonth & "\Timecard.xls", "Timecard.xls", DateStr & GblMyName & "出勤簿.xls")
                xlsExpenses.SaveDocument()
                xlsExpenses.SaveDocument(NewPath)
                MsgBox("登録されました。")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Private Sub PDFExpense()
        If bbiQuotation.Down = True Or bbiExExpenses.Down = True Or bbiExTimecard.Down = True Then
            Dim fd As SaveFileDialog = New SaveFileDialog()
            Dim strFileName As String = ""
            fd.Title = "ファイル名選択"
            fd.InitialDirectory = GblQuotationPath
            fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True
            If fd.ShowDialog() = DialogResult.OK Then
                strFileName = fd.FileName
                strFileName = Replace(UCase(strFileName), ".PDF", "")
            End If
            Try
                If bbiQuotation.Down = True Then
                    If bbiInvoice.Down = True Or bbiMaintInvoice.Down = True Or bbiMaintQuote.Down = True Then
                        xlsDoc.ExportToPdf(strFileName & ".PDF")
                    Else
                        xlsExpenses.ExportToPdf(strFileName & ".PDF")
                        If recDoc.Text <> "" Then
                            recDoc.ExportToPdf(strFileName & "-D.PDF")
                        End If
                    End If
                ElseIf bbiExExpenses.Down = True Then
                    xlsExpenses.ExportToPdf(strFileName & ".PDF")
                ElseIf bbiExTimecard.Down = True Then
                    xlsExpenses.ExportToPdf(strFileName & ".PDF")
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub PrintExpense()
        If bbiQuotation.Down = True Or bbiExExpenses.Down = True Or bbiExTimecard.Down = True Then
            Try
                If xtcTools.SelectedTabPage Is tabExSpreadsheet Then
                    xlsExpenses.ShowRibbonPrintPreview()
                ElseIf xtcTools.SelectedTabPage Is tabExSpreadsheet2 Then
                    xlsDoc.ShowRibbonPrintPreview()
                ElseIf xtcTools.SelectedTabPage Is tabExDocument Then
                    recDoc.ShowPrintPreview()
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub LabelControl9_Click(sender As Object, e As EventArgs) Handles LabelControl9.Click
        cmbExCustomer.Text = "A-アロイ"
        txtExCurrencyRate.Text = "1"
        txtExHotel.Text = "8000"
        chkNitto.Checked = True
        txtExNitto.Text = "3000"
        txtExDinner.Text = "3332"
        cmbExMealMember.Text = "別所,理一"
        txtExLunch.Text = "1132"
        cmbExLocStart.Text = "川崎"
        cmbExLocEnd.Text = "岐阜"
        txtExTrain.Text = "10250"
        txtExTaxi.Text = "1020+1030"
        txtExMisc.Text = "2500"
    End Sub
    Private Sub LabelControl33_Click(sender As Object, e As EventArgs) Handles LabelControl33.Click
        cmbExCustomer.Text = "C-Cincinnati"
        txtExCurrencyRate.Text = "120.2"
        txtExHotel.Text = "80"
        chkNitto.Checked = True
        txtExNitto.Text = "5000"
        txtExDinner.Text = "33.22"
        cmbExMealMember.Text = "別所,理一"
        txtExLunch.Text = "11.32"
        cmbExLocStart.Text = "川崎"
        cmbExLocEnd.Text = "岐阜"
        txtExTrain.Text = "102.50"
        txtExTaxi.Text = "10.20+10.30"
        txtExMisc.Text = "25.00"
    End Sub
    Public Shared Function DateRange(Start As DateTime, Thru As DateTime) As IEnumerable(Of Date)
        Return Enumerable.Range(0, (Thru.Date - Start.Date).Days + 1).Select(Function(i) Start.AddDays(i))
    End Function
    Private Sub FillTimecard()
        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("V6").Value = GblMyName
        Dim StartDate As Date = DateSerial(Year(Today()), Month(Today()), 1)
        Dim EndDate As Date = DateSerial(Year(Today()), Month(DateAdd("m", 1, Today())), 0)
        If gvExMonth.SelectedRowsCount > 0 Then
            Dim MonthName As String = gvExMonth.GetRowCellValue(gvExMonth.GetSelectedRows(0), "Month").ToString
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("K6").Value = "(" & Date.Today.Year & "年　" & MonthName & "月分)"
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("L41").Value = "(" & Date.Today.Year & "年　" & MonthName & "月分)"
            Dim CurrentMonth As Integer = Today.Month
            Dim DispMonth As Integer = CInt(MonthName)
            Dim MonthDiff As Integer = -(CurrentMonth - DispMonth)
            StartDate = DateSerial(Year(Today().AddMonths(MonthDiff)), Month(Today().AddMonths(MonthDiff)), 1)
            EndDate = DateSerial(Year(Today().AddMonths(MonthDiff)), Month(DateAdd("m", 1, Today().AddMonths(MonthDiff))), 0)
        Else
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("K6").Value = "(" & Date.Today.Year & "年　" & Date.Today.Month & "月分)"
        End If


        Dim WorkCnt As Integer = 10
        For Each Day As DateTime In DateRange(StartDate, EndDate)
            Select Case Weekday(Day)
                Case 2, 3, 4, 5, 6
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & WorkCnt).Value = CDate("9:00:00")
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("H" & WorkCnt).Value = CDate("18:00:00")
                    '  xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("L" & WorkCnt).Value = 0
                Case Else

            End Select
            WorkCnt += 1
            ' MsgBox(Day.ToShortDateString)
        Next
        xlsExpenses.Document.CalculateFullRebuild()
    End Sub
    Private Sub LoadExDocument()
        If bbiExExpenses.Down = True Then
            xlsExpenses.LoadDocument(DispMonth & "\Expenses.xls")
        ElseIf bbiQuotation.Down = True Then
            Dim PListPath As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\見積もりベース.xls"
            xlsExpenses.LoadDocument(PListPath)
        Else
            xlsExpenses.LoadDocument(DispMonth & "\Timecard.xls")
        End If
    End Sub
    Private Sub LoadExExpenses()
        splMonth.Panel2Collapsed = False
        rpgQuote.Visible = False
        bbiExExpenses.Down = True
        bbiExTimecard.Down = False
        bbiQuotation.Down = False
        LoadExMonthColumns()
        LoadExMonthData()
        xtcTools.SelectedTabPage = tabExSpreadsheet
        xtcCompanyTools.SelectedTabPage = tabMyExpenses
        LoadExDocument()
    End Sub
    Private Sub bbiExExpenses_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExExpenses.ItemClick
        LoadExExpenses()
    End Sub
    Private Sub bbiExTimecard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExTimecard.ItemClick
        splMonth.Panel2Collapsed = False
        rpgQuote.Visible = False
        bbiExExpenses.Down = False
        bbiExTimecard.Down = True
        bbiQuotation.Down = False
        LoadExMonthColumns()
        LoadExMonthData()
        xtcTools.SelectedTabPage = tabExSpreadsheet
        xtcCompanyTools.SelectedTabPage = tabMyExpenses
        LoadExDocument()
    End Sub
    Private Sub bbiQuotation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuotation.ItemClick
        splMonth.Panel2Collapsed = False
        rpgQuote.Visible = True
        bbiExExpenses.Down = False
        bbiExTimecard.Down = False
        bbiQuotation.Down = True
        LoadExHankoColumns()
        LoadQuotePackagesData()
        LoadExDocument()
        xtcTools.SelectedTabPage = tabExSpreadsheet
        xtcCompanyTools.SelectedTabPage = tabSalesTools
    End Sub
    Private Sub bbiExCreate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExCreate.ItemClick
        If bbiExExpenses.Down = True Then
            EnterExpenseData()
        Else
            FillTimecard()
        End If
    End Sub
#End Region
#Region "MailTemplates"
    Private Sub LoadMailTemplateColumns()
        Dim i As Integer = 0
        data6 = New DataTable("gvMailTemplate")
        data6.Clear()
        data6.BeginInit()
        AddColumn(data6, "Subject", System.Type.GetType("System.String"))
        AddColumn(data6, "MailBody", System.Type.GetType("System.String"))
        data6.EndInit()

        gcMailTemplate.DataSource = data6
        gcMailTemplate.DefaultView.PopulateColumns()
        gvMailTemplate.Columns(0).Width = 150
        gvMailTemplate.Columns(1).Width = 600

        gvMailTemplate.Columns.ColumnByFieldName("Subject").Caption = "件名"
        gvMailTemplate.Columns.ColumnByFieldName("MailBody").Caption = "ボディ"
        gvMailTemplate.BestFitColumns()
    End Sub
    Private Sub LoadMailTemplateData()
        Dim DocPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailTemplates\"
        Dim di As New System.IO.DirectoryInfo(DocPath)
        Dim diar1 As System.IO.FileInfo() = di.GetFiles()
        Dim dra As System.IO.FileInfo
        Dim LineItem As String = ""
        data6.Clear()
        For Each dra In diar1
            LineItem = ""
            If UCase(Path.GetExtension(dra.FullName)) = ".TXT" Then
                Dim sr As New System.IO.StreamReader(dra.FullName, System.Text.Encoding.GetEncoding(GblEncoding))
                While sr.Peek() > -1
                    LineItem = LineItem & sr.ReadLine() & vbCrLf
                End While
                sr.Close()

                data6.Rows.Add(Path.GetFileNameWithoutExtension(dra.Name), LineItem)
            End If

        Next
    End Sub
    Private Sub LoadSelectedMail()
        Try
            If gvMailTemplate.SelectedRowsCount > 0 Then
                Dim Subject As String = gvMailTemplate.GetRowCellValue(gvMailTemplate.GetSelectedRows(0), "Subject").ToString
                Dim MailBody As String = gvMailTemplate.GetRowCellValue(gvMailTemplate.GetSelectedRows(0), "MailBody").ToString
                txtSubject.Text = Subject
                rtbBody.Text = MailBody
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaveMailTemplate()
        Try
            If txtSubject.Text <> "" Then
                Dim DocPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailTemplates\" & txtSubject.Text & ".txt"
                Dim sw As New System.IO.StreamWriter(DocPath, False, System.Text.Encoding.GetEncoding(GblEncoding))
                sw.WriteLine(rtbBody.Text)
                sw.Close()
            Else
                MsgBox("件名を入力して下さい。")
            End If
            txtSubject.Text = ""
            rtbBody.Text = ""
            LoadMailTemplateData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DeleteMailTemplate()
        If gvMailTemplate.SelectedRowsCount > 0 Then
            Dim result As Integer = MessageBox.Show("メールテンプレートを削除してよろしいでしょうか？", "メールテンプレート削除", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim Subject As String = gvMailTemplate.GetRowCellValue(gvMailTemplate.GetSelectedRows(0), "Subject").ToString
                Dim DocPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailTemplates\" & Subject & ".txt"
                If File.Exists(DocPath) Then
                    File.Delete(DocPath)
                End If
                txtSubject.Text = ""
                rtbBody.Text = ""
                LoadMailTemplateData()
            End If
        End If
    End Sub
    Private Sub CreateOutlookMail()
        Try
            If gvMailTemplate.SelectedRowsCount > 0 Then
                Dim Subject As String = gvMailTemplate.GetRowCellValue(gvMailTemplate.GetSelectedRows(0), "Subject").ToString
                Dim MailBody As String = gvMailTemplate.GetRowCellValue(gvMailTemplate.GetSelectedRows(0), "MailBody").ToString
                Dim oEMail As Microsoft.Office.Interop.Outlook.MailItem
                Dim i As Integer = 0

                Dim moApp As Microsoft.Office.Interop.Outlook.Application = New Microsoft.Office.Interop.Outlook.Application()
                Me.Cursor = Cursors.WaitCursor
                oEMail = DirectCast(moApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem), Microsoft.Office.Interop.Outlook.MailItem)
                With oEMail
                    .To = ""
                    .Subject = Subject
                    .BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML
                    .Body = MailBody
                    '.Importance = Outlook.OlImportance.olImportanceHigh
                    '.ReadReceiptRequested = True
                    '.Attachments.Add(FilePath, Outlook.OlAttachmentType.olByValue)
                    For i = 0 To SimArr.Count - 1
                        .Attachments.Add(SimArr(i), Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue)
                    Next
                    .Recipients.ResolveAll()
                    .Save()
                    .Display() 'Show the email message and allow for editing before sending
                    '.Send() 'You can automatically send the email without displaying it.
                End With
                Me.Cursor = Cursors.Default
                SimArr.Clear()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub gcMailTemplate_Click(sender As Object, e As EventArgs) Handles gcMailTemplate.Click
        LoadSelectedMail()
    End Sub
    Private Sub gcMailTemplate_DoubleClick(sender As Object, e As EventArgs) Handles gcMailTemplate.DoubleClick
        CreateOutlookMail()
    End Sub
    Private Sub bbiCreateOutlookMail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCreateOutlookMail.ItemClick
        CreateOutlookMail()
    End Sub
    Private Sub bbiMail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMail.ItemClick
        If xtcMain.SelectedTabPage Is tabExpenses Then
            If bbiExExpenses.Down = True Or bbiExTimecard.Down = True Then
                Dim ExpenseYear As String = Microsoft.VisualBasic.Right("0000" & Date.Today.Year, 4)
                Dim YearPath As String = GblExpensesPath & ExpenseYear & "\"
                If gvExMonth.SelectedRowsCount > 0 Then
                    Dim MonthName As String = gvExMonth.GetRowCellValue(gvExMonth.GetSelectedRows(0), "Month").ToString
                    DispMonth = YearPath & MonthName
                    Dim SelPath As String = DispMonth
                    Dim MailForm As New frmMail
                    MailForm.FilePath = SelPath
                    MailForm.ShowDialog()
                End If
            End If

        Else
            Dim SelPath As String = GblCustomerPath & "\" & clbSigmanest.SelectedValue & "\"
            Dim MailForm As New frmMail
            MailForm.FilePath = SelPath
            MailForm.ShowDialog()
        End If
    End Sub
    Private Sub bbiFTPUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFTPUp.ItemClick
        Dim frmFTP As New frmFTP
        frmFTP.ShowDialog()
    End Sub
    Private Sub rtbBody_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles rtbBody.DragDrop

        Try
            splMailMain.Collapsed = False
            If Not e.Data.GetDataPresent(DataFormats.Text) = False Then
                'check if this is an outlook message. The outlook messages, all contain a FileContents attribute. If not, exit.
                Dim formats() As String = e.Data.GetFormats()

                If formats.Contains("FileContents") = False Then Exit Sub

                'they are dragging the attachment
                If (e.Data.GetDataPresent("Object Descriptor")) Then
                    Dim app As New Microsoft.Office.Interop.Outlook.Application() ' // get current selected items
                    Dim selection As Microsoft.Office.Interop.Outlook.Selection
                    Dim myText As String = ""
                    Dim Attachments As New ArrayList
                    Dim FullAttachments As New ArrayList
                    Attachments.Clear()
                    FullAttachments.Clear()

                    selection = app.ActiveExplorer.Selection
                    If selection IsNot Nothing Then

                        Dim mailItem As Microsoft.Office.Interop.Outlook._MailItem
                        For i As Integer = 0 To selection.Count - 1
                            Dim Subject As String = ""
                            Dim ReceiveTime As String = ""
                            Dim Body As String = ""
                            Dim BodyFmt As String = ""
                            Dim ReceivedBy As String = ""
                            mailItem = TryCast(selection.Item(i + 1), Microsoft.Office.Interop.Outlook._MailItem)
                            If mailItem IsNot Nothing Then
                                Try
                                    myText = ""
                                    Subject = mailItem.Subject
                                    ReceivedBy = mailItem.ReceivedByName
                                    ReceiveTime = mailItem.ReceivedTime.ToShortDateString
                                    BodyFmt = Replace(mailItem.Body, vbCrLf & vbCrLf, vbCrLf)
                                    Body = "FROM : " & mailItem.SenderName & vbCrLf & vbCrLf & BodyFmt  'Plain Text Body Message
                                    rtbBody.Text = BodyFmt
                                Catch ex As System.Exception
                                Finally
                                    Marshal.ReleaseComObject(mailItem)
                                End Try

                            End If
                        Next
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub rtbBody_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles rtbBody.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
#End Region
#Region "HTMLMail"
    Private Sub bbiPlaceholders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPlaceholders.ItemClick
        Dim frmPlaceholder As New frmPlaceHolders
        frmPlaceholder.ShowDialog()
    End Sub
    Private Sub LoadMailForm()
        If bbiMailMessage.Down = True Then
            splMailMain.Visible = False
            frmWebMail.Visible = True
            frmWebMail.xtcMailMain.SelectedTabPage = frmWebMail.tabMessage
            ' bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            rpgOutlook.Visible = False
        ElseIf bbiMailTemplate.Down = True Then
            splMailMain.Visible = False
            frmWebMail.Visible = True
            frmWebMail.xtcMailMain.SelectedTabPage = frmWebMail.tabTemplate
            ' bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            rpgOutlook.Visible = False
        ElseIf bbiMailText.Down = True Then
            splMailMain.Visible = True
            frmWebMail.Visible = False
            ' bbiDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            rpgOutlook.Visible = True
        End If

    End Sub
    Private Sub bbiMailMessage_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMailMessage.ItemClick
        bbiMailMessage.Down = True
        bbiMailTemplate.Down = False
        bbiMailText.Down = False
        LoadMailForm()
    End Sub
    Private Sub bbiMailTemplate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMailTemplate.ItemClick
        bbiMailMessage.Down = False
        bbiMailTemplate.Down = True
        bbiMailText.Down = False
        LoadMailForm()
    End Sub
    Private Sub bbiMailText_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMailText.ItemClick
        bbiMailMessage.Down = False
        bbiMailTemplate.Down = False
        bbiMailText.Down = True
        LoadMailForm()
    End Sub
    Private Sub bbiSMTPSettings_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSMTPSettings.ItemClick
        Dim frmSettings As New frmSettings
        frmSettings.xtcMain.SelectedTabPage = frmSettings.tabSMTP
        frmSettings.ShowDialog()
    End Sub
    Private Sub bbiFTPSettings_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiFTPSettings.ItemClick
        Dim frmSettings As New frmSettings
        frmSettings.xtcMain.SelectedTabPage = frmSettings.tabFTP
        frmSettings.ShowDialog()
    End Sub
#End Region
#Region "Quotations"
    Private Sub LoadAllQuoteColumns()
        NavQuotePackage.Expanded = True
        LoadQuotePackagesColumns()
        LoadQuoteOptionsColumns()
        LoadQuotePostsColumns()
        LoadQuoteSupportColumns()
        LoadQuoteAllColumns()
        LoadQuoteMiscColumns()
        LoadCompanyInfo()
        ReadSigmatekPricelist()
    End Sub
    Private Sub LoadCompanyInfo()
        Dim i As Integer = 0
        ricCompanyName.Items.Clear()
        For i = 0 To GblDirList.Count - 1
            ricCompanyName.Items.Add(GblDirList(i))
        Next
        ricDealerName.Items.Clear()
        For i = 0 To GblDirList.Count - 1
            ricDealerName.Items.Add(GblDirList(i))
        Next
        ricDiscountType.Items.Clear()
        ricDiscountType.Items.Add("特別値引")
        ricDiscountType.Items.Add("出精値引")
        ricDiscountType.Items.Add("代理店値引")
    End Sub
    Private Sub ricCompanyName_SelectedValueChanged(sender As Object, e As EventArgs) Handles ricCompanyName.SelectedValueChanged
        Dim edit As ComboBoxEdit = DirectCast(sender, ComboBoxEdit)
        Dim editValue As Object = edit.EditValue
        If IsSQL = False Then Exit Sub
        Try

            Dim db_reader As OleDbDataReader
            Dim connUsers As System.Data.OleDb.OleDbConnection
            Dim Company As String = ""
            Dim cmd As New OleDb.OleDbCommand
            Dim Query As String = ""

            connUsers = New System.Data.OleDb.OleDbConnection
            connUsers.ConnectionString = SSDBString
            connUsers.Open()
            cmd.Connection = connUsers
            Query = "SELECT * FROM tbl_SNContacts WHERE CompanyLink='" & editValue & "' "
            cmd.CommandText = Query
            db_reader = cmd.ExecuteReader(CommandBehavior.Default)
            Do While db_reader.Read
                Company = db_reader.Item("Company").ToString
            Loop
            cmd = Nothing
            connUsers.Close()
            If Company = "" Then
                Company = Microsoft.VisualBasic.Right(editValue, Len(editValue) - 2)
            End If
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A5").Value = Company
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C17").Value = Company
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub ricDealerName_SelectedValueChanged(sender As Object, e As EventArgs) Handles ricDealerName.SelectedValueChanged
        Dim edit As ComboBoxEdit = DirectCast(sender, ComboBoxEdit)
        Dim editValue As Object = edit.EditValue
        If IsSQL = False Then Exit Sub
        Try
            Dim db_reader As OleDbDataReader
            Dim connUsers As System.Data.OleDb.OleDbConnection
            Dim Company As String = ""
            Dim cmd As New OleDb.OleDbCommand
            Dim Query As String = ""

            connUsers = New System.Data.OleDb.OleDbConnection
            connUsers.ConnectionString = SSDBString
            connUsers.Open()
            cmd.Connection = connUsers
            Query = "SELECT * FROM tbl_SNContacts WHERE CompanyLink='" & editValue & "' "
            cmd.CommandText = Query
            db_reader = cmd.ExecuteReader(CommandBehavior.Default)
            Do While db_reader.Read
                Company = db_reader.Item("Company").ToString
            Loop
            cmd = Nothing
            connUsers.Close()
            If Company = "" Then
                Company = Microsoft.VisualBasic.Right(editValue, Len(editValue) - 2)
            End If
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C17").Value = Company
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Sub ricDiscoutType_SelectedValueChanged(sender As Object, e As EventArgs) Handles ricDiscountType.SelectedValueChanged
        Dim edit As ComboBoxEdit = DirectCast(sender, ComboBoxEdit)
        Dim editValue As String = edit.EditValue.ToString
        If bbiCreateQuote.Down = True Then
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F38").Value = editValue
        ElseIf bbiMaintInvoice.Down = True Then
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("F53").Value = editValue
        ElseIf bbiMaintQuote.Down = True Then
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("F45").Value = editValue
        End If
    End Sub
    Private Sub LoadExHankoColumns()
        Dim i As Integer = 0
        data17 = New DataTable("gvExMonth")
        data17.Clear()
        data17.BeginInit()
        AddColumn(data17, "Image", GetType(Image))
        data17.EndInit()

        gcExMonth.DataSource = data17
        gcExMonth.DefaultView.PopulateColumns()
        gvExMonth.Columns.ColumnByFieldName("Image").Caption = "判"
        gvExMonth.Columns(0).OptionsColumn.AllowEdit = False
        gvExMonth.Columns("Image").ColumnEdit = riHanko
        gvExMonth.RowHeight = 50
        LoadExHankoData()
    End Sub
    Private Sub LoadExHankoData()
        Dim Hanko As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\data01_85.png"
        Dim img As Bitmap = CType(Image.FromFile(Hanko, True), Bitmap)
        data17.Rows.Add(img)
        Hanko = SigmanestDataPath & "Applications\SigmaAPP\Quotations\data02_85.png"
        img = CType(Image.FromFile(Hanko, True), Bitmap)
        data17.Rows.Add(img)
        Hanko = SigmanestDataPath & "Applications\SigmaAPP\Quotations\data03_85.png"
        img = CType(Image.FromFile(Hanko, True), Bitmap)
        data17.Rows.Add(img)
        Hanko = SigmanestDataPath & "Applications\SigmaAPP\Quotations\data04_85.png"
        img = CType(Image.FromFile(Hanko, True), Bitmap)
        data17.Rows.Add(img)
    End Sub
    Private Sub LoadQuotePackagesColumns()
        Dim i As Integer = 0
        data20 = New DataTable("gvQPackage")
        data20.Clear()
        data20.BeginInit()
        AddColumn(data20, "Module", System.Type.GetType("System.String"))
        AddColumn(data20, "Detail", System.Type.GetType("System.String"))
        AddColumn(data20, "Price", System.Type.GetType("System.Double"))
        AddColumn(data20, "Quantity", System.Type.GetType("System.Int32"))
        AddColumn(data20, "PriceMulti", System.Type.GetType("System.Double"))
        data20.EndInit()

        gcQPackage.DataSource = data20
        gcQPackage.DefaultView.PopulateColumns()
        gvQPackage.Columns.ColumnByFieldName("Module").Caption = "モジュール"
        gvQPackage.Columns.ColumnByFieldName("Detail").Caption = "詳細"
        gvQPackage.Columns.ColumnByFieldName("Price").Caption = "価格"
        gvQPackage.Columns.ColumnByFieldName("Quantity").Caption = "個数"
        gvQPackage.Columns(0).Width = 75
        gvQPackage.Columns(1).Width = 200
        gvQPackage.Columns(2).Width = 75
        gvQPackage.Columns(3).Width = 75
        gvQPackage.Columns(4).Visible = False
        gvQPackage.Columns(0).OptionsColumn.AllowEdit = False
        gvQPackage.Columns(1).OptionsColumn.AllowEdit = False
        gvQPackage.Columns(2).OptionsColumn.AllowEdit = True
        gvQPackage.Columns(3).OptionsColumn.AllowEdit = True

    End Sub
    Private Sub LoadQuoteOptionsColumns()
        Dim i As Integer = 0
        data21 = New DataTable("gvQOptions")
        data21.Clear()
        data21.BeginInit()
        AddColumn(data21, "Module", System.Type.GetType("System.String"))
        AddColumn(data21, "Detail", System.Type.GetType("System.String"))
        AddColumn(data21, "Price", System.Type.GetType("System.Double"))
        AddColumn(data21, "Quantity", System.Type.GetType("System.Int32"))
        AddColumn(data21, "PriceMulti", System.Type.GetType("System.Double"))
        data21.EndInit()

        gcQOption.DataSource = data21
        gcQOption.DefaultView.PopulateColumns()
        gvQOption.Columns.ColumnByFieldName("Module").Caption = "モジュール"
        gvQOption.Columns.ColumnByFieldName("Detail").Caption = "詳細"
        gvQOption.Columns.ColumnByFieldName("Price").Caption = "価格"
        gvQOption.Columns.ColumnByFieldName("Quantity").Caption = "個数"
        gvQOption.Columns(0).Width = 75
        gvQOption.Columns(1).Width = 200
        gvQOption.Columns(2).Width = 75
        gvQOption.Columns(3).Width = 75
        gvQOption.Columns(4).Visible = False
        gvQOption.Columns(0).OptionsColumn.AllowEdit = False
        gvQOption.Columns(1).OptionsColumn.AllowEdit = False
        gvQOption.Columns(2).OptionsColumn.AllowEdit = True
        gvQOption.Columns(3).OptionsColumn.AllowEdit = True
    End Sub
    Private Sub LoadQuotePostsColumns()
        Dim i As Integer = 0
        data22 = New DataTable("gvQPosts")
        data22.Clear()
        data22.BeginInit()
        AddColumn(data22, "Module", System.Type.GetType("System.String"))
        AddColumn(data22, "Detail", System.Type.GetType("System.String"))
        AddColumn(data22, "Price", System.Type.GetType("System.Double"))
        AddColumn(data22, "Quantity", System.Type.GetType("System.Int32"))
        AddColumn(data22, "PriceMulti", System.Type.GetType("System.Double"))
        data22.EndInit()

        gcQPosts.DataSource = data22
        gcQPosts.DefaultView.PopulateColumns()
        gvQPosts.Columns.ColumnByFieldName("Module").Caption = "モジュール"
        gvQPosts.Columns.ColumnByFieldName("Detail").Caption = "詳細"
        gvQPosts.Columns.ColumnByFieldName("Price").Caption = "価格"
        gvQPosts.Columns.ColumnByFieldName("Quantity").Caption = "個数"
        gvQPosts.Columns(0).Width = 75
        gvQPosts.Columns(1).Width = 200
        gvQPosts.Columns(2).Width = 75
        gvQPosts.Columns(3).Width = 75
        gvQPosts.Columns(4).Visible = False
        gvQPosts.Columns(0).OptionsColumn.AllowEdit = False
        gvQPosts.Columns(1).OptionsColumn.AllowEdit = False
        gvQPosts.Columns(2).OptionsColumn.AllowEdit = True
        gvQPosts.Columns(3).OptionsColumn.AllowEdit = True
    End Sub
    Private Sub LoadQuoteSupportColumns()
        Dim i As Integer = 0
        data23 = New DataTable("gvQSupport")
        data23.Clear()
        data23.BeginInit()
        AddColumn(data23, "Module", System.Type.GetType("System.String"))
        AddColumn(data23, "Detail", System.Type.GetType("System.String"))
        AddColumn(data23, "Price", System.Type.GetType("System.Double"))
        AddColumn(data23, "Quantity", System.Type.GetType("System.Int32"))
        AddColumn(data23, "PriceMulti", System.Type.GetType("System.Double"))
        data23.EndInit()

        gcQSupport.DataSource = data23
        gcQSupport.DefaultView.PopulateColumns()
        gvQSupport.Columns.ColumnByFieldName("Module").Caption = "モジュール"
        gvQSupport.Columns.ColumnByFieldName("Detail").Caption = "詳細"
        gvQSupport.Columns.ColumnByFieldName("Price").Caption = "価格"
        gvQSupport.Columns.ColumnByFieldName("Quantity").Caption = "個数"
        gvQSupport.Columns(0).Width = 75
        gvQSupport.Columns(1).Width = 200
        gvQSupport.Columns(2).Width = 75
        gvQSupport.Columns(3).Width = 75
        gvQSupport.Columns(4).Visible = False
        gvQSupport.Columns(0).OptionsColumn.AllowEdit = False
        gvQSupport.Columns(1).OptionsColumn.AllowEdit = False
        gvQSupport.Columns(2).OptionsColumn.AllowEdit = True
        gvQSupport.Columns(3).OptionsColumn.AllowEdit = True
    End Sub
    Private Sub LoadQuoteAllColumns()
        Dim i As Integer = 0
        data24 = New DataTable("gvQAll")
        data24.Clear()
        data24.BeginInit()
        AddColumn(data24, "Module", System.Type.GetType("System.String"))
        AddColumn(data24, "Detail", System.Type.GetType("System.String"))
        AddColumn(data24, "Price", System.Type.GetType("System.Double"))
        AddColumn(data24, "Quantity", System.Type.GetType("System.Int32"))
        AddColumn(data24, "PriceMulti", System.Type.GetType("System.Double"))
        data24.EndInit()

        gcQAll.DataSource = data24
        gcQAll.DefaultView.PopulateColumns()
        gvQAll.Columns.ColumnByFieldName("Module").Caption = "モジュール"
        gvQAll.Columns.ColumnByFieldName("Detail").Caption = "詳細"
        gvQAll.Columns.ColumnByFieldName("Price").Caption = "価格"
        gvQAll.Columns.ColumnByFieldName("Quantity").Caption = "個数"
        gvQAll.Columns(0).Width = 75
        gvQAll.Columns(1).Width = 200
        gvQAll.Columns(2).Width = 75
        gvQAll.Columns(3).Width = 75
        gvQAll.Columns(4).Visible = False
        gvQAll.Columns(0).OptionsColumn.AllowEdit = False
        gvQAll.Columns(1).OptionsColumn.AllowEdit = False
        gvQAll.Columns(2).OptionsColumn.AllowEdit = True
        gvQAll.Columns(3).OptionsColumn.AllowEdit = True
    End Sub
    Private Sub LoadQuoteMiscColumns()
        Dim i As Integer = 0
        data25 = New DataTable("gvQMisc")
        data25.Clear()
        data25.BeginInit()
        AddColumn(data25, "Module", System.Type.GetType("System.String"))
        AddColumn(data25, "Detail", System.Type.GetType("System.String"))
        AddColumn(data25, "Price", System.Type.GetType("System.Double"))
        data25.EndInit()

        gcQMisc.DataSource = data25
        gcQMisc.DefaultView.PopulateColumns()
        gvQMisc.Columns.ColumnByFieldName("Module").Caption = "モジュール"
        gvQMisc.Columns.ColumnByFieldName("Detail").Caption = "詳細"
        gvQMisc.Columns.ColumnByFieldName("Price").Caption = "値引率"
        gvQMisc.Columns(0).Width = 75
        gvQMisc.Columns(1).Width = 200
        gvQMisc.Columns(2).Width = 75

        gvQMisc.Columns(0).OptionsColumn.AllowEdit = False
        gvQMisc.Columns(1).OptionsColumn.AllowEdit = True
        gvQMisc.Columns(2).OptionsColumn.AllowEdit = True

    End Sub
    Dim USPriceListMod As New ArrayList
    Dim USPriceListDescr As New ArrayList
    Dim USPriceListPrice As New ArrayList
    Dim USPriceListMulti As New ArrayList
    Dim ModuleList As New ArrayList
    Private Sub ReadSigmatekPricelist()

        USPriceListMod.Clear()
        USPriceListDescr.Clear()
        USPriceListPrice.Clear()
        USPriceListMulti.Clear()
        Dim ModuleName As String = ""
        Dim ModuleDescr As String = ""
        Dim ListPrice As String = ""
        Dim ListPriceDbl As Double = 0
        Dim ListPriceMulti As String = ""
        Dim ListPriceMultiDbl As Double = 0
        Dim PriceYen As Double = 0
        Dim PriceYenMulti As Double = 0
        Dim PListPath As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\PriceListDownload.csv"
        Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(PListPath, System.Text.Encoding.GetEncoding(GblEncoding))
        Dim CurrentRecord As String() ' this array will hold each line of data
        afile.TextFieldType = FileIO.FieldType.Delimited
        afile.Delimiters = New String() {","}
        afile.HasFieldsEnclosedInQuotes = True
        ' parse the actual file
        data24.Clear()
        Do While Not afile.EndOfData
            Try
                CurrentRecord = afile.ReadFields
                ModuleName = CurrentRecord(0)
                ModuleDescr = CurrentRecord(1)
                ListPrice = CurrentRecord(2)
                If IsNumeric(ListPrice) Then
                    ListPriceDbl = CDbl(ListPrice)
                Else
                    ListPriceDbl = 0
                End If
                ListPriceMulti = CurrentRecord(3)
                If IsNumeric(ListPriceMulti) Then
                    ListPriceMultiDbl = CDbl(ListPriceMulti)
                Else
                    ListPriceMultiDbl = 0
                End If
                PriceYen = CInt((ListPriceDbl * GblExchangeRate) / 1000) * 1000
                PriceYenMulti = CInt((ListPriceMultiDbl * GblExchangeRate) / 1000) * 1000
                USPriceListMod.Add(ModuleName)
                USPriceListDescr.Add(ModuleDescr)
                USPriceListPrice.Add(ListPriceDbl)
                USPriceListMulti.Add(ListPriceMultiDbl)
                If ListPriceDbl > 0 Then
                    data24.Rows.Add(ModuleName, ModuleDescr, PriceYen, 0, PriceYenMulti)
                End If

            Catch ex As FileIO.MalformedLineException
                afile.Close()
                Stop
            End Try
        Loop
        afile.Close()
    End Sub
    Private Function GetQuoteMatchIndex(ByVal QModule As String) As Integer
        Dim i As Integer = 0
        Dim MatchInd As Integer = 0
        For i = 0 To USPriceListMod.Count - 1
            If QModule = USPriceListMod(i) Then
                MatchInd = i
                Exit For
            End If
        Next
        GetQuoteMatchIndex = MatchInd
    End Function
    Private Sub LoadQuotePackagesData()
        Dim PListPath As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\PriceListJP.csv"
        Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(PListPath, System.Text.Encoding.GetEncoding(GblEncoding))
        Dim CurrentRecord As String() ' this array will hold each line of data
        Dim MatchInd As Integer = 0
        Dim ModuleName As String = ""
        Dim ModuleDescr As String = ""
        Dim ListPrice As String = ""
        Dim ListPriceDbl As Double = 0
        Dim ListPriceMulti As String = ""
        Dim ListPriceMultiDbl As Double = 0
        Dim PriceYen As Double = 0
        Dim PriceYenMulti As Double = 0
        afile.TextFieldType = FileIO.FieldType.Delimited
        afile.Delimiters = New String() {","}
        afile.HasFieldsEnclosedInQuotes = True
        ' parse the actual file
        data20.Clear()
        data21.Clear()
        data22.Clear()
        data23.Clear()
        data25.Clear()
        Do While Not afile.EndOfData
            Try
                CurrentRecord = afile.ReadFields
                If CurrentRecord.Count > 1 Then
                    ModuleName = CurrentRecord(1)
                    MatchInd = GetQuoteMatchIndex(ModuleName)
                    ModuleDescr = CurrentRecord(2)
                    If CurrentRecord.Count > 3 Then
                        ListPrice = CurrentRecord(3)
                        If IsNumeric(ListPrice) Then
                            ListPriceDbl = CDbl(ListPrice)
                        Else
                            ListPriceDbl = 0
                        End If
                        PriceYen = ListPriceDbl
                        PriceYenMulti = ListPriceDbl
                    Else
                        ListPrice = USPriceListPrice(MatchInd)
                        If IsNumeric(ListPrice) Then
                            ListPriceDbl = CDbl(ListPrice)
                        Else
                            ListPriceDbl = 0
                        End If
                        ListPriceMulti = USPriceListMulti(MatchInd)
                        If IsNumeric(ListPriceMulti) Then
                            ListPriceMultiDbl = CDbl(ListPriceMulti)
                        Else
                            ListPriceMultiDbl = 0
                        End If
                        PriceYen = CInt((ListPriceDbl * GblExchangeRate) / 1000) * 1000
                        PriceYenMulti = CInt((ListPriceMultiDbl * GblExchangeRate) / 1000) * 1000
                    End If


                    Select Case CurrentRecord(0)
                        Case "1"
                            data20.Rows.Add(ModuleName, ModuleDescr, PriceYen, 0, PriceYenMulti)
                        Case "2"
                            data21.Rows.Add(ModuleName, ModuleDescr, PriceYen, 0, PriceYenMulti)
                        Case "3"
                            data22.Rows.Add(ModuleName, ModuleDescr, PriceYen, 0, PriceYenMulti)
                        Case "4"
                            data23.Rows.Add(ModuleName, ModuleDescr, PriceYen, 0, PriceYenMulti)
                    End Select
                End If
            Catch ex As FileIO.MalformedLineException
                afile.Close()
                Stop
            End Try
        Loop
        data25.Rows.Add("顧客名:", "", 0)
        data25.Rows.Add("引き合い先:", "", 0)
        data25.Rows.Add("D100", "出精値引", 0)
        afile.Close()
    End Sub
    Private Sub SetQ(ByVal Q As Integer)
        If Q > 0 Then
            Select Case QMode
                Case "Package"
                    gvQPackage.SetRowCellValue(gvQPackage.GetSelectedRows(0), "Quantity", Q)
                Case "Option"
                    gvQOption.SetRowCellValue(gvQOption.GetSelectedRows(0), "Quantity", Q)
                Case "Posts"
                    gvQPosts.SetRowCellValue(gvQPosts.GetSelectedRows(0), "Quantity", Q)
                Case "Support"
                    gvQSupport.SetRowCellValue(gvQSupport.GetSelectedRows(0), "Quantity", Q)
                Case "All"
                    gvQAll.SetRowCellValue(gvQAll.GetSelectedRows(0), "Quantity", Q)
            End Select
        End If
        If Q = 0 Then
            Select Case QMode
                Case "Package"
                    If gvQPackage.GetRowCellValue(gvQPackage.GetSelectedRows(0), "Quantity") = 0 Then
                        gvQPackage.SetRowCellValue(gvQPackage.GetSelectedRows(0), "Quantity", 1)
                    End If
                Case "Option"
                    If gvQOption.GetRowCellValue(gvQOption.GetSelectedRows(0), "Quantity") = 0 Then
                        gvQOption.SetRowCellValue(gvQOption.GetSelectedRows(0), "Quantity", 1)
                    End If
                Case "Posts"
                    If gvQPosts.GetRowCellValue(gvQPosts.GetSelectedRows(0), "Quantity") = 0 Then
                        gvQPosts.SetRowCellValue(gvQPosts.GetSelectedRows(0), "Quantity", 1)
                    End If
                Case "Support"
                    If gvQSupport.GetRowCellValue(gvQSupport.GetSelectedRows(0), "Quantity") = 0 Then
                        gvQSupport.SetRowCellValue(gvQSupport.GetSelectedRows(0), "Quantity", 1)
                    End If
                Case "All"
                    If gvQAll.GetRowCellValue(gvQAll.GetSelectedRows(0), "Quantity") = 0 Then
                        gvQAll.SetRowCellValue(gvQAll.GetSelectedRows(0), "Quantity", 1)
                    End If
            End Select
        ElseIf Q = -1 Then
            Select Case QMode
                Case "Package"
                    gvQPackage.SetRowCellValue(gvQPackage.GetSelectedRows(0), "Quantity", 0)
                Case "Option"
                    gvQOption.SetRowCellValue(gvQOption.GetSelectedRows(0), "Quantity", 0)
                Case "Posts"
                    gvQPosts.SetRowCellValue(gvQPosts.GetSelectedRows(0), "Quantity", 0)
                Case "Support"
                    gvQSupport.SetRowCellValue(gvQSupport.GetSelectedRows(0), "Quantity", 0)
                Case "All"
                    gvQAll.SetRowCellValue(gvQAll.GetSelectedRows(0), "Quantity", 0)
            End Select
        End If
    End Sub
    Private Sub ttsQ1_Click(sender As Object, e As EventArgs) Handles ttsQ1.Click
        SetQ(1)
        LoadQuotation()
    End Sub
    Private Sub ttsQ2_Click(sender As Object, e As EventArgs) Handles ttsQ2.Click
        SetQ(2)
        LoadQuotation()
    End Sub
    Private Sub ttsQ3_Click(sender As Object, e As EventArgs) Handles ttsQ3.Click
        SetQ(3)
        LoadQuotation()
    End Sub
    Private Sub ttsQ4_Click(sender As Object, e As EventArgs) Handles ttsQ4.Click
        SetQ(4)
        LoadQuotation()
    End Sub
    Private Sub ttsQ5_Click(sender As Object, e As EventArgs) Handles ttsQ5.Click
        SetQ(5)
        LoadQuotation()
    End Sub
    Private Sub ttsQAdd_DoubleClick(sender As Object, e As EventArgs) Handles ttsQAdd.Click
        SetQ(0)
        LoadQuotation()
    End Sub
    Private Sub gcQPackage_DoubleClick(sender As Object, e As EventArgs) Handles gcQPackage.DoubleClick
        SetQ(0)
        LoadQuotation()
    End Sub
    Private Sub gcQOption_DoubleClick(sender As Object, e As EventArgs) Handles gcQOption.DoubleClick
        SetQ(0)
        LoadQuotation()
    End Sub
    Private Sub gcQPPosts_DoubleClick(sender As Object, e As EventArgs) Handles gcQPosts.DoubleClick
        SetQ(0)
        LoadQuotation()
    End Sub
    Private Sub gcQSupport_DoubleClick(sender As Object, e As EventArgs) Handles gcQSupport.DoubleClick
        SetQ(0)
        LoadQuotation()
    End Sub
    Private Sub gcQAll_DoubleClick(sender As Object, e As EventArgs) Handles gcQAll.DoubleClick
        SetQ(0)
        LoadQuotation()
    End Sub
    Private Sub ttsCartClear_Click(sender As Object, e As EventArgs) Handles ttsCartClear.Click
        SetQ(-1)
        LoadQuotation()
    End Sub
    Private Sub gcQPackage_Click(sender As Object, e As EventArgs) Handles gcQPackage.Click
        QMode = "Package"
    End Sub
    Private Sub gcQOption_Click(sender As Object, e As EventArgs) Handles gcQOption.Click
        QMode = "Option"
    End Sub
    Private Sub gcQPPosts_Click(sender As Object, e As EventArgs) Handles gcQPosts.Click
        QMode = "Posts"
    End Sub
    Private Sub gcQSupport_Click(sender As Object, e As EventArgs) Handles gcQSupport.Click
        QMode = "Support"
    End Sub
    Private Sub gcQAll_Click(sender As Object, e As EventArgs) Handles gcQAll.Click
        QMode = "All"
    End Sub
    Private Sub ClearAllQty()
        For i = 0 To gvQPackage.RowCount - 1
            gvQPackage.SetRowCellValue(i, "Quantity", 0)
        Next
        For i = 0 To gvQOption.RowCount - 1
            gvQOption.SetRowCellValue(i, "Quantity", 0)
        Next
        For i = 0 To gvQPosts.RowCount - 1
            gvQPosts.SetRowCellValue(i, "Quantity", 0)
        Next
        For i = 0 To gvQAll.RowCount - 1
            gvQAll.SetRowCellValue(i, "Quantity", 0)
        Next
        For i = 0 To gvQSupport.RowCount - 1
            gvQSupport.SetRowCellValue(i, "Quantity", 0)
        Next
        For i = 0 To gvQMisc.RowCount - 1
            gvQMisc.SetRowCellValue(i, "Price", 0)
        Next
    End Sub
    Private Sub LoadModList()
        Dim ModuleName As String = ""
        ModuleList.Clear()
        For i = 26 To 36
            ModuleName = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & i).Value.ToString
            ModuleList.Add(ModuleName)
        Next
    End Sub
    Private Sub LoadQuotation()
        Dim DateField As String = ""
        Dim StartIndex As Integer = 0
        Dim StartIndex2 As Integer = 0
        Dim QModule As String = ""
        Dim QDetail As String = ""
        Dim QPrice As Double = 0
        Dim QPriceMulti As Double = 0
        Dim QQuantity As Integer = 0
        Dim QMQuantity As Integer = 0
        Dim ItemCnt As Integer = 0
        'For i = 26 To 39
        '    DateField = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & i).Value.ToString
        '    If DateField = "" Then
        '        StartIndex = i
        '        Exit For
        '    End If
        'Next
        Dim PListPath As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\見積もりベース.xls"
        xlsExpenses.LoadDocument(PListPath)
        xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G5").Value = Date.Today
        ModuleList.Clear()
        StartIndex = 26
        StartIndex2 = 45
        QQuantity = 0
        QModule = ""
        QDetail = ""
        QPrice = 0
        QPriceMulti = 0
        ItemCnt = 0

        For i = 0 To gvQPackage.RowCount - 1
            QQuantity = gvQPackage.GetRowCellValue(i, "Quantity")
            ItemCnt = ItemCnt + QQuantity
            If QQuantity > 0 Then
                QModule = gvQPackage.GetRowCellValue(i, "Module")
                ModuleList.Add(QModule)
                QDetail = gvQPackage.GetRowCellValue(i, "Detail")
                QPrice = gvQPackage.GetRowCellValue(i, "Price")
                QPriceMulti = gvQPackage.GetRowCellValue(i, "PriceMulti")
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = QModule
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = QDetail
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & QPrice & ")"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & QPrice & ")"
                StartIndex += 1
            End If
            If QQuantity > 1 Then
                QMQuantity = QQuantity - 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = QModule
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = QDetail & " (台数値引き）"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = QQuantity - 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & QPriceMulti & ")"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & QPriceMulti & "*" & QMQuantity & ")"
                StartIndex += 1
            End If
        Next
        QQuantity = 0
        QModule = ""
        QDetail = ""
        QPrice = 0
        QPriceMulti = 0
        For i = 0 To gvQOption.RowCount - 1
            QQuantity = gvQOption.GetRowCellValue(i, "Quantity")
            ItemCnt = ItemCnt + QQuantity
            If QQuantity > 0 Then
                QModule = gvQOption.GetRowCellValue(i, "Module")
                ModuleList.Add(QModule)
                QDetail = gvQOption.GetRowCellValue(i, "Detail")
                QPrice = gvQOption.GetRowCellValue(i, "Price")
                QPriceMulti = gvQOption.GetRowCellValue(i, "PriceMulti")
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = QModule
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = QDetail
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & QPrice & ")"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & QPrice & "*" & QQuantity & ")"
                StartIndex += 1
            End If
            If QQuantity > 1 Then
                QMQuantity = QQuantity - 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = QModule
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = QDetail & " (台数値引き）"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = QQuantity - 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & QPriceMulti & ")"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & QPriceMulti & "*" & QMQuantity & ")"
                StartIndex += 1
            End If
        Next
        QQuantity = 0
        QModule = ""
        QDetail = ""
        QPrice = 0
        QPriceMulti = 0
        For i = 0 To gvQPosts.RowCount - 1
            QQuantity = gvQPosts.GetRowCellValue(i, "Quantity")
            ItemCnt = ItemCnt + QQuantity
            If QQuantity > 0 Then
                QModule = gvQPosts.GetRowCellValue(i, "Module")
                ModuleList.Add(QModule)
                QDetail = gvQPosts.GetRowCellValue(i, "Detail")
                QPrice = gvQPosts.GetRowCellValue(i, "Price")
                QPriceMulti = gvQPosts.GetRowCellValue(i, "PriceMulti")
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = QModule
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = QDetail
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = QQuantity
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & QPrice & ")"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & QPrice & "*" & QQuantity & ")"
                StartIndex += 1
            End If
            'If QQuantity > 1 Then
            '    QMQuantity = QQuantity - 1
            '    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = QModule
            '    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = QDetail & " (台数値引き）"
            '    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = QQuantity - 1
            '    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & QPriceMulti & ")"
            '    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & QPriceMulti & "*" & QMQuantity & ")"
            '    StartIndex += 1
            'End If
        Next
        QQuantity = 0
        QModule = ""
        QDetail = ""
        QPrice = 0
        QPriceMulti = 0
        For i = 0 To gvQAll.RowCount - 1
            QQuantity = gvQAll.GetRowCellValue(i, "Quantity")
            ItemCnt = ItemCnt + QQuantity
            If QQuantity > 0 Then
                QModule = gvQAll.GetRowCellValue(i, "Module")
                ModuleList.Add(QModule)
                QDetail = gvQAll.GetRowCellValue(i, "Detail")
                QPrice = gvQAll.GetRowCellValue(i, "Price")
                QPriceMulti = gvQAll.GetRowCellValue(i, "PriceMulti")
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = QModule
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = QDetail
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & QPrice & ")"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & QPrice & "*" & QQuantity & ")"
                StartIndex += 1
            End If
            If QQuantity > 1 Then
                QMQuantity = QQuantity - 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = QModule
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = QDetail
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = QQuantity - 1
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & QPriceMulti & ")"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & QPriceMulti & "*" & QMQuantity & ")"
                StartIndex += 1
            End If
        Next
        If ItemCnt > 0 Then
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex).Value = "MXU201"
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex).Value = "SigmaNest保守費用 (１２％)"
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex).Value = 1
            Dim MaintAmt As Double = 0
            MaintAmt = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G24").Value.ToString)
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex).Formula = "=(" & MaintAmt & " * 0.12)"
            xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex).Formula = "=(" & MaintAmt & " * 0.12)"
            StartIndex += 1
        End If


        QQuantity = 0
        QModule = ""
        QDetail = ""
        QPrice = 0
        QPriceMulti = 0
        For i = 0 To gvQSupport.RowCount - 1
            QQuantity = gvQSupport.GetRowCellValue(i, "Quantity")
            If QQuantity > 0 Then
                QModule = gvQSupport.GetRowCellValue(i, "Module")
                ModuleList.Add(QModule)
                QDetail = gvQSupport.GetRowCellValue(i, "Detail")
                QPrice = gvQSupport.GetRowCellValue(i, "Price")
                QPriceMulti = gvQSupport.GetRowCellValue(i, "PriceMulti")
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & StartIndex2).Value = QModule
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & StartIndex2).Value = QDetail
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & StartIndex2).Value = QQuantity
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & StartIndex2).Formula = "=(" & QPrice & ")"
                xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & StartIndex2).Formula = "=(" & QPrice & "*" & QQuantity & ")"
                StartIndex2 += 1
            End If
        Next
        QQuantity = 0
        QModule = ""
        QDetail = ""
        QPrice = 0
        QPriceMulti = 0
        For i = 0 To gvQMisc.RowCount - 1
            QModule = gvQMisc.GetRowCellValue(i, "Module")
            QDetail = gvQMisc.GetRowCellValue(i, "Detail")
            QPrice = gvQMisc.GetRowCellValue(i, "Price")
            If QModule = "D100" Then
                If bbiCreateQuote.Down = True Then
                    xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G38").Formula = "=(G37*" & QPrice & ")"
                ElseIf bbiMaintInvoice.Down = True Then
                    xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G53").Formula = "=(G52*" & QPrice & ")"
                ElseIf bbiMaintQuote.Down = True Then
                    xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G45").Formula = "=(G44*" & QPrice & ")"
                End If

            End If

            StartIndex += 1
        Next
    End Sub
    Dim QMode As String = ""
    Private Sub gvQPackage_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvQPackage.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            QMode = "Package"
            ttsQQty.Visible = True
            Me.cmsQuote.Show(gcQPackage, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvQOption_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvQOption.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            QMode = "Option"
            ttsQQty.Visible = True
            Me.cmsQuote.Show(gcQOption, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvQPosts_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvQPosts.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            QMode = "Posts"
            ttsQQty.Visible = True
            Me.cmsQuote.Show(gcQPosts, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvQSupport_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvQSupport.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            QMode = "Support"
            ttsQQty.Visible = True
            Me.cmsQuote.Show(gcQSupport, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvQAll_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvQAll.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            QMode = "All"
            ttsQQty.Visible = True
            Me.cmsQuote.Show(gcQAll, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gvQMisc_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gvQMisc.MouseUp
        If e.Button = MouseButtons.Right And e.Y > 30 Then
            QMode = "Misc"
            ttsQQty.Visible = False
            Me.cmsQuote.Show(gcQMisc, New Point(e.X, e.Y))
        End If
    End Sub
    Private Sub gcExMonth_DoubleClick(sender As Object, e As EventArgs) Handles gcExMonth.DoubleClick
        Dim Hanko As String = ""
        If bbiQuotation.Down = True Then

            If gvExMonth.SelectedRowsCount > 0 Then
                Select Case gvExMonth.GetSelectedRows(0)
                    Case 0
                        Hanko = SigmanestDataPath & "Applications\SigmaAPP\Quotations\data01_85.png"
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Pictures.AddPicture(Hanko, xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G6"))
                    Case 1
                        Hanko = SigmanestDataPath & "Applications\SigmaAPP\Quotations\data02_85.png"
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Pictures.AddPicture(Hanko, xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F18"))
                    Case 2
                        Hanko = SigmanestDataPath & "Applications\SigmaAPP\Quotations\data03_85.png"
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Pictures.AddPicture(Hanko, xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F18"))
                    Case 3
                        Hanko = SigmanestDataPath & "Applications\SigmaAPP\Quotations\data04_85.png"
                        xlsExpenses.Document.Worksheets.ActiveWorksheet.Pictures.AddPicture(Hanko, xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F18"))
                End Select
            End If
        End If
    End Sub
    Private Sub gvQMisc_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gvQMisc.CustomRowCellEdit
        If e.Column.FieldName = "Detail" Then
            Dim gv As GridView = sender
            If e.RowHandle = 0 Then
                e.RepositoryItem = ricCompanyName
            ElseIf e.RowHandle = 1 Then
                e.RepositoryItem = ricDealerName
            ElseIf e.RowHandle = 2 Then
                e.RepositoryItem = ricDiscountType
            End If
        End If
    End Sub
    Private Sub bbiQuoteDoc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiQuoteDoc.ItemClick
        splQuoteDoc.Panel2Collapsed = True
        xtcTools.SelectedTabPage = tabExDocument
        Dim PListPath As String = ""
        PListPath = SigmanestDataPath & "Applications\SigmaAPP\Quotations\footer.doc"
        If File.Exists(PListPath) Then
            recDoc.LoadDocument(PListPath)
        End If
        PListPath = SigmanestDataPath & "Applications\SigmaAPP\Quotations\cover.doc"
        If File.Exists(PListPath) Then
            recDoc2.LoadDocument(PListPath)
            recDoc2.SelectAll()
            recDoc2.Copy()
            recDoc.Paste()
        End If
        PListPath = SigmanestDataPath & "Applications\SigmaAPP\Quotations\description.doc"
        If File.Exists(PListPath) Then
            recDoc2.LoadDocument(PListPath)
            recDoc2.SelectAll()
            recDoc2.Copy()
            recDoc.Paste()
        End If
        Dim i As Integer = 0
        Dim ModName As String = ""
        For i = 0 To ModuleList.Count - 1
            ModName = ModuleList(i)
            PListPath = SigmanestDataPath & "Applications\SigmaAPP\Quotations\" & ModName & ".doc"
            If File.Exists(PListPath) = True Then
                recDoc2.LoadDocument(PListPath)
                recDoc2.SelectAll()
                recDoc2.Copy()
                recDoc.Paste()
            End If
        Next
    End Sub
    Private Sub LoadInvoice()
        Dim DateField As String = ""
        Dim StartIndex As Integer = 0
        Dim EndIndex As Integer = 0
        Dim StartIndex2 As Integer = 0
        Dim EndIndex2 As Integer = 0
        Dim SStartIndex As Integer = 0
        Dim SEndIndex As Integer = 0
        Dim SStartIndex2 As Integer = 0
        Dim SEndIndex2 As Integer = 0
        Dim QModule As String = ""
        Dim QDetail As String = ""
        Dim QPrice As Double = 0
        Dim QPriceMulti As Double = 0
        Dim QQuantity As Integer = 0
        Dim QMQuantity As Integer = 0
        Try
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G5").Value = Date.Today
            StartIndex = 26
            EndIndex = 36
            StartIndex2 = 45
            EndIndex2 = 49
            SStartIndex = 28
            SEndIndex = 37
            SStartIndex2 = 40
            SEndIndex2 = 44
            QQuantity = 0
            QModule = ""
            QDetail = ""
            QPrice = 0
            QPriceMulti = 0
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("A5").Value = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A5").Value.ToString
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("C17").Value = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C17").Value.ToString
            For i = StartIndex To EndIndex
                QModule = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & i).Value.ToString
                If QModule = "" Then
                    Exit For
                End If
                QDetail = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & i).Value.ToString
                QQuantity = CInt(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & i).Value.ToString)
                QPrice = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & i).Value.ToString)
                QPriceMulti = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & i).Value.ToString)
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("A" & SStartIndex).Value = QModule
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("C" & SStartIndex).Value = QDetail
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("D" & SStartIndex).Value = QQuantity
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("F" & SStartIndex).Value = QPrice
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G" & SStartIndex).Value = QPriceMulti
                SStartIndex += 1
            Next
            For i = StartIndex2 To EndIndex2
                QModule = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & i).Value.ToString
                If QModule = "" Then
                    Exit For
                End If
                QDetail = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & i).Value.ToString
                QQuantity = CInt(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & i).Value.ToString)
                QPrice = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & i).Value.ToString)
                QPriceMulti = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & i).Value.ToString)
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("A" & SStartIndex2).Value = QModule
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("C" & SStartIndex2).Value = QDetail
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("D" & SStartIndex2).Value = QQuantity
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("F" & SStartIndex2).Value = QPrice
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G" & SStartIndex2).Value = QPriceMulti
                SStartIndex2 += 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadMaintQuote()
        Dim DateField As String = ""
        Dim StartIndex As Integer = 0
        Dim EndIndex As Integer = 0
        Dim SStartIndex As Integer = 0
        Dim SEndIndex As Integer = 0
        Dim QModule As String = ""
        Dim QDetail As String = ""
        Dim QPrice As Double = 0
        Dim QPriceMulti As Double = 0
        Dim QQuantity As Integer = 0
        Dim QMQuantity As Integer = 0
        Try
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G5").Value = Date.Today
            StartIndex = 26
            EndIndex = 36
            SStartIndex = 27
            SEndIndex = 38
            QQuantity = 0
            QModule = ""
            QDetail = ""
            QPrice = 0
            QPriceMulti = 0
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("A5").Value = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A5").Value.ToString & " 御中"
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("C17").Value = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C17").Value.ToString & " 御中"
            For i = StartIndex To EndIndex
                QModule = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & i).Value.ToString
                If QModule = "" Or InStr(1, QModule, "MXU", CompareMethod.Text) > 0 Then
                    Exit For
                End If
                QDetail = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & i).Value.ToString
                QQuantity = CInt(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & i).Value.ToString)
                QPrice = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & i).Value.ToString)
                QPriceMulti = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & i).Value.ToString)
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("A" & SStartIndex).Value = QModule
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("C" & SStartIndex).Value = QDetail
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("D" & SStartIndex).Value = QQuantity
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("F" & SStartIndex).Value = QPrice
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G" & SStartIndex).Value = QPriceMulti
                SStartIndex += 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadMaintInvoice()
        Dim DateField As String = ""
        Dim StartIndex As Integer = 0
        Dim EndIndex As Integer = 0
        Dim SStartIndex As Integer = 0
        Dim SEndIndex As Integer = 0
        Dim QModule As String = ""
        Dim QDetail As String = ""
        Dim QPrice As Double = 0
        Dim QPriceMulti As Double = 0
        Dim QQuantity As Integer = 0
        Dim QMQuantity As Integer = 0
        Try
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G5").Value = Date.Today
            StartIndex = 26
            EndIndex = 36
            SStartIndex = 29
            SEndIndex = 38
            QQuantity = 0
            QModule = ""
            QDetail = ""
            QPrice = 0
            QPriceMulti = 0
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("A5").Value = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A5").Value.ToString & " 御中"
            xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("C17").Value = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C17").Value.ToString & " 御中"
            For i = StartIndex To EndIndex
                QModule = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("A" & i).Value.ToString
                If QModule = "" Or InStr(1, QModule, "MXU", CompareMethod.Text) > 0 Then
                    Exit For
                End If
                QDetail = xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("C" & i).Value.ToString
                QQuantity = CInt(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("D" & i).Value.ToString)
                QPrice = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("F" & i).Value.ToString)
                QPriceMulti = CDbl(xlsExpenses.Document.Worksheets.ActiveWorksheet.Cells("G" & i).Value.ToString)
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("A" & SStartIndex).Value = QModule
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("C" & SStartIndex).Value = QDetail
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("D" & SStartIndex).Value = QQuantity
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("F" & SStartIndex).Value = QPrice
                xlsDoc.Document.Worksheets.ActiveWorksheet.Cells("G" & SStartIndex).Value = QPriceMulti
                SStartIndex += 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadQuoteDoc()
        If bbiInvoice.Down = True Then
            Dim PListPath As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\請求書ベース.xls"
            xlsDoc.LoadDocument(PListPath)
            xtcTools.SelectedTabPage = tabExSpreadsheet2
            LoadInvoice()
        ElseIf bbiCreateQuote.Down = True Then
            xtcTools.SelectedTabPage = tabExSpreadsheet
        ElseIf bbiMaintInvoice.Down = True Then
            Dim PListPath As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\保守請求書ベース.xls"
            xlsDoc.LoadDocument(PListPath)
            xtcTools.SelectedTabPage = tabExSpreadsheet2
            LoadMaintInvoice()
        ElseIf bbiMaintQuote.Down = True Then
            Dim PListPath As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\保守見積もりベース.xls"
            xlsDoc.LoadDocument(PListPath)
            xtcTools.SelectedTabPage = tabExSpreadsheet2
            LoadMaintQuote()
        End If
    End Sub
    Private Sub bbiInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiInvoice.ItemClick
        bbiInvoice.Down = True
        bbiCreateQuote.Down = False
        bbiMaintQuote.Down = False
        bbiMaintInvoice.Down = False
        LoadQuoteDoc()
    End Sub
    Private Sub bbiCreateQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCreateQuote.ItemClick
        bbiInvoice.Down = False
        bbiCreateQuote.Down = True
        bbiMaintQuote.Down = False
        bbiMaintInvoice.Down = False
        LoadQuoteDoc()
    End Sub
    Private Sub bbiMaintQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMaintQuote.ItemClick
        bbiInvoice.Down = False
        bbiCreateQuote.Down = False
        bbiMaintQuote.Down = True
        bbiMaintInvoice.Down = False
        LoadQuoteDoc()
    End Sub
    Private Sub bbiMaintInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMaintInvoice.ItemClick
        bbiInvoice.Down = False
        bbiCreateQuote.Down = False
        bbiMaintQuote.Down = False
        bbiMaintInvoice.Down = True
        LoadQuoteDoc()
    End Sub
    Private Sub bbiOpenQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOpenQuote.ItemClick
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = ""

        fd.Title = "見積もりを開く"
        fd.InitialDirectory = GblQuotationPath
        fd.Filter = "Excel Files|*.xls;"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
        xtcTools.SelectedTabPage = tabExSpreadsheet
        bbiCreateQuote.Down = True
        If File.Exists(strFileName) Then
            xlsExpenses.LoadDocument(strFileName)
            LoadModList()
        End If
    End Sub
#End Region
#Region "Repository"
    Private Sub riCardLink_OpenLink(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles riCardLink.OpenLink
        If e.EditValue <> "" Then
            Const mailPrefix As String = "mailto:"
            If Not e.EditValue.ToString().ToLower().StartsWith(mailPrefix) Then
                e.EditValue = mailPrefix + e.EditValue.ToString()
            End If
        End If
    End Sub
    Private Sub riCardURL_OpenLink(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles riCardURL.OpenLink
        Dim WebLink As String = ""
        If e.EditValue <> "" Then
            WebLink = e.EditValue
            e.EditValue = WebLink
        End If
    End Sub
    Private Sub riHyperLink_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles riHyperLink.OpenLink
        Dim WebLink As String = ""
        Dim HTMLLink As String = ""
        If e.EditValue <> "" And InStr(1, e.EditValue, "QA", CompareMethod.Text) > 0 Then
            WebLink = Replace(e.EditValue, "QA:", "")
            HTMLLink = "http://ontime.sigmatek.net/OnTimeWeb/viewitem.aspx?id=" & WebLink.Trim & "&type=defects&force_use_number=false"
            e.EditValue = HTMLLink
        ElseIf e.EditValue <> "" And InStr(1, e.EditValue, "SIM", CompareMethod.Text) > 0 Then
            WebLink = Replace(e.EditValue, "SIM:", "")
            HTMLLink = "http://info.sigmatek.net/org/OrgSimRelations?Id=" & WebLink.Trim
            e.EditValue = HTMLLink
        ElseIf e.EditValue <> "" And InStr(1, e.EditValue, "山本", CompareMethod.Text) > 0 Then
            Dim frmHelp As New frmDemoHelp
            Dim PontaPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailTemplates\ponta.png"
            Dim bmp As New Bitmap(PontaPath)
            frmHelp.Width = bmp.Width + 15
            frmHelp.Height = bmp.Height + 40
            frmHelp.picHElp.ImageLocation = PontaPath
            frmHelp.Show()
        ElseIf e.EditValue <> "" And InStr(1, e.EditValue, "竹内", CompareMethod.Text) > 0 Then
            Dim frmHelp As New frmDemoHelp
            Dim PontaPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailTemplates\panda.jpg"
            Dim bmp As New Bitmap(PontaPath)
            frmHelp.Width = bmp.Width + 15
            frmHelp.Height = bmp.Height + 40
            frmHelp.picHElp.ImageLocation = PontaPath
            frmHelp.Show()
        ElseIf e.EditValue <> "" And InStr(1, e.EditValue, "別所", CompareMethod.Text) > 0 Then
            Dim frmHelp As New frmDemoHelp
            Dim PontaPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailTemplates\mia.jpg"
            Dim bmp As New Bitmap(PontaPath)
            frmHelp.Width = bmp.Width + 15
            frmHelp.Height = bmp.Height + 40
            frmHelp.picHElp.ImageLocation = PontaPath
            frmHelp.Show()
        ElseIf e.EditValue <> "" And InStr(1, e.EditValue, "塩沢", CompareMethod.Text) > 0 Then
            Dim frmHelp As New frmDemoHelp
            Dim PontaPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailTemplates\shio.png"
            Dim bmp As New Bitmap(PontaPath)
            frmHelp.Width = bmp.Width + 15
            frmHelp.Height = bmp.Height + 40
            frmHelp.picHElp.ImageLocation = PontaPath
            frmHelp.Show()
        ElseIf e.EditValue <> "" And InStr(1, e.EditValue, "千葉", CompareMethod.Text) > 0 Then
            Dim frmHelp As New frmDemoHelp
            Dim PontaPath As String = SigmanestDataPath & "Applications\SigmaAPP\MailTemplates\chiba.jpg"
            Dim bmp As New Bitmap(PontaPath)
            frmHelp.Width = bmp.Width + 15
            frmHelp.Height = bmp.Height + 40
            frmHelp.picHElp.ImageLocation = PontaPath
            frmHelp.Show()
        End If
    End Sub
    Private Sub riSIMLink_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles riSIMLink.OpenLink
        Dim WebLink As String = ""
        Dim HTMLLink As String = ""
        If e.EditValue <> "" Then
            WebLink = e.EditValue
            HTMLLink = "http://info.sigmatek.net/org/OrgSimRelations?Id=" & WebLink.Trim
            e.EditValue = HTMLLink
        End If
    End Sub
    Private Sub riHyperLink2_OpenLink(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles riHyperlink2.OpenLink
        Dim WebLink As String = ""
        Dim HTMLLink As String = ""
        If e.EditValue <> "" Then
            WebLink = e.EditValue
            If InStr(1, UCase(WebLink), "WWW.", CompareMethod.Text) <= 0 And InStr(1, UCase(WebLink), "HTTP", CompareMethod.Text) <= 0 Then
                WebLink = "www." & WebLink
            End If
            HTMLLink = WebLink
            e.EditValue = HTMLLink
        End If

    End Sub
    Private Sub gvCustomerLog_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gvCustomerLog.CustomRowCellEdit
        If e.Column.FieldName = "LogItem" Then
            Dim Gv As GridView = sender
            e.RepositoryItem = riEventMemo
        End If
        If e.Column.FieldName = "Detail" Then
            Dim gv As GridView = sender
            e.RepositoryItem = riHyperLink
        End If
    End Sub
    Private Sub gvWebLink_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gvWebLink.CustomRowCellEdit
        If e.Column.FieldName = "WebLink" Then
            Dim Gv As GridView = sender
            e.RepositoryItem = riHyperlink2
        End If
    End Sub
    Private Sub gvSIM_CustomRowCellEdit(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs) Handles gvSim.CustomRowCellEdit
        If e.Column.FieldName = "SIMNo" Then
            Dim Gv As GridView = sender
            e.RepositoryItem = riSIMLink
        End If
    End Sub
#End Region
#Region "Navigation"

    Private Sub rbnMain_SelectedPageChanged(sender As System.Object, e As System.EventArgs) Handles rbnMain.SelectedPageChanged

        If rbnMain.SelectedPage.PageIndex = 0 Then
            xtcMain.SelectedTabPage = tabSigmaNEST
            If firstload = False Then
                LoadSigmanestData()
            End If
        ElseIf rbnMain.SelectedPage.PageIndex = 1 Then
            xtcMain.SelectedTabPage = tabDemo
            LoadDemoData()
        ElseIf rbnMain.SelectedPage.PageIndex = 2 Then
            xtcMain.SelectedTabPage = tabCustomer
            If firstload = False Then
                LoadCustomerData()
            End If
            If IsNet = True Then
                LoadSNInfoHub()
            End If
        ElseIf rbnMain.SelectedPage.PageIndex = 3 Then
            bbiShowCustomer.Down = True
            bbiShowCompany.Down = False
            xtcMain.SelectedTabPage = tabCustomerData
            'If LoadSalesLogic = False Then
            '    Dim SLthrd As System.Threading.Thread
            '    SLthrd = New System.Threading.Thread(AddressOf LoadSalesLogixItems)
            '    SLthrd.Start()
            '    LoadSalesLogic = True
            'End If
            PreLoadWebBrowser()
        ElseIf rbnMain.SelectedPage.PageIndex = 4 Then
            xtcMain.SelectedTabPage = tabApps
            LoadAppData()
        ElseIf rbnMain.SelectedPage.PageIndex = 5 Then
            xtcMain.SelectedTabPage = tabMail
            LoadMailForm()
            LoadMailTemplateData()
        ElseIf rbnMain.SelectedPage.PageIndex = 6 Then
            xtcMain.SelectedTabPage = tabWeb
            LoadWebLinksData()
        ElseIf rbnMain.SelectedPage.PageIndex = 7 Then
            xtcMain.SelectedTabPage = tabDocuments
            LoadDocumentData("ドキュメント")
        ElseIf rbnMain.SelectedPage.PageIndex = 8 Then
            xtcMain.SelectedTabPage = tabVideo
            LoadVideoData("プレゼン用ビデオ")
        ElseIf rbnMain.SelectedPage.PageIndex = 9 Then
            xtcCompanyTools.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            rpgQuote.Visible = False
            'xtcTools.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            xtcMain.SelectedTabPage = tabExpenses
            bbiExExpenses.Down = True
            LoadExMonthColumns()
            rpgQuote.Visible = False
            bbiExExpenses.Down = True
            bbiExTimecard.Down = False
            bbiQuotation.Down = False
            xtcTools.SelectedTabPage = tabExSpreadsheet
            xtcCompanyTools.SelectedTabPage = tabMyExpenses

            PrepareExpenseDirectory()
            LoadExpenses()
            LoadExMonthData()
        ElseIf rbnMain.SelectedPage.PageIndex = 10 Then
            xtcMain.SelectedTabPage = tabSettings
        End If

    End Sub
    Private Sub btnUndo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
        If xtcMain.SelectedTabPage Is tabExpenses Then
            UndoExpenses()
        End If
    End Sub
    Private Sub bbiNormalSetting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNormalSetting.ItemClick
        ResetSigmanestPath()
    End Sub
    Private Sub clbSource_DoubleClick(sender As Object, e As EventArgs) Handles clbSource.DoubleClick
        Dim SelPath As String = GblCustomerPath
        SelPath = SelPath & "\" & clbSource.SelectedValue & "\"
        Process.Start(SelPath)
    End Sub
    Private Sub clbVPNItems_DoubleClick(sender As Object, e As EventArgs) Handles clbVPNItems.DoubleClick
        Dim SelPath As String = VPNCustomerPath
        SelPath = SelPath & "\" & clbVPNItems.SelectedValue & "\"
        Process.Start(SelPath)
    End Sub
    Private Sub bbiSetSNData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSetSNData.ItemClick
        If xtcMain.SelectedTabPage Is tabCustomer Then
            SetSigmanestPaths()
        ElseIf xtcMain.SelectedTabPage Is tabDemo Then
            LoadDemoSet()
        ElseIf xtcMain.SelectedTabPage Is tabApps Then
            SetAppPaths()
        End If
    End Sub
    Private Sub bbiUndoSetting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUndoSetting.ItemClick
        If xtcMain.SelectedTabPage Is tabCustomer Then
            UndoSigmanestPath()
        ElseIf xtcMain.SelectedTabPage Is tabApps Then
            UndoAppPaths()
        End If
    End Sub
    Private Sub bbiSaveSettings_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSaveSettings.ItemClick
        SaveIniSettings()
    End Sub

    Private Sub bbiNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNew.ItemClick
        If xtcMain.SelectedTabPage Is tabCustomer Then
            'ClearCustomerForm()
            ClearTikItems()
        ElseIf xtcMain.SelectedTabPage Is tabApps Then
            GblAppFileLog = ""
            recApp.CreateNewDocument()
        ElseIf xtcMain.SelectedTabPage Is tabMail Then
            If bbiMailText.Down = True Then
                txtSubject.Text = ""
                rtbBody.Text = ""
            Else
                frmWebMail.CreateNewMail()
            End If

        ElseIf xtcMain.SelectedTabPage Is tabWeb Then
            txtWebDescription.Text = ""
            txtWebLink.Text = ""
            cmbWebType.Text = ""
        ElseIf xtcMain.SelectedTabPage Is tabExpenses Then
            If bbiQuotation.Down = True Then
                ClearAllQty()
                Dim PListPath As String = SigmanestDataPath & "Applications\SigmaAPP\Quotations\見積もりベース.xls"
                xlsExpenses.LoadDocument(PListPath)
            Else
                ClearExValues()
            End If
        End If
    End Sub
    Private Sub bbiSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSave.ItemClick
        If xtcMain.SelectedTabPage Is tabCustomer Then
            SaveCustomerLogFile()
        ElseIf xtcMain.SelectedTabPage Is tabApps Then
            SaveAppCommentFile()
        ElseIf xtcMain.SelectedTabPage Is tabMail Then
            If bbiMailText.Down = True Then
                SaveMailTemplate()
            Else
                frmWebMail.SaveMail()
            End If
        ElseIf xtcMain.SelectedTabPage Is tabWeb Then
            SaveWebLinksData()
        ElseIf xtcMain.SelectedTabPage Is tabSettings Then
            If bbiTranslate.Down = True Then
                frmTranslation.SaveTranslations()
            Else
                SaveIniSettings()
            End If
        ElseIf xtcMain.SelectedTabPage Is tabDocuments Then
            SaveDocument()
        ElseIf xtcMain.SelectedTabPage Is tabExpenses Then
            SaveExpense()
        End If
    End Sub
    Private Sub bbiExportPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportPDF.ItemClick
        If xtcMain.SelectedTabPage Is tabExpenses Then
            PDFExpense()
        End If
    End Sub
    Private Sub bbiPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrint.ItemClick
        If xtcMain.SelectedTabPage Is tabDocuments Then
            PrintDocument()
        ElseIf xtcMain.SelectedTabPage Is tabExpenses Then
            PrintExpense()
        End If
    End Sub
    Private Sub bbiDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick
        If xtcMain.SelectedTabPage Is tabMail Then
            DeleteMailTemplate()
        ElseIf xtcMain.SelectedTabPage Is tabWeb Then
            DeleteWebLinksData()
        End If
    End Sub
    Private Sub bbiRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        LoadCustomerLogFile()
    End Sub
    Private Sub bbiOpenFile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOpenFile.ItemClick
        If GblDocumentPath <> "" Then
            Process.Start(GblDocumentPath)
        End If
    End Sub
    Private Sub bbiOpen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiOpen.ItemClick
        Try
            If xtcMain.SelectedTabPage Is tabApps Then
                Process.Start(Microsoft.VisualBasic.Left(GblAppPath, Len(GblAppPath) - (Len(GblAppPath) - GblAppPath.LastIndexOf("\"))) & "\")
            ElseIf xtcMain.SelectedTabPage Is tabVideo Then
                Process.Start(GblVideopath)
            ElseIf xtcMain.SelectedTabPage Is tabDocuments Then
                Process.Start(GblDocumentDataPath)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub bbiSNConfig_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSNConfig.ItemClick
        Try
            ConnectToCOM()
            FSNApp.ShowConfigSetup()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ttsItemDelete_Click(sender As Object, e As EventArgs) Handles ttsItemDelete.Click
        Try
            If xtcMain.SelectedTabPage Is tabDocuments Then
                DeleteDocuments()
            ElseIf xtcMain.SelectedTabPage Is tabVideo Then
                DeleteVideoImages()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub bsiVersion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bsiVersion.ItemClick
        If Language = "jp" Then
            Language = "en"
        Else
            Language = "jp"
        End If
        LoadLanguages()
    End Sub
    Private Sub bbiCustMarkers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCustMarkers.ItemClick
        If bbiCustMarkers.Down = True Then
            ShowMapMarkers()
            xtcMain.SelectedTabPage = tabBrowser
        Else
            xtcMain.SelectedTabPage = tabCustomerData
        End If
    End Sub
    Private Sub bbiRefreshData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefreshData.ItemClick
        If xtcMain.SelectedTabPage Is tabSigmaNEST Then
            LoadSigmanestData()
        ElseIf xtcMain.SelectedTabPage Is tabCustomerData Then
            gvCustomerData.ApplyFindFilter("")
            gvCustomerData.ClearColumnsFilter()
            gvCustomerData.SaveLayoutToRegistry("gvCustomerData")
            LoadCustomerInfoItems()
        End If
    End Sub

    Public Function CheckPageExists(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Sub SearchWebShortcut(ByVal SearchVal As String)
        Dim SearchURL As String = ""
        If InStr(1, UCase(SearchVal), "W:", CompareMethod.Text) > 0 Or InStr(1, UCase(SearchVal), "W ", CompareMethod.Text) > 0 Then
            SearchVal = Replace(SearchVal, "W:", "")
            SearchVal = Replace(SearchVal, "W ", "")
            SearchVal = Replace(SearchVal, "w:", "")
            SearchVal = Replace(SearchVal, "w ", "")
            If UCase(SearchVal) = "BATCH" Then
                SearchVal = "Batch_Files"
            ElseIf UCase(SearchVal) = "US" Then
                SearchVal = "Cincinnati_directory"
            ElseIf UCase(SearchVal) = "PS" Then
                SearchVal = "Post_Script_Properties"
            ElseIf UCase(SearchVal) = "HR" Then
                SearchVal = "Human_Resources"
            End If
            If UCase(SearchVal) = "NC" Then
                SearchURL = "http://info.sigmatek.net/Documents/Development/Post/DataNC/DataNC.htm"
            Else
                SearchURL = "http://wiki.sigmatek.net/index.php?title=Special%3ASearch&search=" & SearchVal & "&go=Go"
            End If
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        ElseIf InStr(1, UCase(SearchVal), "O:", CompareMethod.Text) > 0 Or InStr(1, UCase(SearchVal), "O ", CompareMethod.Text) > 0 Then
            SearchVal = Replace(SearchVal, "O:", "")
            SearchVal = Replace(SearchVal, "O ", "")
            SearchVal = Replace(SearchVal, "o:", "")
            SearchVal = Replace(SearchVal, "o ", "")
            SearchURL = "http://ontime.sigmatek.net/ontimeweb/viewitem.aspx?id=" & SearchVal & "&type=defects"
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        ElseIf InStr(1, UCase(SearchVal), "P:", CompareMethod.Text) > 0 Or InStr(1, UCase(SearchVal), "P ", CompareMethod.Text) > 0 Then
            SearchVal = Replace(SearchVal, "P:", "")
            SearchVal = Replace(SearchVal, "P ", "")
            SearchVal = Replace(SearchVal, "p:", "")
            SearchVal = Replace(SearchVal, "p ", "")
            SearchURL = "http://info.sigmatek.net/PriceList/Report?id=87991860-d89a-437b-95ed-43f6f890935c&name=&title=" & SearchVal & ""
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        ElseIf InStr(1, UCase(SearchVal), "C:", CompareMethod.Text) > 0 Or InStr(1, UCase(SearchVal), "C ", CompareMethod.Text) > 0 Then
            SearchVal = Replace(SearchVal, "C:", "")
            SearchVal = Replace(SearchVal, "C ", "")
            SearchVal = Replace(SearchVal, "c:", "")
            SearchVal = Replace(SearchVal, "c ", "")
            SearchVal = Replace(SearchVal, "c　", "")
            SearchVal = Replace(SearchVal, "ｃ　", "")
            rbnMain.SelectedPage = rpgMain
            gvCustomer.ShowFindPanel()
            gvCustomer.ApplyFindFilter(SearchVal)
            gvCustomer.MoveFirst()
            gvCustomer.SelectRow(0)
            beiSearch.EditValue = ""
        ElseIf InStr(1, UCase(SearchVal), "A:", CompareMethod.Text) > 0 Or InStr(1, UCase(SearchVal), "A ", CompareMethod.Text) > 0 Then
            SearchVal = Replace(SearchVal, "A:", "")
            SearchVal = Replace(SearchVal, "A ", "")
            SearchVal = Replace(SearchVal, "a:", "")
            SearchVal = Replace(SearchVal, "a ", "")
            SearchVal = Replace(SearchVal, "a　", "")
            SearchVal = Replace(SearchVal, "ａ　", "")
            rbnMain.SelectedPage = rpgCustomers
            gvCustomerData.ShowFindPanel()
            gvCustomerData.ApplyFindFilter(SearchVal)
            gvCustomerData.MoveFirst()
            gvCustomerData.SelectRow(0)
            beiSearch.EditValue = ""
        ElseIf InStr(1, UCase(SearchVal), "T:", CompareMethod.Text) > 0 Or InStr(1, UCase(SearchVal), "T ", CompareMethod.Text) > 0 Then
            SearchVal = Replace(SearchVal, "T:", "")
            SearchVal = Replace(SearchVal, "T ", "")
            SearchVal = Replace(SearchVal, "t:", "")
            SearchVal = Replace(SearchVal, "t ", "")
            SearchVal = Replace(SearchVal, "t　", "")
            SearchVal = Replace(SearchVal, "ｔ　", "")
            SearchURL = "http://transit.yahoo.co.jp/search/result?flatlon=&from=" & GblMyTrainStation & "&tlatlon=&to=" & SearchVal
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        ElseIf InStr(1, UCase(SearchVal), "M:", CompareMethod.Text) > 0 Or InStr(1, UCase(SearchVal), "M ", CompareMethod.Text) > 0 Then
            SearchVal = Replace(SearchVal, "M:", "")
            SearchVal = Replace(SearchVal, "M ", "")
            SearchVal = Replace(SearchVal, "m:", "")
            SearchVal = Replace(SearchVal, "m ", "")
            SearchVal = Replace(SearchVal, "m　", "")
            SearchVal = Replace(SearchVal, "ｍ　", "")
            SearchURL = "https://www.google.co.jp/maps/place/" & SearchVal
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        ElseIf UCase(SearchVal) = "WM" Then
            SearchURL = "https://outlook.office.com/owa/?realm=sigmatek.net&exsvurl=1&ll-cc=1041&modurl=0"
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        ElseIf UCase(SearchVal) = "SIM" Then
            SearchURL = "http://localhost:1947/_int_/devices.html"
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        ElseIf UCase(SearchVal) = "YT" Then
            SearchURL = "https://www.youtube.com/user/SigmaTEKsystems/playlists"
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        Else
            SearchURL = "https://www.google.co.jp/#q=" & SearchVal & ""
            Process.Start(SearchURL)
            beiSearch.EditValue = ""
        End If

    End Sub
    Private Sub bbiSearch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSearch.ItemClick
        SearchWebShortcut(beiSearch.EditValue)
        beiSearch.EditValue = ""

    End Sub
    Private Sub ritSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ritSearch.KeyDown
        Dim edit As TextEdit = CType(sender, TextEdit)
        Dim val As Object = edit.EditValue
        If e.KeyData = Keys.Enter Then
            If val IsNot Nothing Then
                SearchWebShortcut(val.ToString())
                beiSearch.EditValue = ""
                beiSearch.EditValue = Nothing
            End If
            e.Handled = True


        End If

    End Sub
#End Region



  

  



End Class

