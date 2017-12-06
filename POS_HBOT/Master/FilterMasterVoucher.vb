Public Class FilterMasterVoucher

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub FilterMasterVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_kodeVoucher.Text = ""
        cmb_status.SelectedText = ""
        tb_ket.Text = ""
        tb_diskonProsentase.Text = ""
        tb_diskonNominal.Text = ""
        dtp_awal.Format = DateTimePickerFormat.Custom
        dtp_awal.CustomFormat = " "
        dtp_akhir.Format = DateTimePickerFormat.Custom
        dtp_akhir.CustomFormat = " "
    End Sub

    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        If tb_kodeVoucher.Text = "" And cmb_status.SelectedValue = "" And tb_ket.Text = "" And tb_diskonProsentase.Text = "" And tb_diskonNominal.Text = "" And dtp_awal.Text = "" And dtp_akhir.Text = "" Then
            MessageBox.Show("Salah satu filed harus diisi!!")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub tb_diskonNominal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_diskonNominal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tb_diskonNominal_TextChanged(sender As Object, e As EventArgs) Handles tb_diskonNominal.TextChanged
        If Len(tb_diskonNominal.Text) > 0 Then
            tb_diskonNominal.Text = FormatNumber(CDbl(tb_diskonNominal.Text), 0)
            Dim x As Integer = tb_diskonNominal.SelectionStart.ToString
            If x = 0 Then
                tb_diskonNominal.SelectionStart = Len(tb_diskonNominal.Text)
                tb_diskonNominal.SelectionLength = 0
            Else
                tb_diskonNominal.SelectionStart = x
                tb_diskonNominal.SelectionLength = 0
            End If
        End If
    End Sub

    Private Sub tb_diskonProsentase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_diskonProsentase.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class