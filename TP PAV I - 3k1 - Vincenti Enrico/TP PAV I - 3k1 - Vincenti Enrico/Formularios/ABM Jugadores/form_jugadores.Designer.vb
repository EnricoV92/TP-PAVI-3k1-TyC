<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_jugadores
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
        Me.btn_nuevoJugador = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.cbo_equipos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_jugadores = New System.Windows.Forms.DataGridView()
        Me.col_dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        CType(Me.dgv_jugadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_nuevoJugador
        '
        Me.btn_nuevoJugador.Location = New System.Drawing.Point(40, 218)
        Me.btn_nuevoJugador.Name = "btn_nuevoJugador"
        Me.btn_nuevoJugador.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevoJugador.TabIndex = 0
        Me.btn_nuevoJugador.Text = "Nuevo"
        Me.btn_nuevoJugador.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(408, 218)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 1
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(408, 67)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar.TabIndex = 2
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(131, 12)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(159, 20)
        Me.txt_dni.TabIndex = 3
        '
        'cbo_equipos
        '
        Me.cbo_equipos.FormattingEnabled = True
        Me.cbo_equipos.Location = New System.Drawing.Point(131, 38)
        Me.cbo_equipos.Name = "cbo_equipos"
        Me.cbo_equipos.Size = New System.Drawing.Size(159, 21)
        Me.cbo_equipos.TabIndex = 4
        Me.cbo_equipos.Text = "Seleccione Equipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DNI Jugador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Equipo"
        '
        'dgv_jugadores
        '
        Me.dgv_jugadores.AllowUserToAddRows = False
        Me.dgv_jugadores.AllowUserToDeleteRows = False
        Me.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_jugadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_dni, Me.col_nombre, Me.col_apellido, Me.col_equipo, Me.col_sexo, Me.col_tel})
        Me.dgv_jugadores.Location = New System.Drawing.Point(40, 96)
        Me.dgv_jugadores.Name = "dgv_jugadores"
        Me.dgv_jugadores.ReadOnly = True
        Me.dgv_jugadores.Size = New System.Drawing.Size(443, 102)
        Me.dgv_jugadores.TabIndex = 7
        '
        'col_dni
        '
        Me.col_dni.HeaderText = "DNI"
        Me.col_dni.Name = "col_dni"
        Me.col_dni.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        Me.col_apellido.ReadOnly = True
        '
        'col_equipo
        '
        Me.col_equipo.HeaderText = "Equipo"
        Me.col_equipo.Name = "col_equipo"
        Me.col_equipo.ReadOnly = True
        '
        'col_sexo
        '
        Me.col_sexo.HeaderText = "Sexo"
        Me.col_sexo.Name = "col_sexo"
        Me.col_sexo.ReadOnly = True
        Me.col_sexo.Visible = False
        '
        'col_tel
        '
        Me.col_tel.HeaderText = "Teléfono"
        Me.col_tel.Name = "col_tel"
        Me.col_tel.ReadOnly = True
        Me.col_tel.Visible = False
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(131, 218)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 23)
        Me.btn_editar.TabIndex = 8
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(226, 218)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar.TabIndex = 9
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'form_jugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 259)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.dgv_jugadores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_equipos)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_nuevoJugador)
        Me.Name = "form_jugadores"
        Me.Text = "form_jugadores"
        CType(Me.dgv_jugadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_nuevoJugador As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_consultar As Button
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents cbo_equipos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_jugadores As DataGridView
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_quitar As Button
    Friend WithEvents col_dni As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As DataGridViewTextBoxColumn
    Friend WithEvents col_equipo As DataGridViewTextBoxColumn
    Friend WithEvents col_sexo As DataGridViewTextBoxColumn
    Friend WithEvents col_tel As DataGridViewTextBoxColumn
End Class
