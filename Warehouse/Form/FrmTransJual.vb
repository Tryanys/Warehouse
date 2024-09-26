Imports System.ComponentModel
Imports Warehouse.FrmExplo

Public Class FrmTransJual
    Dim WithEvents dttemp As New tempdt2
    Dim WithEvents cpro As New msaConn
    Dim mform As Form
    Public Sub bukaform(ByVal nForm As Form, ByVal id As String)
        Me.Show()
        mform = nForm : mform.Enabled = False
        tb1.Text = id
        tampdt()
        ambilekspedisi()
    End Sub
    Private Sub tampdt()
        With dttemp
            csql = "select IdTransJual,IdEKS,IdPesanan,IdKaryawan,TglInput,Tanggal from TokoTrans..TransJual order by IdTransJual"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
            Me.lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End With
    End Sub
    Private Sub ambilekspedisi()
        cb1.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select NamaEks from TokoMaster.dbo.Ekspedisi"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb1
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("NamaEks"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub
    Private Sub FrmTransJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb1.Focus() : SendKeys.Send("{end}")
        tampdt()
    End Sub


    Private Sub FrmTransJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress,
        tb3.KeyPress, tb4.KeyPress, tb5.KeyPress, tb6.KeyPress, tb7.KeyPress, tb8.KeyPress, tb9.KeyPress, tb11.KeyPress, tb12.KeyPress, tb13.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then tb6.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb6) Then tb7.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb7) Then tb8.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb8) Then tb9.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb9) Then tb11.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb11) Then tb12.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb12) Then tb13.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb13) Then
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
            If sender.Equals(tb9) Then tb8.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb11) Then tb9.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb12) Then tb11.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb13) Then tb12.Focus() : SendKeys.Send("{end}")
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub

    Private Sub FrmTransJual_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub
    Private Sub tb4_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown,
        tb3.KeyDown, tb4.KeyDown, tb5.KeyDown, tb6.KeyDown, tb7.KeyDown, tb8.KeyDown, tb9.KeyDown, tb11.KeyDown, tb12.KeyDown, tb13.KeyDown
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
                csql = "exec TokoTrans.dbo.sp_Trans#3 '" & mpro & "','" & tb1.Text & "','" & cb1.Text & "','" & tb2.Text & "','" & tb5.Text & "','" & tb8.Text & "',  '" & tb9.Text & "',  '" & tb11.Text & "',  '" & tb10.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                tb8.Text = ""
                tb9.Text = ""
                tb11.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        Try
            tb3.Text = ""
            tb4.Text = ""
            tb5.Text = ""
            tb6.Text = ""
            tb7.Text = ""
            tb8.Text = ""
            tb9.Text = ""
            tb10.Text = ""
            csql = "select NamaPembeli,Alamat,IdBarang,NamaBarang,Satuan,JmlBrg,Diskon,Harga from tokotrans.dbo.ft_TXTJUAL('" & tb2.Text & "')"

            If tb2.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb3.Text = dt(0)
                tb4.Text = dt(1)
                tb5.Text = dt(2)
                tb6.Text = dt(3)
                tb7.Text = dt(4)
                tb8.Text = dt(5)
                tb9.Text = dt(6)
                tb10.Text = dt(7)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmcari As New FrmCari
        With frmcari
            .Text = "PESANAN"
            .Tag = "PESANAN"
            .Show()
        End With
    End Sub

    Private Sub tb10_TextChanged(sender As Object, e As EventArgs) Handles tb11.TextChanged
        Try
            tb12.Text = ""
            tb13.Text = ""
            csql = "select NamaKaryawan,Alamat from TokoMaster..Karyawan  where IdKaryawan ='" & tb11.Text & "'"

            If tb11.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb12.Text = dt(0)
                tb13.Text = dt(1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
End Class