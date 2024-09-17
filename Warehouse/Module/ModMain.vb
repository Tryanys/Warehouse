Module ModMain
    Public csql As String, csql1 As String, csql2 As String, itm() As String
    Public crPro As Integer = 80, IMGPath As String, DOKPath As String, sqllogin As Integer = 30, sqlDatafill As Integer = 30
    Public pHostNM As String = "", pIPLoc As String = "", pMac As String = "", jmlkolom As Integer = 0, LvKolom As String = String.Empty

    Public nKey As String, nPKey As String, nSKey As String, nTkey As String


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
End Module
