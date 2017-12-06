Public Class MasterPaket
    Dim tbl As String = "mst_paket"
    Dim tbl_dtl As String = "mst_paketdetail"
    Public id_paket As String

    Private Sub MasterPaket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        buka_koneksi()
        queryMode = "insert"
        InputMasterPaket.ShowDialog()
        loadTable()
        tutup_koneksi()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If dtg_mstPaket.SelectedRows.Count > 0 Then
            id_paket = dtg_mstPaket.Item(0, dtg_mstPaket.CurrentRow.Index).Value
            buka_koneksi()
            queryMode = "update"
            InputMasterPaket.ShowDialog()
            loadTable()
            tutup_koneksi()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If dtg_mstPaket.SelectedRows.Count > 0 Then
            buka_koneksi()
            id_paket = dtg_mstPaket.Item(0, dtg_mstPaket.CurrentRow.Index).Value
            Dim dr As DialogResult = MessageBox.Show("Apa anda yakin untuk menghapus data? ", "Hapus Data", MessageBoxButtons.YesNo)
            If dr = Windows.Forms.DialogResult.Yes Then
                begin_transac()
                Try
                    Dim kondisi As String = "id_paket='" + id_paket + "'"
                    delete_transac(tbl, kondisi)
                    delete_transac(tbl_dtl, kondisi)
                    commit_transac()
                    errmsg_sukses_hapus()
                Catch ex As Exception
                    rollback_transac()
                    errmsg_gagal_hapus()
                End Try
            End If
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
        FilterMasterPaket.ShowDialog()
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
            dtg_mstPaket.DataSource = ds.Tables(tbl)
            loadDataGrid()
        Catch ex As Exception
            errmsg_gagal()
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub filterTable()
        'MsgBox("select * from mst_paket where kode_paket like '%" + FilterMasterPaket.tb_kdpaket.Text + "%' and nama_paket like '%" + FilterMasterPaket.tb_nmpaket.Text + "%' and member like '%" + FilterMasterPaket.cmb_member.SelectedText + "%' and paket_mulai like '%" + FilterMasterPaket.dtp_awal.Text + "%' and paket_akhir like '%" + FilterMasterPaket.dtp_akhir.Text + "%'")
        Try
            ds.Tables().Clear()
            isi_dataset(tbl, "select * from mst_paket where kode_paket like '%" + FilterMasterPaket.tb_kdpaket.Text + "%' and nama_paket like '%" + FilterMasterPaket.tb_nmpaket.Text + "%' and member like '%" + FilterMasterPaket.cmb_member.SelectedItem + "%'")
            dtg_mstPaket.DataSource = ds.Tables(tbl)
            loadDataGrid()
        Catch ex As Exception
            errmsg_gagal()
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub loadDataGrid()
        dtg_mstPaket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtg_mstPaket.DefaultCellStyle.Font = New Font("Arial", 9.75)
        dtg_mstPaket.AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 9.75)
        dtg_mstPaket.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9.75, FontStyle.Bold)

        dtg_mstPaket.Columns(0).Visible = False
        dtg_mstPaket.Columns(1).HeaderText = "KODE PAKET"
        dtg_mstPaket.Columns(2).HeaderText = "NAMA PAKET"
        dtg_mstPaket.Columns(3).Visible = False
        dtg_mstPaket.Columns(4).HeaderText = "HARGA PAKET SEBELUM DISKON"
        dtg_mstPaket.Columns(5).HeaderText = "DISKON PROSENTASE"
        dtg_mstPaket.Columns(6).HeaderText = "DISKON NOMINAL"
        dtg_mstPaket.Columns(7).HeaderText = "HARGA PAKET SETELAH DISKON"
        dtg_mstPaket.Columns(8).Visible = False
        dtg_mstPaket.Columns(9).Visible = False
        dtg_mstPaket.Columns(10).HeaderText = "KETERANGAN PAKET"
        dtg_mstPaket.Columns(11).Visible = False
        dtg_mstPaket.Columns(12).Visible = False
        dtg_mstPaket.Columns(13).Visible = False
        dtg_mstPaket.Columns(14).Visible = False
        dtg_mstPaket.Columns(15).Visible = False
        dtg_mstPaket.Columns(16).Visible = False

        dtg_mstPaket.Columns(4).DefaultCellStyle.Format = "Rp ###,##0"
        dtg_mstPaket.Columns(4).Width = 200
        dtg_mstPaket.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dtg_mstPaket.Columns(5).DefaultCellStyle.Format = "#,##0'%'"
        dtg_mstPaket.Columns(5).Width = 100
        dtg_mstPaket.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dtg_mstPaket.Columns(6).DefaultCellStyle.Format = "Rp ###,##0"
        dtg_mstPaket.Columns(6).Width = 150
        dtg_mstPaket.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dtg_mstPaket.Columns(7).DefaultCellStyle.Format = "Rp ###,##0"
        dtg_mstPaket.Columns(7).Width = 200
        dtg_mstPaket.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub


    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        If dtg_mstPaket.SelectedRows.Count > 0 Then
            id_paket = dtg_mstPaket.Item(0, dtg_mstPaket.CurrentRow.Index).Value
            buka_koneksi()
            queryMode = "view"
            InputMasterPaket.ShowDialog()
            loadTable()
            tutup_koneksi()
        End If
    End Sub
End Class