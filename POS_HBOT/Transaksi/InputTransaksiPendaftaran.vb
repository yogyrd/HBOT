Imports System.Windows.Forms
Public Class InputTransaksiPendaftaran
    Public kddaftar, tgltr, member, kdmember, nmpelanggan, alamt, notelp, email As String
    Public id_pelanggan As Integer

    Private Sub InputTransaksiPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If cmb_member.SelectedItem = "" Then
            MsgBox("Pilih Jenis Member Terlebih Dahulu!")
        Else
            member = cmb_member.SelectedItem
            DaftarPaket.ShowDialog()
            If DaftarPaket.batal = False Then
                Dim rowAlreadyExist As Boolean = False
                If DaftarPaket.id_paket > 0 Then
                    For i As Integer = 0 To dtg_dftrDetail.Rows.Count() - 1 Step 1
                        If dtg_dftrDetail.Rows(i).Cells(0).Value = DaftarPaket.id_paket Then
                            rowAlreadyExist = True
                            MsgBox("Detail Sudah Tersedia, Tidak Bisa Ditambahkan Lagi!!")
                            Exit For
                        End If
                    Next
                    If rowAlreadyExist = False Then
                        dtg_dftrDetail.Rows.Add(DaftarPaket.id_paket, DaftarPaket.kd_paket, DaftarPaket.nama_paket, DaftarPaket.ket_paket, DaftarPaket.hara_paket)
                        cmb_member.Enabled = False
                    End If
                End If
            Else
                If dtg_dftrDetail.Rows.Count < 0 Then
                    cmb_member.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If dtg_dftrDetail.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dtg_dftrDetail.SelectedRows
                dtg_dftrDetail.Rows.Remove(row)
            Next
        End If
    End Sub

    Private Sub btn_bayar_Click(sender As Object, e As EventArgs) Handles btn_bayar.Click
        kddaftar = tb_kddaftar.Text
        tgltr = dtp_tgltr.Text
        member = cmb_member.SelectedItem
        kdmember = tb_kdmember.Text
        nmpelanggan = cmb_pelanggan.SelectedValue
        alamt = tb_almt.Text
        notelp = tb_notlp.Text
        email = tb_email.Text

        Dim adaQty As Boolean = False
        For i As Integer = 0 To dtg_dftrDetail.Rows.Count() - 1 Step 1
            If dtg_dftrDetail.Rows(i).Cells(5).Value > 0 Then
                adaQty = True
            Else
                adaQty = False
            End If
        Next

        If dtg_dftrDetail.Rows.Count < 1 Or member = "" Or cmb_pelanggan.Text = "" Or adaQty = False Then
            MsgBox("Lengkapi Form Sebelum Melakukan Pembayaran!")
        Else
            id_pelanggan = cmb_pelanggan.SelectedValue
            InputBayarPendaftaran.ShowDialog()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub clearForm()
        tb_kddaftar.Text = ""
        dtp_tgltr.Text = Format(Now, ("yyyy-MM-dd"))
        cmb_member.Enabled = True
        tb_kdmember.Text = ""
        cmb_pelanggan.Text = ""
        tb_almt.Text = ""
        tb_notlp.Text = ""
        tb_email.Text = ""
        tb_almt.Enabled = True
        tb_email.Enabled = True
        tb_notlp.Enabled = True
        loadDataPelanggan()
        cmb_pelanggan.Text = ""

        dtg_dftrDetail.Rows().Clear()
    End Sub

    Private Sub dtg_dftrDetail_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtg_dftrDetail.RowsRemoved
        If dtg_dftrDetail.Rows.Count < 1 Then
            cmb_member.Enabled = True
        End If
    End Sub

    Private Sub dtg_dftrDetail_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_dftrDetail.CellEndEdit
        Select Case e.ColumnIndex
            Case 5
                If dtg_dftrDetail.Item(5, e.RowIndex).Value <> "" Then
                    Dim jml As Integer = dtg_dftrDetail.Item(5, e.RowIndex).Value
                    Dim hrg_str As String = Replace(Replace(dtg_dftrDetail.Item(4, e.RowIndex).Value, "Rp", ""), ",", "")
                    Dim hrg As Double = hrg_str
                    Dim subtotal As Double = hrg * jml
                    dtg_dftrDetail.Item(6, e.RowIndex).Value = Format(subtotal, "Rp ###,###")
                End If
        End Select
    End Sub

    Private Sub dtg_paketDetail_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dtg_dftrDetail.EditingControlShowing
        If dtg_dftrDetail.CurrentCell.ColumnIndex = 5 Then
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

    Private Sub loadDataPelanggan()
        buka_koneksi()
        Try
            isi_dataset("mst_pelanggan")
            cmb_pelanggan.DataSource = ds.Tables("mst_pelanggan")
            cmb_pelanggan.ValueMember = "id_pelanggan"
            cmb_pelanggan.DisplayMember = "nama_pelanggan"
        Catch ex As Exception
            errmsg_error()
        End Try
        ds.Tables.Clear()
    End Sub
    
    Private Sub cmb_pelanggan_Leave(sender As Object, e As EventArgs) Handles cmb_pelanggan.Leave
        If cmb_pelanggan.SelectedValue <> 0 Then
            Try
                load_data_by_id("mst_pelanggan", "id_pelanggan", cmb_pelanggan.SelectedValue)
                If dr.HasRows Then
                    dr.Read()
                    tb_almt.Text = dr("alamat_pelanggan")
                    tb_notlp.Text = dr("notelp_pelanggan")
                    tb_email.Text = dr("email_pelanggan")
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox("Gagal Memuat Data")
            End Try
            tb_almt.Enabled = False
            tb_email.Enabled = False
            tb_notlp.Enabled = False
        Else
            tb_almt.Enabled = True
            tb_email.Enabled = True
            tb_notlp.Enabled = True
            tb_almt.Text = ""
            tb_email.Text = ""
            tb_notlp.Text = ""
        End If
    End Sub

End Class