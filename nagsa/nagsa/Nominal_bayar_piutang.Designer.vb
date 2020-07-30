<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nominal_bayar_piutang
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
        Me.tbinputbayar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbinputbayar
        '
        Me.tbinputbayar.Location = New System.Drawing.Point(128, 57)
        Me.tbinputbayar.Name = "tbinputbayar"
        Me.tbinputbayar.Size = New System.Drawing.Size(207, 20)
        Me.tbinputbayar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Masukan Nominal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total"
        '
        'tbharga
        '
        Me.tbharga.Location = New System.Drawing.Point(128, 19)
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(207, 20)
        Me.tbharga.TabIndex = 3
        '
        'btnbayar
        '
        Me.btnbayar.Location = New System.Drawing.Point(260, 100)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(75, 23)
        Me.btnbayar.TabIndex = 4
        Me.btnbayar.Text = "Bayar"
        Me.btnbayar.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(15, 100)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 5
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'Nominal_bayar_piutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 143)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnbayar)
        Me.Controls.Add(Me.tbharga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbinputbayar)
        Me.Name = "Nominal_bayar_piutang"
        Me.Text = "Pelunasan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbinputbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbharga As System.Windows.Forms.TextBox
    Friend WithEvents btnbayar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
End Class
