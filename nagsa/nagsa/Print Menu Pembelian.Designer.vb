<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Menu_Pembelian
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
        Me.nota_pembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nota_pembelianTableAdapter = New WindowsApplication1.apotikDataSetviewTableAdapters.nota_pembelianTableAdapter()
        CType(Me.apotikDataSetview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nota_pembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.nota_pembelianBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(751, 379)
        Me.ReportViewer1.TabIndex = 0
        '
        'apotikDataSetview
        '
        Me.apotikDataSetview.DataSetName = "apotikDataSetview"
        Me.apotikDataSetview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nota_pembelianBindingSource
        '
        Me.nota_pembelianBindingSource.DataMember = "nota_pembelian"
        Me.nota_pembelianBindingSource.DataSource = Me.apotikDataSetview
        '
        'nota_pembelianTableAdapter
        '
        Me.nota_pembelianTableAdapter.ClearBeforeFill = True
        '
        'Print_Menu_Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 403)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_Menu_Pembelian"
        Me.Text = "Print_Menu_Pembelian"
        CType(Me.apotikDataSetview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nota_pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents nota_pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSetview As WindowsApplication1.apotikDataSetview
    Friend WithEvents nota_pembelianTableAdapter As WindowsApplication1.apotikDataSetviewTableAdapters.nota_pembelianTableAdapter
End Class
