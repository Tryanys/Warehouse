Public Class FrmMaster4
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn
    Private Sub tampdt()
        With dttemp
            .lvTag = .ndKey
            If .ndKey = "brj" Then csql = "select IdBarang,Harga,Diskon,TglInput from TokoMaster.dbo.BarangJual order by IdBarang"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
        End With
    End Sub
    Private Sub FrmMaster4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        Label1.Text = ""
        If dttemp.ndKey = "brj" Then Label1.Text = "BARANG JUAL"

        tb1.Text = dttemp.PKey
        tb1.Focus() : SendKeys.Send("{end}")
        tampdt()
    End Sub
    Private Sub FrmMaster4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub
    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        Try
            tb2.Text = ""
            tb3.Text = ""
            tb4.Text = ""
            tb5.Text = ""
            If dttemp.ndKey = "brj" Then
                csql = "Select b.NamaBarang, b.Satuan, a.Harga, a.Diskon from TokoMaster..Barang b inner join TokoMaster..BarangJual a ON a.IdBarang = b.IdBarang where a.IdBarang ='" & tb1.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    tb3.Text = dt(2)
                Next
                If tb3.Text = "" Then
                    csql = "Select NamaBarang, Satuan from TokoMaster..Barang where IdBarang='" & tb1.Text & "'"
                End If
            End If
            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                If tb3.Text = "" Then
                    tb2.Text = dt(0)
                    tb4.Text = dt(1)
                Else
                    tb2.Text = dt(0)
                    tb4.Text = dt(1)
                    tb3.Text = dt(2)
                    tb5.Text = dt(3)
                End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Or mpro = "hap" Then
                csql = "exec TokoMaster.dbo.sp_Master#5Pro '" & dttemp.ndKey & "','" & mpro & "','" & tb1.Text & "','" & tb3.Text & "','" & tb5.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb3.Text = ""
                tb5.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub FrmMaster4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb3.KeyPress, tb5.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb3) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then tb3.Focus() : SendKeys.Send("{end}")
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub
    Private Sub tb4_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb3.KeyDown, tb5.KeyDown
        If e.Control = True And (e.KeyCode = Asc("S") Or e.KeyCode = Asc("s")) Then
            dtpro("sim")
        ElseIf e.Control = True And (e.KeyCode = Asc("D") Or e.KeyCode = Asc("d")) Then
            dtpro("hap")
        ElseIf e.Control = True And (e.KeyCode = Asc("N") Or e.KeyCode = Asc("n")) Then
            dtpro("bar")
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim frmcari As New FrmCari
        With frmcari
            .Text = "BARANG"
            .Tag = "BARANG"
            .Show()
        End With
    End Sub
End Class