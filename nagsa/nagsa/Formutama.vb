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

    Private Sub Formutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpwaktu.Value = DateTime.Now

        dtpwaktu.Enabled = False
    End Sub

    Private Sub ReturPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturPenjualanToolStripMenuItem.Click
        Retur_Penjualan.ShowDialog()
    End Sub

    Private Sub ReturnPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnPembelianToolStripMenuItem.Click
        Retur_Pembelian.ShowDialog()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
    End Sub

    Private Sub DataSuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSuppliersToolStripMenuItem.Click
        Formsupplier.ShowDialog()
    End Sub

    Private Sub DataCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataCustomerToolStripMenuItem.Click
        Formcustomer.ShowDialog()
    End Sub

    Private Sub BayarHutangCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BayarHutangCustomerToolStripMenuItem.Click
        Form_Bayar_Piutang.ShowDialog()
    End Sub

    Private Sub BayarHutangSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BayarHutangSupplierToolStripMenuItem.Click
        Form_Bayar_Hutang.ShowDialog()
    End Sub

    Private Sub UsernamePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsernamePasswordToolStripMenuItem.Click
        tambah_user.ShowDialog()
    End Sub

    Private Sub KartuStokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KartuStokBarangToolStripMenuItem.Click
        Formreportbarang.ShowDialog()
    End Sub

    Private Sub SemuaBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SemuaBarangToolStripMenuItem1.Click
        Formreportpenjualan.ShowDialog()
    End Sub

    Private Sub HutangSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HutangSupplierToolStripMenuItem.Click
        formreporthutang.ShowDialog()
    End Sub

    Private Sub PiutangPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PiutangPelangganToolStripMenuItem.Click
        Formreportpiutang.ShowDialog()
    End Sub

    Private Sub DaftarSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarSupplierToolStripMenuItem.Click
        Formreportsupplier.ShowDialog()
    End Sub

    Private Sub DaftarCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarCustomerToolStripMenuItem.Click
        Formreportcustomer.ShowDialog()
    End Sub

    Private Sub PerBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PerBarangToolStripMenuItem1.Click
        Formreportjualperbarang.ShowDialog()
    End Sub

    Private Sub PerCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerCustomerToolStripMenuItem.Click
        Formreportjualpercust.ShowDialog()
    End Sub

    Private Sub DetailStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailStokToolStripMenuItem.Click
        Detail_Stok.ShowDialog()
    End Sub

    Private Sub SemuaBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemuaBarangToolStripMenuItem.Click
        formreportpembelian.ShowDialog()
    End Sub

    Private Sub PerBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerBarangToolStripMenuItem.Click
        Formreportbeliperbarang.ShowDialog()
    End Sub

    Private Sub PerSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerSupplierToolStripMenuItem.Click
        Formreportbelipersupp.ShowDialog()
    End Sub

    Private Sub ReturPenjualanHarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturPenjualanHarianToolStripMenuItem.Click
        Formreportreturjualharian.ShowDialog()
    End Sub

    Private Sub ReturPembelianHarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturPembelianHarianToolStripMenuItem.Click
        formreportreturbeliharian.ShowDialog()
    End Sub

    Private Sub PembelianPerTanggalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianPerTanggalToolStripMenuItem.Click

    End Sub

    Private Sub PenjualanPertanggalPPnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanPertanggalPPnToolStripMenuItem.Click
        Formreportjualpertgl.ShowDialog()
    End Sub
End Class