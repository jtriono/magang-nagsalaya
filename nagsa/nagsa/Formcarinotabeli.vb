Imports MySql.Data.MySqlClient
Public Class Formcarinotabeli
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim dt As New DataTable

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        dt.Clear()
        query = "select no_nota_pembelian, kode_supplier, tanggal_pembelian, tanggal_jt_pembelian, Total_harga_pembelian from pembelian where no_nota_pembelian = '" + TextBox1.Text + "' and  `delete` = 0"
        command = New MySqlCommand(query, connect)
        adapter = New MySqlDataAdapter(command)
        adapter.Fill(dt)
        TextBox2.Text = dt.Rows(0).Item("kode_supplier").ToString
        DateTimePicker1.Value = dt.Rows(0).Item("tanggal_pembelian").ToString
        DateTimePicker2.Value = dt.Rows(0).Item("tanggal_jt_pembelian").ToString
        TextBox3.Text = dt.Rows(0).Item("Total_harga_pembelian").ToString
    End Sub

    Private Sub btnlihat_Click(sender As Object, e As EventArgs) Handles btnlihat.Click
        Formreportbelipernota.ShowDialog()
    End Sub
End Class