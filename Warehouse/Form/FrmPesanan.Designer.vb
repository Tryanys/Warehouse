<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPesanan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb7 = New System.Windows.Forms.TextBox()
        Me.tb6 = New System.Windows.Forms.TextBox()
        Me.tb5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb8 = New System.Windows.Forms.TextBox()
        Me.tb9 = New System.Windows.Forms.TextBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Pesanan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.tb4)
        Me.GroupBox1.Controls.Add(Me.tb3)
        Me.GroupBox1.Controls.Add(Me.tb2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barang"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(141, 20)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(27, 23)
        Me.btn1.TabIndex = 8
        Me.btn1.Text = "..."
        Me.btn1.UseVisualStyleBackColor = True
        '
        'tb4
        '
        Me.tb4.Location = New System.Drawing.Point(65, 70)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(89, 20)
        Me.tb4.TabIndex = 7
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(65, 45)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(89, 20)
        Me.tb3.TabIndex = 6
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(65, 22)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(75, 20)
        Me.tb2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Barang"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(102, 21)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(89, 20)
        Me.tb1.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tb7)
        Me.GroupBox2.Controls.Add(Me.tb6)
        Me.GroupBox2.Controls.Add(Me.tb5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(243, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 100)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pembeli"
        '
        'tb7
        '
        Me.tb7.Location = New System.Drawing.Point(68, 70)
        Me.tb7.Name = "tb7"
        Me.tb7.Size = New System.Drawing.Size(89, 20)
        Me.tb7.TabIndex = 12
        '
        'tb6
        '
        Me.tb6.Location = New System.Drawing.Point(68, 45)
        Me.tb6.Name = "tb6"
        Me.tb6.Size = New System.Drawing.Size(89, 20)
        Me.tb6.TabIndex = 11
        '
        'tb5
        '
        Me.tb5.Location = New System.Drawing.Point(68, 22)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(89, 20)
        Me.tb5.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Id Pembeli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(445, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Jumlah"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(445, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Harga"
        '
        'tb8
        '
        Me.tb8.Location = New System.Drawing.Point(497, 72)
        Me.tb8.Name = "tb8"
        Me.tb8.Size = New System.Drawing.Size(89, 20)
        Me.tb8.TabIndex = 13
        '
        'tb9
        '
        Me.tb9.Enabled = False
        Me.tb9.Location = New System.Drawing.Point(497, 101)
        Me.tb9.Name = "tb9"
        Me.tb9.Size = New System.Drawing.Size(89, 20)
        Me.tb9.TabIndex = 15
        '
        'lv
        '
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(37, 174)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(549, 146)
        Me.lv.TabIndex = 16
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(38, 323)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(30, 13)
        Me.lbrec.TabIndex = 17
        Me.lbrec.Text = "Rec."
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(529, 323)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(57, 10)
        Me.pb.TabIndex = 18
        '
        'FrmPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 339)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.tb9)
        Me.Controls.Add(Me.tb8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb4 As TextBox
    Friend WithEvents tb3 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb7 As TextBox
    Friend WithEvents tb6 As TextBox
    Friend WithEvents tb5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tb8 As TextBox
    Friend WithEvents tb9 As TextBox
    Friend WithEvents lv As ListView
    Friend WithEvents lbrec As Label
    Friend WithEvents pb As ProgressBar
    Friend WithEvents btn1 As Button
End Class
