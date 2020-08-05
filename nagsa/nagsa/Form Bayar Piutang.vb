Imports MySql.Data.MySqlClient
Public Class Form_Bayar_Piutang
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Public pilih As String
    Dim dt As New DataTable
    Dim simpandetail As String
    Public simpanharga As String
    Public simpannota As String
    Public simpannama As String


    Private Sub btnmasukharga_Click(sender As Object, e As EventArgs) Handles btnmasukharga.Click
        simpannota = dt.Rows(simpandetail).Item(0)
        simpannama = dt.Rows(simpandetail).Item(1)
        simpanharga = dt.Rows(simpandetail).Item(2)

        Nominal_bayar_piutang.ShowDialog()
    End Sub

    Private Sub Form_Bayar_Piutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtptanggal.Value = DateTime.Now
        dtptanggal.Enabled = False
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Try
            dt.Clear()
            query = "select no_nota_penjualan,nama_cust,total_harga,tanggal_transaksi from piutang where nama_cust = '" + tbnamacust.Text + "' and lunas = 0"
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