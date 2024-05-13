Imports MySql.Data.MySqlClient
Public Class InventoryManager
    Dim status As String

    Private Sub rbtnTersedia_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTersedia.CheckedChanged
        status = "tersedia"
    End Sub
    Private Sub rbtnDisewa_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDisewa.CheckedChanged
        status = "disewa"
    End Sub
    Private Sub rbtnDiperbaiki_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDiperbaiki.CheckedChanged
        status = "diperbaiki"
    End Sub


    Private Sub FormManajemenInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKodeSepeda.Focus()
        koneksi()
        LoadDGV()
    End Sub

    Sub LoadDGV()
        DataGridView1.Rows.Clear()
        CMD = New MySqlCommand("Select * from sepeda_listrik", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = RD("kode_sepeda")
            row.Cells(1).Value = RD("tipe_sepeda")
            row.Cells(2).Value = RD("kapasitas_baterai")
            row.Cells(3).Value = RD("jarak_tempuh")
            row.Cells(4).Value = RD("tarif")
            row.Cells(5).Value = RD("status")
            row.Cells(6).Value = RD("perawatan_terakhir")
            row.Cells(7).Value = RD("id_stasiun")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub
    Sub Clear()
        txtKodeSepeda.Enabled = True
        txtKodeSepeda.Clear()
        cbTipeSepeda.Enabled = True
        cbTipeSepeda.Text = ""
        txtBaterai.Clear()
        txtJarak.Clear()
        txtTarif.Clear()
        cbStasiun.Text = ""
        rbtnDiperbaiki.Checked = False
        rbtnDisewa.Checked = False
        rbtnDisewa.Checked = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateInput() = True Then
            CMD = New MySqlCommand("Select * from sepeda_listrik where kode_sepeda ='" & txtKodeSepeda.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("INSERT INTO sepeda_listrik (kode_sepeda,tipe_sepeda,kapasitas_baterai,jarak_tempuh,tarif,status,perawatan_terakhir,id_stasiun) VALUES ('" & txtKodeSepeda.Text & "', '" & cbTipeSepeda.Text & "', '" & txtBaterai.Text & "','" & txtJarak.Text & "','" & txtTarif.Text & "' ,'" & status & "','" & dtpPerawatan.Text & "','" & cbStasiun.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                LoadDGV()
                Clear()
                MsgBox("Simpan Data Sukses!")
                txtKodeSepeda.Focus()
            Else
                RD.Close()
                MsgBox("Data Tersebut Sudah Ada")
            End If
        End If
    End Sub

    Private Sub btnbrowse_click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Dim openfiledialog As New openfiledialog()

        'openfiledialog.filter = "gambar|*.jpg;.png;.jpeg"

        'If openfiledialog.showdialog() = dialogresult.ok Then
        '    picturebox1.image = image.fromfile(openfiledialog.filename)
        'End If
    End Sub
    Sub EditSepeda()
        txtKodeSepeda.Enabled = False
        cbTipeSepeda.Enabled = False
        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        txtKodeSepeda.Text = dr.Cells(0).Value.ToString()
        cbTipeSepeda.Text = dr.Cells(1).Value.ToString()
        txtBaterai.Text = dr.Cells(2).Value.ToString()
        txtJarak.Text = dr.Cells(3).Value.ToString()
        txtTarif.Text = dr.Cells(4).Value.ToString()
        status = dr.Cells(5).Value.ToString()
        dtpPerawatan.Value = dr.Cells(6).Value.ToString()
        cbStasiun.Text = dr.Cells(7).Value.ToString()

        ' Set RadioButtonChecked berdasarkan nilai di sel yang sesuai
        If status = "tersedia" Then
            rbtnTersedia.Checked = True
        ElseIf status = "disewa" Then
            rbtnDisewa.Checked = True
        ElseIf status = "diperbaiki" Then
            rbtnDiperbaiki.Checked = True
        Else
            rbtnTersedia.Checked = False
            rbtnDisewa.Checked = False
            rbtnDiperbaiki.Checked = False
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Columns(e.ColumnIndex).Name = "Edit" Then
                EditSepeda()
            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "Update" Then
                If ValidateInput() = True Then
                    Dim ubah As String = "UPDATE sepeda_listrik SET tipe_sepeda = '" & cbTipeSepeda.Text & "', kapasitas_baterai = '" & txtBaterai.Text &
                        "', jarak_tempuh = '" & txtJarak.Text & "', tarif = '" & txtTarif.Text & "', status = '" & status &
                        "',perawatan_terakhir='" & dtpPerawatan.Text & "',id_stasiun='" & cbStasiun.Text & "' WHERE kode_sepeda = '" & txtKodeSepeda.Text & "'"

                    CMD = New MySqlCommand(ubah, CONN)
                    CMD.ExecuteNonQuery()
                    LoadDGV()
                    MsgBox("Data berhasil diubah")
                    Clear()
                End If
            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
                If DataGridView1.SelectedRows.Count > 0 Then
                    EditSepeda()
                    Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        Dim delete As String = "DELETE FROM sepeda_listrik WHERE kode_sepeda = '" & txtKodeSepeda.Text & "'"
                        CMD = New MySqlCommand(delete, CONN)
                        CMD.ExecuteNonQuery()
                        MsgBox("Data berhasil dihapus")
                        LoadDGV()
                        Clear()
                        txtKodeSepeda.Focus()
                    End If
                Else
                    MsgBox("Pilih baris yang ingin dihapus terlebih dahulu.", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ValidateInput() As Boolean
        If txtKodeSepeda.Text = "" Or cbTipeSepeda.Text = "" Or txtBaterai.Text = "" Or txtJarak.Text = "" Or txtTarif.Text = "" Or status = "" Or dtpPerawatan.Text = "" Or cbStasiun.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        Clear()
    End Sub

    Private Function GenerateID() As String
        Dim id As String = ""
        Dim query As String = "SELECT MAX(RIGHT(kode_sepeda, 3)) AS id FROM sepeda_listrik"

        Using CMD = New MySqlCommand(query, CONN)
            Using RD = CMD.ExecuteReader()
                If RD.HasRows Then
                    If RD.Read() Then
                        Dim idValue As Object = RD.Item("id")
                        If Not DBNull.Value.Equals(idValue) Then
                            Dim nextId As Integer = Convert.ToInt32(idValue) + 1
                            id = nextId.ToString("D3")
                        Else
                            id = "001"
                        End If
                    End If
                Else
                    id = "001"
                End If
            End Using
        End Using

        Return id
    End Function

    Private Sub btnGenID_Click(sender As Object, e As EventArgs) Handles btnGenID.Click
        If cbTipeSepeda.SelectedItem = "Ventura R5" Then
            txtKodeSepeda.Text = "VR5" & GenerateID()
        ElseIf cbTipeSepeda.SelectedItem = "Varilux Pro" Then
            txtKodeSepeda.Text = "VP" & GenerateID()
        ElseIf cbTipeSepeda.SelectedItem = "Crosser VX" Then
            txtKodeSepeda.Text = "CVX" & GenerateID()
        End If
    End Sub

    Private Sub cbTipeSepeda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipeSepeda.SelectedIndexChanged
        If cbTipeSepeda.Text = "Ventura R5" Then
            txtTarif.Text = "50000"
            txtBaterai.Text = "960"
            txtJarak.Text = "50"
        ElseIf cbTipeSepeda.Text = "Varilux Pro" Then
            txtTarif.Text = "65000"
            txtBaterai.Text = "960"
            txtJarak.Text = "60"
        ElseIf cbTipeSepeda.Text = "Crosser VX" Then
            txtTarif.Text = "80000"
            txtBaterai.Text = "970"
            txtJarak.Text = "60"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()
    End Sub
End Class