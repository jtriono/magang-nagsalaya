Imports MySql.Data.MySqlClient
Public Class Print_Detail_Stok
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String

    Private Sub Print_Detail_Stok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from detail_stok where no_nota = '" + Detail_Stok.tbno_nota.Text + "' and `delete`=0"
        Me.apotikDataSetdetstok.Clear()
        conn.Open()
        comm = New MySqlCommand(query, conn)
        adapt.SelectCommand = comm
        adapt.Fill(Me.apotikDataSetdetstok.detail_stok)
        comm.Dispose()
        adapt.Dispose()
        conn.Close()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class