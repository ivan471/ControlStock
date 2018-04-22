Imports System.Data
Imports MySql.Data.MySqlClient
Public Class datastock

    Private Sub datastock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT * from stock"
        Dim da As New MySqlDataAdapter(query, konek)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim njum As Integer = Val(TextBox6.Text) + Val(TextBox3.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        ElseIf njum <= TextBox8.Text Then
            TextBox10.Text = "Stock Minimum"
            Dim tblupdate As String = "Update stock set Jumlah = " & njum & ",status = '" & TextBox10.Text & "' where Kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate)
            Dim tblsimpan As String = "INSERT INTO stock_masuk(Kode_barang,Jumlah_masuk,Tanggal)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox7.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        ElseIf njum >= TextBox9.Text Then
            TextBox10.Text = "Stock Maksimum"
            Dim tblupdate2 As String = "Update stock set Jumlah = " & njum & ", status = '" & TextBox10.Text & "' where Kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate2)
            Dim tblsimpan As String = "INSERT INTO stock_masuk(Kode_barang,Jumlah_masuk,Tanggal)" _
                                  & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox7.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        Else
            TextBox10.Text = "Cukup"
            Dim tblupdate2 As String = "Update stock set Jumlah = " & njum & ", status = '" & TextBox10.Text & "' where Kode_barang = '" & TextBox1.Text & "'"
            Call simpandata(tblupdate2)
            Dim tblsimpan As String = "INSERT INTO stock_masuk(Kode_barang,Jumlah_masuk,Tanggal)" _
                                 & "VALUES('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox7.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.isigrid()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.TextBox9.Text = "1"
        Formpilih.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox7.Text = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Hanya Boleh Angka Yang Diisi !!!", MsgBoxStyle.Information, "Peringatan")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
