Public Class Frm_ChartMomen
    Private Shared _instance As Frm_ChartMomen
    Public Shared ReadOnly Property Instance As Frm_ChartMomen
        Get
            If _instance Is Nothing Then _instance = New Frm_ChartMomen()
            Return _instance
        End Get
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_ChartMomen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _instance = Me
    End Sub
End Class