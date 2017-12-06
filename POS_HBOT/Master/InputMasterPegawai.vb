Imports System.Windows.Forms
Public Class InputMasterPegawai
    Dim tbl As String = "mst_pegawai"
    Dim kdpegawai As String
    Dim nmpegawai As String
    Dim username As String
    Dim password As String

    Private Sub InputMasterPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
        If queryMode = "insert" Then
            tb_username.ReadOnly = False
        ElseIf queryMode = "update" Then
            tb_username.ReadOnly = True
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
                Dim columnsName As String = "(`kode_pegawai`,`nama_pegawai`,`username`,`password`,`createdby`)"
                Dim columnsValue As String = "('" + tb_kdpegawai.Text + "','" + tb_nmpegawai.Text + "','" + tb_username.Text + "','" + _
                    tb_password.Text + "'," + "1)"
                insert_data(tbl, columnsName, columnsValue)
                MsgBox("Data Berhasil Disimpan")
                clearForm()
            ElseIf queryMode = "update" Then
                dr.Close()
                Dim updateQuery As String = "kode_pegawai='" + tb_kdpegawai.Text + "',nama_pegawai='" + tb_nmpegawai.Text + _
                    "',password='" + tb_password.Text + "'"
                Dim kondisi As String = "id_pegawai='" + MasterPegawai.id_pegawai + "'"
                update_data(tbl, updateQuery, kondisi)
                MessageBox.Show("Data Telah Diperbarui")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Data Gagal Disimpan")
        End Try
    End Sub

    Private Sub clearForm()
        tb_kdpegawai.Text = ""
        tb_nmpegawai.Text = ""
        tb_password.Text = ""
        tb_username.Text = ""
    End Sub

    Private Sub loadDataByID()
        Try
            load_data_by_id(tbl, "id_pegawai", MasterPegawai.id_pegawai)
            If dr.HasRows Then
                dr.Read()
                tb_kdpegawai.Text = dr("kode_pegawai")
                tb_nmpegawai.Text = dr("nama_pegawai")
                tb_username.Text = dr("username")
                tb_password.Text = dr("password")
            End If
        Catch ex As Exception
            MsgBox("Gagal Memuat Data")
        End Try
    End Sub

End Class