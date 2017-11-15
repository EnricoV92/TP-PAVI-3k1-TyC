Public Class form_torneos

    Private Sub form_torneos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializar componentes:
        clear_components()

    End Sub

    Private Sub clear_components()
        txt_fechaDesde.Text = Date.Now.ToString("dd/MM/yyyy")
        txt_fechaHasta.Text = Date.Now.AddDays(30).ToString("dd/MM/yyyy")

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        ABM_Torneos.ShowDialog()
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT * FROM Torneos T JOIN Premios P ON T.id_premio=P.id_premio WHERE "
        Dim flag_filtros As Boolean = False

        'Validar campos de fechas. Si son fechas válidas las agregamos. Caso contrario Nothing
        If IsDate(txt_fechaDesde.Text) Then
            Dim fechaDesde As DateTime = Date.Parse(Me.txt_fechaDesde.Text)
            Dim xfechad As String = fechaDesde.ToString("yyyy-MM-dd")
            filters.Add(xfechad)

            str += "(fechaDesde>=@param1) "
            flag_filtros = True

        Else
            filters.Add(Nothing)
        End If

        If IsDate(txt_fechaHasta.Text) Then
            Dim fechaHasta As DateTime = Date.Parse(Me.txt_fechaHasta.Text)
            Dim xfechah As String = fechaHasta.ToString("yyyy-MM-dd")
            filters.Add(xfechah)
            str += "AND (fechaHasta<=@param2)"
        Else
            filters.Add(Nothing)
        End If


        str += " ORDER BY fechaHasta DESC"
        If flag_filtros Then
            llenar_grid(BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray))
        Else
            MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If dgv_torneos.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron torneos para las fechas ingresadas",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            clear_components()
        End If
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_torneos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_torneos.Rows.Add(New String() {row.Item("nombre_torneo").ToString, row.Item("fechaDesde").ToString, row.Item("fechaHasta").ToString,
                                   row.Item("nombre_premio").ToString, row.Item("cantidad").ToString, row.Item("id_torneo").ToString,
                                   row.Item("descripcion").ToString})
        Next
    End Sub

    Private Sub dgv_torneos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_torneos.CellContentClick
        btn_borrar.Enabled = True
        btn_editar.Enabled = True
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        ABM_Torneos.seleccionar_torneo(ABM_Torneos.Opcion.update, dgv_torneos.CurrentRow)
        ABM_Torneos.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class