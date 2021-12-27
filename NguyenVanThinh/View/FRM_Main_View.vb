Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports VDProLib5
Public Class FRM_Main_View

    Private Shared _instance As FRM_Main_View
    Public Shared ReadOnly Property Instance As FRM_Main_View
        Get
            If _instance Is Nothing Then _instance = New FRM_Main_View()
            Return _instance
        End Get
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub





    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub VậtLiệuToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_chonvatlieu1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_chonvatlieu1.ItemClick
        ChonVatlieuView.ShowDialog()
    End Sub
End Class
