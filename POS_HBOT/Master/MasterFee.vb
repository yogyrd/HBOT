Public Class MasterFee
    Dim tbl As String = "mst_grouppegawaidetail"
    Public id_pegawai, id_grouppegawai, fee As String
    Private Sub MasterFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        buka_koneksi()
        queryMode = "insert"
        InputMasterFee.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        id_grouppegawai = dtg_mstFee.Item(0, dtg_mstFee.CurrentRow.Index).Value
        id_pegawai = dtg_mstFee.Item(1, dtg_mstFee.CurrentRow.Index).Value
        fee = dtg_mstFee.Item(4, dtg_mstFee.CurrentRow.Index).Value
        buka_koneksi()
        queryMode = "update"
        InputMasterFee.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        id_grouppegawai = dtg_mstFee.Item(0, dtg_mstFee.CurrentRow.Index).Value
        id_pegawai = dtg_mstFee.Item(1, dtg_mstFee.CurrentRow.Index).Value
        Dim dr As DialogResult = MessageBox.Show("Apa anda yakin untuk menghapus data? ", "Hapus Data", MessageBoxButtons.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            buka_koneksi()
            Dim kondisi As String = "id_group='" + id_grouppegawai + "' and id_pegawai='" + id_pegawai + "'"
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
        FilterMasterFee.ShowDialog()
        filterTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub loadTable()
        Try
            'dtg_mstFee.Rows.Clear()
            isi_dataset(tbl, "select  a.id_group,a.id_pegawai,c.nama_group,b.nama_pegawai,a.fee from mst_grouppegawaidetail a inner join mst_pegawai b on a.id_pegawai=b.id_pegawai inner join mst_grouppegawai c on a.id_group=c.id_group")
            dtg_mstFee.DataSource = ds.Tables(tbl)
            loadDataGrid()
        Catch ex As Exception
            errmsg_gagal()
        End Try
        'For i As Integer = 0 To ds.Tables(tbl).Rows.Count - 1
        '    dtg_mstFee.Rows.Add(ds.Tables(tbl).Rows(i)("id_group").ToString(), ds.Tables(tbl).Rows(i)("id_pegawai").ToString(), _
        '        ds.Tables(tbl).Rows(i)("nama_group").ToString(), ds.Tables(tbl).Rows(i)("nama_pegawai").ToString(), ds.Tables(tbl).Rows(i)("fee").ToString())
        'Next
        ds.Tables.Clear()
    End Sub

    Private Sub filterTable()
        Try
            ds.Tables().Clear()
            isi_dataset(tbl, "select a.id_group,a.id_pegawai,b.nama_group,c.nama_pegawai,a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group inner join mst_pegawai c on a.id_pegawai=c.id_pegawai where b.nama_group like '%" + FilterMasterFee.tb_nmgroup.Text + "%' and c.nama_pegawai like '%" + FilterMasterFee.tb_nmpegawai.Text + "%' and a.fee like '%" + Replace(FilterMasterFee.tb_fee.Text, ",", "") + "%'")
            dtg_mstFee.DataSource = ds.Tables(tbl)
            loadDataGrid()
        Catch ex As Exception
            errmsg_gagal()
        End Try
        'dtg_mstFee.Rows.Clear()
        'For i As Integer = 0 To ds.Tables(tbl).Rows.Count - 1
        '    dtg_mstFee.Rows.Add(ds.Tables(tbl).Rows(i)("id_group").ToString(), ds.Tables(tbl).Rows(i)("id_pegawai").ToString(), _
        '        ds.Tables(tbl).Rows(i)("nama_group").ToString(), ds.Tables(tbl).Rows(i)("nama_pegawai").ToString(), ds.Tables(tbl).Rows(i)("fee").ToString())
        'Next
        ds.Tables.Clear()
    End Sub

    Private Sub loadDataGrid()
        dtg_mstFee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtg_mstFee.DefaultCellStyle.Font = New Font("Arial", 9.75)
        dtg_mstFee.AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 9.75)
        dtg_mstFee.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9.75, FontStyle.Bold)

        dtg_mstFee.Columns(0).Visible = False
        dtg_mstFee.Columns(1).Visible = False
        dtg_mstFee.Columns(2).HeaderText = "GROUP PEGAWAI"
        dtg_mstFee.Columns(3).HeaderText = "NAMA PEGAWAI"
        dtg_mstFee.Columns(4).HeaderText = "FEE"
        dtg_mstFee.Columns(4).DefaultCellStyle.Format = "Rp ###,###"
        dtg_mstFee.Columns(4).Width = 200
        dtg_mstFee.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

End Class