Public Class ApplyRent
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel1.Hide()
        Panel2.Show()
        txtTipeSepeda.Text = "Ventura R5"
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Hide()
        Panel2.Show()
        txtTipeSepeda.Text = "Varilux Pro"
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel1.Hide()
        Panel2.Show()
        txtTipeSepeda.Text = "Crosser VX"
    End Sub

    Private Sub ApplyRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Show()
        Panel1.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Panel2.Hide()
        Panel1.Show()
    End Sub

    Public Sub Clear()
        txtTipeSepeda.Clear()
        txtLamaSewa.Clear()
        lbTotalTarif.Text = "Rp. 0"
    End Sub

    Private Sub txtLamaSewa_TextChanged(sender As Object, e As EventArgs) Handles txtLamaSewa.TextChanged
        If txtLamaSewa.Text = "" Then
            lbTotalTarif.Text = "Rp. 0"
        Else
            Dim tarif As Integer
            If txtTipeSepeda.Text = "Ventura R5" Then
                tarif = 50000 * CInt(txtLamaSewa.Text)
            ElseIf txtTipeSepeda.Text = "Varilux Pro" Then
                tarif = 65000 * CInt(txtLamaSewa.Text)
            ElseIf txtTipeSepeda.Text = "Crosser VX" Then
                tarif = 80000 * CInt(txtLamaSewa.Text)
            End If
            lbTotalTarif.Text = "Rp. " & tarif * CInt(txtLamaSewa.Text)
        End If
    End Sub
End Class