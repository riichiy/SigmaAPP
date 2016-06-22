
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Data.OleDb
Public Class frmCamera
    Private videoDevices As FilterInfoCollection
    Private videoDevice As VideoCaptureDevice
    Private videoCapabilities As VideoCapabilities()
    Private snapshotCapabilities As VideoCapabilities()
    Dim CameraIndex As Integer = 0
    Public BCardName As String = ""
    Private Sub frmCamera_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count <> 0 Then
            ' add all devices to combo
            For Each device As FilterInfo In videoDevices
                devicesCombo.Items.Add(device.Name)
            Next
        Else
            devicesCombo.Items.Add("No DirectShow devices found")
        End If
        Try
            devicesCombo.SelectedIndex = 0
        Catch ex As Exception

        End Try

        EnableConnectionControls(True)
        ConnectCamera()
    End Sub
    Private Sub SaveSettings()
        Try
            Dim connUsers As System.Data.OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            ' Dim tmpstr() As String
            connUsers = New System.Data.OleDb.OleDbConnection
            connUsers.ConnectionString = DBString
            cmd.Connection = connUsers

            connUsers.Open()
            cmd.Connection = connUsers
            'cmd.CommandText = "UPDATE tbl_Settings SET DefaultCamera='" & devicesCombo.SelectedIndex.ToString & "' WHERE UserID='" & PgmSettings.UserID & "' "
            cmd.ExecuteNonQuery()
            cmd = Nothing
            connUsers.Close()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
        Disconnect()
    End Sub
    ' Enable/disable connection related controls
    Private Sub EnableConnectionControls(enable As Boolean)
        devicesCombo.Enabled = enable
        videoResolutionsCombo.Enabled = enable
        snapshotResolutionsCombo.Enabled = enable
        connectButton.Enabled = enable
        disconnectButton.Enabled = Not enable
        triggerButton.Enabled = (Not enable) AndAlso (snapshotCapabilities.Length <> 0)
    End Sub
    Private Sub devicesCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles devicesCombo.SelectedIndexChanged
        If videoDevices.Count <> 0 Then
            videoDevice = New VideoCaptureDevice(videoDevices(devicesCombo.SelectedIndex).MonikerString)
            EnumeratedSupportedFrameSizes(videoDevice)
        End If
    End Sub

    ' Collect supported video and snapshot sizes
    Private Sub EnumeratedSupportedFrameSizes(videoDevice As VideoCaptureDevice)
        Me.Cursor = Cursors.WaitCursor

        videoResolutionsCombo.Items.Clear()
        snapshotResolutionsCombo.Items.Clear()

        Try
            videoCapabilities = videoDevice.VideoCapabilities
            snapshotCapabilities = videoDevice.SnapshotCapabilities

            For Each capabilty As VideoCapabilities In videoCapabilities
                If Not videoResolutionsCombo.Items.Contains(capabilty.FrameSize) Then
                    videoResolutionsCombo.Items.Add(capabilty.FrameSize)
                End If
            Next

            For Each capabilty As VideoCapabilities In snapshotCapabilities
                If Not snapshotResolutionsCombo.Items.Contains(capabilty.FrameSize) Then
                    snapshotResolutionsCombo.Items.Add(capabilty.FrameSize)
                End If
            Next

            If videoCapabilities.Length = 0 Then
                videoResolutionsCombo.Items.Add("Not supported")
            End If
            If snapshotCapabilities.Length = 0 Then
                snapshotResolutionsCombo.Items.Add("Not supported")
            End If

            videoResolutionsCombo.SelectedIndex = videoResolutionsCombo.Items.Count - 1
            snapshotResolutionsCombo.SelectedIndex = snapshotResolutionsCombo.Items.Count - 1
        Finally
            Me.Cursor = Cursors.[Default]
        End Try
    End Sub
    ' On "Connect" button clicked
    Private Sub connectButton_Click(sender As Object, e As EventArgs) Handles connectButton.Click
        ConnectCamera()
    End Sub
    Private Sub ConnectCamera()
        If videoDevice IsNot Nothing Then
            If (videoCapabilities IsNot Nothing) AndAlso (videoCapabilities.Length <> 0) Then
                videoDevice.DesiredFrameSize = CType(videoResolutionsCombo.SelectedItem, Size)
            End If

            If (snapshotCapabilities IsNot Nothing) AndAlso (snapshotCapabilities.Length <> 0) Then
                videoDevice.ProvideSnapshots = True
                videoDevice.DesiredSnapshotSize = CType(snapshotResolutionsCombo.SelectedItem, Size)
                AddHandler videoDevice.SnapshotFrame, AddressOf Me.videoDevice_SnapshotFrame
            End If

            EnableConnectionControls(False)

            videoSourcePlayer.VideoSource = videoDevice
            videoSourcePlayer.Start()
        End If
    End Sub

    ' On "Disconnect" button clicked
    Private Sub disconnectButton_Click(sender As Object, e As EventArgs) Handles disconnectButton.Click
        Disconnect()
    End Sub
    ' Disconnect from video device
    Private Sub Disconnect()
        If videoSourcePlayer.VideoSource IsNot Nothing Then
            ' stop video device
            videoSourcePlayer.SignalToStop()
            videoSourcePlayer.WaitForStop()
            videoSourcePlayer.VideoSource = Nothing

            If videoDevice.ProvideSnapshots Then
                AddHandler videoDevice.SnapshotFrame, AddressOf Me.videoDevice_SnapshotFrame
            End If

            EnableConnectionControls(True)
        End If
    End Sub
    ' Simulate snapshot trigger
    Private Sub triggerButton_Click(sender As Object, e As EventArgs) Handles triggerButton.Click
        If (videoDevice IsNot Nothing) AndAlso (videoDevice.ProvideSnapshots) Then
            videoDevice.SimulateTrigger()
        End If
    End Sub

    ' New snapshot frame is available
    Private Sub videoDevice_SnapshotFrame(sender As Object, eventArgs As NewFrameEventArgs)
        Console.WriteLine(eventArgs.Frame.Size)

        ShowSnapshot(DirectCast(eventArgs.Frame.Clone(), Bitmap))
    End Sub
    Private Function CreateUID() As String
        Dim DateFmt As String = Microsoft.VisualBasic.Right("0000" & Date.Today.Year, 4) & Microsoft.VisualBasic.Right("00" & Date.Today.Month, 2) & Microsoft.VisualBasic.Right("00" & Date.Today.Day, 2)
        Dim TimeFmt As String = Microsoft.VisualBasic.Right("00" & Date.Now.Hour, 2) & Microsoft.VisualBasic.Right("00" & Date.Now.Minute, 2) & Microsoft.VisualBasic.Right("00" & Date.Now.Second, 2)
        CreateUID = DateFmt & "-" & TimeFmt
    End Function
    Private Sub ShowSnapshot(snapshot As Bitmap)
        Dim TimeStamp As String = CreateUID()
        Dim BCardPath As String = SigmanestDataPath & "RAKUCADATA\BusinessCards\"
        snapshot.Save(BCardPath & TimeStamp & ".jpg")
        BCardName = TimeStamp & ".jpg"
        picCard.BackgroundImage = snapshot
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Disconnect()
        Close()
    End Sub
End Class