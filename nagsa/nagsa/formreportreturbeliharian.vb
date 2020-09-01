Imports MySql.Data.MySqlClient
Public Class formreportreturbeliharian
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim datevalue As String

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        datevalue = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
        datevalue = datevalue.Replace("/", "-")
        MessageBox.Show(datevalue)
        query = "select * from nota_retur_beli where `delete`=0 and tanggal_retur_pembelian='" + datevalue + "'"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSetview.nota_retur_beli)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class