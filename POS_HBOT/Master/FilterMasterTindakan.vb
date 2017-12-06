Public Class FilterMasterTindakan

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub FilterMasterTindakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_nmtindakan.Text = ""
        tb_harga.Text = ""
        tb_ket.Text = ""
    End Sub

    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        Dim harga As String = Replace(tb_harga.Text, ",", "")
        If tb_nmtindakan.Text = "" And harga = "" And tb_ket.Text = "" Then
            MessageBox.Show("Salah satu filed harus diisi!!")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub tb_harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_harga.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tb_harga_TextChanged(sender As Object, e As EventArgs) Handles tb_harga.TextChanged
        If Len(tb_harga.Text) > 0 Then
            tb_harga.Text = FormatNumber(CDbl(tb_harga.Text), 0)
            Dim x As Integer = tb_harga.SelectionStart.ToString
            If x = 0 Then
                tb_harga.SelectionStart = Len(tb_harga.Text)
                tb_harga.SelectionLength = 0
            Else
                tb_harga.SelectionStart = x
                tb_harga.SelectionLength = 0
            End If
        End If
    End Sub
End Class