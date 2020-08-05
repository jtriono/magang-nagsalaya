Imports MySql.Data.MySqlClient
Public Class Formlogin
    Dim conn As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik")
    Dim comm As New MySqlCommand
    Dim adapt As New MySqlDataAdapter
    Dim query As String
    Dim tampunguser As New DataTable
    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        query = "select username,password from userid where username='" + TextBoxuser.Text + "'"
        comm = New MySqlCommand(query, conn)
        adapt = New MySqlDataAdapter(comm)
        adapt.Fill(tampunguser)
        If TextBoxuser.Text = tampunguser.Rows(0).Item(0).ToString And TextBoxpass.Text = tampunguser.Rows(0).Item(1).ToString Then
            Me.Visible = False
            TextBoxuser.Text = ""
            TextBoxpass.Text = ""
            Formutama.ShowDialog()
        Else
            MessageBox.Show("username atau password salah")
        End If
        tampunguser.Clear()
    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Close()
    End Sub


    Private Sub TextBoxpass_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxpass.KeyUp
        If e.KeyCode = Keys.Enter Then
            btlogin.PerformClick()
        End If

    End Sub
End Class
