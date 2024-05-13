Public Class ApplyRent
    Dim options As String = ""
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel1.Hide()
        txtTipeSepeda.Text = "Ventura R5"
        txtTipeSepeda.Enabled = False
        Panel2.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Hide()
        txtTipeSepeda.Text = "Varilux Pro"
        txtTipeSepeda.Enabled = False
        Panel2.Show()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel1.Hide()
        txtTipeSepeda.Text = "Crosser VX"
        txtTipeSepeda.Enabled = False
        Panel2.Show()
    End Sub

    Private Sub ApplyRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Hide()
        Panel1.Show()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Clear()
        Panel2.Hide()
        Panel1.Show()
    End Sub

    Public Sub txtLamaSewa_TextChanged(sender As Object, e As EventArgs) Handles txtLamaSewa.TextChanged
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
            lbTotalTarif.Text = tarif
        End If
    End Sub

    Private Sub chHelm_CheckedChanged(sender As Object, e As EventArgs) Handles chHelm.CheckedChanged
        Dim tarif As Integer
        If chHelm.Checked Then
            tarif = CInt(lbTotalTarif.Text) + 20000
            lbTotalTarif.Text = tarif
        Else
            tarif = CInt(lbTotalTarif.Text) - 20000
            lbTotalTarif.Text = tarif
        End If
    End Sub

    Private Sub chExtraBatt_CheckedChanged(sender As Object, e As EventArgs) Handles chExtraBatt.CheckedChanged
        Dim tarif As Integer
        If chExtraBatt.Checked Then
            tarif = CInt(lbTotalTarif.Text) + 35000
            lbTotalTarif.Text = tarif
        Else
            tarif = CInt(lbTotalTarif.Text) - 35000
            lbTotalTarif.Text = tarif
        End If
    End Sub

    Private Sub Clear()
        txtLamaSewa.Clear()
        txtTipeSepeda.Clear()
        lbTotalTarif.Text = "0"
        chHelm.Checked = False
        chExtraBatt.Checked = False
    End Sub
End Class