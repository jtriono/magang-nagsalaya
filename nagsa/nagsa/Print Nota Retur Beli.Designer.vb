<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Nota_Retur_Beli
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.apotikDataSetview = New WindowsApplication1.apotikDataSetview()
        Me.nota_retur_beliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nota_retur_beliTableAdapter = New WindowsApplication1.apotikDataSetviewTableAdapters.nota_retur_beliTableAdapter()
        CType(Me.apotikDataSetview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nota_retur_beliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.nota_retur_beliBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report18.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(756, 375)
        Me.ReportViewer1.TabIndex = 0
        '
        'apotikDataSetview
        '
        Me.apotikDataSetview.DataSetName = "apotikDataSetview"
        Me.apotikDataSetview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nota_retur_beliBindingSource
        '
        Me.nota_retur_beliBindingSource.DataMember = "nota_retur_beli"
        Me.nota_retur_beliBindingSource.DataSource = Me.apotikDataSetview
        '
        'nota_retur_beliTableAdapter
        '
        Me.nota_retur_beliTableAdapter.ClearBeforeFill = True
        '
        'Print_Nota_Retur_Beli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 400)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_Nota_Retur_Beli"
        Me.Text = "Print_Nota_Retur_Beli"
        CType(Me.apotikDataSetview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nota_retur_beliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents nota_retur_beliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSetview As WindowsApplication1.apotikDataSetview
    Friend WithEvents nota_retur_beliTableAdapter As WindowsApplication1.apotikDataSetviewTableAdapters.nota_retur_beliTableAdapter
End Class
