Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports System.IO
Imports QRCoder

Public Class ClassIMG
    Dim db As msaConn, temptable As DataTable, csql As String

    Public Function QRgenSaveimage(kd As String) As String
        Dim nmfile As String = Replace(kd, ".", "") & "QR.bmp"
        Dim qr As New QRCodeGenerator
        Dim dt = qr.CreateQrCode(kd, QRCodeGenerator.ECCLevel.Q)
        Dim cd As New QRCode(dt)
        Dim bmp As Bitmap = cd.GetGraphic(6)
        bmp.Save(IMGPath & "\" & nmfile)
        Application.DoEvents()
        Return (IMGPath & "\" & nmfile)
    End Function

    Public Sub GenQR_Code(ByVal pic As PictureBox, ByVal kd As String)
        Dim qr As New QRCodeGenerator
        Dim data = qr.CreateQrCode(kd, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        pic.Image = code.GetGraphic(6)
        Dim bmp As Bitmap = code.GetGraphic(6)
        qr = Nothing
    End Sub

    Public Sub ResizeImages(ByVal FileName, ByVal NewFileName, ByVal maxWidth, ByVal maxHeight, ByVal uploadDir, ByVal qualityPercent)
        Dim originalImg As System.Drawing.Image = System.Drawing.Image.FromFile(uploadDir & "\" & FileName)

        Dim aspectRatio As Double
        Dim newHeight As Integer
        Dim newWidth As Integer

        '*** Calculate Size ***'
        If originalImg.Width > maxWidth Or originalImg.Height > maxHeight Then
            If originalImg.Width >= originalImg.Height Then ' image is wider than tall
                newWidth = maxWidth
                aspectRatio = originalImg.Width / maxWidth
                newHeight = originalImg.Height / aspectRatio
            Else ' image is taller than wide
                newHeight = maxHeight
                aspectRatio = originalImg.Height / maxHeight
                newWidth = originalImg.Width / aspectRatio
            End If
        Else ' if image is not larger than max then keep original size
            newWidth = originalImg.Width
            newHeight = originalImg.Height
        End If

        Dim newImg As New Bitmap(originalImg, CInt(newWidth), CInt(newHeight)) '' blank canvas
        Dim canvas As Graphics = Graphics.FromImage(newImg) 'graphics element

        '*** compress ***'
        Dim myEncoderParameters As EncoderParameters
        myEncoderParameters = New EncoderParameters(1)
        ' set quality level based on "resolution" variable
        Dim myEncoderParameter = New EncoderParameter(System.Drawing.Imaging.Encoder.Quality, CType(qualityPercent, Int32))
        myEncoderParameters.Param(0) = myEncoderParameter

        '*** Save As  ***'
        canvas.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
        canvas.DrawImage(newImg, New Point(0, 0))
        newImg.Save(IMGPath & "\" & NewFileName, getCodec("image/jpeg"), myEncoderParameters)

        '*** Close ***'
        originalImg.Dispose()
        newImg.Dispose()
        '*** Nothing ***'
        newImg = Nothing
        originalImg = Nothing
    End Sub

    Public Sub VaryQualityLevel(ByVal nPath As String, ByVal nFile As String, ByVal nQuaLev As Byte)
        ' Get a bitmap. The Using statement ensures objects  
        ' are automatically disposed from memory after use.  
        Using bmp1 As New Bitmap(nPath & "\" & nFile)
            Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

            ' Create an Encoder object based on the GUID  
            ' for the Quality parameter category.  
            Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

            ' Create an EncoderParameters object.  
            ' An EncoderParameters object has an array of EncoderParameter  
            ' objects. In this case, there is only one  
            ' EncoderParameter object in the array.  
            Dim myEncoderParameters As New EncoderParameters(1)

            '-- masukkan hasil ke folder default penampung file image
            Dim myEncoderParameter As New EncoderParameter(myEncoder, 50L)
            myEncoderParameters.Param(0) = myEncoderParameter
            bmp1.Save(IMGPath & "\c_" & nFile, jpgEncoder, myEncoderParameters)

            'myEncoderParameter = New EncoderParameter(myEncoder, 100L)
            'myEncoderParameters.Param(0) = myEncoderParameter
            'bmp1.Save("C:\test\TestPhotoQualityHundred.jpg", jpgEncoder, myEncoderParameters)

            '' Save the bitmap as a JPG file with zero quality level compression.  
            'myEncoderParameter = New EncoderParameter(myEncoder, 0L)
            'myEncoderParameters.Param(0) = myEncoderParameter
            'bmp1.Save("C:\test\TestPhotoQualityZero.jpg", jpgEncoder, myEncoderParameters)
        End Using
    End Sub
    Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()
        Dim codec As ImageCodecInfo
        For Each codec In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next codec
        Return Nothing
    End Function

    Private Function getCodec(ByVal getThis) As Drawing.Imaging.ImageCodecInfo
        Dim output As Drawing.Imaging.ImageCodecInfo = Nothing
        Dim codecs As Imaging.ImageCodecInfo() = Imaging.ImageCodecInfo.GetImageEncoders
        For Each codec As Imaging.ImageCodecInfo In codecs
            If codec.MimeType = getThis Then
                output = codec
            End If
        Next codec
        Return output
    End Function

    ' update file ditambahkan untuk simAset
    Public Function UpdatenmFile(ByVal csql As String) As String
        Dim nmSta As String = ""
        Try
            db = New msaConn
            If db.ExecNonQuery(csql) > 0 Then
                nmSta = "NameFile Update "
            Else
                MsgBox("Update namaFile Gagal hubungi Administrator", vbInformation, "Chek ID")
            End If
            db = Nothing
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Check ID ")
        End Try
        Return nmSta
    End Function

    Public Function HapusFileimg(ByVal picbox As PictureBox, ByVal csql As String) As String
        Dim nmSta As String = ""
        db = New msaConn
        Dim vb = MsgBox("Benar akan dihapus", vbYesNo, "Validasi")
        If vb = vbNo Then GoTo sls
        Try
            If db.ExecNonQuery(csql) > 0 Then
                nmSta = "ok"
                picbox.ImageLocation = Nothing
                FileDel(picbox.Tag)
            Else
                MsgBox("Hapus foto gagal", vbInformation, "Hapus Foto")
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Hapus Foto")
        Finally
            db = Nothing
        End Try
sls:
        HapusFileimg = nmSta
    End Function


    Public Function SimpanPhoto(ByVal MeTag As String, ByVal filePath As String, ByVal Pkey As String, ByVal csql As String) As Integer
        'StartTiming()
        Dim stream As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(stream)
        Dim photo() As Byte = reader.ReadBytes(stream.Length)
        Dim con As String = String.Empty, Rval As Integer
        Dim itm() As String = Split(Pkey, "!")
        con = "Data Source=" & NamIP & ";Initial Catalog=" & DBName & ";User ID=" & CUser & ";Password=" & CPass & "" ';Integrated Security=yes"

        Cursor.Current = Cursors.AppStarting
        Dim fotocon As SqlConnection = New SqlConnection(con)
        Dim fotoComm As SqlCommand = New SqlCommand(csql, fotocon)
        Try
            Cursor.Current = Cursors.WaitCursor
            Select Case MeTag
                Case "kiba", "kibb", "kibc", "kibd", "kibe", "kibf", "kibbx", "kibcx", "kibdx", "kibex", "kibl", "krw"
                    fotoComm.Parameters.Add("@noid", SqlDbType.VarChar, 65).Value = Pkey
                    fotoComm.Parameters.Add("@photo", SqlDbType.Image, photo.Length).Value = photo
                Case "kibcl", "kibcrg"
                    fotoComm.Parameters.Add("@noid", SqlDbType.VarChar, 75).Value = Pkey
                    fotoComm.Parameters.Add("@photo", SqlDbType.Image, photo.Length).Value = photo
                Case "peg"
                    fotoComm.Parameters.Add("@noid", SqlDbType.VarChar, 20).Value = Pkey
                    fotoComm.Parameters.Add("@photo", SqlDbType.Image, photo.Length).Value = photo
                Case "kddpa", "idpbaru"
                    fotoComm.Parameters.Add("@noid", SqlDbType.VarChar, 50).Value = Pkey
                    fotoComm.Parameters.Add("@photo", SqlDbType.Image, photo.Length).Value = photo
                Case "RekonFile"
                    fotoComm.Parameters.Add("@noid", SqlDbType.VarChar, 50).Value = Pkey
                    fotoComm.Parameters.Add("@photo", SqlDbType.Image, photo.Length).Value = photo
                Case "MutasiSKPDat", "KorekSalMin", "ReklasBarang", "ReklasBarangPLH" _
                    , "MutBrgPel", "PbukuAL", "KIBAsertFile", "PengamananKibBFile", "RKBMDkebBaruFile" _
                    , "RKBMDPerPenPemFile", "RKBMDPenPemFile", "RKBMDPkebBaruFile", "MutasiSKPDXFile" _
                    , "PtTGRfile", "PtTGRnonFile", "PesanFile", "PbukuATFile", "KorKurALFile", "PenghapusanALFile"
                    fotoComm.Parameters.Add("@KIB", SqlDbType.VarChar, 70).Value = Pkey
                    fotoComm.Parameters.Add("@PDF", SqlDbType.Image, photo.Length).Value = photo
            End Select

            fotocon.Open()
            Rval = fotoComm.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "SimpanPhoto")
        Finally
            Cursor.Current = Cursors.Default
            reader.Close()
            stream.Close()
            fotocon.Close()
            fotoComm = Nothing
            fotocon = Nothing
        End Try
        Return Rval
        Exit Function
        'StopTiming()
    End Function

    Public Sub PanggilFoto(ByVal meTag As String, ByVal Pkey As String, ByVal PictBox As PictureBox, ByVal csql1 As String, ByVal csql2 As String)
        'StartTiming()
        ' Assumes that connection is a valid SqlConnection object.
        Dim temptable As DataTable, db As msaConn
        Dim stream As FileStream = Nothing
        Dim Writer As BinaryWriter
        Dim bufferSize As Integer = 1000
        Dim outByte(bufferSize - 1) As Byte
        Dim startIndex As Long = 0
        Dim con As String = "Data Source=" & NamIP & ";Initial Catalog=" & DBName & ";User ID=" & CUser & ";Password=" & CPass & "" ';Integrated Security=yes"
        Dim nmFile As String = ""
        Dim Rval As Integer, foto As String = String.Empty, FileName As String = String.Empty
        Cursor.Current = Cursors.AppStarting

        db = New msaConn
        'chek data image
        temptable = db.ExecQuery(csql1)
        For Each dt As DataRow In temptable.Rows
            If IsDBNull(dt(0)) = True Then
                db = Nothing
                Exit Sub
            Else
                nmFile = dt(1)
            End If
        Next

        If meTag <> "df" Then PictBox.ImageLocation = Nothing
        Dim fotocon As SqlConnection = New SqlConnection(con)
        Dim fotoComm As SqlCommand = New SqlCommand(csql2, fotocon)
        Select Case meTag
            Case "kiba", "kibb", "kibc", "kibd", "kibe", "kibf", "kibbx", "kibcx", "kibdx", "kibex", "kibl", "df", "krw"
                fotoComm.Parameters.Add("@noid", SqlDbType.VarChar, 65).Value = Pkey
            Case "kibcl", "kibcrg"
                fotoComm.Parameters.Add("@noid", SqlDbType.VarChar, 75).Value = Pkey
            Case "peg"
                fotoComm.Parameters.Add("@noid", SqlDbType.VarChar, 20).Value = Pkey
        End Select

        Try
            Cursor.Current = Cursors.WaitCursor
            fotocon.Open()
            'Rval = fotoComm.ExecuteNonQuery
            Dim reader As SqlDataReader = fotoComm.ExecuteReader(CommandBehavior.SequentialAccess)
            Do While reader.Read()
                ' Get the publisher id, which must occur before getting the logo.
                foto = reader.GetString(0)

                ' Create a file to hold the output.
                If meTag = "df" Then
                    stream = New FileStream(DOKPath & "\" & nmFile, FileMode.OpenOrCreate, FileAccess.Write)
                Else
                    stream = New FileStream(IMGPath & "\" & nmFile, FileMode.OpenOrCreate, FileAccess.Write)
                End If

                Writer = New BinaryWriter(stream)

                ' Reset the starting byte for a new BLOB.
                startIndex = 0

                ' Read bytes into outByte() and retain the number of bytes returned.
                Rval = reader.GetBytes(1, startIndex, outByte, 0, bufferSize)

                ' Continue while there are bytes beyond the size of the buffer.
                Do While Rval = bufferSize
                    Writer.Write(outByte)
                    Writer.Flush()

                    ' Reposition start index to end of the last buffer and fill buffer.
                    startIndex += bufferSize
                    Rval = reader.GetBytes(1, startIndex, outByte, 0, bufferSize)
                Loop

                ' Write the remaining buffer.
                If Rval > 0 Then Writer.Write(outByte, 0, Rval - 1)
                Writer.Flush()

                ' Close the output file.
                Writer.Close()
                stream.Close()
                If meTag <> "df" Then
                    PictBox.Tag = IMGPath & "\" & nmFile
                    PictBox.ImageLocation = PictBox.Tag 'Application.StartupPath & "\" & Pkey & ".JPG"
                End If
            Loop
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "PanggilFoto")
        Finally
            'Writer.Close()
            'stream.Close()
            Cursor.Current = Cursors.Default
            fotocon.Close()
            fotoComm = Nothing
            fotocon = Nothing
        End Try
        'StopTiming()
    End Sub


End Class

