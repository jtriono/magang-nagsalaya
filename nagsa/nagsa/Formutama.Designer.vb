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
        Me.SuspendLayout()
        '
        'btnpenjualan
        '
        Me.btnpenjualan.Location = New System.Drawing.Point(69, 75)
        Me.btnpenjualan.Name = "btnpenjualan"
        Me.btnpenjualan.Size = New System.Drawing.Size(75, 68)
        Me.btnpenjualan.TabIndex = 0
        Me.btnpenjualan.Text = "Penjualan"
        Me.btnpenjualan.UseVisualStyleBackColor = True
        '
        'btnpembelian
        '
        Me.btnpembelian.Location = New System.Drawing.Point(203, 75)
        Me.btnpembelian.Name = "btnpembelian"
        Me.btnpembelian.Size = New System.Drawing.Size(75, 68)
        Me.btnpembelian.TabIndex = 1
        Me.btnpembelian.Text = "Pembelian"
        Me.btnpembelian.UseVisualStyleBackColor = True
        '
        'btntambahbarang
        '
        Me.btntambahbarang.Location = New System.Drawing.Point(333, 75)
        Me.btntambahbarang.Name = "btntambahbarang"
        Me.btntambahbarang.Size = New System.Drawing.Size(75, 68)
        Me.btntambahbarang.TabIndex = 2
        Me.btntambahbarang.Text = "Tambah Barang"
        Me.btntambahbarang.UseVisualStyleBackColor = True
        '
        'btnsupplier
        '
        Me.btnsupplier.Location = New System.Drawing.Point(465, 75)
        Me.btnsupplier.Name = "btnsupplier"
        Me.btnsupplier.Size = New System.Drawing.Size(75, 68)
        Me.btnsupplier.TabIndex = 3
        Me.btnsupplier.Text = "Supplier"
        Me.btnsupplier.UseVisualStyleBackColor = True
        '
        'btncustomer
        '
        Me.btncustomer.Location = New System.Drawing.Point(594, 75)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(75, 68)
        Me.btncustomer.TabIndex = 4
        Me.btncustomer.Text = "Customer"
        Me.btncustomer.UseVisualStyleBackColor = True
        '
        'dtpwaktu
        '
        Me.dtpwaktu.Location = New System.Drawing.Point(594, 305)
        Me.dtpwaktu.Name = "dtpwaktu"
        Me.dtpwaktu.Size = New System.Drawing.Size(116, 20)
        Me.dtpwaktu.TabIndex = 5
        Me.dtpwaktu.Value = New Date(2020, 6, 9, 10, 44, 0, 0)
        '
        'Formutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 337)
        Me.Controls.Add(Me.dtpwaktu)
        Me.Controls.Add(Me.btncustomer)
        Me.Controls.Add(Me.btnsupplier)
        Me.Controls.Add(Me.btntambahbarang)
        Me.Controls.Add(Me.btnpembelian)
        Me.Controls.Add(Me.btnpenjualan)
        Me.Name = "Formutama"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnpenjualan As System.Windows.Forms.Button
    Friend WithEvents btnpembelian As System.Windows.Forms.Button
    Friend WithEvents btntambahbarang As System.Windows.Forms.Button
    Friend WithEvents btnsupplier As System.Windows.Forms.Button
    Friend WithEvents btncustomer As System.Windows.Forms.Button
    Friend WithEvents dtpwaktu As System.Windows.Forms.DateTimePicker
End Class
