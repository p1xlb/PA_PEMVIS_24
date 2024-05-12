Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        If username = "admin" And password = "admin" Then
            MsgBox("Logged in As Admin")
            Me.Hide()
            AdminDash.Show()



        Else
            MsgBox("Login Gagal")
        End If
    End Sub
End Class
