<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formcustomer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Buttoncari = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.Buttonhapus = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(572, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'Buttoncari
        '
        Me.Buttoncari.Location = New System.Drawing.Point(504, 20)
        Me.Buttoncari.Name = "Buttoncari"
        Me.Buttoncari.Size = New System.Drawing.Size(97, 20)
        Me.Buttoncari.TabIndex = 1
        Me.Buttoncari.Text = "Cari"
        Me.Buttoncari.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(469, 20)
        Me.TextBox1.TabIndex = 2
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(29, 276)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 23)
        Me.bttambah.TabIndex = 3
        Me.bttambah.Text = "Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'Buttonhapus
        '
        Me.Buttonhapus.Location = New System.Drawing.Point(110, 276)
        Me.Buttonhapus.Name = "Buttonhapus"
        Me.Buttonhapus.Size = New System.Drawing.Size(75, 23)
        Me.Buttonhapus.TabIndex = 4
        Me.Buttonhapus.Text = "Hapus"
        Me.Buttonhapus.UseVisualStyleBackColor = True
        '
        'Formcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 334)
        Me.Controls.Add(Me.Buttonhapus)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Buttoncari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Formcustomer"
        Me.Text = "Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Buttoncari As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents Buttonhapus As System.Windows.Forms.Button
End Class
