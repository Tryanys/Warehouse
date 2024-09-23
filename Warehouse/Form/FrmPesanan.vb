Imports System.ComponentModel
Imports Warehouse.FrmExplo

Public Class FrmPesanan
    Dim WithEvents dttemp As New tempdt2
    Dim WithEvents cpro As New msaConn
    Dim mform As Form

    Public Sub bukaform(ByVal nForm As Form, ByVal id As String)
        Me.Show()
        mform = nForm : mform.Enabled = False
        tb1.Text = id
        tb1.Focus() : SendKeys.Send("{end}")
        tampdt()
    End Sub
    Private Sub tampdt()
        With dttemp
            csql = "select IdPesanan,IdPembeli,IdBarang,JmlBrg,Status from TokoTrans..Pesanan order by IdPesanan"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
            Me.lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End With
    End Sub

    Private Sub FrmPesanan_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
            tb6.Text = ""
            tb7.Text = ""
            tb8.Text = ""
            tb9.Text = ""
            csql = "select a.IdBarang,c.NamaBarang,c.Satuan, b.IdPembeli,b.NamaPembeli,b.Alamat,a.JmlBrg,d.Harga from TokoTrans..Pesanan a 
	                    inner join TokoMaster..Pembeli b on a.IdPembeli=b.IdPembeli
	                    inner join TokoMaster..Barang c on a.IdBarang=c.IdBarang
	                    inner join TokoMaster..BarangJual d on a.IdBarang=d.IdBarang where IdPesanan ='" & tb1.Text & "'"

            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb2.Text = dt(0)
                tb3.Text = dt(1)
                tb4.Text = dt(2)
                tb5.Text = dt(3)
                tb6.Text = dt(4)
                tb7.Text = dt(5)
                tb8.Text = dt(6)
                tb9.Text = dt(7)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        Try
            tb3.Text = ""
            tb4.Text = ""
            tb9.Text = ""
            csql = "select a.NamaBarang, a.Satuan, b.Harga from TokoMaster..Barang a 
	                    inner join TokoMaster..BarangJual b on a.IdBarang=b.IdBarang where b.IdBarang ='" & tb2.Text & "'"

            If tb2.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb3.Text = dt(0)
                tb4.Text = dt(1)
                tb9.Text = dt(2)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub FrmPesanan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress, tb3.KeyPress, tb4.KeyPress, tb5.KeyPress, tb6.KeyPress, tb7.KeyPress,
            tb8.KeyPress, tb9.KeyPress
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
    Private Sub tb4_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown,
    tb3.KeyDown, tb4.KeyDown, tb5.KeyDown, tb6.KeyDown, tb7.KeyDown, tb8.KeyDown, tb9.KeyDown
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
                csql = "exec TokoTrans.dbo.sp_Trans#2 '" & mpro & "','" & tb1.Text & "','" & tb5.Text & "',  '" & tb2.Text & "',  '" & tb8.Text & "','','',''"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                tb8.Text = ""
                tb9.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub tb5_TextChanged(sender As Object, e As EventArgs) Handles tb5.TextChanged
        Try
            tb6.Text = ""
            tb7.Text = ""
            csql = "select NamaPembeli, Alamat from TokoMaster..Pembeli where IdPembeli = '" & tb5.Text & "'"

            If tb5.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb6.Text = dt(0)
                tb7.Text = dt(1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim frmcari As New FrmCari
        With frmcari
            .Text = "BARANG JUAL"
            .Tag = "BARANG JUAL"
            .Show()
        End With
    End Sub

    Private Sub FrmPesanan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mform.Enabled = True
    End Sub

    Private Sub FrmPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class