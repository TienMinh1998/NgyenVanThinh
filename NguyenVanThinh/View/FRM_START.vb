Public Class FRM_START
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 3
        If Panel2.Width >= Panel1.Width Then
            Timer1.Stop()
            Me.Hide()
            A_frm_main.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class