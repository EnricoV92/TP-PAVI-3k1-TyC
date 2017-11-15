<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearFecha
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nroFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_diaFecha = New System.Windows.Forms.MaskedTextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.txt_cancha = New System.Windows.Forms.TextBox()
        Me.Cancha = New System.Windows.Forms.Label()
        Me.cbo_equipo2 = New System.Windows.Forms.ComboBox()
        Me.cbo_equipo1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_partidos = New System.Windows.Forms.DataGridView()
        Me.col_equipo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_equipo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cancha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_equipo1_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_equipo2_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbo_torneos = New System.Windows.Forms.ComboBox()
        Me.TorneosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Torneos = New TP_PAV_I___3k1___Vincenti_Enrico.Torneos()
        Me.TorneosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TorneosTableAdapter = New TP_PAV_I___3k1___Vincenti_Enrico.TorneosTableAdapters.TorneosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_partidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorneosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Torneos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorneosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número Fecha"
        '
        'txt_nroFecha
        '
        Me.txt_nroFecha.Location = New System.Drawing.Point(136, 57)
        Me.txt_nroFecha.Name = "txt_nroFecha"
        Me.txt_nroFecha.Size = New System.Drawing.Size(116, 20)
        Me.txt_nroFecha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Día"
        '
        'txt_diaFecha
        '
        Me.txt_diaFecha.Location = New System.Drawing.Point(136, 83)
        Me.txt_diaFecha.Mask = "00/00/0000"
        Me.txt_diaFecha.Name = "txt_diaFecha"
        Me.txt_diaFecha.Size = New System.Drawing.Size(116, 20)
        Me.txt_diaFecha.TabIndex = 3
        Me.txt_diaFecha.ValidatingType = GetType(Date)
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(341, 468)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cargar)
        Me.GroupBox1.Controls.Add(Me.txt_cancha)
        Me.GroupBox1.Controls.Add(Me.Cancha)
        Me.GroupBox1.Controls.Add(Me.cbo_equipo2)
        Me.GroupBox1.Controls.Add(Me.cbo_equipo1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 178)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Partidos"
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(262, 149)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cargar.TabIndex = 6
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'txt_cancha
        '
        Me.txt_cancha.Location = New System.Drawing.Point(94, 113)
        Me.txt_cancha.Name = "txt_cancha"
        Me.txt_cancha.Size = New System.Drawing.Size(121, 20)
        Me.txt_cancha.TabIndex = 5
        '
        'Cancha
        '
        Me.Cancha.AutoSize = True
        Me.Cancha.Location = New System.Drawing.Point(45, 116)
        Me.Cancha.Name = "Cancha"
        Me.Cancha.Size = New System.Drawing.Size(44, 13)
        Me.Cancha.TabIndex = 4
        Me.Cancha.Text = "Cancha"
        '
        'cbo_equipo2
        '
        Me.cbo_equipo2.FormattingEnabled = True
        Me.cbo_equipo2.Location = New System.Drawing.Point(94, 77)
        Me.cbo_equipo2.Name = "cbo_equipo2"
        Me.cbo_equipo2.Size = New System.Drawing.Size(121, 21)
        Me.cbo_equipo2.TabIndex = 3
        '
        'cbo_equipo1
        '
        Me.cbo_equipo1.FormattingEnabled = True
        Me.cbo_equipo1.Location = New System.Drawing.Point(94, 39)
        Me.cbo_equipo1.Name = "cbo_equipo1"
        Me.cbo_equipo1.Size = New System.Drawing.Size(121, 21)
        Me.cbo_equipo1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Equipo 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Equipo 1"
        '
        'dgv_partidos
        '
        Me.dgv_partidos.AllowUserToAddRows = False
        Me.dgv_partidos.AllowUserToDeleteRows = False
        Me.dgv_partidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_partidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_equipo1, Me.col_equipo2, Me.col_cancha, Me.col_equipo1_id, Me.col_equipo2_id})
        Me.dgv_partidos.Location = New System.Drawing.Point(42, 309)
        Me.dgv_partidos.Name = "dgv_partidos"
        Me.dgv_partidos.ReadOnly = True
        Me.dgv_partidos.Size = New System.Drawing.Size(543, 137)
        Me.dgv_partidos.TabIndex = 9
        '
        'col_equipo1
        '
        Me.col_equipo1.HeaderText = "Equipo 1"
        Me.col_equipo1.Name = "col_equipo1"
        Me.col_equipo1.ReadOnly = True
        '
        'col_equipo2
        '
        Me.col_equipo2.HeaderText = "Equipo 2"
        Me.col_equipo2.Name = "col_equipo2"
        Me.col_equipo2.ReadOnly = True
        '
        'col_cancha
        '
        Me.col_cancha.HeaderText = "Cancha"
        Me.col_cancha.Name = "col_cancha"
        Me.col_cancha.ReadOnly = True
        '
        'col_equipo1_id
        '
        Me.col_equipo1_id.HeaderText = "id_equipo1"
        Me.col_equipo1_id.Name = "col_equipo1_id"
        Me.col_equipo1_id.ReadOnly = True
        '
        'col_equipo2_id
        '
        Me.col_equipo2_id.HeaderText = "id_equipo2"
        Me.col_equipo2_id.Name = "col_equipo2_id"
        Me.col_equipo2_id.ReadOnly = True
        '
        'cbo_torneos
        '
        Me.cbo_torneos.DataSource = Me.TorneosBindingSource1
        Me.cbo_torneos.DisplayMember = "nombre_torneo"
        Me.cbo_torneos.FormattingEnabled = True
        Me.cbo_torneos.Location = New System.Drawing.Point(136, 30)
        Me.cbo_torneos.Name = "cbo_torneos"
        Me.cbo_torneos.Size = New System.Drawing.Size(121, 21)
        Me.cbo_torneos.TabIndex = 10
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
        'TorneosBindingSource
        '
        Me.TorneosBindingSource.DataMember = "Torneos"
        Me.TorneosBindingSource.DataSource = Me.Torneos
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Torneos"
        '
        'TorneosTableAdapter
        '
        Me.TorneosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(510, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_fechaDesde
        '
        Me.txt_fechaDesde.Location = New System.Drawing.Point(304, 30)
        Me.txt_fechaDesde.Mask = "00/00/0000"
        Me.txt_fechaDesde.Name = "txt_fechaDesde"
        Me.txt_fechaDesde.Size = New System.Drawing.Size(105, 20)
        Me.txt_fechaDesde.TabIndex = 13
        Me.txt_fechaDesde.ValidatingType = GetType(Date)
        '
        'txt_fechaHasta
        '
        Me.txt_fechaHasta.Location = New System.Drawing.Point(424, 31)
        Me.txt_fechaHasta.Mask = "00/00/0000"
        Me.txt_fechaHasta.Name = "txt_fechaHasta"
        Me.txt_fechaHasta.Size = New System.Drawing.Size(105, 20)
        Me.txt_fechaHasta.TabIndex = 14
        Me.txt_fechaHasta.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Desde"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(430, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Hasta"
        '
        'CrearFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 558)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_fechaHasta)
        Me.Controls.Add(Me.txt_fechaDesde)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo_torneos)
        Me.Controls.Add(Me.dgv_partidos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_diaFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nroFecha)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearFecha"
        Me.Text = "CrearFecha"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_partidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorneosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Torneos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorneosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nroFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_diaFecha As MaskedTextBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cargar As Button
    Friend WithEvents txt_cancha As TextBox
    Friend WithEvents Cancha As Label
    Friend WithEvents cbo_equipo2 As ComboBox
    Friend WithEvents cbo_equipo1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_partidos As DataGridView
    Friend WithEvents col_equipo1 As DataGridViewTextBoxColumn
    Friend WithEvents col_equipo2 As DataGridViewTextBoxColumn
    Friend WithEvents col_cancha As DataGridViewTextBoxColumn
    Friend WithEvents col_equipo1_id As DataGridViewTextBoxColumn
    Friend WithEvents col_equipo2_id As DataGridViewTextBoxColumn
    Friend WithEvents cbo_torneos As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Torneos As Torneos
    Friend WithEvents TorneosBindingSource As BindingSource
    Friend WithEvents TorneosTableAdapter As TorneosTableAdapters.TorneosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents TorneosBindingSource1 As BindingSource
    Friend WithEvents txt_fechaDesde As MaskedTextBox
    Friend WithEvents txt_fechaHasta As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
