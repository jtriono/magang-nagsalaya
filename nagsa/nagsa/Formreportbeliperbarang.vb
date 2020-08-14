Imports MySql.Data.MySqlClient
Public Class Formreportbeliperbarang
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Private Sub Formreportbeliperbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_pembelian where `delete`=0"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.detail_pembelian)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Buttoncari_Click(sender As Object, e As EventArgs) Handles Buttoncari.Click
        query = "select * from detail_pembelian where `delete`=0 and nama_barang like '%" + tbcari.Text + "%'"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.detail_pembelian)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class