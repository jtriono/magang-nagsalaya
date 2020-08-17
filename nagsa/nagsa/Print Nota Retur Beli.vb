Imports MySql.Data.MySqlClient
Public Class Print_Nota_Retur_Beli
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim datevalue As String

    Private Sub Print_Nota_Retur_Beli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from nota_retur_beli where `delete`= 0 and retur = 1 and no_retur_pembelian='" + Retur_Pembelian.tbno_nota.Text + "'"
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