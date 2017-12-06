Public Class MasterVoucher
    Dim tbl As String = "mst_voucher"
    Public id_voucher As String
    Dim sql As String

    Private Sub MasterVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
        tutup_koneksi()
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        buka_koneksi()
        queryMode = "insert"
        InputMasterVoucher.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        id_voucher = dtg_mstVoucher.Item(0, dtg_mstVoucher.CurrentRow.Index).Value
        buka_koneksi()
        queryMode = "update"
        InputMasterVoucher.ShowDialog()
        loadTable()
        tutup_koneksi()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        id_voucher = dtg_mstVoucher.Item(0, dtg_mstVoucher.CurrentRow.Index).Value
        Dim dr As DialogResult = MessageBox.Show("Apa anda yakin untuk menghapus data? ", "Hapus Data", MessageBoxButtons.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            buka_koneksi()
            Dim kondisi As String = "id_voucher='" + id_voucher + "'"
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
        FilterMasterVoucher.ShowDialog()
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
            isi_dataset(tbl, "select id_voucher,kode_voucher,ket_voucher,diskon_prosentase,diskon_nominal, mulai_voucher,akhir_voucher,if(status_voucher=1,'Aktif','Tidak Aktif') as status_voucher from mst_voucher")
            dtg_mstVoucher.DataSource = ds.Tables(tbl)
            loadDataGrid()
        Catch ex As Exception
            errmsg_gagal()
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub filterTable()
        Dim awalvoucher As String = FilterMasterVoucher.dtp_awal.Text
        Dim akhirvoucher As String = FilterMasterVoucher.dtp_akhir.Text
        If awalvoucher = "" Or akhirvoucher = "" Then
            sql = "select id_voucher,kode_voucher,ket_voucher,diskon_prosentase,diskon_nominal, mulai_voucher,akhir_voucher,if(status_voucher=1,'Aktif','Tidak Aktif') as status_voucher " + _
                        "from mst_voucher " + _
                        "where kode_voucher like '%" + FilterMasterVoucher.tb_kodeVoucher.Text + "%' and status_voucher like '%" + FilterMasterVoucher.cmb_status.SelectedValue + "%' " + _
                        "and ket_voucher like '%" + FilterMasterVoucher.tb_ket.Text + "%' and diskon_prosentase like '%" + FilterMasterVoucher.tb_diskonProsentase.Text + "%' and diskon_nominal like '%" + Replace(FilterMasterVoucher.tb_diskonNominal.Text, ",", "") + "%' " + _
                        "and mulai_voucher like '%" + FilterMasterVoucher.dtp_awal.Text + "%' and akhir_voucher like '%" + FilterMasterVoucher.dtp_akhir.Text + "%'"
        Else
            sql = "select id_voucher,kode_voucher,ket_voucher,diskon_prosentase,diskon_nominal, mulai_voucher,akhir_voucher,if(status_voucher=1,'Aktif','Tidak Aktif') as status_voucher " + _
                        "from mst_voucher " + _
                        "where kode_voucher like '%" + FilterMasterVoucher.tb_kodeVoucher.Text + "%' and status_voucher like '%" + FilterMasterVoucher.cmb_status.SelectedValue + "%' " + _
                        "and ket_voucher like '%" + FilterMasterVoucher.tb_ket.Text + "%' and diskon_prosentase like '%" + FilterMasterVoucher.tb_diskonProsentase.Text + "%' and diskon_nominal like '%" + Replace(FilterMasterVoucher.tb_diskonNominal.Text, ",", "") + "%'"
        End If
        Try
            ds.Tables().Clear()
            isi_dataset(tbl, sql)
            dtg_mstVoucher.DataSource = ds.Tables(tbl)
            loadDataGrid()
        Catch ex As Exception
            errmsg_gagal()
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub loadDataGrid()
        dtg_mstVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtg_mstVoucher.DefaultCellStyle.Font = New Font("Arial", 9.75)
        dtg_mstVoucher.AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 9.75)
        dtg_mstVoucher.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9.75, FontStyle.Bold)

        dtg_mstVoucher.Columns(0).Visible = False
        dtg_mstVoucher.Columns(1).HeaderText = "KODE VOUCHER"
        dtg_mstVoucher.Columns(2).HeaderText = "KETERANGAN"
        dtg_mstVoucher.Columns(3).HeaderText = "DISKON PROSENTASE"
        dtg_mstVoucher.Columns(4).HeaderText = "DISKON NOMINAL"
        dtg_mstVoucher.Columns(5).HeaderText = "VOUCHER MULAI"
        dtg_mstVoucher.Columns(6).HeaderText = "VOUCHER BERAKHIR"
        dtg_mstVoucher.Columns(7).HeaderText = "STATUS"
        dtg_mstVoucher.Columns(4).DefaultCellStyle.Format = "Rp ###,##0"
        dtg_mstVoucher.Columns(4).Width = 200
        dtg_mstVoucher.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtg_mstVoucher.Columns(3).DefaultCellStyle.Format = "#,##0'%'"
        dtg_mstVoucher.Columns(3).Width = 150
        dtg_mstVoucher.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtg_mstVoucher.Columns(5).DefaultCellStyle.Format = "yyyy'-'MMMM'-'dd"
        dtg_mstVoucher.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtg_mstVoucher.Columns(6).DefaultCellStyle.Format = "yyyy'-'MMMM'-'dd"
        dtg_mstVoucher.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

End Class