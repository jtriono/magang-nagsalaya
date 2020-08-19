<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Detail_Stok
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
        Me.apotikDataSetdetstok = New WindowsApplication1.apotikDataSetdetstok()
        Me.detail_stokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.detail_stokTableAdapter = New WindowsApplication1.apotikDataSetdetstokTableAdapters.detail_stokTableAdapter()
        CType(Me.apotikDataSetdetstok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detail_stokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.detail_stokBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report19.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(718, 375)
        Me.ReportViewer1.TabIndex = 0
        '
        'apotikDataSetdetstok
        '
        Me.apotikDataSetdetstok.DataSetName = "apotikDataSetdetstok"
        Me.apotikDataSetdetstok.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'detail_stokBindingSource
        '
        Me.detail_stokBindingSource.DataMember = "detail_stok"
        Me.detail_stokBindingSource.DataSource = Me.apotikDataSetdetstok
        '
        'detail_stokTableAdapter
        '
        Me.detail_stokTableAdapter.ClearBeforeFill = True
        '
        'Print_Detail_Stok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 399)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_Detail_Stok"
        Me.Text = "Print_Detail_Stok"
        CType(Me.apotikDataSetdetstok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detail_stokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detail_stokBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSetdetstok As WindowsApplication1.apotikDataSetdetstok
    Friend WithEvents detail_stokTableAdapter As WindowsApplication1.apotikDataSetdetstokTableAdapters.detail_stokTableAdapter
End Class
