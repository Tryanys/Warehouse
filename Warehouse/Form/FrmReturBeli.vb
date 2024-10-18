Public Class FrmReturBeli
    Dim WithEvents dtempt As New tempdt
    Dim WithEvents cpro As New msaConn
    Dim mform As Form
    Public Sub bukaform(ByVal nForm As Form, ByVal id As String)
        Me.Show()
        mform = nForm : mform.Enabled = False
        'tb1.Text = id
        tb1.Focus() : SendKeys.Send("{end}")
        If dtempt.ndKey = "rb" Then tb9.Enabled = False : tb10.Enabled = False
    End Sub
    Private Sub tampdt()
        With dtempt
            If .ndKey = "rb" Then csql = "select IdKaryawan,TglInput,IdRetur,Tanggal,Keterangan from TokoTrans.dbo.ReturBeli order by IdKaryawan"
            If .ndKey = "rp" Then csql = "select IdKaryawan,TglInput,IdPen,Tanggal,Keterangan from TokoTrans.dbo.ReturPen order by IdKaryawan"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
            Me.lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End With
    End Sub

    Private Sub FrmReturBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress,
        tb3.KeyPress, tb4.KeyPress, tb5.KeyPress, tb6.KeyPress, tb7.KeyPress, tb8.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then tb6.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb6) Then tb7.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb7) Then tb8.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb8) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb2) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb6) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb7) Then tb6.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb8) Then tb7.Focus() : SendKeys.Send("{end}")
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub
    Private Sub tb4_TextChanged(sender As Object, e As EventArgs) Handles tb4.TextChanged
        Try
            tb5.Text = ""
            tb6.Text = ""
            csql = "select NamaBarang,Satuan from TokoMaster.dbo.Barang where IdBarang='" & tb4.Text & "'"

            If tb4.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb5.Text = dt(0)
                tb6.Text = dt(1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        Try
            tb3.Text = ""
            csql = "select NamaKaryawan from TokoMaster.dbo.Karyawan where IdKaryawan='" & tb2.Text & "'"

            If tb2.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb3.Text = dt(0)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub FrmReturBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb1.Focus() : SendKeys.Send("{end}")
        tampdt()
    End Sub

    Private Sub tb4_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown,
        tb3.KeyDown, tb4.KeyDown, tb5.KeyDown, tb6.KeyDown, tb7.KeyDown, tb8.KeyDown
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
            If dtempt.ndKey = "rb" Then
                If mpro = "sim" Or mpro = "hap" Then
                    csql = "exec TokoTrans.dbo.sp_ReturBeli_Pro '" & mpro & "','" & tb2.Text & "','','" & dtp1.Text & "','" & tb8.Text & "'"
                    For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                        MsgBox(dt("Ket"), vbInformation, "Cek Err")
                    Next
                    csql = "exec TokoTrans.dbo.sp_ReturBeliDet_Pro '" & mpro & "','','" & tb1.Text & "','" & tb4.Text & "','" & tb7.Text & "'"
                    For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                        MsgBox(dt("Ket"), vbInformation, "Cek Err")
                    Next
                    dtpro("bar")
                End If
            ElseIf dtempt.ndKey = "rp" Then
                If mpro = "sim" Or mpro = "hap" Then
                    csql = "exec TokoTrans.dbo.sp_ReturTerima_Pro '" & mpro & "','" & tb2.Text & "','','" & dtp1.Text & "','" & tb8.Text & "'"
                    For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                        MsgBox(dt("Ket"), vbInformation, "Cek Err")
                    Next
                    csql = "exec TokoTrans.dbo.sp_ReturTerimaDet_Pro '" & mpro & "','','" & tb1.Text & "','" & tb4.Text & "','" & tb7.Text & "','" & tb9.Text & "','" & tb10.Text & "'"
                    For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                        MsgBox(dt("Ket"), vbInformation, "Cek Err")
                    Next
                    dtpro("bar")
                End If
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                tb3.Text = ""
                tb4.Text = ""
                tb5.Text = ""
                tb6.Text = ""
                tb7.Text = ""
                tb8.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub FrmTransBeli_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mform.Enabled = True
    End Sub

End Class