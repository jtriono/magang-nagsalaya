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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btncari = New System.Windows.Forms.Button()
        Me.tbnopembelian = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.dgvreturbeli = New System.Windows.Forms.DataGridView()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgvdetailbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreturbeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(851, 421)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(98, 41)
        Me.btn_tambah.TabIndex = 57
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btncari)
        Me.PanelControl1.Controls.Add(Me.tbnopembelian)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.tbno_nota)
        Me.PanelControl1.Controls.Add(Me.tbkode_supplier)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.dtppilihtanggal)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Location = New System.Drawing.Point(11, 68)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(936, 135)
        Me.PanelControl1.TabIndex = 42
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(331, 49)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 27
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'tbnopembelian
        '
        Me.tbnopembelian.Location = New System.Drawing.Point(204, 50)
        Me.tbnopembelian.Name = "tbnopembelian"
        Me.tbnopembelian.Size = New System.Drawing.Size(121, 21)
        Me.tbnopembelian.TabIndex = 26
        Me.tbnopembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(571, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Tanggal"
        '
        'tbno_nota
        '
        Me.tbno_nota.Location = New System.Drawing.Point(204, 12)
        Me.tbno_nota.Name = "tbno_nota"
        Me.tbno_nota.Size = New System.Drawing.Size(138, 21)
        Me.tbno_nota.TabIndex = 24
        Me.tbno_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbkode_supplier
        '
        Me.tbkode_supplier.Location = New System.Drawing.Point(204, 87)
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
        Me.dtppilihtanggal.Location = New System.Drawing.Point(712, 12)
        Me.dtppilihtanggal.Name = "dtppilihtanggal"
        Me.dtppilihtanggal.Size = New System.Drawing.Size(219, 21)
        Me.dtppilihtanggal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Nota Pembelian"
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
        Me.dgvdetailbarang.Location = New System.Drawing.Point(11, 210)
        Me.dgvdetailbarang.Name = "dgvdetailbarang"
        Me.dgvdetailbarang.Size = New System.Drawing.Size(937, 205)
        Me.dgvdetailbarang.TabIndex = 58
        '
        'btnkoreksi
        '
        Me.btnkoreksi.Location = New System.Drawing.Point(659, 674)
        Me.btnkoreksi.Name = "btnkoreksi"
        Me.btnkoreksi.Size = New System.Drawing.Size(82, 47)
        Me.btnkoreksi.TabIndex = 62
        Me.btnkoreksi.Text = "Koreksi Nota"
        Me.btnkoreksi.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(870, 674)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(82, 47)
        Me.btnsimpan.TabIndex = 61
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(766, 674)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(81, 47)
        Me.btnprint.TabIndex = 60
        Me.btnprint.Text = "Print Nota"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(8, 674)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(81, 47)
        Me.btnhapus.TabIndex = 59
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'dgvreturbeli
        '
        Me.dgvreturbeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreturbeli.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvreturbeli.Location = New System.Drawing.Point(12, 466)
        Me.dgvreturbeli.Name = "dgvreturbeli"
        Me.dgvreturbeli.Size = New System.Drawing.Size(937, 205)
        Me.dgvreturbeli.TabIndex = 63
        '
        'Retur_Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 733)
        Me.Controls.Add(Me.dgvreturbeli)
        Me.Controls.Add(Me.btnkoreksi)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.dgvdetailbarang)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tbtotalharga)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Retur_Pembelian"
        Me.Text = "Retur_Pembelian"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgvdetailbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreturbeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbnopembelian As System.Windows.Forms.TextBox
    Friend WithEvents dgvreturbeli As System.Windows.Forms.DataGridView
    Friend WithEvents btncari As System.Windows.Forms.Button
End Class
