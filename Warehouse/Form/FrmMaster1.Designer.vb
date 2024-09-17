<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaster1
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
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kecamatan"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(145, 68)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(59, 20)
        Me.tb1.TabIndex = 4
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(145, 93)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(128, 20)
        Me.tb2.TabIndex = 5
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(145, 122)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(128, 21)
        Me.cb1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Alamat"
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(145, 151)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(128, 20)
        Me.tb3.TabIndex = 8
        '
        'lv
        '
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(12, 203)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(521, 167)
        Me.lv.TabIndex = 9
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(469, 376)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(64, 16)
        Me.pb.TabIndex = 10
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(12, 376)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(30, 13)
        Me.lbrec.TabIndex = 11
        Me.lbrec.Text = "Rec."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "No.Telp"
        '
        'tb4
        '
        Me.tb4.Location = New System.Drawing.Point(145, 177)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(128, 20)
        Me.tb4.TabIndex = 13
        '
        'FrmMaster1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 398)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMaster1"
        Me.Text = "FrmMaster1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb3 As TextBox
    Friend WithEvents lv As ListView
    Friend WithEvents pb As ProgressBar
    Friend WithEvents lbrec As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb4 As TextBox
End Class
