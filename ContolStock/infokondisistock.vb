﻿Imports System.Data
Imports MySql.Data.MySqlClient
Public Class infokondisistock

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
      
    End Sub
    Sub isigrid()
        Dim query As String = "SELECT Kode_barang,nama,merek,jumlah_barang,keterangan,tanggal from kondisi_stock inner join stock using (kode_barang)"
        Dim da As New MySqlDataAdapter(query, konek)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub infokondisistock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call isigrid()
    End Sub
End Class