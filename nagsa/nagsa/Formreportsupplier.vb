Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Formreportsupplier
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Private Sub Formreportsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from supplier where `delete`=0"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.supplier)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Dim paramtgl As New ReportParameter("tgl", Formutama.dtpwaktu.Value.ToString)
        ReportViewer1.LocalReport.SetParameters(paramtgl)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class