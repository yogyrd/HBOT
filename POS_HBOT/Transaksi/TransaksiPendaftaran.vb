Public Class TransaksiPendaftaran
    Dim tbl As String = "trans_daftar"

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        buka_koneksi()
        InputTransaksiPendaftaran.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        buka_koneksi()
        FilterTransaksiPendaftaran.ShowDialog()
        'filterTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub TransaksiPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub loadTable()
        isi_dataset(tbl, "select * " + _
            "from trans_daftar a inner join mst_pelanggan b on a.id_pelanggan=b.id_pelanggan " + _
            "left join mst_voucher c on a.id_voucher=c.id_voucher " + _
            "order by id_daftar asc")
        dtg_transDaftar.Rows.Clear()
        For i As Integer = 0 To ds.Tables(tbl).Rows.Count - 1
            dtg_transDaftar.Rows.Add(ds.Tables(tbl).Rows(i)("kode_daftar").ToString(), ds.Tables(tbl).Rows(i)("nama_pelanggan").ToString(), _
                ds.Tables(tbl).Rows(i)("member_pelanggan").ToString(), Format(ds.Tables(tbl).Rows(i)("tgl_trans"), "yyyy-MMM-dd").ToString(), ds.Tables(tbl).Rows(i)("jenis_bayar").ToString(), _
                Format(ds.Tables(tbl).Rows(i)("total_bruto"), "Rp ##,##").ToString(), Format(ds.Tables(tbl).Rows(i)("diskonpersen_daftar"), "## %").ToString(), Format(ds.Tables(tbl).Rows(i)("diskonnominal_daftar"), "Rp ##,##").ToString(), _
                Format(ds.Tables(tbl).Rows(i)("total_neto"), "Rp ##,##").ToString())
        Next
        ds.Tables.Clear()
    End Sub
End Class