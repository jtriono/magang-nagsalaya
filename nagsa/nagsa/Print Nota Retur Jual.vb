Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Print_Nota_Retur_Jual
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String

    Private Sub Print_Nota_Retur_Jual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_retur_jual d,retur_penjualan r where d.no_nota_penjualan=r.no_nota_penjualan and d.`delete`=0 and r.`delete`=0 and retur=1 and no_retur_penjualan='" + Retur_Penjualan.tbno_nota.Text.ToString + "' and d.no_nota_penjualan='" + Retur_Penjualan.tbnopenjualan.Text.ToString + "'"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.detail_retur_jual)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()

        Dim totalparam As New ReportParameter("paramtotalharga", Retur_Penjualan.tbtotalharga.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(totalparam)

        Dim paramtgl As New ReportParameter("tgl", Formutama.dtpwaktu.Value.ToString)
        ReportViewer1.LocalReport.SetParameters(paramtgl)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Print_Nota_Retur_Jual_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        query = "update detail_retur_jual set `delete`=1 where no_nota_penjualan='" + Retur_Penjualan.tbnopenjualan.Text.ToString + "' and kode_barang='" + Retur_Penjualan.pilih + "'"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class