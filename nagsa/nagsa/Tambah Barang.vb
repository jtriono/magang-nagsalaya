Imports MySql.Data.MySqlClient
Public Class Formtambahbarang
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampungitem As New DataTable
    Dim autoid As String
    Dim datevalue As String
    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        autoid = ""
        tampungitem = New DataTable
        query = "select * from barang"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampungitem)
        If tampungitem.Rows.Count < 9 Then
            autoid = autoid + "I0000" + (tampungitem.Rows.Count + 1).ToString
        ElseIf tampungitem.Rows.Count < 99 Then
            autoid = autoid + "I000" + (tampungitem.Rows.Count + 1).ToString
        ElseIf tampungitem.Rows.Count < 999 Then
            autoid = autoid + "I00" + (tampungitem.Rows.Count + 1).ToString
        ElseIf tampungitem.Rows.Count < 9999 Then
            autoid = autoid + "I0" + (tampungitem.Rows.Count + 1).ToString
        ElseIf tampungitem.Rows.Count < 99999 Then
            autoid = autoid + "I" + (tampungitem.Rows.Count + 1).ToString
        End If
        datevalue = dtpexpire.Value.Date.ToString("yyyy-MM-dd")
        datevalue = datevalue.Replace("/", "-")
        query = "insert into barang values('" + autoid + "','" + tbnama.Text + "','" + tbhbeli.Text + "','" + tbhjual.Text + "','" + tbstok.Text + "','" + tbbatch.Text + "','" + datevalue + "','" + tbsatuan.Text + "','0')"
        conn.Open()
        comm = New MySqlCommand(query, conn)
        comm.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("barang berhasil ditambahkan")

    End Sub

    Private Sub btbatal_Click(sender As Object, e As EventArgs) Handles btbatal.Click
        Me.Close()
    End Sub

    Private Sub Formtambahbarang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Formbarang.textboxcari.Text = ""
        Formbarang.buttoncari.PerformClick()
    End Sub

    
    Private Sub Formtambahbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpexpire.CustomFormat = "yyyy-MM-dd"
    End Sub
End Class