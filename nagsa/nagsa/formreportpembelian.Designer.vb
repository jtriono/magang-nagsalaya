﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formreportpembelian
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
        Me.pembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.apotikDataSet = New WindowsApplication1.apotikDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pembelianTableAdapter = New WindowsApplication1.apotikDataSetTableAdapters.pembelianTableAdapter()
        CType(Me.pembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pembelianBindingSource
        '
        Me.pembelianBindingSource.DataMember = "pembelian"
        Me.pembelianBindingSource.DataSource = Me.apotikDataSet
        '
        'apotikDataSet
        '
        Me.apotikDataSet.DataSetName = "apotikDataSet"
        Me.apotikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.pembelianBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report12.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 13)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(702, 370)
        Me.ReportViewer1.TabIndex = 0
        '
        'pembelianTableAdapter
        '
        Me.pembelianTableAdapter.ClearBeforeFill = True
        '
        'formreportpembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 395)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "formreportpembelian"
        Me.Text = "Laporan Pembelian"
        CType(Me.pembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apotikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents apotikDataSet As WindowsApplication1.apotikDataSet
    Friend WithEvents pembelianTableAdapter As WindowsApplication1.apotikDataSetTableAdapters.pembelianTableAdapter
End Class
