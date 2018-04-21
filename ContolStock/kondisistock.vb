Public Class kondisistock

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.TextBox9.Text = "2"
        Formpilih.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim njum As Integer = Val(TextBox5.Text) - Val(TextBox3.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox10.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        ElseIf njum <= TextBox6.Text Then
            TextBox11.Text = "Stock Minimum"
            Dim tblupdate As String = "Update stock set Jumlah = " & njum & ",status = '" & TextBox11.Text & "' where kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO kondisi_stock(Kode_Barang,Jumlah_barang,keterangan,Tanggal)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox9.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        ElseIf njum >= TextBox7.Text Then
            TextBox11.Text = "Stock Maksimum"
            Dim tblupdate1 As String = "Update stock set Jumlah = " & njum & ", status = '" & TextBox11.Text & "' where kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate1)
            Dim tblsimpan As String = "INSERT INTO kondisi_stock(Kode_Barang,Jumlah_barang,keterangan,Tanggal)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox9.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        Else
            TextBox11.Text = "Cukup"
            Dim tblupdate2 As String = "Update stock set Jumlah = " & njum & ", status = '" & TextBox11.Text & "' where kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate2)
            Dim tblsimpan As String = "INSERT INTO kondisi_stock(Kode_Barang,Jumlah_barang,keterangan,Tanggal)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox9.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox9.Text = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub
End Class

