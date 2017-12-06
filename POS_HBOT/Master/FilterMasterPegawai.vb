Public Class FilterMasterPegawai

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        If tb_kdpegawai.Text = "" And tb_nmpegawai.Text = "" And tb_username.Text = "" Then
            MessageBox.Show("Salah satu filed harus diisi!!")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FilterMasterPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_kdpegawai.Text = ""
        tb_nmpegawai.Text = ""
        tb_username.Text = ""
    End Sub
End Class