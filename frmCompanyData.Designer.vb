<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyData
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanyData))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.splCompany = New DevExpress.XtraEditors.SplitContainerControl()
        Me.navMain = New DevExpress.XtraNavBar.NavBarControl()
        Me.navMap = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.imageMap = New System.Windows.Forms.PictureBox()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer12 = New System.Windows.Forms.SplitContainer()
        Me.rdoPrefecture = New DevExpress.XtraEditors.RadioGroup()
        Me.SplitContainer13 = New System.Windows.Forms.SplitContainer()
        Me.clbIndustry = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.rdoOptions = New DevExpress.XtraEditors.RadioGroup()
        Me.navCompany = New DevExpress.XtraNavBar.NavBarGroup()
        Me.gcCompany = New DevExpress.XtraGrid.GridControl()
        Me.gvCompany = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.riHyperLinkEMail = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.riHyperLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.XpDataView1 = New DevExpress.Xpo.XPDataView(Me.components)
        Me.cmsCompanyData = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttsAddToEMailList = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.splCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splCompany.SuspendLayout()
        CType(Me.navMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navMain.SuspendLayout()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        CType(Me.imageMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer12.Panel1.SuspendLayout()
        Me.SplitContainer12.Panel2.SuspendLayout()
        Me.SplitContainer12.SuspendLayout()
        CType(Me.rdoPrefecture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer13.Panel1.SuspendLayout()
        Me.SplitContainer13.Panel2.SuspendLayout()
        Me.SplitContainer13.SuspendLayout()
        CType(Me.clbIndustry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoOptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riHyperLinkEMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riHyperLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpDataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCompanyData.SuspendLayout()
        Me.SuspendLayout()
        '
        'splCompany
        '
        Me.splCompany.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.splCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splCompany.Location = New System.Drawing.Point(0, 0)
        Me.splCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.splCompany.Name = "splCompany"
        Me.splCompany.Panel1.Controls.Add(Me.navMain)
        Me.splCompany.Panel1.Text = "Panel1"
        Me.splCompany.Panel2.Controls.Add(Me.gcCompany)
        Me.splCompany.Panel2.Text = "Panel2"
        Me.splCompany.Size = New System.Drawing.Size(1091, 651)
        Me.splCompany.SplitterPosition = 295
        Me.splCompany.TabIndex = 2
        Me.splCompany.Text = "SplitContainerControl1"
        '
        'navMain
        '
        Me.navMain.ActiveGroup = Me.navMap
        Me.navMain.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.navMain.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.navMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navMain.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navCompany, Me.navMap})
        Me.navMain.Location = New System.Drawing.Point(0, 0)
        Me.navMain.Name = "navMain"
        Me.navMain.OptionsNavPane.CollapsedWidth = 100
        Me.navMain.OptionsNavPane.ExpandedWidth = 295
        Me.navMain.ShowIcons = DevExpress.Utils.DefaultBoolean.[False]
        Me.navMain.Size = New System.Drawing.Size(295, 651)
        Me.navMain.TabIndex = 0
        Me.navMain.Text = "ナビゲーション"
        Me.navMain.View = New DevExpress.XtraNavBar.ViewInfo.NavigationPaneViewInfoRegistrator()
        '
        'navMap
        '
        Me.navMap.Caption = "地図"
        Me.navMap.ControlContainer = Me.NavBarGroupControlContainer2
        Me.navMap.Expanded = True
        Me.navMap.GroupClientHeight = 80
        Me.navMap.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navMap.Name = "navMap"
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer2.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer2.Controls.Add(Me.imageMap)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(293, 531)
        Me.NavBarGroupControlContainer2.TabIndex = 1
        '
        'imageMap
        '
        Me.imageMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imageMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imageMap.InitialImage = Nothing
        Me.imageMap.Location = New System.Drawing.Point(0, 0)
        Me.imageMap.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.imageMap.Name = "imageMap"
        Me.imageMap.Size = New System.Drawing.Size(293, 531)
        Me.imageMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imageMap.TabIndex = 7
        Me.imageMap.TabStop = False
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer1.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer1.Controls.Add(Me.SplitContainer7)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(332, 531)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        Me.SplitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.txtSearch)
        Me.SplitContainer7.Panel1.Controls.Add(Me.btnCancel)
        Me.SplitContainer7.Panel1.Controls.Add(Me.btnSearch)
        Me.SplitContainer7.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.SplitContainer12)
        Me.SplitContainer7.Size = New System.Drawing.Size(332, 531)
        Me.SplitContainer7.SplitterDistance = 94
        Me.SplitContainer7.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.Location = New System.Drawing.Point(10, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Size = New System.Drawing.Size(312, 24)
        Me.txtSearch.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(117, 40)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 36)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "中止"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(10, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 36)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "検索"
        '
        'SplitContainer12
        '
        Me.SplitContainer12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer12.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer12.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer12.Name = "SplitContainer12"
        Me.SplitContainer12.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer12.Panel1
        '
        Me.SplitContainer12.Panel1.Controls.Add(Me.rdoPrefecture)
        '
        'SplitContainer12.Panel2
        '
        Me.SplitContainer12.Panel2.Controls.Add(Me.SplitContainer13)
        Me.SplitContainer12.Size = New System.Drawing.Size(332, 433)
        Me.SplitContainer12.SplitterDistance = 206
        Me.SplitContainer12.TabIndex = 1
        '
        'rdoPrefecture
        '
        Me.rdoPrefecture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoPrefecture.Location = New System.Drawing.Point(0, 0)
        Me.rdoPrefecture.Name = "rdoPrefecture"
        Me.rdoPrefecture.Size = New System.Drawing.Size(332, 206)
        Me.rdoPrefecture.TabIndex = 0
        '
        'SplitContainer13
        '
        Me.SplitContainer13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer13.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer13.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer13.Name = "SplitContainer13"
        Me.SplitContainer13.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer13.Panel1
        '
        Me.SplitContainer13.Panel1.Controls.Add(Me.clbIndustry)
        '
        'SplitContainer13.Panel2
        '
        Me.SplitContainer13.Panel2.Controls.Add(Me.rdoOptions)
        Me.SplitContainer13.Size = New System.Drawing.Size(332, 223)
        Me.SplitContainer13.SplitterDistance = 152
        Me.SplitContainer13.TabIndex = 1
        '
        'clbIndustry
        '
        Me.clbIndustry.CheckOnClick = True
        Me.clbIndustry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbIndustry.Location = New System.Drawing.Point(0, 0)
        Me.clbIndustry.Name = "clbIndustry"
        Me.clbIndustry.Size = New System.Drawing.Size(332, 152)
        Me.clbIndustry.TabIndex = 1
        '
        'rdoOptions
        '
        Me.rdoOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoOptions.Location = New System.Drawing.Point(0, 0)
        Me.rdoOptions.Name = "rdoOptions"
        Me.rdoOptions.Size = New System.Drawing.Size(332, 67)
        Me.rdoOptions.TabIndex = 3
        '
        'navCompany
        '
        Me.navCompany.Caption = "企業情報検索"
        Me.navCompany.ControlContainer = Me.NavBarGroupControlContainer1
        Me.navCompany.GroupClientHeight = 80
        Me.navCompany.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.navCompany.Name = "navCompany"
        '
        'gcCompany
        '
        Me.gcCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCompany.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gcCompany.Location = New System.Drawing.Point(0, 0)
        Me.gcCompany.MainView = Me.gvCompany
        Me.gcCompany.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gcCompany.Name = "gcCompany"
        Me.gcCompany.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riHyperLinkEMail, Me.riHyperLink})
        Me.gcCompany.Size = New System.Drawing.Size(791, 651)
        Me.gcCompany.TabIndex = 1
        Me.gcCompany.UseEmbeddedNavigator = True
        Me.gcCompany.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCompany})
        '
        'gvCompany
        '
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Green
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Green
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "True"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "False"
        Me.gvCompany.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gvCompany.GridControl = Me.gcCompany
        Me.gvCompany.GroupPanelText = "カラムによってソートするには、カラムヘッダーをここにドラッグして下さい。"
        Me.gvCompany.Name = "gvCompany"
        Me.gvCompany.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvCompany.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvCompany.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvCompany.OptionsSelection.MultiSelect = True
        Me.gvCompany.OptionsView.ColumnAutoWidth = False
        Me.gvCompany.OptionsView.ShowAutoFilterRow = True
        '
        'riHyperLinkEMail
        '
        Me.riHyperLinkEMail.AutoHeight = False
        Me.riHyperLinkEMail.Name = "riHyperLinkEMail"
        '
        'riHyperLink
        '
        Me.riHyperLink.AutoHeight = False
        Me.riHyperLink.Name = "riHyperLink"
        '
        'cmsCompanyData
        '
        Me.cmsCompanyData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttsAddToEMailList})
        Me.cmsCompanyData.Name = "cmsCompanyData"
        Me.cmsCompanyData.Size = New System.Drawing.Size(165, 26)
        '
        'ttsAddToEMailList
        '
        Me.ttsAddToEMailList.Image = CType(resources.GetObject("ttsAddToEMailList.Image"), System.Drawing.Image)
        Me.ttsAddToEMailList.Name = "ttsAddToEMailList"
        Me.ttsAddToEMailList.Size = New System.Drawing.Size(164, 22)
        Me.ttsAddToEMailList.Text = "Eメールリストを作成"
        '
        'frmCompanyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 651)
        Me.Controls.Add(Me.splCompany)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompanyData"
        Me.Text = "frmCustomerData"
        CType(Me.splCompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splCompany.ResumeLayout(False)
        CType(Me.navMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navMain.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        CType(Me.imageMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer12.Panel1.ResumeLayout(False)
        Me.SplitContainer12.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer12.ResumeLayout(False)
        CType(Me.rdoPrefecture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer13.Panel1.ResumeLayout(False)
        Me.SplitContainer13.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer13.ResumeLayout(False)
        CType(Me.clbIndustry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoOptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riHyperLinkEMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riHyperLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpDataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCompanyData.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splCompany As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcCompany As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCompany As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents riHyperLinkEMail As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents XpDataView1 As DevExpress.Xpo.XPDataView
    Friend WithEvents cmsCompanyData As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttsAddToEMailList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents navMain As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents navCompany As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainer12 As System.Windows.Forms.SplitContainer
    Friend WithEvents rdoPrefecture As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents SplitContainer13 As System.Windows.Forms.SplitContainer
    Friend WithEvents clbIndustry As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents rdoOptions As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents riHyperLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents navMap As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents imageMap As System.Windows.Forms.PictureBox
End Class
