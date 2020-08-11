Imports MySql.Data.MySqlClient
Public Class Print_Menu_Penjualan
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Private Sub Print_Menu_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_penjualan,penjualan where penjualan.no_nota_penjualan ='" + Formpenjualan.tbno_nota.Text.ToString + "' and detail_penjualan.no_nota_penjualan = penjualan.no_nota_penjualan and penjualan.`delete`=0"
        Me.apotikDataSet.Clear()
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