Public Class Formpembelian

    Private Sub Formpembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(Label1.Font.FontFamily, 30)
        tb_totalharga.Font = New Font(tb_totalharga.Font.FontFamily, 30)
        Label2.Font = New Font(Label2.Font.FontFamily, 15)
        Label3.Font = New Font(Label3.Font.FontFamily, 15)
        Label4.Font = New Font(Label4.Font.FontFamily, 15)
        Label5.Font = New Font(Label5.Font.FontFamily, 15)
        tb_nonota.Font = New Font(tb_nonota.Font.FontFamily, 15)
        dtptanggal.Font = New Font(dtptanggal.Font.FontFamily, 15)
        tb_nosupplier.Font = New Font(tb_nosupplier.Font.FontFamily, 15)
        dtp_jt.Font = New Font(dtp_jt.Font.FontFamily, 15)

        dtptanggal.Value = DateTime.Now
        dtp_jt.Value = DateTime.Now

        tb_totalharga.Enabled = False
        tb_nonota.Enabled = False
        tbnamabarang.Enabled = False
    End Sub

    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        Isi_Supplier.ShowDialog()
    End Sub
End Class