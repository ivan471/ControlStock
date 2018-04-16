Public Class stockkeluar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.TextBox9.Text = "3"
        Formpilih.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        Else

            Dim njum As Integer = Val(TextBox3.Text) - Val(TextBox4.Text)
            Dim tblupdate As String = "Update stock set Jumlah = " & njum & " where kode = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO stock_keluar(Kode_Barang,Jumlah,Tanggal_keluar)" _
                                & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Dikeluar", MsgBoxStyle.Information, "Information")
            Form5.DataGridView1.Refresh()
            Me.Close()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox5.Text = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub
End Class