Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Print_Menu_Pembelian
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Private Sub Print_Menu_Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_pembelian where no_nota_pembelian ='" + Formpembelian.tb_nonota.Text.ToString + "' and `delete`=0"
        Me.apotikDataSetview.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.detail_pembelian)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()

        Dim paramnota As New ReportParameter("nonota", Formpembelian.tb_nonota.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(paramnota)

        Dim paramsupp As New ReportParameter("kodesupp", Formpembelian.tb_kodesupplier.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(paramsupp)

        Dim paramharga As New ReportParameter("totalharga", Formpembelian.tb_totalharga.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(paramharga)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class