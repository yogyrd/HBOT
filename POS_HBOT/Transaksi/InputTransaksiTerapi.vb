Public Class InputTransaksiTerapi
    Dim id_daftar As String
    Dim id_groupdokter, id_groupperawat, id_groupoperator, id_grouptender, id_groupofficer As Integer
    Dim fee_dokter, fee_perawat, fee_operator, fee_tender, fee_officer As Double
    Dim tbl As String = "trans_terapi"
    Dim new_id_terapi As Integer
   
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub


    Private Sub InputTransaksiTerapi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
    End Sub

    Private Sub loadDataDokter()
        Try
            isi_dataset("mst_grouppegawaidetail", "select c.id_pegawai, c.nama_pegawai, a.id_group, a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group " + _
                        "inner join mst_pegawai c on a.id_pegawai=c.id_pegawai " + _
                        "where b.nama_group='DOKTER'")
            cmb_dokter.DataSource = ds.Tables("mst_grouppegawaidetail")
            cmb_dokter.ValueMember = "id_pegawai"
            cmb_dokter.DisplayMember = "nama_pegawai"
        Catch ex As Exception
            MsgBox("Gagal Memuat Daftar Dokter")
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub loadDataPerawat()
        Try
            isi_dataset("mst_grouppegawaidetail", "select c.id_pegawai, c.nama_pegawai, a.id_group, a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group " + _
                        "inner join mst_pegawai c on a.id_pegawai=c.id_pegawai " + _
                        "where b.nama_group='PERAWAT'")
            cmb_perawat.DataSource = ds.Tables("mst_grouppegawaidetail")
            cmb_perawat.ValueMember = "id_pegawai"
            cmb_perawat.DisplayMember = "nama_pegawai"
        Catch ex As Exception
            MsgBox("Gagal Memuat Daftar Dokter")
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub loadDataOperator()
        Try
            isi_dataset("mst_grouppegawaidetail", "select c.id_pegawai, c.nama_pegawai, a.id_group, a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group " + _
                        "inner join mst_pegawai c on a.id_pegawai=c.id_pegawai " + _
                        "where b.nama_group='OPERATOR'")
            cmb_operator.DataSource = ds.Tables("mst_grouppegawaidetail")
            cmb_operator.ValueMember = "id_pegawai"
            cmb_operator.DisplayMember = "nama_pegawai"
        Catch ex As Exception
            MsgBox("Gagal Memuat Daftar Dokter")
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub loadDataTender()
        Try
            isi_dataset("mst_grouppegawaidetail", "select c.id_pegawai, c.nama_pegawai, a.id_group, a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group " + _
                        "inner join mst_pegawai c on a.id_pegawai=c.id_pegawai " + _
                        "where b.nama_group='TENDER'")
            cmb_tender.DataSource = ds.Tables("mst_grouppegawaidetail")
            cmb_tender.ValueMember = "id_pegawai"
            cmb_tender.DisplayMember = "nama_pegawai"
        Catch ex As Exception
            MsgBox("Gagal Memuat Daftar Dokter")
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub loadDataOfficer()
        Try
            isi_dataset("mst_grouppegawaidetail", "select c.id_pegawai, c.nama_pegawai, a.id_group, a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group " + _
                        "inner join mst_pegawai c on a.id_pegawai=c.id_pegawai " + _
                        "where b.nama_group='OFFICER'")
            cmb_officer.DataSource = ds.Tables("mst_grouppegawaidetail")
            cmb_officer.ValueMember = "id_pegawai"
            cmb_officer.DisplayMember = "nama_pegawai"
        Catch ex As Exception
            MsgBox("Gagal Memuat Daftar Dokter")
        End Try
        ds.Tables.Clear()
    End Sub

    Private Sub clearForm()
        tb_kddaftar.Text = ""
        tb_nmpelanggan.Text = ""
        tb_nmpelanggan.ReadOnly = True
        dtp_tglterapi.Text = Format(Now, ("yyyy-MM-dd"))
        nud_jam.Value = 23
        nud_menit.Value = 59
        tb_nmpasien.Text = ""
        tb_jmlterapi.Text = "0"
        tb_ambil.Text = "0"
        loadDataDokter()
        loadDataPerawat()
        loadDataOperator()
        loadDataTender()
        loadDataOfficer()
    End Sub

    Private Sub tb_kddaftar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_kddaftar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            loadDataDaftar()
            loadTotalTerapi()
            loadJumlahTerapi()
        End If
    End Sub

    Private Sub loadDataDaftar()
        Try
            load_data("select * from trans_daftar a inner join mst_pelanggan b on a.id_pelanggan=b.id_pelanggan where a.kode_daftar='" + tb_kddaftar.Text + "'")
            If dr.HasRows Then
                dr.Read()
                tb_nmpelanggan.Text = dr("nama_pelanggan")
                tb_kddaftar.Text.ToUpper()
                tb_kddaftar.Text = dr("kode_daftar")
                id_daftar = dr("id_daftar").ToString()
            Else
                MsgBox("Data Tidak Valid!")
                tb_nmpelanggan.Text = ""
                tb_kddaftar.Text = ""
                id_daftar = ""
            End If
        Catch ex As Exception
            MsgBox("Data Tidak Valid!")
            tb_nmpelanggan.Text = ""
            tb_kddaftar.Text = ""
            id_daftar = ""
        End Try
        dr.Close()
    End Sub

    Private Sub loadTotalTerapi()
        Try
            load_data("select sum(b.qty_tindakan) as total_terapi " + _
                      "from trans_daftardetail a inner join mst_paketdetail b on a.id_paket=b.id_paket " + _
                      "inner join mst_tindakan c on b.id_tindakan=c.id_tindakan " + _
                      "where a.id_daftar=" + id_daftar + " and c.nama_tindakan like '%terapi%'")
            If dr.HasRows Then
                dr.Read()
                tb_jmlterapi.Text = dr("total_terapi")
            End If
        Catch ex As Exception
            tb_jmlterapi.Text = "0"
        End Try
        dr.Close()
    End Sub

    Private Sub loadJumlahTerapi()
        Try
            load_data("select count(*) as jumlah_terapi from trans_terapi where id_daftar=" + id_daftar)
            If dr.HasRows Then
                dr.Read()
                tb_ambil.Text = dr("jumlah_terapi")
            End If
        Catch ex As Exception
            tb_ambil.Text = "0"
        End Try
        dr.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        begin_transac()
        Try
            Dim columnsName As String = "(`id_daftar`,`tgl_terapi`,`jam_terapi`,`nama_pasien`,`createdby`)"
            Dim columnsValue As String = "('" + id_daftar + "','" + dtp_tglterapi.Text + "','" + nud_jam.Value.ToString() + ":" + nud_menit.Value.ToString() + _
                "','" + tb_nmpasien.Text + "'," + "1)"

            insert_transac(tbl, columnsName, columnsValue)

            'Untuk mengambil id Terapi Header
            Dim id_terapi_header As Integer = getIdHeader()



            Dim columnsNameDokter As String = "(`id_terapi`,`id_pegawai`,`id_grouppegawai`,`fee_pegawai`)"
            Dim columnsValueDokter As String = "(" + id_terapi_header.ToString() + "," + cmb_dokter.SelectedValue.ToString() + "," + loadIdGroupDokter(cmb_dokter.SelectedValue).ToString() + "," + loadFeeDokter(cmb_dokter.SelectedValue).ToString() + ")"
            insert_transac("trans_terapidetail", columnsNameDokter, columnsValueDokter)

            Dim columnsNamePerawat As String = "(`id_terapi`,`id_pegawai`,`id_grouppegawai`,`fee_pegawai`)"
            Dim columnsValuePerawat As String = "(" + id_terapi_header.ToString() + "," + cmb_perawat.SelectedValue.ToString() + "," + loadIdGroupPerawat(cmb_perawat.SelectedValue).ToString() + "," + loadFeePerawat(cmb_perawat.SelectedValue).ToString() + ")"
            insert_transac("trans_terapidetail", columnsNamePerawat, columnsValuePerawat)

            Dim columnsNameOperator As String = "(`id_terapi`,`id_pegawai`,`id_grouppegawai`,`fee_pegawai`)"
            Dim columnsValueOperator As String = "(" + id_terapi_header.ToString() + "," + cmb_operator.SelectedValue.ToString() + "," + loadIdGroupOperator(cmb_operator.SelectedValue).ToString() + "," + loadFeeOperator(cmb_operator.SelectedValue).ToString() + ")"
            insert_transac("trans_terapidetail", columnsNameOperator, columnsValueOperator)

            Dim columnsNameTender As String = "(`id_terapi`,`id_pegawai`,`id_grouppegawai`,`fee_pegawai`)"
            Dim columnsValueTender As String = "(" + id_terapi_header.ToString() + "," + cmb_tender.SelectedValue.ToString() + "," + loadIdGroupTender(cmb_tender.SelectedValue).ToString() + "," + loadFeeTender(cmb_tender.SelectedValue).ToString() + ")"
            insert_transac("trans_terapidetail", columnsNameTender, columnsValueTender)

            Dim columnsNameOfficer As String = "(`id_terapi`,`id_pegawai`,`id_grouppegawai`,`fee_pegawai`)"
            Dim columnsValueOfficer As String = "(" + id_terapi_header.ToString() + "," + cmb_officer.SelectedValue.ToString() + "," + loadIdGroupOfficer(cmb_officer.SelectedValue).ToString() + "," + loadFeeOfficer(cmb_officer.SelectedValue).ToString() + ")"
            insert_transac("trans_terapidetail", columnsNameOfficer, columnsValueOfficer)

            commit_transac()
            errmsg_sukses_simpan()
            clearForm()
            Me.Close()
        Catch ex As Exception
            rollback_transac()
            errmsg_gagal_simpan()
        End Try
    End Sub

    Private Function getIdHeader()
        isi_reader("select ifnull(max(id_terapi),1) as id_terapi from trans_terapi")
        If dr.HasRows Then
            dr.Read()
            new_id_terapi = dr("id_terapi")
        End If
        dr.Close()

        Return new_id_terapi
    End Function

    Private Function loadIdGroupDokter(ByVal idpegawai_dokter As String)
        Try
            load_data("select a.id_group from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%DOKTER%' and a.id_pegawai=" + idpegawai_dokter)
            If dr.HasRows Then
                dr.Read()
                id_groupdokter = dr("id_group")
            End If
        Catch ex As Exception
            id_groupdokter = 0
        End Try
        dr.Close()
        Return id_groupdokter
    End Function

    Private Function loadFeeDokter(ByVal idpegawai_dokter As String)
        Try
            load_data("select a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%DOKTER%' and a.id_pegawai=" + idpegawai_dokter)
            If dr.HasRows Then
                dr.Read()
                fee_dokter = dr("fee")
            End If
        Catch ex As Exception
            fee_dokter = 0
        End Try
        dr.Close()
        Return fee_dokter
    End Function

    Private Function loadIdGroupPerawat(ByVal idpegawai_perawat As String)
        Try
            load_data("select a.id_group from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%PERAWAT%' and a.id_pegawai=" + idpegawai_perawat)
            If dr.HasRows Then
                dr.Read()
                id_groupperawat = dr("id_group")
            End If
        Catch ex As Exception
            id_groupperawat = 0
        End Try
        dr.Close()
        Return id_groupperawat
    End Function

    Private Function loadFeePerawat(ByVal idpegawai_perawat As String)
        Try
            load_data("select a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%PERAWAT%' and a.id_pegawai=" + idpegawai_perawat)
            If dr.HasRows Then
                dr.Read()
                fee_perawat = dr("fee")
            End If
        Catch ex As Exception
            fee_perawat = 0
        End Try
        dr.Close()
        Return fee_perawat
    End Function

    Private Function loadIdGroupOperator(ByVal idpegawai_operator As String)
        Try
            load_data("select a.id_group from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%OPERATOR%' and a.id_pegawai=" + idpegawai_operator)
            If dr.HasRows Then
                dr.Read()
                id_groupoperator = dr("id_group")
            End If
        Catch ex As Exception
            id_groupoperator = 0
        End Try
        dr.Close()
        Return id_groupoperator
    End Function

    Private Function loadFeeOperator(ByVal idpegawai_operator As String)
        Try
            load_data("select a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%OPERATOR%' and a.id_pegawai=" + idpegawai_operator)
            If dr.HasRows Then
                dr.Read()
                fee_operator = dr("fee")
            End If
        Catch ex As Exception
            fee_operator = 0
        End Try
        dr.Close()
        Return fee_operator
    End Function

    Private Function loadIdGroupTender(ByVal idpegawai_tender As String)
        Try
            load_data("select a.id_group from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%TENDER%' and a.id_pegawai=" + idpegawai_tender)
            If dr.HasRows Then
                dr.Read()
                id_grouptender = dr("id_group")
            End If
        Catch ex As Exception
            id_grouptender = 0
        End Try
        dr.Close()
        Return id_grouptender
    End Function

    Private Function loadFeeTender(ByVal idpegawai_tender As String)
        Try
            load_data("select a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%TENDER%' and a.id_pegawai=" + idpegawai_tender)
            If dr.HasRows Then
                dr.Read()
                fee_tender = dr("fee")
            End If
        Catch ex As Exception
            fee_tender = 0
        End Try
        dr.Close()
        Return fee_tender
    End Function

    Private Function loadIdGroupOfficer(ByVal idpegawai_officer As String)
        Try
            load_data("select a.id_group from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%OFFICER%' and a.id_pegawai=" + idpegawai_officer)
            If dr.HasRows Then
                dr.Read()
                id_groupofficer = dr("id_group")
            End If
        Catch ex As Exception
            id_groupofficer = 0
        End Try
        dr.Close()
        Return id_groupofficer
    End Function

    Private Function loadFeeOfficer(ByVal idpegawai_officer As String)
        Try
            load_data("select a.fee from mst_grouppegawaidetail a inner join mst_grouppegawai b on a.id_group=b.id_group where b.nama_group like '%OFFICER%' and a.id_pegawai=" + idpegawai_officer)
            If dr.HasRows Then
                dr.Read()
                fee_officer = dr("fee")
            End If
        Catch ex As Exception
            fee_officer = 0
        End Try
        dr.Close()
        Return fee_officer
    End Function

End Class