Public Class ABM_Torneos
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow
    Private Sub ABM_Torneos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_fechaDesde.Text = Date.Now.ToString("dd/MM/yyyy")
        txt_fechaHasta.Text = Date.Now.AddDays(30).ToString("dd/MM/yyyy")

        llenarCombo(cbo_premios, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Premios"), "nombre_premio", "id_premio")

        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Torneo"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar Torneo"
                'Recuperar usuario seleccionado en la grilla 
                mostrar_datos()
                txt_nombre.Enabled = True
                txt_fechaDesde.Enabled = True
                txt_fechaHasta.Enabled = True
                cbo_premios.Enabled = True


            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Habilitar/Deshabilitar Torneo"
                txt_nombre.Enabled = False
                txt_fechaDesde.Enabled = False
                txt_fechaHasta.Enabled = False
                cbo_premios.Enabled = False
        End Select
    End Sub
    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_nombre.Text = _row_selected.Cells("col_nombre").Value
            txt_fechaDesde.Text = _row_selected.Cells("col_fechaDesde").Value
            txt_fechaHasta.Text = _row_selected.Cells("col_fechaHasta").Value
            txt_cantidad.Text = _row_selected.Cells("col_cantEquipos").Value
            cbo_premios.Text = _row_selected.Cells("col_premio").Value



        End If
    End Sub
    Public Sub seleccionar_torneo(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub
    Private Function validar_campos() As Boolean
        'campos obligatorios


        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        If txt_fechaDesde.Text = String.Empty Then
            txt_fechaDesde.BackColor = Color.Red
            txt_fechaDesde.Focus()
            Return False
        Else
            txt_fechaDesde.BackColor = Color.White
        End If

        If cbo_premios.Text = String.Empty Then
            cbo_premios.BackColor = Color.Red
            cbo_premios.Focus()
            Return False
        Else
            cbo_premios.BackColor = Color.White
        End If

        If txt_cantidad.Text = String.Empty Then
            txt_cantidad.BackColor = Color.Red
            txt_cantidad.Focus()
            Return False
        Else
            txt_cantidad.BackColor = Color.White
        End If

        If txt_descripcion.Text = String.Empty Then
            txt_descripcion.BackColor = Color.Red
            txt_descripcion.Focus()
            Return False
        Else
            txt_descripcion.BackColor = Color.White
        End If

        Return True
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""
        Dim estado As String


        Select Case _action
            Case Opcion.insert
                If existe_torneo() = False Then
                    If validar_campos() Then

                        Dim xfechad As String = ""
                        Dim xfechah As String = ""

                        If IsDate(txt_fechaDesde.Text) Then
                            Dim fechaDesde As DateTime = Date.Parse(Me.txt_fechaDesde.Text)
                            xfechad = fechaDesde.ToString("yyyy-MM-dd")
                        End If

                        If IsDate(txt_fechaHasta.Text) Then
                            Dim fechaHasta As DateTime = Date.Parse(Me.txt_fechaHasta.Text)
                            xfechah = fechaHasta.ToString("yyyy-MM-dd")
                        End If

                        str_sql = "INSERT INTO Torneos (nombre_torneo, descripcion, 
                                    fechaDesde, fechaHasta, cantidad, id_premio) VALUES('"
                        str_sql += txt_nombre.Text + "','"
                        str_sql += txt_descripcion.Text + "','"
                        str_sql += xfechad + "','"
                        str_sql += xfechah + "','"
                        str_sql += txt_cantidad.Text + "',"
                        str_sql += cbo_premios.SelectedValue.ToString + ")"
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Torneo Creado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("DNI de jugador encontrado!. Ingrese un dni diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then

                    str_sql = "UPDATE Torneos SET nombre_torneo = '"
                    str_sql += txt_nombre.Text + "', descripcion = '"
                    str_sql += txt_descripcion.Text + "', fechaDesde = '"

                    str_sql += txt_fechaDesde.Text + "', fechaHasta = '"
                    str_sql += txt_fechaHasta.Text + "', cantidad = '"
                    str_sql += txt_cantidad.Text + "', id_premio = "
                    str_sql += cbo_premios.SelectedValue.ToString
                    str_sql += " WHERE id_torneo = " + _row_selected.Cells("col_id_torneo").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Torneo actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Torneo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Jugadores where documento_jugador = " + _row_selected.Cells("col_dni").Value).Rows(0).Item("estado").ToString
                If estado = "N" Then
                    estado = "S"
                Else
                    estado = "N"
                End If
                str_sql = "UPDATE users SET estado = '" + estado + "' WHERE id_usuario = " + _row_selected.Cells("col_id").Value
                If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                    MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

        End Select
    End Sub
    Private Function existe_torneo() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from Torneos where nombre_torneo = '" + txt_nombre.Text + "'").Rows.Count > 0
    End Function
    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub txt_fechaDesde_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_fechaDesde.MaskInputRejected

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class