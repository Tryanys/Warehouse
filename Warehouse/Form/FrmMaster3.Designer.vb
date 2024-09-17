<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaster3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb5 = New System.Windows.Forms.TextBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Rak"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(171, 63)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(100, 20)
        Me.tb1.TabIndex = 6
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(171, 91)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(147, 20)
        Me.tb2.TabIndex = 7
        '
        'tb5
        '
        Me.tb5.Location = New System.Drawing.Point(171, 164)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(46, 20)
        Me.tb5.TabIndex = 10
        '
        'lv
        '
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(30, 214)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(652, 179)
        Me.lv.TabIndex = 11
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(27, 402)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(30, 13)
        Me.lbrec.TabIndex = 12
        Me.lbrec.Text = "Rec."
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(625, 399)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(57, 16)
        Me.pb.TabIndex = 13
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(171, 137)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(147, 21)
        Me.cb1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Satuan"
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(171, 114)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(147, 20)
        Me.tb3.TabIndex = 16
        '
        'FrmMaster3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 434)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.tb5)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMaster3"
        Me.Text = "Form Master Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents tb5 As TextBox
    Friend WithEvents lv As ListView
    Friend WithEvents lbrec As Label
    Friend WithEvents pb As ProgressBar
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb3 As TextBox
End Class
