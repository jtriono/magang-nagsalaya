<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formtambahcust
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
        Me.Tbkota = New System.Windows.Forms.TextBox()
        Me.Tbnotelp = New System.Windows.Forms.TextBox()
        Me.Tbnpwp = New System.Windows.Forms.TextBox()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.Btbatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Telp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NPWP"
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(101, 10)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(380, 20)
        Me.tbnama.TabIndex = 5
        '
        'tbalamat
        '
        Me.tbalamat.Location = New System.Drawing.Point(101, 41)
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(380, 20)
        Me.tbalamat.TabIndex = 6
        '
        'Tbkota
        '
        Me.Tbkota.Location = New System.Drawing.Point(101, 70)
        Me.Tbkota.Name = "Tbkota"
        Me.Tbkota.Size = New System.Drawing.Size(380, 20)
        Me.Tbkota.TabIndex = 7
        '
        'Tbnotelp
        '
        Me.Tbnotelp.Location = New System.Drawing.Point(101, 100)
        Me.Tbnotelp.Name = "Tbnotelp"
        Me.Tbnotelp.Size = New System.Drawing.Size(380, 20)
        Me.Tbnotelp.TabIndex = 8
        '
        'Tbnpwp
        '
        Me.Tbnpwp.Location = New System.Drawing.Point(101, 128)
        Me.Tbnpwp.Name = "Tbnpwp"
        Me.Tbnpwp.Size = New System.Drawing.Size(380, 20)
        Me.Tbnpwp.TabIndex = 9
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(101, 172)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 23)
        Me.bttambah.TabIndex = 10
        Me.bttambah.Text = "Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'Btbatal
        '
        Me.Btbatal.Location = New System.Drawing.Point(182, 172)
        Me.Btbatal.Name = "Btbatal"
        Me.Btbatal.Size = New System.Drawing.Size(75, 23)
        Me.Btbatal.TabIndex = 11
        Me.Btbatal.Text = "Batal"
        Me.Btbatal.UseVisualStyleBackColor = True
        '
        'Formtambahcust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 267)
        Me.Controls.Add(Me.Btbatal)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.Tbnpwp)
        Me.Controls.Add(Me.Tbnotelp)
        Me.Controls.Add(Me.Tbkota)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formtambahcust"
        Me.Text = "Tambah Customer"
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
    Friend WithEvents Tbkota As System.Windows.Forms.TextBox
    Friend WithEvents Tbnotelp As System.Windows.Forms.TextBox
    Friend WithEvents Tbnpwp As System.Windows.Forms.TextBox
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents Btbatal As System.Windows.Forms.Button
End Class
