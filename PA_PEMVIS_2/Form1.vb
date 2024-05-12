Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE username = '" & username & "' AND password = '" & password & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            MsgBox("Login Berhasil")
            Me.Hide()
            UserDash.Show()
        ElseIf username = "Admin" And password = "Admin" Then
            MsgBox("Login Berhasil")
            Me.Hide()
            AdminDash.Show()
        Else
            MsgBox("Login Gagal")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class
