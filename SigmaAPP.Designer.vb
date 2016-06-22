<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Dim GalleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.xtcMain = New DevExpress.XtraTab.XtraTabControl()
        Me.tabCustomer = New DevExpress.XtraTab.XtraTabPage()
        Me.splCustomer = New System.Windows.Forms.SplitContainer()
        Me.splCustInfo = New System.Windows.Forms.SplitContainer()
        Me.gcCustomer = New DevExpress.XtraGrid.GridControl()
        Me.gvCustomer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcCustomerDetail = New DevExpress.XtraGrid.GridControl()
        Me.cvCustomerDetail = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.riCardLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.riCardURL = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.xtcCustomer = New DevExpress.XtraTab.XtraTabControl()
        Me.tabTicket = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.splSim = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer11 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.clbSigmanest = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.clbVPNItems = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.clbSource = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.gcSim = New DevExpress.XtraGrid.GridControl()
        Me.gvSim = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riSIMLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.gcMachine = New DevExpress.XtraGrid.GridControl()
        Me.gvMachine = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemHyperLinkEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.splSigmaInfo = New System.Windows.Forms.SplitContainer()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtTikVersion = New DevExpress.XtraEditors.TextEdit()
        Me.rbnMain = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSetSNData = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUndoSetting = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditLog = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMail = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiJapan = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUSA = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiKorea = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOpenINI = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiChina = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSigmanest = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCompanion = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCTL = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLite = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiNormalSetting = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiBeyondCompare = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOpenFile = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCreateOutlookMail = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCalDay = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCalWeek = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCalWork = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCalMonth = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCalTimeline = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSNConfig = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiShowVideo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDocuments = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDocMachines = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDocTrouble = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCustFind = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCustClear = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAddNewCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSIMMail = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLicenseFile = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSalesMode = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAddCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditCust = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCustDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.skinSet = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.bbiEight = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiViewer = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOpen = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRunFile = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiShowCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiShowCompany = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMasterPost = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCompanyMode = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSpain = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGoogleContacts = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExWeb = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExExpenses = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExTimecard = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExCreate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiHasp = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPartnerMode = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiKillSigmanest = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiQuotation = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPicture = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSlideshow = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiQuoteDoc = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCreateQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMaintQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMaintInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOpenQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiVersion = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiCreateNewExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCreateNewWord = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSQLManager = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiQA = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiClickstamper = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOntime = New DevExpress.XtraBars.BarButtonItem()
        Me.bsNetworkStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiCustMarkers = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSalesLogix = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiTranslate = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFTPUp = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportToCSV = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPlaceholders = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMailMessage = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMailTemplate = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiMailText = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSMTPSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFTPSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiOpenPresentation = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUnits = New DevExpress.XtraBars.BarButtonItem()
        Me.copyDB = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPostalCodes = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiVPNStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.bsiGDriveStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.bbiRefreshData = New DevExpress.XtraBars.BarButtonItem()
        Me.beiSearch = New DevExpress.XtraBars.BarEditItem()
        Me.ritSearch = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.bbiSearch = New DevExpress.XtraBars.BarButtonItem()
        Me.bTest = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiProductInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection48 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonMiniToolbar1 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(Me.components)
        Me.rpgSigma = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgLanguage = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSigmaStartup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSigmaINI = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgTools = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgDemo = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgSigmanest2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgShowVideo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgDemoTools = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgMain = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgCustFind = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSalesMode = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgNav = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSigmanest = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgLog = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgMisc = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgCustomers = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgCustomerNav = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgFind = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgCustomerEdit = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgEight = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgApps = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgNav2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSigmanestApp = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSigmaDLLIni = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgAppVide = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgMail = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgMailer = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgNav3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgOutlook = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgWeb = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgWebNav = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgMaintenance = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgExcel = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgDocNav = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgMaintFind = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgNewDocument = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgDocApp = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgVideo = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgVideoShow = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgVideoFolder = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSlideshow = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpExpenses = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgExDocument = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgExNavigation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgExEdit = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgQuote = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSettings = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgSigmaTools = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgEdit = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgMiscSettings = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemRadioGroup2 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.chkTikClosed = New DevExpress.XtraEditors.CheckEdit()
        Me.meTikSolution = New DevExpress.XtraEditors.MemoEdit()
        Me.meTikDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.cmsShortcuts = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsSaveLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTikTitle = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciTitle = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDescription = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSolution = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lciVersion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.rtbEdit = New System.Windows.Forms.RichTextBox()
        Me.cbtnQA = New DevExpress.XtraEditors.CheckButton()
        Me.txtSIMVersion = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaintenance = New DevExpress.XtraEditors.TextEdit()
        Me.txtVersion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.deMaintenance = New DevExpress.XtraEditors.DateEdit()
        Me.gcCustomerLog = New DevExpress.XtraGrid.GridControl()
        Me.gvCustomerLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riEventMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.riHyperLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabOverview = New DevExpress.XtraTab.XtraTabPage()
        Me.wbOverview = New System.Windows.Forms.WebBrowser()
        Me.tabSupport = New DevExpress.XtraTab.XtraTabPage()
        Me.wbSupport = New System.Windows.Forms.WebBrowser()
        Me.tabMachine = New DevExpress.XtraTab.XtraTabPage()
        Me.wbMachine = New System.Windows.Forms.WebBrowser()
        Me.gcQA = New DevExpress.XtraGrid.GridControl()
        Me.gvQA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcSimSum = New DevExpress.XtraGrid.GridControl()
        Me.gvSimSum = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabCustomerData = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer9 = New System.Windows.Forms.SplitContainer()
        Me.gcCustomerData = New DevExpress.XtraGrid.GridControl()
        Me.gvCustomerData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ricComboEdit = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ricCountryComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.riHyperLinkMail = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.SplitContainer10 = New System.Windows.Forms.SplitContainer()
        Me.imageMap = New System.Windows.Forms.PictureBox()
        Me.webBrowser = New System.Windows.Forms.WebBrowser()
        Me.picCard = New System.Windows.Forms.PictureBox()
        Me.tabCompanySearch = New DevExpress.XtraTab.XtraTabPage()
        Me.tabSaleslogix = New DevExpress.XtraTab.XtraTabPage()
        Me.gcSalesLogix = New DevExpress.XtraGrid.GridControl()
        Me.gvSalesLogix = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemHyperLinkEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemHyperLinkEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.tabSigmaNEST = New DevExpress.XtraTab.XtraTabPage()
        Me.splApplications = New System.Windows.Forms.SplitContainer()
        Me.gcSigmaNEST = New DevExpress.XtraGrid.GridControl()
        Me.gvSigmaNEST = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gcProducts = New DevExpress.XtraGrid.GridControl()
        Me.gvProducts = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnlClock = New System.Windows.Forms.Panel()
        Me.tabApps = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.gcApps = New DevExpress.XtraGrid.GridControl()
        Me.gvApps = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.recApp = New DevExpress.XtraRichEdit.RichEditControl()
        Me.tabDemo = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer()
        Me.gcDemoMachine = New DevExpress.XtraGrid.GridControl()
        Me.gvDemoMachine = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riPicM = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.gcDemoFeatures = New DevExpress.XtraGrid.GridControl()
        Me.gvDemoFeatures = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riPicF = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabMail = New DevExpress.XtraTab.XtraTabPage()
        Me.splMailMain = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.rtbBody = New System.Windows.Forms.RichTextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubject = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gcMailTemplate = New DevExpress.XtraGrid.GridControl()
        Me.gvMailTemplate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.riEventType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.riEventAttachment = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.tabDocuments = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.tlDocuments = New DevExpress.XtraTreeList.TreeList()
        Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colPath = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colSize = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.docViewer = New DevExpress.XtraRichEdit.RichEditControl()
        Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.xlsData = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.tabWeb = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbWebType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWebLink = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWebDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gcWebLink = New DevExpress.XtraGrid.GridControl()
        Me.gvWebLink = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riHyperlink2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.tabVideo = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer17 = New System.Windows.Forms.SplitContainer()
        Me.gcVideo = New DevExpress.XtraGrid.GridControl()
        Me.gvVideo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.picImage = New DevExpress.XtraEditors.PictureEdit()
        Me.tabExpenses = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer14 = New System.Windows.Forms.SplitContainer()
        Me.xtcCompanyTools = New DevExpress.XtraTab.XtraTabControl()
        Me.tabMyExpenses = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExAdvertising = New DevExpress.XtraEditors.TextEdit()
        Me.txtExMisc = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExGift = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExRevenue = New DevExpress.XtraEditors.TextEdit()
        Me.txtExPostal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExOvPostal = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.cmbExLocEnd = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbExLocStart = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtExGas = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExCarRental = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExCarMiles = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExParking = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.rdoTransporation = New DevExpress.XtraEditors.RadioGroup()
        Me.txtExTaxi = New DevExpress.XtraEditors.TextEdit()
        Me.btnExSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExHighway = New DevExpress.XtraEditors.TextEdit()
        Me.txtExTrain = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExAir = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.cmbExMealMember = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.chkExForCompany = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExMealMisc = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExDinner = New DevExpress.XtraEditors.TextEdit()
        Me.txtExBreakfast = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExLunch = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.txtExCurrencyRate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbExCustomer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtExNitto = New DevExpress.XtraEditors.TextEdit()
        Me.deExDate = New DevExpress.XtraEditors.DateEdit()
        Me.chkExLate = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.chkExEarly = New DevExpress.XtraEditors.CheckEdit()
        Me.txtExEarlyLate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.chkNitto = New DevExpress.XtraEditors.CheckEdit()
        Me.txtExHotel = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.chkHotel = New DevExpress.XtraEditors.CheckEdit()
        Me.tabSalesTools = New DevExpress.XtraTab.XtraTabPage()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer6 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.gcQMisc = New DevExpress.XtraGrid.GridControl()
        Me.gvQMisc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ricCompanyName = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ricDiscountType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.ricDealerName = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.gcQPackage = New DevExpress.XtraGrid.GridControl()
        Me.gvQPackage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.gcQOption = New DevExpress.XtraGrid.GridControl()
        Me.gvQOption = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.gcQPosts = New DevExpress.XtraGrid.GridControl()
        Me.gvQPosts = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.NavBarGroupControlContainer4 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.gcQSupport = New DevExpress.XtraGrid.GridControl()
        Me.gvQSupport = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.NavBarGroupControlContainer5 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.gcQAll = New DevExpress.XtraGrid.GridControl()
        Me.gvQAll = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.NavQuotePackage = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.ポスト = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.splMonth = New System.Windows.Forms.SplitContainer()
        Me.xtcTools = New DevExpress.XtraTab.XtraTabControl()
        Me.tabExWeb = New DevExpress.XtraTab.XtraTabPage()
        Me.webExpenses = New System.Windows.Forms.WebBrowser()
        Me.tabExSpreadsheet = New DevExpress.XtraTab.XtraTabPage()
        Me.xlsExpenses = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.tabExSpreadsheet2 = New DevExpress.XtraTab.XtraTabPage()
        Me.xlsDoc = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.tabExDocument = New DevExpress.XtraTab.XtraTabPage()
        Me.splQuoteDoc = New System.Windows.Forms.SplitContainer()
        Me.recDoc = New DevExpress.XtraRichEdit.RichEditControl()
        Me.recDoc2 = New DevExpress.XtraRichEdit.RichEditControl()
        Me.gcExMonth = New DevExpress.XtraGrid.GridControl()
        Me.gvExMonth = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riHanko = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabBrowser = New DevExpress.XtraTab.XtraTabPage()
        Me.webB = New System.Windows.Forms.WebBrowser()
        Me.tabSettings = New DevExpress.XtraTab.XtraTabPage()
        Me.gcsSettings = New DevExpress.XtraEditors.GroupControl()
        Me.splSettings = New System.Windows.Forms.SplitContainer()
        Me.gcSettings = New DevExpress.XtraGrid.GridControl()
        Me.gvSettings = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcLSettings = New DevExpress.XtraGrid.GridControl()
        Me.gvLSettings = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riPassword = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.pnlTools = New System.Windows.Forms.Panel()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmsCustomer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsFindCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsNewFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsEditFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsOpenCustomerFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsFolderDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsMoveToCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsCreateExpenses = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsPostFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsTest = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCheck = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsCheck = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsEditSim = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsSIMMail = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsMailLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsDeleteLogItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsEditLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCustomerData = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsCustomerMultiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsAddToEMailList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsMailClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsOpenWebAddress = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsGoogleSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsNavitime = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsSearchJalan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsSearchRakuten = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsSearchWeather = New System.Windows.Forms.ToolStripMenuItem()
        Me.封筒ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsEnvelopeLarge = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsEnvelopeSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsVideo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsShowVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.cmsWeb = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsCopyClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsSim = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsAddToSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsAddMaintToSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsRequestSim = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDemo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsShowDemoVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsShowDemoWOL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsOpenDemoHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsQuote = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsQQty = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsQ1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsQ2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsQ3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsQ4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsQ5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsQAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsCartClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmsDelete = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsItemDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.BandwidthUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cmsAutoTest = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsLaunchasAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttsRunAutotest = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageCollection16 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcMain.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        CType(Me.splCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splCustomer.Panel1.SuspendLayout()
        Me.splCustomer.Panel2.SuspendLayout()
        Me.splCustomer.SuspendLayout()
        CType(Me.splCustInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splCustInfo.Panel1.SuspendLayout()
        Me.splCustInfo.Panel2.SuspendLayout()
        Me.splCustInfo.SuspendLayout()
        CType(Me.gcCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCustomerDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cvCustomerDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riCardLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riCardURL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcCustomer.SuspendLayout()
        Me.tabTicket.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.splSim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splSim.Panel1.SuspendLayout()
        Me.splSim.Panel2.SuspendLayout()
        Me.splSim.SuspendLayout()
        CType(Me.SplitContainer11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer11.Panel1.SuspendLayout()
        Me.SplitContainer11.Panel2.SuspendLayout()
        Me.SplitContainer11.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.clbSigmanest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbVPNItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clbSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcSim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riSIMLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.splSigmaInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splSigmaInfo.Panel1.SuspendLayout()
        Me.splSigmaInfo.Panel2.SuspendLayout()
        Me.splSigmaInfo.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.txtTikVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ritSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTikClosed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meTikSolution.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meTikDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsShortcuts.SuspendLayout()
        CType(Me.txtTikTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSolution, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSIMVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaintenance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deMaintenance.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deMaintenance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCustomerLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCustomerLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riEventMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riHyperLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOverview.SuspendLayout()
        Me.tabSupport.SuspendLayout()
        Me.tabMachine.SuspendLayout()
        CType(Me.gcQA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcSimSum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSimSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustomerData.SuspendLayout()
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer9.Panel1.SuspendLayout()
        Me.SplitContainer9.Panel2.SuspendLayout()
        Me.SplitContainer9.SuspendLayout()
        CType(Me.gcCustomerData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCustomerData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ricComboEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ricCountryComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riHyperLinkMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer10.Panel1.SuspendLayout()
        Me.SplitContainer10.Panel2.SuspendLayout()
        Me.SplitContainer10.SuspendLayout()
        CType(Me.imageMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSaleslogix.SuspendLayout()
        CType(Me.gcSalesLogix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSalesLogix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSigmaNEST.SuspendLayout()
        CType(Me.splApplications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splApplications.Panel1.SuspendLayout()
        Me.splApplications.Panel2.SuspendLayout()
        Me.splApplications.SuspendLayout()
        CType(Me.gcSigmaNEST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSigmaNEST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gcProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabApps.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.gcApps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvApps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDemo.SuspendLayout()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        CType(Me.gcDemoMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDemoMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPicM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDemoFeatures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDemoFeatures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPicF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMail.SuspendLayout()
        CType(Me.splMailMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMailMain.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMailTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMailTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riEventType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riEventAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDocuments.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.tlDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWeb.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.cmbWebType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWebLink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWebDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcWebLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvWebLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riHyperlink2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVideo.SuspendLayout()
        CType(Me.SplitContainer17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer17.Panel1.SuspendLayout()
        Me.SplitContainer17.Panel2.SuspendLayout()
        Me.SplitContainer17.SuspendLayout()
        CType(Me.gcVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabExpenses.SuspendLayout()
        CType(Me.SplitContainer14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer14.Panel1.SuspendLayout()
        Me.SplitContainer14.Panel2.SuspendLayout()
        Me.SplitContainer14.SuspendLayout()
        CType(Me.xtcCompanyTools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcCompanyTools.SuspendLayout()
        Me.tabMyExpenses.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.txtExAdvertising.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExMisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExGift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExRevenue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExPostal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExOvPostal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.cmbExLocEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbExLocStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExGas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExCarRental.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExCarMiles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExParking.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoTransporation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExTaxi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExHighway.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExTrain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExAir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.cmbExMealMember.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExForCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExMealMisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExDinner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExBreakfast.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExLunch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.txtExCurrencyRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbExCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExNitto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deExDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deExDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExLate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExEarly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExEarlyLate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNitto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExHotel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHotel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSalesTools.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer6.SuspendLayout()
        CType(Me.gcQMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ricCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ricDiscountType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ricDealerName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.gcQPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        CType(Me.gcQOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer3.SuspendLayout()
        CType(Me.gcQPosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQPosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer4.SuspendLayout()
        CType(Me.gcQSupport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQSupport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer5.SuspendLayout()
        CType(Me.gcQAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvQAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMonth.Panel1.SuspendLayout()
        Me.splMonth.Panel2.SuspendLayout()
        Me.splMonth.SuspendLayout()
        CType(Me.xtcTools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcTools.SuspendLayout()
        Me.tabExWeb.SuspendLayout()
        Me.tabExSpreadsheet.SuspendLayout()
        Me.tabExSpreadsheet2.SuspendLayout()
        Me.tabExDocument.SuspendLayout()
        CType(Me.splQuoteDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splQuoteDoc.Panel1.SuspendLayout()
        Me.splQuoteDoc.Panel2.SuspendLayout()
        Me.splQuoteDoc.SuspendLayout()
        CType(Me.gcExMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvExMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riHanko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBrowser.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        CType(Me.gcsSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcsSettings.SuspendLayout()
        CType(Me.splSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splSettings.Panel1.SuspendLayout()
        Me.splSettings.Panel2.SuspendLayout()
        Me.splSettings.SuspendLayout()
        CType(Me.gcSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCustomer.SuspendLayout()
        Me.cmsCheck.SuspendLayout()
        Me.cmsLog.SuspendLayout()
        Me.cmsCustomerData.SuspendLayout()
        Me.cmsVideo.SuspendLayout()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsWeb.SuspendLayout()
        Me.cmsSim.SuspendLayout()
        Me.cmsDemo.SuspendLayout()
        Me.cmsQuote.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.cmsDelete.SuspendLayout()
        Me.cmsAutoTest.SuspendLayout()
        CType(Me.ImageCollection16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xtcMain
        '
        Me.xtcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcMain.Location = New System.Drawing.Point(0, 0)
        Me.xtcMain.Name = "xtcMain"
        Me.xtcMain.SelectedTabPage = Me.tabCustomer
        Me.xtcMain.Size = New System.Drawing.Size(1270, 801)
        Me.xtcMain.TabIndex = 0
        Me.xtcMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCustomer, Me.tabCustomerData, Me.tabCompanySearch, Me.tabSaleslogix, Me.tabSigmaNEST, Me.tabApps, Me.tabDemo, Me.tabMail, Me.tabDocuments, Me.tabWeb, Me.tabVideo, Me.tabExpenses, Me.tabBrowser, Me.tabSettings})
        '
        'tabCustomer
        '
        Me.tabCustomer.Controls.Add(Me.splCustomer)
        Me.tabCustomer.Controls.Add(Me.gcQA)
        Me.tabCustomer.Controls.Add(Me.gcSimSum)
        Me.tabCustomer.Name = "tabCustomer"
        Me.tabCustomer.Size = New System.Drawing.Size(1264, 772)
        Me.tabCustomer.Text = "CustomerFiles"
        '
        'splCustomer
        '
        Me.splCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splCustomer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splCustomer.Location = New System.Drawing.Point(0, 0)
        Me.splCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.splCustomer.Name = "splCustomer"
        '
        'splCustomer.Panel1
        '
        Me.splCustomer.Panel1.Controls.Add(Me.splCustInfo)
        '
        'splCustomer.Panel2
        '
        Me.splCustomer.Panel2.Controls.Add(Me.xtcCustomer)
        Me.splCustomer.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.splCustomer.Size = New System.Drawing.Size(1264, 772)
        Me.splCustomer.SplitterDistance = 335
        Me.splCustomer.SplitterWidth = 3
        Me.splCustomer.TabIndex = 2
        '
        'splCustInfo
        '
        Me.splCustInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splCustInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splCustInfo.Location = New System.Drawing.Point(0, 0)
        Me.splCustInfo.Name = "splCustInfo"
        Me.splCustInfo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splCustInfo.Panel1
        '
        Me.splCustInfo.Panel1.Controls.Add(Me.gcCustomer)
        '
        'splCustInfo.Panel2
        '
        Me.splCustInfo.Panel2.Controls.Add(Me.gcCustomerDetail)
        Me.splCustInfo.Size = New System.Drawing.Size(335, 772)
        Me.splCustInfo.SplitterDistance = 568
        Me.splCustInfo.TabIndex = 0
        '
        'gcCustomer
        '
        Me.gcCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCustomer.Location = New System.Drawing.Point(0, 0)
        Me.gcCustomer.MainView = Me.gvCustomer
        Me.gcCustomer.Name = "gcCustomer"
        Me.gcCustomer.Size = New System.Drawing.Size(335, 568)
        Me.gcCustomer.TabIndex = 1
        Me.gcCustomer.UseEmbeddedNavigator = True
        Me.gcCustomer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCustomer})
        '
        'gvCustomer
        '
        Me.gvCustomer.GridControl = Me.gcCustomer
        Me.gvCustomer.Name = "gvCustomer"
        Me.gvCustomer.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvCustomer.OptionsBehavior.Editable = False
        Me.gvCustomer.OptionsCustomization.AllowGroup = False
        Me.gvCustomer.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvCustomer.OptionsView.ColumnAutoWidth = False
        Me.gvCustomer.OptionsView.EnableAppearanceOddRow = True
        Me.gvCustomer.OptionsView.ShowAutoFilterRow = True
        Me.gvCustomer.OptionsView.ShowGroupPanel = False
        '
        'gcCustomerDetail
        '
        Me.gcCustomerDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCustomerDetail.Location = New System.Drawing.Point(0, 0)
        Me.gcCustomerDetail.MainView = Me.cvCustomerDetail
        Me.gcCustomerDetail.Name = "gcCustomerDetail"
        Me.gcCustomerDetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riCardLink, Me.riCardURL})
        Me.gcCustomerDetail.Size = New System.Drawing.Size(335, 200)
        Me.gcCustomerDetail.TabIndex = 3
        Me.gcCustomerDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.cvCustomerDetail})
        '
        'cvCustomerDetail
        '
        Me.cvCustomerDetail.CardWidth = 250
        Me.cvCustomerDetail.FocusedCardTopFieldIndex = 0
        Me.cvCustomerDetail.GridControl = Me.gcCustomerDetail
        Me.cvCustomerDetail.Name = "cvCustomerDetail"
        Me.cvCustomerDetail.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'riCardLink
        '
        Me.riCardLink.AutoHeight = False
        Me.riCardLink.Name = "riCardLink"
        '
        'riCardURL
        '
        Me.riCardURL.AutoHeight = False
        Me.riCardURL.Name = "riCardURL"
        '
        'xtcCustomer
        '
        Me.xtcCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcCustomer.Location = New System.Drawing.Point(5, 5)
        Me.xtcCustomer.Name = "xtcCustomer"
        Me.xtcCustomer.SelectedTabPage = Me.tabTicket
        Me.xtcCustomer.Size = New System.Drawing.Size(916, 762)
        Me.xtcCustomer.TabIndex = 0
        Me.xtcCustomer.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabTicket, Me.tabOverview, Me.tabSupport, Me.tabMachine})
        '
        'tabTicket
        '
        Me.tabTicket.Controls.Add(Me.SplitContainer3)
        Me.tabTicket.Name = "tabTicket"
        Me.tabTicket.Size = New System.Drawing.Size(910, 733)
        Me.tabTicket.Text = "ログ"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.splSim)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer3.Size = New System.Drawing.Size(910, 733)
        Me.SplitContainer3.SplitterDistance = 131
        Me.SplitContainer3.SplitterWidth = 5
        Me.SplitContainer3.TabIndex = 2
        '
        'splSim
        '
        Me.splSim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splSim.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splSim.Location = New System.Drawing.Point(0, 0)
        Me.splSim.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.splSim.Name = "splSim"
        '
        'splSim.Panel1
        '
        Me.splSim.Panel1.Controls.Add(Me.SplitContainer11)
        '
        'splSim.Panel2
        '
        Me.splSim.Panel2.Controls.Add(Me.gcSim)
        Me.splSim.Panel2.Controls.Add(Me.gcMachine)
        Me.splSim.Size = New System.Drawing.Size(910, 131)
        Me.splSim.SplitterDistance = 704
        Me.splSim.TabIndex = 0
        '
        'SplitContainer11
        '
        Me.SplitContainer11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer11.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer11.Name = "SplitContainer11"
        '
        'SplitContainer11.Panel1
        '
        Me.SplitContainer11.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer11.Panel2
        '
        Me.SplitContainer11.Panel2.Controls.Add(Me.clbSource)
        Me.SplitContainer11.Size = New System.Drawing.Size(704, 131)
        Me.SplitContainer11.SplitterDistance = 467
        Me.SplitContainer11.SplitterWidth = 5
        Me.SplitContainer11.TabIndex = 1
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.clbSigmanest)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.clbVPNItems)
        Me.SplitContainer4.Size = New System.Drawing.Size(467, 131)
        Me.SplitContainer4.SplitterDistance = 230
        Me.SplitContainer4.TabIndex = 0
        '
        'clbSigmanest
        '
        Me.clbSigmanest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbSigmanest.Location = New System.Drawing.Point(0, 0)
        Me.clbSigmanest.Name = "clbSigmanest"
        Me.clbSigmanest.Size = New System.Drawing.Size(230, 131)
        Me.clbSigmanest.TabIndex = 1
        '
        'clbVPNItems
        '
        Me.clbVPNItems.AllowDrop = True
        Me.clbVPNItems.Appearance.BackColor = System.Drawing.Color.White
        Me.clbVPNItems.Appearance.Options.UseBackColor = True
        Me.clbVPNItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbVPNItems.Location = New System.Drawing.Point(0, 0)
        Me.clbVPNItems.Name = "clbVPNItems"
        Me.clbVPNItems.Size = New System.Drawing.Size(233, 131)
        Me.clbVPNItems.TabIndex = 2
        '
        'clbSource
        '
        Me.clbSource.AllowDrop = True
        Me.clbSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbSource.Location = New System.Drawing.Point(0, 0)
        Me.clbSource.Name = "clbSource"
        Me.clbSource.Size = New System.Drawing.Size(232, 131)
        Me.clbSource.TabIndex = 1
        '
        'gcSim
        '
        Me.gcSim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSim.Location = New System.Drawing.Point(0, 0)
        Me.gcSim.MainView = Me.gvSim
        Me.gcSim.Name = "gcSim"
        Me.gcSim.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riSIMLink})
        Me.gcSim.Size = New System.Drawing.Size(202, 131)
        Me.gcSim.TabIndex = 2
        Me.gcSim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSim})
        '
        'gvSim
        '
        Me.gvSim.GridControl = Me.gcSim
        Me.gvSim.Name = "gvSim"
        Me.gvSim.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvSim.OptionsCustomization.AllowGroup = False
        Me.gvSim.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSim.OptionsView.EnableAppearanceOddRow = True
        Me.gvSim.OptionsView.RowAutoHeight = True
        Me.gvSim.OptionsView.ShowGroupPanel = False
        '
        'riSIMLink
        '
        Me.riSIMLink.AutoHeight = False
        Me.riSIMLink.Name = "riSIMLink"
        '
        'gcMachine
        '
        Me.gcMachine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMachine.Location = New System.Drawing.Point(0, 0)
        Me.gcMachine.MainView = Me.gvMachine
        Me.gcMachine.Name = "gcMachine"
        Me.gcMachine.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit3})
        Me.gcMachine.Size = New System.Drawing.Size(202, 131)
        Me.gcMachine.TabIndex = 3
        Me.gcMachine.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMachine})
        '
        'gvMachine
        '
        Me.gvMachine.GridControl = Me.gcMachine
        Me.gvMachine.Name = "gvMachine"
        Me.gvMachine.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvMachine.OptionsCustomization.AllowGroup = False
        Me.gvMachine.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvMachine.OptionsView.EnableAppearanceOddRow = True
        Me.gvMachine.OptionsView.RowAutoHeight = True
        Me.gvMachine.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemHyperLinkEdit3
        '
        Me.RepositoryItemHyperLinkEdit3.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit3.Name = "RepositoryItemHyperLinkEdit3"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.splSigmaInfo)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.gcCustomerLog)
        Me.SplitContainer2.Size = New System.Drawing.Size(910, 597)
        Me.SplitContainer2.SplitterDistance = 270
        Me.SplitContainer2.TabIndex = 0
        '
        'splSigmaInfo
        '
        Me.splSigmaInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splSigmaInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splSigmaInfo.Location = New System.Drawing.Point(0, 0)
        Me.splSigmaInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.splSigmaInfo.MinimumSize = New System.Drawing.Size(0, 134)
        Me.splSigmaInfo.Name = "splSigmaInfo"
        Me.splSigmaInfo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splSigmaInfo.Panel1
        '
        Me.splSigmaInfo.Panel1.Controls.Add(Me.LayoutControl3)
        Me.splSigmaInfo.Panel1.Controls.Add(Me.rtbEdit)
        '
        'splSigmaInfo.Panel2
        '
        Me.splSigmaInfo.Panel2.Controls.Add(Me.cbtnQA)
        Me.splSigmaInfo.Panel2.Controls.Add(Me.txtSIMVersion)
        Me.splSigmaInfo.Panel2.Controls.Add(Me.txtMaintenance)
        Me.splSigmaInfo.Panel2.Controls.Add(Me.txtVersion)
        Me.splSigmaInfo.Panel2.Controls.Add(Me.LabelControl8)
        Me.splSigmaInfo.Panel2.Controls.Add(Me.LabelControl7)
        Me.splSigmaInfo.Panel2.Controls.Add(Me.deMaintenance)
        Me.splSigmaInfo.Size = New System.Drawing.Size(910, 270)
        Me.splSigmaInfo.SplitterDistance = 242
        Me.splSigmaInfo.SplitterWidth = 3
        Me.splSigmaInfo.TabIndex = 0
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.txtTikVersion)
        Me.LayoutControl3.Controls.Add(Me.chkTikClosed)
        Me.LayoutControl3.Controls.Add(Me.meTikSolution)
        Me.LayoutControl3.Controls.Add(Me.meTikDescription)
        Me.LayoutControl3.Controls.Add(Me.txtTikTitle)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1427, 160, 250, 350)
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(910, 242)
        Me.LayoutControl3.TabIndex = 2
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'txtTikVersion
        '
        Me.txtTikVersion.Location = New System.Drawing.Point(814, 41)
        Me.txtTikVersion.MenuManager = Me.rbnMain
        Me.txtTikVersion.Name = "txtTikVersion"
        Me.txtTikVersion.Size = New System.Drawing.Size(89, 20)
        Me.txtTikVersion.StyleController = Me.LayoutControl3
        Me.txtTikVersion.TabIndex = 104
        '
        'rbnMain
        '
        Me.rbnMain.ApplicationIcon = CType(resources.GetObject("rbnMain.ApplicationIcon"), System.Drawing.Bitmap)
        Me.rbnMain.ExpandCollapseItem.Id = 0
        Me.rbnMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rbnMain.ExpandCollapseItem, Me.bbiSave, Me.bbiSetSNData, Me.bbiUndoSetting, Me.bbiSaveSettings, Me.bbiNew, Me.bbiEditLog, Me.bbiRefresh, Me.bbiMail, Me.bbiJapan, Me.bbiUSA, Me.bbiKorea, Me.bbiOpenINI, Me.bbiChina, Me.bbiSigmanest, Me.bbiCompanion, Me.bbiQuote, Me.bbiCTL, Me.bbiLite, Me.bbiNormalSetting, Me.bbiBeyondCompare, Me.bbiOpenFile, Me.bbiDelete, Me.bbiCreateOutlookMail, Me.bbiCalDay, Me.bbiCalWeek, Me.bbiCalWork, Me.bbiCalMonth, Me.bbiCalTimeline, Me.bbiSNConfig, Me.bbiShowVideo, Me.bbiDocuments, Me.bbiDocMachines, Me.bbiDocTrouble, Me.bbiCustFind, Me.bbiCustClear, Me.bbiAddNewCustomer, Me.bbiEditCustomer, Me.bbiSIMMail, Me.bbiLicenseFile, Me.bbiSalesMode, Me.bbiAddCustomer, Me.bbiEditCust, Me.bbiCustDelete, Me.skinSet, Me.bbiEight, Me.bbiViewer, Me.bbiOpen, Me.bbiRunFile, Me.bbiShowCustomer, Me.bbiShowCompany, Me.bbiMasterPost, Me.bbiCompanyMode, Me.bbiPrint, Me.bbiSpain, Me.bbiGoogleContacts, Me.bbiExExcel, Me.bbiExWeb, Me.bbiExExpenses, Me.bbiExTimecard, Me.bbiExCreate, Me.btnUndo, Me.bbiHasp, Me.bbiPartnerMode, Me.bbiKillSigmanest, Me.bbiQuotation, Me.bbiPicture, Me.bbiSlideshow, Me.bbiQuoteDoc, Me.bbiExportPDF, Me.bbiInvoice, Me.bbiCreateQuote, Me.bbiMaintQuote, Me.bbiMaintInvoice, Me.bbiOpenQuote, Me.bsiVersion, Me.bbiCreateNewExcel, Me.bbiCreateNewWord, Me.bbiSQLManager, Me.bbiQA, Me.bsiStatus, Me.bbiClickstamper, Me.bbiOntime, Me.bsNetworkStatus, Me.bbiCustMarkers, Me.bbiSalesLogix, Me.bbiTranslate, Me.bbiFTPUp, Me.bbiExportToCSV, Me.bbiPlaceholders, Me.bbiMailMessage, Me.bbiMailTemplate, Me.bbiMailText, Me.bbiSMTPSettings, Me.bbiFTPSettings, Me.bbiOpenPresentation, Me.bbiUnits, Me.copyDB, Me.btnPostalCodes, Me.bsiVPNStatus, Me.bsiGDriveStatus, Me.bbiRefreshData, Me.beiSearch, Me.bbiSearch, Me.bTest, Me.bbiProductInfo})
        Me.rbnMain.LargeImages = Me.ImageCollection48
        Me.rbnMain.Location = New System.Drawing.Point(0, 0)
        Me.rbnMain.MaxItemId = 63
        Me.rbnMain.MiniToolbars.Add(Me.RibbonMiniToolbar1)
        Me.rbnMain.Name = "rbnMain"
        Me.rbnMain.PageHeaderItemLinks.Add(Me.skinSet)
        Me.rbnMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpgSigma, Me.rpgDemo, Me.rpgMain, Me.rpgCustomers, Me.rpgApps, Me.rpgMail, Me.rpgWeb, Me.rpgMaintenance, Me.rpgVideo, Me.rpExpenses, Me.rpgSettings})
        Me.rbnMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRadioGroup1, Me.RepositoryItemRadioGroup2, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemTextEdit1, Me.ritSearch})
        Me.rbnMain.Size = New System.Drawing.Size(1270, 147)
        Me.rbnMain.StatusBar = Me.RibbonStatusBar1
        Me.rbnMain.Toolbar.ItemLinks.Add(Me.bbiOpenPresentation)
        Me.rbnMain.Toolbar.ItemLinks.Add(Me.bbiRefreshData)
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "登録"
        Me.bbiSave.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSave.Id = 1
        Me.bbiSave.LargeImageIndex = 29
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiSetSNData
        '
        Me.bbiSetSNData.Caption = "Sigmaを設定"
        Me.bbiSetSNData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSetSNData.Id = 2
        Me.bbiSetSNData.LargeImageIndex = 54
        Me.bbiSetSNData.Name = "bbiSetSNData"
        '
        'bbiUndoSetting
        '
        Me.bbiUndoSetting.Caption = "元の設定"
        Me.bbiUndoSetting.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiUndoSetting.Id = 3
        Me.bbiUndoSetting.LargeImageIndex = 45
        Me.bbiUndoSetting.Name = "bbiUndoSetting"
        '
        'bbiSaveSettings
        '
        Me.bbiSaveSettings.Caption = "設定保存"
        Me.bbiSaveSettings.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSaveSettings.Id = 4
        Me.bbiSaveSettings.LargeImageIndex = 29
        Me.bbiSaveSettings.Name = "bbiSaveSettings"
        '
        'bbiNew
        '
        Me.bbiNew.Caption = "クリア"
        Me.bbiNew.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiNew.Id = 5
        Me.bbiNew.LargeImageIndex = 46
        Me.bbiNew.Name = "bbiNew"
        '
        'bbiEditLog
        '
        Me.bbiEditLog.Caption = "ログ編集"
        Me.bbiEditLog.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEditLog.Id = 6
        Me.bbiEditLog.LargeImageIndex = 10
        Me.bbiEditLog.Name = "bbiEditLog"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "ログ更新"
        Me.bbiRefresh.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiRefresh.Id = 7
        Me.bbiRefresh.LargeImageIndex = 47
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'bbiMail
        '
        Me.bbiMail.Caption = "メール"
        Me.bbiMail.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiMail.Id = 8
        Me.bbiMail.LargeImageIndex = 69
        Me.bbiMail.Name = "bbiMail"
        '
        'bbiJapan
        '
        Me.bbiJapan.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiJapan.Caption = "日本語"
        Me.bbiJapan.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiJapan.Id = 10
        Me.bbiJapan.LargeImageIndex = 48
        Me.bbiJapan.Name = "bbiJapan"
        '
        'bbiUSA
        '
        Me.bbiUSA.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiUSA.Caption = "英語"
        Me.bbiUSA.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiUSA.Id = 11
        Me.bbiUSA.LargeImageIndex = 50
        Me.bbiUSA.Name = "bbiUSA"
        '
        'bbiKorea
        '
        Me.bbiKorea.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiKorea.Caption = "韓国語"
        Me.bbiKorea.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiKorea.Id = 12
        Me.bbiKorea.LargeImageIndex = 49
        Me.bbiKorea.Name = "bbiKorea"
        '
        'bbiOpenINI
        '
        Me.bbiOpenINI.Caption = "INIフォルダー開く"
        Me.bbiOpenINI.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiOpenINI.Id = 13
        Me.bbiOpenINI.LargeImageIndex = 51
        Me.bbiOpenINI.Name = "bbiOpenINI"
        '
        'bbiChina
        '
        Me.bbiChina.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiChina.Caption = "中国語"
        Me.bbiChina.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiChina.Id = 14
        Me.bbiChina.LargeImageIndex = 52
        Me.bbiChina.Name = "bbiChina"
        '
        'bbiSigmanest
        '
        Me.bbiSigmanest.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiSigmanest.Caption = "SigmaNEST"
        Me.bbiSigmanest.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSigmanest.Id = 15
        Me.bbiSigmanest.LargeImageIndex = 54
        Me.bbiSigmanest.Name = "bbiSigmanest"
        '
        'bbiCompanion
        '
        Me.bbiCompanion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiCompanion.Caption = "Companion"
        Me.bbiCompanion.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCompanion.Id = 16
        Me.bbiCompanion.LargeImageIndex = 53
        Me.bbiCompanion.Name = "bbiCompanion"
        '
        'bbiQuote
        '
        Me.bbiQuote.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiQuote.Caption = "Quote"
        Me.bbiQuote.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiQuote.Id = 17
        Me.bbiQuote.LargeImageIndex = 55
        Me.bbiQuote.Name = "bbiQuote"
        '
        'bbiCTL
        '
        Me.bbiCTL.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiCTL.Caption = "CTL"
        Me.bbiCTL.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCTL.Id = 18
        Me.bbiCTL.LargeImageIndex = 56
        Me.bbiCTL.Name = "bbiCTL"
        '
        'bbiLite
        '
        Me.bbiLite.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiLite.Caption = "Lite"
        Me.bbiLite.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiLite.Id = 19
        Me.bbiLite.LargeImageIndex = 57
        Me.bbiLite.Name = "bbiLite"
        '
        'bbiNormalSetting
        '
        Me.bbiNormalSetting.Caption = "標準設定"
        Me.bbiNormalSetting.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiNormalSetting.Id = 20
        Me.bbiNormalSetting.LargeImageIndex = 58
        Me.bbiNormalSetting.Name = "bbiNormalSetting"
        '
        'bbiBeyondCompare
        '
        Me.bbiBeyondCompare.Caption = "Beyond Compare"
        Me.bbiBeyondCompare.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiBeyondCompare.Id = 21
        Me.bbiBeyondCompare.LargeImageIndex = 59
        Me.bbiBeyondCompare.Name = "bbiBeyondCompare"
        '
        'bbiOpenFile
        '
        Me.bbiOpenFile.Caption = "ファイル開く"
        Me.bbiOpenFile.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiOpenFile.Id = 24
        Me.bbiOpenFile.LargeImageIndex = 84
        Me.bbiOpenFile.Name = "bbiOpenFile"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "削除"
        Me.bbiDelete.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiDelete.Id = 25
        Me.bbiDelete.LargeImageIndex = 42
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiCreateOutlookMail
        '
        Me.bbiCreateOutlookMail.Caption = "メール作成"
        Me.bbiCreateOutlookMail.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCreateOutlookMail.Id = 26
        Me.bbiCreateOutlookMail.LargeImageIndex = 62
        Me.bbiCreateOutlookMail.Name = "bbiCreateOutlookMail"
        '
        'bbiCalDay
        '
        Me.bbiCalDay.Caption = "日"
        Me.bbiCalDay.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCalDay.Id = 27
        Me.bbiCalDay.LargeImageIndex = 33
        Me.bbiCalDay.Name = "bbiCalDay"
        '
        'bbiCalWeek
        '
        Me.bbiCalWeek.Caption = "週"
        Me.bbiCalWeek.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCalWeek.Id = 32
        Me.bbiCalWeek.LargeImageIndex = 36
        Me.bbiCalWeek.Name = "bbiCalWeek"
        '
        'bbiCalWork
        '
        Me.bbiCalWork.Caption = "週（平日）"
        Me.bbiCalWork.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCalWork.Id = 33
        Me.bbiCalWork.LargeImageIndex = 37
        Me.bbiCalWork.Name = "bbiCalWork"
        '
        'bbiCalMonth
        '
        Me.bbiCalMonth.Caption = "月"
        Me.bbiCalMonth.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCalMonth.Id = 34
        Me.bbiCalMonth.LargeImageIndex = 34
        Me.bbiCalMonth.Name = "bbiCalMonth"
        '
        'bbiCalTimeline
        '
        Me.bbiCalTimeline.Caption = "タイムライン"
        Me.bbiCalTimeline.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCalTimeline.Id = 35
        Me.bbiCalTimeline.LargeImageIndex = 35
        Me.bbiCalTimeline.Name = "bbiCalTimeline"
        '
        'bbiSNConfig
        '
        Me.bbiSNConfig.Caption = "SNコンフィグ"
        Me.bbiSNConfig.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSNConfig.Id = 36
        Me.bbiSNConfig.LargeImageIndex = 63
        Me.bbiSNConfig.Name = "bbiSNConfig"
        '
        'bbiShowVideo
        '
        Me.bbiShowVideo.Caption = "ビデオ"
        Me.bbiShowVideo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiShowVideo.Id = 37
        Me.bbiShowVideo.LargeImageIndex = 64
        Me.bbiShowVideo.Name = "bbiShowVideo"
        '
        'bbiDocuments
        '
        Me.bbiDocuments.Caption = "ドキュメント"
        Me.bbiDocuments.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiDocuments.Id = 38
        Me.bbiDocuments.LargeImageIndex = 65
        Me.bbiDocuments.Name = "bbiDocuments"
        '
        'bbiDocMachines
        '
        Me.bbiDocMachines.Caption = "機械仕様書"
        Me.bbiDocMachines.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiDocMachines.Id = 39
        Me.bbiDocMachines.LargeImageIndex = 66
        Me.bbiDocMachines.Name = "bbiDocMachines"
        '
        'bbiDocTrouble
        '
        Me.bbiDocTrouble.Caption = "トラブルシューティング"
        Me.bbiDocTrouble.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiDocTrouble.Id = 41
        Me.bbiDocTrouble.LargeImageIndex = 68
        Me.bbiDocTrouble.Name = "bbiDocTrouble"
        '
        'bbiCustFind
        '
        Me.bbiCustFind.Caption = "検索"
        Me.bbiCustFind.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCustFind.Id = 42
        Me.bbiCustFind.LargeImageIndex = 32
        Me.bbiCustFind.Name = "bbiCustFind"
        '
        'bbiCustClear
        '
        Me.bbiCustClear.Caption = "検索クリア"
        Me.bbiCustClear.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCustClear.Id = 43
        Me.bbiCustClear.LargeImageIndex = 22
        Me.bbiCustClear.Name = "bbiCustClear"
        '
        'bbiAddNewCustomer
        '
        Me.bbiAddNewCustomer.Caption = "新規顧客"
        Me.bbiAddNewCustomer.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiAddNewCustomer.Id = 44
        Me.bbiAddNewCustomer.LargeImageIndex = 11
        Me.bbiAddNewCustomer.Name = "bbiAddNewCustomer"
        '
        'bbiEditCustomer
        '
        Me.bbiEditCustomer.Caption = "名前編集"
        Me.bbiEditCustomer.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEditCustomer.Id = 45
        Me.bbiEditCustomer.LargeImageIndex = 10
        Me.bbiEditCustomer.Name = "bbiEditCustomer"
        '
        'bbiSIMMail
        '
        Me.bbiSIMMail.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiSIMMail.Caption = "SIMメール"
        Me.bbiSIMMail.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSIMMail.Id = 46
        Me.bbiSIMMail.LargeImageIndex = 69
        Me.bbiSIMMail.Name = "bbiSIMMail"
        '
        'bbiLicenseFile
        '
        Me.bbiLicenseFile.Caption = "ライセンス開く"
        Me.bbiLicenseFile.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiLicenseFile.Id = 47
        Me.bbiLicenseFile.LargeImageIndex = 70
        Me.bbiLicenseFile.Name = "bbiLicenseFile"
        '
        'bbiSalesMode
        '
        Me.bbiSalesMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiSalesMode.Caption = "見込"
        Me.bbiSalesMode.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSalesMode.Id = 48
        Me.bbiSalesMode.LargeImageIndex = 71
        Me.bbiSalesMode.Name = "bbiSalesMode"
        '
        'bbiAddCustomer
        '
        Me.bbiAddCustomer.Caption = "追加"
        Me.bbiAddCustomer.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiAddCustomer.Id = 49
        Me.bbiAddCustomer.LargeImageIndex = 11
        Me.bbiAddCustomer.Name = "bbiAddCustomer"
        '
        'bbiEditCust
        '
        Me.bbiEditCust.Caption = "編集"
        Me.bbiEditCust.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEditCust.Id = 50
        Me.bbiEditCust.LargeImageIndex = 10
        Me.bbiEditCust.Name = "bbiEditCust"
        '
        'bbiCustDelete
        '
        Me.bbiCustDelete.Caption = "削除"
        Me.bbiCustDelete.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCustDelete.Id = 51
        Me.bbiCustDelete.LargeImageIndex = 42
        Me.bbiCustDelete.Name = "bbiCustDelete"
        '
        'skinSet
        '
        Me.skinSet.Caption = "着せ替え"
        '
        '
        '
        GalleryItemGroup1.Caption = "Group1"
        GalleryItem1.Caption = "Refresh"
        GalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {GalleryItem1})
        Me.skinSet.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.skinSet.Id = 52
        Me.skinSet.Name = "skinSet"
        '
        'bbiEight
        '
        Me.bbiEight.Caption = "Eight 同期"
        Me.bbiEight.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiEight.Id = 53
        Me.bbiEight.LargeImageIndex = 72
        Me.bbiEight.Name = "bbiEight"
        '
        'bbiViewer
        '
        Me.bbiViewer.Caption = "NCビューア"
        Me.bbiViewer.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiViewer.Id = 54
        Me.bbiViewer.LargeImageIndex = 73
        Me.bbiViewer.Name = "bbiViewer"
        '
        'bbiOpen
        '
        Me.bbiOpen.Caption = "フォルダーを開く"
        Me.bbiOpen.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiOpen.Id = 55
        Me.bbiOpen.LargeImageIndex = 51
        Me.bbiOpen.Name = "bbiOpen"
        '
        'bbiRunFile
        '
        Me.bbiRunFile.Caption = "ファイルを実行"
        Me.bbiRunFile.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiRunFile.Id = 56
        Me.bbiRunFile.LargeImageIndex = 38
        Me.bbiRunFile.Name = "bbiRunFile"
        '
        'bbiShowCustomer
        '
        Me.bbiShowCustomer.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiShowCustomer.Caption = "顧客リスト"
        Me.bbiShowCustomer.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiShowCustomer.Id = 57
        Me.bbiShowCustomer.LargeImageIndex = 75
        Me.bbiShowCustomer.Name = "bbiShowCustomer"
        '
        'bbiShowCompany
        '
        Me.bbiShowCompany.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiShowCompany.Caption = "企業リスト"
        Me.bbiShowCompany.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiShowCompany.Id = 58
        Me.bbiShowCompany.LargeImageIndex = 74
        Me.bbiShowCompany.Name = "bbiShowCompany"
        '
        'bbiMasterPost
        '
        Me.bbiMasterPost.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMasterPost.Caption = "ポスト"
        Me.bbiMasterPost.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiMasterPost.Id = 59
        Me.bbiMasterPost.LargeImageIndex = 66
        Me.bbiMasterPost.Name = "bbiMasterPost"
        '
        'bbiCompanyMode
        '
        Me.bbiCompanyMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiCompanyMode.Caption = "顧客"
        Me.bbiCompanyMode.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCompanyMode.Id = 60
        Me.bbiCompanyMode.LargeImageIndex = 81
        Me.bbiCompanyMode.Name = "bbiCompanyMode"
        '
        'bbiPrint
        '
        Me.bbiPrint.Caption = "印刷"
        Me.bbiPrint.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiPrint.Id = 61
        Me.bbiPrint.LargeImageIndex = 76
        Me.bbiPrint.Name = "bbiPrint"
        '
        'bbiSpain
        '
        Me.bbiSpain.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiSpain.Caption = "スペイン語"
        Me.bbiSpain.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSpain.Id = 62
        Me.bbiSpain.LargeImageIndex = 77
        Me.bbiSpain.Name = "bbiSpain"
        '
        'bbiGoogleContacts
        '
        Me.bbiGoogleContacts.Caption = "Google コンタクト追加"
        Me.bbiGoogleContacts.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiGoogleContacts.Id = 1
        Me.bbiGoogleContacts.LargeImageIndex = 27
        Me.bbiGoogleContacts.Name = "bbiGoogleContacts"
        '
        'bbiExExcel
        '
        Me.bbiExExcel.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiExExcel.Caption = "経費XLS"
        Me.bbiExExcel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiExExcel.Id = 2
        Me.bbiExExcel.LargeImageIndex = 14
        Me.bbiExExcel.Name = "bbiExExcel"
        '
        'bbiExWeb
        '
        Me.bbiExWeb.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiExWeb.Caption = "ウェブ情報"
        Me.bbiExWeb.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiExWeb.Id = 3
        Me.bbiExWeb.LargeImageIndex = 78
        Me.bbiExWeb.Name = "bbiExWeb"
        '
        'bbiExExpenses
        '
        Me.bbiExExpenses.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiExExpenses.Caption = "経費"
        Me.bbiExExpenses.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiExExpenses.Down = True
        Me.bbiExExpenses.Id = 4
        Me.bbiExExpenses.LargeImageIndex = 40
        Me.bbiExExpenses.Name = "bbiExExpenses"
        '
        'bbiExTimecard
        '
        Me.bbiExTimecard.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiExTimecard.Caption = "出勤表"
        Me.bbiExTimecard.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiExTimecard.Id = 5
        Me.bbiExTimecard.LargeImageIndex = 21
        Me.bbiExTimecard.Name = "bbiExTimecard"
        '
        'bbiExCreate
        '
        Me.bbiExCreate.Caption = "作成"
        Me.bbiExCreate.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiExCreate.Id = 6
        Me.bbiExCreate.LargeImageIndex = 79
        Me.bbiExCreate.Name = "bbiExCreate"
        '
        'btnUndo
        '
        Me.btnUndo.Caption = "元に戻す"
        Me.btnUndo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnUndo.Id = 7
        Me.btnUndo.LargeImageIndex = 45
        Me.btnUndo.Name = "btnUndo"
        '
        'bbiHasp
        '
        Me.bbiHasp.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiHasp.Caption = "HASP"
        Me.bbiHasp.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiHasp.Id = 8
        Me.bbiHasp.LargeImageIndex = 80
        Me.bbiHasp.Name = "bbiHasp"
        '
        'bbiPartnerMode
        '
        Me.bbiPartnerMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiPartnerMode.Caption = "取引先"
        Me.bbiPartnerMode.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiPartnerMode.Id = 9
        Me.bbiPartnerMode.LargeImageIndex = 82
        Me.bbiPartnerMode.Name = "bbiPartnerMode"
        '
        'bbiKillSigmanest
        '
        Me.bbiKillSigmanest.Caption = "SN終了"
        Me.bbiKillSigmanest.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiKillSigmanest.Id = 10
        Me.bbiKillSigmanest.LargeImageIndex = 86
        Me.bbiKillSigmanest.Name = "bbiKillSigmanest"
        '
        'bbiQuotation
        '
        Me.bbiQuotation.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiQuotation.Caption = "見積書"
        Me.bbiQuotation.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiQuotation.Id = 11
        Me.bbiQuotation.LargeImageIndex = 87
        Me.bbiQuotation.Name = "bbiQuotation"
        '
        'bbiPicture
        '
        Me.bbiPicture.Caption = "画像"
        Me.bbiPicture.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiPicture.Id = 12
        Me.bbiPicture.LargeImageIndex = 88
        Me.bbiPicture.Name = "bbiPicture"
        '
        'bbiSlideshow
        '
        Me.bbiSlideshow.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiSlideshow.Caption = "スライドショー"
        Me.bbiSlideshow.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSlideshow.Id = 13
        Me.bbiSlideshow.LargeImageIndex = 89
        Me.bbiSlideshow.Name = "bbiSlideshow"
        '
        'bbiQuoteDoc
        '
        Me.bbiQuoteDoc.Caption = "見積詳細"
        Me.bbiQuoteDoc.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiQuoteDoc.Id = 14
        Me.bbiQuoteDoc.LargeImageIndex = 65
        Me.bbiQuoteDoc.Name = "bbiQuoteDoc"
        '
        'bbiExportPDF
        '
        Me.bbiExportPDF.Caption = "PDF作成"
        Me.bbiExportPDF.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiExportPDF.Id = 15
        Me.bbiExportPDF.LargeImageIndex = 90
        Me.bbiExportPDF.Name = "bbiExportPDF"
        '
        'bbiInvoice
        '
        Me.bbiInvoice.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiInvoice.Caption = "請求書"
        Me.bbiInvoice.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiInvoice.Id = 19
        Me.bbiInvoice.LargeImageIndex = 92
        Me.bbiInvoice.Name = "bbiInvoice"
        '
        'bbiCreateQuote
        '
        Me.bbiCreateQuote.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiCreateQuote.Caption = "見積書"
        Me.bbiCreateQuote.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCreateQuote.Down = True
        Me.bbiCreateQuote.Id = 20
        Me.bbiCreateQuote.LargeImageIndex = 93
        Me.bbiCreateQuote.Name = "bbiCreateQuote"
        '
        'bbiMaintQuote
        '
        Me.bbiMaintQuote.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMaintQuote.Caption = "保守見積書"
        Me.bbiMaintQuote.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiMaintQuote.Id = 21
        Me.bbiMaintQuote.LargeImageIndex = 93
        Me.bbiMaintQuote.Name = "bbiMaintQuote"
        '
        'bbiMaintInvoice
        '
        Me.bbiMaintInvoice.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMaintInvoice.Caption = "保守請求書"
        Me.bbiMaintInvoice.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiMaintInvoice.Id = 22
        Me.bbiMaintInvoice.LargeImageIndex = 92
        Me.bbiMaintInvoice.Name = "bbiMaintInvoice"
        '
        'bbiOpenQuote
        '
        Me.bbiOpenQuote.Caption = "見積を開く"
        Me.bbiOpenQuote.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiOpenQuote.Id = 23
        Me.bbiOpenQuote.LargeImageIndex = 84
        Me.bbiOpenQuote.Name = "bbiOpenQuote"
        '
        'bsiVersion
        '
        Me.bsiVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiVersion.Caption = "Ver"
        Me.bsiVersion.Id = 24
        Me.bsiVersion.Name = "bsiVersion"
        Me.bsiVersion.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bbiCreateNewExcel
        '
        Me.bbiCreateNewExcel.Caption = "新規エクセル"
        Me.bbiCreateNewExcel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCreateNewExcel.Id = 27
        Me.bbiCreateNewExcel.LargeImageIndex = 14
        Me.bbiCreateNewExcel.Name = "bbiCreateNewExcel"
        '
        'bbiCreateNewWord
        '
        Me.bbiCreateNewWord.Caption = "新規ワード"
        Me.bbiCreateNewWord.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCreateNewWord.Id = 28
        Me.bbiCreateNewWord.LargeImageIndex = 94
        Me.bbiCreateNewWord.Name = "bbiCreateNewWord"
        '
        'bbiSQLManager
        '
        Me.bbiSQLManager.Caption = "SQLﾏﾈｰｼﾞｬｰ"
        Me.bbiSQLManager.Id = 29
        Me.bbiSQLManager.LargeImageIndex = 95
        Me.bbiSQLManager.Name = "bbiSQLManager"
        '
        'bbiQA
        '
        Me.bbiQA.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiQA.Caption = "QA"
        Me.bbiQA.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiQA.Id = 30
        Me.bbiQA.LargeImageIndex = 96
        Me.bbiQA.Name = "bbiQA"
        '
        'bsiStatus
        '
        Me.bsiStatus.Caption = "Online"
        Me.bsiStatus.Id = 31
        Me.bsiStatus.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.bsiStatus.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiStatus.Name = "bsiStatus"
        Me.bsiStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bbiClickstamper
        '
        Me.bbiClickstamper.Caption = "印鑑"
        Me.bbiClickstamper.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiClickstamper.Id = 32
        Me.bbiClickstamper.LargeImageIndex = 97
        Me.bbiClickstamper.Name = "bbiClickstamper"
        '
        'bbiOntime
        '
        Me.bbiOntime.Caption = "OnTime"
        Me.bbiOntime.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiOntime.Id = 33
        Me.bbiOntime.LargeImageIndex = 98
        Me.bbiOntime.Name = "bbiOntime"
        '
        'bsNetworkStatus
        '
        Me.bsNetworkStatus.Caption = "Net Stats"
        Me.bsNetworkStatus.Id = 34
        Me.bsNetworkStatus.Name = "bsNetworkStatus"
        Me.bsNetworkStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bbiCustMarkers
        '
        Me.bbiCustMarkers.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiCustMarkers.Caption = "顧客地図"
        Me.bbiCustMarkers.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiCustMarkers.Id = 35
        Me.bbiCustMarkers.LargeImageIndex = 24
        Me.bbiCustMarkers.Name = "bbiCustMarkers"
        '
        'bbiSalesLogix
        '
        Me.bbiSalesLogix.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiSalesLogix.Caption = "SalesLogix"
        Me.bbiSalesLogix.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSalesLogix.Id = 37
        Me.bbiSalesLogix.LargeImageIndex = 100
        Me.bbiSalesLogix.Name = "bbiSalesLogix"
        '
        'bbiTranslate
        '
        Me.bbiTranslate.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiTranslate.Caption = "翻訳"
        Me.bbiTranslate.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiTranslate.Id = 38
        Me.bbiTranslate.LargeImageIndex = 101
        Me.bbiTranslate.Name = "bbiTranslate"
        '
        'bbiFTPUp
        '
        Me.bbiFTPUp.Caption = "FTPアップ"
        Me.bbiFTPUp.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiFTPUp.Id = 39
        Me.bbiFTPUp.LargeImageIndex = 102
        Me.bbiFTPUp.Name = "bbiFTPUp"
        '
        'bbiExportToCSV
        '
        Me.bbiExportToCSV.Caption = "CSV出力"
        Me.bbiExportToCSV.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiExportToCSV.Id = 41
        Me.bbiExportToCSV.LargeImageIndex = 103
        Me.bbiExportToCSV.Name = "bbiExportToCSV"
        '
        'bbiPlaceholders
        '
        Me.bbiPlaceholders.Caption = "文字変換"
        Me.bbiPlaceholders.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiPlaceholders.Id = 42
        Me.bbiPlaceholders.LargeImageIndex = 16
        Me.bbiPlaceholders.Name = "bbiPlaceholders"
        '
        'bbiMailMessage
        '
        Me.bbiMailMessage.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMailMessage.Caption = "メッセージ"
        Me.bbiMailMessage.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiMailMessage.Down = True
        Me.bbiMailMessage.Id = 43
        Me.bbiMailMessage.LargeImageIndex = 17
        Me.bbiMailMessage.Name = "bbiMailMessage"
        '
        'bbiMailTemplate
        '
        Me.bbiMailTemplate.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMailTemplate.Caption = "テンプレート"
        Me.bbiMailTemplate.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiMailTemplate.Id = 44
        Me.bbiMailTemplate.LargeImageIndex = 8
        Me.bbiMailTemplate.Name = "bbiMailTemplate"
        '
        'bbiMailText
        '
        Me.bbiMailText.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiMailText.Caption = "テキスト"
        Me.bbiMailText.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiMailText.Id = 45
        Me.bbiMailText.LargeImageIndex = 0
        Me.bbiMailText.Name = "bbiMailText"
        '
        'bbiSMTPSettings
        '
        Me.bbiSMTPSettings.Caption = "SMTP設定"
        Me.bbiSMTPSettings.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiSMTPSettings.Id = 46
        Me.bbiSMTPSettings.LargeImageIndex = 5
        Me.bbiSMTPSettings.Name = "bbiSMTPSettings"
        '
        'bbiFTPSettings
        '
        Me.bbiFTPSettings.Caption = "FTP設定"
        Me.bbiFTPSettings.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiFTPSettings.Id = 47
        Me.bbiFTPSettings.LargeImageIndex = 102
        Me.bbiFTPSettings.Name = "bbiFTPSettings"
        '
        'bbiOpenPresentation
        '
        Me.bbiOpenPresentation.Caption = "プレゼンテーション"
        Me.bbiOpenPresentation.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiOpenPresentation.Glyph = CType(resources.GetObject("bbiOpenPresentation.Glyph"), System.Drawing.Image)
        Me.bbiOpenPresentation.Id = 48
        Me.bbiOpenPresentation.Name = "bbiOpenPresentation"
        '
        'bbiUnits
        '
        Me.bbiUnits.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.bbiUnits.Caption = "Metric"
        Me.bbiUnits.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.bbiUnits.Id = 49
        Me.bbiUnits.LargeImageIndex = 104
        Me.bbiUnits.Name = "bbiUnits"
        '
        'copyDB
        '
        Me.copyDB.Caption = "CopyDB"
        Me.copyDB.Id = 50
        Me.copyDB.Name = "copyDB"
        Me.copyDB.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnPostalCodes
        '
        Me.btnPostalCodes.Caption = "Postal"
        Me.btnPostalCodes.Id = 51
        Me.btnPostalCodes.Name = "btnPostalCodes"
        Me.btnPostalCodes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bsiVPNStatus
        '
        Me.bsiVPNStatus.Caption = "VPN On"
        Me.bsiVPNStatus.Id = 53
        Me.bsiVPNStatus.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.bsiVPNStatus.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiVPNStatus.Name = "bsiVPNStatus"
        Me.bsiVPNStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bsiGDriveStatus
        '
        Me.bsiGDriveStatus.Caption = "GDrive On"
        Me.bsiGDriveStatus.Id = 54
        Me.bsiGDriveStatus.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.bsiGDriveStatus.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiGDriveStatus.Name = "bsiGDriveStatus"
        Me.bsiGDriveStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bbiRefreshData
        '
        Me.bbiRefreshData.Caption = "Refresh"
        Me.bbiRefreshData.Glyph = CType(resources.GetObject("bbiRefreshData.Glyph"), System.Drawing.Image)
        Me.bbiRefreshData.Id = 55
        Me.bbiRefreshData.Name = "bbiRefreshData"
        '
        'beiSearch
        '
        Me.beiSearch.Edit = Me.ritSearch
        Me.beiSearch.EditWidth = 150
        Me.beiSearch.Id = 57
        Me.beiSearch.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.beiSearch.ItemAppearance.Normal.Options.UseFont = True
        Me.beiSearch.Name = "beiSearch"
        '
        'ritSearch
        '
        Me.ritSearch.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.ritSearch.AutoHeight = False
        Me.ritSearch.Name = "ritSearch"
        Me.ritSearch.NullValuePrompt = "検索項目を入力"
        Me.ritSearch.NullValuePromptShowForEmptyValue = True
        Me.ritSearch.ShowNullValuePromptWhenFocused = True
        '
        'bbiSearch
        '
        Me.bbiSearch.Caption = "Search"
        Me.bbiSearch.Glyph = CType(resources.GetObject("bbiSearch.Glyph"), System.Drawing.Image)
        Me.bbiSearch.Id = 59
        Me.bbiSearch.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.bbiSearch.ItemAppearance.Hovered.Options.UseFont = True
        Me.bbiSearch.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.bbiSearch.ItemAppearance.Normal.Options.UseFont = True
        Me.bbiSearch.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.bbiSearch.ItemAppearance.Pressed.Options.UseFont = True
        Me.bbiSearch.Name = "bbiSearch"
        ToolTipTitleItem1.Text = "ショートカット"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "W - Wiki (US,PS,NC,Batch)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O - OnTime" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P - プライスリスト" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C - 顧客データ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A - 取引先リスト" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T - 路線" & _
    "情報" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M - 地図" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WM - WebMail" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SIM - SIM情報" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "YT - SN　Youtube"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.bbiSearch.SuperTip = SuperToolTip1
        '
        'bTest
        '
        Me.bTest.Caption = "Test"
        Me.bTest.Id = 61
        Me.bTest.Name = "bTest"
        Me.bTest.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiProductInfo
        '
        Me.bbiProductInfo.Caption = "商品"
        Me.bbiProductInfo.Id = 62
        Me.bbiProductInfo.LargeImageIndex = 54
        Me.bbiProductInfo.Name = "bbiProductInfo"
        '
        'ImageCollection48
        '
        Me.ImageCollection48.ImageSize = New System.Drawing.Size(48, 48)
        Me.ImageCollection48.ImageStream = CType(resources.GetObject("ImageCollection48.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection48.Images.SetKeyName(0, "email.ico")
        Me.ImageCollection48.Images.SetKeyName(1, "phone.ico")
        Me.ImageCollection48.Images.SetKeyName(2, "woman.png")
        Me.ImageCollection48.Images.SetKeyName(3, "print.ico")
        Me.ImageCollection48.Images.SetKeyName(4, "print2.ico")
        Me.ImageCollection48.Images.SetKeyName(5, "smtp.ico")
        Me.ImageCollection48.Images.SetKeyName(6, "rss.ico")
        Me.ImageCollection48.Images.SetKeyName(7, "daemon.ico")
        Me.ImageCollection48.Images.SetKeyName(8, "book.ico")
        Me.ImageCollection48.Images.SetKeyName(9, "google.ico")
        Me.ImageCollection48.Images.SetKeyName(10, "check.ico")
        Me.ImageCollection48.Images.SetKeyName(11, "Plus.ico")
        Me.ImageCollection48.Images.SetKeyName(12, "x.ico")
        Me.ImageCollection48.Images.SetKeyName(13, "form.ico")
        Me.ImageCollection48.Images.SetKeyName(14, "excel.ico")
        Me.ImageCollection48.Images.SetKeyName(15, "ExportToCSV.ico")
        Me.ImageCollection48.Images.SetKeyName(16, "replace.ico")
        Me.ImageCollection48.Images.SetKeyName(17, "subscribe.ico")
        Me.ImageCollection48.Images.SetKeyName(18, "unsubscribe.ico")
        Me.ImageCollection48.Images.SetKeyName(19, "people.ico")
        Me.ImageCollection48.Images.SetKeyName(20, "fax.ico")
        Me.ImageCollection48.Images.SetKeyName(21, "cal.ico")
        Me.ImageCollection48.Images.SetKeyName(22, "list.ico")
        Me.ImageCollection48.Images.SetKeyName(23, "googlemaps.ico")
        Me.ImageCollection48.Images.SetKeyName(24, "gearth.ico")
        Me.ImageCollection48.Images.SetKeyName(25, "gimage.ico")
        Me.ImageCollection48.Images.SetKeyName(26, "gmail.ico")
        Me.ImageCollection48.Images.SetKeyName(27, "google2.ico")
        Me.ImageCollection48.Images.SetKeyName(28, "searchbutton.ico")
        Me.ImageCollection48.Images.SetKeyName(29, "save.ico")
        Me.ImageCollection48.Images.SetKeyName(30, "controlpanel.ico")
        Me.ImageCollection48.Images.SetKeyName(31, "sync.ico")
        Me.ImageCollection48.Images.SetKeyName(32, "find.ico")
        Me.ImageCollection48.Images.SetKeyName(33, "calday.ico")
        Me.ImageCollection48.Images.SetKeyName(34, "calmonth.ico")
        Me.ImageCollection48.Images.SetKeyName(35, "caltimeline.ico")
        Me.ImageCollection48.Images.SetKeyName(36, "calweek.ico")
        Me.ImageCollection48.Images.SetKeyName(37, "calworkweek.ico")
        Me.ImageCollection48.Images.SetKeyName(38, "play.ico")
        Me.ImageCollection48.Images.SetKeyName(39, "calendarplay.ico")
        Me.ImageCollection48.Images.SetKeyName(40, "CurrencyExchange.ico")
        Me.ImageCollection48.Images.SetKeyName(41, "backup.ico")
        Me.ImageCollection48.Images.SetKeyName(42, "delete.ico")
        Me.ImageCollection48.Images.SetKeyName(43, "web.ico")
        Me.ImageCollection48.Images.SetKeyName(44, "SigmaNEST80.ico")
        Me.ImageCollection48.Images.SetKeyName(45, "undo.ico")
        Me.ImageCollection48.Images.SetKeyName(46, "NEW.ico")
        Me.ImageCollection48.Images.SetKeyName(47, "Refresh.ico")
        Me.ImageCollection48.Images.SetKeyName(48, "japan.ico")
        Me.ImageCollection48.Images.SetKeyName(49, "korea.ico")
        Me.ImageCollection48.Images.SetKeyName(50, "usa.ico")
        Me.ImageCollection48.Images.SetKeyName(51, "open.ico")
        Me.ImageCollection48.Images.SetKeyName(52, "china.ico")
        Me.ImageCollection48.Images.SetKeyName(53, "sigma1.ico")
        Me.ImageCollection48.Images.SetKeyName(54, "sigma3.ico")
        Me.ImageCollection48.Images.SetKeyName(55, "sigma4.ico")
        Me.ImageCollection48.Images.SetKeyName(56, "ctl.ico")
        Me.ImageCollection48.Images.SetKeyName(57, "sigma6.ico")
        Me.ImageCollection48.Images.SetKeyName(58, "undo2.ico")
        Me.ImageCollection48.Images.SetKeyName(59, "bcompare.ico")
        Me.ImageCollection48.Images.SetKeyName(60, "autotest.ico")
        Me.ImageCollection48.Images.SetKeyName(61, "rakuca1.ico")
        Me.ImageCollection48.Images.SetKeyName(62, "outlook.ico")
        Me.ImageCollection48.Images.SetKeyName(63, "config.ico")
        Me.ImageCollection48.Images.SetKeyName(64, "video.ico")
        Me.ImageCollection48.Images.SetKeyName(65, "documents.ico")
        Me.ImageCollection48.Images.SetKeyName(66, "machine.ico")
        Me.ImageCollection48.Images.SetKeyName(67, "customize.ico")
        Me.ImageCollection48.Images.SetKeyName(68, "troubleshooting.ico")
        Me.ImageCollection48.Images.SetKeyName(69, "email2.ico")
        Me.ImageCollection48.Images.SetKeyName(70, "license.ico")
        Me.ImageCollection48.Images.SetKeyName(71, "sales.ico")
        Me.ImageCollection48.Images.SetKeyName(72, "eight.ico")
        Me.ImageCollection48.Images.SetKeyName(73, "ipos2.ico")
        Me.ImageCollection48.Images.SetKeyName(74, "company.ico")
        Me.ImageCollection48.Images.SetKeyName(75, "customers.ico")
        Me.ImageCollection48.Images.SetKeyName(76, "print.ico")
        Me.ImageCollection48.Images.SetKeyName(77, "spain.ico")
        Me.ImageCollection48.Images.SetKeyName(78, "navitime.ico")
        Me.ImageCollection48.Images.SetKeyName(79, "create.ico")
        Me.ImageCollection48.Images.SetKeyName(80, "hasp.ico")
        Me.ImageCollection48.Images.SetKeyName(81, "customer.ico")
        Me.ImageCollection48.Images.SetKeyName(82, "partner.ico")
        Me.ImageCollection48.Images.SetKeyName(83, "yahoo.ico")
        Me.ImageCollection48.Images.SetKeyName(84, "file.ico")
        Me.ImageCollection48.Images.SetKeyName(85, "kill.ico")
        Me.ImageCollection48.Images.SetKeyName(86, "poweroff.ico")
        Me.ImageCollection48.Images.SetKeyName(87, "yen2.ico")
        Me.ImageCollection48.Images.SetKeyName(88, "pic.ico")
        Me.ImageCollection48.Images.SetKeyName(89, "slideshow.ico")
        Me.ImageCollection48.Images.SetKeyName(90, "pdf-icon.ico")
        Me.ImageCollection48.Images.SetKeyName(91, "invoice.ico")
        Me.ImageCollection48.Images.SetKeyName(92, "invoice2.ico")
        Me.ImageCollection48.Images.SetKeyName(93, "quote.ico")
        Me.ImageCollection48.Images.SetKeyName(94, "word.ico")
        Me.ImageCollection48.Images.SetKeyName(95, "sql.ico")
        Me.ImageCollection48.Images.SetKeyName(96, "bug.ico")
        Me.ImageCollection48.Images.SetKeyName(97, "hanko.ico")
        Me.ImageCollection48.Images.SetKeyName(98, "axosoft.ico")
        Me.ImageCollection48.Images.SetKeyName(99, "history.ico")
        Me.ImageCollection48.Images.SetKeyName(100, "saleslogix.ico")
        Me.ImageCollection48.Images.SetKeyName(101, "translation.ico")
        Me.ImageCollection48.Images.SetKeyName(102, "ftp.png")
        Me.ImageCollection48.Images.SetKeyName(103, "csv.ico")
        Me.ImageCollection48.Images.SetKeyName(104, "units.ico")
        '
        'rpgSigma
        '
        Me.rpgSigma.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgLanguage, Me.rpgSigmaStartup, Me.rpgSigmaINI, Me.rpgTools})
        Me.rpgSigma.Name = "rpgSigma"
        Me.rpgSigma.Text = "アプリケーション"
        '
        'rpgLanguage
        '
        Me.rpgLanguage.AllowMinimize = False
        Me.rpgLanguage.AllowTextClipping = False
        Me.rpgLanguage.ItemLinks.Add(Me.bbiJapan)
        Me.rpgLanguage.ItemLinks.Add(Me.bbiUSA)
        Me.rpgLanguage.ItemLinks.Add(Me.bbiKorea)
        Me.rpgLanguage.ItemLinks.Add(Me.bbiChina)
        Me.rpgLanguage.Name = "rpgLanguage"
        Me.rpgLanguage.Text = "言語"
        '
        'rpgSigmaStartup
        '
        Me.rpgSigmaStartup.AllowMinimize = False
        Me.rpgSigmaStartup.AllowTextClipping = False
        Me.rpgSigmaStartup.ItemLinks.Add(Me.bbiSigmanest)
        Me.rpgSigmaStartup.ItemLinks.Add(Me.bbiCompanion)
        Me.rpgSigmaStartup.ItemLinks.Add(Me.bbiQuote)
        Me.rpgSigmaStartup.ItemLinks.Add(Me.bbiUnits)
        Me.rpgSigmaStartup.ItemLinks.Add(Me.bbiKillSigmanest)
        Me.rpgSigmaStartup.Name = "rpgSigmaStartup"
        Me.rpgSigmaStartup.Text = "スタートアップ"
        '
        'rpgSigmaINI
        '
        Me.rpgSigmaINI.AllowMinimize = False
        Me.rpgSigmaINI.AllowTextClipping = False
        Me.rpgSigmaINI.ItemLinks.Add(Me.bbiOpenINI)
        Me.rpgSigmaINI.ItemLinks.Add(Me.bbiLicenseFile)
        Me.rpgSigmaINI.Name = "rpgSigmaINI"
        Me.rpgSigmaINI.Text = "SigmaNEST INI"
        '
        'rpgTools
        '
        Me.rpgTools.AllowMinimize = False
        Me.rpgTools.AllowTextClipping = False
        Me.rpgTools.ItemLinks.Add(Me.bbiBeyondCompare)
        Me.rpgTools.ItemLinks.Add(Me.bbiViewer)
        Me.rpgTools.ItemLinks.Add(Me.bTest)
        Me.rpgTools.Name = "rpgTools"
        Me.rpgTools.Text = "ツール"
        '
        'rpgDemo
        '
        Me.rpgDemo.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgSigmanest2, Me.rpgShowVideo, Me.rpgDemoTools})
        Me.rpgDemo.Name = "rpgDemo"
        Me.rpgDemo.Text = "デモ設定"
        '
        'rpgSigmanest2
        '
        Me.rpgSigmanest2.AllowMinimize = False
        Me.rpgSigmanest2.AllowTextClipping = False
        Me.rpgSigmanest2.ItemLinks.Add(Me.bbiSetSNData)
        Me.rpgSigmanest2.ItemLinks.Add(Me.bbiUndoSetting)
        Me.rpgSigmanest2.ItemLinks.Add(Me.bbiNormalSetting)
        Me.rpgSigmanest2.ItemLinks.Add(Me.bbiSNConfig)
        Me.rpgSigmanest2.Name = "rpgSigmanest2"
        Me.rpgSigmanest2.Text = "SigmaNEST設定"
        '
        'rpgShowVideo
        '
        Me.rpgShowVideo.AllowMinimize = False
        Me.rpgShowVideo.AllowTextClipping = False
        Me.rpgShowVideo.ItemLinks.Add(Me.bbiShowVideo)
        Me.rpgShowVideo.Name = "rpgShowVideo"
        Me.rpgShowVideo.Text = "ビデオ"
        '
        'rpgDemoTools
        '
        Me.rpgDemoTools.AllowMinimize = False
        Me.rpgDemoTools.AllowTextClipping = False
        Me.rpgDemoTools.ItemLinks.Add(Me.bbiSQLManager)
        Me.rpgDemoTools.Name = "rpgDemoTools"
        Me.rpgDemoTools.Text = "ツール"
        '
        'rpgMain
        '
        Me.rpgMain.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgCustFind, Me.rpgSalesMode, Me.rpgNav, Me.rpgSigmanest, Me.rpgLog, Me.rpgMisc})
        Me.rpgMain.Name = "rpgMain"
        Me.rpgMain.Text = "顧客データ"
        '
        'rpgCustFind
        '
        Me.rpgCustFind.AllowMinimize = False
        Me.rpgCustFind.AllowTextClipping = False
        Me.rpgCustFind.ItemLinks.Add(Me.bbiCustFind)
        Me.rpgCustFind.Name = "rpgCustFind"
        Me.rpgCustFind.Text = "検索"
        '
        'rpgSalesMode
        '
        Me.rpgSalesMode.AllowMinimize = False
        Me.rpgSalesMode.AllowTextClipping = False
        Me.rpgSalesMode.ItemLinks.Add(Me.bbiCompanyMode)
        Me.rpgSalesMode.ItemLinks.Add(Me.bbiSalesMode)
        Me.rpgSalesMode.ItemLinks.Add(Me.bbiPartnerMode)
        Me.rpgSalesMode.ItemLinks.Add(Me.bbiMasterPost)
        Me.rpgSalesMode.Name = "rpgSalesMode"
        Me.rpgSalesMode.Text = "ナビゲーション"
        '
        'rpgNav
        '
        Me.rpgNav.AllowMinimize = False
        Me.rpgNav.AllowTextClipping = False
        Me.rpgNav.ItemLinks.Add(Me.bbiNew)
        Me.rpgNav.ItemLinks.Add(Me.bbiSave)
        Me.rpgNav.Name = "rpgNav"
        Me.rpgNav.Text = "新規・登録"
        '
        'rpgSigmanest
        '
        Me.rpgSigmanest.ItemLinks.Add(Me.bbiSetSNData)
        Me.rpgSigmanest.ItemLinks.Add(Me.bbiUndoSetting)
        Me.rpgSigmanest.ItemLinks.Add(Me.bbiNormalSetting)
        Me.rpgSigmanest.ItemLinks.Add(Me.bbiSNConfig)
        Me.rpgSigmanest.Name = "rpgSigmanest"
        Me.rpgSigmanest.Text = "SigmaNEST"
        '
        'rpgLog
        '
        Me.rpgLog.AllowMinimize = False
        Me.rpgLog.AllowTextClipping = False
        Me.rpgLog.ItemLinks.Add(Me.bbiRefresh)
        Me.rpgLog.Name = "rpgLog"
        Me.rpgLog.Text = "ログ"
        '
        'rpgMisc
        '
        Me.rpgMisc.AllowMinimize = False
        Me.rpgMisc.AllowTextClipping = False
        Me.rpgMisc.ItemLinks.Add(Me.bbiHasp)
        Me.rpgMisc.ItemLinks.Add(Me.bbiQA)
        Me.rpgMisc.ItemLinks.Add(Me.bbiFTPUp)
        Me.rpgMisc.ItemLinks.Add(Me.bbiMail)
        Me.rpgMisc.ItemLinks.Add(Me.bbiOntime)
        Me.rpgMisc.ItemLinks.Add(Me.bbiClickstamper)
        Me.rpgMisc.Name = "rpgMisc"
        Me.rpgMisc.Text = "その他"
        '
        'rpgCustomers
        '
        Me.rpgCustomers.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgCustomerNav, Me.rpgFind, Me.rpgCustomerEdit, Me.rpgEight})
        Me.rpgCustomers.Name = "rpgCustomers"
        Me.rpgCustomers.Text = "顧客情報"
        '
        'rpgCustomerNav
        '
        Me.rpgCustomerNav.AllowMinimize = False
        Me.rpgCustomerNav.AllowTextClipping = False
        Me.rpgCustomerNav.ItemLinks.Add(Me.bbiShowCustomer)
        Me.rpgCustomerNav.ItemLinks.Add(Me.bbiSalesLogix)
        Me.rpgCustomerNav.ItemLinks.Add(Me.bbiShowCompany)
        Me.rpgCustomerNav.Name = "rpgCustomerNav"
        Me.rpgCustomerNav.Text = "ナビゲーション"
        '
        'rpgFind
        '
        Me.rpgFind.AllowMinimize = False
        Me.rpgFind.AllowTextClipping = False
        Me.rpgFind.ItemLinks.Add(Me.bbiCustFind)
        Me.rpgFind.Name = "rpgFind"
        Me.rpgFind.Text = "検索"
        '
        'rpgCustomerEdit
        '
        Me.rpgCustomerEdit.AllowMinimize = False
        Me.rpgCustomerEdit.AllowTextClipping = False
        Me.rpgCustomerEdit.ItemLinks.Add(Me.bbiAddCustomer)
        Me.rpgCustomerEdit.ItemLinks.Add(Me.bbiEditCust)
        Me.rpgCustomerEdit.ItemLinks.Add(Me.bbiCustDelete)
        Me.rpgCustomerEdit.Name = "rpgCustomerEdit"
        Me.rpgCustomerEdit.Text = "顧客管理"
        '
        'rpgEight
        '
        Me.rpgEight.AllowMinimize = False
        Me.rpgEight.AllowTextClipping = False
        Me.rpgEight.ItemLinks.Add(Me.bbiExportToCSV)
        Me.rpgEight.ItemLinks.Add(Me.bbiCustMarkers)
        Me.rpgEight.ItemLinks.Add(Me.bbiGoogleContacts)
        Me.rpgEight.ItemLinks.Add(Me.bbiEight)
        Me.rpgEight.ItemLinks.Add(Me.copyDB)
        Me.rpgEight.ItemLinks.Add(Me.btnPostalCodes)
        Me.rpgEight.Name = "rpgEight"
        Me.rpgEight.Text = "ツール"
        '
        'rpgApps
        '
        Me.rpgApps.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgNav2, Me.rpgSigmanestApp, Me.rpgSigmaDLLIni, Me.rpgAppVide})
        Me.rpgApps.Name = "rpgApps"
        Me.rpgApps.Text = "アプリ・DLL"
        '
        'rpgNav2
        '
        Me.rpgNav2.AllowMinimize = False
        Me.rpgNav2.AllowTextClipping = False
        Me.rpgNav2.ItemLinks.Add(Me.bbiNew)
        Me.rpgNav2.ItemLinks.Add(Me.bbiSave)
        Me.rpgNav2.Name = "rpgNav2"
        Me.rpgNav2.Text = "新規・登録"
        '
        'rpgSigmanestApp
        '
        Me.rpgSigmanestApp.AllowMinimize = False
        Me.rpgSigmanestApp.AllowTextClipping = False
        Me.rpgSigmanestApp.ItemLinks.Add(Me.bbiSetSNData)
        Me.rpgSigmanestApp.ItemLinks.Add(Me.bbiUndoSetting)
        Me.rpgSigmanestApp.Name = "rpgSigmanestApp"
        Me.rpgSigmanestApp.Text = "SigmaNEST"
        Me.rpgSigmanestApp.Visible = False
        '
        'rpgSigmaDLLIni
        '
        Me.rpgSigmaDLLIni.ItemLinks.Add(Me.bbiOpen)
        Me.rpgSigmaDLLIni.ItemLinks.Add(Me.bbiRunFile)
        Me.rpgSigmaDLLIni.Name = "rpgSigmaDLLIni"
        Me.rpgSigmaDLLIni.Text = "APP/DLL"
        '
        'rpgAppVide
        '
        Me.rpgAppVide.AllowMinimize = False
        Me.rpgAppVide.AllowTextClipping = False
        Me.rpgAppVide.ItemLinks.Add(Me.bbiShowVideo)
        Me.rpgAppVide.Name = "rpgAppVide"
        Me.rpgAppVide.Text = "ビデオ"
        '
        'rpgMail
        '
        Me.rpgMail.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgMailer, Me.rpgNav3, Me.rpgOutlook})
        Me.rpgMail.Name = "rpgMail"
        Me.rpgMail.Text = "メール"
        '
        'rpgMailer
        '
        Me.rpgMailer.AllowMinimize = False
        Me.rpgMailer.AllowTextClipping = False
        Me.rpgMailer.ItemLinks.Add(Me.bbiMailMessage)
        Me.rpgMailer.ItemLinks.Add(Me.bbiMailTemplate)
        Me.rpgMailer.ItemLinks.Add(Me.bbiMailText)
        Me.rpgMailer.ItemLinks.Add(Me.bbiSMTPSettings)
        Me.rpgMailer.ItemLinks.Add(Me.bbiPlaceholders)
        Me.rpgMailer.Name = "rpgMailer"
        Me.rpgMailer.Text = "メール　ナビ"
        '
        'rpgNav3
        '
        Me.rpgNav3.AllowMinimize = False
        Me.rpgNav3.AllowTextClipping = False
        Me.rpgNav3.ItemLinks.Add(Me.bbiNew)
        Me.rpgNav3.ItemLinks.Add(Me.bbiSave)
        Me.rpgNav3.ItemLinks.Add(Me.bbiDelete)
        Me.rpgNav3.Name = "rpgNav3"
        Me.rpgNav3.Text = "新規・登録"
        '
        'rpgOutlook
        '
        Me.rpgOutlook.AllowMinimize = False
        Me.rpgOutlook.AllowTextClipping = False
        Me.rpgOutlook.ItemLinks.Add(Me.bbiCreateOutlookMail)
        Me.rpgOutlook.Name = "rpgOutlook"
        Me.rpgOutlook.Text = "Outlook"
        '
        'rpgWeb
        '
        Me.rpgWeb.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgWebNav})
        Me.rpgWeb.Name = "rpgWeb"
        Me.rpgWeb.Text = "ウェブ"
        '
        'rpgWebNav
        '
        Me.rpgWebNav.AllowMinimize = False
        Me.rpgWebNav.AllowTextClipping = False
        Me.rpgWebNav.ItemLinks.Add(Me.bbiNew)
        Me.rpgWebNav.ItemLinks.Add(Me.bbiDelete)
        Me.rpgWebNav.ItemLinks.Add(Me.bbiSave)
        Me.rpgWebNav.Name = "rpgWebNav"
        Me.rpgWebNav.Text = "新規・登録"
        '
        'rpgMaintenance
        '
        Me.rpgMaintenance.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgExcel, Me.rpgDocNav, Me.rpgMaintFind, Me.rpgNewDocument, Me.rpgDocApp})
        Me.rpgMaintenance.Name = "rpgMaintenance"
        Me.rpgMaintenance.Text = "ドキュメント"
        '
        'rpgExcel
        '
        Me.rpgExcel.AllowMinimize = False
        Me.rpgExcel.AllowTextClipping = False
        Me.rpgExcel.ItemLinks.Add(Me.bbiSave)
        Me.rpgExcel.ItemLinks.Add(Me.bbiOpenFile)
        Me.rpgExcel.ItemLinks.Add(Me.bbiOpen)
        Me.rpgExcel.ItemLinks.Add(Me.bbiPrint)
        Me.rpgExcel.Name = "rpgExcel"
        Me.rpgExcel.Text = "ファイル・フォルダー"
        '
        'rpgDocNav
        '
        Me.rpgDocNav.AllowMinimize = False
        Me.rpgDocNav.AllowTextClipping = False
        Me.rpgDocNav.ItemLinks.Add(Me.bbiDocuments)
        Me.rpgDocNav.ItemLinks.Add(Me.bbiDocMachines)
        Me.rpgDocNav.ItemLinks.Add(Me.bbiProductInfo)
        Me.rpgDocNav.ItemLinks.Add(Me.bbiDocTrouble)
        Me.rpgDocNav.Name = "rpgDocNav"
        Me.rpgDocNav.Text = "ナビゲーション"
        '
        'rpgMaintFind
        '
        Me.rpgMaintFind.AllowMinimize = False
        Me.rpgMaintFind.AllowTextClipping = False
        Me.rpgMaintFind.ItemLinks.Add(Me.bbiCustFind)
        Me.rpgMaintFind.Name = "rpgMaintFind"
        Me.rpgMaintFind.Text = "検索"
        '
        'rpgNewDocument
        '
        Me.rpgNewDocument.AllowMinimize = False
        Me.rpgNewDocument.AllowTextClipping = False
        Me.rpgNewDocument.ItemLinks.Add(Me.bbiCreateNewExcel)
        Me.rpgNewDocument.ItemLinks.Add(Me.bbiCreateNewWord)
        Me.rpgNewDocument.Name = "rpgNewDocument"
        Me.rpgNewDocument.Text = "新規ドキュメント"
        '
        'rpgDocApp
        '
        Me.rpgDocApp.AllowMinimize = False
        Me.rpgDocApp.AllowTextClipping = False
        Me.rpgDocApp.ItemLinks.Add(Me.bbiClickstamper)
        Me.rpgDocApp.Name = "rpgDocApp"
        Me.rpgDocApp.Text = "アウリ"
        '
        'rpgVideo
        '
        Me.rpgVideo.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgVideoShow, Me.rpgVideoFolder, Me.rpgSlideshow})
        Me.rpgVideo.Name = "rpgVideo"
        Me.rpgVideo.Text = "画像"
        '
        'rpgVideoShow
        '
        Me.rpgVideoShow.AllowMinimize = False
        Me.rpgVideoShow.AllowTextClipping = False
        Me.rpgVideoShow.ItemLinks.Add(Me.bbiShowVideo)
        Me.rpgVideoShow.ItemLinks.Add(Me.bbiPicture)
        Me.rpgVideoShow.Name = "rpgVideoShow"
        Me.rpgVideoShow.Text = "ビデオ・画像"
        '
        'rpgVideoFolder
        '
        Me.rpgVideoFolder.AllowMinimize = False
        Me.rpgVideoFolder.AllowTextClipping = False
        Me.rpgVideoFolder.ItemLinks.Add(Me.bbiOpen)
        Me.rpgVideoFolder.Name = "rpgVideoFolder"
        Me.rpgVideoFolder.Text = "フォルダー"
        '
        'rpgSlideshow
        '
        Me.rpgSlideshow.AllowMinimize = False
        Me.rpgSlideshow.AllowTextClipping = False
        Me.rpgSlideshow.ItemLinks.Add(Me.bbiSlideshow)
        Me.rpgSlideshow.Name = "rpgSlideshow"
        Me.rpgSlideshow.Text = "スライドショー"
        Me.rpgSlideshow.Visible = False
        '
        'rpExpenses
        '
        Me.rpExpenses.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgExDocument, Me.rpgExNavigation, Me.rpgExEdit, Me.rpgQuote})
        Me.rpExpenses.Name = "rpExpenses"
        Me.rpExpenses.Text = "社内書類"
        '
        'rpgExDocument
        '
        Me.rpgExDocument.AllowMinimize = False
        Me.rpgExDocument.AllowTextClipping = False
        Me.rpgExDocument.ItemLinks.Add(Me.bbiExExpenses)
        Me.rpgExDocument.ItemLinks.Add(Me.bbiExTimecard)
        Me.rpgExDocument.ItemLinks.Add(Me.bbiQuotation)
        Me.rpgExDocument.ItemLinks.Add(Me.bbiExCreate)
        Me.rpgExDocument.Name = "rpgExDocument"
        Me.rpgExDocument.Text = "ドキュメント"
        '
        'rpgExNavigation
        '
        Me.rpgExNavigation.AllowMinimize = False
        Me.rpgExNavigation.AllowTextClipping = False
        Me.rpgExNavigation.ItemLinks.Add(Me.bbiExExcel)
        Me.rpgExNavigation.ItemLinks.Add(Me.bbiExWeb)
        Me.rpgExNavigation.Name = "rpgExNavigation"
        Me.rpgExNavigation.Text = "ナビゲーション"
        '
        'rpgExEdit
        '
        Me.rpgExEdit.AllowMinimize = False
        Me.rpgExEdit.AllowTextClipping = False
        Me.rpgExEdit.ItemLinks.Add(Me.bbiNew)
        Me.rpgExEdit.ItemLinks.Add(Me.btnUndo)
        Me.rpgExEdit.ItemLinks.Add(Me.bbiSave)
        Me.rpgExEdit.ItemLinks.Add(Me.bbiExportPDF)
        Me.rpgExEdit.ItemLinks.Add(Me.bbiPrint)
        Me.rpgExEdit.ItemLinks.Add(Me.bbiMail)
        Me.rpgExEdit.Name = "rpgExEdit"
        Me.rpgExEdit.Text = "登録・編集"
        '
        'rpgQuote
        '
        Me.rpgQuote.AllowMinimize = False
        Me.rpgQuote.AllowTextClipping = False
        Me.rpgQuote.ItemLinks.Add(Me.bbiOpenQuote)
        Me.rpgQuote.ItemLinks.Add(Me.bbiQuoteDoc)
        Me.rpgQuote.ItemLinks.Add(Me.bbiCreateQuote)
        Me.rpgQuote.ItemLinks.Add(Me.bbiInvoice)
        Me.rpgQuote.ItemLinks.Add(Me.bbiMaintQuote)
        Me.rpgQuote.ItemLinks.Add(Me.bbiMaintInvoice)
        Me.rpgQuote.Name = "rpgQuote"
        Me.rpgQuote.Text = "見積書・請求書"
        '
        'rpgSettings
        '
        Me.rpgSettings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgSigmaTools, Me.rpgEdit, Me.rpgMiscSettings})
        Me.rpgSettings.Name = "rpgSettings"
        Me.rpgSettings.Text = "ツール・設定"
        '
        'rpgSigmaTools
        '
        Me.rpgSigmaTools.AllowMinimize = False
        Me.rpgSigmaTools.AllowTextClipping = False
        Me.rpgSigmaTools.ItemLinks.Add(Me.bbiTranslate)
        Me.rpgSigmaTools.Name = "rpgSigmaTools"
        Me.rpgSigmaTools.Text = "ツール"
        '
        'rpgEdit
        '
        Me.rpgEdit.AllowMinimize = False
        Me.rpgEdit.AllowTextClipping = False
        Me.rpgEdit.ItemLinks.Add(Me.bbiSave)
        Me.rpgEdit.Name = "rpgEdit"
        Me.rpgEdit.Text = "設定編集"
        '
        'rpgMiscSettings
        '
        Me.rpgMiscSettings.AllowMinimize = False
        Me.rpgMiscSettings.AllowTextClipping = False
        Me.rpgMiscSettings.ItemLinks.Add(Me.bbiSMTPSettings)
        Me.rpgMiscSettings.ItemLinks.Add(Me.bbiFTPSettings)
        Me.rpgMiscSettings.Name = "rpgMiscSettings"
        Me.rpgMiscSettings.Text = "その他設定"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemRadioGroup2
        '
        Me.RepositoryItemRadioGroup2.Columns = 2
        Me.RepositoryItemRadioGroup2.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "見積書"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "請求書"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "保守見積書"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "保守請求書")})
        Me.RepositoryItemRadioGroup2.Name = "RepositoryItemRadioGroup2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiVersion)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiStatus)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiVPNStatus, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bsiGDriveStatus, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.beiSearch, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.bbiSearch)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 948)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.rbnMain
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1270, 31)
        '
        'chkTikClosed
        '
        Me.chkTikClosed.Location = New System.Drawing.Point(785, 7)
        Me.chkTikClosed.MenuManager = Me.rbnMain
        Me.chkTikClosed.Name = "chkTikClosed"
        Me.chkTikClosed.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.chkTikClosed.Properties.Appearance.Options.UseFont = True
        Me.chkTikClosed.Properties.Caption = "解決済み"
        Me.chkTikClosed.Size = New System.Drawing.Size(118, 19)
        Me.chkTikClosed.StyleController = Me.LayoutControl3
        Me.chkTikClosed.TabIndex = 103
        '
        'meTikSolution
        '
        Me.meTikSolution.Location = New System.Drawing.Point(76, 166)
        Me.meTikSolution.MenuManager = Me.rbnMain
        Me.meTikSolution.Name = "meTikSolution"
        Me.meTikSolution.Size = New System.Drawing.Size(695, 69)
        Me.meTikSolution.StyleController = Me.LayoutControl3
        Me.meTikSolution.TabIndex = 102
        '
        'meTikDescription
        '
        Me.meTikDescription.AllowDrop = True
        Me.meTikDescription.Location = New System.Drawing.Point(76, 41)
        Me.meTikDescription.MenuManager = Me.rbnMain
        Me.meTikDescription.Name = "meTikDescription"
        Me.meTikDescription.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.meTikDescription.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.meTikDescription.Properties.Appearance.Options.UseBackColor = True
        Me.meTikDescription.Properties.Appearance.Options.UseForeColor = True
        Me.meTikDescription.Properties.ContextMenuStrip = Me.cmsShortcuts
        Me.meTikDescription.Size = New System.Drawing.Size(695, 121)
        Me.meTikDescription.StyleController = Me.LayoutControl3
        Me.meTikDescription.TabIndex = 101
        '
        'cmsShortcuts
        '
        Me.cmsShortcuts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsSaveLog})
        Me.cmsShortcuts.Name = "cmsCustomer"
        Me.cmsShortcuts.Size = New System.Drawing.Size(99, 26)
        '
        'ttsSaveLog
        '
        Me.ttsSaveLog.Image = CType(resources.GetObject("ttsSaveLog.Image"), System.Drawing.Image)
        Me.ttsSaveLog.Name = "ttsSaveLog"
        Me.ttsSaveLog.Size = New System.Drawing.Size(98, 22)
        Me.ttsSaveLog.Text = "登録"
        '
        'txtTikTitle
        '
        Me.txtTikTitle.Location = New System.Drawing.Point(76, 7)
        Me.txtTikTitle.MenuManager = Me.rbnMain
        Me.txtTikTitle.Name = "txtTikTitle"
        Me.txtTikTitle.Size = New System.Drawing.Size(695, 20)
        Me.txtTikTitle.StyleController = Me.LayoutControl3
        Me.txtTikTitle.TabIndex = 100
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciTitle, Me.lciDescription, Me.lciSolution, Me.LayoutControlItem11, Me.EmptySpaceItem1, Me.EmptySpaceItem5, Me.lciVersion, Me.EmptySpaceItem6, Me.EmptySpaceItem7})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(910, 242)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'lciTitle
        '
        Me.lciTitle.AppearanceItemCaption.BackColor = System.Drawing.Color.White
        Me.lciTitle.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.lciTitle.AppearanceItemCaption.Options.UseBackColor = True
        Me.lciTitle.AppearanceItemCaption.Options.UseFont = True
        Me.lciTitle.Control = Me.txtTikTitle
        Me.lciTitle.Location = New System.Drawing.Point(0, 0)
        Me.lciTitle.Name = "lciTitle"
        Me.lciTitle.OptionsPrint.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent
        Me.lciTitle.OptionsPrint.AppearanceItemCaption.Options.UseBackColor = True
        Me.lciTitle.Size = New System.Drawing.Size(768, 24)
        Me.lciTitle.Text = "タイトル"
        Me.lciTitle.TextSize = New System.Drawing.Size(66, 14)
        '
        'lciDescription
        '
        Me.lciDescription.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.lciDescription.AppearanceItemCaption.Options.UseFont = True
        Me.lciDescription.Control = Me.meTikDescription
        Me.lciDescription.Location = New System.Drawing.Point(0, 34)
        Me.lciDescription.Name = "lciDescription"
        Me.lciDescription.Size = New System.Drawing.Size(768, 125)
        Me.lciDescription.Text = "説明"
        Me.lciDescription.TextSize = New System.Drawing.Size(66, 14)
        '
        'lciSolution
        '
        Me.lciSolution.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.lciSolution.AppearanceItemCaption.Options.UseFont = True
        Me.lciSolution.Control = Me.meTikSolution
        Me.lciSolution.Location = New System.Drawing.Point(0, 159)
        Me.lciSolution.Name = "lciSolution"
        Me.lciSolution.Size = New System.Drawing.Size(768, 73)
        Me.lciSolution.Text = "ソリューション"
        Me.lciSolution.TextSize = New System.Drawing.Size(66, 14)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.chkTikClosed
        Me.LayoutControlItem11.Location = New System.Drawing.Point(778, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(122, 23)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(768, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 232)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 24)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(768, 10)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'lciVersion
        '
        Me.lciVersion.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.lciVersion.AppearanceItemCaption.Options.UseFont = True
        Me.lciVersion.Control = Me.txtTikVersion
        Me.lciVersion.CustomizationFormText = "Ver:"
        Me.lciVersion.Location = New System.Drawing.Point(778, 34)
        Me.lciVersion.Name = "lciVersion"
        Me.lciVersion.Size = New System.Drawing.Size(122, 24)
        Me.lciVersion.Text = "Ver:"
        Me.lciVersion.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lciVersion.TextSize = New System.Drawing.Size(24, 14)
        Me.lciVersion.TextToControlDistance = 5
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(778, 23)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(122, 11)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(778, 58)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(122, 174)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'rtbEdit
        '
        Me.rtbEdit.BackColor = System.Drawing.Color.AliceBlue
        Me.rtbEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbEdit.EnableAutoDragDrop = True
        Me.rtbEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbEdit.Location = New System.Drawing.Point(0, 0)
        Me.rtbEdit.Name = "rtbEdit"
        Me.rtbEdit.Size = New System.Drawing.Size(910, 242)
        Me.rtbEdit.TabIndex = 1
        Me.rtbEdit.Text = ""
        '
        'cbtnQA
        '
        Me.cbtnQA.Dock = System.Windows.Forms.DockStyle.Right
        Me.cbtnQA.Location = New System.Drawing.Point(834, 0)
        Me.cbtnQA.Name = "cbtnQA"
        Me.cbtnQA.Size = New System.Drawing.Size(76, 25)
        Me.cbtnQA.TabIndex = 6
        Me.cbtnQA.Text = "QAのみ表示"
        '
        'txtSIMVersion
        '
        Me.txtSIMVersion.Location = New System.Drawing.Point(541, 5)
        Me.txtSIMVersion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSIMVersion.MenuManager = Me.rbnMain
        Me.txtSIMVersion.Name = "txtSIMVersion"
        Me.txtSIMVersion.Size = New System.Drawing.Size(99, 20)
        Me.txtSIMVersion.TabIndex = 5
        '
        'txtMaintenance
        '
        Me.txtMaintenance.Location = New System.Drawing.Point(243, 5)
        Me.txtMaintenance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaintenance.MenuManager = Me.rbnMain
        Me.txtMaintenance.Name = "txtMaintenance"
        Me.txtMaintenance.Size = New System.Drawing.Size(95, 20)
        Me.txtMaintenance.TabIndex = 4
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(436, 5)
        Me.txtVersion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVersion.MenuManager = Me.rbnMain
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(99, 20)
        Me.txtVersion.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(354, 6)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "バージョン："
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(15, 6)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(83, 17)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = "保守終了日："
        '
        'deMaintenance
        '
        Me.deMaintenance.EditValue = Nothing
        Me.deMaintenance.Location = New System.Drawing.Point(113, 5)
        Me.deMaintenance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deMaintenance.MenuManager = Me.rbnMain
        Me.deMaintenance.Name = "deMaintenance"
        Me.deMaintenance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deMaintenance.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deMaintenance.Size = New System.Drawing.Size(124, 20)
        Me.deMaintenance.TabIndex = 0
        '
        'gcCustomerLog
        '
        Me.gcCustomerLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCustomerLog.Location = New System.Drawing.Point(0, 0)
        Me.gcCustomerLog.MainView = Me.gvCustomerLog
        Me.gcCustomerLog.Name = "gcCustomerLog"
        Me.gcCustomerLog.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riEventMemo, Me.riHyperLink})
        Me.gcCustomerLog.Size = New System.Drawing.Size(910, 323)
        Me.gcCustomerLog.TabIndex = 1
        Me.gcCustomerLog.UseEmbeddedNavigator = True
        Me.gcCustomerLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCustomerLog, Me.GridView2})
        '
        'gvCustomerLog
        '
        Me.gvCustomerLog.GridControl = Me.gcCustomerLog
        Me.gvCustomerLog.Name = "gvCustomerLog"
        Me.gvCustomerLog.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvCustomerLog.OptionsCustomization.AllowGroup = False
        Me.gvCustomerLog.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvCustomerLog.OptionsView.EnableAppearanceOddRow = True
        Me.gvCustomerLog.OptionsView.RowAutoHeight = True
        Me.gvCustomerLog.OptionsView.ShowAutoFilterRow = True
        Me.gvCustomerLog.OptionsView.ShowGroupPanel = False
        '
        'riEventMemo
        '
        Me.riEventMemo.Name = "riEventMemo"
        '
        'riHyperLink
        '
        Me.riHyperLink.AutoHeight = False
        Me.riHyperLink.Name = "riHyperLink"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcCustomerLog
        Me.GridView2.Name = "GridView2"
        '
        'tabOverview
        '
        Me.tabOverview.Controls.Add(Me.wbOverview)
        Me.tabOverview.Name = "tabOverview"
        Me.tabOverview.Size = New System.Drawing.Size(910, 733)
        Me.tabOverview.Text = "顧客情報"
        '
        'wbOverview
        '
        Me.wbOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbOverview.Location = New System.Drawing.Point(0, 0)
        Me.wbOverview.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOverview.Name = "wbOverview"
        Me.wbOverview.Size = New System.Drawing.Size(910, 733)
        Me.wbOverview.TabIndex = 0
        '
        'tabSupport
        '
        Me.tabSupport.Controls.Add(Me.wbSupport)
        Me.tabSupport.Name = "tabSupport"
        Me.tabSupport.Size = New System.Drawing.Size(910, 733)
        Me.tabSupport.Text = "サポート"
        '
        'wbSupport
        '
        Me.wbSupport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbSupport.Location = New System.Drawing.Point(0, 0)
        Me.wbSupport.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbSupport.Name = "wbSupport"
        Me.wbSupport.Size = New System.Drawing.Size(910, 733)
        Me.wbSupport.TabIndex = 1
        '
        'tabMachine
        '
        Me.tabMachine.Controls.Add(Me.wbMachine)
        Me.tabMachine.Name = "tabMachine"
        Me.tabMachine.Size = New System.Drawing.Size(910, 733)
        Me.tabMachine.Text = "機械"
        '
        'wbMachine
        '
        Me.wbMachine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbMachine.Location = New System.Drawing.Point(0, 0)
        Me.wbMachine.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMachine.Name = "wbMachine"
        Me.wbMachine.Size = New System.Drawing.Size(910, 733)
        Me.wbMachine.TabIndex = 1
        '
        'gcQA
        '
        Me.gcQA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQA.Location = New System.Drawing.Point(0, 0)
        Me.gcQA.MainView = Me.gvQA
        Me.gcQA.Name = "gcQA"
        Me.gcQA.Size = New System.Drawing.Size(1264, 772)
        Me.gcQA.TabIndex = 4
        Me.gcQA.UseEmbeddedNavigator = True
        Me.gcQA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQA})
        '
        'gvQA
        '
        Me.gvQA.GridControl = Me.gcQA
        Me.gvQA.Name = "gvQA"
        Me.gvQA.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvQA.OptionsCustomization.AllowGroup = False
        Me.gvQA.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvQA.OptionsView.EnableAppearanceOddRow = True
        Me.gvQA.OptionsView.ShowAutoFilterRow = True
        Me.gvQA.OptionsView.ShowGroupPanel = False
        '
        'gcSimSum
        '
        Me.gcSimSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSimSum.Location = New System.Drawing.Point(0, 0)
        Me.gcSimSum.MainView = Me.gvSimSum
        Me.gcSimSum.Name = "gcSimSum"
        Me.gcSimSum.Size = New System.Drawing.Size(1264, 772)
        Me.gcSimSum.TabIndex = 3
        Me.gcSimSum.UseEmbeddedNavigator = True
        Me.gcSimSum.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSimSum})
        '
        'gvSimSum
        '
        Me.gvSimSum.GridControl = Me.gcSimSum
        Me.gvSimSum.Name = "gvSimSum"
        Me.gvSimSum.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvSimSum.OptionsBehavior.Editable = False
        Me.gvSimSum.OptionsCustomization.AllowGroup = False
        Me.gvSimSum.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSimSum.OptionsView.EnableAppearanceOddRow = True
        Me.gvSimSum.OptionsView.ShowAutoFilterRow = True
        Me.gvSimSum.OptionsView.ShowGroupPanel = False
        '
        'tabCustomerData
        '
        Me.tabCustomerData.Controls.Add(Me.SplitContainer9)
        Me.tabCustomerData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabCustomerData.Name = "tabCustomerData"
        Me.tabCustomerData.Size = New System.Drawing.Size(1264, 772)
        Me.tabCustomerData.Text = "CustomerData"
        '
        'SplitContainer9
        '
        Me.SplitContainer9.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer9.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer9.Name = "SplitContainer9"
        '
        'SplitContainer9.Panel1
        '
        Me.SplitContainer9.Panel1.Controls.Add(Me.gcCustomerData)
        '
        'SplitContainer9.Panel2
        '
        Me.SplitContainer9.Panel2.Controls.Add(Me.SplitContainer10)
        Me.SplitContainer9.Size = New System.Drawing.Size(1264, 772)
        Me.SplitContainer9.SplitterDistance = 851
        Me.SplitContainer9.TabIndex = 4
        '
        'gcCustomerData
        '
        Me.gcCustomerData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCustomerData.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gcCustomerData.Location = New System.Drawing.Point(0, 0)
        Me.gcCustomerData.MainView = Me.gvCustomerData
        Me.gcCustomerData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gcCustomerData.MenuManager = Me.rbnMain
        Me.gcCustomerData.Name = "gcCustomerData"
        Me.gcCustomerData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ricComboEdit, Me.ricCountryComboBox, Me.RepositoryItemHyperLinkEdit2, Me.riHyperLinkMail})
        Me.gcCustomerData.Size = New System.Drawing.Size(851, 772)
        Me.gcCustomerData.TabIndex = 3
        Me.gcCustomerData.UseEmbeddedNavigator = True
        Me.gcCustomerData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCustomerData})
        '
        'gvCustomerData
        '
        Me.gvCustomerData.GridControl = Me.gcCustomerData
        Me.gvCustomerData.Name = "gvCustomerData"
        Me.gvCustomerData.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvCustomerData.OptionsSelection.MultiSelect = True
        Me.gvCustomerData.OptionsView.ColumnAutoWidth = False
        Me.gvCustomerData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvCustomerData.OptionsView.ShowAutoFilterRow = True
        '
        'ricComboEdit
        '
        Me.ricComboEdit.AutoHeight = False
        Me.ricComboEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ricComboEdit.Name = "ricComboEdit"
        '
        'ricCountryComboBox
        '
        Me.ricCountryComboBox.AutoHeight = False
        Me.ricCountryComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ricCountryComboBox.Name = "ricCountryComboBox"
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        Me.RepositoryItemHyperLinkEdit2.SingleClick = True
        '
        'riHyperLinkMail
        '
        Me.riHyperLinkMail.AutoHeight = False
        Me.riHyperLinkMail.Name = "riHyperLinkMail"
        Me.riHyperLinkMail.SingleClick = True
        '
        'SplitContainer10
        '
        Me.SplitContainer10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer10.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer10.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer10.Name = "SplitContainer10"
        Me.SplitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer10.Panel1
        '
        Me.SplitContainer10.Panel1.Controls.Add(Me.imageMap)
        '
        'SplitContainer10.Panel2
        '
        Me.SplitContainer10.Panel2.Controls.Add(Me.webBrowser)
        Me.SplitContainer10.Panel2.Controls.Add(Me.picCard)
        Me.SplitContainer10.Panel2MinSize = 230
        Me.SplitContainer10.Size = New System.Drawing.Size(409, 772)
        Me.SplitContainer10.SplitterDistance = 539
        Me.SplitContainer10.SplitterWidth = 3
        Me.SplitContainer10.TabIndex = 0
        '
        'imageMap
        '
        Me.imageMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imageMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imageMap.InitialImage = Nothing
        Me.imageMap.Location = New System.Drawing.Point(0, 0)
        Me.imageMap.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.imageMap.Name = "imageMap"
        Me.imageMap.Size = New System.Drawing.Size(409, 539)
        Me.imageMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imageMap.TabIndex = 4
        Me.imageMap.TabStop = False
        '
        'webBrowser
        '
        Me.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.ScriptErrorsSuppressed = True
        Me.webBrowser.Size = New System.Drawing.Size(409, 230)
        Me.webBrowser.TabIndex = 3
        '
        'picCard
        '
        Me.picCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCard.Location = New System.Drawing.Point(0, 0)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(409, 230)
        Me.picCard.TabIndex = 2
        Me.picCard.TabStop = False
        '
        'tabCompanySearch
        '
        Me.tabCompanySearch.Name = "tabCompanySearch"
        Me.tabCompanySearch.Size = New System.Drawing.Size(1264, 772)
        Me.tabCompanySearch.Text = "Company"
        '
        'tabSaleslogix
        '
        Me.tabSaleslogix.Controls.Add(Me.gcSalesLogix)
        Me.tabSaleslogix.Name = "tabSaleslogix"
        Me.tabSaleslogix.Size = New System.Drawing.Size(1264, 772)
        Me.tabSaleslogix.Text = "Saleslogix"
        '
        'gcSalesLogix
        '
        Me.gcSalesLogix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSalesLogix.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gcSalesLogix.Location = New System.Drawing.Point(0, 0)
        Me.gcSalesLogix.MainView = Me.gvSalesLogix
        Me.gcSalesLogix.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gcSalesLogix.MenuManager = Me.rbnMain
        Me.gcSalesLogix.Name = "gcSalesLogix"
        Me.gcSalesLogix.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemHyperLinkEdit5, Me.RepositoryItemHyperLinkEdit6})
        Me.gcSalesLogix.Size = New System.Drawing.Size(1264, 772)
        Me.gcSalesLogix.TabIndex = 5
        Me.gcSalesLogix.UseEmbeddedNavigator = True
        Me.gcSalesLogix.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSalesLogix})
        '
        'gvSalesLogix
        '
        Me.gvSalesLogix.GridControl = Me.gcSalesLogix
        Me.gvSalesLogix.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Owner", Nothing, "")})
        Me.gvSalesLogix.Name = "gvSalesLogix"
        Me.gvSalesLogix.OptionsBehavior.Editable = False
        Me.gvSalesLogix.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSalesLogix.OptionsSelection.MultiSelect = True
        Me.gvSalesLogix.OptionsView.EnableAppearanceEvenRow = True
        Me.gvSalesLogix.OptionsView.ShowAutoFilterRow = True
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        '
        'RepositoryItemHyperLinkEdit5
        '
        Me.RepositoryItemHyperLinkEdit5.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit5.Name = "RepositoryItemHyperLinkEdit5"
        Me.RepositoryItemHyperLinkEdit5.SingleClick = True
        '
        'RepositoryItemHyperLinkEdit6
        '
        Me.RepositoryItemHyperLinkEdit6.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit6.Name = "RepositoryItemHyperLinkEdit6"
        Me.RepositoryItemHyperLinkEdit6.SingleClick = True
        '
        'tabSigmaNEST
        '
        Me.tabSigmaNEST.Controls.Add(Me.splApplications)
        Me.tabSigmaNEST.Name = "tabSigmaNEST"
        Me.tabSigmaNEST.Size = New System.Drawing.Size(1264, 772)
        Me.tabSigmaNEST.Text = "SigmaNEST"
        '
        'splApplications
        '
        Me.splApplications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splApplications.Location = New System.Drawing.Point(0, 0)
        Me.splApplications.Margin = New System.Windows.Forms.Padding(2)
        Me.splApplications.Name = "splApplications"
        '
        'splApplications.Panel1
        '
        Me.splApplications.Panel1.Controls.Add(Me.gcSigmaNEST)
        '
        'splApplications.Panel2
        '
        Me.splApplications.Panel2.Controls.Add(Me.SplitContainer1)
        Me.splApplications.Size = New System.Drawing.Size(1264, 772)
        Me.splApplications.SplitterDistance = 602
        Me.splApplications.SplitterWidth = 3
        Me.splApplications.TabIndex = 3
        '
        'gcSigmaNEST
        '
        Me.gcSigmaNEST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSigmaNEST.Location = New System.Drawing.Point(0, 0)
        Me.gcSigmaNEST.MainView = Me.gvSigmaNEST
        Me.gcSigmaNEST.Name = "gcSigmaNEST"
        Me.gcSigmaNEST.Size = New System.Drawing.Size(602, 772)
        Me.gcSigmaNEST.TabIndex = 0
        Me.gcSigmaNEST.UseEmbeddedNavigator = True
        Me.gcSigmaNEST.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSigmaNEST})
        '
        'gvSigmaNEST
        '
        Me.gvSigmaNEST.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSigmaNEST.Appearance.Row.Options.UseFont = True
        Me.gvSigmaNEST.GridControl = Me.gcSigmaNEST
        Me.gvSigmaNEST.Name = "gvSigmaNEST"
        Me.gvSigmaNEST.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvSigmaNEST.OptionsBehavior.Editable = False
        Me.gvSigmaNEST.OptionsCustomization.AllowGroup = False
        Me.gvSigmaNEST.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSigmaNEST.OptionsSelection.MultiSelect = True
        Me.gvSigmaNEST.OptionsView.EnableAppearanceOddRow = True
        Me.gvSigmaNEST.OptionsView.RowAutoHeight = True
        Me.gvSigmaNEST.OptionsView.ShowGroupPanel = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gcProducts)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlClock)
        Me.SplitContainer1.Size = New System.Drawing.Size(659, 772)
        Me.SplitContainer1.SplitterDistance = 585
        Me.SplitContainer1.TabIndex = 0
        '
        'gcProducts
        '
        Me.gcProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcProducts.Location = New System.Drawing.Point(0, 0)
        Me.gcProducts.MainView = Me.gvProducts
        Me.gcProducts.Name = "gcProducts"
        Me.gcProducts.Size = New System.Drawing.Size(659, 585)
        Me.gcProducts.TabIndex = 1
        Me.gcProducts.UseEmbeddedNavigator = True
        Me.gcProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProducts})
        '
        'gvProducts
        '
        Me.gvProducts.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvProducts.Appearance.Row.Options.UseFont = True
        Me.gvProducts.GridControl = Me.gcProducts
        Me.gvProducts.Name = "gvProducts"
        Me.gvProducts.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvProducts.OptionsBehavior.Editable = False
        Me.gvProducts.OptionsCustomization.AllowGroup = False
        Me.gvProducts.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvProducts.OptionsSelection.MultiSelect = True
        Me.gvProducts.OptionsView.EnableAppearanceOddRow = True
        Me.gvProducts.OptionsView.RowAutoHeight = True
        Me.gvProducts.OptionsView.ShowGroupPanel = False
        '
        'pnlClock
        '
        Me.pnlClock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlClock.Location = New System.Drawing.Point(0, 0)
        Me.pnlClock.Name = "pnlClock"
        Me.pnlClock.Size = New System.Drawing.Size(659, 183)
        Me.pnlClock.TabIndex = 0
        '
        'tabApps
        '
        Me.tabApps.Controls.Add(Me.SplitContainer5)
        Me.tabApps.Name = "tabApps"
        Me.tabApps.Size = New System.Drawing.Size(1264, 772)
        Me.tabApps.Text = "Apps"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.gcApps)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.recApp)
        Me.SplitContainer5.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer5.Size = New System.Drawing.Size(1264, 772)
        Me.SplitContainer5.SplitterDistance = 340
        Me.SplitContainer5.SplitterWidth = 3
        Me.SplitContainer5.TabIndex = 3
        '
        'gcApps
        '
        Me.gcApps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcApps.Location = New System.Drawing.Point(0, 0)
        Me.gcApps.MainView = Me.gvApps
        Me.gcApps.Name = "gcApps"
        Me.gcApps.Size = New System.Drawing.Size(340, 772)
        Me.gcApps.TabIndex = 0
        Me.gcApps.UseEmbeddedNavigator = True
        Me.gcApps.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvApps})
        '
        'gvApps
        '
        Me.gvApps.GridControl = Me.gcApps
        Me.gvApps.Name = "gvApps"
        Me.gvApps.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvApps.OptionsBehavior.Editable = False
        Me.gvApps.OptionsCustomization.AllowGroup = False
        Me.gvApps.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvApps.OptionsView.ColumnAutoWidth = False
        Me.gvApps.OptionsView.EnableAppearanceOddRow = True
        Me.gvApps.OptionsView.ShowAutoFilterRow = True
        Me.gvApps.OptionsView.ShowGroupPanel = False
        '
        'recApp
        '
        Me.recApp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recApp.EnableToolTips = True
        Me.recApp.Location = New System.Drawing.Point(5, 5)
        Me.recApp.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.recApp.MenuManager = Me.rbnMain
        Me.recApp.Name = "recApp"
        Me.recApp.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
        Me.recApp.Options.Fields.UpdateFieldsInTextBoxes = False
        Me.recApp.Size = New System.Drawing.Size(911, 762)
        Me.recApp.TabIndex = 2
        '
        'tabDemo
        '
        Me.tabDemo.Appearance.PageClient.BackColor = System.Drawing.Color.Gray
        Me.tabDemo.Appearance.PageClient.Options.UseBackColor = True
        Me.tabDemo.Controls.Add(Me.SplitContainer8)
        Me.tabDemo.Name = "tabDemo"
        Me.tabDemo.Size = New System.Drawing.Size(1264, 772)
        Me.tabDemo.Text = "Demo"
        '
        'SplitContainer8
        '
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer8.Name = "SplitContainer8"
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.Controls.Add(Me.gcDemoMachine)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.Controls.Add(Me.gcDemoFeatures)
        Me.SplitContainer8.Size = New System.Drawing.Size(1264, 772)
        Me.SplitContainer8.SplitterDistance = 605
        Me.SplitContainer8.TabIndex = 0
        '
        'gcDemoMachine
        '
        Me.gcDemoMachine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDemoMachine.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcDemoMachine.Location = New System.Drawing.Point(0, 0)
        Me.gcDemoMachine.MainView = Me.gvDemoMachine
        Me.gcDemoMachine.Name = "gcDemoMachine"
        Me.gcDemoMachine.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riPicM})
        Me.gcDemoMachine.Size = New System.Drawing.Size(605, 772)
        Me.gcDemoMachine.TabIndex = 1
        Me.gcDemoMachine.UseEmbeddedNavigator = True
        Me.gcDemoMachine.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDemoMachine})
        '
        'gvDemoMachine
        '
        Me.gvDemoMachine.Appearance.Row.Font = New System.Drawing.Font("Meiryo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvDemoMachine.Appearance.Row.Options.UseFont = True
        Me.gvDemoMachine.GridControl = Me.gcDemoMachine
        Me.gvDemoMachine.Name = "gvDemoMachine"
        Me.gvDemoMachine.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvDemoMachine.OptionsBehavior.Editable = False
        Me.gvDemoMachine.OptionsCustomization.AllowGroup = False
        Me.gvDemoMachine.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDemoMachine.OptionsView.RowAutoHeight = True
        Me.gvDemoMachine.OptionsView.ShowAutoFilterRow = True
        Me.gvDemoMachine.OptionsView.ShowGroupPanel = False
        '
        'riPicM
        '
        Me.riPicM.Name = "riPicM"
        '
        'gcDemoFeatures
        '
        Me.gcDemoFeatures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDemoFeatures.Location = New System.Drawing.Point(0, 0)
        Me.gcDemoFeatures.MainView = Me.gvDemoFeatures
        Me.gcDemoFeatures.Name = "gcDemoFeatures"
        Me.gcDemoFeatures.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riPicF})
        Me.gcDemoFeatures.Size = New System.Drawing.Size(655, 772)
        Me.gcDemoFeatures.TabIndex = 1
        Me.gcDemoFeatures.UseEmbeddedNavigator = True
        Me.gcDemoFeatures.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDemoFeatures})
        '
        'gvDemoFeatures
        '
        Me.gvDemoFeatures.Appearance.Row.Font = New System.Drawing.Font("Meiryo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gvDemoFeatures.Appearance.Row.Options.UseFont = True
        Me.gvDemoFeatures.GridControl = Me.gcDemoFeatures
        Me.gvDemoFeatures.Name = "gvDemoFeatures"
        Me.gvDemoFeatures.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvDemoFeatures.OptionsBehavior.Editable = False
        Me.gvDemoFeatures.OptionsCustomization.AllowGroup = False
        Me.gvDemoFeatures.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDemoFeatures.OptionsView.RowAutoHeight = True
        Me.gvDemoFeatures.OptionsView.ShowAutoFilterRow = True
        Me.gvDemoFeatures.OptionsView.ShowGroupPanel = False
        '
        'riPicF
        '
        Me.riPicF.Name = "riPicF"
        '
        'tabMail
        '
        Me.tabMail.Controls.Add(Me.splMailMain)
        Me.tabMail.Name = "tabMail"
        Me.tabMail.Size = New System.Drawing.Size(1264, 772)
        Me.tabMail.Text = "Mail"
        '
        'splMailMain
        '
        Me.splMailMain.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.splMailMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splMailMain.Location = New System.Drawing.Point(0, 0)
        Me.splMailMain.Margin = New System.Windows.Forms.Padding(2)
        Me.splMailMain.Name = "splMailMain"
        Me.splMailMain.Panel1.Controls.Add(Me.GroupControl2)
        Me.splMailMain.Panel1.Text = "Panel1"
        Me.splMailMain.Panel2.Controls.Add(Me.gcMailTemplate)
        Me.splMailMain.Panel2.Text = "Panel2"
        Me.splMailMain.Size = New System.Drawing.Size(1264, 772)
        Me.splMailMain.SplitterPosition = 235
        Me.splMailMain.TabIndex = 5
        Me.splMailMain.Text = "SplitContainerControl1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LayoutControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(235, 772)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "メールテンプレート"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.rtbBody)
        Me.LayoutControl1.Controls.Add(Me.LabelControl3)
        Me.LayoutControl1.Controls.Add(Me.LabelControl2)
        Me.LayoutControl1.Controls.Add(Me.txtSubject)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(2, 21)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(231, 749)
        Me.LayoutControl1.TabIndex = 18
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'rtbBody
        '
        Me.rtbBody.BackColor = System.Drawing.Color.White
        Me.rtbBody.EnableAutoDragDrop = True
        Me.rtbBody.Location = New System.Drawing.Point(12, 72)
        Me.rtbBody.Name = "rtbBody"
        Me.rtbBody.Size = New System.Drawing.Size(207, 665)
        Me.rtbBody.TabIndex = 18
        Me.rtbBody.Text = ""
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 14)
        Me.LabelControl3.StyleController = Me.LayoutControl1
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "件名"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl2.StyleController = Me.LayoutControl1
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "ボディ"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(12, 30)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(207, 20)
        Me.txtSubject.StyleController = Me.LayoutControl1
        Me.txtSubject.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(231, 749)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LabelControl3
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(211, 18)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.LabelControl2
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(211, 18)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtSubject
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 18)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(211, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.rtbBody
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(211, 669)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'gcMailTemplate
        '
        Me.gcMailTemplate.AllowDrop = True
        Me.gcMailTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcMailTemplate.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.gcMailTemplate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gcMailTemplate.Location = New System.Drawing.Point(0, 0)
        Me.gcMailTemplate.MainView = Me.gvMailTemplate
        Me.gcMailTemplate.Margin = New System.Windows.Forms.Padding(2)
        Me.gcMailTemplate.Name = "gcMailTemplate"
        Me.gcMailTemplate.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.riEventType, Me.riEventAttachment})
        Me.gcMailTemplate.Size = New System.Drawing.Size(1024, 772)
        Me.gcMailTemplate.TabIndex = 4
        Me.gcMailTemplate.UseEmbeddedNavigator = True
        Me.gcMailTemplate.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMailTemplate})
        '
        'gvMailTemplate
        '
        Me.gvMailTemplate.GridControl = Me.gcMailTemplate
        Me.gvMailTemplate.Name = "gvMailTemplate"
        Me.gvMailTemplate.OptionsBehavior.Editable = False
        Me.gvMailTemplate.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvMailTemplate.OptionsView.ColumnAutoWidth = False
        Me.gvMailTemplate.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMailTemplate.OptionsView.RowAutoHeight = True
        Me.gvMailTemplate.OptionsView.ShowAutoFilterRow = True
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'riEventType
        '
        Me.riEventType.AutoHeight = False
        Me.riEventType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riEventType.Name = "riEventType"
        '
        'riEventAttachment
        '
        Me.riEventAttachment.Name = "riEventAttachment"
        '
        'tabDocuments
        '
        Me.tabDocuments.Controls.Add(Me.SplitContainer6)
        Me.tabDocuments.Name = "tabDocuments"
        Me.tabDocuments.Size = New System.Drawing.Size(1264, 772)
        Me.tabDocuments.Text = "Documents"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.tlDocuments)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.docViewer)
        Me.SplitContainer6.Panel2.Controls.Add(Me.pdfViewer)
        Me.SplitContainer6.Panel2.Controls.Add(Me.xlsData)
        Me.SplitContainer6.Size = New System.Drawing.Size(1264, 772)
        Me.SplitContainer6.SplitterDistance = 327
        Me.SplitContainer6.TabIndex = 0
        '
        'tlDocuments
        '
        Me.tlDocuments.AllowDrop = True
        Me.tlDocuments.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colName, Me.colPath, Me.colType, Me.colSize})
        Me.tlDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlDocuments.Location = New System.Drawing.Point(0, 0)
        Me.tlDocuments.Name = "tlDocuments"
        Me.tlDocuments.OptionsBehavior.Editable = False
        Me.tlDocuments.OptionsView.EnableAppearanceEvenRow = True
        Me.tlDocuments.Size = New System.Drawing.Size(327, 772)
        Me.tlDocuments.StateImageList = Me.imageCollection1
        Me.tlDocuments.TabIndex = 2
        '
        'colName
        '
        Me.colName.Caption = "Name"
        Me.colName.FieldName = "Name"
        Me.colName.MinWidth = 49
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        Me.colName.Width = 253
        '
        'colPath
        '
        Me.colPath.Caption = "Path"
        Me.colPath.FieldName = "Path"
        Me.colPath.Name = "colPath"
        Me.colPath.Visible = True
        Me.colPath.VisibleIndex = 3
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 1
        Me.colType.Width = 28
        '
        'colSize
        '
        Me.colSize.Caption = "Size(Bytes)"
        Me.colSize.FieldName = "Size"
        Me.colSize.Name = "colSize"
        Me.colSize.Visible = True
        Me.colSize.VisibleIndex = 2
        Me.colSize.Width = 28
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection1.Images.SetKeyName(0, "Folder_Closed.png")
        Me.imageCollection1.Images.SetKeyName(1, "Folder_Opened.png")
        Me.imageCollection1.Images.SetKeyName(2, "File.png")
        Me.imageCollection1.Images.SetKeyName(3, "Local_Disk.png")
        '
        'docViewer
        '
        Me.docViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.docViewer.EnableToolTips = True
        Me.docViewer.Location = New System.Drawing.Point(0, 0)
        Me.docViewer.MenuManager = Me.rbnMain
        Me.docViewer.Name = "docViewer"
        Me.docViewer.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
        Me.docViewer.Options.Fields.UpdateFieldsInTextBoxes = False
        Me.docViewer.Size = New System.Drawing.Size(933, 772)
        Me.docViewer.TabIndex = 9
        '
        'pdfViewer
        '
        Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
        Me.pdfViewer.Name = "pdfViewer"
        Me.pdfViewer.Size = New System.Drawing.Size(933, 772)
        Me.pdfViewer.TabIndex = 10
        '
        'xlsData
        '
        Me.xlsData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xlsData.Location = New System.Drawing.Point(0, 0)
        Me.xlsData.MenuManager = Me.rbnMain
        Me.xlsData.Name = "xlsData"
        Me.xlsData.Size = New System.Drawing.Size(933, 772)
        Me.xlsData.TabIndex = 7
        Me.xlsData.Text = "SpreadsheetControl1"
        '
        'tabWeb
        '
        Me.tabWeb.Controls.Add(Me.SplitContainerControl1)
        Me.tabWeb.Name = "tabWeb"
        Me.tabWeb.Size = New System.Drawing.Size(1264, 772)
        Me.tabWeb.Text = "Web"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcWebLink)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1264, 772)
        Me.SplitContainerControl1.SplitterPosition = 238
        Me.SplitContainerControl1.TabIndex = 6
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.LayoutControl2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(238, 772)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "ウェブリンク"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.LabelControl6)
        Me.LayoutControl2.Controls.Add(Me.cmbWebType)
        Me.LayoutControl2.Controls.Add(Me.LabelControl4)
        Me.LayoutControl2.Controls.Add(Me.txtWebLink)
        Me.LayoutControl2.Controls.Add(Me.LabelControl5)
        Me.LayoutControl2.Controls.Add(Me.txtWebDescription)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(2, 21)
        Me.LayoutControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(234, 749)
        Me.LayoutControl2.TabIndex = 21
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(29, 14)
        Me.LabelControl6.StyleController = Me.LayoutControl2
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "タイプ"
        '
        'cmbWebType
        '
        Me.cmbWebType.Location = New System.Drawing.Point(12, 30)
        Me.cmbWebType.MenuManager = Me.rbnMain
        Me.cmbWebType.Name = "cmbWebType"
        Me.cmbWebType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbWebType.Size = New System.Drawing.Size(210, 20)
        Me.cmbWebType.StyleController = Me.LayoutControl2
        Me.cmbWebType.TabIndex = 20
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 96)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 14)
        Me.LabelControl4.StyleController = Me.LayoutControl2
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "リンク先"
        '
        'txtWebLink
        '
        Me.txtWebLink.Location = New System.Drawing.Point(12, 114)
        Me.txtWebLink.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWebLink.Name = "txtWebLink"
        Me.txtWebLink.Size = New System.Drawing.Size(210, 20)
        Me.txtWebLink.StyleController = Me.LayoutControl2
        Me.txtWebLink.TabIndex = 18
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(26, 14)
        Me.LabelControl5.StyleController = Me.LayoutControl2
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "説明"
        '
        'txtWebDescription
        '
        Me.txtWebDescription.Location = New System.Drawing.Point(12, 72)
        Me.txtWebDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWebDescription.Name = "txtWebDescription"
        Me.txtWebDescription.Size = New System.Drawing.Size(210, 20)
        Me.txtWebDescription.StyleController = Me.LayoutControl2
        Me.txtWebDescription.TabIndex = 1
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(234, 749)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LabelControl6
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(214, 18)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.LabelControl5
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(214, 18)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.LabelControl4
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(214, 18)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmbWebType
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 18)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(214, 24)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtWebLink
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(214, 627)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtWebDescription
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(214, 24)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'gcWebLink
        '
        Me.gcWebLink.AllowDrop = True
        Me.gcWebLink.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcWebLink.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.gcWebLink.Location = New System.Drawing.Point(0, 0)
        Me.gcWebLink.MainView = Me.gvWebLink
        Me.gcWebLink.Margin = New System.Windows.Forms.Padding(2)
        Me.gcWebLink.Name = "gcWebLink"
        Me.gcWebLink.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riHyperlink2})
        Me.gcWebLink.Size = New System.Drawing.Size(1021, 772)
        Me.gcWebLink.TabIndex = 4
        Me.gcWebLink.UseEmbeddedNavigator = True
        Me.gcWebLink.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvWebLink})
        '
        'gvWebLink
        '
        Me.gvWebLink.GridControl = Me.gcWebLink
        Me.gvWebLink.Name = "gvWebLink"
        Me.gvWebLink.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvWebLink.OptionsView.ColumnAutoWidth = False
        Me.gvWebLink.OptionsView.EnableAppearanceEvenRow = True
        Me.gvWebLink.OptionsView.RowAutoHeight = True
        Me.gvWebLink.OptionsView.ShowAutoFilterRow = True
        '
        'riHyperlink2
        '
        Me.riHyperlink2.AutoHeight = False
        Me.riHyperlink2.Name = "riHyperlink2"
        '
        'tabVideo
        '
        Me.tabVideo.Controls.Add(Me.SplitContainer17)
        Me.tabVideo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabVideo.Name = "tabVideo"
        Me.tabVideo.Size = New System.Drawing.Size(1264, 772)
        Me.tabVideo.Text = "Video"
        '
        'SplitContainer17
        '
        Me.SplitContainer17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer17.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer17.Name = "SplitContainer17"
        '
        'SplitContainer17.Panel1
        '
        Me.SplitContainer17.Panel1.Controls.Add(Me.gcVideo)
        '
        'SplitContainer17.Panel2
        '
        Me.SplitContainer17.Panel2.Controls.Add(Me.picImage)
        Me.SplitContainer17.Size = New System.Drawing.Size(1264, 772)
        Me.SplitContainer17.SplitterDistance = 419
        Me.SplitContainer17.TabIndex = 0
        '
        'gcVideo
        '
        Me.gcVideo.AllowDrop = True
        Me.gcVideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcVideo.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.gcVideo.Location = New System.Drawing.Point(0, 0)
        Me.gcVideo.MainView = Me.gvVideo
        Me.gcVideo.Margin = New System.Windows.Forms.Padding(2)
        Me.gcVideo.Name = "gcVideo"
        Me.gcVideo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.gcVideo.Size = New System.Drawing.Size(419, 772)
        Me.gcVideo.TabIndex = 6
        Me.gcVideo.UseEmbeddedNavigator = True
        Me.gcVideo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVideo})
        '
        'gvVideo
        '
        Me.gvVideo.GridControl = Me.gcVideo
        Me.gvVideo.Name = "gvVideo"
        Me.gvVideo.OptionsBehavior.Editable = False
        Me.gvVideo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvVideo.OptionsView.EnableAppearanceEvenRow = True
        Me.gvVideo.OptionsView.RowAutoHeight = True
        Me.gvVideo.OptionsView.ShowAutoFilterRow = True
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'picImage
        '
        Me.picImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picImage.Location = New System.Drawing.Point(0, 0)
        Me.picImage.MenuManager = Me.rbnMain
        Me.picImage.Name = "picImage"
        Me.picImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picImage.Size = New System.Drawing.Size(841, 772)
        Me.picImage.TabIndex = 0
        '
        'tabExpenses
        '
        Me.tabExpenses.Controls.Add(Me.SplitContainer14)
        Me.tabExpenses.Name = "tabExpenses"
        Me.tabExpenses.Size = New System.Drawing.Size(1264, 772)
        Me.tabExpenses.Text = "Expenses"
        '
        'SplitContainer14
        '
        Me.SplitContainer14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer14.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer14.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer14.Name = "SplitContainer14"
        '
        'SplitContainer14.Panel1
        '
        Me.SplitContainer14.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer14.Panel1.Controls.Add(Me.xtcCompanyTools)
        '
        'SplitContainer14.Panel2
        '
        Me.SplitContainer14.Panel2.Controls.Add(Me.splMonth)
        Me.SplitContainer14.Size = New System.Drawing.Size(1264, 772)
        Me.SplitContainer14.SplitterDistance = 371
        Me.SplitContainer14.TabIndex = 0
        '
        'xtcCompanyTools
        '
        Me.xtcCompanyTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcCompanyTools.Location = New System.Drawing.Point(0, 0)
        Me.xtcCompanyTools.Name = "xtcCompanyTools"
        Me.xtcCompanyTools.SelectedTabPage = Me.tabMyExpenses
        Me.xtcCompanyTools.Size = New System.Drawing.Size(371, 772)
        Me.xtcCompanyTools.TabIndex = 12
        Me.xtcCompanyTools.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabMyExpenses, Me.tabSalesTools})
        '
        'tabMyExpenses
        '
        Me.tabMyExpenses.Controls.Add(Me.GroupControl7)
        Me.tabMyExpenses.Controls.Add(Me.GroupControl4)
        Me.tabMyExpenses.Controls.Add(Me.GroupControl5)
        Me.tabMyExpenses.Controls.Add(Me.GroupControl6)
        Me.tabMyExpenses.Name = "tabMyExpenses"
        Me.tabMyExpenses.Size = New System.Drawing.Size(365, 743)
        Me.tabMyExpenses.Text = "経費"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.LabelControl27)
        Me.GroupControl7.Controls.Add(Me.LabelControl23)
        Me.GroupControl7.Controls.Add(Me.txtExAdvertising)
        Me.GroupControl7.Controls.Add(Me.txtExMisc)
        Me.GroupControl7.Controls.Add(Me.LabelControl32)
        Me.GroupControl7.Controls.Add(Me.txtExGift)
        Me.GroupControl7.Controls.Add(Me.LabelControl25)
        Me.GroupControl7.Controls.Add(Me.txtExRevenue)
        Me.GroupControl7.Controls.Add(Me.txtExPostal)
        Me.GroupControl7.Controls.Add(Me.LabelControl28)
        Me.GroupControl7.Controls.Add(Me.LabelControl31)
        Me.GroupControl7.Controls.Add(Me.txtExOvPostal)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl7.Location = New System.Drawing.Point(0, 417)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(365, 102)
        Me.GroupControl7.TabIndex = 29
        Me.GroupControl7.Text = "その他"
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Location = New System.Drawing.Point(15, 55)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl27.TabIndex = 24
        Me.LabelControl27.Text = "広告費："
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Location = New System.Drawing.Point(200, 81)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl23.TabIndex = 34
        Me.LabelControl23.Text = "その他："
        '
        'txtExAdvertising
        '
        Me.txtExAdvertising.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExAdvertising.Location = New System.Drawing.Point(94, 51)
        Me.txtExAdvertising.MenuManager = Me.rbnMain
        Me.txtExAdvertising.Name = "txtExAdvertising"
        Me.txtExAdvertising.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExAdvertising.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExAdvertising.Size = New System.Drawing.Size(77, 20)
        Me.txtExAdvertising.TabIndex = 30
        '
        'txtExMisc
        '
        Me.txtExMisc.Location = New System.Drawing.Point(279, 77)
        Me.txtExMisc.MenuManager = Me.rbnMain
        Me.txtExMisc.Name = "txtExMisc"
        Me.txtExMisc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExMisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExMisc.Size = New System.Drawing.Size(77, 20)
        Me.txtExMisc.TabIndex = 33
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl32.Location = New System.Drawing.Point(15, 81)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl32.TabIndex = 32
        Me.LabelControl32.Text = "土産/接待費："
        '
        'txtExGift
        '
        Me.txtExGift.Location = New System.Drawing.Point(94, 77)
        Me.txtExGift.MenuManager = Me.rbnMain
        Me.txtExGift.Name = "txtExGift"
        Me.txtExGift.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExGift.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExGift.Size = New System.Drawing.Size(77, 20)
        Me.txtExGift.TabIndex = 32
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Location = New System.Drawing.Point(200, 55)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl25.TabIndex = 30
        Me.LabelControl25.Text = "印紙代："
        '
        'txtExRevenue
        '
        Me.txtExRevenue.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExRevenue.Location = New System.Drawing.Point(279, 51)
        Me.txtExRevenue.MenuManager = Me.rbnMain
        Me.txtExRevenue.Name = "txtExRevenue"
        Me.txtExRevenue.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExRevenue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExRevenue.Size = New System.Drawing.Size(77, 20)
        Me.txtExRevenue.TabIndex = 31
        '
        'txtExPostal
        '
        Me.txtExPostal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExPostal.Location = New System.Drawing.Point(94, 25)
        Me.txtExPostal.MenuManager = Me.rbnMain
        Me.txtExPostal.Name = "txtExPostal"
        Me.txtExPostal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExPostal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExPostal.Size = New System.Drawing.Size(77, 20)
        Me.txtExPostal.TabIndex = 28
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Location = New System.Drawing.Point(200, 29)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl28.TabIndex = 20
        Me.LabelControl28.Text = "海外郵送："
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl31.Location = New System.Drawing.Point(15, 29)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl31.TabIndex = 18
        Me.LabelControl31.Text = "国内郵送代金："
        '
        'txtExOvPostal
        '
        Me.txtExOvPostal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExOvPostal.Location = New System.Drawing.Point(279, 25)
        Me.txtExOvPostal.MenuManager = Me.rbnMain
        Me.txtExOvPostal.Name = "txtExOvPostal"
        Me.txtExOvPostal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExOvPostal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExOvPostal.Size = New System.Drawing.Size(77, 20)
        Me.txtExOvPostal.TabIndex = 29
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.cmbExLocEnd)
        Me.GroupControl4.Controls.Add(Me.cmbExLocStart)
        Me.GroupControl4.Controls.Add(Me.txtExGas)
        Me.GroupControl4.Controls.Add(Me.LabelControl18)
        Me.GroupControl4.Controls.Add(Me.LabelControl22)
        Me.GroupControl4.Controls.Add(Me.txtExCarRental)
        Me.GroupControl4.Controls.Add(Me.LabelControl20)
        Me.GroupControl4.Controls.Add(Me.txtExCarMiles)
        Me.GroupControl4.Controls.Add(Me.LabelControl21)
        Me.GroupControl4.Controls.Add(Me.txtExParking)
        Me.GroupControl4.Controls.Add(Me.LabelControl19)
        Me.GroupControl4.Controls.Add(Me.rdoTransporation)
        Me.GroupControl4.Controls.Add(Me.txtExTaxi)
        Me.GroupControl4.Controls.Add(Me.btnExSearch)
        Me.GroupControl4.Controls.Add(Me.LabelControl17)
        Me.GroupControl4.Controls.Add(Me.LabelControl14)
        Me.GroupControl4.Controls.Add(Me.txtExHighway)
        Me.GroupControl4.Controls.Add(Me.txtExTrain)
        Me.GroupControl4.Controls.Add(Me.LabelControl16)
        Me.GroupControl4.Controls.Add(Me.LabelControl15)
        Me.GroupControl4.Controls.Add(Me.txtExAir)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(0, 231)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(365, 186)
        Me.GroupControl4.TabIndex = 17
        Me.GroupControl4.Text = "交通費"
        '
        'cmbExLocEnd
        '
        Me.cmbExLocEnd.Location = New System.Drawing.Point(197, 25)
        Me.cmbExLocEnd.MenuManager = Me.rbnMain
        Me.cmbExLocEnd.Name = "cmbExLocEnd"
        Me.cmbExLocEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbExLocEnd.Size = New System.Drawing.Size(156, 20)
        Me.cmbExLocEnd.TabIndex = 17
        '
        'cmbExLocStart
        '
        Me.cmbExLocStart.Location = New System.Drawing.Point(12, 25)
        Me.cmbExLocStart.MenuManager = Me.rbnMain
        Me.cmbExLocStart.Name = "cmbExLocStart"
        Me.cmbExLocStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbExLocStart.Size = New System.Drawing.Size(156, 20)
        Me.cmbExLocStart.TabIndex = 16
        '
        'txtExGas
        '
        Me.txtExGas.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExGas.Location = New System.Drawing.Point(91, 160)
        Me.txtExGas.MenuManager = Me.rbnMain
        Me.txtExGas.Name = "txtExGas"
        Me.txtExGas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExGas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExGas.Size = New System.Drawing.Size(77, 20)
        Me.txtExGas.TabIndex = 26
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(197, 112)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl18.TabIndex = 24
        Me.LabelControl18.Text = "レンタカー："
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Location = New System.Drawing.Point(12, 164)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl22.TabIndex = 30
        Me.LabelControl22.Text = "ガソリン："
        '
        'txtExCarRental
        '
        Me.txtExCarRental.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExCarRental.Location = New System.Drawing.Point(276, 108)
        Me.txtExCarRental.MenuManager = Me.rbnMain
        Me.txtExCarRental.Name = "txtExCarRental"
        Me.txtExCarRental.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExCarRental.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExCarRental.Size = New System.Drawing.Size(77, 20)
        Me.txtExCarRental.TabIndex = 23
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Location = New System.Drawing.Point(197, 164)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl20.TabIndex = 34
        Me.LabelControl20.Text = "車（キロ40円）："
        '
        'txtExCarMiles
        '
        Me.txtExCarMiles.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExCarMiles.Location = New System.Drawing.Point(276, 160)
        Me.txtExCarMiles.MenuManager = Me.rbnMain
        Me.txtExCarMiles.Name = "txtExCarMiles"
        Me.txtExCarMiles.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExCarMiles.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExCarMiles.Size = New System.Drawing.Size(77, 20)
        Me.txtExCarMiles.TabIndex = 27
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Location = New System.Drawing.Point(197, 138)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl21.TabIndex = 32
        Me.LabelControl21.Text = "パーキング："
        '
        'txtExParking
        '
        Me.txtExParking.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExParking.Location = New System.Drawing.Point(276, 134)
        Me.txtExParking.MenuManager = Me.rbnMain
        Me.txtExParking.Name = "txtExParking"
        Me.txtExParking.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExParking.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExParking.Size = New System.Drawing.Size(77, 20)
        Me.txtExParking.TabIndex = 25
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Location = New System.Drawing.Point(12, 112)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl19.TabIndex = 26
        Me.LabelControl19.Text = "タクシー・バス："
        '
        'rdoTransporation
        '
        Me.rdoTransporation.Location = New System.Drawing.Point(12, 50)
        Me.rdoTransporation.MenuManager = Me.rbnMain
        Me.rdoTransporation.Name = "rdoTransporation"
        Me.rdoTransporation.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "電車"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "電車(自)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "車"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "車(自）")})
        Me.rdoTransporation.Size = New System.Drawing.Size(268, 26)
        Me.rdoTransporation.TabIndex = 18
        '
        'txtExTaxi
        '
        Me.txtExTaxi.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExTaxi.Location = New System.Drawing.Point(91, 108)
        Me.txtExTaxi.MenuManager = Me.rbnMain
        Me.txtExTaxi.Name = "txtExTaxi"
        Me.txtExTaxi.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExTaxi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExTaxi.Size = New System.Drawing.Size(77, 20)
        Me.txtExTaxi.TabIndex = 22
        '
        'btnExSearch
        '
        Me.btnExSearch.Location = New System.Drawing.Point(297, 51)
        Me.btnExSearch.Name = "btnExSearch"
        Me.btnExSearch.Size = New System.Drawing.Size(55, 23)
        Me.btnExSearch.TabIndex = 19
        Me.btnExSearch.Text = "検索"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(12, 138)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl17.TabIndex = 22
        Me.LabelControl17.Text = "高速代金："
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(174, 27)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(17, 19)
        Me.LabelControl14.TabIndex = 16
        Me.LabelControl14.Text = "～"
        '
        'txtExHighway
        '
        Me.txtExHighway.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExHighway.Location = New System.Drawing.Point(91, 134)
        Me.txtExHighway.MenuManager = Me.rbnMain
        Me.txtExHighway.Name = "txtExHighway"
        Me.txtExHighway.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExHighway.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExHighway.Size = New System.Drawing.Size(77, 20)
        Me.txtExHighway.TabIndex = 24
        '
        'txtExTrain
        '
        Me.txtExTrain.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExTrain.Location = New System.Drawing.Point(91, 82)
        Me.txtExTrain.MenuManager = Me.rbnMain
        Me.txtExTrain.Name = "txtExTrain"
        Me.txtExTrain.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExTrain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExTrain.Size = New System.Drawing.Size(77, 20)
        Me.txtExTrain.TabIndex = 20
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(197, 86)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl16.TabIndex = 20
        Me.LabelControl16.Text = "航空運賃："
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Location = New System.Drawing.Point(12, 86)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl15.TabIndex = 18
        Me.LabelControl15.Text = "路線運賃："
        '
        'txtExAir
        '
        Me.txtExAir.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExAir.Location = New System.Drawing.Point(276, 82)
        Me.txtExAir.MenuManager = Me.rbnMain
        Me.txtExAir.Name = "txtExAir"
        Me.txtExAir.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExAir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExAir.Size = New System.Drawing.Size(77, 20)
        Me.txtExAir.TabIndex = 21
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.cmbExMealMember)
        Me.GroupControl5.Controls.Add(Me.chkExForCompany)
        Me.GroupControl5.Controls.Add(Me.LabelControl13)
        Me.GroupControl5.Controls.Add(Me.LabelControl24)
        Me.GroupControl5.Controls.Add(Me.txtExMealMisc)
        Me.GroupControl5.Controls.Add(Me.LabelControl26)
        Me.GroupControl5.Controls.Add(Me.txtExDinner)
        Me.GroupControl5.Controls.Add(Me.txtExBreakfast)
        Me.GroupControl5.Controls.Add(Me.LabelControl29)
        Me.GroupControl5.Controls.Add(Me.LabelControl30)
        Me.GroupControl5.Controls.Add(Me.txtExLunch)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl5.Location = New System.Drawing.Point(0, 129)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(365, 102)
        Me.GroupControl5.TabIndex = 11
        Me.GroupControl5.Text = "飲食"
        '
        'cmbExMealMember
        '
        Me.cmbExMealMember.Location = New System.Drawing.Point(94, 77)
        Me.cmbExMealMember.MenuManager = Me.rbnMain
        Me.cmbExMealMember.Name = "cmbExMealMember"
        Me.cmbExMealMember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbExMealMember.Size = New System.Drawing.Size(186, 20)
        Me.cmbExMealMember.TabIndex = 14
        '
        'chkExForCompany
        '
        Me.chkExForCompany.Location = New System.Drawing.Point(297, 77)
        Me.chkExForCompany.MenuManager = Me.rbnMain
        Me.chkExForCompany.Name = "chkExForCompany"
        Me.chkExForCompany.Properties.Caption = "社内"
        Me.chkExForCompany.Size = New System.Drawing.Size(46, 19)
        Me.chkExForCompany.TabIndex = 15
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(15, 81)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl13.TabIndex = 32
        Me.LabelControl13.Text = "メンバー："
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Location = New System.Drawing.Point(200, 55)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl24.TabIndex = 30
        Me.LabelControl24.Text = "その他："
        '
        'txtExMealMisc
        '
        Me.txtExMealMisc.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExMealMisc.Location = New System.Drawing.Point(279, 51)
        Me.txtExMealMisc.MenuManager = Me.rbnMain
        Me.txtExMealMisc.Name = "txtExMealMisc"
        Me.txtExMealMisc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExMealMisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExMealMisc.Size = New System.Drawing.Size(77, 20)
        Me.txtExMealMisc.TabIndex = 13
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Location = New System.Drawing.Point(15, 55)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl26.TabIndex = 24
        Me.LabelControl26.Text = "夕食："
        '
        'txtExDinner
        '
        Me.txtExDinner.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExDinner.Location = New System.Drawing.Point(94, 51)
        Me.txtExDinner.MenuManager = Me.rbnMain
        Me.txtExDinner.Name = "txtExDinner"
        Me.txtExDinner.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExDinner.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExDinner.Size = New System.Drawing.Size(77, 20)
        Me.txtExDinner.TabIndex = 12
        '
        'txtExBreakfast
        '
        Me.txtExBreakfast.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExBreakfast.Location = New System.Drawing.Point(94, 25)
        Me.txtExBreakfast.MenuManager = Me.rbnMain
        Me.txtExBreakfast.Name = "txtExBreakfast"
        Me.txtExBreakfast.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExBreakfast.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExBreakfast.Size = New System.Drawing.Size(77, 20)
        Me.txtExBreakfast.TabIndex = 10
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Location = New System.Drawing.Point(200, 29)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl29.TabIndex = 20
        Me.LabelControl29.Text = "昼食："
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl30.Location = New System.Drawing.Point(15, 29)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl30.TabIndex = 18
        Me.LabelControl30.Text = "朝食："
        '
        'txtExLunch
        '
        Me.txtExLunch.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExLunch.Location = New System.Drawing.Point(279, 25)
        Me.txtExLunch.MenuManager = Me.rbnMain
        Me.txtExLunch.Name = "txtExLunch"
        Me.txtExLunch.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExLunch.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExLunch.Size = New System.Drawing.Size(77, 20)
        Me.txtExLunch.TabIndex = 11
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.txtExCurrencyRate)
        Me.GroupControl6.Controls.Add(Me.LabelControl33)
        Me.GroupControl6.Controls.Add(Me.cmbExCustomer)
        Me.GroupControl6.Controls.Add(Me.txtExNitto)
        Me.GroupControl6.Controls.Add(Me.deExDate)
        Me.GroupControl6.Controls.Add(Me.chkExLate)
        Me.GroupControl6.Controls.Add(Me.LabelControl9)
        Me.GroupControl6.Controls.Add(Me.chkExEarly)
        Me.GroupControl6.Controls.Add(Me.txtExEarlyLate)
        Me.GroupControl6.Controls.Add(Me.LabelControl10)
        Me.GroupControl6.Controls.Add(Me.chkNitto)
        Me.GroupControl6.Controls.Add(Me.txtExHotel)
        Me.GroupControl6.Controls.Add(Me.LabelControl12)
        Me.GroupControl6.Controls.Add(Me.LabelControl11)
        Me.GroupControl6.Controls.Add(Me.chkHotel)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl6.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(365, 129)
        Me.GroupControl6.TabIndex = 2
        Me.GroupControl6.Text = "一般"
        '
        'txtExCurrencyRate
        '
        Me.txtExCurrencyRate.EditValue = "1"
        Me.txtExCurrencyRate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExCurrencyRate.Location = New System.Drawing.Point(66, 104)
        Me.txtExCurrencyRate.MenuManager = Me.rbnMain
        Me.txtExCurrencyRate.Name = "txtExCurrencyRate"
        Me.txtExCurrencyRate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExCurrencyRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExCurrencyRate.Size = New System.Drawing.Size(66, 20)
        Me.txtExCurrencyRate.TabIndex = 7
        Me.txtExCurrencyRate.TabStop = False
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl33.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl33.Location = New System.Drawing.Point(16, 107)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl33.TabIndex = 12
        Me.LabelControl33.Text = "為替："
        '
        'cmbExCustomer
        '
        Me.cmbExCustomer.Location = New System.Drawing.Point(94, 52)
        Me.cmbExCustomer.MenuManager = Me.rbnMain
        Me.cmbExCustomer.Name = "cmbExCustomer"
        Me.cmbExCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbExCustomer.Size = New System.Drawing.Size(262, 20)
        Me.cmbExCustomer.TabIndex = 2
        '
        'txtExNitto
        '
        Me.txtExNitto.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExNitto.Location = New System.Drawing.Point(268, 78)
        Me.txtExNitto.MenuManager = Me.rbnMain
        Me.txtExNitto.Name = "txtExNitto"
        Me.txtExNitto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExNitto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExNitto.Size = New System.Drawing.Size(88, 20)
        Me.txtExNitto.TabIndex = 6
        '
        'deExDate
        '
        Me.deExDate.EditValue = Nothing
        Me.deExDate.Location = New System.Drawing.Point(178, 25)
        Me.deExDate.MenuManager = Me.rbnMain
        Me.deExDate.Name = "deExDate"
        Me.deExDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deExDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deExDate.Size = New System.Drawing.Size(178, 20)
        Me.deExDate.TabIndex = 1
        '
        'chkExLate
        '
        Me.chkExLate.Location = New System.Drawing.Point(216, 104)
        Me.chkExLate.MenuManager = Me.rbnMain
        Me.chkExLate.Name = "chkExLate"
        Me.chkExLate.Properties.Caption = "夜遅"
        Me.chkExLate.Size = New System.Drawing.Size(46, 19)
        Me.chkExLate.TabIndex = 8
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(16, 29)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl9.TabIndex = 1
        Me.LabelControl9.Text = "日付："
        '
        'chkExEarly
        '
        Me.chkExEarly.Location = New System.Drawing.Point(164, 104)
        Me.chkExEarly.MenuManager = Me.rbnMain
        Me.chkExEarly.Name = "chkExEarly"
        Me.chkExEarly.Properties.Caption = "早朝"
        Me.chkExEarly.Size = New System.Drawing.Size(46, 19)
        Me.chkExEarly.TabIndex = 7
        '
        'txtExEarlyLate
        '
        Me.txtExEarlyLate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExEarlyLate.Location = New System.Drawing.Point(268, 104)
        Me.txtExEarlyLate.MenuManager = Me.rbnMain
        Me.txtExEarlyLate.Name = "txtExEarlyLate"
        Me.txtExEarlyLate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExEarlyLate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExEarlyLate.Size = New System.Drawing.Size(88, 20)
        Me.txtExEarlyLate.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(16, 55)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(42, 14)
        Me.LabelControl10.TabIndex = 3
        Me.LabelControl10.Text = "出張先："
        '
        'chkNitto
        '
        Me.chkNitto.Location = New System.Drawing.Point(249, 79)
        Me.chkNitto.MenuManager = Me.rbnMain
        Me.chkNitto.Name = "chkNitto"
        Me.chkNitto.Properties.Caption = ""
        Me.chkNitto.Size = New System.Drawing.Size(23, 19)
        Me.chkNitto.TabIndex = 5
        '
        'txtExHotel
        '
        Me.txtExHotel.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtExHotel.Location = New System.Drawing.Point(94, 77)
        Me.txtExHotel.MenuManager = Me.rbnMain
        Me.txtExHotel.Name = "txtExHotel"
        Me.txtExHotel.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExHotel.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExHotel.Size = New System.Drawing.Size(84, 20)
        Me.txtExHotel.TabIndex = 4
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(200, 80)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(30, 14)
        Me.LabelControl12.TabIndex = 8
        Me.LabelControl12.Text = "日当："
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(16, 81)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(42, 14)
        Me.LabelControl11.TabIndex = 5
        Me.LabelControl11.Text = "宿泊費："
        '
        'chkHotel
        '
        Me.chkHotel.Location = New System.Drawing.Point(75, 78)
        Me.chkHotel.MenuManager = Me.rbnMain
        Me.chkHotel.Name = "chkHotel"
        Me.chkHotel.Properties.Caption = ""
        Me.chkHotel.Size = New System.Drawing.Size(46, 19)
        Me.chkHotel.TabIndex = 3
        '
        'tabSalesTools
        '
        Me.tabSalesTools.Controls.Add(Me.NavBarControl1)
        Me.tabSalesTools.Name = "tabSalesTools"
        Me.tabSalesTools.Size = New System.Drawing.Size(365, 787)
        Me.tabSalesTools.Text = "営業"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup4
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer3)
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer4)
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer5)
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer6)
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavQuotePackage, Me.NavBarGroup2, Me.ポスト, Me.NavBarGroup1, Me.NavBarGroup3, Me.NavBarGroup4})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 365
        Me.NavBarControl1.Size = New System.Drawing.Size(365, 787)
        Me.NavBarControl1.TabIndex = 0
        Me.NavBarControl1.Text = "NavBarControl1"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.NavigationPaneViewInfoRegistrator()
        '
        'NavBarGroup4
        '
        Me.NavBarGroup4.Caption = "値引・その他"
        Me.NavBarGroup4.ControlContainer = Me.NavBarGroupControlContainer6
        Me.NavBarGroup4.Expanded = True
        Me.NavBarGroup4.GroupClientHeight = 333
        Me.NavBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup4.Name = "NavBarGroup4"
        '
        'NavBarGroupControlContainer6
        '
        Me.NavBarGroupControlContainer6.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer6.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer6.Controls.Add(Me.gcQMisc)
        Me.NavBarGroupControlContainer6.Name = "NavBarGroupControlContainer6"
        Me.NavBarGroupControlContainer6.Size = New System.Drawing.Size(363, 539)
        Me.NavBarGroupControlContainer6.TabIndex = 5
        '
        'gcQMisc
        '
        Me.gcQMisc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQMisc.Location = New System.Drawing.Point(0, 0)
        Me.gcQMisc.MainView = Me.gvQMisc
        Me.gcQMisc.Name = "gcQMisc"
        Me.gcQMisc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ricCompanyName, Me.ricDiscountType, Me.ricDealerName})
        Me.gcQMisc.Size = New System.Drawing.Size(363, 539)
        Me.gcQMisc.TabIndex = 4
        Me.gcQMisc.UseEmbeddedNavigator = True
        Me.gcQMisc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQMisc})
        '
        'gvQMisc
        '
        Me.gvQMisc.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvQMisc.Appearance.Row.Options.UseFont = True
        Me.gvQMisc.GridControl = Me.gcQMisc
        Me.gvQMisc.Name = "gvQMisc"
        Me.gvQMisc.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvQMisc.OptionsCustomization.AllowGroup = False
        Me.gvQMisc.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvQMisc.OptionsView.RowAutoHeight = True
        Me.gvQMisc.OptionsView.ShowAutoFilterRow = True
        Me.gvQMisc.OptionsView.ShowGroupPanel = False
        '
        'ricCompanyName
        '
        Me.ricCompanyName.AutoHeight = False
        Me.ricCompanyName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ricCompanyName.Name = "ricCompanyName"
        '
        'ricDiscountType
        '
        Me.ricDiscountType.AutoHeight = False
        Me.ricDiscountType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ricDiscountType.Name = "ricDiscountType"
        '
        'ricDealerName
        '
        Me.ricDealerName.AutoHeight = False
        Me.ricDealerName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ricDealerName.Name = "ricDealerName"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer1.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer1.Controls.Add(Me.gcQPackage)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(363, 245)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'gcQPackage
        '
        Me.gcQPackage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQPackage.Location = New System.Drawing.Point(0, 0)
        Me.gcQPackage.MainView = Me.gvQPackage
        Me.gcQPackage.Name = "gcQPackage"
        Me.gcQPackage.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.gcQPackage.Size = New System.Drawing.Size(363, 245)
        Me.gcQPackage.TabIndex = 2
        Me.gcQPackage.UseEmbeddedNavigator = True
        Me.gcQPackage.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQPackage})
        '
        'gvQPackage
        '
        Me.gvQPackage.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvQPackage.Appearance.Row.Options.UseFont = True
        Me.gvQPackage.GridControl = Me.gcQPackage
        Me.gvQPackage.Name = "gvQPackage"
        Me.gvQPackage.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvQPackage.OptionsCustomization.AllowGroup = False
        Me.gvQPackage.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvQPackage.OptionsView.RowAutoHeight = True
        Me.gvQPackage.OptionsView.ShowAutoFilterRow = True
        Me.gvQPackage.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer2.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer2.Controls.Add(Me.gcQOption)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(363, 309)
        Me.NavBarGroupControlContainer2.TabIndex = 1
        '
        'gcQOption
        '
        Me.gcQOption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQOption.Location = New System.Drawing.Point(0, 0)
        Me.gcQOption.MainView = Me.gvQOption
        Me.gcQOption.Name = "gcQOption"
        Me.gcQOption.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.gcQOption.Size = New System.Drawing.Size(363, 309)
        Me.gcQOption.TabIndex = 3
        Me.gcQOption.UseEmbeddedNavigator = True
        Me.gcQOption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQOption})
        '
        'gvQOption
        '
        Me.gvQOption.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvQOption.Appearance.Row.Options.UseFont = True
        Me.gvQOption.GridControl = Me.gcQOption
        Me.gvQOption.Name = "gvQOption"
        Me.gvQOption.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvQOption.OptionsCustomization.AllowGroup = False
        Me.gvQOption.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvQOption.OptionsView.RowAutoHeight = True
        Me.gvQOption.OptionsView.ShowAutoFilterRow = True
        Me.gvQOption.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'NavBarGroupControlContainer3
        '
        Me.NavBarGroupControlContainer3.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer3.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer3.Controls.Add(Me.gcQPosts)
        Me.NavBarGroupControlContainer3.Name = "NavBarGroupControlContainer3"
        Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(363, 309)
        Me.NavBarGroupControlContainer3.TabIndex = 2
        '
        'gcQPosts
        '
        Me.gcQPosts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQPosts.Location = New System.Drawing.Point(0, 0)
        Me.gcQPosts.MainView = Me.gvQPosts
        Me.gcQPosts.Name = "gcQPosts"
        Me.gcQPosts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit3})
        Me.gcQPosts.Size = New System.Drawing.Size(363, 309)
        Me.gcQPosts.TabIndex = 3
        Me.gcQPosts.UseEmbeddedNavigator = True
        Me.gcQPosts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQPosts})
        '
        'gvQPosts
        '
        Me.gvQPosts.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvQPosts.Appearance.Row.Options.UseFont = True
        Me.gvQPosts.GridControl = Me.gcQPosts
        Me.gvQPosts.Name = "gvQPosts"
        Me.gvQPosts.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvQPosts.OptionsCustomization.AllowGroup = False
        Me.gvQPosts.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvQPosts.OptionsView.RowAutoHeight = True
        Me.gvQPosts.OptionsView.ShowAutoFilterRow = True
        Me.gvQPosts.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        '
        'NavBarGroupControlContainer4
        '
        Me.NavBarGroupControlContainer4.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer4.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer4.Controls.Add(Me.gcQSupport)
        Me.NavBarGroupControlContainer4.Name = "NavBarGroupControlContainer4"
        Me.NavBarGroupControlContainer4.Size = New System.Drawing.Size(363, 277)
        Me.NavBarGroupControlContainer4.TabIndex = 3
        '
        'gcQSupport
        '
        Me.gcQSupport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQSupport.Location = New System.Drawing.Point(0, 0)
        Me.gcQSupport.MainView = Me.gvQSupport
        Me.gcQSupport.Name = "gcQSupport"
        Me.gcQSupport.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit4})
        Me.gcQSupport.Size = New System.Drawing.Size(363, 277)
        Me.gcQSupport.TabIndex = 3
        Me.gcQSupport.UseEmbeddedNavigator = True
        Me.gcQSupport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQSupport})
        '
        'gvQSupport
        '
        Me.gvQSupport.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvQSupport.Appearance.Row.Options.UseFont = True
        Me.gvQSupport.GridControl = Me.gcQSupport
        Me.gvQSupport.Name = "gvQSupport"
        Me.gvQSupport.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvQSupport.OptionsCustomization.AllowGroup = False
        Me.gvQSupport.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvQSupport.OptionsView.RowAutoHeight = True
        Me.gvQSupport.OptionsView.ShowAutoFilterRow = True
        Me.gvQSupport.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit4
        '
        Me.RepositoryItemPictureEdit4.Name = "RepositoryItemPictureEdit4"
        '
        'NavBarGroupControlContainer5
        '
        Me.NavBarGroupControlContainer5.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer5.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer5.Controls.Add(Me.gcQAll)
        Me.NavBarGroupControlContainer5.Name = "NavBarGroupControlContainer5"
        Me.NavBarGroupControlContainer5.Size = New System.Drawing.Size(363, 245)
        Me.NavBarGroupControlContainer5.TabIndex = 4
        '
        'gcQAll
        '
        Me.gcQAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQAll.Location = New System.Drawing.Point(0, 0)
        Me.gcQAll.MainView = Me.gvQAll
        Me.gcQAll.Name = "gcQAll"
        Me.gcQAll.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit5})
        Me.gcQAll.Size = New System.Drawing.Size(363, 245)
        Me.gcQAll.TabIndex = 3
        Me.gcQAll.UseEmbeddedNavigator = True
        Me.gcQAll.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvQAll})
        '
        'gvQAll
        '
        Me.gvQAll.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvQAll.Appearance.Row.Options.UseFont = True
        Me.gvQAll.GridControl = Me.gcQAll
        Me.gvQAll.Name = "gvQAll"
        Me.gvQAll.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvQAll.OptionsCustomization.AllowGroup = False
        Me.gvQAll.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvQAll.OptionsView.RowAutoHeight = True
        Me.gvQAll.OptionsView.ShowAutoFilterRow = True
        Me.gvQAll.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit5
        '
        Me.RepositoryItemPictureEdit5.Name = "RepositoryItemPictureEdit5"
        '
        'NavQuotePackage
        '
        Me.NavQuotePackage.Caption = "パッケージ"
        Me.NavQuotePackage.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavQuotePackage.GroupClientHeight = 245
        Me.NavQuotePackage.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavQuotePackage.Name = "NavQuotePackage"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "オプション"
        Me.NavBarGroup2.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup2.GroupClientHeight = 309
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'ポスト
        '
        Me.ポスト.Caption = "ポスト＋カスタマイズ"
        Me.ポスト.ControlContainer = Me.NavBarGroupControlContainer3
        Me.ポスト.GroupClientHeight = 309
        Me.ポスト.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.ポスト.Name = "ポスト"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "インストール・サポート・保守"
        Me.NavBarGroup1.ControlContainer = Me.NavBarGroupControlContainer4
        Me.NavBarGroup1.GroupClientHeight = 277
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "全て（英語）"
        Me.NavBarGroup3.ControlContainer = Me.NavBarGroupControlContainer5
        Me.NavBarGroup3.GroupClientHeight = 245
        Me.NavBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'splMonth
        '
        Me.splMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splMonth.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splMonth.Location = New System.Drawing.Point(0, 0)
        Me.splMonth.Name = "splMonth"
        '
        'splMonth.Panel1
        '
        Me.splMonth.Panel1.Controls.Add(Me.xtcTools)
        '
        'splMonth.Panel2
        '
        Me.splMonth.Panel2.Controls.Add(Me.gcExMonth)
        Me.splMonth.Size = New System.Drawing.Size(889, 772)
        Me.splMonth.SplitterDistance = 818
        Me.splMonth.TabIndex = 9
        '
        'xtcTools
        '
        Me.xtcTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcTools.Location = New System.Drawing.Point(0, 0)
        Me.xtcTools.Name = "xtcTools"
        Me.xtcTools.SelectedTabPage = Me.tabExWeb
        Me.xtcTools.Size = New System.Drawing.Size(818, 772)
        Me.xtcTools.TabIndex = 11
        Me.xtcTools.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabExWeb, Me.tabExSpreadsheet, Me.tabExSpreadsheet2, Me.tabExDocument})
        '
        'tabExWeb
        '
        Me.tabExWeb.Controls.Add(Me.webExpenses)
        Me.tabExWeb.Name = "tabExWeb"
        Me.tabExWeb.Size = New System.Drawing.Size(812, 743)
        Me.tabExWeb.Text = "ウェブ"
        '
        'webExpenses
        '
        Me.webExpenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webExpenses.Location = New System.Drawing.Point(0, 0)
        Me.webExpenses.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webExpenses.Name = "webExpenses"
        Me.webExpenses.ScriptErrorsSuppressed = True
        Me.webExpenses.Size = New System.Drawing.Size(812, 743)
        Me.webExpenses.TabIndex = 11
        '
        'tabExSpreadsheet
        '
        Me.tabExSpreadsheet.Controls.Add(Me.xlsExpenses)
        Me.tabExSpreadsheet.Name = "tabExSpreadsheet"
        Me.tabExSpreadsheet.Size = New System.Drawing.Size(812, 787)
        Me.tabExSpreadsheet.Text = "エクセル"
        '
        'xlsExpenses
        '
        Me.xlsExpenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xlsExpenses.Location = New System.Drawing.Point(0, 0)
        Me.xlsExpenses.MenuManager = Me.rbnMain
        Me.xlsExpenses.Name = "xlsExpenses"
        Me.xlsExpenses.Size = New System.Drawing.Size(812, 787)
        Me.xlsExpenses.TabIndex = 10
        Me.xlsExpenses.Text = "SpreadsheetControl1"
        '
        'tabExSpreadsheet2
        '
        Me.tabExSpreadsheet2.Controls.Add(Me.xlsDoc)
        Me.tabExSpreadsheet2.Name = "tabExSpreadsheet2"
        Me.tabExSpreadsheet2.Size = New System.Drawing.Size(812, 787)
        Me.tabExSpreadsheet2.Text = "エクセル2"
        '
        'xlsDoc
        '
        Me.xlsDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xlsDoc.Location = New System.Drawing.Point(0, 0)
        Me.xlsDoc.MenuManager = Me.rbnMain
        Me.xlsDoc.Name = "xlsDoc"
        Me.xlsDoc.Size = New System.Drawing.Size(812, 787)
        Me.xlsDoc.TabIndex = 11
        Me.xlsDoc.Text = "SpreadsheetControl1"
        '
        'tabExDocument
        '
        Me.tabExDocument.Controls.Add(Me.splQuoteDoc)
        Me.tabExDocument.Name = "tabExDocument"
        Me.tabExDocument.Size = New System.Drawing.Size(812, 787)
        Me.tabExDocument.Text = "ドキュメント"
        '
        'splQuoteDoc
        '
        Me.splQuoteDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splQuoteDoc.Location = New System.Drawing.Point(0, 0)
        Me.splQuoteDoc.Name = "splQuoteDoc"
        Me.splQuoteDoc.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splQuoteDoc.Panel1
        '
        Me.splQuoteDoc.Panel1.Controls.Add(Me.recDoc)
        '
        'splQuoteDoc.Panel2
        '
        Me.splQuoteDoc.Panel2.Controls.Add(Me.recDoc2)
        Me.splQuoteDoc.Size = New System.Drawing.Size(812, 787)
        Me.splQuoteDoc.SplitterDistance = 644
        Me.splQuoteDoc.TabIndex = 0
        '
        'recDoc
        '
        Me.recDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recDoc.EnableToolTips = True
        Me.recDoc.Location = New System.Drawing.Point(0, 0)
        Me.recDoc.MenuManager = Me.rbnMain
        Me.recDoc.Name = "recDoc"
        Me.recDoc.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
        Me.recDoc.Options.Fields.UpdateFieldsInTextBoxes = False
        Me.recDoc.Size = New System.Drawing.Size(812, 644)
        Me.recDoc.TabIndex = 0
        '
        'recDoc2
        '
        Me.recDoc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recDoc2.EnableToolTips = True
        Me.recDoc2.Location = New System.Drawing.Point(0, 0)
        Me.recDoc2.MenuManager = Me.rbnMain
        Me.recDoc2.Name = "recDoc2"
        Me.recDoc2.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
        Me.recDoc2.Options.Fields.UpdateFieldsInTextBoxes = False
        Me.recDoc2.Size = New System.Drawing.Size(812, 139)
        Me.recDoc2.TabIndex = 1
        '
        'gcExMonth
        '
        Me.gcExMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcExMonth.Location = New System.Drawing.Point(0, 0)
        Me.gcExMonth.MainView = Me.gvExMonth
        Me.gcExMonth.Name = "gcExMonth"
        Me.gcExMonth.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riHanko})
        Me.gcExMonth.Size = New System.Drawing.Size(67, 772)
        Me.gcExMonth.TabIndex = 30
        Me.gcExMonth.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvExMonth})
        '
        'gvExMonth
        '
        Me.gvExMonth.Appearance.FixedLine.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvExMonth.Appearance.FixedLine.Options.UseFont = True
        Me.gvExMonth.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvExMonth.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvExMonth.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gvExMonth.Appearance.Row.Options.UseFont = True
        Me.gvExMonth.GridControl = Me.gcExMonth
        Me.gvExMonth.Name = "gvExMonth"
        Me.gvExMonth.OptionsCustomization.AllowGroup = False
        Me.gvExMonth.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvExMonth.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvExMonth.OptionsView.EnableAppearanceOddRow = True
        Me.gvExMonth.OptionsView.ShowGroupPanel = False
        Me.gvExMonth.RowHeight = 50
        '
        'riHanko
        '
        Me.riHanko.Name = "riHanko"
        Me.riHanko.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'tabBrowser
        '
        Me.tabBrowser.Controls.Add(Me.webB)
        Me.tabBrowser.Name = "tabBrowser"
        Me.tabBrowser.Size = New System.Drawing.Size(1264, 772)
        Me.tabBrowser.Text = "Browser"
        '
        'webB
        '
        Me.webB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webB.Location = New System.Drawing.Point(0, 0)
        Me.webB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webB.Name = "webB"
        Me.webB.ScriptErrorsSuppressed = True
        Me.webB.Size = New System.Drawing.Size(1264, 772)
        Me.webB.TabIndex = 4
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.gcsSettings)
        Me.tabSettings.Controls.Add(Me.pnlTools)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(1264, 772)
        Me.tabSettings.Text = "Settings"
        '
        'gcsSettings
        '
        Me.gcsSettings.Controls.Add(Me.splSettings)
        Me.gcsSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcsSettings.Location = New System.Drawing.Point(0, 0)
        Me.gcsSettings.Name = "gcsSettings"
        Me.gcsSettings.Size = New System.Drawing.Size(1264, 772)
        Me.gcsSettings.TabIndex = 0
        Me.gcsSettings.Text = "設定"
        '
        'splSettings
        '
        Me.splSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splSettings.Location = New System.Drawing.Point(2, 21)
        Me.splSettings.Name = "splSettings"
        Me.splSettings.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splSettings.Panel1
        '
        Me.splSettings.Panel1.Controls.Add(Me.gcSettings)
        '
        'splSettings.Panel2
        '
        Me.splSettings.Panel2.Controls.Add(Me.gcLSettings)
        Me.splSettings.Size = New System.Drawing.Size(1260, 749)
        Me.splSettings.SplitterDistance = 408
        Me.splSettings.TabIndex = 0
        '
        'gcSettings
        '
        Me.gcSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSettings.Location = New System.Drawing.Point(0, 0)
        Me.gcSettings.MainView = Me.gvSettings
        Me.gcSettings.Name = "gcSettings"
        Me.gcSettings.Size = New System.Drawing.Size(1260, 408)
        Me.gcSettings.TabIndex = 29
        Me.gcSettings.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSettings})
        '
        'gvSettings
        '
        Me.gvSettings.GridControl = Me.gcSettings
        Me.gvSettings.Name = "gvSettings"
        Me.gvSettings.OptionsCustomization.AllowGroup = False
        Me.gvSettings.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvSettings.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvSettings.OptionsView.ShowGroupPanel = False
        '
        'gcLSettings
        '
        Me.gcLSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLSettings.Location = New System.Drawing.Point(0, 0)
        Me.gcLSettings.MainView = Me.gvLSettings
        Me.gcLSettings.Name = "gcLSettings"
        Me.gcLSettings.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riPassword})
        Me.gcLSettings.Size = New System.Drawing.Size(1260, 337)
        Me.gcLSettings.TabIndex = 30
        Me.gcLSettings.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLSettings})
        '
        'gvLSettings
        '
        Me.gvLSettings.GridControl = Me.gcLSettings
        Me.gvLSettings.Name = "gvLSettings"
        Me.gvLSettings.OptionsCustomization.AllowGroup = False
        Me.gvLSettings.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvLSettings.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvLSettings.OptionsView.ShowGroupPanel = False
        '
        'riPassword
        '
        Me.riPassword.AutoHeight = False
        Me.riPassword.Name = "riPassword"
        Me.riPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'pnlTools
        '
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTools.Location = New System.Drawing.Point(0, 0)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(1264, 772)
        Me.pnlTools.TabIndex = 32
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 100)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(217, 477)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmsCustomer
        '
        Me.cmsCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsFindCustomer, Me.ttsNewFolder, Me.ttsEditFolder, Me.ttsOpenCustomerFolder, Me.ttsFolderDelete, Me.ttsMoveToCustomer, Me.ttsCreateExpenses, Me.ttsPostFiles})
        Me.cmsCustomer.Name = "cmsCustomer"
        Me.cmsCustomer.Size = New System.Drawing.Size(165, 180)
        '
        'ttsFindCustomer
        '
        Me.ttsFindCustomer.Image = CType(resources.GetObject("ttsFindCustomer.Image"), System.Drawing.Image)
        Me.ttsFindCustomer.Name = "ttsFindCustomer"
        Me.ttsFindCustomer.Size = New System.Drawing.Size(164, 22)
        Me.ttsFindCustomer.Text = "情報検索"
        '
        'ttsNewFolder
        '
        Me.ttsNewFolder.Image = CType(resources.GetObject("ttsNewFolder.Image"), System.Drawing.Image)
        Me.ttsNewFolder.Name = "ttsNewFolder"
        Me.ttsNewFolder.Size = New System.Drawing.Size(164, 22)
        Me.ttsNewFolder.Text = "フォルダー新規"
        '
        'ttsEditFolder
        '
        Me.ttsEditFolder.Image = CType(resources.GetObject("ttsEditFolder.Image"), System.Drawing.Image)
        Me.ttsEditFolder.Name = "ttsEditFolder"
        Me.ttsEditFolder.Size = New System.Drawing.Size(164, 22)
        Me.ttsEditFolder.Text = "フォルダー名前編集"
        '
        'ttsOpenCustomerFolder
        '
        Me.ttsOpenCustomerFolder.Image = CType(resources.GetObject("ttsOpenCustomerFolder.Image"), System.Drawing.Image)
        Me.ttsOpenCustomerFolder.Name = "ttsOpenCustomerFolder"
        Me.ttsOpenCustomerFolder.Size = New System.Drawing.Size(164, 22)
        Me.ttsOpenCustomerFolder.Text = "フォルダー開く"
        '
        'ttsFolderDelete
        '
        Me.ttsFolderDelete.Image = CType(resources.GetObject("ttsFolderDelete.Image"), System.Drawing.Image)
        Me.ttsFolderDelete.Name = "ttsFolderDelete"
        Me.ttsFolderDelete.Size = New System.Drawing.Size(164, 22)
        Me.ttsFolderDelete.Text = "フォルダー削除"
        Me.ttsFolderDelete.Visible = False
        '
        'ttsMoveToCustomer
        '
        Me.ttsMoveToCustomer.Image = CType(resources.GetObject("ttsMoveToCustomer.Image"), System.Drawing.Image)
        Me.ttsMoveToCustomer.Name = "ttsMoveToCustomer"
        Me.ttsMoveToCustomer.Size = New System.Drawing.Size(164, 22)
        Me.ttsMoveToCustomer.Text = "顧客に移動"
        '
        'ttsCreateExpenses
        '
        Me.ttsCreateExpenses.Image = CType(resources.GetObject("ttsCreateExpenses.Image"), System.Drawing.Image)
        Me.ttsCreateExpenses.Name = "ttsCreateExpenses"
        Me.ttsCreateExpenses.Size = New System.Drawing.Size(164, 22)
        Me.ttsCreateExpenses.Text = "経費リポート作成"
        '
        'ttsPostFiles
        '
        Me.ttsPostFiles.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsTest})
        Me.ttsPostFiles.Image = CType(resources.GetObject("ttsPostFiles.Image"), System.Drawing.Image)
        Me.ttsPostFiles.Name = "ttsPostFiles"
        Me.ttsPostFiles.Size = New System.Drawing.Size(164, 22)
        Me.ttsPostFiles.Text = "ポストファイル"
        '
        'ttsTest
        '
        Me.ttsTest.Name = "ttsTest"
        Me.ttsTest.Size = New System.Drawing.Size(102, 22)
        Me.ttsTest.Text = "mac1"
        '
        'cmsCheck
        '
        Me.cmsCheck.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsCheck, Me.ttsEditSim, Me.ttsSIMMail})
        Me.cmsCheck.Name = "cmsCustomer"
        Me.cmsCheck.Size = New System.Drawing.Size(149, 70)
        '
        'ttsCheck
        '
        Me.ttsCheck.Image = CType(resources.GetObject("ttsCheck.Image"), System.Drawing.Image)
        Me.ttsCheck.Name = "ttsCheck"
        Me.ttsCheck.Size = New System.Drawing.Size(148, 22)
        Me.ttsCheck.Text = "確認"
        '
        'ttsEditSim
        '
        Me.ttsEditSim.Image = CType(resources.GetObject("ttsEditSim.Image"), System.Drawing.Image)
        Me.ttsEditSim.Name = "ttsEditSim"
        Me.ttsEditSim.Size = New System.Drawing.Size(148, 22)
        Me.ttsEditSim.Text = "編集"
        '
        'ttsSIMMail
        '
        Me.ttsSIMMail.Image = CType(resources.GetObject("ttsSIMMail.Image"), System.Drawing.Image)
        Me.ttsSIMMail.Name = "ttsSIMMail"
        Me.ttsSIMMail.Size = New System.Drawing.Size(148, 22)
        Me.ttsSIMMail.Text = "SIMをメールする"
        '
        'cmsLog
        '
        Me.cmsLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsMailLog, Me.ttsDeleteLogItem, Me.ttsEditLog})
        Me.cmsLog.Name = "cmsCustomer"
        Me.cmsLog.Size = New System.Drawing.Size(131, 70)
        '
        'ttsMailLog
        '
        Me.ttsMailLog.Image = CType(resources.GetObject("ttsMailLog.Image"), System.Drawing.Image)
        Me.ttsMailLog.Name = "ttsMailLog"
        Me.ttsMailLog.Size = New System.Drawing.Size(130, 22)
        Me.ttsMailLog.Text = "Eメール作成"
        '
        'ttsDeleteLogItem
        '
        Me.ttsDeleteLogItem.Image = CType(resources.GetObject("ttsDeleteLogItem.Image"), System.Drawing.Image)
        Me.ttsDeleteLogItem.Name = "ttsDeleteLogItem"
        Me.ttsDeleteLogItem.Size = New System.Drawing.Size(130, 22)
        Me.ttsDeleteLogItem.Text = "列削除"
        '
        'ttsEditLog
        '
        Me.ttsEditLog.Image = CType(resources.GetObject("ttsEditLog.Image"), System.Drawing.Image)
        Me.ttsEditLog.Name = "ttsEditLog"
        Me.ttsEditLog.Size = New System.Drawing.Size(130, 22)
        Me.ttsEditLog.Text = "ログ編集"
        '
        'cmsCustomerData
        '
        Me.cmsCustomerData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsCustomerMultiEdit, Me.ttsAddToEMailList, Me.ttsMailClient, Me.ttsOpenWebAddress, Me.ttsGoogleSearch, Me.ttsNavitime, Me.ttsSearchJalan, Me.ttsSearchRakuten, Me.ttsSearchWeather, Me.封筒ToolStripMenuItem})
        Me.cmsCustomerData.Name = "ContextMenuStrip1"
        Me.cmsCustomerData.Size = New System.Drawing.Size(172, 224)
        '
        'ttsCustomerMultiEdit
        '
        Me.ttsCustomerMultiEdit.Image = CType(resources.GetObject("ttsCustomerMultiEdit.Image"), System.Drawing.Image)
        Me.ttsCustomerMultiEdit.Name = "ttsCustomerMultiEdit"
        Me.ttsCustomerMultiEdit.Size = New System.Drawing.Size(171, 22)
        Me.ttsCustomerMultiEdit.Text = "複数編集"
        '
        'ttsAddToEMailList
        '
        Me.ttsAddToEMailList.Image = CType(resources.GetObject("ttsAddToEMailList.Image"), System.Drawing.Image)
        Me.ttsAddToEMailList.Name = "ttsAddToEMailList"
        Me.ttsAddToEMailList.Size = New System.Drawing.Size(171, 22)
        Me.ttsAddToEMailList.Text = "Eメールリストを作成"
        '
        'ttsMailClient
        '
        Me.ttsMailClient.Image = CType(resources.GetObject("ttsMailClient.Image"), System.Drawing.Image)
        Me.ttsMailClient.Name = "ttsMailClient"
        Me.ttsMailClient.Size = New System.Drawing.Size(171, 22)
        Me.ttsMailClient.Text = "メール作成"
        '
        'ttsOpenWebAddress
        '
        Me.ttsOpenWebAddress.Image = CType(resources.GetObject("ttsOpenWebAddress.Image"), System.Drawing.Image)
        Me.ttsOpenWebAddress.Name = "ttsOpenWebAddress"
        Me.ttsOpenWebAddress.Size = New System.Drawing.Size(171, 22)
        Me.ttsOpenWebAddress.Text = "Webページを開く"
        '
        'ttsGoogleSearch
        '
        Me.ttsGoogleSearch.Image = CType(resources.GetObject("ttsGoogleSearch.Image"), System.Drawing.Image)
        Me.ttsGoogleSearch.Name = "ttsGoogleSearch"
        Me.ttsGoogleSearch.Size = New System.Drawing.Size(171, 22)
        Me.ttsGoogleSearch.Text = "Googleルート検索"
        '
        'ttsNavitime
        '
        Me.ttsNavitime.Image = CType(resources.GetObject("ttsNavitime.Image"), System.Drawing.Image)
        Me.ttsNavitime.Name = "ttsNavitime"
        Me.ttsNavitime.Size = New System.Drawing.Size(171, 22)
        Me.ttsNavitime.Text = "Navitimeルート検索"
        '
        'ttsSearchJalan
        '
        Me.ttsSearchJalan.Image = CType(resources.GetObject("ttsSearchJalan.Image"), System.Drawing.Image)
        Me.ttsSearchJalan.Name = "ttsSearchJalan"
        Me.ttsSearchJalan.Size = New System.Drawing.Size(171, 22)
        Me.ttsSearchJalan.Text = "Jalanホテル検索"
        '
        'ttsSearchRakuten
        '
        Me.ttsSearchRakuten.Image = CType(resources.GetObject("ttsSearchRakuten.Image"), System.Drawing.Image)
        Me.ttsSearchRakuten.Name = "ttsSearchRakuten"
        Me.ttsSearchRakuten.Size = New System.Drawing.Size(171, 22)
        Me.ttsSearchRakuten.Text = "Rakutenホテル検索"
        '
        'ttsSearchWeather
        '
        Me.ttsSearchWeather.Image = CType(resources.GetObject("ttsSearchWeather.Image"), System.Drawing.Image)
        Me.ttsSearchWeather.Name = "ttsSearchWeather"
        Me.ttsSearchWeather.Size = New System.Drawing.Size(171, 22)
        Me.ttsSearchWeather.Text = "Yahoo天気検索"
        '
        '封筒ToolStripMenuItem
        '
        Me.封筒ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsEnvelopeLarge, Me.ttsEnvelopeSmall})
        Me.封筒ToolStripMenuItem.Image = CType(resources.GetObject("封筒ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.封筒ToolStripMenuItem.Name = "封筒ToolStripMenuItem"
        Me.封筒ToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.封筒ToolStripMenuItem.Text = "封筒"
        '
        'ttsEnvelopeLarge
        '
        Me.ttsEnvelopeLarge.Name = "ttsEnvelopeLarge"
        Me.ttsEnvelopeLarge.Size = New System.Drawing.Size(150, 22)
        Me.ttsEnvelopeLarge.Text = "シグマ封筒　大"
        '
        'ttsEnvelopeSmall
        '
        Me.ttsEnvelopeSmall.Name = "ttsEnvelopeSmall"
        Me.ttsEnvelopeSmall.Size = New System.Drawing.Size(150, 22)
        Me.ttsEnvelopeSmall.Text = "シグマ封筒　小"
        '
        'cmsVideo
        '
        Me.cmsVideo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsShowVideo})
        Me.cmsVideo.Name = "cmsCustomer"
        Me.cmsVideo.Size = New System.Drawing.Size(119, 26)
        '
        'ttsShowVideo
        '
        Me.ttsShowVideo.Image = CType(resources.GetObject("ttsShowVideo.Image"), System.Drawing.Image)
        Me.ttsShowVideo.Name = "ttsShowVideo"
        Me.ttsShowVideo.Size = New System.Drawing.Size(118, 22)
        Me.ttsShowVideo.Text = "ビデオ開く"
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(209, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(166, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(375, 434)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'cmsWeb
        '
        Me.cmsWeb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsCopyClipboard})
        Me.cmsWeb.Name = "cmsCustomer"
        Me.cmsWeb.Size = New System.Drawing.Size(168, 26)
        '
        'ttsCopyClipboard
        '
        Me.ttsCopyClipboard.Image = CType(resources.GetObject("ttsCopyClipboard.Image"), System.Drawing.Image)
        Me.ttsCopyClipboard.Name = "ttsCopyClipboard"
        Me.ttsCopyClipboard.Size = New System.Drawing.Size(167, 22)
        Me.ttsCopyClipboard.Text = "クリップボードへコピー"
        '
        'cmsSim
        '
        Me.cmsSim.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsAddToSchedule, Me.ttsAddMaintToSchedule, Me.ttsRequestSim})
        Me.cmsSim.Name = "cmsSim"
        Me.cmsSim.Size = New System.Drawing.Size(204, 70)
        '
        'ttsAddToSchedule
        '
        Me.ttsAddToSchedule.Image = CType(resources.GetObject("ttsAddToSchedule.Image"), System.Drawing.Image)
        Me.ttsAddToSchedule.Name = "ttsAddToSchedule"
        Me.ttsAddToSchedule.Size = New System.Drawing.Size(203, 22)
        Me.ttsAddToSchedule.Text = "ライセンス日をスケジュールに"
        '
        'ttsAddMaintToSchedule
        '
        Me.ttsAddMaintToSchedule.Image = CType(resources.GetObject("ttsAddMaintToSchedule.Image"), System.Drawing.Image)
        Me.ttsAddMaintToSchedule.Name = "ttsAddMaintToSchedule"
        Me.ttsAddMaintToSchedule.Size = New System.Drawing.Size(203, 22)
        Me.ttsAddMaintToSchedule.Text = "保守日をスケジュールに"
        '
        'ttsRequestSim
        '
        Me.ttsRequestSim.Image = CType(resources.GetObject("ttsRequestSim.Image"), System.Drawing.Image)
        Me.ttsRequestSim.Name = "ttsRequestSim"
        Me.ttsRequestSim.Size = New System.Drawing.Size(203, 22)
        Me.ttsRequestSim.Text = "メールを送る"
        '
        'cmsDemo
        '
        Me.cmsDemo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsShowDemoVideo, Me.ttsShowDemoWOL, Me.ttsOpenDemoHelp})
        Me.cmsDemo.Name = "cmsSim"
        Me.cmsDemo.Size = New System.Drawing.Size(131, 70)
        '
        'ttsShowDemoVideo
        '
        Me.ttsShowDemoVideo.Image = CType(resources.GetObject("ttsShowDemoVideo.Image"), System.Drawing.Image)
        Me.ttsShowDemoVideo.Name = "ttsShowDemoVideo"
        Me.ttsShowDemoVideo.Size = New System.Drawing.Size(130, 22)
        Me.ttsShowDemoVideo.Text = "ビデオを開く"
        '
        'ttsShowDemoWOL
        '
        Me.ttsShowDemoWOL.Image = CType(resources.GetObject("ttsShowDemoWOL.Image"), System.Drawing.Image)
        Me.ttsShowDemoWOL.Name = "ttsShowDemoWOL"
        Me.ttsShowDemoWOL.Size = New System.Drawing.Size(130, 22)
        Me.ttsShowDemoWOL.Text = "WOLを開く"
        '
        'ttsOpenDemoHelp
        '
        Me.ttsOpenDemoHelp.Image = CType(resources.GetObject("ttsOpenDemoHelp.Image"), System.Drawing.Image)
        Me.ttsOpenDemoHelp.Name = "ttsOpenDemoHelp"
        Me.ttsOpenDemoHelp.Size = New System.Drawing.Size(130, 22)
        Me.ttsOpenDemoHelp.Text = "HELPを開く"
        '
        'cmsQuote
        '
        Me.cmsQuote.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsQQty, Me.ttsQAdd, Me.ttsCartClear})
        Me.cmsQuote.Name = "cmsSim"
        Me.cmsQuote.Size = New System.Drawing.Size(115, 70)
        '
        'ttsQQty
        '
        Me.ttsQQty.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsQ1, Me.ttsQ2, Me.ttsQ3, Me.ttsQ4, Me.ttsQ5})
        Me.ttsQQty.Image = CType(resources.GetObject("ttsQQty.Image"), System.Drawing.Image)
        Me.ttsQQty.Name = "ttsQQty"
        Me.ttsQQty.Size = New System.Drawing.Size(114, 22)
        Me.ttsQQty.Text = "数量"
        '
        'ttsQ1
        '
        Me.ttsQ1.Name = "ttsQ1"
        Me.ttsQ1.Size = New System.Drawing.Size(80, 22)
        Me.ttsQ1.Text = "1"
        '
        'ttsQ2
        '
        Me.ttsQ2.Name = "ttsQ2"
        Me.ttsQ2.Size = New System.Drawing.Size(80, 22)
        Me.ttsQ2.Text = "2"
        '
        'ttsQ3
        '
        Me.ttsQ3.Name = "ttsQ3"
        Me.ttsQ3.Size = New System.Drawing.Size(80, 22)
        Me.ttsQ3.Text = "3"
        '
        'ttsQ4
        '
        Me.ttsQ4.Name = "ttsQ4"
        Me.ttsQ4.Size = New System.Drawing.Size(80, 22)
        Me.ttsQ4.Text = "4"
        '
        'ttsQ5
        '
        Me.ttsQ5.Name = "ttsQ5"
        Me.ttsQ5.Size = New System.Drawing.Size(80, 22)
        Me.ttsQ5.Text = "5"
        '
        'ttsQAdd
        '
        Me.ttsQAdd.Image = CType(resources.GetObject("ttsQAdd.Image"), System.Drawing.Image)
        Me.ttsQAdd.Name = "ttsQAdd"
        Me.ttsQAdd.Size = New System.Drawing.Size(114, 22)
        Me.ttsQAdd.Text = "追加"
        '
        'ttsCartClear
        '
        Me.ttsCartClear.Image = CType(resources.GetObject("ttsCartClear.Image"), System.Drawing.Image)
        Me.ttsCartClear.Name = "ttsCartClear"
        Me.ttsCartClear.Size = New System.Drawing.Size(114, 22)
        Me.ttsCartClear.Text = "取り消し"
        '
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.xtcMain)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1270, 801)
        Me.Panel2.TabIndex = 12
        '
        'cmsDelete
        '
        Me.cmsDelete.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsFind, Me.ttsItemDelete})
        Me.cmsDelete.Name = "cmsCustomer"
        Me.cmsDelete.Size = New System.Drawing.Size(99, 48)
        '
        'ttsFind
        '
        Me.ttsFind.Image = CType(resources.GetObject("ttsFind.Image"), System.Drawing.Image)
        Me.ttsFind.Name = "ttsFind"
        Me.ttsFind.Size = New System.Drawing.Size(98, 22)
        Me.ttsFind.Text = "検索"
        '
        'ttsItemDelete
        '
        Me.ttsItemDelete.Image = CType(resources.GetObject("ttsItemDelete.Image"), System.Drawing.Image)
        Me.ttsItemDelete.Name = "ttsItemDelete"
        Me.ttsItemDelete.Size = New System.Drawing.Size(98, 22)
        Me.ttsItemDelete.Text = "削除"
        '
        'BandwidthUpdateTimer
        '
        Me.BandwidthUpdateTimer.Enabled = True
        Me.BandwidthUpdateTimer.Interval = 5000
        '
        'cmsAutoTest
        '
        Me.cmsAutoTest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsLaunchasAdmin, Me.ttsRunAutotest})
        Me.cmsAutoTest.Name = "cmsCustomer"
        Me.cmsAutoTest.Size = New System.Drawing.Size(160, 48)
        '
        'ttsLaunchasAdmin
        '
        Me.ttsLaunchasAdmin.Image = CType(resources.GetObject("ttsLaunchasAdmin.Image"), System.Drawing.Image)
        Me.ttsLaunchasAdmin.Name = "ttsLaunchasAdmin"
        Me.ttsLaunchasAdmin.Size = New System.Drawing.Size(159, 22)
        Me.ttsLaunchasAdmin.Text = "管理者として実行"
        '
        'ttsRunAutotest
        '
        Me.ttsRunAutotest.Image = CType(resources.GetObject("ttsRunAutotest.Image"), System.Drawing.Image)
        Me.ttsRunAutotest.Name = "ttsRunAutotest"
        Me.ttsRunAutotest.Size = New System.Drawing.Size(159, 22)
        Me.ttsRunAutotest.Text = "AutoTEST 実行"
        '
        'ImageCollection16
        '
        Me.ImageCollection16.ImageStream = CType(resources.GetObject("ImageCollection16.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'ClockTimer
        '
        Me.ClockTimer.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 979)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.rbnMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Ribbon = Me.rbnMain
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "SigmaTEK Dashboard"
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcMain.ResumeLayout(False)
        Me.tabCustomer.ResumeLayout(False)
        Me.splCustomer.Panel1.ResumeLayout(False)
        Me.splCustomer.Panel2.ResumeLayout(False)
        CType(Me.splCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splCustomer.ResumeLayout(False)
        Me.splCustInfo.Panel1.ResumeLayout(False)
        Me.splCustInfo.Panel2.ResumeLayout(False)
        CType(Me.splCustInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splCustInfo.ResumeLayout(False)
        CType(Me.gcCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCustomerDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cvCustomerDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riCardLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riCardURL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcCustomer.ResumeLayout(False)
        Me.tabTicket.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.splSim.Panel1.ResumeLayout(False)
        Me.splSim.Panel2.ResumeLayout(False)
        CType(Me.splSim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splSim.ResumeLayout(False)
        Me.SplitContainer11.Panel1.ResumeLayout(False)
        Me.SplitContainer11.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer11.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.clbSigmanest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbVPNItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clbSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcSim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riSIMLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.splSigmaInfo.Panel1.ResumeLayout(False)
        Me.splSigmaInfo.Panel2.ResumeLayout(False)
        Me.splSigmaInfo.Panel2.PerformLayout()
        CType(Me.splSigmaInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splSigmaInfo.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.txtTikVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbnMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ritSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTikClosed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meTikSolution.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meTikDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsShortcuts.ResumeLayout(False)
        CType(Me.txtTikTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSolution, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSIMVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaintenance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deMaintenance.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deMaintenance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCustomerLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCustomerLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riEventMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riHyperLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOverview.ResumeLayout(False)
        Me.tabSupport.ResumeLayout(False)
        Me.tabMachine.ResumeLayout(False)
        CType(Me.gcQA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcSimSum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSimSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustomerData.ResumeLayout(False)
        Me.SplitContainer9.Panel1.ResumeLayout(False)
        Me.SplitContainer9.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer9.ResumeLayout(False)
        CType(Me.gcCustomerData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCustomerData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ricComboEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ricCountryComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riHyperLinkMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer10.Panel1.ResumeLayout(False)
        Me.SplitContainer10.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer10.ResumeLayout(False)
        CType(Me.imageMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSaleslogix.ResumeLayout(False)
        CType(Me.gcSalesLogix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSalesLogix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSigmaNEST.ResumeLayout(False)
        Me.splApplications.Panel1.ResumeLayout(False)
        Me.splApplications.Panel2.ResumeLayout(False)
        CType(Me.splApplications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splApplications.ResumeLayout(False)
        CType(Me.gcSigmaNEST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSigmaNEST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gcProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabApps.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.gcApps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvApps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDemo.ResumeLayout(False)
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer8.ResumeLayout(False)
        CType(Me.gcDemoMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDemoMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPicM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDemoFeatures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDemoFeatures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPicF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMail.ResumeLayout(False)
        CType(Me.splMailMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMailMain.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMailTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMailTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riEventType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riEventAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDocuments.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.tlDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWeb.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.cmbWebType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWebLink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWebDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcWebLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvWebLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riHyperlink2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVideo.ResumeLayout(False)
        Me.SplitContainer17.Panel1.ResumeLayout(False)
        Me.SplitContainer17.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer17.ResumeLayout(False)
        CType(Me.gcVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabExpenses.ResumeLayout(False)
        Me.SplitContainer14.Panel1.ResumeLayout(False)
        Me.SplitContainer14.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer14.ResumeLayout(False)
        CType(Me.xtcCompanyTools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcCompanyTools.ResumeLayout(False)
        Me.tabMyExpenses.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.txtExAdvertising.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExMisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExGift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExRevenue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExPostal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExOvPostal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.cmbExLocEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbExLocStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExGas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExCarRental.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExCarMiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExParking.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoTransporation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExTaxi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExHighway.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExTrain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExAir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.cmbExMealMember.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExForCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExMealMisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExDinner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExBreakfast.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExLunch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.txtExCurrencyRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbExCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExNitto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deExDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deExDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExLate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExEarly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExEarlyLate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNitto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExHotel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHotel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSalesTools.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer6.ResumeLayout(False)
        CType(Me.gcQMisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQMisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ricCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ricDiscountType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ricDealerName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        CType(Me.gcQPackage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQPackage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        CType(Me.gcQOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer3.ResumeLayout(False)
        CType(Me.gcQPosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQPosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer4.ResumeLayout(False)
        CType(Me.gcQSupport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQSupport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer5.ResumeLayout(False)
        CType(Me.gcQAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvQAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMonth.Panel1.ResumeLayout(False)
        Me.splMonth.Panel2.ResumeLayout(False)
        CType(Me.splMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMonth.ResumeLayout(False)
        CType(Me.xtcTools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcTools.ResumeLayout(False)
        Me.tabExWeb.ResumeLayout(False)
        Me.tabExSpreadsheet.ResumeLayout(False)
        Me.tabExSpreadsheet2.ResumeLayout(False)
        Me.tabExDocument.ResumeLayout(False)
        Me.splQuoteDoc.Panel1.ResumeLayout(False)
        Me.splQuoteDoc.Panel2.ResumeLayout(False)
        CType(Me.splQuoteDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splQuoteDoc.ResumeLayout(False)
        CType(Me.gcExMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvExMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riHanko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBrowser.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        CType(Me.gcsSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcsSettings.ResumeLayout(False)
        Me.splSettings.Panel1.ResumeLayout(False)
        Me.splSettings.Panel2.ResumeLayout(False)
        CType(Me.splSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splSettings.ResumeLayout(False)
        CType(Me.gcSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCustomer.ResumeLayout(False)
        Me.cmsCheck.ResumeLayout(False)
        Me.cmsLog.ResumeLayout(False)
        Me.cmsCustomerData.ResumeLayout(False)
        Me.cmsVideo.ResumeLayout(False)
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsWeb.ResumeLayout(False)
        Me.cmsSim.ResumeLayout(False)
        Me.cmsDemo.ResumeLayout(False)
        Me.cmsQuote.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.cmsDelete.ResumeLayout(False)
        Me.cmsAutoTest.ResumeLayout(False)
        CType(Me.ImageCollection16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents xtcMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCustomer As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents splCustomer As System.Windows.Forms.SplitContainer
    Friend WithEvents tabSettings As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rbnMain As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rpgMain As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgNav As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSetSNData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgSigmanest As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiUndoSetting As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcsSettings As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rpgSettings As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents bbiSaveSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgEdit As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgLog As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiEditLog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabDemo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rpgDemo As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents bbiMail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgMisc As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgSigmanest2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents tabSigmaNEST As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rpgSigma As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents splApplications As System.Windows.Forms.SplitContainer
    Friend WithEvents gcSigmaNEST As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSigmaNEST As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bbiJapan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiUSA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiKorea As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgLanguage As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiOpenINI As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgSigmaINI As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiChina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSigmanest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCompanion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgSigmaStartup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCTL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLite As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiNormalSetting As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiBeyondCompare As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgTools As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgApps As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tabApps As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rpgNav2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents gcApps As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvApps As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rpgSigmanestApp As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgSigmaDLLIni As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents recApp As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents rpgMail As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tabMail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents splMailMain As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcMailTemplate As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMailTemplate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents riEventType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents riEventAttachment As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents rpgNav3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgMaintenance As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tabDocuments As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents bbiOpenFile As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgExcel As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCreateOutlookMail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgOutlook As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiCalDay As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCalWeek As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCalWork As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCalMonth As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCalTimeline As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgWeb As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgWebNav As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents tabWeb As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtWebLink As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWebDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcWebLink As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvWebLink As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbWebType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents riHyperlink2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents xlsData As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents docViewer As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents rpgVideo As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents gcDemoMachine As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDemoMachine As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcDemoFeatures As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDemoFeatures As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabVideo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents bbiSNConfig As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiShowVideo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgShowVideo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgVideoShow As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents riPicM As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents riPicF As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bbiDocuments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDocMachines As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgDocNav As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiDocTrouble As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgCustomers As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tabCustomerData As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer9 As System.Windows.Forms.SplitContainer
    Friend WithEvents gcCustomerData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCustomerData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ricComboEdit As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ricCountryComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents riHyperLinkMail As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents SplitContainer10 As System.Windows.Forms.SplitContainer
    Friend WithEvents imageMap As System.Windows.Forms.PictureBox
    Friend WithEvents picCard As System.Windows.Forms.PictureBox
    Friend WithEvents cmsCustomer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsFindCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiCustFind As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCustClear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgFind As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiAddNewCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiEditCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSIMMail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLicenseFile As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSalesMode As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgSalesMode As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmsCheck As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsEditSim As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsLog As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsMailLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsEditLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiAddCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgCustomerEdit As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiEditCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCustDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pdfViewer As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents rpgMaintFind As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents skinSet As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents splSettings As System.Windows.Forms.SplitContainer
    Friend WithEvents gcSettings As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSettings As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcLSettings As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLSettings As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmsCustomerData As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsNavitime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsGoogleSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsOpenCustomerFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiEight As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgEight As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiViewer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiOpen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRunFile As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ttsOpenWebAddress As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpgCustomerNav As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents tabCompanySearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents bbiShowCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiShowCompany As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiMasterPost As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCompanyMode As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ttsMoveToCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsFolderDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsNewFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsEditFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents webBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents bbiSpain As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmsVideo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsShowVideo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents riPassword As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bbiGoogleContacts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ttsMailClient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents rpExpenses As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents tabExpenses As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer14 As System.Windows.Forms.SplitContainer
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmsShortcuts As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ttsCreateExpenses As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiExExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExWeb As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgExNavigation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgExEdit As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiExExpenses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiExTimecard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgExDocument As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiExCreate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents splMonth As System.Windows.Forms.SplitContainer
    Friend WithEvents gcExMonth As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvExMonth As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents rtbBody As System.Windows.Forms.RichTextBox
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmsWeb As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsCopyClipboard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiHasp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcSimSum As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSimSum As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmsSim As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsAddToSchedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsRequestSim As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpgAppVide As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ttsSaveLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsDeleteLogItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiPartnerMode As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ttsSearchJalan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsSearchRakuten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsSearchWeather As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsCustomerMultiEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDemo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsShowDemoVideo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsShowDemoWOL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsOpenDemoHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents splCustInfo As System.Windows.Forms.SplitContainer
    Friend WithEvents gcCustomer As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCustomer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcCustomerDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents riCardLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents cvCustomerDetail As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents riCardURL As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents bbiKillSigmanest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents xtcCompanyTools As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabMyExpenses As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExAdvertising As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExMisc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExGift As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExRevenue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExPostal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExOvPostal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbExLocEnd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbExLocStart As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtExGas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExCarRental As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExCarMiles As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExParking As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdoTransporation As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtExTaxi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExHighway As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExTrain As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExAir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbExMealMember As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkExForCompany As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExMealMisc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExDinner As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExBreakfast As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExLunch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtExCurrencyRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbExCustomer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtExNitto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents deExDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkExLate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkExEarly As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtExEarlyLate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkNitto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtExHotel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkHotel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tabSalesTools As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavQuotePackage As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents gcQPackage As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQPackage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents ポスト As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents bbiQuotation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ttsAddMaintToSchedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xtcTools As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabExWeb As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents webExpenses As System.Windows.Forms.WebBrowser
    Friend WithEvents tabExSpreadsheet As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xlsExpenses As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents tabExDocument As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents splQuoteDoc As System.Windows.Forms.SplitContainer
    Friend WithEvents recDoc As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents recDoc2 As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer5 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents gcQAll As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQAll As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents gcQOption As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQOption As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents NavBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents gcQPosts As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQPosts As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents NavBarGroupControlContainer4 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents gcQSupport As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQSupport As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cmsQuote As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsQQty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsQ1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsQ2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsQ3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsQ4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsQ5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsQAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer17 As System.Windows.Forms.SplitContainer
    Friend WithEvents gcVideo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVideo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents bbiPicture As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents picImage As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents rpgVideoFolder As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiSlideshow As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgSlideshow As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer6 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents gcQMisc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQMisc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents riHanko As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ricCompanyName As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents bbiQuoteDoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgQuote As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiExportPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ricDiscountType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ricDealerName As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemRadioGroup2 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents tabExSpreadsheet2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xlsDoc As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents bbiInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCreateQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiMaintQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiMaintInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiOpenQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bsiVersion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents rpgCustFind As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiCreateNewExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiCreateNewWord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgNewDocument As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmsDelete As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsItemDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiSQLManager As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgDemoTools As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ttsCartClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiQA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcQA As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvQA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bsiStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bbiClickstamper As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgDocApp As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiOntime As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents 封筒ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsEnvelopeLarge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsEnvelopeSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BandwidthUpdateTimer As System.Windows.Forms.Timer
    Friend WithEvents bsNetworkStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bbiCustMarkers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabBrowser As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents webB As System.Windows.Forms.WebBrowser
    Friend WithEvents ttsSIMMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiSalesLogix As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabSaleslogix As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcSalesLogix As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSalesLogix As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemHyperLinkEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents bbiTranslate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgSigmaTools As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents bbiFTPUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ttsPostFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttsTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsAutoTest As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsRunAutotest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RibbonMiniToolbar1 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
    Friend WithEvents ImageCollection48 As DevExpress.Utils.ImageCollection
    Friend WithEvents ImageCollection16 As DevExpress.Utils.ImageCollection
    Friend WithEvents bbiExportToCSV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ttsAddToEMailList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiPlaceholders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgMailer As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiMailMessage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiMailTemplate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiMailText As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSMTPSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiFTPSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgMiscSettings As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiOpenPresentation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiUnits As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents copyDB As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPostalCodes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiVPNStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsiGDriveStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents xtcCustomer As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabTicket As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents splSim As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer11 As System.Windows.Forms.SplitContainer
    Friend WithEvents clbSource As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents gcSim As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents riSIMLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents gcMachine As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMachine As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents splSigmaInfo As System.Windows.Forms.SplitContainer
    Friend WithEvents cbtnQA As DevExpress.XtraEditors.CheckButton
    Friend WithEvents txtSIMVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaintenance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deMaintenance As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gcCustomerLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCustomerLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents riEventMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents riHyperLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabOverview As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents wbOverview As System.Windows.Forms.WebBrowser
    Friend WithEvents tabSupport As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents wbSupport As System.Windows.Forms.WebBrowser
    Friend WithEvents tabMachine As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents wbMachine As System.Windows.Forms.WebBrowser
    Friend WithEvents bbiRefreshData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents beiSearch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ritSearch As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bbiSearch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Tokyo As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents CircularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Friend WithEvents gcProducts As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProducts As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlClock As System.Windows.Forms.Panel
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents CircularGauge3 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ClockTimer As System.Windows.Forms.Timer
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents meTikSolution As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents meTikDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTikTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciTitle As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDescription As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciSolution As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rtbEdit As System.Windows.Forms.RichTextBox
    Friend WithEvents txtTikVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkTikClosed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lciVersion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bTest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents clbSigmanest As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents clbVPNItems As DevExpress.XtraEditors.CheckedListBoxControl
    Private WithEvents tlDocuments As DevExpress.XtraTreeList.TreeList
    Private WithEvents colName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Private WithEvents colType As DevExpress.XtraTreeList.Columns.TreeListColumn
    Private WithEvents colSize As DevExpress.XtraTreeList.Columns.TreeListColumn
    Private WithEvents imageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents colPath As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ttsFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bbiProductInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ttsLaunchasAdmin As System.Windows.Forms.ToolStripMenuItem


    
End Class
