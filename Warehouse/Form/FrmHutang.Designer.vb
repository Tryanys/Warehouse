<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHutang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tb4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 156)
        Me.Panel1.TabIndex = 3
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"PESANAN DITERIMA", "SEDANG PROSES", "DIKIRIM"})
        Me.cb1.Location = New System.Drawing.Point(110, 10)
        Me.cb1.Margin = New System.Windows.Forms.Padding(4)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(134, 24)
        Me.cb1.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Karyawan"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(523, 391)
        Me.pb.Margin = New System.Windows.Forms.Padding(4)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(77, 16)
        Me.pb.TabIndex = 14
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(9, 391)
        Me.lbrec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(37, 17)
        Me.lbrec.TabIndex = 13
        Me.lbrec.Text = "Rec."
        '
        'lv
        '
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(14, 177)
        Me.lv.Margin = New System.Windows.Forms.Padding(4)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(586, 206)
        Me.lv.TabIndex = 12
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(324, 14)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Tanggal"
        '
        'tb4
        '
        Me.tb4.Enabled = False
        Me.tb4.Location = New System.Drawing.Point(110, 42)
        Me.tb4.Margin = New System.Windows.Forms.Padding(4)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(134, 22)
        Me.tb4.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ID Trans"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "yyyy-MM-dd"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(392, 10)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(114, 22)
        Me.dtp1.TabIndex = 26
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(110, 70)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(203, 22)
        Me.TextBox1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Uraian"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(110, 100)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(203, 22)
        Me.TextBox2.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Bayar"
        '
        'FrmHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 413)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmHutang"
        Me.Text = "FrmHutang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pb As ProgressBar
    Friend WithEvents lbrec As Label
    Friend WithEvents lv As ListView
    Friend WithEvents tb4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
