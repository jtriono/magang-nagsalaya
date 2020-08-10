Imports MySql.Data.MySqlClient
Public Class Formreportbarang
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Private Sub Formreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from barang where `delete`=0"
        Me.apotikbarangDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikbarangDataSet.barang)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class