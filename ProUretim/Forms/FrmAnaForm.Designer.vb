<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnaForm))
        Me.TlbMain = New System.Windows.Forms.ToolStrip()
        Me.BtnKapat = New System.Windows.Forms.ToolStripButton()
        Me.BtnBar = New System.Windows.Forms.ToolStrip()
        Me.BtnDil = New System.Windows.Forms.ToolStripButton()
        Me.TlbMain.SuspendLayout()
        Me.BtnBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TlbMain
        '
        Me.TlbMain.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.TlbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnKapat})
        Me.TlbMain.Location = New System.Drawing.Point(0, 0)
        Me.TlbMain.Name = "TlbMain"
        Me.TlbMain.Size = New System.Drawing.Size(686, 70)
        Me.TlbMain.TabIndex = 2
        Me.TlbMain.Text = "ToolStrip1"
        '
        'BtnKapat
        '
        Me.BtnKapat.Image = Global.ProUretim.My.Resources.Resources.shut_down
        Me.BtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnKapat.Name = "BtnKapat"
        Me.BtnKapat.Size = New System.Drawing.Size(52, 67)
        Me.BtnKapat.Text = "Kapat"
        Me.BtnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnBar
        '
        Me.BtnBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDil})
        Me.BtnBar.Location = New System.Drawing.Point(0, 365)
        Me.BtnBar.Name = "BtnBar"
        Me.BtnBar.Size = New System.Drawing.Size(686, 25)
        Me.BtnBar.TabIndex = 4
        Me.BtnBar.Text = "ToolStrip1"
        '
        'BtnDil
        '
        Me.BtnDil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDil.Image = CType(resources.GetObject("BtnDil.Image"), System.Drawing.Image)
        Me.BtnDil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDil.Name = "BtnDil"
        Me.BtnDil.Size = New System.Drawing.Size(23, 22)
        Me.BtnDil.Text = "ToolStripButton1"
        '
        'FrmAnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.BtnBar)
        Me.Controls.Add(Me.TlbMain)
        Me.IsMdiContainer = True
        Me.Name = "FrmAnaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üretim Programı"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TlbMain.ResumeLayout(False)
        Me.TlbMain.PerformLayout()
        Me.BtnBar.ResumeLayout(False)
        Me.BtnBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TlbMain As ToolStrip
    Friend WithEvents BtnKapat As ToolStripButton
    Friend WithEvents BtnBar As ToolStrip
    Friend WithEvents BtnDil As ToolStripButton
End Class
