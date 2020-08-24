Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Formreportbelipernota
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String

    Private Sub Formreportbelipernota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_pembelian dp where no_nota_pembelian = '" + Formcarinotabeli.TextBox1.Text + "' and `delete` = 0"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSet.detail_pembelian)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()

        Dim paramsupp As New ReportParameter("kodesupp", Formcarinotabeli.TextBox2.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(paramsupp)

        Dim paramharga As New ReportParameter("totalharga", Formcarinotabeli.TextBox3.Text.ToString)
        ReportViewer1.LocalReport.SetParameters(paramharga)

        Dim paramtgl As New ReportParameter("tgl", Formutama.dtpwaktu.Value.ToString)
        ReportViewer1.LocalReport.SetParameters(paramtgl)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class