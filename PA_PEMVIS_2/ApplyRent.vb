Public Class ApplyRent
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel1.Hide()
        Panel2.Show()
    End Sub

    Private Sub ApplyRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Hide()
        Panel1.Show()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Panel2.Hide()
        Panel1.Show()
    End Sub
End Class