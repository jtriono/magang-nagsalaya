Imports MySql.Data.MySqlClient
Public Class Formreportbelipernota
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim textvalue As String

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        textvalue = tbnota.Text
        query = "select * from detail_pembelian dp, pembelian p where p.no_nota_pembelian = dp.no_nota_pembelian and p.no_nota_pembelian = '" + textvalue + "' and p.`delete` = 0"
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