Imports MySql.Data.MySqlClient
Public Class Formsupplier
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampungsupplier As New DataTable
    Dim dscustomer As New DataSet

    Private Sub Formsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampungsupplier.Clear()
        query = "select * from supplier"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungsupplier)
        dgvsupplier.DataSource = tampungsupplier
    End Sub

   
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        formIsi_Supplier.ShowDialog()
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If textboxcari.Text = "" Then
            tampungsupplier.Clear()
            query = "select * from supplier"
            comm = New MySqlCommand(query, conn)
            adapt = New MySqlDataAdapter(comm)
            adapt.Fill(tampungsupplier)
            dgvsupplier.DataSource = tampungsupplier
        Else
            tampungsupplier.Clear()
            query = "select * from supplier where nama like '%" + textboxcari.Text + "%'"
            comm = New MySqlCommand(query, conn)
            adapt = New MySqlDataAdapter(comm)
            adapt.Fill(tampungsupplier)
            dgvsupplier.DataSource = tampungsupplier
        End If
    End Sub
End Class