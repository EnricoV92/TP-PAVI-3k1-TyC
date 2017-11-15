Public Class form_jugadores
    Private Sub form_jugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo(cbo_equipos, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Equipos"), "nombre_equipo", "id_equipo")
    End Sub

    Private Sub btn_nuevoJugador_Click(sender As Object, e As EventArgs) Handles btn_nuevoJugador.Click
        ABM_Jugadores.ShowDialog()
    End Sub


    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Dim sql As String = "SELECT documento_jugador, nombre_jugador, apellido_jugador, nombre_equipo, sexo_jugador, teléfono_jugador FROM Jugadores J JOIN Equipos E ON J.id_equipo = E.id_equipo"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        'Validar si el combo 'Equipos' esta seleccionado.
        If cbo_equipos.Text <> String.Empty Then
            'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
            filters.Add(cbo_equipos.SelectedValue)
            sql += " AND J.id_equipo=@param1 "
            flag_filtros = True
        Else
            filters.Add(Nothing)
        End If

        'Validar si el texto 'DNI' no esta vacío.
        If txt_dni.Text <> String.Empty Then
            'Si el txt_dni tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
            filters.Add(txt_dni.Text)
            sql += " AND J.documento_jugador=@param2 "
            flag_filtros = True
        Else
            filters.Add(Nothing)
        End If
        If flag_filtros Then
            llenar_grid(BDHelper.getDBHelper.ConsultarSQLConParametros(sql, filters.ToArray))
            If dgv_jugadores.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron jugdores",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_jugadores.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_jugadores.Rows.Add(New String() {row.Item("documento_jugador").ToString, row.Item("nombre_jugador").ToString, row.Item("apellido_jugador").ToString,
                                   row.Item("nombre_equipo").ToString, row.Item("sexo_jugador").ToString, row.Item("teléfono_jugador").ToString})
        Next
    End Sub

    Private Sub dgv_jugadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_jugadores.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        ABM_Jugadores.seleccionar_usuario(ABM_Jugadores.Opcion.update, dgv_jugadores.CurrentRow)
        ABM_Jugadores.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        ABM_Jugadores.seleccionar_usuario(ABM_Jugadores.Opcion.delete, dgv_jugadores.CurrentRow)
        ABM_Jugadores.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click

        Me.Close()
            End
    End Sub

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class