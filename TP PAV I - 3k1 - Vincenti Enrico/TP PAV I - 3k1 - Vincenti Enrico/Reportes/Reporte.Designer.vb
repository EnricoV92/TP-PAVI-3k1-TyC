<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Me.TorneosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteTorneo1 = New TP_PAV_I___3k1___Vincenti_Enrico.reporteTorneo1()
        Me.rpv_fechas = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TorneosTableAdapter = New TP_PAV_I___3k1___Vincenti_Enrico.reporteTorneo1TableAdapters.TorneosTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SeleccioneUnTorneoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbo_torneos = New System.Windows.Forms.ComboBox()
        Me.TorneosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Torneos = New TP_PAV_I___3k1___Vincenti_Enrico.Torneos()
        Me.btn_verTorneos = New System.Windows.Forms.Button()
        Me.TorneosTableAdapter1 = New TP_PAV_I___3k1___Vincenti_Enrico.TorneosTableAdapters.TorneosTableAdapter()
        CType(Me.TorneosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteTorneo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TorneosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Torneos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TorneosBindingSource
        '
        Me.TorneosBindingSource.DataMember = "Torneos"
        Me.TorneosBindingSource.DataSource = Me.reporteTorneo1
        '
        'reporteTorneo1
        '
        Me.reporteTorneo1.DataSetName = "reporteTorneo1"
        Me.reporteTorneo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpv_fechas
        '
        Me.rpv_fechas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TorneosBindingSource
        Me.rpv_fechas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpv_fechas.LocalReport.ReportEmbeddedResource = "TP_PAV_I___3k1___Vincenti_Enrico.FechasxTorneo.rdlc"
        Me.rpv_fechas.Location = New System.Drawing.Point(0, 24)
        Me.rpv_fechas.Name = "rpv_fechas"
        Me.rpv_fechas.Size = New System.Drawing.Size(569, 356)
        Me.rpv_fechas.TabIndex = 0
        '
        'TorneosTableAdapter
        '
        Me.TorneosTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccioneUnTorneoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(569, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SeleccioneUnTorneoToolStripMenuItem
        '
        Me.SeleccioneUnTorneoToolStripMenuItem.Name = "SeleccioneUnTorneoToolStripMenuItem"
        Me.SeleccioneUnTorneoToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.SeleccioneUnTorneoToolStripMenuItem.Text = "Seleccione un Torneo"
        '
        'cbo_torneos
        '
        Me.cbo_torneos.DataSource = Me.TorneosBindingSource1
        Me.cbo_torneos.DisplayMember = "nombre_torneo"
        Me.cbo_torneos.FormattingEnabled = True
        Me.cbo_torneos.Location = New System.Drawing.Point(143, 2)
        Me.cbo_torneos.Name = "cbo_torneos"
        Me.cbo_torneos.Size = New System.Drawing.Size(121, 21)
        Me.cbo_torneos.TabIndex = 2
        Me.cbo_torneos.ValueMember = "id_torneo"
        '
        'TorneosBindingSource1
        '
        Me.TorneosBindingSource1.DataMember = "Torneos"
        Me.TorneosBindingSource1.DataSource = Me.Torneos
        '
        'Torneos
        '
        Me.Torneos.DataSetName = "Torneos"
        Me.Torneos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_verTorneos
        '
        Me.btn_verTorneos.Location = New System.Drawing.Point(305, 0)
        Me.btn_verTorneos.Name = "btn_verTorneos"
        Me.btn_verTorneos.Size = New System.Drawing.Size(75, 23)
        Me.btn_verTorneos.TabIndex = 3
        Me.btn_verTorneos.Text = "Ver Torneos"
        Me.btn_verTorneos.UseVisualStyleBackColor = True
        '
        'TorneosTableAdapter1
        '
        Me.TorneosTableAdapter1.ClearBeforeFill = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 380)
        Me.Controls.Add(Me.btn_verTorneos)
        Me.Controls.Add(Me.cbo_torneos)
        Me.Controls.Add(Me.rpv_fechas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.TorneosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteTorneo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TorneosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Torneos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rpv_fechas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TorneosBindingSource As BindingSource
    Friend WithEvents reporteTorneo1 As reporteTorneo1
    Friend WithEvents TorneosTableAdapter As reporteTorneo1TableAdapters.TorneosTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cbo_torneos As ComboBox
    Friend WithEvents btn_verTorneos As Button
    Friend WithEvents SeleccioneUnTorneoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Torneos As Torneos
    Friend WithEvents TorneosBindingSource1 As BindingSource
    Friend WithEvents TorneosTableAdapter1 As TorneosTableAdapters.TorneosTableAdapter
End Class
