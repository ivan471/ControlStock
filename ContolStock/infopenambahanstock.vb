Imports System.Data
Imports MySql.Data.MySqlClient
Public Class infopenambahanstock

    Private Sub infopenambahanstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call isigrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub isigrid()
        Dim query As String = "SELECT * from stock_masuk"
        Dim da As New MySqlDataAdapter(query, konek)
        Dim ds As New DataSet()
        If da.Fill(ds) Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Refresh()
        End If
    End Sub
End Class