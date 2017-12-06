Imports MySql.Data.MySqlClient
Module MyModul
    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public trans As MySqlTransaction
    Public cmd As New MySqlCommand
    Public ds As New DataSet
    Public dt As New DataTable

    Private server As String = "localhost"
    Private database As String = "db_hbo"
    Private userName As String = "root"
    Private password As String = ""


    Public queryMode As String
    Public caption As String = "HBOT"

    Public rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument

    Public Sub buka_koneksi()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "Server=" & server & ";Database=" & database & ";Uid=" & userName & ";Pwd=" & password & ";Convert Zero Datetime=True;Allow User Variables=True"
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi ke server gagal! Tutup jendela program, jika tidak bisa hubungi IT")
        End Try
    End Sub
    Public Sub tutup_koneksi()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Sub isi_dataset(ByVal tbl As String)
        da = New MySqlDataAdapter("select * from " + tbl, conn)
        da.Fill(ds, tbl)
    End Sub

    Public Sub isi_dataset(ByVal tbl As String, ByVal query As String)
        da = New MySqlDataAdapter(query, conn)
        da.Fill(ds, tbl)
    End Sub

    Public Sub isi_datatable(ByVal tbl As String)
        da = New MySqlDataAdapter("select * from " + tbl, conn)
        da.Fill(dt)
    End Sub

    Public Sub isi_reader(ByVal query)
        cmd = New MySqlCommand(query, conn)
        dr = cmd.ExecuteReader
    End Sub


    Public Sub isi_combobox(ByVal query)
        da = New MySqlDataAdapter(query, conn)
        ds = New DataSet
    End Sub

    Public Sub insert_transac(ByVal tbl As String, ByVal columnsName As String, ByVal columnsValue As String)
        cmd.Transaction = trans
        cmd.Connection = conn
        cmd.CommandText = "insert into " + tbl + " " + columnsName + " values " + columnsValue
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub update_transac(ByVal tbl As String, ByVal updateQuery As String, ByVal kondisi As String)
        cmd.Transaction = trans
        cmd.Connection = conn
        cmd.CommandText = "update " + tbl + " set " + updateQuery + " where " + kondisi
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub delete_transac(ByVal tbl As String, ByVal kondisi As String)
        cmd.Transaction = trans
        cmd.Connection = conn
        cmd.CommandText = "delete from " + tbl + " where " + kondisi
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub begin_transac()
        trans = conn.BeginTransaction()
    End Sub

    Public Sub commit_transac()
        trans.Commit()
    End Sub

    Public Sub rollback_transac()
        trans.Rollback()
    End Sub

    Public Sub insert_data(ByVal tbl As String, ByVal columnsName As String, ByVal columnsValue As String)
        cmd.Connection = conn
        cmd.CommandText = "insert into " + tbl + " " + columnsName + " values " + columnsValue
        cmd.ExecuteNonQuery()
        cmd.CommandText = "commit"
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub update_data(ByVal tbl As String, ByVal updateQuery As String, ByVal kondisi As String)
        cmd.Connection = conn
        cmd.CommandText = "update " + tbl + " set " + updateQuery + " where " + kondisi
        cmd.ExecuteNonQuery()
        cmd.CommandText = "commit"
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub load_data_by_id(ByVal tbl As String, ByVal columnid As String, ByVal kondisi As String)
        cmd.Connection = conn
        cmd.CommandText = "select * from " + tbl + " where " + columnid + "='" + kondisi + "'"
        da.SelectCommand = cmd
        dr = cmd.ExecuteReader
    End Sub

    Public Sub load_data_by_two_id(ByVal tbl As String, ByVal columnid1 As String, ByVal kondisi1 As String, ByVal columnid2 As String, ByVal kondisi2 As String)
        cmd.Connection = conn
        cmd.CommandText = "select * from " + tbl + " where " + columnid1 + "=" + kondisi1 + " and " + columnid2 + "=" + kondisi2
        da.SelectCommand = cmd
        dr = cmd.ExecuteReader
    End Sub

    Public Sub load_data(ByVal sql As String)
        cmd.Connection = conn
        cmd.CommandText = sql
        da.SelectCommand = cmd
        dr = cmd.ExecuteReader
    End Sub

    Public Sub delete_data(ByVal tbl As String, ByVal kondisi As String)
        cmd.Connection = conn
        cmd.CommandText = "delete from " + tbl + " where " + kondisi
        cmd.ExecuteNonQuery()
        cmd.CommandText = "commit"
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub sqlCommand(ByVal sql As String)
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub clear(ByVal dsName As String)
        ds.Tables(dsName).Clear()
        ds.Tables.Remove(dsName)
    End Sub

    Public Sub errmsg_sukses_simpan()
        MessageBox.Show("Data Berhasil Disimpan")
    End Sub

    Public Sub errmsg_sukses_ubah()
        MessageBox.Show("Data Berhasil Disimpan")
    End Sub

    Public Sub errmsg_sukses_hapus()
        MessageBox.Show("Data berhasil dihapus")
    End Sub

    Public Sub errmsg_error()
        MessageBox.Show("ERROR!! Hubungi IT Pusat")
    End Sub

    Public Sub errmsg_gagal()
        MessageBox.Show("Gagal Memuat Data!!")
    End Sub

    Public Sub errmsg_gagal_simpan()
        MessageBox.Show("Data Gagal Disimpan")
    End Sub

    Public Sub errmsg_gagal_hapus()
        MessageBox.Show("Data Gagal Dihapus")
    End Sub

    'Public Sub export(ByVal sql As String)
    '    buka_koneksi()
    '    isi_dataset("lp", sql)
    '    tutup_koneksi()
    '    Dim pSaveDialog As SaveFileDialog = New SaveFileDialog

    '    'set SaveFileDialog properties
    '    pSaveDialog.Title = "Save File .."
    '    'pSaveDialog.FileName = "Listing"
    '    pSaveDialog.Filter = "Excel files (*.xlsx)|*.xlsx"

    '    'SaveFileDialog 
    '    If pSaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

    '        Dim sFile As String = pSaveDialog.FileName

    '        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-us")

    '        Dim excel As New Microsoft.Office.Interop.Excel.Application
    '        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
    '        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
    '        'Dim range As Microsoft.Office.Interop.Excel.Range

    '        wBook = excel.Workbooks.Add()
    '        wSheet = wBook.ActiveSheet()

    '        Dim colIndex As Integer = 0
    '        Dim rowIndex As Integer = 2

    '        For i As Integer = 0 To ds.Tables("lp").Columns.Count - 1
    '            colIndex = colIndex + 1
    '            excel.Cells(rowIndex, colIndex) = ds.Tables("lp").Columns(i).ColumnName
    '        Next

    '        For i As Integer = 0 To ds.Tables("lp").Rows.Count - 1
    '            rowIndex = rowIndex + 1
    '            For j As Integer = 0 To ds.Tables("lp").Columns.Count - 1
    '                excel.Cells(rowIndex, j + 1) = ds.Tables("lp").Rows(i)(j)
    '            Next
    '        Next

    '        wSheet.Rows("2").Font.FontStyle = "Bold"
    '        wSheet.Rows("2:" & rowIndex).Font.Size = 11
    '        wSheet.Cells.Columns.AutoFit()
    '        wSheet.Cells.Select()
    '        wSheet.Cells.EntireColumn.AutoFit()
    '        wSheet.Cells(1, 1).Select()

    '        wSheet.Columns.AutoFit()
    '        Dim blnFileOpen As Boolean = False
    '        Try
    '            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(sFile)
    '            fileTemp.Close()
    '        Catch ex As Exception
    '            blnFileOpen = False
    '        End Try

    '        If System.IO.File.Exists(sFile) Then
    '            System.IO.File.Delete(sFile)
    '        End If
    '        wBook.SaveAs(sFile)
    '        wBook.Close()
    '        MessageBox.Show(sFile & " Created successfully....", caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    '    clear("lp")
    'End Sub
End Module
