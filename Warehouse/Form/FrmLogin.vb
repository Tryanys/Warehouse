Public Class FrmLogin
    Private Sub BTNLOG_Click(sender As Object, e As EventArgs) Handles BTNLOG.Click
        If TXTUSER.Text = "ADMIN" AndAlso TXTPASS.Text = "ADMIN" Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Login Gagal")
        End If
    End Sub

    Private Sub BTNKLR_Click(sender As Object, e As EventArgs) Handles BTNKLR.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTUSER.KeyPress, TXTPASS.KeyPress, BTNLOG.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(TXTUSER) Then TXTPASS.Focus() : SendKeys.Send("{end}")
            If sender.Equals(TXTPASS) Then BTNLOG.Focus() : SendKeys.Send("{end}")
            If sender.Equals(BTNLOG) Then
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(TXTUSER) Then Me.Close()
            If sender.Equals(TXTPASS) Then TXTUSER.Focus() : SendKeys.Send("{end}")
            If sender.Equals(BTNLOG) Then TXTPASS.Focus() : SendKeys.Send("{end}")
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub
End Class