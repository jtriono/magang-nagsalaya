<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formreportbeliperbarang
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.Buttoncari = New System.Windows.Forms.Button()
        Me.apotikDataSet = New WindowsApplication1.apotikDataSet()
        Me.detail_pembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.detail_pembelianTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.detail_pembelianTableAdapter()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detail_pembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.detail_pembelianBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report13.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(767, 328)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(13, 13)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(658, 20)
        Me.tbcari.TabIndex = 1
        '
        'Buttoncari
        '
        Me.Buttoncari.Location = New System.Drawing.Point(677, 12)
        Me.Buttoncari.Name = "Buttoncari"
        Me.Buttoncari.Size = New System.Drawing.Size(102, 23)
        Me.Buttoncari.TabIndex = 2
        Me.Buttoncari.Text = "Cari"
        Me.Buttoncari.UseVisualStyleBackColor = True
        '
        'apotikDataSet
        '
        Me.apotikDataSet.DataSetName = "apotikDataSet"
        Me.apotikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'detail_pembelianBindingSource
        '
        Me.detail_pembelianBindingSource.DataMember = "detail_pembelian"
        Me.detail_pembelianBindingSource.DataSource = Me.apotikDataSet
        '
        'detail_pembelianTableAdapter
        '
        Me.detail_pembelianTableAdapter.ClearBeforeFill = True
        '
        'Formreportbeliperbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 392)
        Me.Controls.Add(Me.Buttoncari)
        Me.Controls.Add(Me.tbcari)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Formreportbeliperbarang"
        Me.Text = "Formreportbeliperbarang"
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detail_pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbcari As System.Windows.Forms.TextBox
    Friend WithEvents Buttoncari As System.Windows.Forms.Button
    Friend WithEvents detail_pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents detail_pembelianTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.detail_pembelianTableAdapter
End Class
