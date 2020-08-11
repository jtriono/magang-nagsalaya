<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Menu_Penjualan
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
        Me.penjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.apotikDataSet = New WindowsApplication1.apotikDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.penjualanTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.penjualanTableAdapter()
        CType(Me.penjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'penjualanBindingSource
        '
        Me.penjualanBindingSource.DataMember = "penjualan"
        Me.penjualanBindingSource.DataSource = Me.apotikDataSet
        '
        'apotikDataSet
        '
        Me.apotikDataSet.DataSetName = "apotikDataSet"
        Me.apotikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.penjualanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(751, 380)
        Me.ReportViewer1.TabIndex = 0
        '
        'penjualanTableAdapter
        '
        Me.penjualanTableAdapter.ClearBeforeFill = True
        '
        'Print_Menu_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 404)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_Menu_Penjualan"
        Me.Text = "Print_Menu_Penjualan"
        CType(Me.penjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents penjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents penjualanTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.penjualanTableAdapter
End Class
