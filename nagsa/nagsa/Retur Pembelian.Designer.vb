<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retur_Pembelian
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
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.tbhargadisc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbtotalrp = New System.Windows.Forms.TextBox()
        Me.tbdisc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbhargajual = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbnamabarang = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbkodebarang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.tbno_nota = New System.Windows.Forms.TextBox()
        Me.tbkode_supplier = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtppilihtanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbtotalharga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvdetailbarang = New System.Windows.Forms.DataGridView()
        Me.btnkoreksi = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.tb_ed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbbatch = New System.Windows.Forms.TextBox()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgvdetailbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(849, 218)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(98, 59)
        Me.btn_tambah.TabIndex = 57
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'tbhargadisc
        '
        Me.tbhargadisc.Location = New System.Drawing.Point(488, 257)
        Me.tbhargadisc.Name = "tbhargadisc"
        Me.tbhargadisc.Size = New System.Drawing.Size(71, 20)
        Me.tbhargadisc.TabIndex = 56
        Me.tbhargadisc.Text = "0"
        Me.tbhargadisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(592, 261)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Total Rp."
        '
        'tbtotalrp
        '
        Me.tbtotalrp.Location = New System.Drawing.Point(649, 257)
        Me.tbtotalrp.Name = "tbtotalrp"
        Me.tbtotalrp.Size = New System.Drawing.Size(85, 20)
        Me.tbtotalrp.TabIndex = 54
        Me.tbtotalrp.Text = "0"
        Me.tbtotalrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbdisc
        '
        Me.tbdisc.Location = New System.Drawing.Point(399, 257)
        Me.tbdisc.Name = "tbdisc"
        Me.tbdisc.Size = New System.Drawing.Size(71, 20)
        Me.tbdisc.TabIndex = 53
        Me.tbdisc.Text = "0"
        Me.tbdisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(354, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Disc %"
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(262, 258)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(66, 20)
        Me.tbjumlah.TabIndex = 51
        Me.tbjumlah.Text = "0"
        Me.tbjumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(216, 260)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Jumlah"
        '
        'tbhargajual
        '
        Me.tbhargajual.Location = New System.Drawing.Point(81, 258)
        Me.tbhargajual.Name = "tbhargajual"
        Me.tbhargajual.Size = New System.Drawing.Size(100, 20)
        Me.tbhargajual.TabIndex = 49
        Me.tbhargajual.Text = "0"
        Me.tbhargajual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Harga Jual"
        '
        'tbnamabarang
        '
        Me.tbnamabarang.Location = New System.Drawing.Point(293, 222)
        Me.tbnamabarang.Name = "tbnamabarang"
        Me.tbnamabarang.Size = New System.Drawing.Size(195, 20)
        Me.tbnamabarang.TabIndex = 47
        Me.tbnamabarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(215, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Nama Barang"
        '
        'tbkodebarang
        '
        Me.tbkodebarang.Location = New System.Drawing.Point(92, 222)
        Me.tbkodebarang.Name = "tbkodebarang"
        Me.tbkodebarang.Size = New System.Drawing.Size(93, 20)
        Me.tbkodebarang.TabIndex = 45
        Me.tbkodebarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Kode Barang"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.tbno_nota)
        Me.PanelControl1.Controls.Add(Me.tbkode_supplier)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.dtppilihtanggal)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Location = New System.Drawing.Point(11, 71)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(936, 135)
        Me.PanelControl1.TabIndex = 42
        '
        'tbno_nota
        '
        Me.tbno_nota.Location = New System.Drawing.Point(126, 12)
        Me.tbno_nota.Name = "tbno_nota"
        Me.tbno_nota.Size = New System.Drawing.Size(138, 21)
        Me.tbno_nota.TabIndex = 24
        Me.tbno_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbkode_supplier
        '
        Me.tbkode_supplier.Location = New System.Drawing.Point(126, 87)
        Me.tbkode_supplier.Name = "tbkode_supplier"
        Me.tbkode_supplier.Size = New System.Drawing.Size(121, 21)
        Me.tbkode_supplier.TabIndex = 7
        Me.tbkode_supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Kode Supplier"
        '
        'dtppilihtanggal
        '
        Me.dtppilihtanggal.Location = New System.Drawing.Point(126, 47)
        Me.dtppilihtanggal.Name = "dtppilihtanggal"
        Me.dtppilihtanggal.Size = New System.Drawing.Size(154, 21)
        Me.dtppilihtanggal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No. Retur"
        '
        'tbtotalharga
        '
        Me.tbtotalharga.Location = New System.Drawing.Point(648, 6)
        Me.tbtotalharga.Name = "tbtotalharga"
        Me.tbtotalharga.Size = New System.Drawing.Size(300, 20)
        Me.tbtotalharga.TabIndex = 41
        Me.tbtotalharga.Text = "0"
        Me.tbtotalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Total"
        '
        'dgvdetailbarang
        '
        Me.dgvdetailbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetailbarang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvdetailbarang.Location = New System.Drawing.Point(12, 301)
        Me.dgvdetailbarang.Name = "dgvdetailbarang"
        Me.dgvdetailbarang.Size = New System.Drawing.Size(937, 234)
        Me.dgvdetailbarang.TabIndex = 58
        '
        'btnkoreksi
        '
        Me.btnkoreksi.Location = New System.Drawing.Point(656, 570)
        Me.btnkoreksi.Name = "btnkoreksi"
        Me.btnkoreksi.Size = New System.Drawing.Size(82, 47)
        Me.btnkoreksi.TabIndex = 62
        Me.btnkoreksi.Text = "Koreksi Nota"
        Me.btnkoreksi.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(867, 570)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(82, 47)
        Me.btnsimpan.TabIndex = 61
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(763, 570)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(81, 47)
        Me.btnprint.TabIndex = 60
        Me.btnprint.Text = "Print Nota"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(12, 570)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(81, 47)
        Me.btnhapus.TabIndex = 59
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'tb_ed
        '
        Me.tb_ed.Location = New System.Drawing.Point(720, 222)
        Me.tb_ed.Name = "tb_ed"
        Me.tb_ed.Size = New System.Drawing.Size(109, 20)
        Me.tb_ed.TabIndex = 66
        Me.tb_ed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(686, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "E.D."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(509, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Batch"
        '
        'tbbatch
        '
        Me.tbbatch.Location = New System.Drawing.Point(550, 222)
        Me.tbbatch.Name = "tbbatch"
        Me.tbbatch.Size = New System.Drawing.Size(109, 20)
        Me.tbbatch.TabIndex = 63
        Me.tbbatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Retur_Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 635)
        Me.Controls.Add(Me.tb_ed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbbatch)
        Me.Controls.Add(Me.btnkoreksi)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.dgvdetailbarang)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.tbhargadisc)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tbtotalrp)
        Me.Controls.Add(Me.tbdisc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbjumlah)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbhargajual)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbnamabarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbkodebarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tbtotalharga)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Retur_Pembelian"
        Me.Text = "Retur_Pembelian"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgvdetailbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents tbhargadisc As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbtotalrp As System.Windows.Forms.TextBox
    Friend WithEvents tbdisc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbhargajual As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbkodebarang As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tbno_nota As System.Windows.Forms.TextBox
    Friend WithEvents tbkode_supplier As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtppilihtanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbtotalharga As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvdetailbarang As System.Windows.Forms.DataGridView
    Friend WithEvents btnkoreksi As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents tb_ed As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbbatch As System.Windows.Forms.TextBox
End Class
