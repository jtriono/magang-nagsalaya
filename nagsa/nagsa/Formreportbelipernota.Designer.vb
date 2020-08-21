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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbnota = New System.Windows.Forms.TextBox()
        Me.btncari = New System.Windows.Forms.Button()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Nota"
        '
        'tbnota
        '
        Me.tbnota.Location = New System.Drawing.Point(70, 10)
        Me.tbnota.Name = "tbnota"
        Me.tbnota.Size = New System.Drawing.Size(125, 20)
        Me.tbnota.TabIndex = 1
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(210, 8)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 2
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
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
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 37)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(734, 354)
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
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.tbnota)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formreportbelipernota"
        Me.Text = "Formreportbelipernota"
        CType(Me.detail_pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbnota As System.Windows.Forms.TextBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents detail_pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents detail_pembelianTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.detail_pembelianTableAdapter
    Friend WithEvents pembelianTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.pembelianTableAdapter
End Class
