Imports Warehouse

Public Class FrmExplo
    Dim WithEvents dttemp As New tempdt2

    Private Sub isiPD(ByVal thn As Integer)
        csql = "select periode from tokomaster.dbo.ft_periode('" & thn & "') order by nom "
        Try
            With cbPD
                .Items.Clear()
                For Each dt As DataRow In dttemp.ExecQuery(csql).Rows
                    .Items.Add(dt(0))
                Next
                .Text = thn.ToString & Format(Now, "MM")
            End With
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "err")
        End Try

    End Sub




    Private Sub FrmExplo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dttemp.lvTag = Me.Tag
        dttemp.tv = Me.tv
        dttemp.lv1 = Me.lv1
        dttemp.lv2 = Me.lv2
        dttemp.pb = Me.pb

        tthn.Text = Now.Year
        If Me.Tag = "Trans" Then dttemp.MenuTransaksi()


    End Sub
    Private Sub tv_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv.AfterSelect
        dttemp.ndKey = tv.SelectedNode.Name
        itm = Split(dttemp.ndKey, "!")
        If Me.Tag = "Trans" Then
            dttemp.dtMaster()
        Else
            If itm(0) = "bl" Then
                dttemp.PKey = tthn.Text
                dttemp.SKey = itm(1)
                dttemp.Tamplidt(itm(0))

            ElseIf itm(0) = "ps" Then
                dttemp.PKey = tthn.Text : dttemp.SKey = itm(1)
                dttemp.Tamplidt(itm(0))
            ElseIf itm(0) = "tp" Then
                dttemp.PKey = tthn.Text
                dttemp.SKey = itm(1)

                Select Case itm(1)
                    Case "diterima"
                        dttemp.Tamplidt("Pesanan Diterima")
                    Case "proses"
                        dttemp.Tamplidt("Sedang Proses")
                    Case "dikirim"
                        dttemp.Tamplidt("Dikirim")
                End Select
            ElseIf itm(0) = "pj" Then
                dttemp.PKey = tthn.Text : dttemp.SKey = itm(1)
                dttemp.Tamplidt(itm(0))
            ElseIf itm(0) = "byr" Then
                dttemp.PKey = tthn.Text : dttemp.SKey = itm(1)
                dttemp.Tamplidt(itm(0))
            End If
        End If
        Me.ts1.Text = Me.tv.SelectedNode.Text

    End Sub
    Private Sub BukaFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaFormToolStripMenuItem.Click
        dttemp.PKey = ""
        If Me.Tag = "beli" Then
            dttemp.ndKey = "bl"
            dttemp.BukaForm(Me.Tag)
        ElseIf Me.Tag = "pesan" Then
            dttemp.ndKey = "ps"
            dttemp.BukaForm(Me.Tag)
        ElseIf Me.Tag = "jual" Then
            dttemp.ndKey = "pj"
            dttemp.BukaForm(Me.Tag)
        ElseIf Me.Tag = "bayar" Then
            dttemp.ndKey = "byr"
            dttemp.BukaForm(Me.Tag)
        End If
    End Sub
    Private Sub FrmExplo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dttemp = Nothing
    End Sub
    Private Sub lv1_DoubleClick(sender As Object, e As EventArgs) Handles lv1.DoubleClick
        With lv1
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)
            If Me.Tag = "beli" Then
                dttemp.ndKey = "bl"
                nPKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf Me.Tag = "pesan" Then
                dttemp.ndKey = "ps"
                nPKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf Me.Tag = "Terima" Then
                dttemp.ndKey = "tp!diterima"
                nPKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf Me.Tag = "bayar" Then
                dttemp.ndKey = "byr"
                nPKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            End If
        End With
    End Sub


    Private Sub lv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv1.SelectedIndexChanged
        With lv1
            If .SelectedIndices.Count = 0 Then Exit Sub

            Dim lvi As ListViewItem = .SelectedItems(0)
            dttemp.PKey = lvi.Text
            dttemp.TampilDetailTransaksi(.Tag)




            'If dttemp.ndKey.Contains("bl") Then
            '    dttemp.TampilDetailTransaksi(tv.SelectedNode.Name)
            'ElseIf dttemp.ndKey.Contains("ps") Then
            '    dttemp.TampilDetailPesanan(tv.SelectedNode.Name)
            'End If
            'Select Case tv.SelectedNode.Name
            '    Case "tp!diterima"
            '        dttemp.TampilDetailTerimaPesanan(tv.SelectedNode.Name)
            'End Select

            Me.ts2.Text = "Sorot " & lvi.Text & " " & lvi.Index & " dari " & .Items.Count
        End With
    End Sub


    Private Sub tthn_TextChanged(sender As Object, e As EventArgs) Handles tthn.TextChanged
        If Len(tthn.Text) <> 4 Then Exit Sub
        isiPD(tthn.Text)
        If Me.Tag = "beli" Then dttemp.MenuPembelian(tthn.Text)
        If Me.Tag = "pesan" Then dttemp.MenuPesanan(tthn.Text)
        If Me.Tag = "Terima" Then dttemp.MenuTerimaPesanan(tthn.Text)
        If Me.Tag = "jual" Then dttemp.MenuPenjualan(tthn.Text)
        If Me.Tag = "bayar" Then dttemp.MenuBayar(tthn.Text)
    End Sub


    Private Sub tthn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tthn.KeyPress
        e.KeyChar = Chr(BatasAngka(e.KeyChar))
    End Sub

    Private Sub cbPD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPD.SelectedIndexChanged
        lbPD.Text = ""
        Try
            csql = "select KetPeriode from tokomaster.dbo.ft_Periode('" & tthn.Text & "') where periode='" & cbPD.Text & "'"
            lbPD.Text = dttemp.ExecScalar(csql)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "cek err")
        End Try
    End Sub
