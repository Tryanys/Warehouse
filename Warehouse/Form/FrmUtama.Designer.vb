﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiBeliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerimaPesananToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GudangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PembukuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LainnyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMain = New System.Windows.Forms.StatusStrip()
        Me.tslbMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsKantor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsPengguna = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsPenggunaStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsTGL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1011, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiBeliToolStripMenuItem, Me.TerimaPesananToolStripMenuItem1, Me.ToolStripSeparator1, Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem, Me.GudangToolStripMenuItem, Me.ToolStripSeparator2, Me.PembukuanToolStripMenuItem, Me.PelaporanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'TransaksiBeliToolStripMenuItem
        '
        Me.TransaksiBeliToolStripMenuItem.Name = "TransaksiBeliToolStripMenuItem"
        Me.TransaksiBeliToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.TransaksiBeliToolStripMenuItem.Text = "Pesanan"
        '
        'TerimaPesananToolStripMenuItem1
        '
        Me.TerimaPesananToolStripMenuItem1.Name = "TerimaPesananToolStripMenuItem1"
        Me.TerimaPesananToolStripMenuItem1.Size = New System.Drawing.Size(186, 26)
        Me.TerimaPesananToolStripMenuItem1.Text = "Terima Pesanan"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'GudangToolStripMenuItem
        '
        Me.GudangToolStripMenuItem.Name = "GudangToolStripMenuItem"
        Me.GudangToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.GudangToolStripMenuItem.Text = "Gudang"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'PembukuanToolStripMenuItem
        '
        Me.PembukuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HutangToolStripMenuItem, Me.PiutangToolStripMenuItem, Me.ToolStripSeparator3, Me.LainnyaToolStripMenuItem})
        Me.PembukuanToolStripMenuItem.Name = "PembukuanToolStripMenuItem"
        Me.PembukuanToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.PembukuanToolStripMenuItem.Text = "Pembukuan"
        '
        'HutangToolStripMenuItem
        '
        Me.HutangToolStripMenuItem.Name = "HutangToolStripMenuItem"
        Me.HutangToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.HutangToolStripMenuItem.Text = "Hutang"
        '
        'PiutangToolStripMenuItem
        '
        Me.PiutangToolStripMenuItem.Name = "PiutangToolStripMenuItem"
        Me.PiutangToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.PiutangToolStripMenuItem.Text = "Piutang"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(178, 6)
        '
        'LainnyaToolStripMenuItem
        '
        Me.LainnyaToolStripMenuItem.Name = "LainnyaToolStripMenuItem"
        Me.LainnyaToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.LainnyaToolStripMenuItem.Text = "Lainnya"
        '
        'PelaporanToolStripMenuItem
        '
        Me.PelaporanToolStripMenuItem.Name = "PelaporanToolStripMenuItem"
        Me.PelaporanToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.PelaporanToolStripMenuItem.Text = "Pelaporan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'tsMain
        '
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslbMain, Me.tsKantor, Me.tsPengguna, Me.tsPenggunaStatus, Me.tsTGL, Me.ToolStripStatusLabel1})
        Me.tsMain.Location = New System.Drawing.Point(0, 387)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.tsMain.Size = New System.Drawing.Size(1011, 25)
        Me.tsMain.TabIndex = 3
        Me.tsMain.Text = "StatusStrip1"
        '
        'tslbMain
        '
        Me.tslbMain.Name = "tslbMain"
        Me.tslbMain.Size = New System.Drawing.Size(674, 20)
        Me.tslbMain.Spring = True
        Me.tslbMain.Text = "Status"
        '
        'tsKantor
        '
        Me.tsKantor.Name = "tsKantor"
        Me.tsKantor.Size = New System.Drawing.Size(53, 20)
        Me.tsKantor.Text = "Kantor"
        '
        'tsPengguna
        '
        Me.tsPengguna.Name = "tsPengguna"
        Me.tsPengguna.Size = New System.Drawing.Size(74, 20)
        Me.tsPengguna.Text = "Pengguna"
        '
        'tsPenggunaStatus
        '
        Me.tsPenggunaStatus.Name = "tsPenggunaStatus"
        Me.tsPenggunaStatus.Size = New System.Drawing.Size(114, 20)
        Me.tsPenggunaStatus.Text = "PenggunaStatus"
        '
        'tsTGL
        '
        Me.tsTGL.Name = "tsTGL"
        Me.tsTGL.Size = New System.Drawing.Size(61, 20)
        Me.tsTGL.Text = "Tanggal"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripStatusLabel1.Text = "--"
        '
        'FrmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 412)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiBeliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GudangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PembukuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsMain As StatusStrip
    Friend WithEvents tslbMain As ToolStripStatusLabel
    Friend WithEvents tsKantor As ToolStripStatusLabel
    Friend WithEvents tsPengguna As ToolStripStatusLabel
    Friend WithEvents tsPenggunaStatus As ToolStripStatusLabel
    Friend WithEvents tsTGL As ToolStripStatusLabel
    Friend WithEvents TerimaPesananToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents HutangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PiutangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents LainnyaToolStripMenuItem As ToolStripMenuItem
End Class
