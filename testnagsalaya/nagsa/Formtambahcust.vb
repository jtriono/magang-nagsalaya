Imports MySql.Data.MySqlClient
Public Class Formtambahcust
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampungcust As New DataTable
    Dim autoid As String
    Private Sub Btbatal_Click(sender As Object, e As EventArgs) Handles Btbatal.Click
        Me.Close()
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        autoid = ""
        tampungcust = New DataTable
        query = "select * from customer"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungcust)
        If tampungcust.Rows.Count < 9 Then
            autoid = autoid + "C0000" + (tampungcust.Rows.Count + 1).ToString
        ElseIf tampungcust.Rows.Count < 99 Then
            autoid = autoid + "C000" + (tampungcust.Rows.Count + 1).ToString
        ElseIf tampungcust.Rows.Count < 999 Then
            autoid = autoid + "C00" + (tampungcust.Rows.Count + 1).ToString
        ElseIf tampungcust.Rows.Count < 9999 Then
            autoid = autoid + "C0" + (tampungcust.Rows.Count + 1).ToString
        ElseIf tampungcust.Rows.Count < 99999 Then
            autoid = autoid + "C" + (tampungcust.Rows.Count + 1).ToString
        End If

        query = "insert into customer values('" + autoid + "','" + tbnama.Text + "','" + tbalamat.Text + "','" + Tbkota.Text + "','" + Tbnotelp.Text + "','" + Tbnpwp.Text + "')"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("customer berhasil ditambahkan")


    End Sub

    Private Sub Formtambahcust_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Formcustomer.tbcari.Text = ""
        Formcustomer.Buttoncari.PerformClick()
    End Sub
End Class