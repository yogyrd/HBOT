Public Class frm_hakakses

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    
    
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim value As Integer

        If RadioButton1.Checked Then
            value = 1
        ElseIf RadioButton2.Checked Then
            value = 2
        ElseIf RadioButton3.Checked Then
            value = 3
        End If


    End Sub
End Class
