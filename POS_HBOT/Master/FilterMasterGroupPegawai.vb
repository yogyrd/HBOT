Public Class FilterMasterGroupPegawai

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub FilterMasterGroupPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_kdgroup.Text = ""
        tb_nmgroup.Text = ""
    End Sub

    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        If tb_kdgroup.Text = "" And tb_nmgroup.Text = "" Then
            MessageBox.Show("Salah satu filed harus diisi!!")
        Else
            Me.Close()
        End If
    End Sub
End Class