Public Class DaftarTindakan
    Public id_tindakan, nama_tindakan, ket_tindakan, harga_tindakan As String
    Public batal As Boolean = False


    Private Sub DaftarTindakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        batal = True
        Me.Close()
    End Sub

    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        batal = False
        selectItem()
        Me.Close()
    End Sub

    Private Sub loadTable()
        Try
            isi_dataset("mst_tindakan")
            dtg_mstTindakan.DataSource = ds.Tables("mst_tindakan")
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
        dtg_mstTindakan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtg_mstTindakan.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub dtg_mstTindakan_DoubleClick(sender As Object, e As EventArgs) Handles dtg_mstTindakan.DoubleClick
        batal = False
        selectItem()
        Me.Close()
    End Sub

    Private Sub selectItem()
        Dim hrg As Double
        Dim selectedRowCount As Integer = dtg_mstTindakan.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If selectedRowCount > 0 Then
            Dim i As Integer
            For i = 0 To selectedRowCount - 1
                id_tindakan = dtg_mstTindakan.SelectedRows(0).Cells(0).Value.ToString
                nama_tindakan = dtg_mstTindakan.SelectedRows(0).Cells(1).Value.ToString
                ket_tindakan = dtg_mstTindakan.SelectedRows(0).Cells(2).Value.ToString
                hrg = Convert.ToDouble(dtg_mstTindakan.SelectedRows(0).Cells(3).Value.ToString)
                harga_tindakan = Format(hrg, "Rp ###,###")
            Next i
        End If
        Me.Close()
    End Sub
End Class