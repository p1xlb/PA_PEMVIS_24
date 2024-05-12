<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvetoryManager
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
        Me.txtIDSepeda = New System.Windows.Forms.TextBox()
        Me.cbTipeSepeda = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbIdle = New System.Windows.Forms.RadioButton()
        Me.rbSewaBerjalan = New System.Windows.Forms.RadioButton()
        Me.rbMaintenance = New System.Windows.Forms.RadioButton()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.txtKilometer = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIDSepeda
        '
        Me.txtIDSepeda.Location = New System.Drawing.Point(134, 73)
        Me.txtIDSepeda.Name = "txtIDSepeda"
        Me.txtIDSepeda.Size = New System.Drawing.Size(100, 22)
        Me.txtIDSepeda.TabIndex = 0
        '
        'cbTipeSepeda
        '
        Me.cbTipeSepeda.FormattingEnabled = True
        Me.cbTipeSepeda.Location = New System.Drawing.Point(134, 102)
        Me.cbTipeSepeda.Name = "cbTipeSepeda"
        Me.cbTipeSepeda.Size = New System.Drawing.Size(121, 24)
        Me.cbTipeSepeda.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMaintenance)
        Me.GroupBox1.Controls.Add(Me.rbSewaBerjalan)
        Me.GroupBox1.Controls.Add(Me.rbIdle)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 57)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rbIdle
        '
        Me.rbIdle.AutoSize = True
        Me.rbIdle.Location = New System.Drawing.Point(7, 22)
        Me.rbIdle.Name = "rbIdle"
        Me.rbIdle.Size = New System.Drawing.Size(50, 20)
        Me.rbIdle.TabIndex = 0
        Me.rbIdle.TabStop = True
        Me.rbIdle.Text = "Idle"
        Me.rbIdle.UseVisualStyleBackColor = True
        '
        'rbSewaBerjalan
        '
        Me.rbSewaBerjalan.AutoSize = True
        Me.rbSewaBerjalan.Location = New System.Drawing.Point(63, 22)
        Me.rbSewaBerjalan.Name = "rbSewaBerjalan"
        Me.rbSewaBerjalan.Size = New System.Drawing.Size(115, 20)
        Me.rbSewaBerjalan.TabIndex = 1
        Me.rbSewaBerjalan.TabStop = True
        Me.rbSewaBerjalan.Text = "Sewa Berjalan"
        Me.rbSewaBerjalan.UseVisualStyleBackColor = True
        '
        'rbMaintenance
        '
        Me.rbMaintenance.AutoSize = True
        Me.rbMaintenance.Location = New System.Drawing.Point(184, 22)
        Me.rbMaintenance.Name = "rbMaintenance"
        Me.rbMaintenance.Size = New System.Drawing.Size(105, 20)
        Me.rbMaintenance.TabIndex = 2
        Me.rbMaintenance.TabStop = True
        Me.rbMaintenance.Text = "Maintenance"
        Me.rbMaintenance.UseVisualStyleBackColor = True
        '
        'txtTarif
        '
        Me.txtTarif.Location = New System.Drawing.Point(134, 195)
        Me.txtTarif.Name = "txtTarif"
        Me.txtTarif.Size = New System.Drawing.Size(100, 22)
        Me.txtTarif.TabIndex = 4
        '
        'txtKilometer
        '
        Me.txtKilometer.Location = New System.Drawing.Point(134, 223)
        Me.txtKilometer.Name = "txtKilometer"
        Me.txtKilometer.Size = New System.Drawing.Size(100, 22)
        Me.txtKilometer.TabIndex = 5
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(366, 265)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(447, 265)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(528, 265)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(609, 265)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 9
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'InvetoryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtKilometer)
        Me.Controls.Add(Me.txtTarif)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbTipeSepeda)
        Me.Controls.Add(Me.txtIDSepeda)
        Me.Name = "InvetoryManager"
        Me.Text = "InvetoryManager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIDSepeda As TextBox
    Friend WithEvents cbTipeSepeda As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbMaintenance As RadioButton
    Friend WithEvents rbSewaBerjalan As RadioButton
    Friend WithEvents rbIdle As RadioButton
    Friend WithEvents txtTarif As TextBox
    Friend WithEvents txtKilometer As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnList As Button
End Class
