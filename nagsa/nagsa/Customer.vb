Imports MySql.Data.MySqlClient
Public Class Formcustomer
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampungcustomer As New DataTable
    Dim pilihdgv As String
    Public customertest As String
    Public pilihcustomer As Boolean = False

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        Formtambahcust.ShowDialog()
    End Sub

    Private Sub Formcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampungcustomer.Clear()
        query = "select * from customer where `delete`=0"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungcustomer)
        dgvcustomer.DataSource = tampungcustomer
    End Sub

    Private Sub Buttonhapus_Click(sender As Object, e As EventArgs) Handles Buttonhapus.Click
        tampungcustomer.Clear()
        query = "update customer set `delete`=1 where customerid='" + pilihdgv + "'"
        If MessageBox.Show("Yakin akan menghapus customer ini?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            conn.Open()
            comm = New MySqlCommand(query, conn)
            comm.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data Berhasil Dihapus")
        End If
        Buttoncari.PerformClick()
    End Sub

    Private Sub Buttoncari_Click(sender As Object, e As EventArgs) Handles Buttoncari.Click
        If tbcari.Text = "" Then
            tampungcustomer.Clear()
            query = "select * from customer where `delete`=0"
            comm = New MySqlCommand(query, conn)
            adapt = New MySqlDataAdapter(comm)
            adapt.Fill(tampungcustomer)
            dgvcustomer.DataSource = tampungcustomer
        Else
            tampungcustomer.Clear()
            query = "select * from customer where nama like '%" + tbcari.Text + "%'"
            comm = New MySqlCommand(query, conn)
            adapt = New MySqlDataAdapter(comm)
            adapt.Fill(tampungcustomer)
            dgvcustomer.DataSource = tampungcustomer
        End If  
    End Sub

    Private Sub dgvcustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomer.CellContentClick
        pilihdgv = dgvcustomer.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub dgvcustomer_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcustomer.CellContentDoubleClick
        If pilihcustomer = True Then
            customertest = dgvcustomer.Rows(e.RowIndex).Cells(0).Value.ToString
            pilihcustomer = False
            Me.Close()
       
        End If
    End Sub
End Class