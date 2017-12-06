Public Class TransaksiTerapi
    Dim tbl As String = "trans_terapi"

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        buka_koneksi()
        InputTransaksiTerapi.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        FilterTransaksiTerapi.ShowDialog()
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub TransaksiTerapi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub loadTable()
        isi_dataset(tbl, "select * from trans_terapi a inner join trans_daftar b on a.id_daftar=b.id_daftar inner join mst_pelanggan c on b.id_pelanggan=c.id_pelanggan")
        dtg_transTerapi.Rows.Clear()
        For i As Integer = 0 To ds.Tables(tbl).Rows.Count - 1
            dtg_transTerapi.Rows.Add(ds.Tables(tbl).Rows(i)("id_daftar").ToString(), ds.Tables(tbl).Rows(i)("kode_daftar").ToString(), _
                ds.Tables(tbl).Rows(i)("nama_pelanggan").ToString(), ds.Tables(tbl).Rows(i)("nama_pasien").ToString(), _
                Format(ds.Tables(tbl).Rows(i)("tgl_terapi"), "yyyy-MMM-dd").ToString(), ds.Tables(tbl).Rows(i)("jam_terapi").ToString())
        Next
        ds.Tables.Clear()
    End Sub
End Class