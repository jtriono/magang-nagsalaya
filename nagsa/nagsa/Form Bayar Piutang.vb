Imports MySql.Data.MySqlClient
Public Class Form_Bayar_Piutang
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Public pilih As String
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim simpandetail As String
    Public simpanharga As String

    Private Sub btnmasukharga_Click(sender As Object, e As EventArgs) Handles btnmasukharga.Click
        simpanharga = dt2.Rows(simpandetail).Item(2)

        Nominal_bayar_piutang.ShowDialog()
    End Sub

    Private Sub Form_Bayar_Piutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtptanggal.Value = DateTime.Now
        dtptanggal.Enabled = False
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Try
            dt.Clear()
            query = "select no_nota_penjualan,nama_cust,total_harga from piutang where nama_cust = '" + tbnamacust.Text + "' and lunas = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pilih = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        simpandetail = DataGridView1.CurrentRow.Index
    End Sub

    
    Private Sub Buttonpilihcustomer_Click(sender As Object, e As EventArgs) Handles Buttonpilihcustomer.Click
        Formcustomer.pilihcustomer = True
        Formcustomer.ShowDialog()
        tbnamacust.Text = Formcustomer.customertest
    End Sub
End Class