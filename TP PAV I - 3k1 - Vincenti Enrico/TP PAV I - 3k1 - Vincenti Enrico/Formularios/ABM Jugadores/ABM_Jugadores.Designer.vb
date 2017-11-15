<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Jugadores
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
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.lbl_dni = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_teléfono = New System.Windows.Forms.TextBox()
        Me.lbl_teléfono = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radio_masculino = New System.Windows.Forms.RadioButton()
        Me.radio_femenino = New System.Windows.Forms.RadioButton()
        Me.cbo_equipos = New System.Windows.Forms.ComboBox()
        Me.lbl_equipos = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(92, 79)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(165, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(92, 49)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(165, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(92, 20)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(165, 20)
        Me.txt_dni.TabIndex = 2
        '
        'lbl_dni
        '
        Me.lbl_dni.AutoSize = True
        Me.lbl_dni.Location = New System.Drawing.Point(34, 23)
        Me.lbl_dni.Name = "lbl_dni"
        Me.lbl_dni.Size = New System.Drawing.Size(26, 13)
        Me.lbl_dni.TabIndex = 3
        Me.lbl_dni.Text = "DNI"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(34, 82)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 4
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(34, 52)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 5
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_teléfono
        '
        Me.txt_teléfono.Location = New System.Drawing.Point(92, 251)
        Me.txt_teléfono.Name = "txt_teléfono"
        Me.txt_teléfono.Size = New System.Drawing.Size(165, 20)
        Me.txt_teléfono.TabIndex = 6
        '
        'lbl_teléfono
        '
        Me.lbl_teléfono.AutoSize = True
        Me.lbl_teléfono.Location = New System.Drawing.Point(34, 251)
        Me.lbl_teléfono.Name = "lbl_teléfono"
        Me.lbl_teléfono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_teléfono.TabIndex = 7
        Me.lbl_teléfono.Text = "Teléfono"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radio_masculino)
        Me.GroupBox1.Controls.Add(Me.radio_femenino)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 84)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'radio_masculino
        '
        Me.radio_masculino.AutoSize = True
        Me.radio_masculino.Location = New System.Drawing.Point(55, 51)
        Me.radio_masculino.Name = "radio_masculino"
        Me.radio_masculino.Size = New System.Drawing.Size(73, 17)
        Me.radio_masculino.TabIndex = 1
        Me.radio_masculino.TabStop = True
        Me.radio_masculino.Text = "Masculino"
        Me.radio_masculino.UseVisualStyleBackColor = True
        '
        'radio_femenino
        '
        Me.radio_femenino.AutoSize = True
        Me.radio_femenino.Location = New System.Drawing.Point(55, 19)
        Me.radio_femenino.Name = "radio_femenino"
        Me.radio_femenino.Size = New System.Drawing.Size(71, 17)
        Me.radio_femenino.TabIndex = 0
        Me.radio_femenino.TabStop = True
        Me.radio_femenino.Text = "Femenino"
        Me.radio_femenino.UseVisualStyleBackColor = True
        '
        'cbo_equipos
        '
        Me.cbo_equipos.FormattingEnabled = True
        Me.cbo_equipos.Location = New System.Drawing.Point(92, 219)
        Me.cbo_equipos.Name = "cbo_equipos"
        Me.cbo_equipos.Size = New System.Drawing.Size(165, 21)
        Me.cbo_equipos.TabIndex = 9
        Me.cbo_equipos.Text = "Seleccione Equipo"
        '
        'lbl_equipos
        '
        Me.lbl_equipos.AutoSize = True
        Me.lbl_equipos.Location = New System.Drawing.Point(34, 222)
        Me.lbl_equipos.Name = "lbl_equipos"
        Me.lbl_equipos.Size = New System.Drawing.Size(45, 13)
        Me.lbl_equipos.TabIndex = 10
        Me.lbl_equipos.Text = "Equipos"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(182, 326)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(92, 326)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 12
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'ABM_Jugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 374)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_equipos)
        Me.Controls.Add(Me.cbo_equipos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_teléfono)
        Me.Controls.Add(Me.txt_teléfono)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_dni)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Name = "ABM_Jugadores"
        Me.Text = "ABM_Jugadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents lbl_dni As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_teléfono As TextBox
    Friend WithEvents lbl_teléfono As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radio_masculino As RadioButton
    Friend WithEvents radio_femenino As RadioButton
    Friend WithEvents cbo_equipos As ComboBox
    Friend WithEvents lbl_equipos As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
End Class
