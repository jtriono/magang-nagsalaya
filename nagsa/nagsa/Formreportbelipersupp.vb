Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Formreportbelipersupp
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim supp As String
    Private Sub Formreportbelipersupp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from pembelian where `delete`=0"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.pembelian)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formsupplier.pilihsupplier = True
        Formsupplier.ShowDialog()
        supp = Formsupplier.suppliertest
        query = "select * from pembelian where `delete`=0 and kode_supplier='" + supp + "'"
        Me.apotikDataSet.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.pembelian)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()

        Dim paramtgl As New ReportParameter("tgl", Formutama.dtpwaktu.Value.ToString)
        ReportViewer1.LocalReport.SetParameters(paramtgl)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class