Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Print_Menu_Penjualan
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Private Sub Print_Menu_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_penjualan where no_nota_penjualan ='" + Formpenjualan.tbno_nota.Text.ToString + "' and `delete`=0"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.detail_penjualan)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()

        Dim paramnota As New ReportParameter("nonota", Formpenjualan.tbno_nota.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(paramnota)

        Dim parampajak As New ReportParameter("nopajak", Formpenjualan.tbno_pajak.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(parampajak)

        Dim paramcust As New ReportParameter("kodecust", Formpenjualan.tbkode_cust.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(paramcust)

        Dim paramharga As New ReportParameter("totalharga", Formpenjualan.tbtotalharga.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(paramharga)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class