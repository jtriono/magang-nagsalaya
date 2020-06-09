Public Class Formutama

    Private Sub btnpenjualan_Click(sender As Object, e As EventArgs) Handles btnpenjualan.Click
        Formpenjualan.ShowDialog()
    End Sub

    Private Sub btnpembelian_Click(sender As Object, e As EventArgs) Handles btnpembelian.Click
        Formpembelian.ShowDialog()
    End Sub

    Private Sub btntambahbarang_Click(sender As Object, e As EventArgs) Handles btntambahbarang.Click
        Formtambahbarang.ShowDialog()
    End Sub

    Private Sub btnsupplier_Click(sender As Object, e As EventArgs) Handles btnsupplier.Click
        Formsupplier.ShowDialog()
    End Sub

    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        Formcustomer.ShowDialog()
    End Sub
    Private Sub Formutama_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Formlogin.Visible = True
    End Sub

    Private Sub btnbarang_Click(sender As Object, e As EventArgs) Handles btnbarang.Click
        Formbarang.ShowDialog()
    End Sub

    Private Sub btnk_Click(sender As Object, e As EventArgs) Handles btnk.Click
        formk.ShowDialog()
    End Sub

    Private Sub btnmaster_Click(sender As Object, e As EventArgs) Handles btnmaster.Click
        Formmaster.ShowDialog()

    End Sub

    Private Sub btnhutangpiutang_Click(sender As Object, e As EventArgs) Handles btnhutangpiutang.Click
        Formhutangpiutang.ShowDialog()

    End Sub

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Formlaporan.ShowDialog()

    End Sub

    Private Sub btnutility_Click(sender As Object, e As EventArgs) Handles btnutility.Click
        Formutility.ShowDialog()

    End Sub
End Class