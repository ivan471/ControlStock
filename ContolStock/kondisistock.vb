Public Class kondisistock

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.TextBox9.Text = "2"
        Formpilih.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim njum As Integer = Val(TextBox5.Text) - Val(TextBox3.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        ElseIf njum <= TextBox8.Text Then
            TextBox9.Text = "Stock Minimum"
            Dim tblupdate As String = "Update stock set Jumlah = " & njum & ",status = '" & TextBox9.Text & "' where kode = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO kondisi_stock(Kode_Barang,Status,Jumlah,keterangan,Tanggal)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox7.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        ElseIf njum >= TextBox9.Text Then
            TextBox9.Text = "Stock Maksimum"
            Dim tblupdate2 As String = "Update stock set Jumlah = " & njum & ", status = '" & TextBox9.Text & "' where kode = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate2)
            Dim tblsimpan As String = "INSERT INTO kondisi_stock(Kode_Barang,Status,Jumlah,keterangan,Tanggal)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox7.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        ElseIf njum < TextBox8.Text And njum > TextBox9.Text Then
            TextBox9.Text = "Cukup"
            Dim tblupdate2 As String = "Update stock set Jumlah = " & njum & ", status = '" & TextBox9.Text & "' where kode = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate2)
            Dim tblsimpan As String = "INSERT INTO kondisi_stock(Kode_Barang,Status,Jumlah,keterangan,Tanggal)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox7.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        End If
        'Dim tblsimpan As String = "INSERT INTO kondisi_stock(Kode_Barang,Status,Jumlah,keterangan,Tanggal)" _
        '                         & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "')"
        'Call simpandata(tblsimpan)
        'MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
        'Form5.DataGridView1.Refresh()
        'Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

