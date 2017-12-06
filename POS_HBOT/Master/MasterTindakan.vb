Public Class MasterTindakan
    Dim tbl As String = "mst_tindakan"
    Public id_tindakan As String

    Private Sub MasterTindakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        buka_koneksi()
        queryMode = "insert"
        InputMasterTindakan.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        id_tindakan = dtg_mstTindakan.Item(0, dtg_mstTindakan.CurrentRow.Index).Value
        buka_koneksi()
        queryMode = "update"
        InputMasterTindakan.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        id_tindakan = dtg_mstTindakan.Item(0, dtg_mstTindakan.CurrentRow.Index).Value
        Dim dr As DialogResult = MessageBox.Show("Apa anda yakin untuk menghapus data? ", "Hapus Data", MessageBoxButtons.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            buka_koneksi()
            Dim kondisi As String = "id_tindakan='" + id_tindakan + "'"
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
        FilterMasterTindakan.ShowDialog()
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
            isi_dataset(tbl)
            dtg_mstTindakan.DataSource = ds.Tables(tbl)
            loadDataGrid()
        Catch ex As Exception
            errmsg_gagal()
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub filterTable()
        Try
            ds.Tables().Clear()
            isi_dataset(tbl, "select * from mst_tindakan where nama_tindakan like '%" + FilterMasterTindakan.tb_nmtindakan.Text + "%' and keterangan like '%" + FilterMasterTindakan.tb_ket.Text + "%' and harga_tindakan like '%" + Replace(FilterMasterTindakan.tb_harga.Text, ",", "") + "%'")
            dtg_mstTindakan.DataSource = ds.Tables(tbl)
            loadDataGrid()
        Catch ex As Exception
            errmsg_gagal()
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub loadDataGrid()
        dtg_mstTindakan.Columns(0).Visible = False
        dtg_mstTindakan.Columns(4).Visible = False
        dtg_mstTindakan.Columns(5).Visible = False
        dtg_mstTindakan.Columns(6).Visible = False
        dtg_mstTindakan.Columns(7).Visible = False
        dtg_mstTindakan.Columns(8).Visible = False
        dtg_mstTindakan.Columns(9).Visible = False
        dtg_mstTindakan.Columns(1).HeaderText = "NAMA TINDAKAN"
        dtg_mstTindakan.Columns(3).HeaderText = "HARGA PER TINDAKAN"
        dtg_mstTindakan.Columns(2).HeaderText = "KETERANGAN"
        dtg_mstTindakan.Columns(3).DefaultCellStyle.Format = "Rp ###,###"
        dtg_mstTindakan.Columns(3).Width = 200
        dtg_mstTindakan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtg_mstTindakan.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtg_mstTindakan.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9.75, FontStyle.Bold)
        dtg_mstTindakan.DefaultCellStyle.Font = New Font("Arial", 9.75)
        dtg_mstTindakan.AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 9.75)
    End Sub

End Class