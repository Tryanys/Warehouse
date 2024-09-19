Imports Warehouse

Public Class FrmExplo2
    Dim WithEvents dttemp As New tempdt
    Private Sub FrmExplo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dttemp.lvTag = Me.Tag
        dttemp.tv = Me.tv
        dttemp.lv = Me.lv
        dttemp.pb = Me.pb
        If Me.Tag = "mast" Then
            dttemp.MenuMaster()
        End If
    End Sub

    Private Sub tv_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv.AfterSelect
        dttemp.ndKey = tv.SelectedNode.Name
        If Me.Tag = "mast" Then dttemp.dtMaster()
        Me.lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.ts1.Text = Me.tv.SelectedNode.Text

    End Sub

    Private Sub FrmExplo2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dttemp = Nothing

    End Sub

    Private Sub BukaFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaFormToolStripMenuItem.Click
        dttemp.BukaForm(Me.Tag)
    End Sub

    Private Sub lv_DoubleClick(sender As Object, e As EventArgs) Handles lv.DoubleClick
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)
            If dttemp.ndKey = "pro" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "jen" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "kab" Or dttemp.ndKey = "kec" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "brd" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "brj" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            ElseIf dttemp.ndKey = "tgd" Or dttemp.ndKey = "tga" Then
                dttemp.PKey = lvi.Text
                dttemp.BukaForm(Me.Tag)
            End If

        End With

    End Sub

    Private Sub lv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv.SelectedIndexChanged
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)


            Me.ts2.Text = "Sorot " & lvi.Text & " " & lvi.Index & " dari " & .Items.Count
        End With
    End Sub
End Class


