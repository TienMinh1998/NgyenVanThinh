<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_xulysolieu
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_xulysolieu))
        Me.data_griview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbb_dai_strip = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pn_main = New System.Windows.Forms.Panel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.txt_first = New System.Windows.Forms.TextBox()
        Me.txt_end = New System.Windows.Forms.TextBox()
        Me.txt_thepmax = New System.Windows.Forms.TextBox()
        Me.txt_thepmin = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btn_chonthep = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_dongfrm = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.data_griview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_main.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'data_griview
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.data_griview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.data_griview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_griview.BackgroundColor = System.Drawing.Color.White
        Me.data_griview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.data_griview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data_griview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_griview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.data_griview.ColumnHeadersHeight = 4
        Me.data_griview.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(245, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_griview.DefaultCellStyle = DataGridViewCellStyle9
        Me.data_griview.EnableHeadersVisualStyles = False
        Me.data_griview.GridColor = System.Drawing.Color.Silver
        Me.data_griview.Location = New System.Drawing.Point(18, 17)
        Me.data_griview.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.data_griview.Name = "data_griview"
        Me.data_griview.RowHeadersVisible = False
        Me.data_griview.RowHeadersWidth = 51
        Me.data_griview.RowTemplate.Height = 24
        Me.data_griview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_griview.Size = New System.Drawing.Size(740, 573)
        Me.data_griview.TabIndex = 2
        Me.data_griview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Turquoise
        Me.data_griview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.data_griview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.data_griview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.data_griview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.data_griview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.data_griview.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.data_griview.ThemeStyle.GridColor = System.Drawing.Color.Silver
        Me.data_griview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.data_griview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.data_griview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.data_griview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.data_griview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.data_griview.ThemeStyle.HeaderStyle.Height = 4
        Me.data_griview.ThemeStyle.ReadOnly = False
        Me.data_griview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.data_griview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data_griview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.data_griview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.data_griview.ThemeStyle.RowsStyle.Height = 24
        Me.data_griview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.data_griview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Chọn đường kính "
        '
        'cbb_dai_strip
        '
        Me.cbb_dai_strip.FormattingEnabled = True
        Me.cbb_dai_strip.Location = New System.Drawing.Point(167, 95)
        Me.cbb_dai_strip.Name = "cbb_dai_strip"
        Me.cbb_dai_strip.Size = New System.Drawing.Size(100, 24)
        Me.cbb_dai_strip.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Strip"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(167, 54)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(101, 22)
        Me.NumericUpDown1.TabIndex = 5
        Me.NumericUpDown1.Tag = "9"
        Me.NumericUpDown1.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Silver
        Me.Chart1.BorderlineWidth = 2
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(792, 83)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(590, 291)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        '
        'pn_main
        '
        Me.pn_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pn_main.Controls.Add(Me.data_griview)
        Me.pn_main.Location = New System.Drawing.Point(12, 83)
        Me.pn_main.Name = "pn_main"
        Me.pn_main.Size = New System.Drawing.Size(774, 609)
        Me.pn_main.TabIndex = 17
        '
        'txt_first
        '
        Me.txt_first.Location = New System.Drawing.Point(444, 51)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.Size = New System.Drawing.Size(100, 22)
        Me.txt_first.TabIndex = 18
        '
        'txt_end
        '
        Me.txt_end.Location = New System.Drawing.Point(444, 98)
        Me.txt_end.Name = "txt_end"
        Me.txt_end.Size = New System.Drawing.Size(100, 22)
        Me.txt_end.TabIndex = 18
        '
        'txt_thepmax
        '
        Me.txt_thepmax.Location = New System.Drawing.Point(444, 137)
        Me.txt_thepmax.Name = "txt_thepmax"
        Me.txt_thepmax.Size = New System.Drawing.Size(100, 22)
        Me.txt_thepmax.TabIndex = 18
        '
        'txt_thepmin
        '
        Me.txt_thepmin.Location = New System.Drawing.Point(167, 136)
        Me.txt_thepmin.Name = "txt_thepmin"
        Me.txt_thepmin.Size = New System.Drawing.Size(100, 22)
        Me.txt_thepmin.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_chonthep)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_thepmin)
        Me.GroupBox2.Controls.Add(Me.txt_first)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.txt_end)
        Me.GroupBox2.Controls.Add(Me.cbb_dai_strip)
        Me.GroupBox2.Controls.Add(Me.txt_thepmax)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(792, 380)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 312)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "KẾT QUẢ BỐ TRÍ THÉP TỰ ĐỘNG"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(292, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 17)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Thép Mũ Gối B : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(292, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Thép vùng kéo giữa : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Thép mũ nhịp giữa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(292, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Thép Mũ Gối A : "
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btn_chonthep
        '
        Me.btn_chonthep.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_chonthep.CheckedState.Parent = Me.btn_chonthep
        Me.btn_chonthep.CustomImages.Parent = Me.btn_chonthep
        Me.btn_chonthep.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_chonthep.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_chonthep.ForeColor = System.Drawing.Color.Black
        Me.btn_chonthep.HoverState.Parent = Me.btn_chonthep
        Me.btn_chonthep.Image = CType(resources.GetObject("btn_chonthep.Image"), System.Drawing.Image)
        Me.btn_chonthep.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_chonthep.Location = New System.Drawing.Point(225, 175)
        Me.btn_chonthep.Name = "btn_chonthep"
        Me.btn_chonthep.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_chonthep.ShadowDecoration.Parent = Me.btn_chonthep
        Me.btn_chonthep.Size = New System.Drawing.Size(120, 120)
        Me.btn_chonthep.TabIndex = 22
        Me.btn_chonthep.Text = "Chọn Thép"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Phân Tích Biểu Đồ Moment và chọn thép "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'btn_dongfrm
        '
        Me.btn_dongfrm.CheckedState.Parent = Me.btn_dongfrm
        Me.btn_dongfrm.CustomImages.Parent = Me.btn_dongfrm
        Me.btn_dongfrm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_dongfrm.ForeColor = System.Drawing.Color.White
        Me.btn_dongfrm.HoverState.Parent = Me.btn_dongfrm
        Me.btn_dongfrm.Image = CType(resources.GetObject("btn_dongfrm.Image"), System.Drawing.Image)
        Me.btn_dongfrm.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_dongfrm.Location = New System.Drawing.Point(1333, 1)
        Me.btn_dongfrm.Name = "btn_dongfrm"
        Me.btn_dongfrm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_dongfrm.ShadowDecoration.Parent = Me.btn_dongfrm
        Me.btn_dongfrm.Size = New System.Drawing.Size(54, 53)
        Me.btn_dongfrm.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aqua
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_dongfrm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1394, 61)
        Me.Panel1.TabIndex = 21
        '
        'frm_xulysolieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1394, 704)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pn_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_xulysolieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xử Lý Số Liệu"
        CType(Me.data_griview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_main.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents data_griview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbb_dai_strip As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents pn_main As Panel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents txt_first As TextBox
    Friend WithEvents txt_end As TextBox
    Friend WithEvents txt_thepmax As TextBox
    Friend WithEvents txt_thepmin As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btn_chonthep As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_dongfrm As Guna.UI2.WinForms.Guna2CircleButton
End Class
