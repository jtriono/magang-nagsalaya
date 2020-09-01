Imports MySql.Data.MySqlClient
Public Class Formbarang
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Public itemtest As String
    Public pilihbarang As Boolean = False
    Dim tampungbarang As New DataTable
    Dim pilihdgv As String
    Private Sub Formbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampungbarang = New DataTable
        query = "select * from barang where `delete`=0 and stokakhir > 0"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungbarang)
        dgvbarang.DataSource = tampungbarang
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        Formtambahbarang.ShowDialog()
    End Sub

    Private Sub dgvbarang_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellContentDoubleClick
        If pilihbarang = True Then
            itemtest = dgvbarang.Rows(e.RowIndex).Cells(0).Value.ToString
            pilihbarang = False
            Me.Close()

        End If
    End Sub

    Private Sub buttoncari_Click(sender As Object, e As EventArgs) Handles buttoncari.Click
        If textboxcari.Text = "" Then
            tampungbarang.Clear()
            query = "select * from barang where `delete`=0 and stokakhir>0"
            comm = New MySqlCommand(query, conn)
            adapt = New MySqlDataAdapter(comm)
            adapt.Fill(tampungbarang)
            dgvbarang.DataSource = tampungbarang
        Else
            tampungbarang.Clear()
            query = "select * from barang where nama like '%" + textboxcari.Text + "%' and `delete`=0 and stokakhir>0"
            comm = New MySqlCommand(query, conn)
            adapt = New MySqlDataAdapter(comm)
            adapt.Fill(tampungbarang)
            dgvbarang.DataSource = tampungbarang
        End If
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        tampungbarang.Clear()
        query = "update barang set `delete`=1 where itemid='" + pilihdgv + "'"
        If MessageBox.Show("Yakin akan menghapus barang ini?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            conn.Open()
            comm = New MySqlCommand(query, conn)
            comm.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data Berhasil Dihapus")
        End If
        buttoncari.PerformClick()
    End Sub

    Private Sub dgvbarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellContentClick
        pilihdgv = dgvbarang.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub
End Class