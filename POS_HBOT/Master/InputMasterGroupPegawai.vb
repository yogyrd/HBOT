Imports System.Windows.Forms
Public Class InputMasterGroupPegawai
    Dim tbl As String = "mst_grouppegawai"
    Dim kdgroup As String
    Dim nmgroup As String

    Private Sub InputMasterGroupPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
        If queryMode = "insert" Then
            tb_kdgroup.ReadOnly = False
        ElseIf queryMode = "update" Then
            tb_kdgroup.ReadOnly = True
            loadDataByID()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        If queryMode = "insert" Then
            Me.Close()
        ElseIf queryMode = "update" Then
            dr.Close()
            Me.Close()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If queryMode = "insert" Then
                Dim columnsName As String = "(`kode_group`,`nama_group`,`createdby`)"
                Dim columnsValue As String = "('" + tb_kdgroup.Text + "','" + tb_nmgroup.Text + "'," + "1)"
                insert_data(tbl, columnsName, columnsValue)
                errmsg_sukses_simpan()
                clearForm()
            ElseIf queryMode = "update" Then
                dr.Close()
                Dim updateQuery As String = "nama_group='" + tb_nmgroup.Text + "'"
                Dim kondisi As String = "id_group='" + MasterGroupPegawai.id_grouppegawai + "'"
                update_data(tbl, updateQuery, kondisi)
                errmsg_sukses_ubah()
                Me.Close()
            End If
        Catch ex As Exception
            errmsg_gagal_simpan()
        End Try
    End Sub

    Private Sub clearForm()
        tb_kdgroup.Text = ""
        tb_nmgroup.Text = ""
    End Sub

    Private Sub loadDataByID()
        Try
            load_data_by_id(tbl, "id_group", MasterGroupPegawai.id_grouppegawai)
            If dr.HasRows Then
                dr.Read()
                tb_kdgroup.Text = dr("kode_group")
                tb_nmgroup.Text = dr("nama_group")
            End If
        Catch ex As Exception
            errmsg_gagal()
        End Try
    End Sub
End Class