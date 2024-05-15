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
        getRentInfo()
    End Sub

    Private Function getNama() As String
        Dim username As String = Form1.txtUsername.Text
        CMD = New MySqlCommand("SELECT * FROM pelanggan WHERE username = '" & username & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim nama = RD.Item("nama_pelanggan")
            RD.Close()
            Return nama
        End If
        Return ""
    End Function

    Private Sub AjukanSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjukanSewaToolStripMenuItem.Click
        ApplyRent.Show()
    End Sub

    Private Sub getRentInfo()
        Dim username As String = Form1.txtUsername.Text
        CMD = New MySqlCommand("SELECT * FROM transaksi WHERE username = '" & username & "' AND status IN ('Applied', 'Approved', 'Ongoing')", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            AjukanSewaToolStripMenuItem.Enabled = False
            tipe_sepeda.Text = RD.Item("tipe_sepeda")
            paket.Text = RD.Item("paket")
            lama_sewa.Text = RD.Item("lama_sewa")
            status.Text = RD.Item("status")
            RD.Close()
            If status.Text = "Applied" Then
                statusBox.BackColor = Color.DarkOrange
            ElseIf status.Text = "Approved" Then
                statusBox.BackColor = Color.Green
                Label6.Text = "Sewa Sepeda Listrik Anda Telah Disetujui!, datangi outlet kami untuk mengambil Sepeda anda, dan klik tombol Mulai."
            ElseIf status.Text = "Ongoing" Then
                statusBox.BackColor = Color.Blue
            End If

            If tipe_sepeda.Text = "Ventura R5" Then
                VR5.Show()
                VX.Hide()
                CVX.Hide()
            ElseIf tipe_sepeda.Text = "Varilux Pro" Then
                VR5.Hide()
                VX.Show()
                CVX.Hide()
            ElseIf tipe_sepeda.Text = "Crosser VX" Then
                VR5.Hide()
                VX.Hide()
                CVX.Show()
            End If
        Else
            RD.Close()
            Label2.Text = "Sewa Sepeda Listrik Sekarang!"
            Panel1.Hide()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        getRentInfo()
    End Sub
End Class