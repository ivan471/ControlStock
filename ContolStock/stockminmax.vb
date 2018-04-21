Public Class stockminmax

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.TextBox9.Text = "4"
        Formpilih.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        Else
            Dim tblupdate As String = "Update stock set min_stock = '" & TextBox2.Text & "',max_stock = '" & TextBox3.Text & "' where kode_barang = '" & TextBox5.Text & "'"
            Call simpandata(tblupdate)
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        End If
    End Sub
End Class