Public Class FrmMaster
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn
    Private Sub FrmMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        lb1.Text = ""
        If dttemp.ndKey = "pro" Then lb1.Text = "PROPINSI"
        If dttemp.ndKey = "jen" Then lb1.Text = "JENIS BARANG"
        If dttemp.ndKey = "tgd" Then
            lb1.Text = "TAG"
            label1.Text = "TAG"
        End If
        If dttemp.ndKey = "tga" Then
            lb1.Text = "TAG AKSES"
            label1.Text = "Akses"
        End If
        tb1.Text = dttemp.PKey
        tb1.Focus() : SendKeys.Send("{end}")
    End Sub
    Private Sub FrmMaster_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub

    Private Sub tb1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb2) Then tb1.Focus() : SendKeys.Send("{end}")
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub

    Private Sub tb1_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown
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
                csql = "exec TokoMaster.dbo.sp_Master#1Pro '" & dttemp.ndKey & "','" & mpro & "','" & tb1.Text & "','','','" & tb2.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = " "
                tb2.Text = " "
                dttemp.PKey = ""
                tb1.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        Try

            tb2.Text = ""
            If dttemp.ndKey = "pro" Then
                csql = "select Keterangan from TokoMaster.dbo.WILPROV where ProvID='" & tb1.Text & "'"
            ElseIf dttemp.ndKey = "jen" Then
                csql = "select Keterangan from TokoMaster.dbo.JenisBarang where Jenis='" & tb1.Text & "'"
            ElseIf dttemp.ndKey = "tgd" Then
                csql = "select KetTag from TokoMaster.dbo.TAG where TAG='" & tb1.Text & "'"
            ElseIf dttemp.ndKey = "tga" Then
                csql = "select AksesKet from TokoMaster.dbo.AksesTag where Akses='" & tb1.Text & "'"
            ElseIf dttemp.ndKey = "kab" Then
                csql = "select Keterangan from TokoMaster.dbo.WILKAB where KabID='" & tb1.Text & "'"
            ElseIf dttemp.ndKey = "kec" Then
                csql = "select Keterangan from TokoMaster.dbo.WILKEC where KecID='" & tb1.Text & "'"
            End If
            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb2.Text = dt(0)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
End Class