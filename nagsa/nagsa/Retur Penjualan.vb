Imports MySql.Data.MySqlClient
Public Class Retur_Penjualan
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim dt As New DataTable
    Dim autogenerate As String
    Dim harga As String
    Dim harga2 As Integer = 0
    Dim harga3 As Integer = 0


    Private Sub Retur_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(Label1.Font.FontFamily, 30)
        tbtotalharga.Font = New Font(tbtotalharga.Font.FontFamily, 30)
        Label2.Font = New Font(Label2.Font.FontFamily, 15)
        tbno_nota.Font = New Font(tbno_nota.Font.FontFamily, 15)
        Label4.Font = New Font(Label4.Font.FontFamily, 15)
        dtppilihtanggal.Font = New Font(dtppilihtanggal.Font.FontFamily, 15)
        Label5.Font = New Font(Label5.Font.FontFamily, 15)
        tbkode_cust.Font = New Font(tbkode_cust.Font.FontFamily, 15)

        tbno_nota.Enabled = False
    End Sub

    Private Sub tbjumlah_TextChanged(sender As Object, e As EventArgs) Handles tbjumlah.TextChanged
        Try
            harga2 = 0
            If harga2 = 0 Then
                harga2 = CInt(tbhargajual.Text) * CInt(tbjumlah.Text)
            Else
                harga2 = 0
                harga2 = CInt(tbhargajual.Text) * CInt(tbjumlah.Text)
            End If
            tbtotalrp.Text = harga2
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbdisc_TextChanged(sender As Object, e As EventArgs) Handles tbdisc.TextChanged
        Try
            harga3 = 0
            If tbtotalrp.Text = harga2 Then
                harga3 = (CInt(tbtotalrp.Text) * (CInt(tbdisc.Text) / 100))
            ElseIf tbtotalrp.Text <> harga2 Then
                harga3 = 0
                tbtotalrp.Text = harga2
                harga3 = (CInt(tbtotalrp.Text) * (CInt(tbdisc.Text) / 100))
            End If
            tbhargadisc.Text = harga3
            harga3 = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class