<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExplo
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ts1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.ct = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BukaFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btBaca = New System.Windows.Forms.Button()
        Me.lbPD = New System.Windows.Forms.Label()
        Me.cbPD = New System.Windows.Forms.ComboBox()
        Me.tthn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.lv2 = New System.Windows.Forms.ListView()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ct.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts1, Me.ts2, Me.pb})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 313)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(508, 22)
        Me.StatusStrip1.TabIndex = 0
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
        Me.pb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(70, 16)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tv)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(508, 313)
        Me.SplitContainer1.SplitterDistance = 276
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 2
        '
        'tv
        '
        Me.tv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tv.ContextMenuStrip = Me.ct
        Me.tv.Location = New System.Drawing.Point(3, 118)
        Me.tv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(272, 194)
        Me.tv.TabIndex = 1
        '
        'ct
        '
        Me.ct.ImageScalingSize = New System.Drawing.Size(24, 24)
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btBaca)
        Me.Panel1.Controls.Add(Me.lbPD)
        Me.Panel1.Controls.Add(Me.cbPD)
        Me.Panel1.Controls.Add(Me.tthn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 113)
        Me.Panel1.TabIndex = 0
        '
        'btBaca
        '
        Me.btBaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btBaca.Location = New System.Drawing.Point(211, 83)
        Me.btBaca.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btBaca.Name = "btBaca"
        Me.btBaca.Size = New System.Drawing.Size(50, 20)
        Me.btBaca.TabIndex = 5
        Me.btBaca.Text = "Baca"
        Me.btBaca.UseVisualStyleBackColor = True
        '
        'lbPD
        '
        Me.lbPD.AutoSize = True
        Me.lbPD.Location = New System.Drawing.Point(136, 47)
        Me.lbPD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPD.Name = "lbPD"
        Me.lbPD.Size = New System.Drawing.Size(43, 13)
        Me.lbPD.TabIndex = 4
        Me.lbPD.Text = "Periode"
        '
        'cbPD
        '
        Me.cbPD.FormattingEnabled = True
        Me.cbPD.Location = New System.Drawing.Point(64, 45)
        Me.cbPD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbPD.Name = "cbPD"
        Me.cbPD.Size = New System.Drawing.Size(71, 21)
        Me.cbPD.TabIndex = 3
        '
        'tthn
        '
        Me.tthn.Location = New System.Drawing.Point(62, 20)
        Me.tthn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tthn.Name = "tthn"
        Me.tthn.Size = New System.Drawing.Size(60, 20)
        Me.tthn.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Periode"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 23)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Tahun"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lv1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lv2)
        Me.SplitContainer2.Size = New System.Drawing.Size(229, 313)
        Me.SplitContainer2.SplitterDistance = 126
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 0
        '
        'lv1
        '
        Me.lv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv1.FullRowSelect = True
        Me.lv1.HideSelection = False
        Me.lv1.Location = New System.Drawing.Point(1, 0)
        Me.lv1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(225, 125)
        Me.lv1.TabIndex = 0
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'lv2
        '
        Me.lv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv2.FullRowSelect = True
        Me.lv2.HideSelection = False
        Me.lv2.Location = New System.Drawing.Point(0, 1)
        Me.lv2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lv2.Name = "lv2"
        Me.lv2.Size = New System.Drawing.Size(227, 181)
        Me.lv2.TabIndex = 1
        Me.lv2.UseCompatibleStateImageBehavior = False
        '
        'FrmExplo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(508, 335)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FrmExplo"
        Me.Text = "FrmExplo"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ct.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tv As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbPD As Label
    Friend WithEvents cbPD As ComboBox
    Friend WithEvents tthn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents lv1 As ListView
    Friend WithEvents lv2 As ListView
    Friend WithEvents ts1 As ToolStripStatusLabel
    Friend WithEvents ts2 As ToolStripStatusLabel
    Friend WithEvents pb As ToolStripProgressBar
    Friend WithEvents ct As ContextMenuStrip
    Friend WithEvents BukaFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btBaca As Button
End Class
