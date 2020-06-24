<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formbarang
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
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvbarang
        '
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(12, 24)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.Size = New System.Drawing.Size(736, 287)
        Me.dgvbarang.TabIndex = 5
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(93, 317)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 4
        Me.bthapus.Text = "Hapus"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(12, 317)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 23)
        Me.bttambah.TabIndex = 3
        Me.bttambah.Text = "Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'Formbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 370)
        Me.Controls.Add(Me.dgvbarang)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.bttambah)
        Me.Name = "Formbarang"
        Me.Text = "Barang"
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvbarang As System.Windows.Forms.DataGridView
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
End Class
