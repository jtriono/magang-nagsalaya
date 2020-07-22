<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retur_Penjualan
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
        Me.tbkode_cust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtppilihtanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.dgvdetailbarang = New System.Windows.Forms.DataGridView()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkoreksi = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbnopenjualan = New System.Windows.Forms.TextBox()
        Me.dgvreturjual = New System.Windows.Forms.DataGridView()
        Me.btncari = New System.Windows.Forms.Button()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgvdetailbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreturjual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
        '
        'tbtotalharga
        '
        Me.tbtotalharga.Location = New System.Drawing.Point(649, 10)
        Me.tbtotalharga.Name = "tbtotalharga"
        Me.tbtotalharga.Size = New System.Drawing.Size(300, 20)
        Me.tbtotalharga.TabIndex = 2
        Me.tbtotalharga.Text = "0"
        Me.tbtotalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btncari)
        Me.PanelControl1.Controls.Add(Me.tbnopenjualan)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.tbno_nota)
        Me.PanelControl1.Controls.Add(Me.tbkode_cust)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.dtppilihtanggal)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 68)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(936, 135)
        Me.PanelControl1.TabIndex = 3
        '
        'tbno_nota
        '
        Me.tbno_nota.Location = New System.Drawing.Point(126, 12)
        Me.tbno_nota.Name = "tbno_nota"
        Me.tbno_nota.Size = New System.Drawing.Size(138, 21)
        Me.tbno_nota.TabIndex = 24
        Me.tbno_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'dtppilihtanggal
        '
        Me.dtppilihtanggal.Location = New System.Drawing.Point(777, 12)
        Me.dtppilihtanggal.Name = "dtppilihtanggal"
        Me.dtppilihtanggal.Size = New System.Drawing.Size(154, 21)
        Me.dtppilihtanggal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(726, 15)
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
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(851, 423)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(98, 45)
        Me.btn_tambah.TabIndex = 39
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'dgvdetailbarang
        '
        Me.dgvdetailbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetailbarang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvdetailbarang.Location = New System.Drawing.Point(11, 213)
        Me.dgvdetailbarang.Name = "dgvdetailbarang"
        Me.dgvdetailbarang.Size = New System.Drawing.Size(937, 204)
        Me.dgvdetailbarang.TabIndex = 40
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(11, 682)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(81, 47)
        Me.btnhapus.TabIndex = 41
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkoreksi
        '
        Me.btnkoreksi.Location = New System.Drawing.Point(674, 682)
        Me.btnkoreksi.Name = "btnkoreksi"
        Me.btnkoreksi.Size = New System.Drawing.Size(82, 47)
        Me.btnkoreksi.TabIndex = 44
        Me.btnkoreksi.Text = "Koreksi Nota"
        Me.btnkoreksi.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(867, 682)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(82, 47)
        Me.btnsimpan.TabIndex = 43
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(771, 682)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(81, 47)
        Me.btnprint.TabIndex = 42
        Me.btnprint.Text = "Print Nota"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "No Nota Penjualan"
        '
        'tbnopenjualan
        '
        Me.tbnopenjualan.Location = New System.Drawing.Point(126, 51)
        Me.tbnopenjualan.Name = "tbnopenjualan"
        Me.tbnopenjualan.Size = New System.Drawing.Size(121, 21)
        Me.tbnopenjualan.TabIndex = 26
        Me.tbnopenjualan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvreturjual
        '
        Me.dgvreturjual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreturjual.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvreturjual.Location = New System.Drawing.Point(11, 473)
        Me.dgvreturjual.Name = "dgvreturjual"
        Me.dgvreturjual.Size = New System.Drawing.Size(937, 204)
        Me.dgvreturjual.TabIndex = 45
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(253, 50)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 27
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'Retur_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 741)
        Me.Controls.Add(Me.dgvreturjual)
        Me.Controls.Add(Me.btnkoreksi)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.dgvdetailbarang)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.tbtotalharga)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Retur_Penjualan"
        Me.Text = "Retur_Penjualan"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgvdetailbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreturjual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbtotalharga As System.Windows.Forms.TextBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tbno_nota As System.Windows.Forms.TextBox
    Friend WithEvents tbkode_cust As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtppilihtanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents dgvdetailbarang As System.Windows.Forms.DataGridView
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnkoreksi As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents tbnopenjualan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvreturjual As System.Windows.Forms.DataGridView
    Friend WithEvents btncari As System.Windows.Forms.Button
End Class
