Imports MySql.Data.MySqlClient
Public Class Nominal_bayar_hutang
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim harga As Integer

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Me.Close()
    End Sub

    Private Sub Nominal_bayar_hutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbharga.Text = Form_Bayar_Hutang.simpanharga
        tbnota.Text = Form_Bayar_Hutang.simpannota
        tbnama.Text = Form_Bayar_Hutang.simpannama
    End Sub

    Private Sub btnbayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        'Try
        '    query = "update hutang set lunas = 1, tanggal_pelunasan = '" + Form_Bayar_Hutang.dtptanggal.Value.ToString + "' where total_harga = '" + Form_Bayar_Hutang.simpanharga + "' and lunas = 0"
        '    connect.Open()
        '    command = New MySqlCommand(query, connect)
        '    command.ExecuteNonQuery()
        '    connect.Close()
        '    MessageBox.Show("data berhasil masuk")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    connect.Close()
        'End Try

        If CInt(tbharga.Text) - CInt(tbinputbayar.Text) = 0 Then
            query = "update hutang set lunas = 1, total_harga = 0 where total_harga = '" + Form_Bayar_Hutang.simpanharga + "' and lunas = 0"
        ElseIf CInt(tbharga.Text) - CInt(tbinputbayar.Text) < 0 Then
            MessageBox.Show("Input Salah")
        ElseIf CInt(tbharga.Text) - CInt(tbinputbayar.Text) > 0 Then
            query = "update hutang set total_harga = '" + harga.ToString + "' where total_harga = '" + Form_Bayar_Hutang.simpanharga + "' and lunas = 0"
        End If
        connect.Open()
        command = New MySqlCommand(query, connect)
        command.ExecuteNonQuery()
        connect.Close()

        query = "insert into bayar_hutang Values('" + tbnota.Text + "','" + tbnama.Text + "', '" + tbinputbayar.Text + "', '" + Form_Bayar_Piutang.dtptanggal.Value.ToString + "',0)"
        connect.Open()
        command = New MySqlCommand(query, connect)
        command.ExecuteNonQuery()
        connect.Close()
        MessageBox.Show("Data Berhasil Masuk")

        tbnota.Text = " "
        tbnama.Text = " "
        tbharga.Text = " "
        tbinputbayar.Text = " "
    End Sub

    Private Sub tbinputbayar_TextChanged(sender As Object, e As EventArgs) Handles tbinputbayar.TextChanged
        Try
            harga = 0
            harga = (CInt(tbharga.Text) - CInt(tbinputbayar.Text))
        Catch ex As Exception

        End Try
        
    End Sub
End Class