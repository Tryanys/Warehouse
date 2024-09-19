Public Class FrmTerima
    Dim WithEvents dttemp As New tempdt2
    Dim WithEvents cpro As New msaConn
    Dim mform As Form
    Private Sub tampdt()
        With dttemp
            csql = "select IdBarang,IdGudang,Harga,Diskon,Stok,Keterangan from TokoTrans..ft_CekStok('" & tb4.Text & "')"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
            Me.lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End With
    End Sub
    Public Sub bukaform(ByVal nForm As Form, ByVal id As String)
        Me.Show()
        mform = nForm : mform.Enabled = False
        tb1.Text = id
        tb1.Focus() : SendKeys.Send("{end}")
        tampdt()
    End Sub
    Private Sub FrmTerima_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        Try
            csql = "select NamaPembeli,Alamat,IdBarang,NamaBarang,Satuan,JmlBrg,Harga,Status from TokoTrans.dbo.ft_TCTerima('" & tb1.Text & "')"

            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb2.Text = dt(0)
                tb3.Text = dt(1)
                tb4.Text = dt(2)
                tb5.Text = dt(3)
                tb6.Text = dt(4)
                tb7.Text = dt(5)
                tb8.Text = dt(6)
                cb1.Text = dt(7)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Or mpro = "hap" Then
                csql = "exec TokoTrans.dbo.sp_Trans#2 '" & mpro & "','" & tb1.Text & "',''  , '','',  '" & cb1.Text & "',  '',  ''"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                cb1.Text = ""
                tb8.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub FrmTerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress,
        tb3.KeyPress, cb1.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(cb1) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb2) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb1) Then tb3.Focus() : cb1.DroppedDown = True
        End If
        e.KeyChar = HurufBesar(e.KeyChar)

    End Sub
End Class