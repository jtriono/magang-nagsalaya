<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_user
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
        Me.tbuser = New System.Windows.Forms.TextBox()
        Me.tbpwd = New System.Windows.Forms.TextBox()
        Me.cblevel = New System.Windows.Forms.ComboBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Level"
        '
        'tbuser
        '
        Me.tbuser.Location = New System.Drawing.Point(189, 36)
        Me.tbuser.Name = "tbuser"
        Me.tbuser.Size = New System.Drawing.Size(156, 20)
        Me.tbuser.TabIndex = 3
        '
        'tbpwd
        '
        Me.tbpwd.Location = New System.Drawing.Point(189, 83)
        Me.tbpwd.Name = "tbpwd"
        Me.tbpwd.Size = New System.Drawing.Size(156, 20)
        Me.tbpwd.TabIndex = 4
        '
        'cblevel
        '
        Me.cblevel.FormattingEnabled = True
        Me.cblevel.Items.AddRange(New Object() {"Supervisor", "Operator1", "Operator2"})
        Me.cblevel.Location = New System.Drawing.Point(189, 129)
        Me.cblevel.Name = "cblevel"
        Me.cblevel.Size = New System.Drawing.Size(156, 21)
        Me.cblevel.TabIndex = 5
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(282, 214)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 6
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(101, 215)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(75, 23)
        Me.btnprev.TabIndex = 7
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(192, 215)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 8
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(12, 215)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 9
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(189, 166)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 10
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'tambah_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 258)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.cblevel)
        Me.Controls.Add(Me.tbpwd)
        Me.Controls.Add(Me.tbuser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tambah_user"
        Me.Text = "tambah_user"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbuser As System.Windows.Forms.TextBox
    Friend WithEvents tbpwd As System.Windows.Forms.TextBox
    Friend WithEvents cblevel As System.Windows.Forms.ComboBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
End Class
