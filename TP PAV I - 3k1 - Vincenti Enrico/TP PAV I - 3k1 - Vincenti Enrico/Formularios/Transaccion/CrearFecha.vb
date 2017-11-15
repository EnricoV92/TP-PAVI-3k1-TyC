Public Class CrearFecha

    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value

    End Sub

    Private Sub CrearFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Torneos._Torneos' Puede moverla o quitarla según sea necesario.
        Me.TorneosTableAdapter.getTorneos(Me.Torneos._Torneos)
        cbo_torneos.SelectedValue = -1

    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        dgv_partidos.Rows.Add(New String() {cbo_equipo1.Text, cbo_equipo2.Text, txt_cancha.Text.ToString, cbo_equipo1.SelectedValue.ToString,
                              cbo_equipo2.SelectedValue.ToString})
    End Sub

    Private Sub clear_components()
        cbo_torneos.SelectedValue = -1
        cbo_equipo1.SelectedValue = -1
        cbo_equipo2.SelectedValue = -1
        txt_nroFecha.Text = ""
        txt_diaFecha.Clear()

        dgv_partidos.Rows.Clear()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim partidos = New List(Of Partidos)
        Dim flag As Boolean = False

        For Each row In dgv_partidos.Rows

            Dim p As Partidos = New Partidos(row.Cells("col_equipo1_id").Value, row.Cells("col_equipo2_id").Value, row.Cells("col_cancha").Value)
            partidos.Add(p)
        Next

        If IsDate(txt_diaFecha.Text) Then
            Dim diaFecha As DateTime = Date.Parse(Me.txt_diaFecha.Text)
            Dim xdiaFecha As String = diaFecha.ToString("yyyy-MM-dd")
            BDHelper.guardarFechaTorneoYPartidos(txt_nroFecha.Text, cbo_torneos.SelectedValue, xdiaFecha, partidos)
            MessageBox.Show("Transaccion completada. Se insertaron los partidos de la correspondiente Fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            clear_components()
        Else
            MessageBox.Show("no paso el formato de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub txt_nroFecha_TextChanged(sender As Object, e As EventArgs) Handles txt_nroFecha.TextChanged

    End Sub

    Private Sub cbo_torneos_DisplayMemberChanged(sender As Object, e As EventArgs) Handles cbo_torneos.DisplayMemberChanged

    End Sub

    Private Sub cbo_torneos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_torneos.SelectionChangeCommitted
        Dim filters As New List(Of Object)
        filters.Add(cbo_torneos.SelectedValue)

        llenarCombo(cbo_equipo1, BDHelper.getDBHelper.ConsultarSQLConParametros("SELECT * from EquiposxTorneos ET JOIN Equipos E ON ET.id_equipo = E.id_equipo WHERE id_torneo =@param1 ", filters.ToArray), "nombre_equipo", "id_equipo")
        llenarCombo(cbo_equipo2, BDHelper.getDBHelper.ConsultarSQLConParametros("SELECT * from EquiposxTorneos ET JOIN Equipos E ON ET.id_equipo = E.id_equipo WHERE id_torneo =@param1 ", filters.ToArray), "nombre_equipo", "id_equipo")


    End Sub
End Class