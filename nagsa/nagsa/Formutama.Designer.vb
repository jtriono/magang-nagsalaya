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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnbarang = New System.Windows.Forms.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnk = New System.Windows.Forms.Button()
        Me.btnmaster = New System.Windows.Forms.Button()
        Me.btnhutangpiutang = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnutility = New System.Windows.Forms.Button()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnpenjualan
        '
        Me.btnpenjualan.Location = New System.Drawing.Point(540, 0)
        Me.btnpenjualan.Name = "btnpenjualan"
        Me.btnpenjualan.Size = New System.Drawing.Size(170, 145)
        Me.btnpenjualan.TabIndex = 0
        Me.btnpenjualan.Text = "Penjualan"
        Me.btnpenjualan.UseVisualStyleBackColor = True
        '
        'btnpembelian
        '
        Me.btnpembelian.Location = New System.Drawing.Point(206, 151)
        Me.btnpembelian.Name = "btnpembelian"
        Me.btnpembelian.Size = New System.Drawing.Size(157, 139)
        Me.btnpembelian.TabIndex = 1
        Me.btnpembelian.Text = "Pembelian"
        Me.btnpembelian.UseVisualStyleBackColor = True
        '
        'btntambahbarang
        '
        Me.btntambahbarang.Location = New System.Drawing.Point(369, 0)
        Me.btntambahbarang.Name = "btntambahbarang"
        Me.btntambahbarang.Size = New System.Drawing.Size(165, 145)
        Me.btntambahbarang.TabIndex = 2
        Me.btntambahbarang.Text = "Tambah Barang"
        Me.btntambahbarang.UseVisualStyleBackColor = True
        '
        'btnsupplier
        '
        Me.btnsupplier.Location = New System.Drawing.Point(369, 151)
        Me.btnsupplier.Name = "btnsupplier"
        Me.btnsupplier.Size = New System.Drawing.Size(165, 139)
        Me.btnsupplier.TabIndex = 3
        Me.btnsupplier.Text = "Supplier"
        Me.btnsupplier.UseVisualStyleBackColor = True
        '
        'btncustomer
        '
        Me.btncustomer.Location = New System.Drawing.Point(540, 151)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(170, 139)
        Me.btncustomer.TabIndex = 4
        Me.btncustomer.Text = "Customer"
        Me.btncustomer.UseVisualStyleBackColor = True
        '
        'dtpwaktu
        '
        Me.dtpwaktu.Location = New System.Drawing.Point(594, 366)
        Me.dtpwaktu.Name = "dtpwaktu"
        Me.dtpwaktu.Size = New System.Drawing.Size(116, 20)
        Me.dtpwaktu.TabIndex = 5
        Me.dtpwaktu.Value = New Date(2020, 6, 9, 10, 44, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NAS Computer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "081-33333-7365 HP. 081-7033-13512"
        '
        'btnbarang
        '
        Me.btnbarang.Location = New System.Drawing.Point(207, 0)
        Me.btnbarang.Name = "btnbarang"
        Me.btnbarang.Size = New System.Drawing.Size(156, 145)
        Me.btnbarang.TabIndex = 9
        Me.btnbarang.Text = "Barang"
        Me.btnbarang.UseVisualStyleBackColor = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnutility)
        Me.PanelControl1.Controls.Add(Me.btnlaporan)
        Me.PanelControl1.Controls.Add(Me.btnhutangpiutang)
        Me.PanelControl1.Controls.Add(Me.btnmaster)
        Me.PanelControl1.Controls.Add(Me.btnk)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 290)
        Me.PanelControl1.TabIndex = 10
        '
        'btnk
        '
        Me.btnk.Location = New System.Drawing.Point(5, 26)
        Me.btnk.Name = "btnk"
        Me.btnk.Size = New System.Drawing.Size(190, 23)
        Me.btnk.TabIndex = 0
        Me.btnk.Text = "K"
        Me.btnk.UseVisualStyleBackColor = True
        '
        'btnmaster
        '
        Me.btnmaster.Location = New System.Drawing.Point(5, 81)
        Me.btnmaster.Name = "btnmaster"
        Me.btnmaster.Size = New System.Drawing.Size(190, 23)
        Me.btnmaster.TabIndex = 1
        Me.btnmaster.Text = "Master"
        Me.btnmaster.UseVisualStyleBackColor = True
        '
        'btnhutangpiutang
        '
        Me.btnhutangpiutang.Location = New System.Drawing.Point(5, 132)
        Me.btnhutangpiutang.Name = "btnhutangpiutang"
        Me.btnhutangpiutang.Size = New System.Drawing.Size(190, 23)
        Me.btnhutangpiutang.TabIndex = 2
        Me.btnhutangpiutang.Text = "Hutang Piutang"
        Me.btnhutangpiutang.UseVisualStyleBackColor = True
        '
        'btnlaporan
        '
        Me.btnlaporan.Location = New System.Drawing.Point(5, 186)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(190, 23)
        Me.btnlaporan.TabIndex = 3
        Me.btnlaporan.Text = "Laporan"
        Me.btnlaporan.UseVisualStyleBackColor = True
        '
        'btnutility
        '
        Me.btnutility.Location = New System.Drawing.Point(5, 241)
        Me.btnutility.Name = "btnutility"
        Me.btnutility.Size = New System.Drawing.Size(190, 23)
        Me.btnutility.TabIndex = 4
        Me.btnutility.Text = "Utility"
        Me.btnutility.UseVisualStyleBackColor = True
        '
        'Formutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 398)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btnbarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpwaktu)
        Me.Controls.Add(Me.btncustomer)
        Me.Controls.Add(Me.btnsupplier)
        Me.Controls.Add(Me.btntambahbarang)
        Me.Controls.Add(Me.btnpembelian)
        Me.Controls.Add(Me.btnpenjualan)
        Me.Name = "Formutama"
        Me.Text = "Home"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnpenjualan As System.Windows.Forms.Button
    Friend WithEvents btnpembelian As System.Windows.Forms.Button
    Friend WithEvents btntambahbarang As System.Windows.Forms.Button
    Friend WithEvents btnsupplier As System.Windows.Forms.Button
    Friend WithEvents btncustomer As System.Windows.Forms.Button
    Friend WithEvents dtpwaktu As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnbarang As System.Windows.Forms.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnutility As System.Windows.Forms.Button
    Friend WithEvents btnlaporan As System.Windows.Forms.Button
    Friend WithEvents btnhutangpiutang As System.Windows.Forms.Button
    Friend WithEvents btnmaster As System.Windows.Forms.Button
    Friend WithEvents btnk As System.Windows.Forms.Button
End Class
