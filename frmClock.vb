Imports Microsoft.VisualBasic
Imports System
Imports System.Management
Imports System.Threading
Imports System.Collections.Generic
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Base
Partial Public Class frmClock
#Region "Clock"
    Private timeShifts As Dictionary(Of String, Integer)
    Private lockTimerCounter2 As Integer = 0
    Private animationLockCounterCore As Integer = 0

    ReadOnly Property IsAnimationLocked() As Boolean
        Get
            Return animationLockCounterCore > 0
        End Get
    End Property
    Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
        Try
            If lockTimerCounter2 = 0 Then
                lockTimerCounter2 += 1
                'MsgBox(Visible)
                If IsAnimationLocked Then
                    Return
                End If
                LockAnimation()
                Dim gauges As List(Of GaugeControl) = CollectChildGauges(LayoutControl1)
                For Each gauge As GaugeControl In gauges
                    DoAnimation(gauge)
                Next gauge
                UnlockAnimation()
                lockTimerCounter2 -= 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub UnlockAnimation()
        animationLockCounterCore -= 1
    End Sub
    Sub LockAnimation()
        animationLockCounterCore += 1
    End Sub
    Sub DoAnimation(ByVal gauge As GaugeControl)
        Dim time As DateTime = DateTime.UtcNow.AddHours(timeShifts(gauge.Name))
        For Each gb As IGauge In gauge.Gauges
            Dim cGauge As ICircularGauge = TryCast(gb, ICircularGauge)
            If cGauge IsNot Nothing Then
                UpdateClock(time, cGauge.Scales(0), cGauge.Scales(1), cGauge.Scales(2))
            End If
        Next gb
    End Sub
    Sub UpdateClock(ByVal dt As DateTime, ByVal h As IArcScale, ByVal m As IArcScale, ByVal s As IArcScale)
        Dim hour As Integer
        If dt.Hour <= 12 Then
            hour = dt.Hour
        Else
            hour = dt.Hour - 12
        End If
        Dim min As Integer = dt.Minute
        Dim sec As Integer = dt.Second
        h.Value = CSng(hour) + CSng(min) / 60.0F
        m.Value = (CSng(min) + CSng(sec) / 60.0F) / 5.0F
        s.Value = sec / 5.0F
    End Sub
    Function CollectChildGauges(ByVal parentControl As Control) As List(Of GaugeControl)
        Dim result As List(Of GaugeControl) = New List(Of GaugeControl)()
        For Each control As Control In parentControl.Controls
            If TypeOf control Is GaugeControl Then
                result.Add(TryCast(control, GaugeControl))
            ElseIf control.Controls.Count > 0 Then
                result.AddRange(CollectChildGauges(control))
            End If
        Next control
        Return result
    End Function
#End Region
    Public Sub frmNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        timeShifts = New Dictionary(Of String, Integer)()
        timeShifts.Add("Washington", -4)
        timeShifts.Add("Paris", +1)
        timeShifts.Add("Moscow", +3)
        timeShifts.Add("London", +0)
        timeShifts.Add("Tokyo", +9)
        timeShifts.Add("Rome", +1)
        timer.Start()
        OnTimerTick(Nothing, Nothing)
    End Sub
    



End Class
