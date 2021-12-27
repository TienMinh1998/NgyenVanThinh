Module Dulieudungchung
    ' Hàm hiển thị form vào trong FORM chính mà ta quy định
    Public path As String ' đường dẫn 
    Public activeForm As Form
    ' Dữ liệu liên quan đến phần bảng nội lực
    Public sobanghi As Integer
    ' Danh sách trong bảng nội lực 
    Public recordload As New List(Of CellNoiLuc)
    ' Bảng Nội Lực khi Chọn xong giải Strip nhưng chưa tính As
    Public bangnoiluccon As New List(Of CellNoiLuc)
    ' bảng kích thước khi load vào 
    Public bangkichthuoc As New List(Of CellKichthuoc)
    ' Lưới=======================================================
    Public GridLines As New List(Of CellGridLine)
    Public GridLines_x As New List(Of CellGridLine) ' theo phương x có 1,2,3
    Public GridLines_y As New List(Of CellGridLine) ' theo phương y có A, B, C
    '=========================================================================
    ' Kích thước và vị trí của các giải Strip
    Public kichthuoc As New List(Of CellKichthuoc)



    Public sobanghikt As Integer
    Public Mphi As Integer
    ' số bản ghi của lưới : 
    Public CountGridLines As Integer


    Private Sub Open_frm(childForm As Form)
        If activeForm IsNot Nothing Then activeForm.Close()
        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        A_frm_main.btn_xembangnoiluc.Controls.Add(childForm)
        A_frm_main.btn_xembangnoiluc.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    ' Nội lực
    Public maxx As Double
    Public Minn As Double
    Public processbolean As Boolean = False
    ' bản vẽ của Trịnh Văn Viện

    Public namegiaistrip As String = "CSB5"

End Module
