Imports MySql.Data.MySqlClient
Public Class Formreportjualpertgl
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim datevalue As String

    'Private Sub Formreportjualpertgl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    datevalue = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
    '    datevalue = datevalue.Replace("/", "-")
    '    MessageBox.Show(datevalue)
    '    query = "select * from penjualan where tanggal_penjualan = '" + datevalue + "' and `delete` = 0"
    '    conn.Open()
    '    comm = New MySqlCommand(query, conn)
    '    adapt.SelectCommand = comm
    '    adapt.Fill(Me.apotikDataSet.penjualan)
    '    comm.Dispose()
    '    adapt.Dispose()
    '    conn.Close()
    '    Me.ReportViewer1.RefreshReport()
    'End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        datevalue = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
        datevalue = datevalue.Replace("/", "-")
        MessageBox.Show(datevalue)
        query = "select * from penjualan where tanggal_penjualan = '" + datevalue + "' and `delete` = 0"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.penjualan)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class