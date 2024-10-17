Imports Warehouse
Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Net.NetworkInformation
Imports System.Net.Dns
Imports System.Globalization
Imports System.Net


Public Class FrmUtama

    Dim noform As Integer

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        Dim frmexplo As New FrmExplo2
        With frmexplo
            .MdiParent = Me
            noform = +1
            .Text = "Master " & noform
            .Tag = "mast"
            .Show()
        End With
    End Sub

    Private Sub FrmUtama_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim loginForm As New FrmLogin()
        Me.Enabled = False
        loginForm.ShowDialog()
        If loginForm.DialogResult = DialogResult.OK Then
            Me.Enabled = True
        Else
            Me.Close()
        End If
    End Sub



    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        Dim frmexplo As New FrmExplo
        With frmexplo
            .MdiParent = Me : noform = +1
            .Text = "Pembelian " & noform
            .Tag = "beli"
            .Show()
        End With
    End Sub

    Private Sub FrmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim jam As New samakanjam
        'tsTGL.Text = jam.AmbilTanggalServer.Date.ToShortDateString

        'jam = Nothing

        Dim dt As String = ""
        Dim dtStyle As String = "ddd, dd MMM yyyy"
        gantijamServer()
        dt = DateTime.Now.ToString(dtStyle, New System.Globalization.CultureInfo("id-ID"))
        tsTGL.Text = dt
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Dim frmexplo As New FrmExplo
        With frmexplo
            .MdiParent = Me : noform = +1
            .Text = "Penjualan " & noform
            .Tag = "jl"
            .Show()
        End With
    End Sub

    Private Sub TransaksiBeliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBeliToolStripMenuItem.Click
        Dim frmexplo As New FrmExplo
        With frmexplo
            .MdiParent = Me : noform = +1
            .Text = "Pesanan " & noform
            .Tag = "ps"
            .Show()
        End With
    End Sub

    Private Sub TerimaPesananToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TerimaPesananToolStripMenuItem1.Click
        Dim frmexplo As New FrmExplo
        With frmexplo
            .MdiParent = Me : noform = +1
            .Text = "Terima Pesanan " & noform
            .Tag = "tp"
            .Show()
        End With
    End Sub

    Private Sub HutangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HutangToolStripMenuItem.Click
        Dim frmexplo As New FrmExplo
        With frmexplo
            .MdiParent = Me : noform = +1
            .Text = "Bayar Hutang " & noform
            .Tag = "bht"
            .Show()
        End With
    End Sub

    Private Sub PiutangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PiutangToolStripMenuItem.Click
        Dim frmexplo As New FrmExplo
        With frmexplo
            .MdiParent = Me : noform = +1
            .Text = "Bayar Piutang " & noform
            .Tag = "bpt"
            .Show()
        End With
    End Sub

    Private Sub ReturBeliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturBeliToolStripMenuItem.Click
        Dim frmexplo As New FrmExplo
        With frmexplo
            .MdiParent = Me : noform = +1
            .Text = "Retur Beli " & noform
            .Tag = "rb"
            .Show()
        End With
    End Sub

    Private Sub ReturPenerimaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturPenerimaanToolStripMenuItem.Click
        Dim frmexplo As New FrmExplo
        With frmexplo
            .MdiParent = Me : noform = +1
            .Text = "Retur Penerimaan " & noform
            .Tag = "rp"
            .Show()
        End With
    End Sub
End Class

'Public Class samakanjam
'    Dim newDate As Date
'    Dim db As msaConn, st As systemtime



'    Public Function AmbilTanggalServer() As Date
'        Dim newdate As Date
'        db = New msaConn
'        Try
'            csql = "exec tokomaster.dbo.sp_tanggal"
'            For Each dt As DataRow In db.ExecQuery(csql).Rows
'                newdate = dt(0)
'            Next


'            st.year = newdate.Year
'            st.month = newdate.Month
'            st.day = newdate.Day
'            st.hour = newdate.Hour
'            st.minute = newdate.Minute
'            st.second = newdate.Second
'            st.milliseconds = newdate.Millisecond

'            SetLocaltime(st)

'        Catch ex As Exception
'            MsgBox(Err.Description, vbInformation, "Cek err")
'        Finally
'            db = Nothing
'        End Try

'        Return newdate

'    End Function

'    Private Structure systemtime
'        Public year As Short
'        Public month As Short
'        Public dayOfWeek As Short
'        Public day As Short
'        Public hour As Short
'        Public minute As Short
'        Public second As Short
'        Public milliseconds As Short
'    End Structure


'    <DllImport("kernel32.dll", SetLastError:=True)>
'    Private Shared Function SetLocaltime(ByRef time As systemtime) As Boolean

'    End Function


'End Class





