<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formreportbelipernota
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.detail_pembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.apotikDataSet = New WindowsApplication1.apotikDataSet()
        Me.pembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.detail_pembelianTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.detail_pembelianTableAdapter()
        Me.pembelianTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.pembelianTableAdapter()
        CType(Me.detail_pembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'detail_pembelianBindingSource
        '
        Me.detail_pembelianBindingSource.DataMember = "detail_pembelian"
        Me.detail_pembelianBindingSource.DataSource = Me.apotikDataSet
        '
        'apotikDataSet
        '
        Me.apotikDataSet.DataSetName = "apotikDataSet"
        Me.apotikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pembelianBindingSource
        '
        Me.pembelianBindingSource.DataMember = "pembelian"
        Me.pembelianBindingSource.DataSource = Me.apotikDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.detail_pembelianBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.pembelianBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report22.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(734, 379)
        Me.ReportViewer1.TabIndex = 3
        '
        'detail_pembelianTableAdapter
        '
        Me.detail_pembelianTableAdapter.ClearBeforeFill = True
        '
        'pembelianTableAdapter
        '
        Me.pembelianTableAdapter.ClearBeforeFill = True
        '
        'Formreportbelipernota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 403)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Formreportbelipernota"
        Me.Text = "Formreportbelipernota"
        CType(Me.detail_pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detail_pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents detail_pembelianTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.detail_pembelianTableAdapter
    Friend WithEvents pembelianTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.pembelianTableAdapter
End Class
