Imports Microsoft.Reporting.WinForms
Public Class Reporte2
    Private Sub Reporte2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Torneos._Torneos' Puede moverla o quitarla según sea necesario.
        Me.TorneosTableAdapter.getTorneos(Me.Torneos._Torneos)
        cbo_torneos.SelectedValue = -1
        'TODO: esta línea de código carga datos en la tabla 'reporteResultados.ResultadosEquipos' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub cbo_torneos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_torneos.SelectedIndexChanged
        rpv_resultados.LocalReport.SetParameters({New ReportParameter("nombreTorneo", cbo_torneos.Text.ToString)})
        Me.ResultadosEquiposTableAdapter.verResultados(Me.reporteResultados.ResultadosEquipos, cbo_torneos.SelectedValue)
        Me.rpv_resultados.RefreshReport()
    End Sub
End Class