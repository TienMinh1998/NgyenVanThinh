Imports System.Threading.Tasks
Imports System.Threading
Imports DevExpress.XtraEditors
Public Class frm_process
    Private Business As BusinessProcess
    Private _dk As Boolean
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Property Dk As Boolean
        Get
            Return _dk
        End Get
        Set(value As Boolean)
            _dk = value
        End Set
    End Property

    Private Sub frm_process_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Call process
        'Business = New BusinessProcess()
        'Business.loadingProccess(prc, Me)


    End Sub



    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        If dk = False Then
            prc.Visible = True
            Label1.Text = "...Đang tải dữ liệu từ máy chủ..."
            Me.Refresh()
            prc.Properties.Minimum = 0
            prc.Properties.Maximum = 100
            prc.Properties.Step = 2
            prc.Properties.PercentView = True
            prc.Properties.EndColor = Color.Green
            prc.Properties.StartColor = Color.Green
            prc.Properties.ShowTitle = True

            For i = 1 To 100
                Thread.Sleep(20)
                prc.PerformStep()
                prc.Update()
            Next
            dk = True
            Me.Close()
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        dk = False
    End Sub
End Class