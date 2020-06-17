Imports MySql.Data.MySqlClient
Public Class Formpenjualan
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim dt As New DataTable
    Dim autogenerate As String


    Private Sub Formpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(Label1.Font.FontFamily, 30)
        tbtotalharga.Font = New Font(tbtotalharga.Font.FontFamily, 30)
        Label2.Font = New Font(Label2.Font.FontFamily, 15)
        Label3.Font = New Font(Label3.Font.FontFamily, 15)
        no_nota.Font = New Font(no_nota.Font.FontFamily, 15)
        tbno_nota.Font = New Font(tbno_nota.Font.FontFamily, 15)
        tbno_pajak.Font = New Font(tbno_pajak.Font.FontFamily, 15)
        Label4.Font = New Font(Label4.Font.FontFamily, 11)
        dtppilihtanggal.Font = New Font(dtppilihtanggal.Font.FontFamily, 11)
        Label5.Font = New Font(Label5.Font.FontFamily, 11)
        tbkode_cust.Font = New Font(tbkode_cust.Font.FontFamily, 11)
        Label6.Font = New Font(Label6.Font.FontFamily, 11)
        dtpjatuh_tempo.Font = New Font(dtpjatuh_tempo.Font.FontFamily, 11)


        dtpjatuh_tempo.Value = DateTime.Now
        dtppilihtanggal.Value = DateTime.Now

        tbnamabarang.Enabled = False
        tbtotalrp.Enabled = False
        tbno_nota.Enabled = False

        Try
            autogenerate = ""
            dt = New DataTable
            query = "select no_pajak from penjualan"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt)
            If dt.Rows.Count < 10 Then
                autogenerate = autogenerate + "00000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100 Then
                autogenerate = autogenerate + "0000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 1000 Then
                autogenerate = autogenerate + "000" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 10000 Then
                autogenerate = autogenerate + "00" + (dt.Rows.Count + 1).ToString
            ElseIf dt.Rows.Count < 100000 Then
                autogenerate = autogenerate + "0" + (dt.Rows.Count + 1).ToString
            End If
            tbno_nota.Text = autogenerate
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnkoreksi_Click(sender As Object, e As EventArgs) Handles btnkoreksi.Click
        tbno_nota.Enabled = True
    End Sub
End Class