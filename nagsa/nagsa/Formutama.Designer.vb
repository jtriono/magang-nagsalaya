<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formutama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnpenjualan = New System.Windows.Forms.Button()
        Me.btnpembelian = New System.Windows.Forms.Button()
        Me.btntambahbarang = New System.Windows.Forms.Button()
        Me.btnsupplier = New System.Windows.Forms.Button()
        Me.btncustomer = New System.Windows.Forms.Button()
        Me.dtpwaktu = New System.Windows.Forms.DateTimePicker()
        Me.btnbarang = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HutangPiutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BayarHutangCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BayarHutangSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KartuStokBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianPerBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemuaBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanPerBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerBarangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemuaBarangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanPertanggalPPnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturPenjualanHarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianPerTanggalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianPerNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturPembelianHarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiutangPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HutangSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsernamePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnpenjualan
        '
        Me.btnpenjualan.Location = New System.Drawing.Point(512, 54)
        Me.btnpenjualan.Name = "btnpenjualan"
        Me.btnpenjualan.Size = New System.Drawing.Size(198, 120)
        Me.btnpenjualan.TabIndex = 0
        Me.btnpenjualan.Text = "Penjualan"
        Me.btnpenjualan.UseVisualStyleBackColor = True
        '
        'btnpembelian
        '
        Me.btnpembelian.Location = New System.Drawing.Point(12, 190)
        Me.btnpembelian.Name = "btnpembelian"
        Me.btnpembelian.Size = New System.Drawing.Size(198, 120)
        Me.btnpembelian.TabIndex = 1
        Me.btnpembelian.Text = "Pembelian"
        Me.btnpembelian.UseVisualStyleBackColor = True
        '
        'btntambahbarang
        '
        Me.btntambahbarang.Location = New System.Drawing.Point(263, 54)
        Me.btntambahbarang.Name = "btntambahbarang"
        Me.btntambahbarang.Size = New System.Drawing.Size(198, 120)
        Me.btntambahbarang.TabIndex = 2
        Me.btntambahbarang.Text = "Tambah Barang"
        Me.btntambahbarang.UseVisualStyleBackColor = True
        '
        'btnsupplier
        '
        Me.btnsupplier.Location = New System.Drawing.Point(263, 190)
        Me.btnsupplier.Name = "btnsupplier"
        Me.btnsupplier.Size = New System.Drawing.Size(198, 120)
        Me.btnsupplier.TabIndex = 3
        Me.btnsupplier.Text = "Supplier"
        Me.btnsupplier.UseVisualStyleBackColor = True
        '
        'btncustomer
        '
        Me.btncustomer.Location = New System.Drawing.Point(512, 190)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(198, 120)
        Me.btncustomer.TabIndex = 4
        Me.btncustomer.Text = "Customer"
        Me.btncustomer.UseVisualStyleBackColor = True
        '
        'dtpwaktu
        '
        Me.dtpwaktu.Location = New System.Drawing.Point(12, 366)
        Me.dtpwaktu.Name = "dtpwaktu"
        Me.dtpwaktu.Size = New System.Drawing.Size(116, 20)
        Me.dtpwaktu.TabIndex = 5
        Me.dtpwaktu.Value = New Date(2020, 6, 9, 10, 44, 0, 0)
        '
        'btnbarang
        '
        Me.btnbarang.Location = New System.Drawing.Point(12, 54)
        Me.btnbarang.Name = "btnbarang"
        Me.btnbarang.Size = New System.Drawing.Size(198, 120)
        Me.btnbarang.TabIndex = 9
        Me.btnbarang.Text = "Barang"
        Me.btnbarang.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KToolStripMenuItem, Me.MasterToolStripMenuItem, Me.HutangPiutangToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.UtilityToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KToolStripMenuItem
        '
        Me.KToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturPenjualanToolStripMenuItem, Me.ReturnPembelianToolStripMenuItem})
        Me.KToolStripMenuItem.Name = "KToolStripMenuItem"
        Me.KToolStripMenuItem.Size = New System.Drawing.Size(26, 20)
        Me.KToolStripMenuItem.Text = "K"
        '
        'ReturPenjualanToolStripMenuItem
        '
        Me.ReturPenjualanToolStripMenuItem.Name = "ReturPenjualanToolStripMenuItem"
        Me.ReturPenjualanToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ReturPenjualanToolStripMenuItem.Text = "Return Penjualan"
        '
        'ReturnPembelianToolStripMenuItem
        '
        Me.ReturnPembelianToolStripMenuItem.Name = "ReturnPembelianToolStripMenuItem"
        Me.ReturnPembelianToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ReturnPembelianToolStripMenuItem.Text = "Return Pembelian"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSuppliersToolStripMenuItem, Me.DataCustomerToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DataSuppliersToolStripMenuItem
        '
        Me.DataSuppliersToolStripMenuItem.Name = "DataSuppliersToolStripMenuItem"
        Me.DataSuppliersToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DataSuppliersToolStripMenuItem.Text = "Data Suppliers"
        '
        'DataCustomerToolStripMenuItem
        '
        Me.DataCustomerToolStripMenuItem.Name = "DataCustomerToolStripMenuItem"
        Me.DataCustomerToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DataCustomerToolStripMenuItem.Text = "Data Customers"
        '
        'HutangPiutangToolStripMenuItem
        '
        Me.HutangPiutangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BayarHutangCustomerToolStripMenuItem, Me.BayarHutangSupplierToolStripMenuItem})
        Me.HutangPiutangToolStripMenuItem.Name = "HutangPiutangToolStripMenuItem"
        Me.HutangPiutangToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.HutangPiutangToolStripMenuItem.Text = "Hutang Piutang"
        '
        'BayarHutangCustomerToolStripMenuItem
        '
        Me.BayarHutangCustomerToolStripMenuItem.Name = "BayarHutangCustomerToolStripMenuItem"
        Me.BayarHutangCustomerToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.BayarHutangCustomerToolStripMenuItem.Text = "Bayar Piutang Customer"
        '
        'BayarHutangSupplierToolStripMenuItem
        '
        Me.BayarHutangSupplierToolStripMenuItem.Name = "BayarHutangSupplierToolStripMenuItem"
        Me.BayarHutangSupplierToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.BayarHutangSupplierToolStripMenuItem.Text = "Bayar Hutang Supplier"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailStokToolStripMenuItem, Me.KartuStokBarangToolStripMenuItem, Me.LaporanPembelianPerBarangToolStripMenuItem, Me.LaporanPenjualanPerBarangToolStripMenuItem, Me.DaftarSupplierToolStripMenuItem, Me.DaftarCustomerToolStripMenuItem, Me.PenjualanPertanggalPPnToolStripMenuItem, Me.ReturPenjualanHarianToolStripMenuItem, Me.PembelianPerTanggalToolStripMenuItem, Me.PembelianPerNotaToolStripMenuItem, Me.ReturPembelianHarianToolStripMenuItem, Me.PiutangPelangganToolStripMenuItem, Me.HutangSupplierToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DetailStokToolStripMenuItem
        '
        Me.DetailStokToolStripMenuItem.Name = "DetailStokToolStripMenuItem"
        Me.DetailStokToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DetailStokToolStripMenuItem.Text = "Detail Stok"
        '
        'KartuStokBarangToolStripMenuItem
        '
        Me.KartuStokBarangToolStripMenuItem.Name = "KartuStokBarangToolStripMenuItem"
        Me.KartuStokBarangToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.KartuStokBarangToolStripMenuItem.Text = "Kartu Stok Barang"
        '
        'LaporanPembelianPerBarangToolStripMenuItem
        '
        Me.LaporanPembelianPerBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerBarangToolStripMenuItem, Me.SemuaBarangToolStripMenuItem, Me.PerSupplierToolStripMenuItem})
        Me.LaporanPembelianPerBarangToolStripMenuItem.Name = "LaporanPembelianPerBarangToolStripMenuItem"
        Me.LaporanPembelianPerBarangToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LaporanPembelianPerBarangToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'PerBarangToolStripMenuItem
        '
        Me.PerBarangToolStripMenuItem.Name = "PerBarangToolStripMenuItem"
        Me.PerBarangToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PerBarangToolStripMenuItem.Text = "Per-Barang"
        '
        'SemuaBarangToolStripMenuItem
        '
        Me.SemuaBarangToolStripMenuItem.Name = "SemuaBarangToolStripMenuItem"
        Me.SemuaBarangToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SemuaBarangToolStripMenuItem.Text = "Semua Barang"
        '
        'PerSupplierToolStripMenuItem
        '
        Me.PerSupplierToolStripMenuItem.Name = "PerSupplierToolStripMenuItem"
        Me.PerSupplierToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PerSupplierToolStripMenuItem.Text = "Per-Supplier"
        '
        'LaporanPenjualanPerBarangToolStripMenuItem
        '
        Me.LaporanPenjualanPerBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerBarangToolStripMenuItem1, Me.SemuaBarangToolStripMenuItem1, Me.PerCustomerToolStripMenuItem})
        Me.LaporanPenjualanPerBarangToolStripMenuItem.Name = "LaporanPenjualanPerBarangToolStripMenuItem"
        Me.LaporanPenjualanPerBarangToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LaporanPenjualanPerBarangToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'PerBarangToolStripMenuItem1
        '
        Me.PerBarangToolStripMenuItem1.Name = "PerBarangToolStripMenuItem1"
        Me.PerBarangToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PerBarangToolStripMenuItem1.Text = "Per-Barang"
        '
        'SemuaBarangToolStripMenuItem1
        '
        Me.SemuaBarangToolStripMenuItem1.Name = "SemuaBarangToolStripMenuItem1"
        Me.SemuaBarangToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SemuaBarangToolStripMenuItem1.Text = "Semua Barang"
        '
        'PerCustomerToolStripMenuItem
        '
        Me.PerCustomerToolStripMenuItem.Name = "PerCustomerToolStripMenuItem"
        Me.PerCustomerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PerCustomerToolStripMenuItem.Text = "Per-Customer"
        '
        'DaftarSupplierToolStripMenuItem
        '
        Me.DaftarSupplierToolStripMenuItem.Name = "DaftarSupplierToolStripMenuItem"
        Me.DaftarSupplierToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DaftarSupplierToolStripMenuItem.Text = "Daftar Supplier"
        '
        'DaftarCustomerToolStripMenuItem
        '
        Me.DaftarCustomerToolStripMenuItem.Name = "DaftarCustomerToolStripMenuItem"
        Me.DaftarCustomerToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DaftarCustomerToolStripMenuItem.Text = "Daftar Customer"
        '
        'PenjualanPertanggalPPnToolStripMenuItem
        '
        Me.PenjualanPertanggalPPnToolStripMenuItem.Name = "PenjualanPertanggalPPnToolStripMenuItem"
        Me.PenjualanPertanggalPPnToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PenjualanPertanggalPPnToolStripMenuItem.Text = "Penjualan Pertanggal"
        '
        'ReturPenjualanHarianToolStripMenuItem
        '
        Me.ReturPenjualanHarianToolStripMenuItem.Name = "ReturPenjualanHarianToolStripMenuItem"
        Me.ReturPenjualanHarianToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ReturPenjualanHarianToolStripMenuItem.Text = "Retur Penjualan Harian"
        '
        'PembelianPerTanggalToolStripMenuItem
        '
        Me.PembelianPerTanggalToolStripMenuItem.Name = "PembelianPerTanggalToolStripMenuItem"
        Me.PembelianPerTanggalToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PembelianPerTanggalToolStripMenuItem.Text = "Pembelian PerTanggal"
        '
        'PembelianPerNotaToolStripMenuItem
        '
        Me.PembelianPerNotaToolStripMenuItem.Name = "PembelianPerNotaToolStripMenuItem"
        Me.PembelianPerNotaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PembelianPerNotaToolStripMenuItem.Text = "Pembelian PerNota"
        '
        'ReturPembelianHarianToolStripMenuItem
        '
        Me.ReturPembelianHarianToolStripMenuItem.Name = "ReturPembelianHarianToolStripMenuItem"
        Me.ReturPembelianHarianToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ReturPembelianHarianToolStripMenuItem.Text = "Retur Pembelian Harian"
        '
        'PiutangPelangganToolStripMenuItem
        '
        Me.PiutangPelangganToolStripMenuItem.Name = "PiutangPelangganToolStripMenuItem"
        Me.PiutangPelangganToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PiutangPelangganToolStripMenuItem.Text = "Piutang Customer"
        '
        'HutangSupplierToolStripMenuItem
        '
        Me.HutangSupplierToolStripMenuItem.Name = "HutangSupplierToolStripMenuItem"
        Me.HutangSupplierToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.HutangSupplierToolStripMenuItem.Text = "Hutang Supplier"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsernamePasswordToolStripMenuItem})
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'UsernamePasswordToolStripMenuItem
        '
        Me.UsernamePasswordToolStripMenuItem.Name = "UsernamePasswordToolStripMenuItem"
        Me.UsernamePasswordToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.UsernamePasswordToolStripMenuItem.Text = "Username and Password"
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(635, 366)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnlogout.TabIndex = 12
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Formutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 398)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnbarang)
        Me.Controls.Add(Me.dtpwaktu)
        Me.Controls.Add(Me.btncustomer)
        Me.Controls.Add(Me.btnsupplier)
        Me.Controls.Add(Me.btntambahbarang)
        Me.Controls.Add(Me.btnpembelian)
        Me.Controls.Add(Me.btnpenjualan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formutama"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnpenjualan As System.Windows.Forms.Button
    Friend WithEvents btnpembelian As System.Windows.Forms.Button
    Friend WithEvents btntambahbarang As System.Windows.Forms.Button
    Friend WithEvents btnsupplier As System.Windows.Forms.Button
    Friend WithEvents btncustomer As System.Windows.Forms.Button
    Friend WithEvents dtpwaktu As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnbarang As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HutangPiutangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BayarHutangCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BayarHutangSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailStokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KartuStokBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPembelianPerBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemuaBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanPerBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanPertanggalPPnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerBarangToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemuaBarangToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturPenjualanHarianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianPerTanggalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianPerNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturPembelianHarianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PiutangPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HutangSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsernamePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnlogout As System.Windows.Forms.Button
End Class
