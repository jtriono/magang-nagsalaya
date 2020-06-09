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
End Class