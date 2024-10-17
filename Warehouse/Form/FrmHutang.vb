Imports System.ComponentModel

Public Class FrmHutang
    Dim WithEvents dtempt As New tempdt
    Dim WithEvents cpro As New msaConn
    Dim mform As Form

    Public Sub bukaform(ByVal nForm As Form, ByVal id As String)
        Me.Show()
        mform = nForm : mform.Enabled = False
        'tb1.Text = id
        tb1.Focus() : SendKeys.Send("{end}")
        ambilkaryawan()
        tampdt()
    End Sub

    Private Sub tampdt()
        Try
            If dtempt.ndKey = "byr" Then
                csql = "select * from TokoTrans..ByrHutang"
            ElseIf dtempt.ndKey = "bpt" Then
                csql = "select * from TokoTrans..ByrPiutang"
            End If

            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
            Me.lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ambilkaryawan()
        cb1.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select Namakaryawan from TokoMaster.dbo.Karyawan"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb1
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
    Private Sub FrmHutang_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmUtama.Enabled = True
        dtempt = Nothing
        cpro = Nothing
    End Sub

    Private Sub FrmHutang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress,
        cb1.KeyPress, tb3.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(cb1) Then tb3.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then
                'simpan
                'dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb2) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb3) Then cb1.Focus() : cb1.DroppedDown = True
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub
    Private Sub dtpro(ByVal mpro As String)
        Try
            If mpro = "sim" Or mpro = "hap" Then
                If dtempt.ndKey = "byr" Then
                    csql = "exec TokoTrans.dbo.sp_byrHutang_Pro '" & mpro & "','" & cb1.Text & "','" & tb1.Text & "',  '" & tb2.Text & "', '" & tb3.Text & "','','" & dtp1.Text & "',''"
                ElseIf dtempt.ndKey = "bpt" Then
                    csql = "exec TokoTrans.dbo.sp_byrPiutang_Pro '" & mpro & "','" & cb1.Text & "','" & tb1.Text & "',  '" & tb2.Text & "', '" & tb3.Text & "','','" & dtp1.Text & "',''"
                    For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                        MsgBox(dt("Ket"), vbInformation, "Cek Err")
                    Next
                    dtpro("bar")
                ElseIf mpro = "bar" Then
                    tb1.Text = ""
                    tb2.Text = ""
                    cb1.Text = ""
                    tb1.Focus()
                    tampdt()
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub


End Class