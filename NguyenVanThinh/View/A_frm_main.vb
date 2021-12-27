Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Public Class A_frm_main
    Private Business_Data As BussinessFRM_Main
    Private DataSite As Boolean = False
    Private _BanveState As Boolean = False
    Private _XulyState As Boolean = False
    Private _vatlieuState As Boolean = False
    Private _bangnoiluc As UserDataExcel
    Private _bangkichthuoc As User_bangkichthuoc
    Private _vatlieu As user_vatlieu
    Private _bangnoilucExcel As user_data2
    Private _banve As user_banve
    Private _Draw As New Drawing
    Private data As DataConnection
    Private hamve As Drawing
    Private _GridLines As UserGridLinnes
    Private Shared _instance As A_frm_main
    Public Shared ReadOnly Property Instance As A_frm_main
        Get
            If _instance Is Nothing Then _instance = New A_frm_main()
            Return _instance
        End Get
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Property Bangnoiluc As UserDataExcel
        Get
            If _bangnoiluc Is Nothing Then _bangnoiluc = New UserDataExcel()
            Return _bangnoiluc
        End Get
        Set(value As UserDataExcel)
            _bangnoiluc = value
        End Set
    End Property

    Public Property Vatlieu As user_vatlieu
        Get
            If _vatlieu Is Nothing Then _vatlieu = New user_vatlieu()
            Return _vatlieu
        End Get
        Set(value As user_vatlieu)
            _vatlieu = value
        End Set
    End Property
    Public Property BangnoilucExcel As user_data2
        Get
            If _bangnoilucExcel Is Nothing Then _bangnoilucExcel = New user_data2()
            Return _bangnoilucExcel
        End Get
        Set(value As user_data2)
            _bangnoilucExcel = value
        End Set
    End Property
    Public Property Banve As user_banve
        Get
            If _banve Is Nothing Then _banve = New user_banve()

            Return _banve
        End Get
        Set(value As user_banve)
            _banve = value
        End Set
    End Property

    Public Property Draw As Drawing
        Get
            Return _Draw
        End Get
        Set(value As Drawing)
            _Draw = value
        End Set
    End Property

    Public Property Bangkichthuoc As User_bangkichthuoc
        Get
            If _bangkichthuoc Is Nothing Then _bangkichthuoc = New User_bangkichthuoc()
            Return _bangkichthuoc
        End Get
        Set(value As User_bangkichthuoc)
            _bangkichthuoc = value
        End Set
    End Property

    Public Property GridLines As UserGridLinnes
        Get
            If _GridLines Is Nothing Then _GridLines = New UserGridLinnes()
            Return _GridLines
        End Get
        Set(value As UserGridLinnes)
            _GridLines = value
        End Set
    End Property

    Public Property BanveState As Boolean
        Get
            Return _BanveState
        End Get
        Set(value As Boolean)
            _BanveState = value
        End Set
    End Property

    Public Property XulyState As Boolean
        Get
            Return _XulyState
        End Get
        Set(value As Boolean)
            _XulyState = value
        End Set
    End Property

    Public Property VatlieuState As Boolean
        Get
            Return _vatlieuState
        End Get
        Set(value As Boolean)
            _vatlieuState = value
        End Set
    End Property

    Private Sub btn_new_Click(sender As Object, e As EventArgs)
        ' Call View New
        Business_Data = New BussinessFRM_Main()
        Business_Data.CallViewNew()
    End Sub
    Private Sub btn_bangnoiluc_Click(sender As Object, e As EventArgs) Handles btn_bangnoiluc.Click
        ' Call View Bảng Nội Lực
        Business_Data = New BussinessFRM_Main()
        Business_Data.chang_view(A_frm_main.Instance.Bangnoiluc)
    End Sub
    ' Clear View Panel- DELETE
    Private Sub btn_xoa_Click(sender As Object, e As EventArgs)
        Business_Data.FRM.btn_xembangnoiluc.Controls.Clear()
    End Sub
    ' Call View User_New
    Private Sub frm_tinhtoansafe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _instance = Me
        Business_Data = New BussinessFRM_Main()
        Business_Data.chang_view(User_banve_matbang.Instance)
    End Sub
    ' View FRM Chọn vật liệu
    Private Sub btn_khaibaovatlieu_Click(sender As Object, e As EventArgs)
        Business_Data.CallViewVatlieu()
    End Sub
    'Call View Process 
    Private Sub btn_xulysolieu_Click(sender As Object, e As EventArgs) Handles btn_xulysolieu.Click
        Try
            If XulyState = True Then
                If VatlieuState = True Then
                    Business_Data.CallViewXulysolieu()
                Else
                    MessageBox.Show("bạn Chưa chọn vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("lỗi không xác định")
        End Try

    End Sub
    Private Sub btn_xuatbanve_Click(sender As Object, e As EventArgs) Handles btn_xuatbanve.Click
        Business_Data.chang_view(A_frm_main.Instance.Banve)
    End Sub
    ' Call Load Data
    Private Sub NewDataAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDataAccessToolStripMenuItem.Click
        Try

            If Business_Data.LoadData() = True Then
                btn_bangnoiluc.Enabled = True
                btn_matbang.Enabled = True
                btn_bangkichthuoc.Enabled = True
                btn_GridLines.Enabled = True
                DataSite = True
                BanveState = False
                XulyState = True
                MessageBox.Show("Load Dữ Liệu thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            ' dựa vào file mình chọn     

        Catch ex As Exception
            MessageBox.Show("Data Failure: " + ex.Message)
        End Try

    End Sub
    'Call View Ban Ve
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_matbang.Click
        Try
            If DataSite = True Then
                Business_Data.CallViewPlan(3000) ' 3000 là khoảng cách đến kí hiệu trục
            Else
                MessageBox.Show("Chưa có dữ liệu mặt bằng, bạn phải load dữ liệu trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub UpdateWindow()
        Business_Data.chang_view(user_banve.Instance)
    End Sub
    ' Call View Setting Of Application
    Private Sub btn_caidat_Click(sender As Object, e As EventArgs) Handles btn_caidat.Click
        Business_Data = New BussinessFRM_Main()
    End Sub

    Private Sub FluentDesignFormControl1_Click(sender As Object, e As EventArgs) Handles FluentDesignFormControl1.Click

    End Sub

    Private Sub btn_GridLines_Click(sender As Object, e As EventArgs) Handles btn_GridLines.Click
        ' Call View Bảng Nội Lực
        Business_Data.chang_view(A_frm_main.Instance.GridLines)
    End Sub

    Private Sub btn_bangkichthuoc_Click(sender As Object, e As EventArgs) Handles btn_bangkichthuoc.Click
        Business_Data.chang_view(A_frm_main.Instance.Bangkichthuoc)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub VậtLiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VậtLiệuToolStripMenuItem.Click
        Business_Data.CallViewVatlieu()
    End Sub



    Private Sub btn_ve_Click(sender As Object, e As EventArgs) Handles btn_ve.Click
        Try
            If XulyState = True Then
                If BanveState = True Then
                    Business_Data.CallvewBANVE()
                Else
                    MessageBox.Show("bạn Chưa chọn thép!!! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Bạn Chưa Load Dữ Liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi không xác định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try



    End Sub

    Private Sub btn_momen_Click(sender As Object, e As EventArgs) Handles btn_momen.Click
        Try
            If XulyState = True Then
                If VatlieuState = True Then
                    Business_Data.CallViewXulysolieu()
                Else
                    MessageBox.Show("bạn Chưa chọn vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Chưa có dữ liệu để vẽ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi không xác định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_xuat_Click(sender As Object, e As EventArgs) Handles btn_xuat.Click

    End Sub
    Private Sub DisPlayFORM(childForm As Form)
        'Dim activeForm As Form
        'If activeForm IsNot Nothing Then activeForm.Close()
        'activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.btn_xembangnoiluc.Controls.Add(childForm)
        Me.btn_xembangnoiluc.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub XemNộiLựcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemNộiLựcToolStripMenuItem.Click
        ' Call View Bảng Nội Lực
        Business_Data = New BussinessFRM_Main()
        Business_Data.chang_view(A_frm_main.Instance.Bangnoiluc)
    End Sub
End Class
