Imports System.ComponentModel
Imports Warehouse

Public Class FrmTransBeli
    Dim WithEvents dtempt As New tempdt
    Dim WithEvents cpro As New msaConn
    Dim mform As Form

    Public Sub bukaform(ByVal nForm As Form, ByVal id As String)
        Me.Show()
        mform = nForm : mform.Enabled = False
        tb1.Text = id
        tampdt()
        ambilkaryawan()
        ambilGudang()
        tb2.Focus() : SendKeys.Send("{end}")
    End Sub



    Private Sub tampdt()
        Try
            csql = "select * from TokoTrans..TransBeli order by IdTransBeli"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
            Me.lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ambilkaryawan()
        cb2.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select Namakaryawan from TokoMaster.dbo.Karyawan"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb2
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("Namakaryawan"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub
    Private Sub ambilGudang()
        cb1.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select NamaGudang from TokoMaster.dbo.Gudang"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb1
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("NamaGudang"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub
    Private Sub tb4_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, cb1.KeyDown, cb2.KeyDown, tb2.KeyDown,
        tb3.KeyDown, tb4.KeyDown, tb5.KeyDown, tb6.KeyDown, tb7.KeyDown, tb8.KeyDown, tb9.KeyDown, tb10.KeyDown
        If e.Control = True And (e.KeyCode = Asc("S") Or e.KeyCode = Asc("s")) Then
            dtpro("sim")
        ElseIf e.Control = True And (e.KeyCode = Asc("D") Or e.KeyCode = Asc("d")) Then
            dtpro("hap")
        ElseIf e.Control = True And (e.KeyCode = Asc("N") Or e.KeyCode = Asc("n")) Then
            dtpro("bar")
        End If
    End Sub
    Private Sub FrmTransBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, cb1.KeyPress, cb2.KeyPress, tb2.KeyPress,
        tb3.KeyPress, tb4.KeyPress, tb5.KeyPress, tb6.KeyPress, tb7.KeyPress, tb8.KeyPress, tb9.KeyPress, tb10.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(cb1) Then cb2.Focus() : cb2.DroppedDown = True
            If sender.Equals(cb2) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then tb6.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb6) Then tb7.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb7) Then tb8.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb8) Then tb9.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb9) Then tb10.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb10) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(cb1) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb2) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(tb2) Then cb2.Focus() : cb2.DroppedDown = True
            If sender.Equals(tb3) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb6) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb7) Then tb6.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb8) Then tb7.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb9) Then tb8.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb10) Then tb9.Focus() : SendKeys.Send("{end}")
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub

    Private Sub FrmTransBeli_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmUtama.Enabled = True
        dtempt = Nothing
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
            tb10.Text = ""
            dtp1.Text = ""
            cb1.Text = ""
            cb2.Text = ""
            csql = "select b.NamaGudang,c.NamaKaryawan,d.IdSuplier,d.NamaSuplier,d.Alamat,e.IdBarang,f.NamaBarang,f.Satuan,g.Jumlah,g.Harga,g.Diskon,h.TglExp from TokoTrans..TransBeli a
	                    inner join TokoMaster..Gudang b on a.IdGudang=b.IdGudang
	                    inner join TokoMaster..Karyawan c on a.IdKaryawan=c.IdKaryawan
	                    inner join TokoMaster..Supplier d on a.IdSuplier=d.IdSuplier
	                    inner join TokoMaster..GudangHrg e on a.IdGudang=e.IdGudang
	                    inner join TokoMaster..Barang f on e.IdBarang=f.IdBarang 
					    inner join TokoTrans..TransBeliDet g on a.IdTransBeli=g.IdTransBeli 
						inner join TokoMaster..GudangHrg h on a.IdTransBeli=h.IdTransBeli where a.IdTransBeli ='" & tb1.Text & "'"

            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                cb1.Text = dt(0)
                cb2.Text = dt(1)
                tb2.Text = dt(2)
                tb3.Text = dt(3)
                tb4.Text = dt(4)
                tb5.Text = dt(5)
                tb6.Text = dt(6)
                tb7.Text = dt(7)
                tb8.Text = dt(8)
                tb9.Text = dt(9)
                tb10.Text = dt(10)
                dtp1.Text = dt(11)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        Try
            csql = "select NamaSuplier,Alamat from TokoMaster.dbo.Supplier where IdSuplier='" & tb2.Text & "'"

            If tb2.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb3.Text = dt(0)
                tb4.Text = dt(1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub
    Private Sub tb5_TextChanged(sender As Object, e As EventArgs) Handles tb5.TextChanged
        Try
            csql = "select NamaBarang,Satuan from TokoMaster.dbo.Barang where IdBarang='" & tb5.Text & "'"

            If tb5.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb6.Text = dt(0)
                tb7.Text = dt(1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Or mpro = "hap" Then
                csql = "exec TokoTrans.dbo.sp_Trans#1 '" & mpro & "','" & tb1.Text & "','" & tb2.Text & "',  '" & cb2.Text & "',  '" & cb1.Text & "','" & tb8.Text & "',  '" & tb9.Text & "',  '" & tb10.Text & "',  '" & tb5.Text & "','" & dtp1.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                cb1.Text = ""
                cb2.Text = ""
                tb8.Text = ""
                tb9.Text = ""
                tb10.Text = ""
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