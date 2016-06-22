Public Class frmProgress
    Delegate Sub DelegateUpdate(ByVal progress As Integer)
    ''' <summary>
    ''' Delegate to handle the Close event 
    ''' for this dialog
    ''' </summary>
    ''' <param name="dialog"></param>
    ''' <remarks></remarks>
    Delegate Sub DelegateClose(ByRef dialog As Form)

    ''' <summary>
    ''' Default constructor which initializes 
    ''' this control
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
    End Sub


    ''' <summary>
    ''' Method to update the progress bar widget. This 
    ''' uses the InvokeRequired and BeginInvoke methods
    ''' </summary>
    ''' <param name="progress">Progress value</param>
    ''' <remarks></remarks>
    Public Sub UpdateProgress(ByVal progress As Integer)
        If pbcStatus.InvokeRequired Then
            pbcStatus.BeginInvoke(New DelegateUpdate(AddressOf UpdateDelegateImpl), progress)
        Else
            pbcStatus.Position = progress
        End If

    End Sub

    Sub UpdateDelegateImpl(ByVal progress As Integer)
        pbcStatus.Position = progress
        'LabelProgress.Text = ""
        'LabelProgress.Text = progress & CStr("%")
    End Sub
    ''' <summary>
    ''' Implmentation of the DelegateClose
    ''' </summary>
    ''' <param name="dialog"></param>
    ''' <remarks></remarks>
    Sub CloseDelegateImpl(ByRef dialog As Form)
        dialog.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Close()
    End Sub
End Class