Public Class MasterPegawai
    Dim tbl As String = "mst_pegawai"
    Public id_pegawai As String

    Private Sub MasterPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        buka_koneksi()
        queryMode = "insert"
        InputMasterPegawai.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        id_pegawai = dtg_mstPegawai.Item(0, dtg_mstPegawai.CurrentRow.Index).Value
        buka_koneksi()
        queryMode = "update"
        InputMasterPegawai.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        id_pegawai = dtg_mstPegawai.Item(0, dtg_mstPegawai.CurrentRow.Index).Value
        Dim dr As DialogResult = MessageBox.Show("Apa anda yakin untuk menghapus data? ", "Hapus Data", MessageBoxButtons.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            buka_koneksi()
            Dim kondisi As String = "id_pegawai='" + id_pegawai + "'"
            delete_data(tbl, kondisi)
            errmsg_sukses_hapus()
            loadTable()
            tutup_koneksi()
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        buka_koneksi()
        FilterMasterPegawai.ShowDialog()
        filterTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub loadTable()
        isi_dataset(tbl)
        dtg_mstPegawai.Rows.Clear()
        For i As Integer = 0 To ds.Tables(tbl).Rows.Count - 1
            dtg_mstPegawai.Rows.Add(ds.Tables(tbl).Rows(i)("id_pegawai").ToString(), ds.Tables(tbl).Rows(i)("kode_pegawai").ToString(), _
                ds.Tables(tbl).Rows(i)("nama_pegawai").ToString(), ds.Tables(tbl).Rows(i)("username").ToString())
        Next
        ds.Tables.Clear()
    End Sub

    Private Sub filterTable()
        isi_dataset(tbl, "select * from " + tbl + " where username like '%" + FilterMasterPegawai.tb_username.Text + "%' and nama_pegawai like '%" + _
                    FilterMasterPegawai.tb_nmpegawai.Text + "%' and kode_pegawai like '%" + FilterMasterPegawai.tb_kdpegawai.Text + "%'")
        dtg_mstPegawai.Rows.Clear()
        For i As Integer = 0 To ds.Tables(tbl).Rows.Count - 1
            dtg_mstPegawai.Rows.Add(ds.Tables(tbl).Rows(i)("id_pegawai").ToString(), ds.Tables(tbl).Rows(i)("kode_pegawai").ToString(), _
                                    ds.Tables(tbl).Rows(i)("nama_pegawai").ToString(), ds.Tables(tbl).Rows(i)("username").ToString())
        Next
        ds.Tables(tbl).Clear()
    End Sub
End Class