Imports MySql.Data.MySqlClient
Public Class Formcustomer
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampungcustomer As New DataTable
    Dim dscustomer As New DataSet
    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        Formtambahcust.ShowDialog()
    End Sub

    Private Sub Formcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampungcustomer.Clear()
        query = "select * from customer"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungcustomer)
        dgvcustomer.DataSource = tampungcustomer
    End Sub

    Private Sub Buttonhapus_Click(sender As Object, e As EventArgs) Handles Buttonhapus.Click

    End Sub

    Private Sub Buttoncari_Click(sender As Object, e As EventArgs) Handles Buttoncari.Click
        If tbcari.Text = "" Then
            tampungcustomer.Clear()
            query = "select * from customer"
            comm = New MySqlCommand(query, conn)
            adapt = New MySqlDataAdapter(comm)
            adapt.Fill(tampungcustomer)
            dgvcustomer.DataSource = tampungcustomer
        Else
            tampungcustomer.Clear()
            query = "select * from customer where nama='" + tbcari.Text + "'"
            comm = New MySqlCommand(query, conn)
            adapt = New MySqlDataAdapter(comm)
            adapt.Fill(tampungcustomer)
            dgvcustomer.DataSource = tampungcustomer
        End If  
    End Sub
End Class