<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formtambahbarang
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
        Me.btbatal = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.tbstok = New System.Windows.Forms.TextBox()
        Me.tbsatuan = New System.Windows.Forms.TextBox()
        Me.tbexpire = New System.Windows.Forms.TextBox()
        Me.tbbatch = New System.Windows.Forms.TextBox()
        Me.tbhjual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbhbeli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(167, 236)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 23)
        Me.btbatal.TabIndex = 31
        Me.btbatal.Text = "Batal"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(86, 236)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 23)
        Me.bttambah.TabIndex = 30
        Me.bttambah.Text = "Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'tbstok
        '
        Me.tbstok.Location = New System.Drawing.Point(86, 189)
        Me.tbstok.Name = "tbstok"
        Me.tbstok.Size = New System.Drawing.Size(388, 20)
        Me.tbstok.TabIndex = 29
        '
        'tbsatuan
        '
        Me.tbsatuan.Location = New System.Drawing.Point(86, 162)
        Me.tbsatuan.Name = "tbsatuan"
        Me.tbsatuan.Size = New System.Drawing.Size(388, 20)
        Me.tbsatuan.TabIndex = 28
        '
        'tbexpire
        '
        Me.tbexpire.Location = New System.Drawing.Point(86, 131)
        Me.tbexpire.Name = "tbexpire"
        Me.tbexpire.Size = New System.Drawing.Size(388, 20)
        Me.tbexpire.TabIndex = 27
        '
        'tbbatch
        '
        Me.tbbatch.Location = New System.Drawing.Point(86, 98)
        Me.tbbatch.Name = "tbbatch"
        Me.tbbatch.Size = New System.Drawing.Size(388, 20)
        Me.tbbatch.TabIndex = 26
        '
        'tbhjual
        '
        Me.tbhjual.Location = New System.Drawing.Point(86, 67)
        Me.tbhjual.Name = "tbhjual"
        Me.tbhjual.Size = New System.Drawing.Size(388, 20)
        Me.tbhjual.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Stok Awal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Satuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Expire Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "No Batch"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Harga Jual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Harga Beli"
        '
        'tbhbeli
        '
        Me.tbhbeli.Location = New System.Drawing.Point(86, 38)
        Me.tbhbeli.Name = "tbhbeli"
        Me.tbhbeli.Size = New System.Drawing.Size(388, 20)
        Me.tbhbeli.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nama Barang"
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(86, 12)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(388, 20)
        Me.tbnama.TabIndex = 16
        '
        'Formtambahbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 274)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.tbstok)
        Me.Controls.Add(Me.tbsatuan)
        Me.Controls.Add(Me.tbexpire)
        Me.Controls.Add(Me.tbbatch)
        Me.Controls.Add(Me.tbhjual)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbhbeli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbnama)
        Me.Name = "Formtambahbarang"
        Me.Text = "Tambah_Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents tbstok As System.Windows.Forms.TextBox
    Friend WithEvents tbsatuan As System.Windows.Forms.TextBox
    Friend WithEvents tbexpire As System.Windows.Forms.TextBox
    Friend WithEvents tbbatch As System.Windows.Forms.TextBox
    Friend WithEvents tbhjual As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbhbeli As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
End Class
