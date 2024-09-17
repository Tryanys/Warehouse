<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCari
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
        Me.lv = New System.Windows.Forms.ListView()
        Me.lbrec = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'lv
        '
        Me.lv.FullRowSelect = True
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(59, 65)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(360, 165)
        Me.lv.TabIndex = 1
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'lbrec
        '
        Me.lbrec.AutoSize = True
        Me.lbrec.Location = New System.Drawing.Point(56, 233)
        Me.lbrec.Name = "lbrec"
        Me.lbrec.Size = New System.Drawing.Size(30, 13)
        Me.lbrec.TabIndex = 2
        Me.lbrec.Text = "Rec."
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(369, 233)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(50, 13)
        Me.pb.TabIndex = 3
        '
        'FrmCari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 252)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lbrec)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCari"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lv As ListView
    Friend WithEvents lbrec As Label
    Friend WithEvents pb As ProgressBar
End Class
