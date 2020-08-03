<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpembelian
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_totalharga = New System.Windows.Forms.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dtp_jt = New System.Windows.Forms.DateTimePicker()
        Me.dtptanggal = New System.Windows.Forms.DateTimePicker()
        Me.tb_kodesupplier = New System.Windows.Forms.TextBox()
        Me.tb_nonota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbkodebarang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbnamabarang = New System.Windows.Forms.TextBox()
        Me.tbbatch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_ed = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_hargabeli = New System.Windows.Forms.TextBox()
        Me.tb_jumlah = New System.Windows.Forms.TextBox()
        Me.tbdisc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_harga = New System.Windows.Forms.TextBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.dgv_barangbeli = New System.Windows.Forms.DataGridView()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btn_koreksi = New System.Windows.Forms.Button()
        Me.btn_supplier = New System.Windows.Forms.Button()
        Me.cb_satuan = New System.Windows.Forms.ComboBox()
        Me.tbhargadisc = New System.Windows.Forms.TextBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnsimpanhutang = New System.Windows.Forms.Button()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgv_barangbeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Rp."
        '
        'tb_totalharga
        '
        Me.tb_totalharga.Location = New System.Drawing.Point(621, 10)
        Me.tb_totalharga.Name = "tb_totalharga"
        Me.tb_totalharga.Size = New System.Drawing.Size(362, 20)
        Me.tb_totalharga.TabIndex = 1
        Me.tb_totalharga.Text = "0"
        Me.tb_totalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dtp_jt)
        Me.PanelControl1.Controls.Add(Me.dtptanggal)
        Me.PanelControl1.Controls.Add(Me.tb_kodesupplier)
        Me.PanelControl1.Controls.Add(Me.tb_nonota)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Location = New System.Drawing.Point(16, 66)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(719, 174)
        Me.PanelControl1.TabIndex = 2
        '
        'dtp_jt
        '
        Me.dtp_jt.Location = New System.Drawing.Point(234, 133)
        Me.dtp_jt.Name = "dtp_jt"
        Me.dtp_jt.Size = New System.Drawing.Size(200, 21)
        Me.dtp_jt.TabIndex = 10
        '
        'dtptanggal
        '
        Me.dtptanggal.Location = New System.Drawing.Point(234, 50)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(200, 21)
        Me.dtptanggal.TabIndex = 9
        '
        'tb_kodesupplier
        '
        Me.tb_kodesupplier.Location = New System.Drawing.Point(234, 95)
        Me.tb_kodesupplier.Name = "tb_kodesupplier"
        Me.tb_kodesupplier.Size = New System.Drawing.Size(108, 21)
        Me.tb_kodesupplier.TabIndex = 8
        Me.tb_kodesupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_nonota
        '
        Me.tb_nonota.Location = New System.Drawing.Point(234, 11)
        Me.tb_nonota.Name = "tb_nonota"
        Me.tb_nonota.Size = New System.Drawing.Size(108, 21)
        Me.tb_nonota.TabIndex = 7
        Me.tb_nonota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tanggal Jatuh Tempo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kode Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. Nota"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Kode Barang"
        '
        'tbkodebarang
        '
        Me.tbkodebarang.Location = New System.Drawing.Point(88, 257)
        Me.tbkodebarang.Name = "tbkodebarang"
        Me.tbkodebarang.Size = New System.Drawing.Size(88, 20)
        Me.tbkodebarang.TabIndex = 11
        Me.tbkodebarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nama Barang"
        '
        'tbnamabarang
        '
        Me.tbnamabarang.Location = New System.Drawing.Point(303, 257)
        Me.tbnamabarang.Name = "tbnamabarang"
        Me.tbnamabarang.Size = New System.Drawing.Size(198, 20)
        Me.tbnamabarang.TabIndex = 13
        Me.tbnamabarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbbatch
        '
        Me.tbbatch.Location = New System.Drawing.Point(571, 257)
        Me.tbbatch.Name = "tbbatch"
        Me.tbbatch.Size = New System.Drawing.Size(109, 20)
        Me.tbbatch.TabIndex = 14
        Me.tbbatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(530, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Batch"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(707, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "E.D."
        '
        'tb_ed
        '
        Me.tb_ed.Location = New System.Drawing.Point(741, 257)
        Me.tb_ed.Name = "tb_ed"
        Me.tb_ed.Size = New System.Drawing.Size(109, 20)
        Me.tb_ed.TabIndex = 17
        Me.tb_ed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Satuan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(158, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Harga Beli Barang"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(349, 298)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Jumlah"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(487, 298)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Discount"
        '
        'tb_hargabeli
        '
        Me.tb_hargabeli.Location = New System.Drawing.Point(257, 295)
        Me.tb_hargabeli.Name = "tb_hargabeli"
        Me.tb_hargabeli.Size = New System.Drawing.Size(68, 20)
        Me.tb_hargabeli.TabIndex = 23
        Me.tb_hargabeli.Text = "0"
        Me.tb_hargabeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_jumlah
        '
        Me.tb_jumlah.Location = New System.Drawing.Point(395, 295)
        Me.tb_jumlah.Name = "tb_jumlah"
        Me.tb_jumlah.Size = New System.Drawing.Size(66, 20)
        Me.tb_jumlah.TabIndex = 24
        Me.tb_jumlah.Text = "0"
        Me.tb_jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbdisc
        '
        Me.tbdisc.Location = New System.Drawing.Point(542, 295)
        Me.tbdisc.Name = "tbdisc"
        Me.tbdisc.Size = New System.Drawing.Size(64, 20)
        Me.tbdisc.TabIndex = 25
        Me.tbdisc.Text = "0"
        Me.tbdisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(707, 298)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Total Harga"
        '
        'tb_harga
        '
        Me.tb_harga.Location = New System.Drawing.Point(776, 295)
        Me.tb_harga.Name = "tb_harga"
        Me.tb_harga.Size = New System.Drawing.Size(100, 20)
        Me.tb_harga.TabIndex = 27
        Me.tb_harga.Text = "0"
        Me.tb_harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(908, 260)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 51)
        Me.btn_tambah.TabIndex = 28
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'dgv_barangbeli
        '
        Me.dgv_barangbeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barangbeli.Location = New System.Drawing.Point(16, 353)
        Me.dgv_barangbeli.Name = "dgv_barangbeli"
        Me.dgv_barangbeli.Size = New System.Drawing.Size(967, 210)
        Me.dgv_barangbeli.TabIndex = 29
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(16, 584)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 53)
        Me.btnhapus.TabIndex = 31
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(908, 584)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 53)
        Me.btnsimpan.TabIndex = 32
        Me.btnsimpan.Text = "Simpan Nota"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btn_koreksi
        '
        Me.btn_koreksi.Location = New System.Drawing.Point(101, 584)
        Me.btn_koreksi.Name = "btn_koreksi"
        Me.btn_koreksi.Size = New System.Drawing.Size(75, 53)
        Me.btn_koreksi.TabIndex = 33
        Me.btn_koreksi.Text = "Koreksi Nota"
        Me.btn_koreksi.UseVisualStyleBackColor = True
        '
        'btn_supplier
        '
        Me.btn_supplier.Location = New System.Drawing.Point(812, 107)
        Me.btn_supplier.Name = "btn_supplier"
        Me.btn_supplier.Size = New System.Drawing.Size(114, 99)
        Me.btn_supplier.TabIndex = 34
        Me.btn_supplier.Text = "Supplier"
        Me.btn_supplier.UseVisualStyleBackColor = True
        '
        'cb_satuan
        '
        Me.cb_satuan.FormattingEnabled = True
        Me.cb_satuan.Location = New System.Drawing.Point(60, 295)
        Me.cb_satuan.Name = "cb_satuan"
        Me.cb_satuan.Size = New System.Drawing.Size(76, 21)
        Me.cb_satuan.TabIndex = 35
        '
        'tbhargadisc
        '
        Me.tbhargadisc.Location = New System.Drawing.Point(621, 295)
        Me.tbhargadisc.Name = "tbhargadisc"
        Me.tbhargadisc.Size = New System.Drawing.Size(71, 20)
        Me.tbhargadisc.TabIndex = 36
        Me.tbhargadisc.Text = "0"
        Me.tbhargadisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(182, 255)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(26, 23)
        Me.btncari.TabIndex = 37
        Me.btncari.Text = "V"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(827, 584)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 53)
        Me.btnprint.TabIndex = 38
        Me.btnprint.Text = "Print Nota"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnsimpanhutang
        '
        Me.btnsimpanhutang.Location = New System.Drawing.Point(741, 584)
        Me.btnsimpanhutang.Name = "btnsimpanhutang"
        Me.btnsimpanhutang.Size = New System.Drawing.Size(75, 53)
        Me.btnsimpanhutang.TabIndex = 39
        Me.btnsimpanhutang.Text = "Simpan Hutang"
        Me.btnsimpanhutang.UseVisualStyleBackColor = True
        '
        'Formpembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 660)
        Me.Controls.Add(Me.btnsimpanhutang)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.tbhargadisc)
        Me.Controls.Add(Me.cb_satuan)
        Me.Controls.Add(Me.btn_supplier)
        Me.Controls.Add(Me.btn_koreksi)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.dgv_barangbeli)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.tb_harga)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbdisc)
        Me.Controls.Add(Me.tb_jumlah)
        Me.Controls.Add(Me.tb_hargabeli)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_ed)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbbatch)
        Me.Controls.Add(Me.tbnamabarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbkodebarang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tb_totalharga)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formpembelian"
        Me.Text = "Pembelian"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgv_barangbeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_totalharga As System.Windows.Forms.TextBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dtp_jt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_kodesupplier As System.Windows.Forms.TextBox
    Friend WithEvents tb_nonota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbkodebarang As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents tbbatch As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_ed As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_hargabeli As System.Windows.Forms.TextBox
    Friend WithEvents tb_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents tbdisc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_harga As System.Windows.Forms.TextBox
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents dgv_barangbeli As System.Windows.Forms.DataGridView
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btn_koreksi As System.Windows.Forms.Button
    Friend WithEvents btn_supplier As System.Windows.Forms.Button
    Friend WithEvents cb_satuan As System.Windows.Forms.ComboBox
    Friend WithEvents tbhargadisc As System.Windows.Forms.TextBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnsimpanhutang As System.Windows.Forms.Button
End Class
