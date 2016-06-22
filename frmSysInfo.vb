﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Management
Imports System.Threading
Imports System.Collections.Generic
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Base
Partial Public Class frmSysInfo
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

    Private Shared stateCounter As Integer = 0
    Private Shared lockTimerCounter As Integer = 0

    Private Shared Function GetPerfomanceInfo_CPU(ByVal wmiService As WMIService) As PerfomanceInfo_CPU()
        Dim collection() As ManagementObject = wmiService.GetObjects("SELECT Name,PercentProcessorTime,PercentPrivilegedTime,PercentUserTime " & "FROM Win32_PerfFormattedData_PerfOS_Processor " & "WHERE Name='_Total'", False)
        Dim result(collection.Length - 1) As PerfomanceInfo_CPU
        For i As Integer = 0 To collection.Length - 1
            result(i) = New PerfomanceInfo_CPU(CStr(collection(i).Properties("Name").Value), CSng(CULng(collection(i).Properties("PercentProcessorTime").Value)), CSng(CULng(collection(i).Properties("PercentPrivilegedTime").Value)), CSng(CULng(collection(i).Properties("PercentUserTime").Value)))
        Next i
        Return result
    End Function
    Private Shared Function GetPerfomanceInfo_OS(ByVal wmiService As WMIService) As PerfomanceInfo_OS()
        Dim collection() As ManagementObject = wmiService.GetObjects("SELECT Name,Processes,Threads " & "FROM Win32_PerfFormattedData_PerfOS_System", False)
        Dim result(collection.Length - 1) As PerfomanceInfo_OS
        For i As Integer = 0 To collection.Length - 1
            result(i) = New PerfomanceInfo_OS(CStr(collection(i).Properties("Name").Value), CInt(Fix(CUInt(collection(i).Properties("Processes").Value))), CInt(Fix(CUInt(collection(i).Properties("Threads").Value))))
        Next i
        Return result
    End Function
    Private Shared Function GetTotalMemorySizeMB(ByVal wmiService As WMIService) As Integer
        Dim collection() As ManagementObject = wmiService.GetObjects("Select TotalVisibleMemorySize From Win32_OperatingSystem", True)
        If (collection.Length = 1) Then
            Return CInt(Fix(CULng(collection(0).Properties("TotalVisibleMemorySize").Value) / 1024))
        Else
            Return 4096
        End If
    End Function
    Private Shared Function GetFreeMemorySizeMB(ByVal wmiService As WMIService) As Integer
        Dim collection() As ManagementObject = wmiService.GetObjects("Select FreePhysicalMemory From Win32_OperatingSystem", False)
        If (collection.Length = 1) Then
            Return CInt(Fix(CULng(collection(0).Properties("FreePhysicalMemory").Value) / 1024))
        Else
            Return 4096
        End If
    End Function
    Private Shared Function GetOSName(ByVal wmiService As WMIService) As String
        Dim collection() As ManagementObject = wmiService.GetObjects("Select Caption From Win32_OperatingSystem", True)
        If (collection.Length = 1) Then
            Return CStr(collection(0).Properties("Caption").Value)
        Else
            Return String.Empty
        End If
    End Function
    Private Shared Function GetProcessorNames(ByVal wmiService As WMIService) As String()
        Dim collection() As ManagementObject = wmiService.GetObjects("Select Name From Win32_Processor", True)
        Dim result(collection.Length - 1) As String
        For i As Integer = 0 To collection.Length - 1
            result(i) = CStr(collection(i).Properties("Name").Value)
        Next i
        Return result
    End Function
    Private Shared Function GetTotalHDDSizeGB(ByVal wmiService As WMIService) As Integer
        Dim collection() As ManagementObject = wmiService.GetObjects("Select Size From Win32_LogicalDisk ", True)
        Dim size As UInt64 = 0
        For i As Integer = 0 To collection.Length - 1
            Dim pData As PropertyData = collection(i).Properties("Size")
            If (pData IsNot Nothing AndAlso pData.Value IsNot Nothing) Then
                size += (CULng(pData.Value))
            Else
                size += (0UI)
            End If
        Next i
        Return CInt(Fix(size >> 30))
    End Function
    Private Shared Function GetFreeHDDSizeGB(ByVal wmiService As WMIService) As Integer
        Dim collection() As ManagementObject = wmiService.GetObjects("Select FreeSpace From Win32_LogicalDisk ", False)
        Dim size As UInt64 = 0
        For i As Integer = 0 To collection.Length - 1
            Dim pData As PropertyData = collection(i).Properties("FreeSpace")
            If (pData IsNot Nothing AndAlso pData.Value IsNot Nothing) Then
                size += (CULng(pData.Value))
            Else
                size += (0UI)
            End If
        Next i
        Return CInt(Fix(size >> 30))
    End Function

    Private buffer() As PerfomanceInfo_CPU
    Private wmiService As WMIService
    Private pollingTimer As System.Threading.Timer

    Protected ReadOnly Property DashboardGauge() As CircularGauge
        Get
            Try
                Return TryCast(gaugeControl1.Gauges(0), CircularGauge)
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property
    Public ReadOnly Property ShowExportMenu() As Boolean
        Get
            Return True
        End Get
    End Property
    Public ReadOnly Property ExportControl() As DevExpress.XtraGauges.Win.GaugeControl
        Get
            Return gaugeControl1
        End Get
    End Property

    Public Sub New()
        buffer = New PerfomanceInfo_CPU(2) {}
        wmiService = wmiService.GetInstance(Nothing)
        InitializeComponent()
        If wmiService.Connected Then
            Dim processors() As String = GetProcessorNames(wmiService)
            DashboardGauge.Labels("processorName").Text = processors(0)
            DashboardGauge.Labels("osName").Text = GetOSName(wmiService)
            DashboardGauge.Scales("memoryTotal").MaxValue = GetTotalMemorySizeMB(wmiService)
            DashboardGauge.Scales("hddTotal").MaxValue = GetTotalHDDSizeGB(wmiService)
            Me.pollingTimer = New System.Threading.Timer(AddressOf OnTimerCallback, Nothing, 1000, 300)
            OnTimerCallback(Nothing)
        End If
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
    Private Sub frmSysInfo_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        wmiService.Dispose()
        pollingTimer.Dispose()
    End Sub
    Sub OnTimerCallback(ByVal state As Object)
        Try
            If Interlocked.CompareExchange(lockTimerCounter, 1, 0) = 0 Then
                If wmiService IsNot Nothing Then
                    UpdatePerfomanceData_CPU()
                    If stateCounter Mod 5 = 0 Then
                        UpdatePerfomanceData_OS()
                    End If
                    If stateCounter Mod 10 = 0 Then
                        UpdatePerfomanceData_Memory()
                    End If
                    If stateCounter Mod 20 = 0 Then
                        UpdatePerfomanceData_HDD()
                    End If
                End If
                stateCounter += 1
                Interlocked.Add(lockTimerCounter, -1)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub UpdatePerfomanceData_CPU()
        Try
            Dim infos() As PerfomanceInfo_CPU = GetPerfomanceInfo_CPU(wmiService)
            If infos.Length = 1 Then
                Dim info As PerfomanceInfo_CPU = GetBufferedPerfomanceInfo(infos(0))
                DashboardGauge.Scales("cpuTotal").Value = info.Total
                DashboardGauge.Scales("cpuUser").Value = info.Kernel + info.User
                DashboardGauge.Scales("cpuKernel").Value = info.Kernel
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub UpdatePerfomanceData_OS()
        Try
            Dim infos() As PerfomanceInfo_OS = GetPerfomanceInfo_OS(wmiService)
            If infos.Length = 1 Then
                DashboardGauge.Scales("osThreads").Value = infos(0).Threads
                DashboardGauge.Scales("osProcesses").Value = infos(0).Processes
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub UpdatePerfomanceData_Memory()
        Try
            DashboardGauge.Scales("memoryTotal").Value = GetFreeMemorySizeMB(wmiService)
        Catch ex As Exception

        End Try

    End Sub
    Sub UpdatePerfomanceData_HDD()
        Try
            DashboardGauge.Scales("hddTotal").Value = GetFreeHDDSizeGB(wmiService)
        Catch ex As Exception

        End Try

    End Sub
    Private Function GetBufferedPerfomanceInfo(ByVal currentValue As PerfomanceInfo_CPU) As PerfomanceInfo_CPU
        Try
            For i As Integer = 1 To buffer.Length - 1
                buffer(i - 1) = buffer(i)
            Next i
            buffer(buffer.Length - 1) = currentValue

            Dim total As Single = 0
            Dim kernel As Single = 0
            Dim user As Single = 0
            Dim n As Integer = 0
            For i As Integer = 0 To buffer.Length - 1
                If buffer(i) IsNot Nothing Then
                    total += buffer(i).Total
                    kernel += buffer(i).Kernel
                    user += buffer(i).User
                    n += 1
                End If
            Next i
            Return New PerfomanceInfo_CPU(currentValue.Name, total / CSng(n), kernel / CSng(n), user / CSng(n))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Private Sub gaugeControl1_Click(sender As Object, e As EventArgs) Handles gaugeControl1.Click

    End Sub
