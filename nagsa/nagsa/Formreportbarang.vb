Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Formreportbarang
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
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


        Dim paramtgl As New ReportParameter("pmtanggal", Formutama.dtpwaktu.Value.ToString)
        ReportViewer1.LocalReport.SetParameters(paramtgl)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class