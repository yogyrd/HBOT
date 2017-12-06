Imports System.Text
Imports System.Windows.Forms

Public Class InputMasterVoucher
    Dim tbl As String = "mst_voucher"
    Dim status As String

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub InputMasterVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
        If queryMode = "update" Then
            loadDataByID()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim disc_nominal As String = Replace(tb_diskonNominal.Text, ",", "")
        status = cmb_status.SelectedItem
        If status = "Aktif" Then
            status = "1"
        Else
            status = "0"
        End If
        If tb_diskonNominal.Text = "" Then
            tb_diskonNominal.Text = "0"
        End If
        If tb_diskonProsentase.Text = "" Then
            tb_diskonProsentase.Text = "0"
        End If
        Try
            If queryMode = "insert" Then
                Dim columnsName As String = "(`kode_voucher`,`diskon_prosentase`,`diskon_nominal`,`ket_voucher`,`status_voucher`,`mulai_voucher`,`akhir_voucher`,`createdby`)"
                Dim columnsValue As String = "('" + tb_kdVoucher.Text + "','" + tb_diskonProsentase.Text + "','" + disc_nominal + "','" + tb_ket.Text + "'," + status + ",'" + dtp_awal.Text + "','" + dtp_akhir.Text + "'," + "1)"
                insert_data(tbl, columnsName, columnsValue)
                errmsg_sukses_simpan()
                clearForm()
            ElseIf queryMode = "update" Then
                Dim updateQuery As String = "diskon_prosentase='" + tb_diskonProsentase.Text + "',diskon_nominal='" + disc_nominal + "',ket_voucher='" + tb_ket.Text + "',status_voucher='" + status + "',mulai_voucher='" + dtp_awal.Text + "',akhir_voucher='" + dtp_akhir.Text + "'"
                Dim kondisi As String = "id_voucher='" + MasterVoucher.id_voucher + "'"
                update_data(tbl, updateQuery, kondisi)
                errmsg_sukses_ubah()
                Me.Close()
            End If
        Catch ex As Exception
            errmsg_gagal_simpan()
        End Try
    End Sub

    Private Sub btn_randomKode_Click(sender As Object, e As EventArgs) Handles btn_randomKode.Click
        If queryMode = "insert" Then
            Dim kode As String = generateKode()
            Try
                load_data_by_id(tbl, "kode_voucher", kode)
                If dr.HasRows Then
                    dr.Read()
                    Do
                        kode = generateKode()
                    Loop While kode = dr("kode_voucher")
                End If
            Catch ex As Exception
                errmsg_gagal()
            End Try
            dr.Close()
            tb_kdVoucher.Text = kode
        ElseIf queryMode = "update" Then
            MsgBox("Kode Voucher Tiak Boleh Diganti!")
        End If
    End Sub

    Private Sub clearForm()
        tb_kdVoucher.Text = ""
        cmb_status.SelectedItem = ""
        tb_ket.Text = ""
        tb_diskonProsentase.Text = 0
        tb_diskonNominal.Text = 0
        dtp_awal.Text = Format(Now, ("yyyy-MM-dd"))
        dtp_akhir.Text = "9998-12-31"
    End Sub

    Private Sub loadDataByID()
        Try
            load_data_by_id(tbl, "id_voucher", MasterVoucher.id_voucher)
            If dr.HasRows Then
                dr.Read()
                tb_kdVoucher.Text = dr("kode_voucher")
                cmb_status.SelectedIndex = dr("status_voucher")
                tb_ket.Text = dr("ket_voucher")
                tb_diskonProsentase.Text = dr("diskon_prosentase")
                tb_diskonNominal.Text = dr("diskon_nominal")
                dtp_awal.Text = Format(dr("mulai_voucher"), ("yyyy-MM-dd"))
                dtp_akhir.Text = Format(dr("akhir_voucher"), ("yyyy-MM-dd"))
            End If
        Catch ex As Exception
            errmsg_gagal()
        End Try
        dr.Close()
    End Sub

    Private Sub tb_diskonProsentase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_diskonProsentase.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
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

    Private Function generateKode()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

End Class