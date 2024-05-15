Imports MySql.Data.MySqlClient

Public Class ApplyRent
    Dim options As New List(Of String)
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
        koneksi()
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

    Private Sub btnAjukan_Click(sender As Object, e As EventArgs) Handles btnAjukan.Click
        If txtLamaSewa.Text = "" Then
            MsgBox("Lama sewa tidak boleh kosong", MsgBoxStyle.Critical, "Error")
        Else
            Dim id_transaksi As String = GenerateID()
            Dim username As String = Form1.txtUsername.Text
            Dim tipe_sepeda As String = txtTipeSepeda.Text
            Dim lama_sewa As Integer = CInt(txtLamaSewa.Text)
            Dim total_tarif As Integer = CInt(lbTotalTarif.Text)
            If chHelm.Checked Then
                options.Add("helm")
            End If
            If chExtraBatt.Checked Then
                options.Add("extra batt")
            End If
            Dim paket As String = String.Join(", ", options)
            Dim status As String = "Applied"
            Dim query = "INSERT INTO transaksi (id_transaksi, username, tipe_sepeda, paket, lama_sewa, tarif, status) VALUES (" & id_transaksi & ", '" & username & "', '" & tipe_sepeda & "', '" & paket & "', " & lama_sewa & ", " & total_tarif & ", '" & status & "')"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            RD.Close()
            MsgBox("Pengajuan sewa berhasil", MsgBoxStyle.Information, "Success")
            Clear()
            Panel2.Hide()
            Panel1.Show()
            UserDash.AjukanSewaToolStripMenuItem.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub txtLamaSewa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLamaSewa.KeyPress
        Dim keyChar = e.KeyChar
        If Not Char.IsDigit(keyChar) And Not Char.IsControl(keyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function GenerateID() As Integer
        Dim query = "SELECT COUNT(*) FROM transaksi"
        CMD = New MySqlCommand(query, CONN)
        Dim count = CMD.ExecuteScalar()
        RD.Close()
        Return count + 1
    End Function
End Class