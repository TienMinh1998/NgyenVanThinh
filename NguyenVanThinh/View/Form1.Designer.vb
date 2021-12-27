Partial Public Class fr_gioithieu
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_gioithieu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_safe = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_ve = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chương Trình Tính Toán Sàn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(627, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 34)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Get Started"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 154)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(405, 314)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'btn_safe
        '
        Me.btn_safe.BorderRadius = 20
        Me.btn_safe.CheckedState.Parent = Me.btn_safe
        Me.btn_safe.CustomImages.Parent = Me.btn_safe
        Me.btn_safe.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_safe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_safe.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_safe.HoverState.Parent = Me.btn_safe
        Me.btn_safe.Image = CType(resources.GetObject("btn_safe.Image"), System.Drawing.Image)
        Me.btn_safe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_safe.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_safe.Location = New System.Drawing.Point(454, 154)
        Me.btn_safe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_safe.Name = "btn_safe"
        Me.btn_safe.ShadowDecoration.Parent = Me.btn_safe
        Me.btn_safe.Size = New System.Drawing.Size(499, 92)
        Me.btn_safe.TabIndex = 77
        Me.btn_safe.Text = "TẠO CHƯƠNG TRÌNH TÍNH TOÁN VS SAFE"
        Me.btn_safe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_ve
        '
        Me.btn_ve.BorderRadius = 20
        Me.btn_ve.CheckedState.Parent = Me.btn_ve
        Me.btn_ve.CustomImages.Parent = Me.btn_ve
        Me.btn_ve.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ve.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ve.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_ve.HoverState.Parent = Me.btn_ve
        Me.btn_ve.Image = CType(resources.GetObject("btn_ve.Image"), System.Drawing.Image)
        Me.btn_ve.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_ve.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_ve.Location = New System.Drawing.Point(454, 266)
        Me.btn_ve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ve.Name = "btn_ve"
        Me.btn_ve.ShadowDecoration.Parent = Me.btn_ve
        Me.btn_ve.Size = New System.Drawing.Size(499, 92)
        Me.btn_ve.TabIndex = 77
        Me.btn_ve.Text = "VẼ VÀ XUẤT DỰA TRÊN DỮ LIỆU CÓ SẴN"
        Me.btn_ve.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button2.Location = New System.Drawing.Point(454, 376)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(499, 92)
        Me.Guna2Button2.TabIndex = 77
        Me.Guna2Button2.Text = "HƯỚNG DẪN SỬ DỤNG"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "GV hướng dẫn : Nguyễn Thị Hải Như"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(647, 529)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(306, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Demo By Trịnh Văn Viện - 61TH1"
        '
        'fr_gioithieu
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 572)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.btn_ve)
        Me.Controls.Add(Me.btn_safe)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "fr_gioithieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chương Trình Tính Toán Sàn-TG-Trịnh Văn Viện"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_safe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_ve As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

#End Region

End Class