End Class

Friend Class PerfomanceInfo_CPU
    Private nameCore As String
    Private totalCore As Single
    Private kernelCore As Single
    Private userCore As Single

    Public ReadOnly Property Name() As String
        Get
            Return nameCore
        End Get
    End Property
    Public ReadOnly Property Total() As Single
        Get
            Return totalCore
        End Get
    End Property
    Public ReadOnly Property Kernel() As Single
        Get
            Return kernelCore
        End Get
    End Property
    Public ReadOnly Property User() As Single
        Get
            Return userCore
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal total As Single, ByVal kernel As Single, ByVal user As Single)
        nameCore = name
        totalCore = total
        kernelCore = kernel
        userCore = user
    End Sub
End Class
Friend Class PerfomanceInfo_OS
    Private nameCore As String
    Private processesCore As Integer
    Private threadsCore As Integer

    Public ReadOnly Property Name() As String
        Get
            Return nameCore
        End Get
    End Property
    Public ReadOnly Property Processes() As Integer
        Get
            Return processesCore
        End Get
    End Property
    Public ReadOnly Property Threads() As Integer
        Get
            Return threadsCore
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal processes As Integer, ByVal threads As Integer)
        nameCore = name
        processesCore = processes
        threadsCore = threads
    End Sub
End Class
Friend Class MemoryPerfomanceInfo
    Private nameCore As String
    Private totalCore As Integer
    Private freeCore As Integer

    Public ReadOnly Property Name() As String
        Get
            Return nameCore
        End Get
    End Property
    Public ReadOnly Property Total() As Integer
        Get
            Return totalCore
        End Get
    End Property
    Public ReadOnly Property Free() As Integer
        Get
            Return freeCore
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal total As Integer, ByVal free As Integer)
        nameCore = name
        totalCore = total
        freeCore = free
    End Sub
