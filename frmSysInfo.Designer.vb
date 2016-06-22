<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        Dim notifyEvent As System.Threading.WaitHandle = New System.Threading.EventWaitHandle(False, System.Threading.EventResetMode.AutoReset)
        System.Threading.Interlocked.Add(lockTimerCounter, 1)
        If pollingTimer IsNot Nothing Then
            pollingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)
            pollingTimer.Dispose(notifyEvent)
            pollingTimer = Nothing
        End If
        System.Threading.WaitHandle.WaitAll(New System.Threading.WaitHandle() {notifyEvent})
        If wmiService IsNot Nothing Then
            wmiService.Dispose()
            wmiService = Nothing
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysInfo))
        Dim ScaleLabel37 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel38 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel39 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel40 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel41 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel42 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel43 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel44 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel45 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel46 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel47 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel48 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleIndicatorState15 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
        Dim ScaleIndicatorState16 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
        Dim ScaleLabel49 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel50 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel51 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleIndicatorState17 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
        Dim ScaleIndicatorState18 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
        Dim ScaleLabel52 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel53 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleLabel54 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel()
        Dim ScaleIndicatorState19 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
        Dim ScaleIndicatorState20 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
        Dim ScaleIndicatorState21 As DevExpress.XtraGauges.Core.Model.ScaleIndicatorState = New DevExpress.XtraGauges.Core.Model.ScaleIndicatorState()
        Me.splWid = New System.Windows.Forms.SplitContainer()
        Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.arcScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.arcScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.arcScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
        Me.labelComponent2 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
        Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.arcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.arcScaleRangeBarComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.arcScaleRangeBarComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.arcScaleRangeBarComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.arcScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.London = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.CircularGauge4 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleBackgroundLayerComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.ArcScaleComponent14 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleEffectLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
        Me.ArcScaleStateIndicatorComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
        Me.ArcScaleStateIndicatorComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
        Me.ArcScaleNeedleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleNeedleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleComponent15 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleNeedleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleComponent16 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleSpindleCapComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
        Me.Washington = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.CircularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleBackgroundLayerComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.ArcScaleComponent11 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleEffectLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
        Me.ArcScaleStateIndicatorComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
        Me.ArcScaleStateIndicatorComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
        Me.ArcScaleNeedleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleNeedleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleComponent12 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleNeedleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleComponent13 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleSpindleCapComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
        Me.Tokyo = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.CircularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleBackgroundLayerComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.ArcScaleComponent8 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
        Me.ArcScaleStateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
        Me.ArcScaleStateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
        Me.ArcScaleStateIndicatorComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent()
        Me.ArcScaleNeedleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleNeedleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleComponent9 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleNeedleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleComponent10 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.splWid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splWid.Panel1.SuspendLayout()
        Me.splWid.Panel2.SuspendLayout()
        Me.splWid.SuspendLayout()
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labelComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleRangeBarComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleRangeBarComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleRangeBarComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CircularGauge4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleEffectLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleStateIndicatorComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleSpindleCapComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircularGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleEffectLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleStateIndicatorComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleSpindleCapComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleStateIndicatorComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splWid
        '
        Me.splWid.BackColor = System.Drawing.SystemColors.Control
        Me.splWid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splWid.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splWid.Location = New System.Drawing.Point(0, 0)
        Me.splWid.Name = "splWid"
        Me.splWid.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splWid.Panel1
        '
        Me.splWid.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.splWid.Panel1.Controls.Add(Me.gaugeControl1)
        '
        'splWid.Panel2
        '
        Me.splWid.Panel2.Controls.Add(Me.LayoutControl1)
        Me.splWid.Size = New System.Drawing.Size(520, 573)
        Me.splWid.SplitterDistance = 381
        Me.splWid.SplitterWidth = 1
        Me.splWid.TabIndex = 0
        '
        'gaugeControl1
        '
        Me.gaugeControl1.BackColor = System.Drawing.Color.Transparent
        Me.gaugeControl1.BackgroundImage = CType(resources.GetObject("gaugeControl1.BackgroundImage"), System.Drawing.Image)
        Me.gaugeControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
        Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
        Me.gaugeControl1.Name = "gaugeControl1"
        Me.gaugeControl1.Size = New System.Drawing.Size(520, 381)
        Me.gaugeControl1.TabIndex = 3
        '
        'circularGauge1
        '
        Me.circularGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.[False]
        Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1, Me.arcScaleBackgroundLayerComponent2, Me.arcScaleBackgroundLayerComponent3, Me.arcScaleBackgroundLayerComponent4})
        Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 508, 369)
        Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.labelComponent1, Me.labelComponent2})
        Me.circularGauge1.Name = "circularGauge1"
        Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1, Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
        Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.arcScaleRangeBarComponent1, Me.arcScaleRangeBarComponent2, Me.arcScaleRangeBarComponent3, Me.arcScaleRangeBarComponent4})
        Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1, Me.arcScaleComponent2, Me.arcScaleComponent3, Me.arcScaleComponent4, Me.arcScaleComponent5, Me.arcScaleComponent6, Me.arcScaleComponent7})
        '
        'arcScaleBackgroundLayerComponent1
        '
        Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
        Me.arcScaleBackgroundLayerComponent1.Name = "bgCPU"
        Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
        Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(122.0!, 122.0!)
        Me.arcScaleBackgroundLayerComponent1.ZOrder = -5
        '
        'arcScaleComponent1
        '
        Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 75.0!)
        Me.arcScaleComponent1.EndAngle = 60.0!
        ScaleLabel37.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5.0!)
        ScaleLabel37.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel37.FormatString = "{0} {1:F0}%"
        ScaleLabel37.Name = "Label0"
        ScaleLabel37.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 122.0!)
        ScaleLabel37.Size = New System.Drawing.SizeF(100.0!, 12.0!)
        ScaleLabel37.Text = "Total:"
        ScaleLabel38.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5.0!)
        ScaleLabel38.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DimGray")
        ScaleLabel38.FormatString = "{0}"
        ScaleLabel38.Name = "Label1"
        ScaleLabel38.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 95.0!)
        ScaleLabel38.Size = New System.Drawing.SizeF(50.0!, 12.0!)
        ScaleLabel38.Text = "Kernel"
        ScaleLabel39.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5.0!)
        ScaleLabel39.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DarkGray")
        ScaleLabel39.FormatString = "{0}"
        ScaleLabel39.Name = "Label2"
        ScaleLabel39.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 88.0!)
        ScaleLabel39.Size = New System.Drawing.SizeF(50.0!, 12.0!)
        ScaleLabel39.Text = "User"
        Me.arcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel37, ScaleLabel38, ScaleLabel39})
        Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.4!, 0.6!)
        Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
        Me.arcScaleComponent1.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent1.MaxValue = 100.0!
        Me.arcScaleComponent1.MinorTickCount = 4
        Me.arcScaleComponent1.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3!, 0.5!)
        Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
        Me.arcScaleComponent1.Name = "cpuTotal"
        Me.arcScaleComponent1.RadiusX = 50.0!
        Me.arcScaleComponent1.RadiusY = 50.0!
        Me.arcScaleComponent1.StartAngle = -240.0!
        Me.arcScaleComponent1.Value = 15.0!
        Me.arcScaleComponent1.ZOrder = -50
        '
        'arcScaleBackgroundLayerComponent2
        '
        Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent4
        Me.arcScaleBackgroundLayerComponent2.Name = "bgOS"
        Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
        Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(100.0!, 100.0!)
        Me.arcScaleBackgroundLayerComponent2.ZOrder = 1050
        '
        'arcScaleComponent4
        '
        Me.arcScaleComponent4.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent4.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent4.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent4.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent4.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        Me.arcScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 175.0!)
        Me.arcScaleComponent4.EndAngle = 10.0!
        ScaleLabel40.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel40.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel40.FormatString = "{0}{1:F0}"
        ScaleLabel40.Name = "Label1"
        ScaleLabel40.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 160.0!)
        ScaleLabel40.Size = New System.Drawing.SizeF(50.0!, 12.0!)
        ScaleLabel40.Text = "Threads:"
        Me.arcScaleComponent4.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel40})
        Me.arcScaleComponent4.MajorTickCount = 7
        Me.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent4.MajorTickmark.ShapeOffset = -1.0!
        Me.arcScaleComponent4.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.25!, 0.4!)
        Me.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
        Me.arcScaleComponent4.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent4.MaxValue = 1300.0!
        Me.arcScaleComponent4.MinorTickCount = 4
        Me.arcScaleComponent4.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3!, 0.5!)
        Me.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
        Me.arcScaleComponent4.MinValue = 100.0!
        Me.arcScaleComponent4.Name = "osThreads"
        Me.arcScaleComponent4.RadiusX = 40.0!
        Me.arcScaleComponent4.RadiusY = 40.0!
        Me.arcScaleComponent4.StartAngle = -190.0!
        Me.arcScaleComponent4.Value = 500.0!
        '
        'arcScaleBackgroundLayerComponent3
        '
        Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent6
        Me.arcScaleBackgroundLayerComponent3.Name = "bgMemory"
        Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
        Me.arcScaleBackgroundLayerComponent3.Size = New System.Drawing.SizeF(92.0!, 92.0!)
        Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
        '
        'arcScaleComponent6
        '
        Me.arcScaleComponent6.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent6.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent6.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent6.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent6.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3.0!)
        Me.arcScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(45.0!, 135.0!)
        Me.arcScaleComponent6.EndAngle = 60.0!
        ScaleLabel41.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel41.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel41.FormatString = "{0} {2:P1}"
        ScaleLabel41.Name = "Label0"
        ScaleLabel41.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(50.0!, 150.0!)
        ScaleLabel41.Size = New System.Drawing.SizeF(100.0!, 12.0!)
        ScaleLabel41.Text = "Free:"
        ScaleLabel42.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel42.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
        ScaleLabel42.FormatString = "{0}"
        ScaleLabel42.Name = "Label1"
        ScaleLabel42.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(50.0!, 125.0!)
        ScaleLabel42.Text = "Memory, MB"
        Me.arcScaleComponent6.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel41, ScaleLabel42})
        Me.arcScaleComponent6.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent6.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent6.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.2!, 0.3!)
        Me.arcScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
        Me.arcScaleComponent6.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent6.MaxValue = 100.0!
        Me.arcScaleComponent6.MinorTickCount = 4
        Me.arcScaleComponent6.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.15!, 0.25!)
        Me.arcScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
        Me.arcScaleComponent6.Name = "memoryTotal"
        Me.arcScaleComponent6.RadiusX = 40.0!
        Me.arcScaleComponent6.RadiusY = 40.0!
        Me.arcScaleComponent6.StartAngle = -240.0!
        Me.arcScaleComponent6.Value = 15.0!
        '
        'arcScaleBackgroundLayerComponent4
        '
        Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScaleComponent7
        Me.arcScaleBackgroundLayerComponent4.Name = "bgHDD"
        Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
        Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(92.0!, 92.0!)
        Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
        '
        'arcScaleComponent7
        '
        Me.arcScaleComponent7.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent7.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent7.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent7.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent7.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3.0!)
        Me.arcScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 135.0!)
        Me.arcScaleComponent7.EndAngle = 60.0!
        ScaleLabel43.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel43.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel43.FormatString = "{0} {2:P1}"
        ScaleLabel43.Name = "Label0"
        ScaleLabel43.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 150.0!)
        ScaleLabel43.Size = New System.Drawing.SizeF(100.0!, 12.0!)
        ScaleLabel43.Text = "Free:"
        ScaleLabel44.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel44.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
        ScaleLabel44.FormatString = "{0}"
        ScaleLabel44.Name = "Label1"
        ScaleLabel44.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 125.0!)
        ScaleLabel44.Text = "HDD, GB"
        Me.arcScaleComponent7.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel43, ScaleLabel44})
        Me.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent7.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent7.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.2!, 0.3!)
        Me.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
        Me.arcScaleComponent7.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent7.MaxValue = 100.0!
        Me.arcScaleComponent7.MinorTickCount = 4
        Me.arcScaleComponent7.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.15!, 0.25!)
        Me.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
        Me.arcScaleComponent7.Name = "hddTotal"
        Me.arcScaleComponent7.RadiusX = 40.0!
        Me.arcScaleComponent7.RadiusY = 40.0!
        Me.arcScaleComponent7.StartAngle = -240.0!
        Me.arcScaleComponent7.Value = 15.0!
        '
        'labelComponent1
        '
        Me.labelComponent1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
        Me.labelComponent1.Name = "processorName"
        Me.labelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 62.0!)
        Me.labelComponent1.Size = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.labelComponent1.Text = "CPU Info"
        Me.labelComponent1.ZOrder = -45
        '
        'labelComponent2
        '
        Me.labelComponent2.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        Me.labelComponent2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
        Me.labelComponent2.Name = "osName"
        Me.labelComponent2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 175.0!)
        Me.labelComponent2.Size = New System.Drawing.SizeF(55.0!, 25.0!)
        Me.labelComponent2.Text = "OS Info"
        Me.labelComponent2.ZOrder = -2
        '
        'arcScaleNeedleComponent1
        '
        Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
        Me.arcScaleNeedleComponent1.Name = "needleCpu"
        Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
        Me.arcScaleNeedleComponent1.StartOffset = -2.75!
        Me.arcScaleNeedleComponent1.ZOrder = -50
        '
        'arcScaleNeedleComponent2
        '
        Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent6
        Me.arcScaleNeedleComponent2.Name = "needleRAM"
        Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
        Me.arcScaleNeedleComponent2.StartOffset = -2.75!
        Me.arcScaleNeedleComponent2.ZOrder = -50
        '
        'arcScaleNeedleComponent3
        '
        Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent7
        Me.arcScaleNeedleComponent3.Name = "needleHDD"
        Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
        Me.arcScaleNeedleComponent3.StartOffset = -2.75!
        Me.arcScaleNeedleComponent3.ZOrder = -50
        '
        'arcScaleRangeBarComponent1
        '
        Me.arcScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleRangeBarComponent1.ArcScale = Me.arcScaleComponent2
        Me.arcScaleRangeBarComponent1.EndOffset = 15.0!
        Me.arcScaleRangeBarComponent1.Name = "rangeUser"
        Me.arcScaleRangeBarComponent1.StartOffset = 40.0!
        Me.arcScaleRangeBarComponent1.ZOrder = -10
        '
        'arcScaleComponent2
        '
        Me.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 75.0!)
        Me.arcScaleComponent2.EndAngle = 60.0!
        Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent2.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6!, 0.8!)
        Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
        Me.arcScaleComponent2.MajorTickmark.ShowText = False
        Me.arcScaleComponent2.MajorTickmark.ShowTick = False
        Me.arcScaleComponent2.MajorTickmark.TextOffset = -10.0!
        Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent2.MaxValue = 100.0!
        Me.arcScaleComponent2.MinorTickCount = 4
        Me.arcScaleComponent2.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6!, 1.0!)
        Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
        Me.arcScaleComponent2.MinorTickmark.ShowTick = False
        Me.arcScaleComponent2.Name = "cpuUser"
        Me.arcScaleComponent2.RadiusX = 50.0!
        Me.arcScaleComponent2.RadiusY = 50.0!
        Me.arcScaleComponent2.StartAngle = -240.0!
        Me.arcScaleComponent2.Value = 15.0!
        Me.arcScaleComponent2.ZOrder = 1001
        '
        'arcScaleRangeBarComponent2
        '
        Me.arcScaleRangeBarComponent2.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
        Me.arcScaleRangeBarComponent2.ArcScale = Me.arcScaleComponent3
        Me.arcScaleRangeBarComponent2.EndOffset = 15.0!
        Me.arcScaleRangeBarComponent2.Name = "rangeKernel"
        Me.arcScaleRangeBarComponent2.StartOffset = 40.0!
        Me.arcScaleRangeBarComponent2.ZOrder = -11
        '
        'arcScaleComponent3
        '
        Me.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent3.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.arcScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 75.0!)
        Me.arcScaleComponent3.EndAngle = 60.0!
        Me.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent3.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent3.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6!, 0.8!)
        Me.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
        Me.arcScaleComponent3.MajorTickmark.ShowText = False
        Me.arcScaleComponent3.MajorTickmark.ShowTick = False
        Me.arcScaleComponent3.MajorTickmark.TextOffset = -10.0!
        Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent3.MaxValue = 100.0!
        Me.arcScaleComponent3.MinorTickCount = 4
        Me.arcScaleComponent3.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6!, 1.0!)
        Me.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
        Me.arcScaleComponent3.MinorTickmark.ShowTick = False
        Me.arcScaleComponent3.Name = "cpuKernel"
        Me.arcScaleComponent3.RadiusX = 50.0!
        Me.arcScaleComponent3.RadiusY = 50.0!
        Me.arcScaleComponent3.StartAngle = -240.0!
        Me.arcScaleComponent3.Value = 3.0!
        Me.arcScaleComponent3.ZOrder = 1002
        '
        'arcScaleRangeBarComponent3
        '
        Me.arcScaleRangeBarComponent3.AnchorValue = 100.0!
        Me.arcScaleRangeBarComponent3.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleRangeBarComponent3.ArcScale = Me.arcScaleComponent4
        Me.arcScaleRangeBarComponent3.EndOffset = -3.0!
        Me.arcScaleRangeBarComponent3.Name = "rangeThreads"
        Me.arcScaleRangeBarComponent3.StartOffset = 35.0!
        Me.arcScaleRangeBarComponent3.ZOrder = 1
        '
        'arcScaleRangeBarComponent4
        '
        Me.arcScaleRangeBarComponent4.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleRangeBarComponent4.ArcScale = Me.arcScaleComponent5
        Me.arcScaleRangeBarComponent4.EndOffset = -2.0!
        Me.arcScaleRangeBarComponent4.Name = "rangeProcesses"
        Me.arcScaleRangeBarComponent4.StartOffset = 35.0!
        Me.arcScaleRangeBarComponent4.ZOrder = 1
        '
        'arcScaleComponent5
        '
        Me.arcScaleComponent5.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent5.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent5.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent5.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.arcScaleComponent5.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3.0!)
        Me.arcScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 175.0!)
        Me.arcScaleComponent5.EndAngle = 150.0!
        ScaleLabel45.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel45.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel45.FormatString = "{0}{1:F0}"
        ScaleLabel45.Name = "Label1"
        ScaleLabel45.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 195.0!)
        ScaleLabel45.Size = New System.Drawing.SizeF(50.0!, 12.0!)
        ScaleLabel45.Text = "Processes:"
        Me.arcScaleComponent5.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel45})
        Me.arcScaleComponent5.MajorTickCount = 6
        Me.arcScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent5.MajorTickmark.ShapeOffset = -1.0!
        Me.arcScaleComponent5.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3!, 0.4!)
        Me.arcScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_2
        Me.arcScaleComponent5.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent5.MaxValue = 150.0!
        Me.arcScaleComponent5.MinorTickCount = 4
        Me.arcScaleComponent5.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3!, 0.5!)
        Me.arcScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_1
        Me.arcScaleComponent5.Name = "osProcesses"
        Me.arcScaleComponent5.RadiusX = 40.0!
        Me.arcScaleComponent5.RadiusY = 40.0!
        Me.arcScaleComponent5.StartAngle = 30.0!
        Me.arcScaleComponent5.Value = 50.0!
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.London)
        Me.LayoutControl1.Controls.Add(Me.Washington)
        Me.LayoutControl1.Controls.Add(Me.Tokyo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(617, 376, 250, 350)
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
        Me.LayoutControl1.Size = New System.Drawing.Size(520, 191)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'London
        '
        Me.London.BackColor = System.Drawing.Color.Transparent
        Me.London.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.London.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge4})
        Me.London.Location = New System.Drawing.Point(347, 12)
        Me.London.Name = "London"
        Me.London.Size = New System.Drawing.Size(161, 167)
        Me.London.TabIndex = 7
        '
        'CircularGauge4
        '
        Me.CircularGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent7})
        Me.CircularGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 149, 155)
        Me.CircularGauge4.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.ArcScaleEffectLayerComponent3})
        Me.CircularGauge4.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.ArcScaleStateIndicatorComponent6, Me.ArcScaleStateIndicatorComponent7})
        Me.CircularGauge4.Name = "CircularGauge4"
        Me.CircularGauge4.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent10, Me.ArcScaleNeedleComponent11, Me.ArcScaleNeedleComponent12})
        Me.CircularGauge4.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent14, Me.ArcScaleComponent15, Me.ArcScaleComponent16})
        Me.CircularGauge4.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.ArcScaleSpindleCapComponent3})
        '
        'ArcScaleBackgroundLayerComponent7
        '
        Me.ArcScaleBackgroundLayerComponent7.ArcScale = Me.ArcScaleComponent14
        Me.ArcScaleBackgroundLayerComponent7.Name = "arcScaleBackgroundLayerComponent2"
        Me.ArcScaleBackgroundLayerComponent7.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
        Me.ArcScaleBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
        Me.ArcScaleBackgroundLayerComponent7.Size = New System.Drawing.SizeF(216.0!, 250.0!)
        Me.ArcScaleBackgroundLayerComponent7.ZOrder = 1000
        '
        'ArcScaleComponent14
        '
        Me.ArcScaleComponent14.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent14.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent14.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent14.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent14.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ArcScaleComponent14.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.ArcScaleComponent14.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent14.EndAngle = 270.0!
        ScaleLabel46.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ScaleLabel46.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel46.FormatString = "{0}"
        ScaleLabel46.Name = "Label0"
        ScaleLabel46.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
        ScaleLabel46.Size = New System.Drawing.SizeF(70.0!, 20.0!)
        ScaleLabel46.Text = "London"
        ScaleLabel47.FormatString = "{0}"
        ScaleLabel47.Name = "Label1"
        ScaleLabel47.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
        ScaleLabel47.Size = New System.Drawing.SizeF(90.0!, 15.0!)
        ScaleLabel47.Text = "United Kingdom"
        ScaleLabel48.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
        ScaleLabel48.FormatString = "{0:F4}"
        ScaleLabel48.Name = "Label2"
        ScaleLabel48.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(168.0!, 225.0!)
        ScaleLabel48.Size = New System.Drawing.SizeF(70.0!, 20.0!)
        ScaleLabel48.Text = "50.065"
        Me.ArcScaleComponent14.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel46, ScaleLabel47, ScaleLabel48})
        Me.ArcScaleComponent14.MajorTickCount = 13
        Me.ArcScaleComponent14.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent14.MajorTickmark.ShapeOffset = -9.5!
        Me.ArcScaleComponent14.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
        Me.ArcScaleComponent14.MajorTickmark.ShowFirst = False
        Me.ArcScaleComponent14.MajorTickmark.TextOffset = -18.0!
        Me.ArcScaleComponent14.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent14.MaxValue = 12.0!
        Me.ArcScaleComponent14.MinorTickCount = 4
        Me.ArcScaleComponent14.MinorTickmark.ShapeOffset = -1.5!
        Me.ArcScaleComponent14.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
        Me.ArcScaleComponent14.Name = "arcScaleComponent4"
        Me.ArcScaleComponent14.RadiusX = 74.0!
        Me.ArcScaleComponent14.RadiusY = 74.0!
        Me.ArcScaleComponent14.StartAngle = -90.0!
        '
        'ArcScaleEffectLayerComponent3
        '
        Me.ArcScaleEffectLayerComponent3.ArcScale = Me.ArcScaleComponent14
        Me.ArcScaleEffectLayerComponent3.Name = "arcScaleEffectLayerComponent2"
        Me.ArcScaleEffectLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
        Me.ArcScaleEffectLayerComponent3.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
        Me.ArcScaleEffectLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
        Me.ArcScaleEffectLayerComponent3.Size = New System.Drawing.SizeF(170.0!, 85.0!)
        Me.ArcScaleEffectLayerComponent3.ZOrder = -1000
        '
        'ArcScaleStateIndicatorComponent6
        '
        Me.ArcScaleStateIndicatorComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
        Me.ArcScaleStateIndicatorComponent6.IndicatorScale = Me.ArcScaleComponent14
        Me.ArcScaleStateIndicatorComponent6.Name = "arcScaleStateIndicatorComponent4"
        Me.ArcScaleStateIndicatorComponent6.Size = New System.Drawing.SizeF(40.0!, 21.0!)
        ScaleIndicatorState15.IntervalLength = 12.0!
        ScaleIndicatorState15.Name = "Default"
        ScaleIndicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagUK
        Me.ArcScaleStateIndicatorComponent6.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState15})
        Me.ArcScaleStateIndicatorComponent6.ZOrder = -100
        '
        'ArcScaleStateIndicatorComponent7
        '
        Me.ArcScaleStateIndicatorComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(130.0!, 223.0!)
        Me.ArcScaleStateIndicatorComponent7.IndicatorScale = Me.ArcScaleComponent14
        Me.ArcScaleStateIndicatorComponent7.Name = "arcScaleStateIndicatorComponent5"
        Me.ArcScaleStateIndicatorComponent7.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
        Me.ArcScaleStateIndicatorComponent7.Size = New System.Drawing.SizeF(20.0!, 20.0!)
        ScaleIndicatorState16.IntervalLength = 12.0!
        ScaleIndicatorState16.Name = "Default"
        ScaleIndicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyGBP
        Me.ArcScaleStateIndicatorComponent7.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState16})
        Me.ArcScaleStateIndicatorComponent7.ZOrder = -100
        '
        'ArcScaleNeedleComponent10
        '
        Me.ArcScaleNeedleComponent10.ArcScale = Me.ArcScaleComponent14
        Me.ArcScaleNeedleComponent10.EndOffset = 10.0!
        Me.ArcScaleNeedleComponent10.Name = "arcScaleNeedleComponent4"
        Me.ArcScaleNeedleComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
        Me.ArcScaleNeedleComponent10.ZOrder = -50
        '
        'ArcScaleNeedleComponent11
        '
        Me.ArcScaleNeedleComponent11.ArcScale = Me.ArcScaleComponent15
        Me.ArcScaleNeedleComponent11.EndOffset = -5.0!
        Me.ArcScaleNeedleComponent11.Name = "arcScaleNeedleComponent5"
        Me.ArcScaleNeedleComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
        Me.ArcScaleNeedleComponent11.ZOrder = -51
        '
        'ArcScaleComponent15
        '
        Me.ArcScaleComponent15.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent15.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent15.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent15.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent15.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent15.EndAngle = 270.0!
        Me.ArcScaleComponent15.MajorTickCount = 2
        Me.ArcScaleComponent15.MajorTickmark.ShowText = False
        Me.ArcScaleComponent15.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent15.MaxValue = 12.0!
        Me.ArcScaleComponent15.MinorTickCount = 0
        Me.ArcScaleComponent15.Name = "arcScaleComponent5"
        Me.ArcScaleComponent15.RadiusX = 74.0!
        Me.ArcScaleComponent15.RadiusY = 74.0!
        Me.ArcScaleComponent15.StartAngle = -90.0!
        Me.ArcScaleComponent15.Value = 3.0!
        '
        'ArcScaleNeedleComponent12
        '
        Me.ArcScaleNeedleComponent12.ArcScale = Me.ArcScaleComponent16
        Me.ArcScaleNeedleComponent12.EndOffset = -10.0!
        Me.ArcScaleNeedleComponent12.Name = "arcScaleNeedleComponent6"
        Me.ArcScaleNeedleComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
        Me.ArcScaleNeedleComponent12.ZOrder = -52
        '
        'ArcScaleComponent16
        '
        Me.ArcScaleComponent16.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent16.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent16.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent16.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent16.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent16.EndAngle = 270.0!
        Me.ArcScaleComponent16.MajorTickCount = 2
        Me.ArcScaleComponent16.MajorTickmark.ShowText = False
        Me.ArcScaleComponent16.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent16.MaxValue = 12.0!
        Me.ArcScaleComponent16.MinorTickCount = 0
        Me.ArcScaleComponent16.Name = "arcScaleComponent6"
        Me.ArcScaleComponent16.RadiusX = 74.0!
        Me.ArcScaleComponent16.RadiusY = 74.0!
        Me.ArcScaleComponent16.StartAngle = -90.0!
        Me.ArcScaleComponent16.Value = 1.5!
        '
        'ArcScaleSpindleCapComponent3
        '
        Me.ArcScaleSpindleCapComponent3.ArcScale = Me.ArcScaleComponent14
        Me.ArcScaleSpindleCapComponent3.Name = "arcScaleSpindleCapComponent2"
        Me.ArcScaleSpindleCapComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
        Me.ArcScaleSpindleCapComponent3.Size = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.ArcScaleSpindleCapComponent3.ZOrder = -100
        '
        'Washington
        '
        Me.Washington.BackColor = System.Drawing.Color.Transparent
        Me.Washington.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Washington.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge3})
        Me.Washington.Location = New System.Drawing.Point(179, 12)
        Me.Washington.Name = "Washington"
        Me.Washington.Size = New System.Drawing.Size(164, 167)
        Me.Washington.TabIndex = 4
        '
        'CircularGauge3
        '
        Me.CircularGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent6})
        Me.CircularGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 152, 155)
        Me.CircularGauge3.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.ArcScaleEffectLayerComponent2})
        Me.CircularGauge3.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.ArcScaleStateIndicatorComponent4, Me.ArcScaleStateIndicatorComponent5})
        Me.CircularGauge3.Name = "CircularGauge3"
        Me.CircularGauge3.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent7, Me.ArcScaleNeedleComponent8, Me.ArcScaleNeedleComponent9})
        Me.CircularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent11, Me.ArcScaleComponent12, Me.ArcScaleComponent13})
        Me.CircularGauge3.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.ArcScaleSpindleCapComponent2})
        '
        'ArcScaleBackgroundLayerComponent6
        '
        Me.ArcScaleBackgroundLayerComponent6.ArcScale = Me.ArcScaleComponent11
        Me.ArcScaleBackgroundLayerComponent6.Name = "arcScaleBackgroundLayerComponent1"
        Me.ArcScaleBackgroundLayerComponent6.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
        Me.ArcScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
        Me.ArcScaleBackgroundLayerComponent6.Size = New System.Drawing.SizeF(216.0!, 250.0!)
        Me.ArcScaleBackgroundLayerComponent6.ZOrder = 1000
        '
        'ArcScaleComponent11
        '
        Me.ArcScaleComponent11.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent11.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent11.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent11.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent11.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ArcScaleComponent11.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.ArcScaleComponent11.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent11.EndAngle = 270.0!
        ScaleLabel49.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ScaleLabel49.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel49.FormatString = "{0}"
        ScaleLabel49.Name = "Label0"
        ScaleLabel49.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
        ScaleLabel49.Size = New System.Drawing.SizeF(70.0!, 20.0!)
        ScaleLabel49.Text = "Cincinnati"
        ScaleLabel50.FormatString = "{0}"
        ScaleLabel50.Name = "Label1"
        ScaleLabel50.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
        ScaleLabel50.Size = New System.Drawing.SizeF(50.0!, 15.0!)
        ScaleLabel50.Text = "U.S.A."
        ScaleLabel51.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
        ScaleLabel51.FormatString = "{0}"
        ScaleLabel51.Name = "Label2"
        ScaleLabel51.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(160.0!, 225.0!)
        ScaleLabel51.Size = New System.Drawing.SizeF(70.0!, 20.0!)
        ScaleLabel51.Text = "100.00"
        Me.ArcScaleComponent11.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel49, ScaleLabel50, ScaleLabel51})
        Me.ArcScaleComponent11.MajorTickCount = 13
        Me.ArcScaleComponent11.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent11.MajorTickmark.ShapeOffset = -9.5!
        Me.ArcScaleComponent11.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
        Me.ArcScaleComponent11.MajorTickmark.ShowFirst = False
        Me.ArcScaleComponent11.MajorTickmark.TextOffset = -18.0!
        Me.ArcScaleComponent11.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent11.MaxValue = 12.0!
        Me.ArcScaleComponent11.MinorTickCount = 4
        Me.ArcScaleComponent11.MinorTickmark.ShapeOffset = -1.5!
        Me.ArcScaleComponent11.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
        Me.ArcScaleComponent11.Name = "arcScaleComponent1"
        Me.ArcScaleComponent11.RadiusX = 74.0!
        Me.ArcScaleComponent11.RadiusY = 74.0!
        Me.ArcScaleComponent11.StartAngle = -90.0!
        '
        'ArcScaleEffectLayerComponent2
        '
        Me.ArcScaleEffectLayerComponent2.ArcScale = Me.ArcScaleComponent11
        Me.ArcScaleEffectLayerComponent2.Name = "arcScaleEffectLayerComponent1"
        Me.ArcScaleEffectLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
        Me.ArcScaleEffectLayerComponent2.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
        Me.ArcScaleEffectLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
        Me.ArcScaleEffectLayerComponent2.Size = New System.Drawing.SizeF(170.0!, 85.0!)
        Me.ArcScaleEffectLayerComponent2.ZOrder = -1000
        '
        'ArcScaleStateIndicatorComponent4
        '
        Me.ArcScaleStateIndicatorComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
        Me.ArcScaleStateIndicatorComponent4.IndicatorScale = Me.ArcScaleComponent11
        Me.ArcScaleStateIndicatorComponent4.Name = "arcScaleStateIndicatorComponent1"
        Me.ArcScaleStateIndicatorComponent4.Size = New System.Drawing.SizeF(40.0!, 21.0!)
        ScaleIndicatorState17.IntervalLength = 12.0!
        ScaleIndicatorState17.Name = "Default"
        ScaleIndicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagUSA
        Me.ArcScaleStateIndicatorComponent4.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState17})
        Me.ArcScaleStateIndicatorComponent4.ZOrder = -100
        '
        'ArcScaleStateIndicatorComponent5
        '
        Me.ArcScaleStateIndicatorComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(123.0!, 223.0!)
        Me.ArcScaleStateIndicatorComponent5.IndicatorScale = Me.ArcScaleComponent11
        Me.ArcScaleStateIndicatorComponent5.Name = "arcScaleStateIndicatorComponent2"
        Me.ArcScaleStateIndicatorComponent5.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
        Me.ArcScaleStateIndicatorComponent5.Size = New System.Drawing.SizeF(20.0!, 20.0!)
        ScaleIndicatorState18.IntervalLength = 12.0!
        ScaleIndicatorState18.Name = "Default"
        ScaleIndicatorState18.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyUSD
        Me.ArcScaleStateIndicatorComponent5.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState18})
        Me.ArcScaleStateIndicatorComponent5.ZOrder = -100
        '
        'ArcScaleNeedleComponent7
        '
        Me.ArcScaleNeedleComponent7.ArcScale = Me.ArcScaleComponent11
        Me.ArcScaleNeedleComponent7.EndOffset = 10.0!
        Me.ArcScaleNeedleComponent7.Name = "arcScaleNeedleComponent1"
        Me.ArcScaleNeedleComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
        Me.ArcScaleNeedleComponent7.ZOrder = -50
        '
        'ArcScaleNeedleComponent8
        '
        Me.ArcScaleNeedleComponent8.ArcScale = Me.ArcScaleComponent12
        Me.ArcScaleNeedleComponent8.EndOffset = -5.0!
        Me.ArcScaleNeedleComponent8.Name = "arcScaleNeedleComponent2"
        Me.ArcScaleNeedleComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
        Me.ArcScaleNeedleComponent8.ZOrder = -51
        '
        'ArcScaleComponent12
        '
        Me.ArcScaleComponent12.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent12.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent12.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent12.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent12.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent12.EndAngle = 270.0!
        Me.ArcScaleComponent12.MajorTickCount = 2
        Me.ArcScaleComponent12.MajorTickmark.ShowText = False
        Me.ArcScaleComponent12.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent12.MaxValue = 12.0!
        Me.ArcScaleComponent12.MinorTickCount = 0
        Me.ArcScaleComponent12.Name = "arcScaleComponent2"
        Me.ArcScaleComponent12.RadiusX = 74.0!
        Me.ArcScaleComponent12.RadiusY = 74.0!
        Me.ArcScaleComponent12.StartAngle = -90.0!
        Me.ArcScaleComponent12.Value = 3.0!
        '
        'ArcScaleNeedleComponent9
        '
        Me.ArcScaleNeedleComponent9.ArcScale = Me.ArcScaleComponent13
        Me.ArcScaleNeedleComponent9.EndOffset = -10.0!
        Me.ArcScaleNeedleComponent9.Name = "arcScaleNeedleComponent3"
        Me.ArcScaleNeedleComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
        Me.ArcScaleNeedleComponent9.ZOrder = -52
        '
        'ArcScaleComponent13
        '
        Me.ArcScaleComponent13.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent13.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent13.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent13.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent13.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent13.EndAngle = 270.0!
        Me.ArcScaleComponent13.MajorTickCount = 2
        Me.ArcScaleComponent13.MajorTickmark.ShowText = False
        Me.ArcScaleComponent13.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent13.MaxValue = 12.0!
        Me.ArcScaleComponent13.MinorTickCount = 0
        Me.ArcScaleComponent13.Name = "arcScaleComponent3"
        Me.ArcScaleComponent13.RadiusX = 74.0!
        Me.ArcScaleComponent13.RadiusY = 74.0!
        Me.ArcScaleComponent13.StartAngle = -90.0!
        Me.ArcScaleComponent13.Value = 1.5!
        '
        'ArcScaleSpindleCapComponent2
        '
        Me.ArcScaleSpindleCapComponent2.ArcScale = Me.ArcScaleComponent11
        Me.ArcScaleSpindleCapComponent2.Name = "arcScaleSpindleCapComponent1"
        Me.ArcScaleSpindleCapComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
        Me.ArcScaleSpindleCapComponent2.Size = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.ArcScaleSpindleCapComponent2.ZOrder = -100
        '
        'Tokyo
        '
        Me.Tokyo.BackColor = System.Drawing.Color.Transparent
        Me.Tokyo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Tokyo.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.CircularGauge2})
        Me.Tokyo.Location = New System.Drawing.Point(12, 12)
        Me.Tokyo.Name = "Tokyo"
        Me.Tokyo.Size = New System.Drawing.Size(163, 167)
        Me.Tokyo.TabIndex = 6
        '
        'CircularGauge2
        '
        Me.CircularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent5})
        Me.CircularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 151, 155)
        Me.CircularGauge2.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.ArcScaleEffectLayerComponent1})
        Me.CircularGauge2.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent() {Me.ArcScaleStateIndicatorComponent1, Me.ArcScaleStateIndicatorComponent2, Me.ArcScaleStateIndicatorComponent3})
        Me.CircularGauge2.Name = "CircularGauge2"
        Me.CircularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent4, Me.ArcScaleNeedleComponent5, Me.ArcScaleNeedleComponent6})
        Me.CircularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent8, Me.ArcScaleComponent9, Me.ArcScaleComponent10})
        Me.CircularGauge2.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.ArcScaleSpindleCapComponent1})
        '
        'ArcScaleBackgroundLayerComponent5
        '
        Me.ArcScaleBackgroundLayerComponent5.ArcScale = Me.ArcScaleComponent8
        Me.ArcScaleBackgroundLayerComponent5.Name = "arcScaleBackgroundLayerComponent3"
        Me.ArcScaleBackgroundLayerComponent5.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.504!, 0.436!)
        Me.ArcScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock
        Me.ArcScaleBackgroundLayerComponent5.Size = New System.Drawing.SizeF(216.0!, 250.0!)
        Me.ArcScaleBackgroundLayerComponent5.ZOrder = 1000
        '
        'ArcScaleComponent8
        '
        Me.ArcScaleComponent8.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent8.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent8.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent8.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent8.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ArcScaleComponent8.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.ArcScaleComponent8.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent8.EndAngle = 270.0!
        ScaleLabel52.AppearanceText.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ScaleLabel52.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel52.FormatString = "{0}"
        ScaleLabel52.Name = "Label0"
        ScaleLabel52.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 135.0!)
        ScaleLabel52.Size = New System.Drawing.SizeF(70.0!, 20.0!)
        ScaleLabel52.Text = "Yokohama"
        ScaleLabel53.FormatString = "{0}"
        ScaleLabel53.Name = "Label1"
        ScaleLabel53.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 238.0!)
        ScaleLabel53.Size = New System.Drawing.SizeF(50.0!, 15.0!)
        ScaleLabel53.Text = "Japan"
        ScaleLabel54.AppearanceText.Font = New System.Drawing.Font("Tahoma", 12.0!)
        ScaleLabel54.FormatString = "{0:F4}"
        ScaleLabel54.Name = "Label2"
        ScaleLabel54.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(168.0!, 225.0!)
        ScaleLabel54.Size = New System.Drawing.SizeF(90.0!, 20.0!)
        ScaleLabel54.Text = "10 653.03"
        Me.ArcScaleComponent8.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel52, ScaleLabel53, ScaleLabel54})
        Me.ArcScaleComponent8.MajorTickCount = 13
        Me.ArcScaleComponent8.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent8.MajorTickmark.ShapeOffset = -9.5!
        Me.ArcScaleComponent8.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2
        Me.ArcScaleComponent8.MajorTickmark.ShowFirst = False
        Me.ArcScaleComponent8.MajorTickmark.TextOffset = -18.0!
        Me.ArcScaleComponent8.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent8.MaxValue = 12.0!
        Me.ArcScaleComponent8.MinorTickCount = 4
        Me.ArcScaleComponent8.MinorTickmark.ShapeOffset = -1.5!
        Me.ArcScaleComponent8.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5
        Me.ArcScaleComponent8.Name = "arcScaleComponent7"
        Me.ArcScaleComponent8.RadiusX = 74.0!
        Me.ArcScaleComponent8.RadiusY = 74.0!
        Me.ArcScaleComponent8.StartAngle = -90.0!
        '
        'ArcScaleEffectLayerComponent1
        '
        Me.ArcScaleEffectLayerComponent1.ArcScale = Me.ArcScaleComponent8
        Me.ArcScaleEffectLayerComponent1.Name = "arcScaleEffectLayerComponent3"
        Me.ArcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
        Me.ArcScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]")
        Me.ArcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
        Me.ArcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(170.0!, 85.0!)
        Me.ArcScaleEffectLayerComponent1.ZOrder = -1000
        '
        'ArcScaleStateIndicatorComponent1
        '
        Me.ArcScaleStateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(75.0!, 218.0!)
        Me.ArcScaleStateIndicatorComponent1.IndicatorScale = Me.ArcScaleComponent8
        Me.ArcScaleStateIndicatorComponent1.Name = "arcScaleStateIndicatorComponent7"
        Me.ArcScaleStateIndicatorComponent1.Size = New System.Drawing.SizeF(40.0!, 21.0!)
        ScaleIndicatorState19.IntervalLength = 12.0!
        ScaleIndicatorState19.Name = "Default"
        ScaleIndicatorState19.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagJapan
        Me.ArcScaleStateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState19})
        Me.ArcScaleStateIndicatorComponent1.ZOrder = -100
        '
        'ArcScaleStateIndicatorComponent2
        '
        Me.ArcScaleStateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(118.0!, 223.0!)
        Me.ArcScaleStateIndicatorComponent2.IndicatorScale = Me.ArcScaleComponent8
        Me.ArcScaleStateIndicatorComponent2.Name = "arcScaleStateIndicatorComponent8"
        Me.ArcScaleStateIndicatorComponent2.Shader = New DevExpress.XtraGauges.Core.Drawing.GrayShader("")
        Me.ArcScaleStateIndicatorComponent2.Size = New System.Drawing.SizeF(20.0!, 20.0!)
        ScaleIndicatorState20.IntervalLength = 12.0!
        ScaleIndicatorState20.Name = "Default"
        ScaleIndicatorState20.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyJPY
        Me.ArcScaleStateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState20})
        Me.ArcScaleStateIndicatorComponent2.ZOrder = -100
        '
        'ArcScaleStateIndicatorComponent3
        '
        Me.ArcScaleStateIndicatorComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(213.0!, 223.0!)
        Me.ArcScaleStateIndicatorComponent3.IndicatorScale = Me.ArcScaleComponent8
        Me.ArcScaleStateIndicatorComponent3.Name = "arcScaleStateIndicatorComponent9"
        Me.ArcScaleStateIndicatorComponent3.Size = New System.Drawing.SizeF(15.0!, 15.0!)
        ScaleIndicatorState21.IntervalLength = 12.0!
        ScaleIndicatorState21.Name = "Default"
        ScaleIndicatorState21.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4
        Me.ArcScaleStateIndicatorComponent3.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {ScaleIndicatorState21})
        Me.ArcScaleStateIndicatorComponent3.ZOrder = -100
        '
        'ArcScaleNeedleComponent4
        '
        Me.ArcScaleNeedleComponent4.ArcScale = Me.ArcScaleComponent8
        Me.ArcScaleNeedleComponent4.EndOffset = 10.0!
        Me.ArcScaleNeedleComponent4.Name = "arcScaleNeedleComponent7"
        Me.ArcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
        Me.ArcScaleNeedleComponent4.ZOrder = -50
        '
        'ArcScaleNeedleComponent5
        '
        Me.ArcScaleNeedleComponent5.ArcScale = Me.ArcScaleComponent9
        Me.ArcScaleNeedleComponent5.EndOffset = -5.0!
        Me.ArcScaleNeedleComponent5.Name = "arcScaleNeedleComponent8"
        Me.ArcScaleNeedleComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
        Me.ArcScaleNeedleComponent5.ZOrder = -51
        '
        'ArcScaleComponent9
        '
        Me.ArcScaleComponent9.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent9.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent9.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent9.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent9.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent9.EndAngle = 270.0!
        Me.ArcScaleComponent9.MajorTickCount = 2
        Me.ArcScaleComponent9.MajorTickmark.ShowText = False
        Me.ArcScaleComponent9.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent9.MaxValue = 12.0!
        Me.ArcScaleComponent9.MinorTickCount = 0
        Me.ArcScaleComponent9.Name = "arcScaleComponent8"
        Me.ArcScaleComponent9.RadiusX = 74.0!
        Me.ArcScaleComponent9.RadiusY = 74.0!
        Me.ArcScaleComponent9.StartAngle = -90.0!
        Me.ArcScaleComponent9.Value = 3.0!
        '
        'ArcScaleNeedleComponent6
        '
        Me.ArcScaleNeedleComponent6.ArcScale = Me.ArcScaleComponent10
        Me.ArcScaleNeedleComponent6.EndOffset = -10.0!
        Me.ArcScaleNeedleComponent6.Name = "arcScaleNeedleComponent9"
        Me.ArcScaleNeedleComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
        Me.ArcScaleNeedleComponent6.ZOrder = -52
        '
        'ArcScaleComponent10
        '
        Me.ArcScaleComponent10.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent10.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent10.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent10.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent10.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 110.0!)
        Me.ArcScaleComponent10.EndAngle = 270.0!
        Me.ArcScaleComponent10.MajorTickCount = 2
        Me.ArcScaleComponent10.MajorTickmark.ShowText = False
        Me.ArcScaleComponent10.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent10.MaxValue = 12.0!
        Me.ArcScaleComponent10.MinorTickCount = 0
        Me.ArcScaleComponent10.Name = "arcScaleComponent9"
        Me.ArcScaleComponent10.RadiusX = 74.0!
        Me.ArcScaleComponent10.RadiusY = 74.0!
        Me.ArcScaleComponent10.StartAngle = -90.0!
        Me.ArcScaleComponent10.Value = 1.5!
        '
        'ArcScaleSpindleCapComponent1
        '
        Me.ArcScaleSpindleCapComponent1.ArcScale = Me.ArcScaleComponent8
        Me.ArcScaleSpindleCapComponent1.Name = "arcScaleSpindleCapComponent3"
        Me.ArcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
        Me.ArcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(12.0!, 12.0!)
        Me.ArcScaleSpindleCapComponent1.ZOrder = -100
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(520, 191)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Tokyo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(167, 171)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Washington
        Me.LayoutControlItem1.Location = New System.Drawing.Point(167, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(168, 171)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.London
        Me.LayoutControlItem3.Location = New System.Drawing.Point(335, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(165, 171)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'frmSysInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 573)
        Me.Controls.Add(Me.splWid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSysInfo"
        Me.Text = "frmSysInfo"
        Me.splWid.Panel1.ResumeLayout(False)
        Me.splWid.Panel2.ResumeLayout(False)
        CType(Me.splWid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splWid.ResumeLayout(False)
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labelComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleRangeBarComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleRangeBarComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleRangeBarComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CircularGauge4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleEffectLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleStateIndicatorComponent6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleStateIndicatorComponent7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleSpindleCapComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircularGauge3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleEffectLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleStateIndicatorComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleStateIndicatorComponent5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleSpindleCapComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleStateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleStateIndicatorComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleStateIndicatorComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splWid As System.Windows.Forms.SplitContainer
    Private WithEvents gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Private WithEvents circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents arcScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents arcScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents arcScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents arcScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Private WithEvents labelComponent2 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Private WithEvents arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents arcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private WithEvents arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents arcScaleRangeBarComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private WithEvents arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents arcScaleRangeBarComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private WithEvents arcScaleRangeBarComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private WithEvents arcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Tokyo As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents CircularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleBackgroundLayerComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
    Private WithEvents ArcScaleStateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
    Private WithEvents ArcScaleStateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
    Private WithEvents ArcScaleStateIndicatorComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
    Private WithEvents ArcScaleNeedleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleNeedleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleNeedleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
    Friend WithEvents Washington As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents CircularGauge3 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleBackgroundLayerComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleEffectLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
    Private WithEvents ArcScaleStateIndicatorComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
    Private WithEvents ArcScaleStateIndicatorComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
    Private WithEvents ArcScaleNeedleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleNeedleComponent8 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleNeedleComponent9 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleComponent13 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleSpindleCapComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents timer As System.Windows.Forms.Timer
    Private WithEvents London As DevExpress.XtraGauges.Win.GaugeControl
    Private WithEvents CircularGauge4 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleBackgroundLayerComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleComponent14 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleEffectLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
    Private WithEvents ArcScaleStateIndicatorComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
    Private WithEvents ArcScaleStateIndicatorComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent
    Private WithEvents ArcScaleNeedleComponent10 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleNeedleComponent11 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleComponent15 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleNeedleComponent12 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleComponent16 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleSpindleCapComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
