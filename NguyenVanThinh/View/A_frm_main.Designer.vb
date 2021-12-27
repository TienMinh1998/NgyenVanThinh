<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_frm_main
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try

            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_frm_main))
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.btn_caidat = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.btn_xuatbanve = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.btn_bangnoiluc = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.btn_xulysolieu = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.menu_main = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.btn_GridLines = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.btn_bangkichthuoc = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.doc_thuoctinh = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.btn_themvatlieu = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Btn_home = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDataAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VậtLiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_matbang = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_xuly = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_ve = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_momen = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_xuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemNộiLựcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_xembangnoiluc = New System.Windows.Forms.Panel()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu_main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1450, 30)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "Element1"
        '
        'btn_caidat
        '
        Me.btn_caidat.ImageOptions.Image = CType(resources.GetObject("btn_caidat.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_caidat.Name = "btn_caidat"
        Me.btn_caidat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_caidat.Text = "Xem nội lực gối 2"
        '
        'btn_xuatbanve
        '
        Me.btn_xuatbanve.Enabled = False
        Me.btn_xuatbanve.ImageOptions.Image = CType(resources.GetObject("btn_xuatbanve.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_xuatbanve.Name = "btn_xuatbanve"
        Me.btn_xuatbanve.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_xuatbanve.Text = "Xuất bản vẽ"
        '
        'btn_bangnoiluc
        '
        Me.btn_bangnoiluc.Enabled = False
        Me.btn_bangnoiluc.ImageOptions.Image = CType(resources.GetObject("btn_bangnoiluc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_bangnoiluc.Name = "btn_bangnoiluc"
        Me.btn_bangnoiluc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_bangnoiluc.Text = "Bảng Nội Lực"
        '
        'btn_xulysolieu
        '
        Me.btn_xulysolieu.ImageOptions.SvgImage = CType(resources.GetObject("btn_xulysolieu.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_xulysolieu.Name = "btn_xulysolieu"
        Me.btn_xulysolieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_xulysolieu.Text = "Xử Lý Số Liệu Và Tính Toán"
        '
        'menu_main
        '
        Me.menu_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu_main.Dock = System.Windows.Forms.DockStyle.Left
        Me.menu_main.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.btn_xulysolieu, Me.btn_bangnoiluc, Me.btn_GridLines, Me.btn_bangkichthuoc, Me.btn_xuatbanve, Me.btn_caidat})
        Me.menu_main.Location = New System.Drawing.Point(0, 68)
        Me.menu_main.Margin = New System.Windows.Forms.Padding(2)
        Me.menu_main.Name = "menu_main"
        Me.menu_main.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.menu_main.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized
        Me.menu_main.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.menu_main.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always
        Me.menu_main.Size = New System.Drawing.Size(50, 666)
        Me.menu_main.TabIndex = 1
        Me.menu_main.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'btn_GridLines
        '
        Me.btn_GridLines.Enabled = False
        Me.btn_GridLines.ImageOptions.Image = CType(resources.GetObject("btn_GridLines.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_GridLines.Name = "btn_GridLines"
        Me.btn_GridLines.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_GridLines.Text = "GridLines"
        '
        'btn_bangkichthuoc
        '
        Me.btn_bangkichthuoc.Enabled = False
        Me.btn_bangkichthuoc.ImageOptions.Image = CType(resources.GetObject("btn_bangkichthuoc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_bangkichthuoc.Name = "btn_bangkichthuoc"
        Me.btn_bangkichthuoc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_bangkichthuoc.Text = "Bảng Kích Thước"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2, Me.DockPanel1})
        Me.DockManager1.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
        Me.DockPanel2.FloatLocation = New System.Drawing.Point(1087, 276)
        Me.DockPanel2.FloatSize = New System.Drawing.Size(200, 207)
        Me.DockPanel2.ID = New System.Guid("99bc24a0-bac3-43b8-83e0-0a7a06c98c32")
        Me.DockPanel2.Location = New System.Drawing.Point(-32768, -32768)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.SavedIndex = 1
        Me.DockPanel2.Size = New System.Drawing.Size(200, 207)
        Me.DockPanel2.Text = "DockPanel2"
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Location = New System.Drawing.Point(5, 24)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(190, 179)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.doc_thuoctinh)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("a893898e-be74-498e-b21e-b0cb08f55842")
        Me.DockPanel1.Location = New System.Drawing.Point(1214, 30)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(236, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(236, 704)
        Me.DockPanel1.Text = "Properti"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'doc_thuoctinh
        '
        Me.doc_thuoctinh.Location = New System.Drawing.Point(7, 25)
        Me.doc_thuoctinh.Name = "doc_thuoctinh"
        Me.doc_thuoctinh.Size = New System.Drawing.Size(224, 674)
        Me.doc_thuoctinh.TabIndex = 0
        '
        'btn_themvatlieu
        '
        Me.btn_themvatlieu.ImageOptions.Image = CType(resources.GetObject("btn_themvatlieu.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_themvatlieu.Name = "btn_themvatlieu"
        Me.btn_themvatlieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.btn_themvatlieu.Text = "Chọn Vật Liệu Sử Dụng"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_home, Me.btn_xuly, Me.NewDataAccessToolStripMenuItem, Me.VậtLiệuToolStripMenuItem, Me.btn_matbang, Me.btn_momen, Me.btn_ve, Me.btn_xuat, Me.XemNộiLựcToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 30)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1450, 38)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Btn_home
        '
        Me.Btn_home.Image = CType(resources.GetObject("Btn_home.Image"), System.Drawing.Image)
        Me.Btn_home.Name = "Btn_home"
        Me.Btn_home.Size = New System.Drawing.Size(94, 34)
        Me.Btn_home.Text = "Home"
        '
        'NewDataAccessToolStripMenuItem
        '
        Me.NewDataAccessToolStripMenuItem.Image = CType(resources.GetObject("NewDataAccessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewDataAccessToolStripMenuItem.Name = "NewDataAccessToolStripMenuItem"
        Me.NewDataAccessToolStripMenuItem.Size = New System.Drawing.Size(119, 34)
        Me.NewDataAccessToolStripMenuItem.Text = "New Data"
        '
        'VậtLiệuToolStripMenuItem
        '
        Me.VậtLiệuToolStripMenuItem.Image = CType(resources.GetObject("VậtLiệuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VậtLiệuToolStripMenuItem.Name = "VậtLiệuToolStripMenuItem"
        Me.VậtLiệuToolStripMenuItem.Size = New System.Drawing.Size(106, 34)
        Me.VậtLiệuToolStripMenuItem.Text = "Vật Liệu"
        '
        'btn_matbang
        '
        Me.btn_matbang.Image = CType(resources.GetObject("btn_matbang.Image"), System.Drawing.Image)
        Me.btn_matbang.Name = "btn_matbang"
        Me.btn_matbang.Size = New System.Drawing.Size(117, 34)
        Me.btn_matbang.Text = "Mặt Bằng"
        '
        'btn_xuly
        '
        Me.btn_xuly.Image = Global.Demo_TrinhVanVien.My.Resources.Resources.Files_icon
        Me.btn_xuly.Name = "btn_xuly"
        Me.btn_xuly.Size = New System.Drawing.Size(76, 34)
        Me.btn_xuly.Text = "File"
        '
        'btn_ve
        '
        Me.btn_ve.Image = CType(resources.GetObject("btn_ve.Image"), System.Drawing.Image)
        Me.btn_ve.Name = "btn_ve"
        Me.btn_ve.Size = New System.Drawing.Size(97, 34)
        Me.btn_ve.Text = "Bản vẽ"
        '
        'btn_momen
        '
        Me.btn_momen.Image = CType(resources.GetObject("btn_momen.Image"), System.Drawing.Image)
        Me.btn_momen.Name = "btn_momen"
        Me.btn_momen.Size = New System.Drawing.Size(128, 34)
        Me.btn_momen.Text = "Bố Trí Thép"
        '
        'btn_xuat
        '
        Me.btn_xuat.Checked = True
        Me.btn_xuat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btn_xuat.Image = CType(resources.GetObject("btn_xuat.Image"), System.Drawing.Image)
        Me.btn_xuat.Name = "btn_xuat"
        Me.btn_xuat.Size = New System.Drawing.Size(133, 34)
        Me.btn_xuat.Text = "Xuất Bản Vẽ"
        '
        'XemNộiLựcToolStripMenuItem
        '
        Me.XemNộiLựcToolStripMenuItem.Image = CType(resources.GetObject("XemNộiLựcToolStripMenuItem.Image"), System.Drawing.Image)
        Me.XemNộiLựcToolStripMenuItem.Name = "XemNộiLựcToolStripMenuItem"
        Me.XemNộiLựcToolStripMenuItem.Size = New System.Drawing.Size(138, 34)
        Me.XemNộiLựcToolStripMenuItem.Text = "Xem Nội Lực"
        '
        'btn_xembangnoiluc
        '
        Me.btn_xembangnoiluc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_xembangnoiluc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_xembangnoiluc.Location = New System.Drawing.Point(50, 68)
        Me.btn_xembangnoiluc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_xembangnoiluc.Name = "btn_xembangnoiluc"
        Me.btn_xembangnoiluc.Size = New System.Drawing.Size(1400, 666)
        Me.btn_xembangnoiluc.TabIndex = 3
        '
        'A_frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 734)
        Me.Controls.Add(Me.btn_xembangnoiluc)
        Me.Controls.Add(Me.menu_main)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.Name = "A_frm_main"
        Me.NavigationControl = Me.menu_main
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tính Toán Và vẽ sàn dựa trên số liệu Safe"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu_main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents menu_main As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents btn_xulysolieu As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents btn_bangnoiluc As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents btn_xuatbanve As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents btn_caidat As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents doc_thuoctinh As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents btn_themvatlieu As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn_matbang As ToolStripMenuItem
    Friend WithEvents btn_xuly As ToolStripMenuItem
    Friend WithEvents NewDataAccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_ve As ToolStripMenuItem
    Friend WithEvents btn_momen As ToolStripMenuItem
    Friend WithEvents btn_xembangnoiluc As Panel
    Friend WithEvents btn_GridLines As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents btn_bangkichthuoc As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents VậtLiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_xuat As ToolStripMenuItem
    Friend WithEvents Btn_home As ToolStripMenuItem
    Friend WithEvents XemNộiLựcToolStripMenuItem As ToolStripMenuItem
End Class
