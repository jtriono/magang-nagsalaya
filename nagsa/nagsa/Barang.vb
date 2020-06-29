Imports MySql.Data.MySqlClient
Public Class Formbarang
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampungbarang As New DataTable
    Private Sub Formbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampungbarang.Clear()
        query = "select * from barang"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungbarang)
        dgvbarang.DataSource = tampungbarang
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        Formtambahbarang.ShowDialog()
    End Sub
End Class