﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TambahStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KondisiStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockMinMaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KondisiStockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockKeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 36)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1131, 537)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahStockToolStripMenuItem, Me.KondisiStockToolStripMenuItem, Me.StockMinMaxToolStripMenuItem, Me.StockKeluarToolStripMenuItem, Me.InformasiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1156, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'TambahStockToolStripMenuItem
        '
        Me.TambahStockToolStripMenuItem.Name = "TambahStockToolStripMenuItem"
        Me.TambahStockToolStripMenuItem.Size = New System.Drawing.Size(113, 24)
        Me.TambahStockToolStripMenuItem.Text = "Tambah Stock"
        '
        'KondisiStockToolStripMenuItem
        '
        Me.KondisiStockToolStripMenuItem.Name = "KondisiStockToolStripMenuItem"
        Me.KondisiStockToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.KondisiStockToolStripMenuItem.Text = "Kondisi Stock"
        '
        'StockMinMaxToolStripMenuItem
        '
        Me.StockMinMaxToolStripMenuItem.Name = "StockMinMaxToolStripMenuItem"
        Me.StockMinMaxToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.StockMinMaxToolStripMenuItem.Text = "Stock Min Max"
        '
        'StockKeluarToolStripMenuItem
        '
        Me.StockKeluarToolStripMenuItem.Name = "StockKeluarToolStripMenuItem"
        Me.StockKeluarToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.StockKeluarToolStripMenuItem.Text = "Stock Keluar"
        '
        'InformasiToolStripMenuItem
        '
        Me.InformasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KondisiStockToolStripMenuItem1, Me.StockMasukToolStripMenuItem, Me.StockKeluarToolStripMenuItem1})
        Me.InformasiToolStripMenuItem.Name = "InformasiToolStripMenuItem"
        Me.InformasiToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.InformasiToolStripMenuItem.Text = "Informasi"
        '
        'KondisiStockToolStripMenuItem1
        '
        Me.KondisiStockToolStripMenuItem1.Name = "KondisiStockToolStripMenuItem1"
        Me.KondisiStockToolStripMenuItem1.Size = New System.Drawing.Size(173, 26)
        Me.KondisiStockToolStripMenuItem1.Text = "Kondisi Stock"
        '
        'StockMasukToolStripMenuItem
        '
        Me.StockMasukToolStripMenuItem.Name = "StockMasukToolStripMenuItem"
        Me.StockMasukToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.StockMasukToolStripMenuItem.Text = "Stock Masuk"
        '
        'StockKeluarToolStripMenuItem1
        '
        Me.StockKeluarToolStripMenuItem1.Name = "StockKeluarToolStripMenuItem1"
        Me.StockKeluarToolStripMenuItem1.Size = New System.Drawing.Size(173, 26)
        Me.StockKeluarToolStripMenuItem1.Text = "Stock Keluar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 578)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1012, 25)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 612)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form5"
        Me.Text = "Daftar Data Stock Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TambahStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents KondisiStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockMinMaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KondisiStockToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockKeluarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
