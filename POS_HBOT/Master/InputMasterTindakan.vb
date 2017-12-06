Imports System.Windows.Forms
Public Class InputMasterTindakan
    Dim tbl As String = "mst_tindakan"
    Private Sub InputMasterTindakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearForm()
        If queryMode = "update" Then
            loadDataByID()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim harga As String = Replace(tb_harga.Text, ",", "")
        Try
            If queryMode = "insert" Then
                Dim columnsName As String = "(`nama_tindakan`,`harga_tindakan`,`keterangan`,`createdby`)"
                Dim columnsValue As String = "('" + tb_nmtindakan.Text + "','" + harga + "','" + tb_ket.Text + "'," + "1)"
                insert_data(tbl, columnsName, columnsValue)
                errmsg_sukses_simpan()
                clearForm()
            ElseIf queryMode = "update" Then
                Dim updateQuery As String = "nama_tindakan='" + tb_nmtindakan.Text + "',harga_tindakan='" + harga + "',keterangan='" + tb_ket.Text + "'"
                Dim kondisi As String = "id_tindakan='" + MasterTindakan.id_tindakan + "'"
                update_data(tbl, updateQuery, kondisi)
                errmsg_sukses_ubah()
                Me.Close()
            End If
        Catch ex As Exception
            errmsg_gagal_simpan()
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub clearForm()
        tb_nmtindakan.Text = ""
        tb_harga.Text = ""
        tb_ket.Text = ""
    End Sub

    Private Sub loadDataByID()
        Try
            load_data_by_id(tbl, "id_tindakan", MasterTindakan.id_tindakan)
            If dr.HasRows Then
                dr.Read()
                tb_nmtindakan.Text = dr("nama_tindakan")
                tb_harga.Text = dr("harga_tindakan")
                tb_ket.Text = dr("keterangan")
            End If
        Catch ex As Exception
            errmsg_gagal()
        End Try
        dr.Close()
    End Sub

    Private Sub tb_harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_harga.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tb_harga_TextChanged(sender As Object, e As EventArgs) Handles tb_harga.TextChanged
        If Len(tb_harga.Text) > 0 Then
            tb_harga.Text = FormatNumber(CDbl(tb_harga.Text), 0)
            Dim x As Integer = tb_harga.SelectionStart.ToString
            If x = 0 Then
                tb_harga.SelectionStart = Len(tb_harga.Text)
                tb_harga.SelectionLength = 0
            Else
                tb_harga.SelectionStart = x
                tb_harga.SelectionLength = 0
            End If
        End If
    End Sub
End Class