' frm chọn vật liệu ban đầu
' truyền vào giá trị của vật liệu, lưu ở mudund : Dữ liệu dùng chung
' Ngày viết : 27/12/2020
'Người viết : Trịnh Văn Viện 
' CHỉnh sửa :  chưa

Public Class ChonVatlieuView



    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        ' Chọn bê tông
        If ccb_betong.Text = "" Then
            lb_chonbetong.Visible = True

        Else
            If ccb_thep.Text = "" Then
                lb_banchuachonthep.Visible = True
            Else
                If IsNumeric(txt_chieudaysan.Text) Then
                    If IsNumeric(txt_lopbaove.Text) Then
                        Select Case ccb_betong.SelectedIndex
                            Case 0
                                Module_vatlieu.betong = 14.5
                                Module_vatlieu.nameofbetong = "B25"
                            Case 1
                                Module_vatlieu.betong = 11.5
                                Module_vatlieu.nameofbetong = "B20"
                            Case 2
                                Module_vatlieu.betong = 8.5
                                Module_vatlieu.nameofbetong = "B15"
                        End Select
                        ' chọn loại thép
                        Select Case ccb_thep.SelectedIndex
                            Case 0
                                Module_vatlieu.thep = 210
                                Module_vatlieu.nameofthep = "CB240-T"
                            Case 1
                                Module_vatlieu.thep = 260
                                Module_vatlieu.nameofthep = "CB300-T"
                            Case 2
                                Module_vatlieu.thep = 260
                                Module_vatlieu.nameofthep = "CB300-V"

                        End Select
                        ' chọn chiều dày sàn và lớp bảo vệ 

                        Module_vatlieu.chieudaysan = Convert.ToDouble(txt_chieudaysan.Text)
                        Module_vatlieu.Asan = Convert.ToDouble(txt_lopbaove.Text)


                        Me.Close()
                    Else
                        txt_lopbaove.Focus()
                        txt_lopbaove.ForeColor = Color.Red
                        lb_lopbaove.Visible = True
                    End If
                Else
                    txt_chieudaysan.Focus()
                    txt_chieudaysan.ForeColor = Color.Red
                    lb_chieudaysan.Visible = True
                End If
            End If
            ''''''''''''


        End If
        Me.Close()

    End Sub

    Private Sub ccb_betong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ccb_betong.SelectedIndexChanged
        lb_chonbetong.Visible = False
        Select Case ccb_betong.SelectedIndex
            Case 0
                lb_betong.Text = "Rb=14.5 (MPA)"
            Case 1
                lb_betong.Text = "Rb=11.5 (MPA)"
            Case 2
                lb_betong.Text = "Rb=8.5 (MPA)"
        End Select


    End Sub

    Private Sub ccb_thep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ccb_thep.SelectedIndexChanged
        lb_banchuachonthep.Visible = False
        Select Case ccb_thep.SelectedIndex
            Case 0
                lb_donvithep.Text = "Rs=210 (MPA)"
            Case 1
                lb_donvithep.Text = "Rs=260 (MPA)"
            Case 2
                lb_donvithep.Text = "Rs=260 (MPA)"
        End Select
    End Sub

    Private Sub frm_chonvatlieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_chieudaysan_TextChanged(sender As Object, e As EventArgs) Handles txt_chieudaysan.TextChanged
        lb_chieudaysan.Visible = False
    End Sub

    Private Sub txt_lopbaove_TextChanged(sender As Object, e As EventArgs) Handles txt_lopbaove.TextChanged
        lb_lopbaove.Visible = False
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class