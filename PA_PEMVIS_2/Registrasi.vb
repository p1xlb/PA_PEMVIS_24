Imports MySql.Data.MySqlClient

Public Class Registrasi
    Private Sub txtRegistrasi_Click(sender As Object, e As EventArgs) Handles txtRegistrasi.Click
        If ValidateInput() = True Then
            CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE username = '" & txtUsername.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim username As String = txtUsername.Text
                Dim password As String = txtPassword.Text
                Dim nama As String = txtNama.Text
                Dim alamat As String = rtxtAlamat.Text
                Dim no_telp As String = txtNTelpon.Text
                CMD = New MySqlCommand("INSERT INTO pelanggan (username, password, nama_pelanggan, nomor_telepon, alamat) VALUES ('" & username & "', '" & password & "', '" & nama & "', '" & alamat & "', '" & no_telp & "')", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Registrasi Berhasil")
                Clear()
                Me.Hide()
                Form1.Show()
            Else
                RD.Close()
                MsgBox("Username sudah digunakan")
            End If
        End If
    End Sub

    Private Function ValidateInput()
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtNama.Text = "" Or rtxtAlamat.Text = "" Or txtNTelpon.Text = "" Then
            MsgBox("Data tidak boleh kosong")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtNama.Clear()
        rtxtAlamat.Clear()
        txtNTelpon.Clear()
    End Sub

    Private Sub Registrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class