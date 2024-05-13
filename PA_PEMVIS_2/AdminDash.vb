Public Class AdminDash
    Private Sub ManajemenInventarisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenInventarisToolStripMenuItem.Click
        InventoryManager.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Form1.Clear()
        Form1.Show()
        Me.Close()
    End Sub
End Class