End Class
Public NotInheritable Class WMIService
    Implements IDisposable

    Public Shared Function GetInstance(ByVal path As String) As WMIService
        If String.IsNullOrEmpty(path) Then
            Return New WMIService("//./root/cimv2")
        Else
            Return New WMIService(path)
        End If
    End Function

    Private scopeCore As ManagementScope
    Private queryCacheCore As Dictionary(Of String, ManagementObjectCollection)
    Private connectedCore As Boolean = False

    ReadOnly Property QueryCache() As Dictionary(Of String, ManagementObjectCollection)
        Get
            Return queryCacheCore
        End Get
    End Property
    Public ReadOnly Property Connected() As Boolean
        Get
            Return connectedCore
        End Get
    End Property
    Public ReadOnly Property Scope() As ManagementScope
        Get
            Return scopeCore
        End Get
    End Property

    Sub New(ByVal path As String)
        queryCacheCore = New Dictionary(Of String, ManagementObjectCollection)()
        Dim options As New ConnectionOptions()
        options.Impersonation = ImpersonationLevel.Impersonate
        options.Authentication = AuthenticationLevel.Packet
        Me.scopeCore = New ManagementScope(path, options)
        Try
            Scope.Connect()
            connectedCore = Scope.IsConnected
        Catch
            connectedCore = False
        End Try
    End Sub
    Function GetManagementObjectCollection(ByVal queryString As String) As ManagementObjectCollection
        Dim result As ManagementObjectCollection = Nothing
        Dim query As New ObjectQuery(queryString)
        Using searcher As New ManagementObjectSearcher(Scope, query)
            result = searcher.Get()
        End Using
        Return result
    End Function
    Public Sub Dispose() Implements IDisposable.Dispose
        connectedCore = False
        If queryCacheCore IsNot Nothing Then
            For Each pair As KeyValuePair(Of String, ManagementObjectCollection) In queryCacheCore
                If pair.Value IsNot Nothing Then
                    pair.Value.Dispose()
                End If
            Next pair
            queryCacheCore.Clear()
            queryCacheCore = Nothing
        End If
        scopeCore = Nothing
    End Sub
    Public Function GetObjectCollection(ByVal queryString As String, ByVal allowQueryCaching As Boolean) As ManagementObjectCollection
        Dim result As ManagementObjectCollection = Nothing
        If allowQueryCaching Then
            QueryCache.TryGetValue(queryString, result)
        End If
        If result Is Nothing Then
            result = GetManagementObjectCollection(queryString)
            If allowQueryCaching Then
                If QueryCache.ContainsKey(queryString) Then
                    QueryCache(queryString) = result
                Else
                    QueryCache.Add(queryString, result)
                End If
            End If
        End If
        Return result
    End Function
    Public Function GetObjects(ByVal queryString As String, ByVal allowQueryCaching As Boolean) As ManagementObject()
        Dim result(-1) As ManagementObject
        Dim collection As ManagementObjectCollection = GetObjectCollection(queryString, allowQueryCaching)
        If collection IsNot Nothing Then
            result = New ManagementObject(collection.Count - 1) {}
            collection.CopyTo(result, 0)
        End If
        Return result
    End Function
End Class