Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Formreportjualpercust
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim cust As String
    Private Sub Formreportjualpercust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from penjualan where `delete`=0"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.penjualan)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Dim paramtgl As New ReportParameter("tgl", Formutama.dtpwaktu.Value.ToString)
        ReportViewer1.LocalReport.SetParameters(paramtgl)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btcarisup_Click(sender As Object, e As EventArgs) Handles btcaricust.Click
        Formcustomer.pilihcustomer = True
        Formcustomer.ShowDialog()
        cust = Formcustomer.customertest
        query = "select * from penjualan where `delete`=0 and kode_customer='" + cust + "'"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.penjualan)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Dim paramtgl As New ReportParameter("tgl", Formutama.dtpwaktu.Value.ToString)
        ReportViewer1.LocalReport.SetParameters(paramtgl)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class