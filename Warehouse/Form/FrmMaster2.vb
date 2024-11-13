Imports System.Data.SqlClient
Imports System.IO

Public Class FrmMaster2
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn
    Private Sub tampdt()
        With dttemp
            .lvTag = .ndKey
            If .ndKey = "krw" Then csql = "select IdKaryawan,NamaKaryawan,Alamat,Akses from TokoMaster.dbo.Karyawan order by IdKaryawan"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
        End With
    End Sub
    Private Sub FrmMaster2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        Label1.Text = ""
        If dttemp.ndKey = "krw" Then Label1.Text = "KARYAWAN"

        tb1.Text = dttemp.PKey
        tb1.Focus() : SendKeys.Send("{end}")
        tampdt()
        ambilTag()
        ambilTagAkses()
        ambilKec()
    End Sub
    Private Sub FrmMaster3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub
    Private Sub ambilTag()
        cb2.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select KetTag from TokoMaster.dbo.TAG"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb2
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("KetTag"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub

    Private Sub ambilTagAkses()
        cb3.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select AksesKet from TokoMaster.dbo.AksesTag"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb3
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("AksesKet"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub

    Private Sub ambilKec()
        cb1.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select Keterangan from TokoMaster.dbo.WILKEC"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb1
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("Keterangan"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub
    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        Dim img() As Byte
        Try

            tb2.Text = ""
            tb4.Text = ""
            tb5.Text = ""
            cb1.Text = ""
            cb2.Text = ""
            cb3.Text = ""
            If dttemp.ndKey = "krw" Then
                csql = "Select a.NamaKaryawan, b.Keterangan, a.Alamat, a.NoTelp, a.TAG, a.Akses, a.foto  from TokoMaster..Karyawan a inner join TokoMaster..WILKEC b ON a.KecID = b.kecID where IdKaryawan ='" & tb1.Text & "'"
            End If
            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb2.Text = dt(0)
                cb1.Text = dt(1)
                tb4.Text = dt(2)
                tb5.Text = dt(3)
                cb2.Text = dt(4)
                cb3.Text = dt(5)
                img = dt(6)
                Dim ms As New MemoryStream(img)
                pt.Image = Image.FromStream(ms)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub


    'Private Sub btSim_Click(sender As Object, e As EventArgs) Handles btSimKIBA.Click, btSimSert.Click, btsimL.Click 'simpan foto semua tombol ini
    '    If sender.Equals(btSimKIBA) Then 'SIMPAN FOTO
    '        If lbPengguna.Text = "" Or lbObjekBar.Text = "" Then
    '            MsgBox("Barang (Aset) ditemukan ", vbInformation, "Chek id")
    '            Exit Sub
    '        ElseIf picBox.Image Is Nothing Then
    '            MsgBox("Image (Foto) tidak ditemukan..", vbInformation, "chek Gambar")
    '            Exit Sub
    '        ElseIf NewFileName = "" Then
    '            MsgBox("Pembaharuan tidak ditemukan..", vbInformation, "chek Gambar")
    '            Exit Sub

    '        End If

    '        com = New ClassIMG
    '        csql = "update asetIMG90.dbo.GambarKIBA set Gambar = @photo where KIBA = @noid"
    '        If com.SimpanPhoto("kiba", IMGPath & "\" & NewFileName, KIBkd, csql) > 0 Then
    '            lbFoto.Enabled = True
    '            MsgBox("Foto berhasil disimpan", vbInformation)

    '            'update nmfile pada gambarkiba
    '            csql = "update asetIMG90.dbo.gambarkiba set nmfile='" & NewFileName & "' where kiba='" & KIBdt & "'"
    '            Me.tsLabel.Text = com.UpdatenmFile(csql)
    '        Else
    '            lbFoto.Enabled = False
    '            MsgBox("Foto gagal disimpan", vbInformation)
    '        End If
    '        NewFileName = ""
    '        com = Nothing

    '    ElseIf sender.Equals(btSimSert) Then
    '        If mOpenftCek = False Then
    '            MsgBox("Informasi Barang (Aset) KIBA tidak ditemukan ", vbInformation, "Chek id")
    '            Exit Sub
    '        ElseIf picBoxSert.Image Is Nothing Then
    '            MsgBox("Image (Foto) tidak ditemukan..", vbInformation, "chek Gambar")
    '            Exit Sub
    '        ElseIf NewFileName = "" Then
    '            MsgBox("Image (Foto) tidak ditemukan..", vbInformation, "chek Gambar")
    '            Exit Sub
    '        End If

    '        com = New ClassIMG
    '        csql = "update asetIMG90.dbo.GambarKIBASert set Gambar = @photo where KIBA = @noid"
    '        If com.SimpanPhoto("kiba", IMGPath & "\" & NewFileName, KIBkd, csql) > 0 Then
    '            lbFotoSert.Enabled = True
    '            MsgBox("Foto berhasil disimpan", vbInformation)

    '            'update nmfile pada gambarkiba
    '            csql = "update asetIMG90.dbo.GambarKIBASert set nmfile='" & NewFileName & "' where kiba='" & KIBdt & "'"
    '            Me.tsLabel.Text = com.UpdatenmFile(csql)
    '        Else
    '            lbFotoSert.Enabled = False
    '            MsgBox("Foto gagal disimpan", vbInformation)
    '        End If
    '        NewFileName = ""
    '        com = Nothing

    '    ElseIf sender.Equals(btsimL) Then
    '        If mOpenftCek = False Then
    '            MsgBox("Informasi Lokasi MAP tidak ditemukan ", vbInformation, "Chek id")
    '            Exit Sub
    '        ElseIf PicBoxL.Image Is Nothing Then
    '            MsgBox("Image (Foto) tidak ditemukan..", vbInformation, "chek Gambar")
    '            Exit Sub
    '        ElseIf NewFileName = "" Then
    '            MsgBox("Image (Foto) tidak ditemukan..", vbInformation, "chek Gambar")
    '            Exit Sub
    '        End If

    '        com = New ClassIMG
    '        csql = "update asetIMG90.dbo.GambarLokasiMAP set Gambar = @photo where KIB = @noid"
    '        If com.SimpanPhoto("kibl", IMGPath & "\" & NewFileName, KIBkd, csql) > 0 Then
    '            lbFotoSert.Enabled = True
    '            MsgBox("Foto berhasil disimpan", vbInformation)

    '            'update nmfile pada gambarkiba
    '            csql = "update asetIMG90.dbo.GambarLokasiMAP set nmfile='" & NewFileName & "' where kib='" & KIBdt & "'"
    '            Me.tsLabel.Text = com.UpdatenmFile(csql)
    '        Else
    '            lbFotoSert.Enabled = False
    '            MsgBox("Foto gagal disimpan", vbInformation)
    '        End If
    '        NewFileName = ""
    '        com = Nothing

    '    End If
    'End Sub


    'PANGGIL FOTO (Download)
    'Private Sub lbft_Click(sender As Object, e As EventArgs) Handles lbFoto.Click, lbFotoSert.Click
    '    If sender.Equals(lbFoto) Then
    '        Me.picBox.Image = Nothing
    '        Application.DoEvents()

    '        If Me.picBox.Image Is Nothing Then
    '            csql1 = "select Gambar,nmFile from asetIMG90.dbo.gambarKIBA where KIBA = '" & KIBdt & "'"
    '            csql2 = "select KIBA,Gambar from asetIMG90.dbo.gambarKIBA where KIBA = @noid"
    '            'kirim untuk panggil foto
    '            com = New ClassIMG
    '            com.PanggilFoto("kiba", KIBdt, Me.picBox, csql1, csql2)
    '            com = Nothing
    '            Me.tsLabel.Text = "Memperbarui gambar"
    '        End If

    '    ElseIf sender.Equals(lbFotoSert) Then
    '        Me.picBoxSert.Image = Nothing
    '        Application.DoEvents()

    '        If Me.picBoxSert.Image Is Nothing Then
    '            csql1 = "select Gambar,nmFile from asetIMG90.dbo.gambarKIBASert where KIBA = '" & KIBdt & "'"
    '            csql2 = "select KIBA,Gambar from asetIMG90.dbo.gambarKIBASert where KIBA = @noid"
    '            'kirim untuk panggil foto
    '            com = New ClassIMG
    '            com.PanggilFoto("kiba", KIBdt, Me.picBoxSert, csql1, csql2)
    '            com = Nothing
    '            Me.tsLabel.Text = "Memperbarui gambar"
    '        End If

    '    End If
    'End Sub
    ''Tampilkan foto ke dalam picturebox

    'Me.picBoxB.Image = Nothing
    '        Application.DoEvents()

    '        If Me.picBoxB.Image Is Nothing Then
    '            csql1 = "select GambarB,nmFileB from asetIMG90.dbo.gambarKIBABatas where KIBA = '" & KIBdt & "'"
    '            csql2 = "select KIBA,GambarB from asetIMG90.dbo.gambarKIBABatas where KIBA = @noid"
    '            'kirim untuk panggil foto
    '            com = New ClassIMG
    '            com.PanggilFoto("kiba", KIBdt, Me.picBoxB, csql1, csql2)
    '            com = Nothing
    '            Me.tsLabel.Text = "Memperbarui gambar BARAT"
    'End If

    Private Sub FrmMaster2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress, cb1.KeyPress, tb4.KeyPress, tb5.KeyPress, cb2.KeyPress, cb3.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(cb1) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then cb2.Focus() : cb2.DroppedDown = True
            If sender.Equals(cb2) Then cb3.Focus() : cb3.DroppedDown = True
            If sender.Equals(cb3) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb2) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(tb5) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb2) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb3) Then cb2.Focus() : cb2.DroppedDown = True
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub

    Private Sub tb4_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown, cb1.KeyDown, tb4.KeyDown, cb2.KeyDown, tb5.KeyDown, cb3.KeyDown
        If e.Control = True And (e.KeyCode = Asc("S") Or e.KeyCode = Asc("s")) Then
            dtpro("sim")
        ElseIf e.Control = True And (e.KeyCode = Asc("D") Or e.KeyCode = Asc("d")) Then
            dtpro("hap")
        ElseIf e.Control = True And (e.KeyCode = Asc("N") Or e.KeyCode = Asc("n")) Then
            dtpro("bar")
        End If
    End Sub

    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Or mpro = "hap" Then
                Dim fotoPath As String = pt.Text
                Dim fotoBytes() As Byte = File.ReadAllBytes(fotoPath)
                Dim csql As String
                csql = "exec TokoMaster.dbo.sp_Master#3Pro '" & dttemp.ndKey & "','" & mpro & "','" & tb1.Text & "','" & cb1.Text & "','" & tb2.Text & "','" & tb4.Text & "','" & tb5.Text & "','" & cb2.Text & "','" & cb3.Text & "','" & pt.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                tb4.Text = ""
                cb1.Text = ""
                cb2.Text = ""
                tb5.Text = ""
                cb3.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub pt_Click(sender As Object, e As EventArgs) Handles pt.Click

    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Gambar"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim imgPath As String = ofd.FileName
            Dim img As Image = Image.FromFile(imgPath)
            pt.Image = img
        End If

        ofd.Dispose()
    End Sub

End Class