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
            row.Cells(1).Value = RD("merek")
            row.Cells(2).Value = RD("model")
            row.Cells(3).Value = RD("kapasitas_baterai")
            row.Cells(4).Value = RD("jarak_tempuh")
            row.Cells(5).Value = RD("tarif")
            row.Cells(6).Value = RD("status")
            row.Cells(7).Value = RD("perawatan_terakhir")
            row.Cells(8).Value = RD("id_stasiun")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub
    Sub Clear()
        txtKodeSepeda.Clear()
        txtMerek.Clear()
        txtModel.Clear()
        txtBaterai.Clear()
        txtJarak.Clear()
        txtTarif.Clear()
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
                CMD = New MySqlCommand("INSERT INTO sepeda_listrik (kode_sepeda,merek,model,kapasitas_baterai,jarak_tempuh,tarif,status,perawatan_terakhir,id_stasiun) VALUES ('" & txtKodeSepeda.Text & "', '" & txtMerek.Text & "','" & txtModel.Text & "', '" & txtBaterai.Text & "','" & txtJarak.Text & "','" & txtTarif.Text & "' ,'" & status & "','" & dtpPerawatan.Text & "','" & cbStasiun.Text & "')", CONN)
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
        txtKodeSepeda.ReadOnly = True
        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        txtKodeSepeda.Text = dr.Cells(0).Value.ToString()
        txtMerek.Text = dr.Cells(1).Value.ToString()
        txtModel.Text = dr.Cells(2).Value.ToString()
        txtBaterai.Text = dr.Cells(3).Value.ToString()
        txtJarak.Text = dr.Cells(4).Value.ToString()
        txtTarif.Text = dr.Cells(5).Value.ToString()
        status = dr.Cells(6).Value.ToString()
        dtpPerawatan.Value = dr.Cells(7).Value.ToString()
        cbStasiun.Text = dr.Cells(8).Value.ToString()

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
                    Dim ubah As String = "UPDATE sepeda_listrik SET merek = '" & txtMerek.Text & "',model = '" & txtModel.Text & "', kapasitas_baterai = '" & txtBaterai.Text &
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
        If txtKodeSepeda.Text = "" Or txtMerek.Text = "" Or txtModel.Text = "" Or txtBaterai.Text = "" Or txtJarak.Text = "" Or txtTarif.Text = "" Or status = "" Or dtpPerawatan.Text = "" Or cbStasiun.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        Clear()
    End Sub
End Class