<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_Stok
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
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncari_nota = New System.Windows.Forms.Button()
        Me.rbbeli = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbjual = New System.Windows.Forms.RadioButton()
        Me.tbno_nota = New System.Windows.Forms.TextBox()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.dtp_ed = New System.Windows.Forms.DateTimePicker()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.tbbatch = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.tbkode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnhapus = New System.Windows.Forms.Button()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(402, 27)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 30
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncari_nota
        '
        Me.btncari_nota.Location = New System.Drawing.Point(321, 27)
        Me.btncari_nota.Name = "btncari_nota"
        Me.btncari_nota.Size = New System.Drawing.Size(75, 23)
        Me.btncari_nota.TabIndex = 29
        Me.btncari_nota.Text = "Cari Nota"
        Me.btncari_nota.UseVisualStyleBackColor = True
        '
        'rbbeli
        '
        Me.rbbeli.AutoSize = True
        Me.rbbeli.Location = New System.Drawing.Point(769, 33)
        Me.rbbeli.Name = "rbbeli"
        Me.rbbeli.Size = New System.Drawing.Size(74, 17)
        Me.rbbeli.TabIndex = 25
        Me.rbbeli.TabStop = True
        Me.rbbeli.Text = "Pembelian"
        Me.rbbeli.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "No. Nota"
        '
        'rbjual
        '
        Me.rbjual.AutoSize = True
        Me.rbjual.Location = New System.Drawing.Point(670, 33)
        Me.rbjual.Name = "rbjual"
        Me.rbjual.Size = New System.Drawing.Size(72, 17)
        Me.rbjual.TabIndex = 24
        Me.rbjual.TabStop = True
        Me.rbjual.Text = "Penjualan"
        Me.rbjual.UseVisualStyleBackColor = True
        '
        'tbno_nota
        '
        Me.tbno_nota.Location = New System.Drawing.Point(115, 29)
        Me.tbno_nota.Name = "tbno_nota"
        Me.tbno_nota.Size = New System.Drawing.Size(200, 20)
        Me.tbno_nota.TabIndex = 28
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(12, 66)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(858, 175)
        Me.dgv2.TabIndex = 27
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_cari)
        Me.PanelControl1.Controls.Add(Me.dtp_ed)
        Me.PanelControl1.Controls.Add(Me.btntambah)
        Me.PanelControl1.Controls.Add(Me.tbjumlah)
        Me.PanelControl1.Controls.Add(Me.tbbatch)
        Me.PanelControl1.Controls.Add(Me.tbnama)
        Me.PanelControl1.Controls.Add(Me.tbkode)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 260)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(858, 171)
        Me.PanelControl1.TabIndex = 23
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(309, 6)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 11
        Me.btn_cari.Text = "Cari Barang"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'dtp_ed
        '
        Me.dtp_ed.Location = New System.Drawing.Point(103, 104)
        Me.dtp_ed.Name = "dtp_ed"
        Me.dtp_ed.Size = New System.Drawing.Size(200, 21)
        Me.dtp_ed.TabIndex = 10
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(778, 115)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 51)
        Me.btntambah.TabIndex = 12
        Me.btntambah.Text = "Simpan"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(103, 142)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(200, 21)
        Me.tbjumlah.TabIndex = 9
        '
        'tbbatch
        '
        Me.tbbatch.Location = New System.Drawing.Point(103, 75)
        Me.tbbatch.Name = "tbbatch"
        Me.tbbatch.Size = New System.Drawing.Size(200, 21)
        Me.tbbatch.TabIndex = 7
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(103, 41)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(200, 21)
        Me.tbnama.TabIndex = 6
        '
        'tbkode
        '
        Me.tbkode.Location = New System.Drawing.Point(103, 8)
        Me.tbkode.Name = "tbkode"
        Me.tbkode.Size = New System.Drawing.Size(200, 21)
        Me.tbkode.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Expired Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Batch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.Location = New System.Drawing.Point(670, 5)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtp_tanggal.TabIndex = 22
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(714, 669)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 51)
        Me.btn_search.TabIndex = 18
        Me.btn_search.Text = "Cari"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(795, 669)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 51)
        Me.btnprint.TabIndex = 19
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 451)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(858, 205)
        Me.dgv1.TabIndex = 17
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(12, 668)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 52)
        Me.btnhapus.TabIndex = 31
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Detail_Stok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 733)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncari_nota)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.rbbeli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbjual)
        Me.Controls.Add(Me.tbno_nota)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Name = "Detail_Stok"
        Me.Text = "Detail_Stok"
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncari_nota As System.Windows.Forms.Button
    Friend WithEvents rbbeli As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbjual As System.Windows.Forms.RadioButton
    Friend WithEvents tbno_nota As System.Windows.Forms.TextBox
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_cari As System.Windows.Forms.Button
    Friend WithEvents dtp_ed As System.Windows.Forms.DateTimePicker
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents tbjumlah As System.Windows.Forms.TextBox
    Friend WithEvents tbbatch As System.Windows.Forms.TextBox
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents tbkode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnhapus As System.Windows.Forms.Button
End Class
