<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrasi
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNTelpon = New System.Windows.Forms.TextBox()
        Me.rtxtAlamat = New System.Windows.Forms.RichTextBox()
        Me.txtRegistrasi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(183, 90)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(255, 22)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(183, 118)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(255, 22)
        Me.txtPassword.TabIndex = 2
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(183, 146)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(255, 22)
        Me.txtNama.TabIndex = 3
        '
        'txtNTelpon
        '
        Me.txtNTelpon.Location = New System.Drawing.Point(183, 174)
        Me.txtNTelpon.Name = "txtNTelpon"
        Me.txtNTelpon.Size = New System.Drawing.Size(255, 22)
        Me.txtNTelpon.TabIndex = 4
        '
        'rtxtAlamat
        '
        Me.rtxtAlamat.Location = New System.Drawing.Point(183, 202)
        Me.rtxtAlamat.Name = "rtxtAlamat"
        Me.rtxtAlamat.Size = New System.Drawing.Size(255, 96)
        Me.rtxtAlamat.TabIndex = 6
        Me.rtxtAlamat.Text = ""
        '
        'txtRegistrasi
        '
        Me.txtRegistrasi.Location = New System.Drawing.Point(363, 304)
        Me.txtRegistrasi.Name = "txtRegistrasi"
        Me.txtRegistrasi.Size = New System.Drawing.Size(75, 23)
        Me.txtRegistrasi.TabIndex = 7
        Me.txtRegistrasi.Text = "Registrasi"
        Me.txtRegistrasi.UseVisualStyleBackColor = True
        '
        'Registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtRegistrasi)
        Me.Controls.Add(Me.rtxtAlamat)
        Me.Controls.Add(Me.txtNTelpon)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "Registrasi"
        Me.Text = "Registrasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNTelpon As TextBox
    Friend WithEvents rtxtAlamat As RichTextBox
    Friend WithEvents txtRegistrasi As Button
End Class
