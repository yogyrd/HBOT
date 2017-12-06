Public Class FilterMasterFee

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        If tb_nmpegawai.Text = "" And tb_nmgroup.Text = "" And tb_fee.Text = "" Then
            MessageBox.Show("Salah satu filed harus diisi!!")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FilterMasterFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_nmgroup.Text = ""
        tb_nmpegawai.Text = ""
        tb_fee.Text = ""
    End Sub

    Private Sub tb_fee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_fee.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tb_fee_TextChanged(sender As Object, e As EventArgs) Handles tb_fee.TextChanged
        If Len(tb_fee.Text) > 0 Then
            tb_fee.Text = FormatNumber(CDbl(tb_fee.Text), 0)
            Dim x As Integer = tb_fee.SelectionStart.ToString
            If x = 0 Then
                tb_fee.SelectionStart = Len(tb_fee.Text)
                tb_fee.SelectionLength = 0
            Else
                tb_fee.SelectionStart = x
                tb_fee.SelectionLength = 0
            End If
        End If
    End Sub
End Class