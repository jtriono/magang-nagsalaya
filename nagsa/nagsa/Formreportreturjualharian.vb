Imports MySql.Data.MySqlClient
Public Class Formreportreturjualharian
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim datevalue As String

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        datevalue = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
        datevalue = datevalue.Replace("/", "-")
        query = "select * from nota_retur_jual where `delete`=0 and tanggal_retur_penjualan='" + datevalue + "'"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSetview.nota_retur_jual)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class