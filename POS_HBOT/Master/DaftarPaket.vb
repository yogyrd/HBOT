Public Class DaftarPaket
    Public batal As Boolean
    Public id_paket, kd_paket, nama_paket, member, hara_paket, ket_paket As String

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        batal = True
        Me.Close()
    End Sub

    Private Sub DaftarPaket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buka_koneksi()
        loadTable()
    End Sub

    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        batal = False
        selectItem()
        Me.Close()
    End Sub

    Private Sub dtg_mstPaket_DoubleClick(sender As Object, e As EventArgs) Handles dtg_mstPaket.DoubleClick
        batal = False
        selectItem()
        Me.Close()
    End Sub

    Private Sub loadTable()
        Try
            isi_dataset("mst_paket", "select * from mst_paket where member='" + InputTransaksiPendaftaran.member + "'")
            dtg_mstPaket.Rows.Clear()
            For i As Integer = 0 To ds.Tables("mst_paket").Rows.Count - 1
                dtg_mstPaket.Rows.Add(ds.Tables("mst_paket").Rows(i)("id_paket").ToString(), ds.Tables("mst_paket").Rows(i)("kode_paket").ToString(), _
                    ds.Tables("mst_paket").Rows(i)("nama_paket").ToString(), ds.Tables("mst_paket").Rows(i)("member").ToString(), _
                    Format(ds.Tables("mst_paket").Rows(i)("harga_paket_neto"), "Rp ###,###"), ds.Tables("mst_paket").Rows(i)("ket_paket").ToString())
            Next
        Catch ex As Exception
            errmsg_gagal()
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub selectItem()
        Dim selectedRowCount As Integer = dtg_mstPaket.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If selectedRowCount > 0 Then
            Dim i As Integer
            For i = 0 To selectedRowCount - 1
                id_paket = dtg_mstPaket.SelectedRows(0).Cells(0).Value.ToString
                kd_paket = dtg_mstPaket.SelectedRows(0).Cells(1).Value.ToString
                nama_paket = dtg_mstPaket.SelectedRows(0).Cells(2).Value.ToString
                member = dtg_mstPaket.SelectedRows(0).Cells(3).Value.ToString
                hara_paket = dtg_mstPaket.SelectedRows(0).Cells(4).Value.ToString
                ket_paket = dtg_mstPaket.SelectedRows(0).Cells(5).Value.ToString
            Next i
        End If
        Me.Close()
    End Sub

End Class