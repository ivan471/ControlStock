Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.start()
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
    Private Sub TambahStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahStockToolStripMenuItem.Click
        datastock.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 10
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            DataGridView1.Visible = True
            ProgressBar1.Visible = False
            MenuStrip1.Visible = True
        End If
    End Sub

    Private Sub KondisiStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KondisiStockToolStripMenuItem.Click
        kondisistock.Show()
    End Sub

    Private Sub StockKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockKeluarToolStripMenuItem.Click
        stockkeluar.Show()
    End Sub

    Private Sub KondisiStockToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KondisiStockToolStripMenuItem1.Click
        infokondisistock.Show()
    End Sub

    Private Sub StockMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockMasukToolStripMenuItem.Click
        infopenambahanstock.Show()
    End Sub

    Private Sub StockKeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockKeluarToolStripMenuItem1.Click
        infostockkeluar.Show()
    End Sub

    Private Sub StockMinMaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockMinMaxToolStripMenuItem.Click
        stockminmax.Show()
    End Sub
End Class