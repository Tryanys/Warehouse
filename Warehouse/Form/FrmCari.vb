
Public Class FrmCari
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn

    Private Sub FrmCari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dttemp.lvTag = Me.Tag
        dttemp.lv = Me.lv
        dttemp.pb2 = Me.pb
        If Me.Tag = "BARANG" Then
            dtSearch()
            Label1.Text = "DATA BARANG"
        ElseIf Me.Tag = "BARANG JUAL" Then
            dtPesan()
            Label1.Text = "DATA BARANG JUAL"
        ElseIf Me.Tag = "PESANAN" Then
            dtjual()
            Label1.Text = "DATA PESANAN"
        End If
    End Sub
    Public Sub dtSearch()
        Try
            csql = ""
            csql = "select Idbarang,NamaBarang,Stok from TokoTrans..ft_TampilJual()"

            If csql = "" Then Exit Sub
            lvListAuto(lv, pb, csql)
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try

    End Sub
    Private Sub dtPesan()
        Try
            csql = "select a.IdBarang, a.NamaBarang,b.Harga,b.Diskon,a.Satuan from TokoMaster..Barang a 
	                    inner join TokoMaster..BarangJual b on a.IdBarang=b.IdBarang order by IdBarang"
            lvListAuto(lv, pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub dtjual()
        Try
            csql = "select a.IdPesanan,a.IdPembeli,a.IdBarang,a.JmlBrg from TokoTrans..Pesanan a 
	                    inner join TokoMaster..BarangJual b on a.IdBarang=b.IdBarang order by IdPesanan"
            lvListAuto(lv, pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub lv_DoubleClick(sender As Object, e As EventArgs) Handles lv.DoubleClick
        With lv
            If .SelectedIndices.Count = 0 Then Exit Sub
            Dim lvi As ListViewItem = .SelectedItems(0)
            If Me.Tag = "BARANG" Then
                FrmMaster4.tb1.Text = lvi.Text
                Me.Close()
            ElseIf Me.Tag = "BARANG JUAL" Then
                FrmPesanan.tb2.Text = lvi.Text
                Me.Close()
            ElseIf Me.Tag = "PESANAN" Then
                FrmTransJual.tb2.Text = lvi.Text
                Me.Close()
            End If

        End With
    End Sub
End Class