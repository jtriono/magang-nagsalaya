<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Nota_Retur_Jual
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.apotikDataSet = New WindowsApplication1.apotikDataSet()
        Me.detail_retur_jualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.detail_retur_jualTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.detail_retur_jualTableAdapter()
        Me.retur_penjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.retur_penjualanTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.retur_penjualanTableAdapter()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detail_retur_jualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.retur_penjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.detail_retur_jualBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.retur_penjualanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report23.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(753, 378)
        Me.ReportViewer1.TabIndex = 0
        '
        'apotikDataSet
        '
        Me.apotikDataSet.DataSetName = "apotikDataSet"
        Me.apotikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'detail_retur_jualBindingSource
        '
        Me.detail_retur_jualBindingSource.DataMember = "detail_retur_jual"
        Me.detail_retur_jualBindingSource.DataSource = Me.apotikDataSet
        '
        'detail_retur_jualTableAdapter
        '
        Me.detail_retur_jualTableAdapter.ClearBeforeFill = True
        '
        'retur_penjualanBindingSource
        '
        Me.retur_penjualanBindingSource.DataMember = "retur_penjualan"
        Me.retur_penjualanBindingSource.DataSource = Me.apotikDataSet
        '
        'retur_penjualanTableAdapter
        '
        Me.retur_penjualanTableAdapter.ClearBeforeFill = True
        '
        'Print_Nota_Retur_Jual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 403)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_Nota_Retur_Jual"
        Me.Text = "Print_Nota_Retur_Jual"
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detail_retur_jualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.retur_penjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detail_retur_jualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents retur_penjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents detail_retur_jualTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.detail_retur_jualTableAdapter
    Friend WithEvents retur_penjualanTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.retur_penjualanTableAdapter
End Class
