<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Bayar_Hutang
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.buttonpilihsupplier = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.dtptanggal = New System.Windows.Forms.DateTimePicker()
        Me.tbnamasupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnmasukharga = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Supplier"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.buttonpilihsupplier)
        Me.PanelControl1.Controls.Add(Me.btncari)
        Me.PanelControl1.Controls.Add(Me.dtptanggal)
        Me.PanelControl1.Controls.Add(Me.tbnamasupplier)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(638, 92)
        Me.PanelControl1.TabIndex = 1
        '
        'buttonpilihsupplier
        '
        Me.buttonpilihsupplier.Location = New System.Drawing.Point(333, 11)
        Me.buttonpilihsupplier.Name = "buttonpilihsupplier"
        Me.buttonpilihsupplier.Size = New System.Drawing.Size(75, 23)
        Me.buttonpilihsupplier.TabIndex = 6
        Me.buttonpilihsupplier.Text = "Pilih Supplier"
        Me.buttonpilihsupplier.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(548, 14)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(85, 54)
        Me.btncari.TabIndex = 5
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'dtptanggal
        '
        Me.dtptanggal.Location = New System.Drawing.Point(132, 47)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(276, 21)
        Me.dtptanggal.TabIndex = 4
        '
        'tbnamasupplier
        '
        Me.tbnamasupplier.Enabled = False
        Me.tbnamasupplier.Location = New System.Drawing.Point(132, 11)
        Me.tbnamasupplier.Name = "tbnamasupplier"
        Me.tbnamasupplier.Size = New System.Drawing.Size(195, 21)
        Me.tbnamasupplier.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'btnmasukharga
        '
        Me.btnmasukharga.Location = New System.Drawing.Point(565, 366)
        Me.btnmasukharga.Name = "btnmasukharga"
        Me.btnmasukharga.Size = New System.Drawing.Size(85, 50)
        Me.btnmasukharga.TabIndex = 7
        Me.btnmasukharga.Text = "Bayar"
        Me.btnmasukharga.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(638, 219)
        Me.DataGridView1.TabIndex = 6
        '
        'Form_Bayar_Hutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 432)
        Me.Controls.Add(Me.btnmasukharga)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form_Bayar_Hutang"
        Me.Text = "Daftar Hutang"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbnamasupplier As System.Windows.Forms.TextBox
    Friend WithEvents dtptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnmasukharga As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents buttonpilihsupplier As System.Windows.Forms.Button
End Class
