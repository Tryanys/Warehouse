Imports System.Data.SqlClient
Imports System.IO

Public Class FrmMaster2
    Dim WithEvents dttemp As New tempdt
    Dim WithEvents cpro As New msaConn
    Private Sub tampdt()
        With dttemp
            .lvTag = .ndKey
            If .ndKey = "krw" Then csql = "select IdKaryawan,NamaKaryawan,Alamat,Akses from TokoMaster.dbo.Karyawan order by IdKaryawan"
            lvListAuto(Me.lv, Me.pb, csql)
            lbrec.Text = "Rec. " & Me.lv.Items.Count
        End With
    End Sub
    Private Sub FrmMaster2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmUtama.Enabled = False
        Label1.Text = ""
        If dttemp.ndKey = "krw" Then Label1.Text = "KARYAWAN"

        tb1.Text = dttemp.PKey
        tb1.Focus() : SendKeys.Send("{end}")
        tampdt()
        ambilTag()
        ambilTagAkses()
        ambilKec()
    End Sub
    Private Sub FrmMaster3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmUtama.Enabled = True
        dttemp = Nothing
        cpro = Nothing
    End Sub
    Private Sub ambilTag()
        cb2.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select KetTag from TokoMaster.dbo.TAG"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb2
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("KetTag"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub

    Private Sub ambilTagAkses()
        cb3.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select AksesKet from TokoMaster.dbo.AksesTag"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb3
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("AksesKet"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub

    Private Sub ambilKec()
        cb1.Items.Clear()
        Dim db As New msaConn
        Dim csql As String = "select Keterangan from TokoMaster.dbo.WILKEC"
        Dim datatable As New DataTable
        datatable = db.ExecQuery(csql)
        If datatable.Rows.Count > 0 Then
            With cb1
                .Items.Clear()
                For i As Integer = 0 To datatable.Rows.Count - 1
                    .Items.Add(datatable.Rows(i).Item("Keterangan"))
                Next
                .SelectedIndex = -1
            End With
        End If

        db = Nothing
        datatable.Dispose()
        datatable = Nothing
    End Sub
    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        Dim img() As Byte
        Try

            tb2.Text = ""
            tb4.Text = ""
            tb5.Text = ""
            cb1.Text = ""
            cb2.Text = ""
            cb3.Text = ""
            If dttemp.ndKey = "krw" Then
                csql = "Select a.NamaKaryawan, b.Keterangan, a.Alamat, a.NoTelp, a.TAG, a.Akses, a.foto  from TokoMaster..Karyawan a inner join TokoMaster..WILKEC b ON a.KecID = b.kecID where IdKaryawan ='" & tb1.Text & "'"
            End If
            If tb1.Text = "" Then Exit Sub
            For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                tb2.Text = dt(0)
                cb1.Text = dt(1)
                tb4.Text = dt(2)
                tb5.Text = dt(3)
                cb2.Text = dt(4)
                cb3.Text = dt(5)
                img = dt(6)
                Dim ms As New MemoryStream(img)
                pt.Image = Image.FromStream(ms)
            Next
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    'Private Sub BTN_SHOW_Click(sender As Object, e As EventArgs) Handles BTN_SHOW.Click

    '    Dim command As New SqlCommand("select * from Table_Images where id = @id", connection)
    '    command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxID.Text

    '    Dim table As New DataTable()

    '    Dim adapter As New SqlDataAdapter(command)

    '    adapter.Fill(table)

    '    If table.Rows.Count() <= 0 Then

    '        MessageBox.Show("No Image For This Id")
    '    Else

    '        TextBoxID.Text = table.Rows(0)(0).ToString()
    '        TextBoxName.Text = table.Rows(0)(1).ToString()
    '        TextBoxDesc.Text = table.Rows(0)(2).ToString()

    '        Dim img() As Byte

    '        img = table.Rows(0)(3)

    '        Dim ms As New MemoryStream(img)

    '        PictureBox1.Image = Image.FromStream(ms)

    '    End If

    'End Sub

    Private Sub FrmMaster2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress, tb2.KeyPress, cb1.KeyPress, tb4.KeyPress, tb5.KeyPress, cb2.KeyPress, cb3.KeyPress
        If e.KeyChar = Chr(13) Then
            If sender.Equals(tb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb2) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(cb1) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb5) Then cb2.Focus() : cb2.DroppedDown = True
            If sender.Equals(cb2) Then cb3.Focus() : cb3.DroppedDown = True
            If sender.Equals(cb3) Then
                'simpan
                dtpro("sim")
            End If
        ElseIf e.KeyChar = Chr(27) Then
            If sender.Equals(tb1) Then Me.Close()
            If sender.Equals(tb2) Then tb1.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb1) Then tb2.Focus() : SendKeys.Send("{end}")
            If sender.Equals(tb4) Then cb1.Focus() : cb1.DroppedDown = True
            If sender.Equals(tb5) Then tb4.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb2) Then tb5.Focus() : SendKeys.Send("{end}")
            If sender.Equals(cb3) Then cb2.Focus() : cb2.DroppedDown = True
        End If
        e.KeyChar = HurufBesar(e.KeyChar)
    End Sub

    Private Sub tb4_KeyDown(sender As Object, e As KeyEventArgs) Handles tb1.KeyDown, tb2.KeyDown, cb1.KeyDown, tb4.KeyDown, cb2.KeyDown, tb5.KeyDown, cb3.KeyDown
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
                Dim fotoPath As String = pt.Text
                Dim fotoBytes() As Byte = File.ReadAllBytes(fotoPath)
                Dim csql As String
                csql = "exec TokoMaster.dbo.sp_Master#3Pro '" & dttemp.ndKey & "','" & mpro & "','" & tb1.Text & "','" & cb1.Text & "','" & tb2.Text & "','" & tb4.Text & "','" & tb5.Text & "','" & cb2.Text & "','" & cb3.Text & "','" & pt.Text & "'"
                For Each dt As DataRow In cpro.ExecQuery(csql).Rows
                    MsgBox(dt("Ket"), vbInformation, "Cek Err")
                Next
                dtpro("bar")
            ElseIf mpro = "bar" Then
                tb1.Text = ""
                tb2.Text = ""
                tb4.Text = ""
                cb1.Text = ""
                cb2.Text = ""
                tb5.Text = ""
                cb3.Text = ""
                tb1.Focus()
                tampdt()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, vbInformation, "Cek err")
        End Try
    End Sub

    Private Sub pt_Click(sender As Object, e As EventArgs) Handles pt.Click

    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Gambar"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim imgPath As String = ofd.FileName
            Dim img As Image = Image.FromFile(imgPath)
            pt.Image = img
        End If

        ofd.Dispose()
    End Sub

End Class