Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Print_Nota_Retur_Beli
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String

    Private Sub Print_Nota_Retur_Beli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_retur_beli d,retur_pembelian r where d.no_nota_pembelian=r.no_nota_pembelian and d.`delete`=0 and r.`delete`=0 and retur=1 and no_retur_pembelian='" + Retur_Pembelian.tbno_nota.Text.ToString + "' and d.no_nota_pembelian='" + Retur_Pembelian.tbnopembelian.Text.ToString + "'"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.detail_retur_beli)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()

        Dim parameterharga As New ReportParameter("totalharga", Retur_Pembelian.tbtotalharga.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(parameterharga)

        Dim paramtgl As New ReportParameter("tgl", Formutama.dtpwaktu.Value.ToString)
        ReportViewer1.LocalReport.SetParameters(paramtgl)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Print_Nota_Retur_Beli_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        query = "update detail_retur_beli d,retur_pembelian r set d.`delete`=1 where d.no_nota_pembelian=r.no_nota_pembelian and no_retur_pembelian='" + Retur_Pembelian.tbno_nota.Text.ToString + "'"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class