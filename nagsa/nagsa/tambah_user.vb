Imports MySql.Data.MySqlClient
Public Class tambah_user
    Dim connect As New MySqlConnection("server=localhost;uid=root;pwd=admin;database=apotik;port=3306")
    Dim command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim query As String
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim count As Integer = 0

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        dt = New DataTable
        query = "insert into userid value ('" + tbuser.Text + "','" + tbpwd.Text + "','" + cblevel.Text + "',0)"
        connect.Open()
        command = New MySqlCommand(query, connect)
        command.ExecuteNonQuery()
        connect.Close()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Try
            dt2 = New DataTable
            query = "select username,password,level,`delete` from userid where `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            count = count + 1
            tbuser.Text = dt2.Rows(count).Item("username")
            tbpwd.Text = dt2.Rows(count).Item("password")
            cblevel.Text = dt2.Rows(count).Item("level")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        Try
            dt2 = New DataTable
            query = "select username,password,level,`delete` from userid where `delete` = 0"
            command = New MySqlCommand(query, connect)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(dt2)
            count = count - 1
            tbuser.Text = dt2.Rows(count).Item("username")
            tbpwd.Text = dt2.Rows(count).Item("password")
            cblevel.Text = dt2.Rows(count).Item("level")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Try
            dt = New DataTable
            query = "update userid set `delete` = 1 where username = '" + tbuser.Text + "' and `delete` = 0"
            If MessageBox.Show("Yakin akan menghapus user?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                connect.Open()
                command = New MySqlCommand(query, connect)
                command.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("User berhasil dihapus")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            connect.Close()
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        tbuser.Text = " "
        tbpwd.Text = " "
        cblevel.Text = " "
    End Sub
End Class