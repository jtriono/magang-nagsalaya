<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpenjualan
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
        Me.tbtotalharga = New System.Windows.Forms.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.tbno_nota = New System.Windows.Forms.TextBox()
        Me.dtpjatuh_tempo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbkode_cust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbno_pajak = New System.Windows.Forms.TextBox()
        Me.dtppilihtanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbkodebarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbnamabarang = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbbatch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_ed = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbhargajual = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbdisc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbhargadisc = New System.Windows.Forms.TextBox()
        Me.tbtotalrp = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvdetailbarang = New System.Windows.Forms.DataGridView()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnkoreksi = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.cbsatuan = New System.Windows.Forms.ComboBox()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgvdetailbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Rp. "
        '
        'tbtotalharga
        '
        Me.tbtotalharga.Location = New System.Drawing.Point(739, 10)
        Me.tbtotalharga.Name = "tbtotalharga"
        Me.tbtotalharga.Size = New System.Drawing.Size(300, 20)
        Me.tbtotalharga.TabIndex = 1
        Me.tbtotalharga.Text = "0"
        Me.tbtotalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.tbno_nota)
        Me.PanelControl1.Controls.Add(Me.dtpjatuh_tempo)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.tbkode_cust)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.tbno_pajak)
        Me.PanelControl1.Controls.Add(Me.dtppilihtanggal)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Location = New System.Drawing.Point(13, 67)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1026, 150)
        Me.PanelControl1.TabIndex = 2
        '
        'tbno_nota
        '
        Me.tbno_nota.Location = New System.Drawing.Point(126, 12)
        Me.tbno_nota.Name = "tbno_nota"
        Me.tbno_nota.Size = New System.Drawing.Size(138, 21)
        Me.tbno_nota.TabIndex = 24
        Me.tbno_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpjatuh_tempo
        '
        Me.dtpjatuh_tempo.Location = New System.Drawing.Point(126, 116)
        Me.dtpjatuh_tempo.Name = "dtpjatuh_tempo"
        Me.dtpjatuh_tempo.Size = New System.Drawing.Size(156, 21)
        Me.dtpjatuh_tempo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Jatuh Tempo"
        '
        'tbkode_cust
        '
        Me.tbkode_cust.Location = New System.Drawing.Point(126, 87)
        Me.tbkode_cust.Name = "tbkode_cust"
        Me.tbkode_cust.Size = New System.Drawing.Size(121, 21)
        Me.tbkode_cust.TabIndex = 7
        Me.tbkode_cust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Kode Customer"
        '
        'tbno_pajak
        '
        Me.tbno_pajak.Location = New System.Drawing.Point(126, 50)
        Me.tbno_pajak.Name = "tbno_pajak"
        Me.tbno_pajak.Size = New System.Drawing.Size(156, 21)
        Me.tbno_pajak.TabIndex = 5
        Me.tbno_pajak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtppilihtanggal
        '
        Me.dtppilihtanggal.Location = New System.Drawing.Point(867, 9)
        Me.dtppilihtanggal.Name = "dtppilihtanggal"
        Me.dtppilihtanggal.Size = New System.Drawing.Size(154, 21)
        Me.dtppilihtanggal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(757, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "No. Pajak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No. Nota"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Kode Barang"
        '
        'tbkodebarang
        '
        Me.tbkodebarang.Location = New System.Drawing.Point(88, 234)
        Me.tbkodebarang.Name = "tbkodebarang"
        Me.tbkodebarang.Size = New System.Drawing.Size(100, 20)
        Me.tbkodebarang.TabIndex = 4
        Me.tbkodebarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Satuan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(226, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Nama Barang"
        '
        'tbnamabarang
        '
        Me.tbnamabarang.Location = New System.Drawing.Point(304, 234)
        Me.tbnamabarang.Name = "tbnamabarang"
        Me.tbnamabarang.Size = New System.Drawing.Size(195, 20)
        Me.tbnamabarang.TabIndex = 8
        Me.tbnamabarang.Text = "0"
        Me.tbnamabarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(529, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Batch"
        '
        'tbbatch
        '
        Me.tbbatch.Location = New System.Drawing.Point(570, 234)
        Me.tbbatch.Name = "tbbatch"
        Me.tbbatch.Size = New System.Drawing.Size(100, 20)
        Me.tbbatch.TabIndex = 10
        Me.tbbatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(699, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "E.D."
        '
        'tb_ed
        '
        Me.tb_ed.Location = New System.Drawing.Point(733, 234)
        Me.tb_ed.Name = "tb_ed"
        Me.tb_ed.Size = New System.Drawing.Size(100, 20)
        Me.tb_ed.TabIndex = 12
        Me.tb_ed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(192, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Harga Jual"
        '
        'tbhargajual
        '
        Me.tbhargajual.Location = New System.Drawing.Point(256, 271)
        Me.tbhargajual.Name = "tbhargajual"
        Me.tbhargajual.Size = New System.Drawing.Size(100, 20)
        Me.tbhargajual.TabIndex = 14
        Me.tbhargajual.Text = "0"
        Me.tbhargajual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(387, 274)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Jumlah"
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(433, 271)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(66, 20)
        Me.tbjumlah.TabIndex = 16
        Me.tbjumlah.Text = "0"
        Me.tbjumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(524, 274)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Disc %"
        '
        'tbdisc
        '
        Me.tbdisc.Location = New System.Drawing.Point(569, 271)
        Me.tbdisc.Name = "tbdisc"
        Me.tbdisc.Size = New System.Drawing.Size(71, 20)
        Me.tbdisc.TabIndex = 18
        Me.tbdisc.Text = "0"
        Me.tbdisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(669, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Disc Rp."
        '
        'tbhargadisc
        '
        Me.tbhargadisc.Location = New System.Drawing.Point(723, 271)
        Me.tbhargadisc.Name = "tbhargadisc"
        Me.tbhargadisc.Size = New System.Drawing.Size(100, 20)
        Me.tbhargadisc.TabIndex = 20
        Me.tbhargadisc.Text = "0"
        Me.tbhargadisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbtotalrp
        '
        Me.tbtotalrp.Location = New System.Drawing.Point(914, 233)
        Me.tbtotalrp.Name = "tbtotalrp"
        Me.tbtotalrp.Size = New System.Drawing.Size(125, 20)
        Me.tbtotalrp.TabIndex = 21
        Me.tbtotalrp.Text = "0"
        Me.tbtotalrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(857, 236)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Total Rp."
        '
        'dgvdetailbarang
        '
        Me.dgvdetailbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetailbarang.Location = New System.Drawing.Point(16, 322)
        Me.dgvdetailbarang.Name = "dgvdetailbarang"
        Me.dgvdetailbarang.Size = New System.Drawing.Size(1018, 210)
        Me.dgvdetailbarang.TabIndex = 23
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(16, 590)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(83, 47)
        Me.btnubah.TabIndex = 24
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(122, 590)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(81, 47)
        Me.btnhapus.TabIndex = 25
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(848, 590)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(81, 47)
        Me.btnprint.TabIndex = 26
        Me.btnprint.Text = "Print Nota"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(952, 590)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(82, 47)
        Me.btnsimpan.TabIndex = 27
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnkoreksi
        '
        Me.btnkoreksi.Location = New System.Drawing.Point(741, 590)
        Me.btnkoreksi.Name = "btnkoreksi"
        Me.btnkoreksi.Size = New System.Drawing.Size(82, 47)
        Me.btnkoreksi.TabIndex = 28
        Me.btnkoreksi.Text = "Koreksi Nota"
        Me.btnkoreksi.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(914, 265)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(98, 31)
        Me.btn_tambah.TabIndex = 29
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'cbsatuan
        '
        Me.cbsatuan.FormattingEnabled = True
        Me.cbsatuan.Location = New System.Drawing.Point(60, 271)
        Me.cbsatuan.Name = "cbsatuan"
        Me.cbsatuan.Size = New System.Drawing.Size(121, 21)
        Me.cbsatuan.TabIndex = 25
        '
        'Formpenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 665)
        Me.Controls.Add(Me.cbsatuan)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btnkoreksi)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.dgvdetailbarang)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tbtotalrp)
        Me.Controls.Add(Me.tbhargadisc)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbdisc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbjumlah)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbhargajual)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tb_ed)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbbatch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbnamabarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbkodebarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tbtotalharga)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formpenjualan"
        Me.Text = "Penjualan"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgvdetailbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbtotalharga As System.Windows.Forms.TextBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtppilihtanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbno_pajak As System.Windows.Forms.TextBox
    Friend WithEvents tbkode_cust As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpjatuh_tempo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbkodebarang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbbatch As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tb_ed As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbhargajual As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbdisc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbhargadisc As System.Windows.Forms.TextBox
    Friend WithEvents tbtotalrp As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgvdetailbarang As System.Windows.Forms.DataGridView
    Friend WithEvents tbno_nota As System.Windows.Forms.TextBox
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnkoreksi As System.Windows.Forms.Button
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents cbsatuan As System.Windows.Forms.ComboBox
End Class
