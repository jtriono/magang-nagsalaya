Public Class Formlogin

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        If TextBoxuser.Text <> "MOKO" Or TextBoxpass.Text <> "1234" Then
            MessageBox.Show("Username atau password salah")
        Else
            Me.Visible = False
            TextBoxuser.Text = ""
            TextBoxpass.Text = ""
            Formutama.ShowDialog()
        End If

    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Close()
    End Sub
End Class
