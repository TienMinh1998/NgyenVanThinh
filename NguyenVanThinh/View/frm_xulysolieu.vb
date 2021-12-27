Imports System.Threading

Public Class frm_xulysolieu
    Private data As DataConnection
    Private _mang As New List(Of String)
    Private dem As Boolean = False
    Dim ve As Boolean = False
    Private kiemtra As Boolean = False
    Private Shared _instance As frm_xulysolieu
    Public Shared ReadOnly Property Instance As frm_xulysolieu
        Get
            If _instance Is Nothing Then _instance = New frm_xulysolieu
            Return _instance
        End Get
    End Property
    Public Property Mang As List(Of String)
        Get
            Return _mang
        End Get
        Set(value As List(Of String))
            _mang = value
        End Set
    End Property
    Private Sub cbb_dai_strip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_dai_strip.SelectedIndexChanged
        Dulieudungchung.namegiaistrip = cbb_dai_strip.SelectedItem.ToString


        data = New DataConnection
        data_griview.DataSource = data.ReturnTable(Dulieudungchung.path, cbb_dai_strip.Text.ToString)
        add_to_class(Convert.ToInt16(NumericUpDown1.Value)) ' NUmericUpDown1 là giá trị Phi mình chọn
        ' chọn chiều dày của giải bản và load strip
        DataToDraw.chieudaiban = bangnoiluccon(bangnoiluccon.Count - 1).Station
        DataToDraw.nameofstrip = cbb_dai_strip.SelectedItem.ToString
        ' vẽ biểu đồ
        pn_main.Controls.Clear()
        pn_main.Controls.Add(data_griview)
        Dim a As New BusinessBieudoMomen
        a.vebieudo(bangnoiluccon, Me)
        hambotrithep()

    End Sub
    Private Sub add_to_class(phi As Integer)
        ' xóa dữ liệu cũ của bảng nội lực 
        bangnoiluccon.Clear()
        For index = 0 To data_griview.Rows.Count - 2
            Dim station, m3, gx, gy As Double
            Dim location As String
            Dim Ho_san As Double = Module_vatlieu.chieudaysan - Module_vatlieu.Asan
            Dim strip As String = data_griview.Rows(index).Cells(0).Value.ToString
            station = Val(data_griview.Rows(index).Cells(1).Value)
            location = data_griview.Rows(index).Cells(2).Value.ToString
            m3 = Val(data_griview.Rows(index).Cells(3).Value)
            gx = Val(data_griview.Rows(index).Cells(4).Value)
            gy = Val(data_griview.Rows(index).Cells(5).Value)

            Dim cell As New CellNoiLuc(strip, station, location, m3, gx, gy, phi, Module_vatlieu.betong, Module_vatlieu.thep, 10)
            bangnoiluccon.Add(cell)
        Next

        ' trả về 1 thằng đó là chiều dài bản
    End Sub

    Private Sub frm_xulysolieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim business As New BussinessFRM_Main()
        Try
            If business.FRM.XulyState = True Then
                data = New DataConnection()
                Dim StripName As New List(Of String)
                'cbb_dai_strip.Items.Clear()
                StripName = data.ReturnArrayNameOFStrip(Dulieudungchung.path)
                For i = 0 To StripName.Count - 1
                    cbb_dai_strip.Items.Add(StripName(i))
                Next
                cbb_dai_strip.SelectedItem = Dulieudungchung.namegiaistrip
                data_griview.DataSource = data.ReturnTable(Dulieudungchung.path, cbb_dai_strip.Text.ToString)
                kiemtra = True
            Else
                MessageBox.Show("Chưa có dữ liệu")
            End If
        Catch ex As Exception

        End Try




    End Sub


    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged



        Dulieudungchung.Mphi = Convert.ToInt16(NumericUpDown1.Value)
        Select Case Mphi
            Case 6
                DataToDraw.scautao = 120
            Case 7
                DataToDraw.scautao = 130
            Case 8
                DataToDraw.scautao = 150
            Case 9
                DataToDraw.scautao = 180
            Case 10
                DataToDraw.scautao = 200
        End Select
        add_to_class(Convert.ToInt16(NumericUpDown1.Value)) ' NUmericUpDown1 là giá trị Phi mình chọn
        Dim frm As New frm_tinhtoanthep()
        OpenForm(frm)
        If kiemtra = True Then
            hambotrithep()
        End If

    End Sub

    Private Sub btn_tinhtoanthep_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btn_ve_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_bieudomomen_Click(sender As Object, e As EventArgs)
        ' ấn nút này là thêm 1 mảng 
        Dim a As New BusinessBieudoMomen
        Dim frm As New Frm_ChartMomen()
        a.vebieudo(bangnoiluccon, frm)
        frm.Show()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        'Dim a As New BusinessBieudoMomen
        'Dim frm As New Frm_ChartMomen()
        'a.vebieudo(bangnoiluccon, frm)
        'frm.Show()
    End Sub
    Sub chang_view(ByVal panel As Form)
        pn_main.Controls.Clear()
        pn_main.Controls.Add(panel)
        panel.Dock = DockStyle.Fill

    End Sub
    Sub OpenForm(childForm As Form)
        Dim activeForm As Form
        If activeForm IsNot Nothing Then activeForm.Close()
        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.pn_main.Controls.Add(childForm)
        Me.pn_main.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub hambotrithep()
        txt_first.Text = bangnoiluccon(0).Schon
        txt_end.Text = bangnoiluccon(bangnoiluccon.Count - 1).Schon
        Dim math As New MathOfList
        txt_thepmax.Text = math.ReturnSteelMax(math.ReturnMax(bangnoiluccon), bangnoiluccon)
        txt_thepmin.Text = math.ReturnSteelMax(math.ReturnMin(bangnoiluccon), bangnoiluccon)
    End Sub

    Private Sub btn_veve_Click(sender As Object, e As EventArgs)

        A_frm_main.UpdateWindow()

    End Sub

    Private Sub btn_xacnhan_Click(sender As Object, e As EventArgs)

    End Sub
    Function TInhtoanthep(thep As String) As String
        Dim thepduong As String = String.Empty
        For i = 4 To thep.Count - 1
            thepduong = thepduong + thep(i)
        Next
        Return thepduong
    End Function
    Private Sub btn_xemketquatinh_Click(sender As Object, e As EventArgs)
        add_to_class(Convert.ToInt16(NumericUpDown1.Value)) ' NUmericUpDown1 là giá trị Phi mình chọn
        Dim frm As New frm_tinhtoanthep()
        OpenForm(frm)
    End Sub

    Private Sub btn_dongfrm_Click(sender As Object, e As EventArgs) Handles btn_dongfrm.Click
        Me.Close()
    End Sub

    Private Sub btn_chonthep_Click(sender As Object, e As EventArgs) Handles btn_chonthep.Click
        Dim Business_Data As New BussinessFRM_Main()
        Business_Data.TurnOnBanve() ' bật lên là cho phép vẽ
        ve = True
        dem = True
        Dim thepduongs As String = txt_thepmax.Text
        Dim thepgoiAs As String = txt_first.Text
        DataToDraw.thepmomenduong = TInhtoanthep(txt_thepmax.Text)
        DataToDraw.thepgoia = TInhtoanthep(txt_first.Text)
        DataToDraw.thepgoib = TInhtoanthep(txt_end.Text)
        DataToDraw.goinhip1 = TInhtoanthep(txt_thepmin.Text)
        DataToDraw.goinhip2 = TInhtoanthep(txt_thepmin.Text)
        ' thực hiện luôn luồng 2 

        Business_Data.chang_view(A_frm_main.Instance.Bangnoiluc)
        Business_Data.callchart()
        Business_Data.CallUpdateModel()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class