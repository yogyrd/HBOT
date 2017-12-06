Imports System.Text
Imports System.Windows.Forms
Public Class InputMasterPaket
    Dim tbl As String = "mst_paket"
    Dim diskonpersen As Double
    Dim diskonnominal As Double
    Dim harga_akhir As Double
    Dim new_id_paket As Integer

    Private Sub InputMasterPaket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
        If queryMode = "update" Then
            loadDataPaketByID()
        ElseIf queryMode = "view" Then
            loadDataPaketByID()
            btn_save.Visible = False
            pnl_detailButton.Visible = False
            tb_nmpaket.ReadOnly = True
            cmb_member.Enabled = False
            tb_ket.ReadOnly = True
            dtp_awal.Enabled = False
            dtp_akhir.Enabled = False
            dtg_paketDetail.Enabled = False
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        DaftarTindakan.ShowDialog()
        If DaftarTindakan.batal = False Then
            Dim rowAlreadyExist As Boolean = False
            If DaftarTindakan.id_tindakan > 0 Then
                For i As Integer = 0 To dtg_paketDetail.Rows.Count() - 1 Step 1
                    If dtg_paketDetail.Rows(i).Cells(0).Value = DaftarTindakan.id_tindakan Then
                        rowAlreadyExist = True
                        MsgBox("Detail Sudah Tersedia, Tidak Bisa Ditambahkan Lagi!!")
                        Exit For
                    End If
                Next
                If rowAlreadyExist = False Then
                    dtg_paketDetail.Rows.Add(DaftarTindakan.id_tindakan, DaftarTindakan.nama_tindakan, DaftarTindakan.ket_tindakan, DaftarTindakan.harga_tindakan)
                End If
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        For Each row As DataGridViewRow In dtg_paketDetail.SelectedRows
            dtg_paketDetail.Rows.Remove(row)
        Next
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        tutup_koneksi()
        buka_koneksi()
        begin_transac()
        If queryMode = "insert" Then
            Try
                Dim columnsName As String = "(`nama_paket`,`member`,`harga_paket_bruto`,`diskon_prosentase_paket`,`diskon_nominal_paket`,`harga_paket_neto`,`paket_mulai`,`paket_akhir`,`ket_paket`,`createdby`)"
                Dim columnsValue As String = "('" + tb_nmpaket.Text + "','" + cmb_member.SelectedItem + "'," + Replace(tb_hargaawal.Text, ",", "") + _
                    "," + tb_diskonpersen.Text + "," + Replace(tb_diskonnominal.Text, ",", "") + "," + Replace(tb_hargaakhir.Text, ",", "") + ",'" + dtp_awal.Text + "','" + dtp_akhir.Text + "','" + tb_ket.Text + "'," + "1)"

                insert_transac(tbl, columnsName, columnsValue)

                'Untuk mengambil id Paket Header
                Dim id_paket_header As Integer = getIdHeader()

                If dtg_paketDetail.Rows.Count > 0 Then
                    For i As Integer = 0 To dtg_paketDetail.Rows.Count - 1

                        Dim id_tindakan = dtg_paketDetail.Rows(i).Cells(0).Value.ToString()
                        Dim harga_tindakan = Replace(Replace(dtg_paketDetail.Rows(i).Cells(3).Value.ToString(), "Rp", ""), ",", "")
                        Dim qty_tindakan = dtg_paketDetail.Rows(i).Cells(4).Value.ToString()
                        Dim subtotal_tindakan = Replace(Replace(dtg_paketDetail.Rows(i).Cells(5).Value.ToString(), "Rp", ""), ",", "")

                        Dim columnsNameDetail As String = "(`id_paket`,`id_tindakan`,`harga_tindakan`,`qty_tindakan`,`subtotal_tindakan`)"
                        Dim columnsValueDetail As String = "(" + id_paket_header.ToString() + "," + id_tindakan.ToString() + "," + harga_tindakan.ToString() + "," + qty_tindakan.ToString() + "," + subtotal_tindakan.ToString() + ")"

                        insert_transac("mst_paketdetail", columnsNameDetail, columnsValueDetail)
                        
                    Next
                Else
                    errmsg_gagal_simpan()
                End If
                commit_transac()
                errmsg_sukses_simpan()
                clearForm()
            Catch ex As Exception
                rollback_transac()
                errmsg_gagal_simpan()
            End Try
        ElseIf queryMode = "update" Then
            Try
                Dim updateQuery As String = "nama_paket='" + tb_nmpaket.Text + "', member='" + cmb_member.SelectedItem + "', harga_paket_bruto=" + Replace(tb_hargaawal.Text, ",", "") + _
                ",diskon_prosentase_paket=" + Replace(tb_diskonnominal.Text, ",", "") + ",diskon_nominal_paket=" + Replace(tb_diskonnominal.Text, ",", "") + _
                ",harga_paket_neto=" + Replace(tb_hargaakhir.Text, ",", "") + ",paket_mulai='" + dtp_awal.Text + "',paket_akhir='," + dtp_akhir.Text + _
                "',ket_paket='" + tb_ket.Text + "',updatedby=" + "1" + _
                ",updateddate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'"
                Dim kondisi As String = "id_paket=" + MasterPaket.id_paket
                update_transac(tbl, updateQuery, kondisi)

                delete_transac("mst_paketdetail", kondisi)

                If dtg_paketDetail.Rows.Count > 0 Then
                    For i As Integer = 0 To dtg_paketDetail.Rows.Count - 1

                        Dim id_tindakan = dtg_paketDetail.Rows(i).Cells(0).Value.ToString()
                        Dim harga_tindakan = Replace(Replace(dtg_paketDetail.Rows(i).Cells(3).Value.ToString(), "Rp", ""), ",", "")
                        Dim qty_tindakan = dtg_paketDetail.Rows(i).Cells(4).Value.ToString()
                        Dim subtotal_tindakan = Replace(Replace(dtg_paketDetail.Rows(i).Cells(5).Value.ToString(), "Rp", ""), ",", "")

                        Dim columnsNameDetail As String = "(`id_paket`,`id_tindakan`,`harga_tindakan`,`qty_tindakan`,`subtotal_tindakan`)"
                        Dim columnsValueDetail As String = "(" + MasterPaket.id_paket + "," + id_tindakan.ToString() + "," + harga_tindakan.ToString() + "," + qty_tindakan.ToString() + "," + subtotal_tindakan.ToString() + ")"

                        insert_transac("mst_paketdetail", columnsNameDetail, columnsValueDetail)
                    Next
                Else
                    errmsg_gagal_simpan()
                End If
                commit_transac()
                errmsg_sukses_ubah()
                Me.Close()
            Catch ex As Exception
                rollback_transac()
                errmsg_gagal_simpan()
            End Try
        End If
    End Sub

    Private Function getIdHeader()
        '----------------- MENGAMBIL ID PAKET HEADER UNTUK MASTER PAKET DETAIL---------------------- '

        isi_reader("select ifnull(max(id_paket),0) as id_paket from mst_paket")
        If dr.HasRows Then
            dr.Read()
            new_id_paket = dr("id_paket")
        End If
        dr.Close()

        Return new_id_paket
    End Function

    Private Sub clearForm()
        tb_kdpaket.Text = ""
        tb_nmpaket.Text = ""
        cmb_member.SelectedText = ""
        tb_ket.Text = ""
        tb_hargaawal.Text = 0
        tb_hargaakhir.Text = 0
        tb_diskonpersen.Text = 0
        tb_diskonnominal.Text = 0
        dtg_paketDetail.Rows.Clear()
        dtp_awal.Text = Format(Now, ("yyyy-MM-dd"))
        dtp_akhir.Text = "9998-12-31"
    End Sub

    Private Sub loadDataPaketByID()
        Try
            load_data_by_id(tbl, "id_paket", MasterPaket.id_paket)
            If dr.HasRows Then
                dr.Read()
                tb_kdpaket.Text = dr("kode_paket")
                tb_nmpaket.Text = dr("nama_paket")
                cmb_member.SelectedItem = dr("member")
                tb_ket.Text = dr("ket_paket")
                tb_hargaawal.Text = dr("harga_paket_bruto")
                dtp_awal.Text = dr("paket_mulai")
                dtp_akhir.Text = dr("paket_akhir")
                tb_hargaakhir.Text = dr("harga_paket_neto")
                If dr("diskon_prosentase_paket") > 0 Then
                    tb_diskonpersen.Text = dr("diskon_prosentase_paket")
                    rb_diskonprosentase.Checked = True
                End If
                If dr("diskon_nominal_paket") > 0 Then
                    tb_diskonnominal.Text = dr("diskon_nominal_paket")
                    rb_diskonnominal.Checked = True
                End If
            End If
            dr.Close()
            isi_dataset("mst_paketdetail", "select a.*,b.nama_tindakan,b.keterangan from mst_paketdetail a inner join mst_tindakan b on a.id_tindakan=b.id_tindakan where id_paket=" + MasterPaket.id_paket)
            dtg_paketDetail.Rows.Clear()
            For i As Integer = 0 To ds.Tables("mst_paketdetail").Rows.Count - 1
                dtg_paketDetail.Rows.Add(ds.Tables("mst_paketdetail").Rows(i)("id_tindakan").ToString(), _
                                        ds.Tables("mst_paketdetail").Rows(i)("nama_tindakan").ToString(), ds.Tables("mst_paketdetail").Rows(i)("keterangan").ToString(), _
                                        Format(ds.Tables("mst_paketdetail").Rows(i)("harga_tindakan"), "Rp ###,###"), ds.Tables("mst_paketdetail").Rows(i)("qty_tindakan").ToString(), _
                                        Format(ds.Tables("mst_paketdetail").Rows(i)("subtotal_tindakan"), "Rp ###,###"), ds.Tables("mst_paketdetail").Rows(i)("id_paket").ToString())
            Next
            ds.Tables("mst_paketdetail").Clear()
        Catch ex As Exception
            errmsg_gagal()
        End Try
    End Sub


    Private Function hitung_totaldetail()
        Dim total As Double = 0
        For i As Integer = 0 To dtg_paketDetail.Rows.Count() - 1 Step 1
            Dim subtotal As Double = Replace(Replace(dtg_paketDetail.Rows(i).Cells(5).Value, "Rp", ""), ",", "")
            total = total + subtotal
        Next

        Return total

    End Function

    Private Function hitung_discpersen()
        If tb_diskonpersen.Text = "" Then
            diskonpersen = 0
        Else
            diskonpersen = Convert.ToInt32(tb_diskonpersen.Text)
        End If
        Dim total As Double = 0
        total = Double.Parse(hitung_totaldetail())
        Dim harga_diskon As Double = total - (total * diskonpersen / 100)

        Return harga_diskon

    End Function

    Private Function hitung_discnominal()
        If tb_diskonnominal.Text = "" Then
            diskonnominal = 0
        Else
            diskonnominal = Convert.ToDouble(tb_diskonnominal.Text)
        End If
        Dim total As Double = 0
        total = Double.Parse(hitung_totaldetail())
        Dim harga_diskon As Double = total - diskonnominal

        Return harga_diskon

    End Function

    Private Function hitung_hargaakhir()
        If tb_diskonpersen.ReadOnly = False And tb_diskonnominal.ReadOnly = True Then
            harga_akhir = hitung_discpersen()
        ElseIf tb_diskonnominal.ReadOnly = False And tb_diskonpersen.ReadOnly = True Then
            harga_akhir = hitung_discnominal()
        End If
        Return harga_akhir
    End Function


    Private Sub tb_hargaawal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_hargaawal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tb_hargaawal_TextChanged(sender As Object, e As EventArgs) Handles tb_hargaawal.TextChanged
        If Len(tb_hargaawal.Text) > 0 Then
            tb_hargaawal.Text = FormatNumber(CDbl(tb_hargaawal.Text), 0)
            Dim x As Integer = tb_hargaawal.SelectionStart.ToString
            If x = 0 Then
                tb_hargaawal.SelectionStart = Len(tb_hargaawal.Text)
                tb_hargaawal.SelectionLength = 0
            Else
                tb_hargaawal.SelectionStart = x
                tb_hargaawal.SelectionLength = 0
            End If
        End If
        If tb_diskonpersen.Text <> 0 Then
            hitung_discpersen()
        End If
        If tb_diskonnominal.Text <> 0 Then
            hitung_discnominal()
        End If
    End Sub

    Private Sub tb_diskonpersen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_diskonpersen.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            dtp_awal.Focus()
        End If
    End Sub

    Private Sub tb_diskonnominal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_diskonnominal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            dtp_awal.Focus()
        End If
    End Sub

    Private Sub tb_diskonnominal_TextChanged(sender As Object, e As EventArgs) Handles tb_diskonnominal.TextChanged
        If Len(tb_diskonnominal.Text) > 0 Then
            tb_diskonnominal.Text = FormatNumber(CDbl(tb_diskonnominal.Text), 0)
            Dim x As Integer = tb_diskonnominal.SelectionStart.ToString
            If x = 0 Then
                tb_diskonnominal.SelectionStart = Len(tb_diskonnominal.Text)
                tb_diskonnominal.SelectionLength = 0
            Else
                tb_diskonnominal.SelectionStart = x
                tb_diskonnominal.SelectionLength = 0
            End If
        End If
    End Sub

    Private Sub dtg_paketDetail_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dtg_paketDetail.EditingControlShowing
        If dtg_paketDetail.CurrentCell.ColumnIndex = 4 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If

    End Sub

    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dtg_paketDetail_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_paketDetail.CellEndEdit
        Select Case e.ColumnIndex
            Case 4
                If dtg_paketDetail.Item(4, e.RowIndex).Value <> "" Then
                    Dim jml As Integer = dtg_paketDetail.Item(4, e.RowIndex).Value
                    Dim hrg_str As String = Replace(Replace(dtg_paketDetail.Item(3, e.RowIndex).Value, "Rp", ""), ",", "")
                    Dim hrg As Double = hrg_str
                    Dim subtotal As Double = hrg * jml
                    dtg_paketDetail.Item(5, e.RowIndex).Value = Format(subtotal, "Rp ###,###")
                    tb_hargaawal.Text = hitung_totaldetail()
                    If tb_diskonnominal.Text = "0" And tb_diskonpersen.Text = "0" Then
                        tb_hargaakhir.Text = tb_hargaawal.Text
                    End If
                End If
        End Select
    End Sub

    Private Sub dtg_paketDetail_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtg_paketDetail.RowsRemoved
        tb_hargaawal.Text = hitung_totaldetail()
        If tb_diskonnominal.Text = "0" And tb_diskonpersen.Text = "0" Then
            tb_hargaakhir.Text = tb_hargaawal.Text
        End If
    End Sub

    Private Sub rb_diskonprosentase_CheckedChanged(sender As Object, e As EventArgs) Handles rb_diskonprosentase.CheckedChanged
        tb_diskonpersen.ReadOnly = False
        tb_diskonnominal.ReadOnly = True
        tb_diskonnominal.Text = 0
        tb_hargaakhir.Text = Format(hitung_hargaakhir(), "##,##0")
    End Sub

    Private Sub rb_diskonnominal_CheckedChanged(sender As Object, e As EventArgs) Handles rb_diskonnominal.CheckedChanged
        tb_diskonpersen.ReadOnly = True
        tb_diskonnominal.ReadOnly = False
        tb_diskonpersen.Text = 0
        tb_hargaakhir.Text = Format(hitung_hargaakhir(), "##,##0")
    End Sub

    Private Sub tb_diskonnominal_Leave(sender As Object, e As EventArgs) Handles tb_diskonnominal.Leave
        tb_hargaakhir.Text = Format(hitung_hargaakhir(), "##,##0")
    End Sub

    Private Sub tb_diskonpersen_Leave(sender As Object, e As EventArgs) Handles tb_diskonpersen.Leave
        tb_hargaakhir.Text = Format(hitung_hargaakhir(), "##,##0")
    End Sub

    Private Sub tb_nmpaket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nmpaket.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmb_member.Focus()
        End If
    End Sub

    Private Sub tb_hargaakhir_TextChanged(sender As Object, e As EventArgs) Handles tb_hargaakhir.TextChanged
        If Len(tb_hargaakhir.Text) > 0 Then
            tb_hargaakhir.Text = FormatNumber(CDbl(tb_hargaakhir.Text), 0)
            Dim x As Integer = tb_hargaakhir.SelectionStart.ToString
            If x = 0 Then
                tb_hargaakhir.SelectionStart = Len(tb_hargaakhir.Text)
                tb_hargaakhir.SelectionLength = 0
            Else
                tb_hargaakhir.SelectionStart = x
                tb_hargaakhir.SelectionLength = 0
            End If
        End If
    End Sub
End Class