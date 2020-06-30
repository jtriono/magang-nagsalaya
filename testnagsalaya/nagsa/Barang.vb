Imports MySql.Data.MySqlClient
Public Class Formbarang
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Public itemtest As String
    Private Sub Formbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tampungbarang As New DataTable
        query = "select * from barang"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungbarang)
        dgvbarang.DataSource = tampungbarang
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        Formtambahbarang.ShowDialog()
    End Sub

    Private Sub dgvbarang_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellContentDoubleClick
        itemtest = dgvbarang.Rows(e.RowIndex).Cells(0).Value.ToString
        Me.Close()
    End Sub

End Class