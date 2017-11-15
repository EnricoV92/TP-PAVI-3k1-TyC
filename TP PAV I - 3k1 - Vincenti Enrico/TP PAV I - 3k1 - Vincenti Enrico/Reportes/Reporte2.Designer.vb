<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rpv_resultados = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cbo_torneos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reporteResultados = New TP_PAV_I___3k1___Vincenti_Enrico.ReporteResultados()
        Me.ResultadosEquiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultadosEquiposTableAdapter = New TP_PAV_I___3k1___Vincenti_Enrico.reporteResultadosTableAdapters.ResultadosEquiposTableAdapter()
        Me.Torneos = New TP_PAV_I___3k1___Vincenti_Enrico.Torneos()
        Me.TorneosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TorneosTableAdapter = New TP_PAV_I___3k1___Vincenti_Enrico.TorneosTableAdapters.TorneosTableAdapter()
        CType(Me.reporteResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultadosEquiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Torneos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorneosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpv_resultados
        '
        Me.rpv_resultados.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ResultadosEquiposBindingSource
        Me.rpv_resultados.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpv_resultados.LocalReport.ReportEmbeddedResource = "TP_PAV_I___3k1___Vincenti_Enrico.ReporteResultados.rdlc"
        Me.rpv_resultados.Location = New System.Drawing.Point(0, 24)
        Me.rpv_resultados.Name = "rpv_resultados"
        Me.rpv_resultados.Size = New System.Drawing.Size(926, 237)
        Me.rpv_resultados.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(926, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cbo_torneos
        '
        Me.cbo_torneos.DataSource = Me.TorneosBindingSource
        Me.cbo_torneos.DisplayMember = "nombre_torneo"
        Me.cbo_torneos.FormattingEnabled = True
        Me.cbo_torneos.Location = New System.Drawing.Point(120, 3)
        Me.cbo_torneos.Name = "cbo_torneos"
        Me.cbo_torneos.Size = New System.Drawing.Size(148, 21)
        Me.cbo_torneos.TabIndex = 2
        Me.cbo_torneos.ValueMember = "id_torneo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selecciones Torneo"
        '
        'reporteResultados
        '
        Me.reporteResultados.DataSetName = "reporteResultados"
        Me.reporteResultados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResultadosEquiposBindingSource
        '
        Me.ResultadosEquiposBindingSource.DataMember = "ResultadosEquipos"
        Me.ResultadosEquiposBindingSource.DataSource = Me.reporteResultados
        '
        'ResultadosEquiposTableAdapter
        '
        Me.ResultadosEquiposTableAdapter.ClearBeforeFill = True
        '
        'Torneos
        '
        Me.Torneos.DataSetName = "Torneos"
        Me.Torneos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TorneosBindingSource
        '
        Me.TorneosBindingSource.DataMember = "Torneos"
        Me.TorneosBindingSource.DataSource = Me.Torneos
        '
        'TorneosTableAdapter
        '
        Me.TorneosTableAdapter.ClearBeforeFill = True
        '
        'Reporte2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_torneos)
        Me.Controls.Add(Me.rpv_resultados)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Reporte2"
        Me.Text = "Reporte2"
        CType(Me.reporteResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultadosEquiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Torneos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorneosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rpv_resultados As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ResultadosEquiposBindingSource As BindingSource
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cbo_torneos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ResultadosEquiposTableAdapter As reporteResultadosTableAdapters.ResultadosEquiposTableAdapter
    Friend WithEvents Torneos As Torneos
    Friend WithEvents TorneosBindingSource As BindingSource
    Friend WithEvents TorneosTableAdapter As TorneosTableAdapters.TorneosTableAdapter
    Friend WithEvents reporteResultados As ReporteResultados
End Class
