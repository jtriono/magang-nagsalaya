<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formIsi_Supplier
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.tbalamat = New System.Windows.Forms.TextBox()
        Me.tbkota = New System.Windows.Forms.TextBox()
        Me.tbtelpon = New System.Windows.Forms.TextBox()
        Me.tbhutang = New System.Windows.Forms.TextBox()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telpon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Saldo Hutang"
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(86, 13)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(403, 20)
        Me.tbnama.TabIndex = 5
        '
        'tbalamat
        '
        Me.tbalamat.Location = New System.Drawing.Point(86, 39)
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(403, 20)
        Me.tbalamat.TabIndex = 6
        '
        'tbkota
        '
        Me.tbkota.Location = New System.Drawing.Point(86, 65)
        Me.tbkota.Name = "tbkota"
        Me.tbkota.Size = New System.Drawing.Size(403, 20)
        Me.tbkota.TabIndex = 7
        '
        'tbtelpon
        '
        Me.tbtelpon.Location = New System.Drawing.Point(86, 92)
        Me.tbtelpon.Name = "tbtelpon"
        Me.tbtelpon.Size = New System.Drawing.Size(403, 20)
        Me.tbtelpon.TabIndex = 8
        '
        'tbhutang
        '
        Me.tbhutang.Location = New System.Drawing.Point(86, 119)
        Me.tbhutang.Name = "tbhutang"
        Me.tbhutang.Size = New System.Drawing.Size(403, 20)
        Me.tbhutang.TabIndex = 9
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(86, 163)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 23)
        Me.bttambah.TabIndex = 10
        Me.bttambah.Text = "Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(167, 163)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 23)
        Me.btbatal.TabIndex = 11
        Me.btbatal.Text = "Batal"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'formIsi_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 213)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.tbhutang)
        Me.Controls.Add(Me.tbtelpon)
        Me.Controls.Add(Me.tbkota)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formIsi_Supplier"
        Me.Text = "Isi Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents tbalamat As System.Windows.Forms.TextBox
    Friend WithEvents tbkota As System.Windows.Forms.TextBox
    Friend WithEvents tbtelpon As System.Windows.Forms.TextBox
    Friend WithEvents tbhutang As System.Windows.Forms.TextBox
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
End Class
