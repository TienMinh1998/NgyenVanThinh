Imports System.ComponentModel
Imports System.Text
Imports System.Threading

'from 1 khởi đầu, chọn các lựa chọn để vào phần mềm' 
Partial Public Class fr_gioithieu
    Shared _obj As fr_gioithieu
    Public Shared _Instance As Object

    Public Shared ReadOnly Property _Intance As fr_gioithieu
        Get

            If _obj Is Nothing Then
                _obj = New fr_gioithieu()
            End If

            Return _obj
        End Get
    End Property
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub





    Private Sub btn_huongdansudung_Click(sender As Object, e As EventArgs)

        Me.Hide()
        Me.Show()
    End Sub



    Private Sub btn_safe_Click(sender As Object, e As EventArgs) Handles btn_safe.Click, Guna2Button2.Click, btn_ve.Click
        Me.Hide()
        A_frm_main.ShowDialog()
        Me.Close()


    End Sub

    Private Sub fr_gioithieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)



    End Sub





End Class
