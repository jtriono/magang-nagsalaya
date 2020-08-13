<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formreportjualperbarang
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
        Me.apotikDataSet = New WindowsApplication1.apotikDataSet()
        Me.detail_penjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.detail_penjualanTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.detail_penjualanTableAdapter()
        Me.Tbitem = New System.Windows.Forms.TextBox()
        Me.btncari = New System.Windows.Forms.Button()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detail_penjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.detail_penjualanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report10.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 40)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(710, 320)
        Me.ReportViewer1.TabIndex = 0
        '
        'apotikDataSet
        '
        Me.apotikDataSet.DataSetName = "apotikDataSet"
        Me.apotikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'detail_penjualanBindingSource
        '
        Me.detail_penjualanBindingSource.DataMember = "detail_penjualan"
        Me.detail_penjualanBindingSource.DataSource = Me.apotikDataSet
        '
        'detail_penjualanTableAdapter
        '
        Me.detail_penjualanTableAdapter.ClearBeforeFill = True
        '
        'Tbitem
        '
        Me.Tbitem.Location = New System.Drawing.Point(12, 14)
        Me.Tbitem.Name = "Tbitem"
        Me.Tbitem.Size = New System.Drawing.Size(629, 20)
        Me.Tbitem.TabIndex = 1
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(647, 13)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 2
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'Formreportjualperbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 404)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.Tbitem)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Formreportjualperbarang"
        Me.Text = "Form2"
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detail_penjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detail_penjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents detail_penjualanTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.detail_penjualanTableAdapter
    Friend WithEvents Tbitem As System.Windows.Forms.TextBox
    Friend WithEvents btncari As System.Windows.Forms.Button
End Class
