Imports System.ComponentModel
Imports System.Text

Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data
Partial Public Class FormMain
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub


End Class
