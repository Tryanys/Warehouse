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
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tb3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tb2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tb1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(10, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 127)
        Me.Panel1.TabIndex = 3
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(83, 37)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(102, 20)
        Me.tb2.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Bayar"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(83, 11)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(102, 20)
        Me.tb1.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ID Trans"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "yyyy-MM-dd"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(294, 8)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(86, 20)
        Me.dtp1.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(243, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Tanggal"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"PESANAN DITERIMA", "SEDANG PROSES", "DIKIRIM"})
        Me.cb1.Location = New System.Drawing.Point(83, 63)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(102, 21)
        Me.cb1.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Karyawan"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(392, 318)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(58, 13)
        Me.pb.TabIndex = 14
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(7, 318)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(30, 13)
        Me.lbrec.TabIndex = 13
        Me.lbrec.Text = "Rec."
        '
        'lv
        '
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(10, 144)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(440, 168)
        Me.lv.TabIndex = 12
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(318, 38)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(62, 20)
        Me.tb3.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Num"
        '
        'FrmHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 336)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents tb2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb3 As TextBox
    Friend WithEvents Label1 As Label
End Class
