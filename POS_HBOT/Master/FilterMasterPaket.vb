Public Class FilterMasterPaket

    Private Sub FilterMasterPaket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
    End Sub

    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        If tb_kdpaket.Text = "" And tb_nmpaket.Text = "" And cmb_member.SelectedItem = "" Then
            MessageBox.Show("Salah satu filed harus diisi!!")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        clearForm()
        Me.Close()
    End Sub

    Private Sub clearForm()
        tb_kdpaket.Text = ""
        tb_nmpaket.Text = ""
        cmb_member.SelectedItem = ""
    End Sub

End Class