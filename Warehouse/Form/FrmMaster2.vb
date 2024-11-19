Imports System.Data.SqlClient
Imports System.IO

Public Class FrmMaster2
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn
    Dim com As ClassIMG
    Dim FileName As String = "", NewFileName As String = ""
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
        'Dim img() As Byte
        Try

            tb2.Text = ""
            tb4.Text = ""
            tb5.Text = ""
            cb1.Text = ""
            cb2.Text = ""
            cb3.Text = ""
            pt.Image = Nothing
            If dttemp.ndKey = "krw" Then
                csql = "Select a.NamaKaryawan, b.Keterangan, a.Alamat, a.NoTelp, a.TAG, a.Akses  from TokoMaster..Karyawan a inner join TokoMaster..WILKEC b ON a.KecID = b.kecID where IdKaryawan ='" & tb1.Text & "'"
            End If
            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb2.Text = dt(0)
                cb1.Text = dt(1)
                tb4.Text = dt(2)
                tb5.Text = dt(3)
                cb2.Text = dt(4)
                cb3.Text = dt(5)
                'img = dt(6)
                'Dim ms As New MemoryStream(img)
                'pt.Image = Image.FromStream(ms)
                'Tampilkan foto ke dalam picturebox
                Application.DoEvents()

                If Me.pt.Image Is Nothing Then
                    csql1 = "select Gambar,nmFile from TokoIMG.dbo.gambarKaryawan where id = '" & tb1.Text & "'"
                    csql2 = "select id,Gambar from TokoIMG.dbo.gambarKaryawan where id = @noid"
                    'kirim untuk panggil foto
                    com = New ClassIMG
                    com.PanggilFoto("krw", tb1.Text, Me.pt, csql1, csql2)
                    com = Nothing
                    'Me.lbNot.Text = "Memperbarui gambar BARAT"
                End If

            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub


    Private Sub btSim_Click(sender As Object, e As EventArgs) Handles btSim.Click 'simpan foto semua tombol ini
        Dim nmFile As String = "", nmFullFile As String = ""
        'SIMPAN FOTO
        If pt.Image Is Nothing Then
            MsgBox("Image (Foto) tidak ditemukan..", vbInformation, "chek Gambar")
            Exit Sub
        ElseIf NewFileName = "" Then
            MsgBox("Pembaharuan tidak ditemukan..", vbInformation, "chek Gambar")
            Exit Sub

        End If

        com = New ClassIMG
        csql = "update TokoIMG.dbo.GambarKaryawan set Gambar = @photo where id = @noid"
        If com.SimpanPhoto("krw", IMGPath & "\" & NewFileName, tb1.Text, csql) > 0 Then
            lbFoto.Enabled = True
            MsgBox("Foto berhasil disimpan", vbInformation)

            'update nmfile pada gambarkiba
            csql = "update TokoIMG.dbo.gambarKaryawan set nmfile='" & NewFileName & "' where id='" & tb1.Text & "'"
            Me.lbNot.Text = com.UpdatenmFile(csql)
        Else
            lbFoto.Enabled = False
            MsgBox("Foto gagal disimpan", vbInformation)
        End If
        NewFileName = ""
        com = Nothing
    End Sub


    'PANGGIL FOTO (Download)
    Private Sub lbft_Click(sender As Object, e As EventArgs) Handles lbFoto.Click
        If sender.Equals(lbFoto) Then
            Me.pt.Image = Nothing
            Application.DoEvents()

            If Me.pt.Image Is Nothing Then
                csql1 = "select Gambar,nmFile from TokoIMG.dbo.gambarKaryawan where id = '" & tb1.Text & "'"
                csql2 = "select id,Gambar from TokoIMG.dbo.gambarKaryawan where id = @noid"
                'kirim untuk panggil foto
                com = New ClassIMG
                com.PanggilFoto("krw", tb1.Text, Me.pt, csql1, csql2)
                com = Nothing
                'Me.lbNot.Text = "Memperbarui gambar"
            End If

        End If
    End Sub


    ''open file dialog

    Private Sub dtOpen(ByVal dtPkey As String, ByVal pcBOX As PictureBox, ByVal nmObjft As String)
        Dim OpenFileDialog As New OpenFileDialog
        Dim FullPath As String = ""
        'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "JPEG Files (*.JPG)|*.JPG|BMP Files (*.BMP)|*.BMP|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            FileName = OpenFileDialog.FileName
            Dim nf() As String = Split(FileName, "\")
            nf = Split(nf(nf.GetUpperBound(0)), ".")
            NewFileName = Replace(dtPkey, ".", "") & nmObjft & "." & nf(1) 'nf(nf.GetUpperBound(0))
            FileDel(IMGPath & "\" & NewFileName) 'hapus file
            ' TODO: Add code here to open the file.
            FullPath = OpenFileDialog.FileName
            nFile = System.IO.Path.GetFileName(FullPath)
            nPath = System.IO.Path.GetDirectoryName(FullPath)
            nroot = System.IO.Path.GetPathRoot(FullPath)

            com = New ClassIMG
            com.ResizeImages(nFile, NewFileName, pcBOX.Width * 4, pcBOX.Height * 4, nPath, crPro) 'lakukan rezise pada file asal
            com = Nothing

            pcBOX.Tag = IMGPath & "\" & NewFileName
            pcBOX.ImageLocation = pcBOX.Tag '   'FullPath
        End If
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        'Dim ofd As New OpenFileDialog
        'ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        'ofd.Title = "Pilih Gambar"

        'If ofd.ShowDialog() = DialogResult.OK Then
        '    Dim imgPath As String = ofd.FileName
        '    Dim img As Image = Image.FromFile(imgPath)
        '    pt.Image = img
        'End If

        'ofd.Dispose()

        ''panggil nya
        dtOpen(tb2.Text, pt, "M")
    End Sub

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

End Class