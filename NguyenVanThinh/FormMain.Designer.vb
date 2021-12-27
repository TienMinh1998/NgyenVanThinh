Partial Public Class FormMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.Giư = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.Giư, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 24
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(1233, 143)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Tạo mới"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Etab file"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.etab
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sap2000"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.OIP
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Thông số dầm"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Nội lực dầm"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icon_load
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Vật liệu"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_steel_ore_96
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Vật liệu"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_steel_ore_96
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Diện tích thép yêu cầu"
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_calculator_96
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Bố trí cốt thép"
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icon_steel
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Bản vẽ"
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_autodesk_autocad_96
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Xuất bản vẽ"
        Me.BarButtonItem11.Id = 11
        Me.BarButtonItem11.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.dwg_icon_150x150
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Thuyết minh"
        Me.BarButtonItem12.Id = 12
        Me.BarButtonItem12.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_microsoft_word_2019_96
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Xuất thuyết minh"
        Me.BarButtonItem13.Id = 14
        Me.BarButtonItem13.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_cloud_print_96
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Hướng dẫn"
        Me.BarButtonItem14.Id = 15
        Me.BarButtonItem14.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_about_96
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'Giư
        '
        Me.Giư.Caption = "Giới thiệu"
        Me.Giư.Id = 16
        Me.Giư.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_name_tag_80
        Me.Giư.Name = "Giư"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Bản vẽ"
        Me.BarButtonItem15.Id = 17
        Me.BarButtonItem15.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_autodesk_autocad_96
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Xuất bản vẽ"
        Me.BarButtonItem16.Id = 18
        Me.BarButtonItem16.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.dwg_icon_150x150
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Thuyết minh"
        Me.BarButtonItem17.Id = 19
        Me.BarButtonItem17.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_microsoft_word_2019_96
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Xuất thuyết minh"
        Me.BarButtonItem18.Id = 20
        Me.BarButtonItem18.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_cloud_print_96
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Hướng dẫn"
        Me.BarButtonItem19.Id = 21
        Me.BarButtonItem19.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_about_96
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Giới thiệu"
        Me.BarButtonItem20.Id = 22
        Me.BarButtonItem20.ImageOptions.LargeImage = Global.NguyenDacChinh_60TH2.My.Resources.Resources.icons8_name_tag_80
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup7, Me.RibbonPageGroup8, Me.RibbonPageGroup9})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Tính toán"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Thư mục đồ án"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Dữ liệu đầu vào"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Tính toán"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem15)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem16)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "Bản vẽ kết cấu"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem17)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem18)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.Text = "Thuyết minh tính toán"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.BarButtonItem19)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.BarButtonItem20)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.Text = "Hướng dẫn"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Bản vẽ"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem11)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Bản vẽ kết cấu"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Thuyết minh"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem12)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem13)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "RibbonPageGroup5"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Hướng dẫn "
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem14)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.Giư)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Hướng dẫn"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 732)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "FormMain"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Form1"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Giư As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
