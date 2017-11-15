<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Torneos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_premios = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(119, 31)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(127, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Torneo"
        '
        'txt_fechaDesde
        '
        Me.txt_fechaDesde.Location = New System.Drawing.Point(119, 67)
        Me.txt_fechaDesde.Mask = "00/00/0000"
        Me.txt_fechaDesde.Name = "txt_fechaDesde"
        Me.txt_fechaDesde.Size = New System.Drawing.Size(127, 20)
        Me.txt_fechaDesde.TabIndex = 2
        Me.txt_fechaDesde.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Inicio"
        '
        'txt_fechaHasta
        '
        Me.txt_fechaHasta.Location = New System.Drawing.Point(119, 103)
        Me.txt_fechaHasta.Mask = "00/00/0000"
        Me.txt_fechaHasta.Name = "txt_fechaHasta"
        Me.txt_fechaHasta.Size = New System.Drawing.Size(127, 20)
        Me.txt_fechaHasta.TabIndex = 4
        Me.txt_fechaHasta.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Fin"
        '
        'cbo_premios
        '
        Me.cbo_premios.FormattingEnabled = True
        Me.cbo_premios.Location = New System.Drawing.Point(119, 143)
        Me.cbo_premios.Name = "cbo_premios"
        Me.cbo_premios.Size = New System.Drawing.Size(127, 21)
        Me.cbo_premios.TabIndex = 6
        Me.cbo_premios.Text = "Selecciones Premio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Premio Ganador"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(228, 306)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 8
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(119, 179)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cantidad Equipos"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(119, 219)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(184, 52)
        Me.txt_descripcion.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "mm/dd/yyyy"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(252, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "mm/dd/yyyy"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(119, 306)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 15
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'ABM_Torneos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 370)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_premios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_fechaHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fechaDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Name = "ABM_Torneos"
        Me.Text = "ABM_Torneos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fechaDesde As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fechaHasta As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_premios As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_cancelar As Button
End Class
