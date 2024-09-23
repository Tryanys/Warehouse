Imports System.ComponentModel

Public Class FrmHutang
    Dim WithEvents dtempt As New tempdt
    Dim WithEvents cpro As New msaConn
    Dim mform As Form

    Public Sub bukaform(ByVal nForm As Form, ByVal id As String)
        Me.Show()
        mform = nForm : mform.Enabled = False
        'tb1.Text = id
        'tb2.Focus() : SendKeys.Send("{end}")
    End Sub

    Private Sub FrmHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmHutang_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmUtama.Enabled = True
        dtempt = Nothing
        cpro = Nothing
    End Sub
End Class