Public Class ABM_Jugadores
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub ABM_Jugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_jugadores.llenarCombo(cbo_equipos, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Equipos"), "nombre_equipo", "id_equipo")
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Jugador"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar Jugador"
                'Recuperar usuario seleccionado en la grilla 
                mostrar_datos()
                txt_dni.Enabled = False
                radio_masculino.Enabled = False
                radio_femenino.Enabled = False
                txt_nombre.Enabled = True
                txt_apellido.Enabled = True
                txt_teléfono.Enabled = True
                cbo_equipos.Enabled = True


            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Habilitar/Deshabilitar Jugador"
                txt_dni.Enabled = False
                radio_masculino.Enabled = False
                radio_femenino.Enabled = False
                txt_nombre.Enabled = False
                txt_apellido.Enabled = False
                txt_teléfono.Enabled = False
                cbo_equipos.Enabled = False
        End Select
    End Sub
    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_nombre.Text = _row_selected.Cells("col_nombre").Value
            txt_apellido.Text = _row_selected.Cells("col_apellido").Value
            txt_dni.Text = _row_selected.Cells("col_dni").Value
            txt_teléfono.Text = _row_selected.Cells("col_tel").Value
            cbo_equipos.Text = _row_selected.Cells("col_equipo").Value
            If _row_selected.Cells("col_sexo").Value = "Masculino" Then
                radio_masculino.Checked = True
            Else radio_femenino.Checked = True
            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged

    End Sub

    Private Sub txt_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_dni.TextChanged

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub

    Public Sub seleccionar_usuario(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""

        Dim radio As String = "Masculino"

        Select Case _action
            Case Opcion.insert
                If existe_dni() = False Then
                    If validar_campos() Then
                        If radio_femenino.Checked = True Then
                            radio = "Femenino"
                        End If
                        str_sql = "INSERT INTO Jugadores (documento_jugador, nombre_jugador, apellido_jugador, 
                                    sexo_jugador, teléfono_jugador, id_equipo) VALUES('"
                        str_sql += txt_dni.Text + "','"
                        str_sql += txt_nombre.Text + "','"
                        str_sql += txt_apellido.Text + "','"
                        str_sql += radio + "','"
                        str_sql += txt_teléfono.Text + "',"
                        str_sql += cbo_equipos.SelectedValue.ToString + ")"
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("DNI de jugador encontrado!. Ingrese un dni diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Opcion.update
                If validar_campos() Then
                    If radio_femenino.Checked = True Then
                        radio = "Femenino"
                    End If
                    str_sql = "UPDATE Jugadores SET nombre_jugador = '"
                    str_sql += txt_nombre.Text + "', apellido_jugador = '"
                    str_sql += txt_apellido.Text + "', sexo_jugador = '"
                    str_sql += radio + "', teléfono_jugador = '"
                    str_sql += txt_teléfono.Text + "', id_equipo = "
                    str_sql += cbo_equipos.SelectedValue.ToString
                    str_sql += " WHERE documento_jugador = " + _row_selected.Cells("col_dni").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Jugador actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el jugador!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case Opcion.delete
                'estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Jugadores where documento_jugador = " + _row_selected.Cells("col_dni").Value).Rows(0).Item("estado").ToString
                ''If estado = "N" Then
                'estado = "S"
                'Else
                'estado = "N"
                'End If
                'str_sql = "UPDATE Jugadores SET estado = '" + estado + "' WHERE documento_jugador = " + _row_selected.Cells("col_dni").Value
                str_sql = "DELETE from Jugadores WHERE documento_jugador = " + _row_selected.Cells("col_dni").Value
                If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                    MessageBox.Show("Jugador eliminado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                    Else
                    MessageBox.Show("Error al quitar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

        End Select
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_dni.Text = String.Empty Then
            txt_dni.BackColor = Color.Red
            txt_dni.Focus()
            Return False
        Else
            txt_dni.BackColor = Color.White
        End If

        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If
        If txt_apellido.Text = String.Empty Then
            txt_apellido.BackColor = Color.Red
            txt_apellido.Focus()
            Return False
        Else
            txt_apellido.BackColor = Color.White
        End If


        If cbo_equipos.Text = String.Empty Then
            cbo_equipos.BackColor = Color.Red
            cbo_equipos.Focus()
            Return False
        Else
            cbo_equipos.BackColor = Color.White
        End If

        If txt_teléfono.Text = String.Empty Then
            txt_teléfono.BackColor = Color.Red
            txt_teléfono.Focus()
            Return False
        Else
            txt_teléfono.BackColor = Color.White
        End If

        Return True
    End Function

    Private Function existe_dni() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from Jugadores where documento_jugador = '" + txt_dni.Text + "'").Rows.Count > 0
    End Function

    Private Sub cbo_equipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_equipos.SelectedIndexChanged

    End Sub
End Class