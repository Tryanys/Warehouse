Imports System.Data.SqlClient
Imports System.IO

Module ModMain
    Public csql As String, csql1 As String, csql2 As String, itm() As String
    Public crPro As Integer = 80, IMGPath As String, DOKPath As String, sqllogin As Integer = 30, sqlDatafill As Integer = 30
    Public pHostNM As String = "", pIPLoc As String = "", pMac As String = "", jmlkolom As Integer = 0, LvKolom As String = String.Empty
    Public NamIP As String, DBName As String
    Public CUser As String, CPass As String

    Public nKey As String, nPKey As String, nSKey As String, nTkey As String

    Public Sub FileDel(ByVal FullPathfile As String)
        If FullPathfile = "" Then Exit Sub
        If (System.IO.File.Exists(FullPathfile)) Then
            My.Computer.FileSystem.DeleteFile(FullPathfile)
        End If
    End Sub

    Public Function HurufBesar(ByVal keyascii As String) As String
        HurufBesar = UCase(Chr(Asc(keyascii)))
    End Function

    Public Function BatasAngka(ByVal keyascii As String) As Integer
        BatasAngka = Asc(keyascii)
        'MsgBox(Asc(keyascii) & " " & Asc(vbBack))
        If Not (Asc(keyascii) >= Asc("0") And Asc(keyascii) <= Asc("9") Or Asc(keyascii) = Asc(vbBack) Or Asc(keyascii) = Asc("-") Or Asc(keyascii) = Asc(".") Or Asc(keyascii) = Asc(",")) Then
            BatasAngka = 0
        End If
    End Function

    Public Function BatasTanggal(ByVal keyascii As String) As Integer
        BatasTanggal = Asc(keyascii)
        'MsgBox(Asc(keyascii) & " " & Asc(vbBack))
        If Not (Asc(keyascii) >= Asc("0") And Asc(keyascii) <= Asc("9") Or Asc(keyascii) = Asc(vbBack) Or Asc(keyascii) = Asc("/") Or Asc(keyascii) = Asc("-")) Then
            BatasTanggal = 0
        End If
    End Function

    Public Function AmbilTanggalServer24() As Date
        Dim tgl As Date
        Dim db As msaConn, temptable As DataTable

        db = New msaConn
        tgl = Format(Now, "dd/MM/yyyy HH:mm:ss")
        Try
            csql = "exec tokomaster.dbo.sp_tanggal"
            temptable = db.ExecQuery(csql)
            For Each dtrow As DataRow In temptable.Rows
                tgl = Format(dtrow(0), "dd/MM/yyyy HH:mm:ss")
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "AmbilTanggalServer")
        Finally
            temptable = Nothing
            db = Nothing
        End Try
        Return tgl
    End Function

    Public Sub gantijamServer()
        Dim d As DateTime
        d = AmbilTanggalServer24()

        Try
            Microsoft.VisualBasic.TimeOfDay = d 'Your time...
            Microsoft.VisualBasic.DateString = Format(New Date(d.Year, d.Month, d.Day), "MM/dd/yyyy") 'The date...
        Catch ex As Exception
            'MsgBox("Jalankan as Administrator") 'You might have to run as Administrator...?
            Exit Sub
        End Try
    End Sub
End Module
