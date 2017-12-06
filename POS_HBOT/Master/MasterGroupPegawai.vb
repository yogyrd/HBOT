Public Class MasterGroupPegawai
    Dim tbl As String = "mst_grouppegawai"
    Public id_grouppegawai As String

    Private Sub MasterGroupPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        buka_koneksi()
        queryMode = "insert"
        InputMasterGroupPegawai.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        id_grouppegawai = dtg_mstGroupPegawai.Item(0, dtg_mstGroupPegawai.CurrentRow.Index).Value
        buka_koneksi()
        queryMode = "update"
        InputMasterGroupPegawai.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        id_grouppegawai = dtg_mstGroupPegawai.Item(0, dtg_mstGroupPegawai.CurrentRow.Index).Value
        Dim dr As DialogResult = MessageBox.Show("Apa anda yakin untuk menghapus data? ", "Hapus Data", MessageBoxButtons.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            buka_koneksi()
            Dim kondisi As String = "id_group='" + id_grouppegawai + "'"
            delete_data(tbl, kondisi)
            MessageBox.Show("Data berhasil dihapus")
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
        FilterMasterGroupPegawai.ShowDialog()
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
        dtg_mstGroupPegawai.Rows.Clear()
        For i As Integer = 0 To ds.Tables(tbl).Rows.Count - 1
            dtg_mstGroupPegawai.Rows.Add(ds.Tables(tbl).Rows(i)("id_group").ToString(), ds.Tables(tbl).Rows(i)("kode_group").ToString(), _
                ds.Tables(tbl).Rows(i)("nama_group").ToString())
        Next
        ds.Tables.Clear()
    End Sub

    Private Sub filterTable()
        isi_dataset(tbl, "select * from " + tbl + " where kode_group like '%" + FilterMasterGroupPegawai.tb_kdgroup.Text + "%' and nama_group like '%" + FilterMasterGroupPegawai.tb_nmgroup.Text + "%'")
        dtg_mstGroupPegawai.Rows.Clear()
        For i As Integer = 0 To ds.Tables(tbl).Rows.Count - 1
            dtg_mstGroupPegawai.Rows.Add(ds.Tables(tbl).Rows(i)("id_group").ToString(), ds.Tables(tbl).Rows(i)("kode_group").ToString(), _
                                    ds.Tables(tbl).Rows(i)("nama_group").ToString())
        Next
        ds.Tables(tbl).Clear()
    End Sub

End Class