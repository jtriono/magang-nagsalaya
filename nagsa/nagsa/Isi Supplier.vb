Imports MySql.Data.MySqlClient
Public Class formIsi_Supplier
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampungsupp As New DataTable
    Dim autoid As String

    
    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        autoid = ""
        tampungsupp = New DataTable
        query = "select * from supplier"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungsupp)
        If tampungsupp.Rows.Count < 9 Then
            autoid = autoid + "S0000" + (tampungsupp.Rows.Count + 1).ToString
        ElseIf tampungsupp.Rows.Count < 99 Then
            autoid = autoid + "S000" + (tampungsupp.Rows.Count + 1).ToString
        ElseIf tampungsupp.Rows.Count < 999 Then
            autoid = autoid + "S00" + (tampungsupp.Rows.Count + 1).ToString
        ElseIf tampungsupp.Rows.Count < 9999 Then
            autoid = autoid + "S0" + (tampungsupp.Rows.Count + 1).ToString
        ElseIf tampungsupp.Rows.Count < 99999 Then
            autoid = autoid + "S" + (tampungsupp.Rows.Count + 1).ToString
        End If

        query = "insert into supplier values('" + autoid + "','" + tbnama.Text + "','" + tbalamat.Text + "','" + tbkota.Text + "','" + tbtelpon.Text + "','" + tbhutang.Text + "','0')"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("supplier berhasil ditambahkan")

    End Sub

   
    Private Sub btbatal_Click(sender As Object, e As EventArgs) Handles btbatal.Click
        Me.Close()
    End Sub
End Class