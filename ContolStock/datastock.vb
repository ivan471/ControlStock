Public Class datastock

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub datastock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        ComboBox1.Items.Add("Buah")
        ComboBox1.Items.Add("Kaleng")
        ComboBox1.Items.Add("Box")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan Semua form terisi")
        Else
            Dim tblsimpan As String = "INSERT INTO stock (kode, Nama, Merek, Jumlah,Satuan)" _
                                & "VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox4.Text & "', '" & TextBox3.Text & "','" & ComboBox1.Text & "')"
            Call simpandata(tblsimpan)
            MsgBox("Data Stock Berhasil Ditambah", MsgBoxStyle.Information, "Information")
            Form5.DataGridView1.Refresh()
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpilih.TextBox1.Text = "1"
        Formpilih.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
