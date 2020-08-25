<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formreportbarang
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
        Me.barangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.apotikbarangDataSet = New WindowsApplication1.apotikbarangDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.barangTableAdapter = New WindowsApplication1.apotikbarangDataSetTableAdapters.barangTableAdapter()
        CType(Me.barangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apotikbarangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barangBindingSource
        '
        Me.barangBindingSource.DataMember = "barang"
        Me.barangBindingSource.DataSource = Me.apotikbarangDataSet
        '
        'apotikbarangDataSet
        '
        Me.apotikbarangDataSet.DataSetName = "apotikbarangDataSet"
        Me.apotikbarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        ReportDataSource1.Name = "DataSetbarang"
        ReportDataSource1.Value = Me.barangBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(719, 273)
        Me.ReportViewer1.TabIndex = 0
        '
        'barangTableAdapter
        '
        Me.barangTableAdapter.ClearBeforeFill = True
        '
        'Formreportbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 297)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Formreportbarang"
        Me.Text = "Formreport"
        CType(Me.barangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apotikbarangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents barangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikbarangDataSet As WindowsApplication1.apotikbarangDataSet
    Friend WithEvents barangTableAdapter As WindowsApplication1.apotikbarangDataSetTableAdapters.barangTableAdapter
End Class