End Class



Public Class tempdt2
    Inherits msaConn
    Implements ClassInterface.explore2
    Implements ClassInterface.nKey

    Dim ntv As TreeView, nlv1 As ListView, nlv2 As ListView, nlvtag As String, nPB As ToolStripProgressBar, nPB2 As ProgressBar
    Dim troot As TreeNode, troot1 As TreeNode, troot2 As TreeNode
    Public Property tv As TreeView Implements ClassInterface.explore2.tv
        Get
            tv = ntv
        End Get
        Set(value As TreeView)
            ntv = value
        End Set
    End Property

    Public Property lv1 As ListView Implements ClassInterface.explore2.lv1
        Get
            lv1 = nlv1
        End Get
        Set(value As ListView)
            nlv1 = value
        End Set
    End Property

    Public Property lv2 As ListView Implements ClassInterface.explore2.lv2
        Get
            lv2 = nlv2
        End Get
        Set(value As ListView)
            nlv2 = value
        End Set
    End Property

    Public Property lvTag As String Implements ClassInterface.explore2.lvTag
        Get
            lvTag = nlvtag
        End Get
        Set(value As String)
            nlvtag = value
        End Set
    End Property

    Public Property pb As ToolStripProgressBar Implements ClassInterface.explore2.pb
        Get
            pb = nPB
        End Get
        Set(value As ToolStripProgressBar)
            nPB = value
        End Set
    End Property

    Public Property ndKey As String Implements ClassInterface.explore2.ndKey
        Get
            ndKey = nKey
        End Get
        Set(value As String)
            nKey = value
        End Set
    End Property

    Public Property PKey As String Implements ClassInterface.nKey.PKey
        Get
            PKey = nPKey
        End Get
        Set(value As String)
            nPKey = value
        End Set
    End Property

    Public Property SKey As String Implements ClassInterface.nKey.SKey
        Get
            SKey = nSKey
        End Get
        Set(value As String)
            nSKey = value
        End Set
    End Property

    Public Property Tkey As String Implements ClassInterface.nKey.Tkey
        Get
            Tkey = nTkey
        End Get
        Set(value As String)
            nTkey = value
        End Set
    End Property

    Public Property pb2 As ProgressBar Implements ClassInterface.explore2.pb2
        Get
            pb2 = nPB2
        End Get
        Set(value As ProgressBar)
            nPB2 = value
        End Set
    End Property

    Public Sub MenuTransaksi()
        With tv
            troot = .Nodes.Add("tr", "Transaksi")
            troot1 = troot.Nodes.Add("ps", "Pesanan")
            troot1 = troot.Nodes.Add("ts", "Terima Pesanan")
            troot1 = troot.Nodes.Add("tp", "Penjualan")
            troot1 = troot.Nodes.Add("tb", "Pembelian")
            troot1 = troot.Nodes.Add("byr", "Bayar Hutang")
            troot.Expand()

            troot = .Nodes.Add("gd", "Gudang")
            troot.Expand()

        End With
    End Sub
    Public Sub TampilDetailTerimaPesanan(ByVal ttag As String)
        Select Case ttag
            Case "tp!diterima"
                csql = "select IdPesanan,IdPembeli,IdBarang,Tanggal,NamaPembeli,NamaBarang,JmlBrg,Harga,Diskon,Satuan from TokoTrans.dbo.ft_TerimaPesananMenuDet('" & PKey & "','" & SKey & "')"
        End Select
        lv2.Items.Clear()

        lvListAutoMain(lv2, pb, csql)
    End Sub
    Public Sub TampilDetailPesanan(ByVal idPembeli As String)
        Dim csql As String = "SELECT IdPesanan,IdPembeli,IdBarang,Tanggal,NamaPembeli,NamaBarang,JmlBrg,Harga,Diskon,Satuan,Status FROM TokoTrans.dbo.ft_PesananPblDet('" & PKey & "','" & SKey & "')"
        lv2.Items.Clear()

        lvListAutoMain(lv2, pb, csql)
    End Sub
    Public Sub TampilDetailTransaksi(ByVal ttag As String)
        If ttag = "bl" Then
            csql = "SELECT IdBarang,NamaBarang,Satuan,Jumlah,Harga,Total,Diskon,HrgDis FROM TokoTrans.dbo.ft_PembelianSplDet('" & PKey & "')"

        End If

        lvListAutoMain(lv2, pb, csql)
    End Sub

    Public Sub Tamplidt(ByVal ttag As String)
        If ttag = "bl" Then
            csql = "select idtransbeli,Tanggal,NamaGudang,namaKaryawan,Jumlah,Total,HrgDiskon,bayar,HrgDiskon-bayar Hutang from tokotrans.dbo.ft_PembelianSpl('" & PKey & "','" & SKey & "')"
        ElseIf ttag = "ps" Then
            csql = "select IdPesanan,Tanggal,NamaPembeli,NamaBarang from TokoTrans.dbo.ft_PesananPbl('" & PKey & "','" & SKey & "')"
        ElseIf ttag = "pj" Then
            csql = "select IdTransJual,IdEKS,IdPesanan,IdPembeli,IdKaryawan from TokoTrans.dbo.ft_PenjualanPbl('" & PKey & "','" & SKey & "')"
        ElseIf ttag = "byr" Then
            csql = "select IdHutang,IDTransBeli,Tanggal,uraian,Debet,Kredit,KetPost from TokoTrans.dbo.ft_BayarHutangSpl('" & PKey & "','" & SKey & "')"
        End If
        Select Case ttag
            Case "Pesanan Diterima"
                csql = "select IdPesanan,TglInput,IdPembeli,IdBarang,Status from TokoTrans.dbo.ft_TerimaPesananMenu('" & PKey & "','" & ttag & "')"
            Case "Sedang Proses"
                csql = "select IdPesanan,TglInput,IdPembeli,IdBarang,Status from TokoTrans.dbo.ft_TerimaPesananMenu('" & PKey & "','" & ttag & "')"
            Case "Dikirim"
                csql = "select IdPesanan,TglInput,IdPembeli,IdBarang,Status from TokoTrans.dbo.ft_TerimaPesananMenu('" & PKey & "','" & ttag & "')"

        End Select
        Me.lv1.Tag = ttag
        lvListAutoMain(lv1, pb, csql)
    End Sub

    Public Sub MenuPembelian(ByVal thn As Integer)
        Dim db As New msaConn
        Try
            csql = "select idsuplier,namaSuplier from tokotrans.dbo.ft_PembelianMenu('" & thn & "')"
            With tv
                .Nodes.Clear()
                troot = .Nodes.Add("bl", "Pembelian " & thn.ToString)
                For Each dt As DataRow In db.ExecQuery(csql).Rows
                    troot1 = troot.Nodes.Add("bl!" & dt(0), dt(1))
                Next
                troot.Expand()
            End With
        Catch ex As Exception
            MsgBox(Err.Description, "cek err")
        Finally
            db = Nothing
        End Try
    End Sub
    Public Sub MenuPenjualan(ByVal thn As Integer)
        Dim db As New msaConn
        Try
            csql = "select IdPembeli,NamaPembeli from tokotrans.dbo.ft_PenjualanMenu('" & thn & "')"
            With tv
                .Nodes.Clear()
                troot = .Nodes.Add("pj", "Penjualan " & thn.ToString)
                For Each dt As DataRow In db.ExecQuery(csql).Rows
                    troot1 = troot.Nodes.Add("pj!" & dt(0), dt(1))
                Next
                troot.Expand()
            End With
        Catch ex As Exception
            MsgBox(Err.Description, "cek err")
        Finally
            db = Nothing
        End Try
    End Sub

    Public Sub MenuPesanan(ByVal thn As Integer)
        Dim db As New msaConn
        Try
            csql = "select IdPembeli,NamaPembeli from TokoTrans.dbo.ft_PesananMenu('" & thn & "')"
            With tv
                .Nodes.Clear()
                troot = .Nodes.Add("ps", "Pesanan " & thn.ToString)
                For Each dt As DataRow In db.ExecQuery(csql).Rows
                    troot1 = troot.Nodes.Add("ps!" & dt(0), dt(1))
                Next
                troot.Expand()
            End With
        Catch ex As Exception
            MsgBox(Err.Description, "cek err")
        Finally
            db = Nothing
        End Try
    End Sub
    Public Sub MenuTerimaPesanan(ByVal thn As Integer)
        Dim db As New msaConn
        Try
            With tv
                .Nodes.Clear()
                troot = .Nodes.Add("tp", "TerimaPesanan " & thn.ToString)
                Dim troot1Diterima As TreeNode = troot.Nodes.Add("tp!diterima", "Pesanan Diterima")
                Dim troot1Proses As TreeNode = troot.Nodes.Add("tp!proses", "Sedang Proses")
                Dim troot1Dikirim As TreeNode = troot.Nodes.Add("tp!dikirim", "Dikirim")
            End With
            troot.Expand()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        Finally
            db = Nothing
        End Try
    End Sub

    Public Sub MenuBayar(ByVal thn As Integer)
        Dim db As New msaConn
        Try
            csql = "select idsuplier,namaSuplier from tokotrans.dbo.ft_BayarHutangMenu('" & thn & "')"
            With tv
                .Nodes.Clear()
                troot = .Nodes.Add("byr", "Bayar Hutang " & thn.ToString)
                For Each dt As DataRow In db.ExecQuery(csql).Rows
                    troot1 = troot.Nodes.Add("byr!" & dt(0), dt(1))
                Next
                troot.Expand()
            End With
        Catch ex As Exception
            MsgBox(Err.Description, "cek err")
        Finally
            db = Nothing
        End Try
    End Sub

    Public Sub dtMaster()
        Try
            csql = ""
            If ndKey = "ps" Then csql = "select * from TokoTrans..Pesanan order by IdPesanan"
            If ndKey = "tb" Then csql = "select * from TokoTrans..TransBeli order by IdTransBeli"
            If ndKey = "tp" Then csql = "select * from TokoTrans..TransJual order by IdTransJual"
            If ndKey = "byr" Then csql = "select * from TokoTrans..bkHutang"

            lvListAutoMain(lv1, pb, csql)
            Me.lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try

    End Sub
    Public Sub dtdet()
        Try

            csql = ""
            csql = "select a.IdTransBeli,e.IdBarang,d.IdSuplier,a.TglInput ,b.NamaGudang, c.NamaKaryawan,e.NamaBarang,f.Harga,f.Jumlah,f.Diskon, e.Satuan from TokoTrans..TransBeli a 
	                        inner join TokoMaster..Gudang b on a.IdGudang=b.IdGudang
	                        inner join TokoMaster..Karyawan c on a.IdKaryawan=c.IdKaryawan
	                        inner join TokoMaster..Supplier d on a.IdSuplier=d.IdSuplier
							inner join TokoTrans..TransBeliDet f on a.IdTransBeli=f.IdTransBeli
	                        inner join TokoMaster..Barang e on f.IdBarang=e.IdBarang order by IdTransBeli"

            lvListAutoMain(lv2, pb, csql)
            Me.lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try

    End Sub
    Public Sub detjual()
        Try
            csql = ""
            csql = "select a.IdTransJual,a.idPesanan,b.IdBarang,a.IdEKS,a.TglInput, c.NamaKaryawan ,d.NamaBarang,b.Jumlah,b.Harga,b.Diskon,d.Satuan From TokoTrans..TransJual a 
	                        inner join TokoTrans..TransJualDet b on a.IdTransJual=b.IdTransJual
	                        inner join TokoMaster..Karyawan c on a.IdKaryawan=c.IdKaryawan
	                        inner join TokoMaster..Barang d on b.IdBarang=d.IdBarang order by IdTransJual"

            lvListAutoMain(lv2, pb, csql)
            Me.lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Public Sub detpesan()
        Try
            csql = ""
            csql = "select a.IdPesanan,a.IdPembeli,a.IdBarang,c.NamaPembeli,c.Notelp,d.NamaBarang,a.JmlBrg,d.Satuan from TokoTrans..Pesanan a 
	                        inner join TokoMaster..BarangJual b on a.IdBarang=b.IdBarang
	                        inner join TokoMaster..Pembeli c on a.IdPembeli=c.IdPembeli
	                        inner join TokoMaster..Barang d on b.IdBarang=d.IdBarang"

            lvListAutoMain(lv2, pb, csql)
            Me.lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Public Sub BukaForm(ByVal meTag As String)
        Select Case meTag
            Case "beli"
                If ndKey = "bl" Then
                    FrmTransBeli.bukaform(FrmUtama, nPKey)
                End If
            Case "pesan"
                If ndKey = "ps" Then
                    FrmPesanan.bukaform(FrmUtama, nPKey)
                End If
            Case "jual"
                If ndKey = "pj" Then
                    FrmTransJual.bukaform(FrmUtama, nPKey)
                End If
            Case "bayar"
                If ndKey = "byr" Then
                    FrmHutang.bukaform(FrmUtama, nPKey)
                End If
        End Select
    End Sub
End Class
