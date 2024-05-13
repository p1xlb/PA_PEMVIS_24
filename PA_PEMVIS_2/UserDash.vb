Imports MySql.Data.MySqlClient

Public Class UserDash
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Form1.Clear()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub UserDash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Label1.Text = "Selamat Datang, " & getNama()
    End Sub

    Private Function getNama() As String
        Dim username As String = Form1.txtUsername.Text
        CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE username = '" & username & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Return RD.Item("nama_pelanggan")
            RD.Close()
        End If
        Return ""
    End Function

    Private Sub AjukanSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjukanSewaToolStripMenuItem.Click
        ApplyRent.Show()
    End Sub
End Class