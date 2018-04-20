Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Formpilih

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data belum dipilih")
        ElseIf TextBox9.Text = "1" Then
            datastock.TextBox1.Text = TextBox2.Text
            datastock.TextBox2.Text = TextBox3.Text
            datastock.TextBox4.Text = TextBox4.Text
            datastock.TextBox5.Text = TextBox5.Text
            datastock.TextBox6.Text = TextBox6.Text
            datastock.TextBox8.Text = TextBox7.Text
            datastock.TextBox9.Text = TextBox8.Text
            Me.Close()
        ElseIf TextBox9.Text = "2" Then
            kondisistock.TextBox1.Text = TextBox2.Text
            kondisistock.TextBox2.Text = TextBox3.Text
            kondisistock.TextBox5.Text = TextBox6.Text
            kondisistock.TextBox6.Text = TextBox6.Text
            kondisistock.TextBox7.Text = TextBox6.Text
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Formpilih_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call isigrid()
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT * from stock"
        Dim da As New MySqlDataAdapter(query, konek)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.RowCount > 0 Then
            Dim baris As Integer
            With DataGridView1
                baris = .CurrentRow.Index
                TextBox2.Text = .Item(0, baris).Value
                TextBox3.Text = .Item(1, baris).Value
                TextBox4.Text = .Item(2, baris).Value
                TextBox5.Text = .Item(6, baris).Value
                TextBox6.Text = .Item(3, baris).Value
                TextBox7.Text = .Item(4, baris).Value
                TextBox8.Text = .Item(5, baris).Value
            End With
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call seleksi()
    End Sub
    Sub seleksi()
        Dim strtext As String = "SELECT * FROM stock WHERE Nama like '%" & TextBox1.Text & "%'"
        Using cmd As New MySqlCommand(strtext, konek)
            Using adapter As New MySqlDataAdapter(cmd)
                Using DataSet As New DataSet()
                    adapter.Fill(DataSet)
                    DataGridView1.DataSource = DataSet.Tables(0)
                    DataGridView1.ReadOnly = True
                End Using
            End Using
        End Using
    End Sub

End Class