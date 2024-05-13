Public Class UserDash
    Private Sub ListSepedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjukanSewaToolStripMenuItem.Click
        Me.Hide()
        ApplyRent.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Form1.Clear()
        Form1.Show()
        Me.Close()
    End Sub
End Class