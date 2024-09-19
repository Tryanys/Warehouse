<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTerima
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lv = New System.Windows.Forms.ListView()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 157)
        Me.Panel1.TabIndex = 2
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"PESANAN DITERIMA", "SEDANG PROSES", "DIKIRIM"})
        Me.cb1.Location = New System.Drawing.Point(90, 118)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(138, 21)
        Me.cb1.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tb7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tb6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tb5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tb4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(232, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Barang"
        '
        'tb8
        '
        Me.tb8.Enabled = False
        Me.tb8.Location = New System.Drawing.Point(225, 48)
        Me.tb8.Name = "tb8"
        Me.tb8.Size = New System.Drawing.Size(79, 20)
        Me.tb8.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Harga"
        '
        'tb7
        '
        Me.tb7.Enabled = False
        Me.tb7.Location = New System.Drawing.Point(225, 22)
        Me.tb7.Name = "tb7"
        Me.tb7.Size = New System.Drawing.Size(79, 20)
        Me.tb7.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(178, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Jumlah"
        '
        'tb6
        '
        Me.tb6.Enabled = False
        Me.tb6.Location = New System.Drawing.Point(81, 72)
        Me.tb6.Name = "tb6"
        Me.tb6.Size = New System.Drawing.Size(87, 20)
        Me.tb6.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Satuan"
        '
        'tb5
        '
        Me.tb5.Enabled = False
        Me.tb5.Location = New System.Drawing.Point(81, 49)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(87, 20)
        Me.tb5.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Barang"
        '
        'tb4
        '
        Me.tb4.Enabled = False
        Me.tb4.Location = New System.Drawing.Point(81, 22)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(87, 20)
        Me.tb4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Kode Barang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tb3)
        Me.GroupBox1.Controls.Add(Me.tb2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tb1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesanan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 21)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(78, 72)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(87, 20)
        Me.tb3.TabIndex = 8
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(78, 49)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(87, 20)
        Me.tb2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pembeli"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(78, 22)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(87, 20)
        Me.tb1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "No Pesanan"
        '
        'lv
        '
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(12, 163)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(535, 168)
        Me.lv.TabIndex = 3
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(9, 334)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(30, 13)
        Me.lbrec.TabIndex = 10
        Me.lbrec.Text = "Rec."
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(489, 334)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(58, 13)
        Me.pb.TabIndex = 11
        '
        'FrmTerima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 352)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmTerima"
        Me.Text = "FrmTerima"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tb7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tb3 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lv As ListView
    Friend WithEvents lbrec As Label
    Friend WithEvents pb As ProgressBar
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents Label10 As Label
End Class
