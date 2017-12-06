Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Public Class InputBayarPendaftaran
    Dim last_id_pelanggan, last_id_daftar As Double

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If InputTransaksiPendaftaran.id_pelanggan = 0 Then
            begin_transac()

            Try
                Dim columnsNameCust As String = "(`nama_pelanggan`,`member_pelanggan`,`alamat_pelanggan`,`notelp_pelanggan`,`email_pelanggan`,`createdby`)"
                Dim columnsValueCust As String = "('" + InputTransaksiPendaftaran.cmb_pelanggan.Text + "','" + InputTransaksiPendaftaran.cmb_member.Text + _
                    "','" + InputTransaksiPendaftaran.tb_almt.Text + "','" + Replace(InputTransaksiPendaftaran.tb_notlp.Text, ".", "") + "','" + InputTransaksiPendaftaran.tb_email.Text + "'," + "1)"
                insert_transac("mst_pelanggan", columnsNameCust, columnsValueCust)

                Dim columnsNameTrans As String = "(`id_pelanggan`,`id_voucher`,`kode_member`,`tgl_trans`,`jenis_bayar`,`kartu`,`mesin`,`total_bruto`," +
                    "`diskonpersen_daftar`,`diskonnominal_daftar`,`total_neto`,`createdby`)"
                Dim columnsValueTrans As String = "('" + (getLastIdPelanggan()).ToString + "','" + tb_kdvoucher.Text + "','" + InputTransaksiPendaftaran.tb_kdmember.Text + _
                    "','" + InputTransaksiPendaftaran.dtp_tgltr.Text + "','" + cmb_jenisbayar.Text + "','" + cmb_kartu.Text + "','" + cmb_mesin.Text + _
                    "'," + Replace(lbl_total.Text, ",", "") + "," + tb_diskpersen.Text + "," + Replace(tb_disknominal.Text, ",", "") + "," + Replace(lbl_grandtotal.Text, ",", "") + ",1)"
                insert_transac("trans_daftar", columnsNameTrans, columnsValueTrans)

                last_id_daftar = getLastIdDaftar()


                For i As Integer = 0 To InputTransaksiPendaftaran.dtg_dftrDetail.Rows.Count - 1

                    Dim id_paket = InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(0).Value.ToString()
                    Dim harga_paket = Replace(Replace(InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(4).Value.ToString(), "Rp", ""), ",", "")
                    Dim qty_paket = InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(5).Value.ToString()
                    Dim subtotal_paket = Replace(Replace(InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(6).Value.ToString(), "Rp", ""), ",", "")

                    Dim columnsNameDetail As String = "(`id_daftar`,`id_paket`,`harga_paket`,`qty_paket`,`subtotal_paket`)"
                    Dim columnsValueDetail As String = "(" + last_id_daftar.ToString() + "," + id_paket.ToString() + "," + harga_paket.ToString() + "," + qty_paket.ToString() + "," + subtotal_paket.ToString() + ")"

                    insert_transac("trans_daftardetail", columnsNameDetail, columnsValueDetail)
                Next


                commit_transac()
                errmsg_sukses_simpan()
                Me.Close()
                InputTransaksiPendaftaran.Close()
                rpt = New Invoice

            Catch ex As Exception
                errmsg_gagal_simpan()
                rollback_transac()
            End Try
        End If
        If InputTransaksiPendaftaran.id_pelanggan > 0 Then
            begin_transac()
            Try
                Dim columnsNameTrans As String = "(`id_pelanggan`,`id_voucher`,`kode_member`,`tgl_trans`,`jenis_bayar`,`kartu`,`mesin`,`total_bruto`," +
                    "`diskonpersen_daftar`,`diskonnominal_daftar`,`total_neto`,`createdby`)"
                Dim columnsValueTrans As String = "('" + InputTransaksiPendaftaran.id_pelanggan.ToString + "','" + tb_kdvoucher.Text + "','" + InputTransaksiPendaftaran.tb_kdmember.Text + _
                    "','" + InputTransaksiPendaftaran.dtp_tgltr.Text + "','" + cmb_jenisbayar.Text + "','" + cmb_kartu.Text + "','" + cmb_mesin.Text + _
                    "'," + Replace(lbl_total.Text, ",", "") + "," + tb_diskpersen.Text + "," + Replace(tb_disknominal.Text, ",", "") + "," + Replace(lbl_grandtotal.Text, ",", "") + ",1)"
                insert_transac("trans_daftar", columnsNameTrans, columnsValueTrans)

                last_id_daftar = getLastIdDaftar()


                For i As Integer = 0 To InputTransaksiPendaftaran.dtg_dftrDetail.Rows.Count - 1

                    Dim id_paket = InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(0).Value.ToString()
                    Dim harga_paket = Replace(Replace(InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(4).Value.ToString(), "Rp", ""), ",", "")
                    Dim qty_paket = InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(5).Value.ToString()
                    Dim subtotal_paket = Replace(Replace(InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(6).Value.ToString(), "Rp", ""), ",", "")

                    Dim columnsNameDetail As String = "(`id_daftar`,`id_paket`,`harga_paket`,`qty_paket`,`subtotal_paket`)"
                    Dim columnsValueDetail As String = "(" + last_id_daftar.ToString() + "," + id_paket.ToString() + "," + harga_paket.ToString() + "," + qty_paket.ToString() + "," + subtotal_paket.ToString() + ")"

                    insert_transac("trans_daftardetail", columnsNameDetail, columnsValueDetail)
                Next

                commit_transac()
                errmsg_sukses_simpan()
                Me.Close()
                InputTransaksiPendaftaran.Close()
            Catch ex As Exception
                errmsg_gagal_simpan()
                rollback_transac()
            End Try
        End If
    End Sub

    Private Function getLastIdPelanggan()
        '----------------- MENGAMBIL ID PELANGGAN ---------------------- '

        isi_reader("select ifnull(max(id_pelanggan),0) as id_pelanggan from mst_pelanggan")
        If dr.HasRows Then
            dr.Read()
            last_id_pelanggan = dr("id_pelanggan")
        End If
        dr.Close()

        Return last_id_pelanggan
    End Function

    Private Function getLastIdDaftar()
        '----------------- MENGAMBIL ID PENDAFTARAN ---------------------- '

        isi_reader("select ifnull(max(id_daftar),0) as id_daftar from trans_daftar")
        If dr.HasRows Then
            dr.Read()
            last_id_daftar = dr("id_daftar")
        End If
        dr.Close()

        Return last_id_daftar
    End Function

    Private Sub InputBayarPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_total.Text = Format(hitung_total(), "##,##")
        tb_kdvoucher.Text = ""
        tb_diskpersen.Text = "0"
        tb_disknominal.Text = "0"
        cmb_jenisbayar.SelectedItem = "TUNAI"
        cmb_mesin.Text = ""
        cmb_kartu.Text = ""

        lbl_grandtotal.Text = Format(hitung_grandtotal(), "##,##")
        lbl_sisabayar.Text = "0"

    End Sub

    Private Function hitung_total()
        Dim total As Double = 0
        For i As Integer = 0 To InputTransaksiPendaftaran.dtg_dftrDetail.Rows.Count() - 1 Step 1
            Dim subtotal As Double = Replace(Replace(InputTransaksiPendaftaran.dtg_dftrDetail.Rows(i).Cells(6).Value, "Rp", ""), ",", "")
            total = total + subtotal
        Next

        Return total
    End Function

    Private Function hitung_grandtotal()
        Dim grandtotal As Double = 0
        Dim diskpersen As Integer = CInt(tb_diskpersen.Text)
        Dim disknominal As Double = CDbl(Replace(tb_disknominal.Text, ",", ""))
        If diskpersen > 0 Then
            grandtotal = hitung_total() - (hitung_total() * (diskpersen / 100))
        Else
            grandtotal = hitung_total()
        End If
        If tb_disknominal.Text > 0 Then
            grandtotal = hitung_total() - disknominal
        Else
            grandtotal = hitung_total()
        End If

        Return grandtotal
    End Function

    Private Function hitung_bayar()
        Dim grandtotal As Double = hitung_grandtotal()
        Dim sisa_bayar As Double = 0
        Dim str_bayar As String = tb_bayar.Text
        If str_bayar = "" Then
            str_bayar = 0
        End If
        Dim bayar As Double = CDbl(str_bayar)
        sisa_bayar = bayar - grandtotal

        Return sisa_bayar
    End Function

    Private Sub tb_bayar_TextChanged(sender As Object, e As EventArgs) Handles tb_bayar.TextChanged
        If Len(tb_bayar.Text) > 0 Then
            tb_bayar.Text = FormatNumber(CDbl(tb_bayar.Text), 0)
            Dim x As Integer = tb_bayar.SelectionStart.ToString
            If x = 0 Then
                tb_bayar.SelectionStart = Len(tb_bayar.Text)
                tb_bayar.SelectionLength = 0
            Else
                tb_bayar.SelectionStart = x
                tb_bayar.SelectionLength = 0
            End If
        End If
    End Sub

    Private Sub tb_bayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_bayar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                cekPembayaran()
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            cekPembayaran()
        End If
    End Sub

    Private Sub tb_bayar_Leave(sender As Object, e As EventArgs) Handles tb_bayar.Leave
        cekPembayaran()
    End Sub

    Private Sub cekPembayaran()
        If hitung_bayar() < 0 Then
            MsgBox("Nominal Pembayaran Kurang!!")
            lbl_sisabayar.Text = Format(hitung_bayar(), "##,##")
        ElseIf hitung_bayar() = 0 Then
            lbl_sisabayar.Text = "0"
        Else
            lbl_sisabayar.Text = Format(hitung_bayar(), "##,##")
        End If
    End Sub
End Class