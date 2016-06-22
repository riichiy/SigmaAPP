<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlaceHolders
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gcPlaceHolder = New DevExpress.XtraGrid.GridControl()
        Me.gvPlaceHolder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAbort = New DevExpress.XtraEditors.SimpleButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gcPlaceHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPlaceHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.White
        Me.PanelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.gcPlaceHolder)
        Me.PanelControl1.Controls.Add(Me.btnAbort)
        Me.PanelControl1.Controls.Add(Me.Label17)
        Me.PanelControl1.Controls.Add(Me.Label16)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(471, 363)
        Me.PanelControl1.TabIndex = 32
        '
        'gcPlaceHolder
        '
        Me.gcPlaceHolder.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.gcPlaceHolder.Location = New System.Drawing.Point(8, 73)
        Me.gcPlaceHolder.MainView = Me.gvPlaceHolder
        Me.gcPlaceHolder.Margin = New System.Windows.Forms.Padding(2)
        Me.gcPlaceHolder.Name = "gcPlaceHolder"
        Me.gcPlaceHolder.Size = New System.Drawing.Size(454, 230)
        Me.gcPlaceHolder.TabIndex = 70
        Me.gcPlaceHolder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPlaceHolder})
        '
        'gvPlaceHolder
        '
        Me.gvPlaceHolder.GridControl = Me.gcPlaceHolder
        Me.gvPlaceHolder.Name = "gvPlaceHolder"
        Me.gvPlaceHolder.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPlaceHolder.OptionsView.ShowGroupPanel = False
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(387, 318)
        Me.btnAbort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(75, 28)
        Me.btnAbort.TabIndex = 69
        Me.btnAbort.Text = "完了"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(449, 40)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "下記の文字変換はメールの件名、ボディ部に利用でき、登録データからの情報に送信前に自動交換します。"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "文字変換"
        '
        'frmPlaceHolders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(471, 363)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(494, 600)
        Me.Name = "frmPlaceHolders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文字変換"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.gcPlaceHolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPlaceHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnAbort As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcPlaceHolder As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPlaceHolder As DevExpress.XtraGrid.Views.Grid.GridView

End Class
