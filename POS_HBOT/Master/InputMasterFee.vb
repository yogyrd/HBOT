Imports System.Windows.Forms
Public Class InputMasterFee
    Dim tbl As String = "mst_grouppegawaidetail"
    
    Private Sub InputMasterFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If queryMode = "insert" Then
            clearForm()
            loadDataGroupPegawai()
            loadDataPegawai()
        ElseIf queryMode = "update" Then
            loadDataByID()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        If ds.Tables.Count > 0 Then
            ds.Tables("mst_grouppegawai").Clear()
            ds.Tables("mst_pegawai").Clear()
        End If
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim id_group As String
        Dim id_pegawai As String
        Dim fee As String
        id_group = cmb_group.SelectedValue
        id_pegawai = cmb_pegawai.SelectedValue
        fee = Replace(tb_fee.Text, ",", "")

        Try
            If queryMode = "insert" Then
                Dim columnsName As String = "(`id_group`,`id_pegawai`,`fee`,`createdby`)"
                Dim columnsValue As String = "(" + id_group + "," + id_pegawai + "," + fee + ",1)"
                insert_data(tbl, columnsName, columnsValue)
                errmsg_sukses_simpan()
                clearForm()
            ElseIf queryMode = "update" Then
                Dim updateQuery As String = "id_group=" + id_group + ", id_pegawai=" + id_pegawai + ", fee=" + fee
                Dim kondisi As String = "id_group=" + MasterFee.id_grouppegawai + " and id_pegawai=" + MasterFee.id_pegawai
                update_data(tbl, updateQuery, kondisi)
                errmsg_sukses_ubah()
                Me.Close()
            End If
        Catch ex As Exception
            errmsg_gagal_simpan()
        End Try
    End Sub

    Private Sub clearForm()
        tb_fee.Text = ""
        cmb_group.Text = ""
        cmb_pegawai.Text = ""
    End Sub

    Private Sub loadDataGroupPegawai()
        Try
            isi_dataset("mst_grouppegawai")
            cmb_group.DataSource = ds.Tables("mst_grouppegawai")
            cmb_group.ValueMember = "id_group"
            cmb_group.DisplayMember = "nama_group"
        Catch ex As Exception
            errmsg_error()
        End Try
    End Sub

    Private Sub loadDataPegawai()
        Try
            isi_dataset("mst_pegawai")
            cmb_pegawai.DataSource = ds.Tables("mst_pegawai")
            cmb_pegawai.ValueMember = "id_pegawai"
            cmb_pegawai.DisplayMember = "nama_pegawai"
        Catch ex As Exception
            errmsg_error()
        End Try
    End Sub


    Private Sub loadDataByID()
        Try
            loadDataGroupPegawai()
            loadDataPegawai()
            cmb_group.SelectedValue = MasterFee.id_grouppegawai
            cmb_pegawai.SelectedValue = MasterFee.id_pegawai
            tb_fee.Text = MasterFee.fee
        Catch ex As Exception
            errmsg_gagal()
        End Try
    End Sub

    Private Sub tb_fee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_fee.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tb_fee_TextChanged(sender As Object, e As EventArgs) Handles tb_fee.TextChanged
        If Len(tb_fee.Text) > 0 Then
            tb_fee.Text = FormatNumber(CDbl(tb_fee.Text), 0)
            Dim x As Integer = tb_fee.SelectionStart.ToString
            If x = 0 Then
                tb_fee.SelectionStart = Len(tb_fee.Text)
                tb_fee.SelectionLength = 0
            Else
                tb_fee.SelectionStart = x
                tb_fee.SelectionLength = 0
            End If
        End If
    End Sub
End Class