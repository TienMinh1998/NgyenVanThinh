<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_chonvatlieu
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_chonvatlieu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ccb_betong = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ccb_thep = New System.Windows.Forms.ComboBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_chieudaysan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_lopbaove = New System.Windows.Forms.TextBox()
        Me.lb_chonbetong = New System.Windows.Forms.Label()
        Me.lb_banchuachonthep = New System.Windows.Forms.Label()
        Me.lb_chieudaysan = New System.Windows.Forms.Label()
        Me.lb_lopbaove = New System.Windows.Forms.Label()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chọn Bê Tông"
        '
        'ccb_betong
        '
        Me.ccb_betong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccb_betong.FormattingEnabled = True
        Me.ccb_betong.Items.AddRange(New Object() {"B25", "B20", "B15"})
        Me.ccb_betong.Location = New System.Drawing.Point(193, 49)
        Me.ccb_betong.Name = "ccb_betong"
        Me.ccb_betong.Size = New System.Drawing.Size(226, 24)
        Me.ccb_betong.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Chọn Thép"
        '
        'ccb_thep
        '
        Me.ccb_thep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccb_thep.FormattingEnabled = True
        Me.ccb_thep.Items.AddRange(New Object() {"CB-240-T", "CB-300-T", "CB-300-V"})
        Me.ccb_thep.Location = New System.Drawing.Point(193, 100)
        Me.ccb_thep.Name = "ccb_thep"
        Me.ccb_thep.Size = New System.Drawing.Size(226, 24)
        Me.ccb_thep.TabIndex = 1
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(250, 274)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(139, 54)
        Me.btn_ok.TabIndex = 4
        Me.btn_ok.Text = "Xác Nhận"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Chiều Dày sàn"
        '
        'txt_chieudaysan
        '
        Me.txt_chieudaysan.Location = New System.Drawing.Point(193, 152)
        Me.txt_chieudaysan.Name = "txt_chieudaysan"
        Me.txt_chieudaysan.Size = New System.Drawing.Size(226, 23)
        Me.txt_chieudaysan.TabIndex = 2
        Me.txt_chieudaysan.Text = "13"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Lớp bảo vệ"
        '
        'txt_lopbaove
        '
        Me.txt_lopbaove.Location = New System.Drawing.Point(193, 205)
        Me.txt_lopbaove.Name = "txt_lopbaove"
        Me.txt_lopbaove.Size = New System.Drawing.Size(226, 23)
        Me.txt_lopbaove.TabIndex = 3
        Me.txt_lopbaove.Text = "2"
        '
        'lb_chonbetong
        '
        Me.lb_chonbetong.AutoSize = True
        Me.lb_chonbetong.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_chonbetong.ForeColor = System.Drawing.Color.Red
        Me.lb_chonbetong.Location = New System.Drawing.Point(197, 77)
        Me.lb_chonbetong.Name = "lb_chonbetong"
        Me.lb_chonbetong.Size = New System.Drawing.Size(158, 17)
        Me.lb_chonbetong.TabIndex = 8
        Me.lb_chonbetong.Text = "Bạn Chưa chọn Bê Tông"
        Me.lb_chonbetong.Visible = False
        '
        'lb_banchuachonthep
        '
        Me.lb_banchuachonthep.AutoSize = True
        Me.lb_banchuachonthep.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_banchuachonthep.ForeColor = System.Drawing.Color.Red
        Me.lb_banchuachonthep.Location = New System.Drawing.Point(197, 128)
        Me.lb_banchuachonthep.Name = "lb_banchuachonthep"
        Me.lb_banchuachonthep.Size = New System.Drawing.Size(133, 17)
        Me.lb_banchuachonthep.TabIndex = 8
        Me.lb_banchuachonthep.Text = "Bạn chưa chọn thép"
        Me.lb_banchuachonthep.Visible = False
        '
        'lb_chieudaysan
        '
        Me.lb_chieudaysan.AutoSize = True
        Me.lb_chieudaysan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_chieudaysan.ForeColor = System.Drawing.Color.Red
        Me.lb_chieudaysan.Location = New System.Drawing.Point(195, 180)
        Me.lb_chieudaysan.Name = "lb_chieudaysan"
        Me.lb_chieudaysan.Size = New System.Drawing.Size(133, 17)
        Me.lb_chieudaysan.TabIndex = 8
        Me.lb_chieudaysan.Text = "Phải Nhập Giá trị số!!"
        Me.lb_chieudaysan.Visible = False
        '
        'lb_lopbaove
        '
        Me.lb_lopbaove.AutoSize = True
        Me.lb_lopbaove.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_lopbaove.ForeColor = System.Drawing.Color.Red
        Me.lb_lopbaove.Location = New System.Drawing.Point(192, 233)
        Me.lb_lopbaove.Name = "lb_lopbaove"
        Me.lb_lopbaove.Size = New System.Drawing.Size(133, 17)
        Me.lb_lopbaove.TabIndex = 8
        Me.lb_lopbaove.Text = "Phải Nhập Giá trị số!!"
        Me.lb_lopbaove.Visible = False
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 43)
        Me.Panel1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(24, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Chọn Sơ Bộ Vật Liệu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(437, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frm_chonvatlieu
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(639, 353)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lb_lopbaove)
        Me.Controls.Add(Me.lb_chieudaysan)
        Me.Controls.Add(Me.ccb_betong)
        Me.Controls.Add(Me.lb_banchuachonthep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_chonbetong)
        Me.Controls.Add(Me.ccb_thep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_lopbaove)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_chieudaysan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_chonvatlieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chọn Vật Liệu Sử Dụng"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ccb_betong As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ccb_thep As ComboBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_chieudaysan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_lopbaove As TextBox
    Friend WithEvents lb_chonbetong As Label
    Friend WithEvents lb_banchuachonthep As Label
    Friend WithEvents lb_chieudaysan As Label
    Friend WithEvents lb_lopbaove As Label
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
