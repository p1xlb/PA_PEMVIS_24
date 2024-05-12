<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDash
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenyewaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListSepedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPersetujuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListPenyewaanBerjalanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListRiwayatPenyewaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarisToolStripMenuItem, Me.PenyewaanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventarisToolStripMenuItem
        '
        Me.InventarisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListSepedaToolStripMenuItem})
        Me.InventarisToolStripMenuItem.Name = "InventarisToolStripMenuItem"
        Me.InventarisToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.InventarisToolStripMenuItem.Text = "Inventaris"
        '
        'PenyewaanToolStripMenuItem
        '
        Me.PenyewaanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListPersetujuanToolStripMenuItem, Me.ListPenyewaanBerjalanToolStripMenuItem, Me.ListRiwayatPenyewaanToolStripMenuItem})
        Me.PenyewaanToolStripMenuItem.Name = "PenyewaanToolStripMenuItem"
        Me.PenyewaanToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.PenyewaanToolStripMenuItem.Text = "Penyewaan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'ListSepedaToolStripMenuItem
        '
        Me.ListSepedaToolStripMenuItem.Name = "ListSepedaToolStripMenuItem"
        Me.ListSepedaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ListSepedaToolStripMenuItem.Text = "List Sepeda"
        '
        'ListPersetujuanToolStripMenuItem
        '
        Me.ListPersetujuanToolStripMenuItem.Name = "ListPersetujuanToolStripMenuItem"
        Me.ListPersetujuanToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ListPersetujuanToolStripMenuItem.Text = "List Persetujuan"
        '
        'ListPenyewaanBerjalanToolStripMenuItem
        '
        Me.ListPenyewaanBerjalanToolStripMenuItem.Name = "ListPenyewaanBerjalanToolStripMenuItem"
        Me.ListPenyewaanBerjalanToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ListPenyewaanBerjalanToolStripMenuItem.Text = "List Penyewaan Berjalan"
        '
        'ListRiwayatPenyewaanToolStripMenuItem
        '
        Me.ListRiwayatPenyewaanToolStripMenuItem.Name = "ListRiwayatPenyewaanToolStripMenuItem"
        Me.ListRiwayatPenyewaanToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ListRiwayatPenyewaanToolStripMenuItem.Text = "List Riwayat Penyewaan"
        '
        'AdminDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminDash"
        Me.Text = "AdminDash"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListSepedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenyewaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPersetujuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPenyewaanBerjalanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListRiwayatPenyewaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
End Class
