<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebMail
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWebMail))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.xtcMailMain = New DevExpress.XtraTab.XtraTabControl()
        Me.tabMessage = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtFrom = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubject = New DevExpress.XtraEditors.TextEdit()
        Me.cmbTo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tabTemplate = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.btnOpenEML = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.btnHTML = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.btnSaveTemplate = New DevExpress.XtraEditors.SimpleButton()
        Me.tabList = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.gcAddress = New DevExpress.XtraGrid.GridControl()
        Me.gvAddress = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riSIMLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer()
        Me.btnDeleteList = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddressOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
        Me.splStatus = New System.Windows.Forms.SplitContainer()
        Me.axBrowser = New AxSHDocVw.AxWebBrowser()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.pbcStatus = New DevExpress.XtraEditors.ProgressBarControl()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.xtcMailMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcMailMain.SuspendLayout()
        Me.tabMessage.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTemplate.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.tabList.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.gcAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riSIMLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        CType(Me.splStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splStatus.Panel1.SuspendLayout()
        Me.splStatus.Panel2.SuspendLayout()
        Me.splStatus.SuspendLayout()
        CType(Me.axBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.pbcStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.splStatus)
        Me.SplitContainer1.Size = New System.Drawing.Size(1026, 608)
        Me.SplitContainer1.SplitterDistance = 113
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.xtcMailMain)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnSend)
        Me.SplitContainer2.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.SplitContainer2.Size = New System.Drawing.Size(1026, 113)
        Me.SplitContainer2.SplitterDistance = 823
        Me.SplitContainer2.TabIndex = 0
        '
        'xtcMailMain
        '
        Me.xtcMailMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcMailMain.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtcMailMain.Location = New System.Drawing.Point(0, 0)
        Me.xtcMailMain.Name = "xtcMailMain"
        Me.xtcMailMain.SelectedTabPage = Me.tabMessage
        Me.xtcMailMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcMailMain.Size = New System.Drawing.Size(823, 113)
        Me.xtcMailMain.TabIndex = 0
        Me.xtcMailMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabMessage, Me.tabTemplate, Me.tabList})
        '
        'tabMessage
        '
        Me.tabMessage.Controls.Add(Me.LayoutControl1)
        Me.tabMessage.Name = "tabMessage"
        Me.tabMessage.Size = New System.Drawing.Size(793, 107)
        Me.tabMessage.Text = "M"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtFrom)
        Me.LayoutControl1.Controls.Add(Me.txtSubject)
        Me.LayoutControl1.Controls.Add(Me.cmbTo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(793, 107)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(117, 12)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(664, 20)
        Me.txtFrom.StyleController = Me.LayoutControl1
        Me.txtFrom.TabIndex = 6
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(117, 60)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(664, 20)
        Me.txtSubject.StyleController = Me.LayoutControl1
        Me.txtSubject.TabIndex = 5
        '
        'cmbTo
        '
        Me.cmbTo.Location = New System.Drawing.Point(117, 36)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTo.Size = New System.Drawing.Size(664, 20)
        Me.cmbTo.StyleController = Me.LayoutControl1
        Me.cmbTo.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(793, 107)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFrom
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(773, 24)
        Me.LayoutControlItem3.Text = "差出人："
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 14)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmbTo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(773, 24)
        Me.LayoutControlItem1.Text = "宛先："
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 14)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtSubject
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(773, 39)
        Me.LayoutControlItem2.Text = "件名："
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 14)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'tabTemplate
        '
        Me.tabTemplate.Controls.Add(Me.SplitContainer3)
        Me.tabTemplate.Name = "tabTemplate"
        Me.tabTemplate.Padding = New System.Windows.Forms.Padding(10)
        Me.tabTemplate.Size = New System.Drawing.Size(793, 107)
        Me.tabTemplate.Text = "T"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(10, 10)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnOpenEML)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(773, 87)
        Me.SplitContainer3.SplitterDistance = 83
        Me.SplitContainer3.TabIndex = 0
        '
        'btnOpenEML
        '
        Me.btnOpenEML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOpenEML.Image = CType(resources.GetObject("btnOpenEML.Image"), System.Drawing.Image)
        Me.btnOpenEML.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnOpenEML.Location = New System.Drawing.Point(0, 0)
        Me.btnOpenEML.Name = "btnOpenEML"
        Me.btnOpenEML.Size = New System.Drawing.Size(83, 87)
        Me.btnOpenEML.TabIndex = 0
        Me.btnOpenEML.Text = "テンプレート"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnHTML)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer4.Size = New System.Drawing.Size(686, 87)
        Me.SplitContainer4.SplitterDistance = 83
        Me.SplitContainer4.TabIndex = 1
        '
        'btnHTML
        '
        Me.btnHTML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHTML.Image = CType(resources.GetObject("btnHTML.Image"), System.Drawing.Image)
        Me.btnHTML.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnHTML.Location = New System.Drawing.Point(0, 0)
        Me.btnHTML.Name = "btnHTML"
        Me.btnHTML.Size = New System.Drawing.Size(83, 87)
        Me.btnHTML.TabIndex = 1
        Me.btnHTML.Text = "HTML"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.btnSaveTemplate)
        Me.SplitContainer5.Size = New System.Drawing.Size(599, 87)
        Me.SplitContainer5.SplitterDistance = 83
        Me.SplitContainer5.TabIndex = 2
        '
        'btnSaveTemplate
        '
        Me.btnSaveTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveTemplate.Image = CType(resources.GetObject("btnSaveTemplate.Image"), System.Drawing.Image)
        Me.btnSaveTemplate.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSaveTemplate.Location = New System.Drawing.Point(0, 0)
        Me.btnSaveTemplate.Name = "btnSaveTemplate"
        Me.btnSaveTemplate.Size = New System.Drawing.Size(83, 87)
        Me.btnSaveTemplate.TabIndex = 2
        Me.btnSaveTemplate.Text = "登録"
        '
        'tabList
        '
        Me.tabList.Controls.Add(Me.SplitContainer6)
        Me.tabList.Name = "tabList"
        Me.tabList.Size = New System.Drawing.Size(793, 107)
        Me.tabList.Text = "L"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.gcAddress)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.SplitContainer8)
        Me.SplitContainer6.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer6.Size = New System.Drawing.Size(793, 107)
        Me.SplitContainer6.SplitterDistance = 722
        Me.SplitContainer6.TabIndex = 0
        '
        'gcAddress
        '
        Me.gcAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAddress.Location = New System.Drawing.Point(0, 0)
        Me.gcAddress.MainView = Me.gvAddress
        Me.gcAddress.Name = "gcAddress"
        Me.gcAddress.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riSIMLink})
        Me.gcAddress.Size = New System.Drawing.Size(722, 107)
        Me.gcAddress.TabIndex = 3
        Me.gcAddress.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAddress})
        '
        'gvAddress
        '
        Me.gvAddress.GridControl = Me.gcAddress
        Me.gvAddress.Name = "gvAddress"
        Me.gvAddress.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvAddress.OptionsCustomization.AllowGroup = False
        Me.gvAddress.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvAddress.OptionsView.EnableAppearanceOddRow = True
        Me.gvAddress.OptionsView.RowAutoHeight = True
        Me.gvAddress.OptionsView.ShowGroupPanel = False
        '
        'riSIMLink
        '
        Me.riSIMLink.AutoHeight = False
        Me.riSIMLink.Name = "riSIMLink"
        '
        'SplitContainer8
        '
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainer8.Name = "SplitContainer8"
        Me.SplitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.Controls.Add(Me.btnDeleteList)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.Controls.Add(Me.btnAddressOK)
        Me.SplitContainer8.Size = New System.Drawing.Size(57, 97)
        Me.SplitContainer8.SplitterDistance = 37
        Me.SplitContainer8.TabIndex = 0
        '
        'btnDeleteList
        '
        Me.btnDeleteList.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteList.Appearance.Options.UseFont = True
        Me.btnDeleteList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDeleteList.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnDeleteList.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteList.Name = "btnDeleteList"
        Me.btnDeleteList.Size = New System.Drawing.Size(57, 37)
        Me.btnDeleteList.TabIndex = 2
        Me.btnDeleteList.Text = "削除"
        '
        'btnAddressOK
        '
        Me.btnAddressOK.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddressOK.Appearance.Options.UseFont = True
        Me.btnAddressOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddressOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAddressOK.Location = New System.Drawing.Point(0, 0)
        Me.btnAddressOK.Name = "btnAddressOK"
        Me.btnAddressOK.Size = New System.Drawing.Size(57, 56)
        Me.btnAddressOK.TabIndex = 2
        Me.btnAddressOK.Text = "戻る"
        '
        'btnSend
        '
        Me.btnSend.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Appearance.Options.UseFont = True
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSend.Location = New System.Drawing.Point(10, 10)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(179, 93)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "送信"
        '
        'splStatus
        '
        Me.splStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splStatus.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splStatus.Location = New System.Drawing.Point(0, 0)
        Me.splStatus.Name = "splStatus"
        Me.splStatus.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splStatus.Panel1
        '
        Me.splStatus.Panel1.Controls.Add(Me.axBrowser)
        '
        'splStatus.Panel2
        '
        Me.splStatus.Panel2.Controls.Add(Me.SplitContainer7)
        Me.splStatus.Size = New System.Drawing.Size(1026, 491)
        Me.splStatus.SplitterDistance = 462
        Me.splStatus.TabIndex = 0
        '
        'axBrowser
        '
        Me.axBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.axBrowser.Enabled = True
        Me.axBrowser.Location = New System.Drawing.Point(0, 0)
        Me.axBrowser.OcxState = CType(resources.GetObject("axBrowser.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axBrowser.Size = New System.Drawing.Size(1026, 462)
        Me.axBrowser.TabIndex = 2
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.pbcStatus)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.lblStatus)
        Me.SplitContainer7.Size = New System.Drawing.Size(1026, 25)
        Me.SplitContainer7.SplitterDistance = 912
        Me.SplitContainer7.TabIndex = 0
        '
        'pbcStatus
        '
        Me.pbcStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbcStatus.Location = New System.Drawing.Point(0, 0)
        Me.pbcStatus.Name = "pbcStatus"
        Me.pbcStatus.Size = New System.Drawing.Size(912, 25)
        Me.pbcStatus.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblStatus.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(110, 25)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "1 of 1"
        '
        'frmWebMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 608)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWebMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWebMail"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.xtcMailMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcMailMain.ResumeLayout(False)
        Me.tabMessage.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTemplate.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.tabList.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.gcAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riSIMLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer8.ResumeLayout(False)
        Me.splStatus.Panel1.ResumeLayout(False)
        Me.splStatus.Panel2.ResumeLayout(False)
        CType(Me.splStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splStatus.ResumeLayout(False)
        CType(Me.axBrowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        CType(Me.pbcStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents xtcMailMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabMessage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTemplate As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbTo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOpenEML As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHTML As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveTemplate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents tabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents gcAddress As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAddress As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents riSIMLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents splStatus As System.Windows.Forms.SplitContainer
    Friend WithEvents axBrowser As AxSHDocVw.AxWebBrowser
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents pbcStatus As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnDeleteList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddressOK As DevExpress.XtraEditors.SimpleButton
End Class
