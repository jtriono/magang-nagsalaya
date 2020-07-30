Imports MySql.Data.MySqlClient
Public Class Nominal_bayar_hutang
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Me.Close()
    End Sub

    Private Sub Nominal_bayar_hutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbharga.Text = Form_Bayar_Hutang.simpanharga
    End Sub

    Private Sub btnbayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        Try
            query = "update from hutang set lunas = 1 where total_harga = '" + Form_Bayar_Hutang.pilih + "' lunas = 0"
            connect.Open()
            command = New MySqlCommand(query, connect)
            command.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub
End Class