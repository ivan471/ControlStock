Public Class stockkeluar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.TextBox9.Text = "3"
        Formpilih.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim njum As Integer = Val(TextBox4.Text) - Val(TextBox3.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        ElseIf TextBox3.Text > TextBox4.Text Then
            MsgBox("Data stock kurang", MsgBoxStyle.Information, "Information")
            TextBox3.Focus()
        ElseIf njum <= TextBox5.Text Then
            TextBox9.Text = "Stock Minimum"
            Dim tblupdate As String = "Update stock set Jumlah = " & njum & ",status = '" & TextBox9.Text & "' where kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO stock_keluar(Kode_Barang,jumlah_keluar,tanggal_keluar)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox8.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        ElseIf njum >= TextBox7.Text Then
            TextBox9.Text = "Stock Maksimum"
            Dim tblupdate1 As String = "Update stock set Jumlah = " & njum & ", status = '" & TextBox9.Text & "' where kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate1)
            Dim tblsimpan As String = "INSERT INTO stock_keluar(Kode_Barang,jumlah_keluar,tanggal_keluar)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox8.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        Else
            TextBox9.Text = "Cukup"
            Dim tblupdate2 As String = "Update stock set Jumlah = " & njum & ", status = '" & TextBox9.Text & "' where kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate2)
            Dim tblsimpan As String = "INSERT INTO stock_keluar(Kode_Barang,jumlah_keluar,tanggal_keluar)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox8.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox8.Text = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Hanya Boleh Angka Yang Diisi !!!", MsgBoxStyle.Information, "Peringatan")
            e.Handled = True
        End If
    End Sub

    Private Sub stockkeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class