Public Class tempdt
    Inherits msaConn
    Implements ClassInterface.explore
    Implements ClassInterface.nKey

    Dim ntv As TreeView, nlv As ListView, nlvtag As String, nPB As ToolStripProgressBar, nPB2 As ProgressBar
    Dim troot As TreeNode, troot1 As TreeNode, troot2 As TreeNode
    Public Property tv As TreeView Implements ClassInterface.explore.tv
        Get
            tv = ntv
        End Get
        Set(value As TreeView)
            ntv = value
        End Set
    End Property

    Public Property ndKey As String Implements ClassInterface.explore.ndKey
        Get
            ndKey = nKey
        End Get
        Set(value As String)
            nKey = value
        End Set
    End Property

    Public Property lv As ListView Implements ClassInterface.explore.lv
        Get
            lv = nlv
        End Get
        Set(value As ListView)
            nlv = value
        End Set
    End Property

    Public Property lvTag As String Implements ClassInterface.explore.lvTag
        Get
            lvTag = nlvtag
        End Get
        Set(value As String)
            nlvtag = value
        End Set
    End Property

    Public Property pb As ToolStripProgressBar Implements ClassInterface.explore.pb
        Get
            pb = nPB
        End Get
        Set(value As ToolStripProgressBar)
            nPB = value
        End Set
    End Property

    Public Property PKey As String Implements ClassInterface.nKey.PKey
        Get
            PKey = nPKey
        End Get
        Set(value As String)
            nPkey = value
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
    Public Property pb2 As ProgressBar Implements ClassInterface.explore.pb2
        Get
            pb2 = nPB2
        End Get
        Set(value As ProgressBar)
            nPB2 = value
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

    Public Sub MenuMaster()
        With tv
            troot = .Nodes.Add("wil", "Wilayah")
            troot1 = troot.Nodes.Add("pro", "Provinsi")
            troot1 = troot.Nodes.Add("kab", "Kabupaten")
            troot1 = troot.Nodes.Add("kec", "Kecamatan")
            troot.Expand()

            troot = .Nodes.Add("wilk", "Wilayah Kerja")
            troot.Expand()

            troot = .Nodes.Add("brg", "Barang")
            troot1 = troot.Nodes.Add("brd", "Data Barang")
            troot1 = troot.Nodes.Add("jen", "Jenis Barang")
            troot1 = troot.Nodes.Add("brj", "Barang Jual")
            troot.Expand()

            troot = .Nodes.Add("splr", "Suplier")
            troot.Expand()

            troot = .Nodes.Add("gdg", "Gudang")
            troot1 = troot.Nodes.Add("gdd", "Data Gudang")
            troot1 = troot.Nodes.Add("gdh", "Gudang Harga")
            troot1 = troot.Nodes.Add("gds", "Gudang Stok")
            troot.Expand()

            troot = .Nodes.Add("pbl", "Pembeli")
            troot.Expand()

            troot = .Nodes.Add("krw", "Karyawan")
            troot.Expand()

            troot = .Nodes.Add("eks", "Ekspedisi")
            troot.Expand()

            troot = .Nodes.Add("tag", "TAG")
            troot1 = troot.Nodes.Add("tgd", "Data TAG")
            troot1 = troot.Nodes.Add("tga", "Akses TAG")
            troot.Expand()
        End With
    End Sub

    Public Sub dtMaster()
        Try
            csql = ""
            If ndKey = "pro" Then csql = "select ProvID,Keterangan from TokoMaster.dbo.WILPROV order by ProvID"
            If ndKey = "kab" Then csql = "select KabID,Keterangan from TokoMaster.dbo.WILKAB order by kabID"
            If ndKey = "kec" Then csql = "select KecID,Keterangan from TokoMaster.dbo.WILKEC order by KecID"

            If ndKey = "wilk" Then csql = "select IdWilKerja,IdKaryawan,Wilayah from TokoMaster.dbo.WilayahKerja order by IdWilKerja"

            If ndKey = "brd" Then csql = "select IdBarang,NamaBarang,Rak from TokoMaster.dbo.Barang order by IdBarang"
            If ndKey = "jen" Then csql = "select Jenis,Keterangan from TokoMaster.dbo.JenisBarang order by Jenis"
            If ndKey = "brj" Then csql = "select a.IdBarang, b.NamaBarang,b.Satuan,a.Harga,a.Diskon,a.TglInput from TokoMaster..BarangJual a 
	                                            inner join TokoMaster..Barang b on a.IdBarang=b.IdBarang order by IdBarang"

            If ndKey = "splr" Then csql = "select IdSuplier,NamaSuplier,Alamat,NoTelp from TokoMaster.dbo.Supplier order by IdSuplier"

            If ndKey = "gdd" Then csql = "select IdGudang,NamaGudang,Alamat from TokoMaster.dbo.Gudang order by IdGudang"
            If ndKey = "gdh" Then csql = "select IdGudang,IdTransBeli,TglMasuk,Stok,TglExp from TokoMaster.dbo.GudangHrg order by IdGudang"
            If ndKey = "gds" Then csql = "select IdGudang,Idbarang,b.NamaBarang,Stok from TokoMaster..GudangStok a
	                                            outer apply (select NamaBarang from TokoMaster..Barang where IdBarang=a.IdBarang) b ORDER BY IdGudang"

            If ndKey = "pbl" Then csql = "select IdPembeli,NamaPembeli,Alamat from TokoMaster.dbo.Pembeli order by IdPembeli"

            If ndKey = "krw" Then csql = "select IdKaryawan,NamaKaryawan,Alamat,TAG,Akses from TokoMaster.dbo.Karyawan order by IdKaryawan"

            If ndKey = "eks" Then csql = "select IdEKS,NamaEKS,Tujuan from TokoMaster.dbo.Ekspedisi order by IdEKS"

            If ndKey = "tgd" Then csql = "select TAG,KetTag from TokoMaster.dbo.TAG order by TAG"
            If ndKey = "tga" Then csql = "select Akses,AksesKet from TokoMaster.dbo.AksesTag order by Akses"

            If csql = "" Then Exit Sub
            lvListAutoMain(lv, pb, csql)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Public Sub BukaForm(ByVal meTag As String)
        If meTag = "mast" Then
            Select Case ndKey
                Case "pro"
                    FrmMaster.Show()
                Case "kab"
                    FrmMaster.Show()
                Case "kec"
                    FrmMaster.Show()
                Case "jen"
                    FrmMaster.Show()
                Case "tgd"
                    FrmMaster.Show()
                Case "tga"
                    FrmMaster.Show()
                Case "splr"
                    FrmMaster1.Show()
                Case "pbl"
                    FrmMaster1.Show()
                Case "krw"
                    FrmMaster2.Show()
                Case "brd"
                    FrmMaster3.Show()
                Case "brj"
                    FrmMaster4.Show()
            End Select


        End If

    End Sub
End Class