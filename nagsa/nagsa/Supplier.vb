Imports MySql.Data.MySqlClient
Public Class Formsupplier
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampungsupplier As New DataTable
    Dim dscustomer As New DataSet
    Public suppliertest As String
    Public pilihsupplier As Boolean = False
    Dim pilihdgv As String

    Private Sub Formsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampungsupplier.Clear()
        query = "select * from supplier where `delete`=0"
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
            query = "select * from supplier where `delete`=0"
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

    Private Sub dgvsupplier_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsupplier.CellContentDoubleClick
        If pilihsupplier = True Then
            suppliertest = dgvsupplier.Rows(e.RowIndex).Cells(0).Value.ToString
            pilihsupplier = False
            Me.Close()

        End If
    End Sub

   
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        tampungsupplier.Clear()
        query = "update supplier set `delete`=1 where supplierid='" + pilihdgv + "'"
        If MessageBox.Show("Yakin akan menghapus supplier ini?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            conn.Open()
            comm = New MySqlCommand(query, conn)
            comm.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data Berhasil Dihapus")
        End If
        btncari.PerformClick()
    End Sub

    Private Sub dgvsupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsupplier.CellContentClick
        pilihdgv = dgvsupplier.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

End Class