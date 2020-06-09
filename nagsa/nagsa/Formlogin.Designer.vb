<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formlogin
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
        Me.btlogin = New System.Windows.Forms.Button()
        Me.TextBoxuser = New System.Windows.Forms.TextBox()
        Me.TextBoxpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btlogin
        '
        Me.btlogin.Location = New System.Drawing.Point(42, 169)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(107, 45)
        Me.btlogin.TabIndex = 0
        Me.btlogin.Text = "Masuk"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'TextBoxuser
        '
        Me.TextBoxuser.Location = New System.Drawing.Point(42, 68)
        Me.TextBoxuser.Name = "TextBoxuser"
        Me.TextBoxuser.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxuser.TabIndex = 2
        '
        'TextBoxpass
        '
        Me.TextBoxpass.Location = New System.Drawing.Point(42, 132)
        Me.TextBoxpass.Name = "TextBoxpass"
        Me.TextBoxpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxpass.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxpass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(198, 169)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(107, 45)
        Me.btkeluar.TabIndex = 6
        Me.btkeluar.Text = "Keluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'Formlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 282)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxpass)
        Me.Controls.Add(Me.TextBoxuser)
        Me.Controls.Add(Me.btlogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btlogin As System.Windows.Forms.Button
    Friend WithEvents TextBoxuser As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btkeluar As System.Windows.Forms.Button

End Class
