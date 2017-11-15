<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_torneos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_fechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_torneos = New System.Windows.Forms.DataGridView()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaDesde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaHasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_premio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantEquipos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_torneo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_torneos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_fechaHasta)
        Me.GroupBox1.Controls.Add(Me.txt_fechaDesde)
        Me.GroupBox1.Controls.Add(Me.dgv_torneos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Torneos"
        '
        'txt_fechaHasta
        '
        Me.txt_fechaHasta.Location = New System.Drawing.Point(304, 24)
        Me.txt_fechaHasta.Mask = "00/00/0000"
        Me.txt_fechaHasta.Name = "txt_fechaHasta"
        Me.txt_fechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.txt_fechaHasta.TabIndex = 7
        Me.txt_fechaHasta.ValidatingType = GetType(Date)
        '
        'txt_fechaDesde
        '
        Me.txt_fechaDesde.Location = New System.Drawing.Point(98, 24)
        Me.txt_fechaDesde.Mask = "00/00/0000"
        Me.txt_fechaDesde.Name = "txt_fechaDesde"
        Me.txt_fechaDesde.Size = New System.Drawing.Size(100, 20)
        Me.txt_fechaDesde.TabIndex = 6
        Me.txt_fechaDesde.ValidatingType = GetType(Date)
        '
        'dgv_torneos
        '
        Me.dgv_torneos.AllowUserToAddRows = False
        Me.dgv_torneos.AllowUserToDeleteRows = False
        Me.dgv_torneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_torneos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.col_fechaDesde, Me.col_fechaHasta, Me.col_premio, Me.col_cantEquipos, Me.col_id_torneo, Me.Descripcion})
        Me.dgv_torneos.Location = New System.Drawing.Point(6, 66)
        Me.dgv_torneos.Name = "dgv_torneos"
        Me.dgv_torneos.ReadOnly = True
        Me.dgv_torneos.Size = New System.Drawing.Size(444, 150)
        Me.dgv_torneos.TabIndex = 5
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Torneo"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_fechaDesde
        '
        Me.col_fechaDesde.HeaderText = "Fecha Inicio"
        Me.col_fechaDesde.Name = "col_fechaDesde"
        Me.col_fechaDesde.ReadOnly = True
        '
        'col_fechaHasta
        '
        Me.col_fechaHasta.HeaderText = "Fecha Fin"
        Me.col_fechaHasta.Name = "col_fechaHasta"
        Me.col_fechaHasta.ReadOnly = True
        '
        'col_premio
        '
        Me.col_premio.HeaderText = "Premio Ganador"
        Me.col_premio.Name = "col_premio"
        Me.col_premio.ReadOnly = True
        '
        'col_cantEquipos
        '
        Me.col_cantEquipos.HeaderText = "Equipos"
        Me.col_cantEquipos.Name = "col_cantEquipos"
        Me.col_cantEquipos.ReadOnly = True
        Me.col_cantEquipos.Visible = False
        '
        'col_id_torneo
        '
        Me.col_id_torneo.HeaderText = "Id Torneo"
        Me.col_id_torneo.Name = "col_id_torneo"
        Me.col_id_torneo.ReadOnly = True
        Me.col_id_torneo.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "col_desc"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Desde"
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(387, 297)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar.TabIndex = 1
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 297)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(92, 23)
        Me.btn_nuevo.TabIndex = 2
        Me.btn_nuevo.Text = "Nuevo Torneo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(110, 297)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(107, 23)
        Me.btn_editar.TabIndex = 3
        Me.btn_editar.Text = "Editar Torneo"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(223, 297)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(99, 23)
        Me.btn_borrar.TabIndex = 4
        Me.btn_borrar.Text = "Eliminar Torneo"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "mm/dd/yyyy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "mm/dd/yyyy"
        '
        'form_torneos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 337)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "form_torneos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_torneos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_torneos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_consultar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents txt_fechaHasta As MaskedTextBox
    Friend WithEvents txt_fechaDesde As MaskedTextBox
    Friend WithEvents btn_borrar As Button
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_fechaDesde As DataGridViewTextBoxColumn
    Friend WithEvents col_fechaHasta As DataGridViewTextBoxColumn
    Friend WithEvents col_premio As DataGridViewTextBoxColumn
    Friend WithEvents col_cantEquipos As DataGridViewTextBoxColumn
    Friend WithEvents col_id_torneo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
