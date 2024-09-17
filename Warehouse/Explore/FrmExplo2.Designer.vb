<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExplo2
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
        Me.components = New System.ComponentModel.Container()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.ct = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BukaFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lv = New System.Windows.Forms.ListView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ts1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.ct.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tv
        '
        Me.tv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tv.ContextMenuStrip = Me.ct
        Me.tv.Location = New System.Drawing.Point(1, 2)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(166, 344)
        Me.tv.TabIndex = 0
        '
        'ct
        '
        Me.ct.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaFormToolStripMenuItem})
        Me.ct.Name = "ct"
        Me.ct.Size = New System.Drawing.Size(132, 26)
        '
        'BukaFormToolStripMenuItem
        '
        Me.BukaFormToolStripMenuItem.Name = "BukaFormToolStripMenuItem"
        Me.BukaFormToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BukaFormToolStripMenuItem.Text = "Buka Form"
        '
        'lv
        '
        Me.lv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.FullRowSelect = True
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(173, 2)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(409, 344)
        Me.lv.TabIndex = 1
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts1, Me.ts2, Me.pb})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 355)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(587, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ts1
        '
        Me.ts1.Name = "ts1"
        Me.ts1.Size = New System.Drawing.Size(119, 17)
        Me.ts1.Text = "ToolStripStatusLabel1"
        '
        'ts2
        '
        Me.ts2.Name = "ts2"
        Me.ts2.Size = New System.Drawing.Size(119, 17)
        Me.ts2.Text = "ToolStripStatusLabel2"
        '
        'pb
        '
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(100, 16)
        '
        'FrmExplo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 377)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.tv)
        Me.Name = "FrmExplo2"
        Me.Text = "FrmExplo2"
        Me.ct.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tv As TreeView
    Friend WithEvents lv As ListView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ts1 As ToolStripStatusLabel
    Friend WithEvents ts2 As ToolStripStatusLabel
    Friend WithEvents pb As ToolStripProgressBar
    Friend WithEvents ct As ContextMenuStrip
    Friend WithEvents BukaFormToolStripMenuItem As ToolStripMenuItem
End Class
